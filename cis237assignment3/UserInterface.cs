using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UserInterface
    {

        private DroidCollection droidCollection = new DroidCollection();

        public override string ToString()
        {
            return "Welcome to the EMPIRE DROID EMPORIUM";
        }

        //public static override string ToString()
        //{
        //    return "";
        //}

        private  int GetUserOption() 
        {
            PrintMainMenu();

            string userOptionString = Console.ReadLine();

            while(userOptionString != "1" && userOptionString != "2" && userOptionString != "3")
            {
                Console.Clear();
                Console.WriteLine("That is not a valid option.");
                Console.WriteLine("Press any key to continue");

                Console.ReadKey();
                Console.Clear();
                PrintMainMenu();
                userOptionString = Console.ReadLine();
            }

            try
            {
                return Int32.Parse(userOptionString);
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Input cannot be empty and must be a number");
                Console.WriteLine("Please try again.");
                return 0;
            }
        }

        private  void PrintMainMenu()
        {
            Console.WriteLine("EMPIRE DROID EMPORIUM");
            Console.WriteLine("1) CREATE A NEW DROID.");
            Console.WriteLine("2) VIEW ALL CURRENT DROIDS.");
            Console.WriteLine("3) EXIT.");
            Console.Write(Environment.NewLine + "What would you like to do? ");
        }

        public void MainMenu()
        {
            Console.Clear();

            int userChoice = GetUserOption();

            while(userChoice != 3)
            {
                if(userChoice == 1)
                {
                    Console.Clear();
                    modelOptions(); // call the modelOptions method
                    int model = Int32.Parse(Console.ReadLine());    // stores user input as an integer

                    materialOptions(); // call the materialOptions method
                    int material = Int32.Parse(Console.ReadLine()); // stores user input as an integer

                    colorOptions(); // call the colorOptions method
                    int color = Int32.Parse(Console.ReadLine()); // stores user input as an integer

                    if (model == 1) // if the user entered a 1 for the model
                    {
                        // call the add protocol droid method
                        addProtocol(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                    else if (model == 2) // if the user entered a 1 for the model
                    {
                        // call the add Utility droid method
                        addUtility(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                    else if (model == 3) // if the user entered a 1 for the model
                    {
                        // call the add Janitor droid method
                        addJanitor(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                    else if (model == 4) // if the user entered a 1 for the model
                    {
                        // call the add Astromech droid method
                        addAstromech(setModel(model), setMaterial(material), setColor(color), droidCollection);
                    }
                }
                if (userChoice == 2)
                {
                    Console.Clear();
                    outputDroidArray(); // call the output droid array method
                }

                Console.WriteLine("Press any Key to continue.");
                Console.ReadKey(); // wait for the user to press a key
                Console.Clear();
                userChoice = GetUserOption(); // prompt the user to enter some input again
            }
        }

        public  void modelOptions()
        {
            Console.Clear();
            Console.WriteLine("Select a Model: ");
            Console.WriteLine("1) protocol  - $100");
            Console.WriteLine("2) utility   - $250");
            Console.WriteLine("3) janitor   - $500");
            Console.WriteLine("4) astromech - $500");
        }

        public  void materialOptions()
        {
            Console.Clear();
            Console.WriteLine("Select a Material: ");
            Console.WriteLine("1) cerillium - $200");
            Console.WriteLine("2) Polyfibe  - $250");
            Console.WriteLine("3) Tekonite  - $500");
        }

        public void colorOptions()
        {
            Console.Clear();
            Console.WriteLine("Select a color: ");
            Console.WriteLine("1) red    - $200");
            Console.WriteLine("2) orange - $200");
            Console.WriteLine("3) gold   - $1000");
        }

        // this method comvers the model int input from the user into a string
        public  string setModel(int model)
        {
            switch (model)
            {
                case 1:
                    return "Protocol";
                    break;
                case 2:
                    return "Utility";
                    break;
                case 3:
                    return "Janitor";
                    break;
                case 4:
                    return "Astromech";
                    break;
                default:
                    return "";
                    break;
            }

        }

        // this method converts the material int input from the user into a string
        public string setMaterial(int material)
        {
            switch (material)
            {
                case 1:
                    return "Cerillium";
                    break;
                case 2:
                    return "Polyfibe";
                    break;
                case 3:
                    return "Tekonite";
                    break;
                default:
                    return "";
                    break;
            }
        }

        // this method converts the color int input from the user into a string
        public string setColor(int color)
        {
            switch (color)
            {
                case 1:
                    return "Red";
                    break;
                case 2:
                    return "Orange";
                    break;
                case 3:
                    return "Gold";
                    break;
                default:
                    return "";
                    break;
            }
        }

        // this method does the propper functions / calls to add a protocol droid
        public static void addProtocol(string model, string material, string color, DroidCollection droidCollection)
        {
            // prompt the user for language feature
            Console.Clear();
            Console.WriteLine("Language feature: $100 per language");
            Console.WriteLine("How many languages should the droid know? ");
            int numberOfLanguages = Int32.Parse(Console.ReadLine());

            // call the addDroid method in the droid collection class
            // pass parameters for protocol droid
            droidCollection.addDroid(model, material, color, numberOfLanguages);
        }

        // this method does the propper functions / calls to add a utility droid
        public static void addUtility(string model, string material, string color, DroidCollection droidCollection)
        {
            // initialize the required bools
            bool toolbox = false;
            bool computerConnection = false;
            bool arm = true;

            // prompt the user for toolbox
            Console.Clear();
            Console.WriteLine("toolbox feature: $100");
            Console.WriteLine("Would you like a toolbox? 1 = yes; 2 = no");
            int toolboxInt = Int32.Parse(Console.ReadLine());
            if (toolboxInt == 1)
                toolbox = true;

            // prompt the user for computer connection
            Console.WriteLine(Environment.NewLine + "Computer connection feature: $850");
            Console.WriteLine("Would you like a Computer Connection? 1 = yes; 2 = no");
            int computerConnectionInt = Int32.Parse(Console.ReadLine());
            if (computerConnectionInt == 1)
                computerConnection = true;

            // prompt the user for an arm
            Console.WriteLine(Environment.NewLine + "Arm feature: $600");
            Console.WriteLine("Would you like an arm? 1 = yes; 2 = no");
            int armInt = Int32.Parse(Console.ReadLine());
            if (armInt == 1)
                arm = true;

            // call the addDroid method in the droid collection class
            // pass parameters for utility droid
            droidCollection.addDroid(model, material, color, toolbox, computerConnection, arm);
        }

        // this method does the propper functions / calls to add a janitor droid
        public static void addJanitor(string model, string material, string color, DroidCollection droidCollection)
        {
            // initialize the required bools
            bool toolbox = false;
            bool computerConnection = false;
            bool arm = true;
            bool trashCompactor = false;
            bool vacuum = false;

            // prompt the user for toolbox
            Console.Clear();
            Console.WriteLine("toolbox feature: $100");
            Console.WriteLine("Would you like a toolbox? 1 = yes; 2 = no");
            int toolboxInt = Int32.Parse(Console.ReadLine());
            if (toolboxInt == 1)
                toolbox = true;

            // prompt the user for computer connection
            Console.WriteLine(Environment.NewLine + "Computer connection feature: $850");
            Console.WriteLine("Would you like a Computer Connection? 1 = yes; 2 = no");
            int computerConnectionInt = Int32.Parse(Console.ReadLine());
            if (computerConnectionInt == 1)
                computerConnection = true;

            // prompt the user for an arm
            Console.WriteLine(Environment.NewLine + "Arm feature: $600");
            Console.WriteLine("Would you like an arm? 1 = yes; 2 = no");
            int armInt = Int32.Parse(Console.ReadLine());
            if (armInt == 1)
                arm = true;

            // prompt the user for trash compactor feature
            Console.WriteLine(Environment.NewLine + "trash Compactor feature: $500");
            Console.WriteLine("Would you like an trash Compactor? 1 = yes; 2 = no");
            int trashCompactorInt = Int32.Parse(Console.ReadLine());
            if (trashCompactorInt == 1)
                trashCompactor = true;

            // prompt the user for vacuum feature
            Console.WriteLine(Environment.NewLine + "vacuum feature: $300");
            Console.WriteLine("Would you like an trash Compactor? 1 = yes; 2 = no");
            int vacuumInt = Int32.Parse(Console.ReadLine());
            if (vacuumInt == 1)
                vacuum = true;

            // call the addDroid method in the droid collection class
            // pass parameters for janitor droid
            droidCollection.addDroid(model, material, color, toolbox, computerConnection, arm, trashCompactor, vacuum);
        }

        // this method does the propper functions / calls to add an astromech droid
        public static void addAstromech(string model, string material, string color, DroidCollection droidCollection)
        {
            // initialize the required bools
            bool toolbox = false;
            bool computerConnection = false;
            bool arm = true;
            bool fireExtinguisher = false;

            // prompt the user for toolbox feature
            Console.Clear();
            Console.WriteLine("toolbox feature: $100");
            Console.WriteLine("Would you like a toolbox? 1 = yes; 2 = no");
            int toolboxInt = Int32.Parse(Console.ReadLine());
            if (toolboxInt == 1)
                toolbox = true;

            // prompt the user for computer connection feature
            Console.WriteLine(Environment.NewLine + "Computer connection feature: $850");
            Console.WriteLine("Would you like a Computer Connection? 1 = yes; 2 = no");
            int computerConnectionInt = Int32.Parse(Console.ReadLine());
            if (computerConnectionInt == 1)
                computerConnection = true;

            // prompt the user for arm feature
            Console.WriteLine(Environment.NewLine + "Arm feature: $600");
            Console.WriteLine("Would you like an arm? 1 = yes; 2 = no");
            int armInt = Int32.Parse(Console.ReadLine());
            if (armInt == 1)
                arm = true;

            // prompt the user for fire extinguisher feature
            Console.WriteLine(Environment.NewLine + "fire extinguisher feature: $200");
            Console.WriteLine("Would you like a fire extinguisher? 1 = yes; 2 = no");
            int fireExtinguisherInt = Int32.Parse(Console.ReadLine());
            if (fireExtinguisherInt == 1)
                fireExtinguisher = true;

            // prompt the user for ships feature
            Console.WriteLine(Environment.NewLine + "Ships feature: $300 per ship");
            Console.WriteLine("How many ships would you like? ");
            int numberOfShips = Int32.Parse(Console.ReadLine());

            // call the addDroid method in the droid collection class
            // pass parameters for astromech droid
            droidCollection.addDroid(model, material, color, toolbox, computerConnection, arm, fireExtinguisher, numberOfShips);
        }

        // outputs all of the droid data
        public void outputDroidArray()
        {
            Console.WriteLine();
            Console.Clear();
            // Get the output string from the droidCollection class's method:
            Console.WriteLine(droidCollection.outputDroidArray());
            Console.WriteLine();
        }
    }
}
