using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class DroidCollection
    {
        IDroid[] droidArray = new Droid[100];

        int index = 0;

        public DroidCollection() { index = 0; }

        public void addDroid(string materialString, string modelString, string colorString, int numberOfLanguages)
        {
            droidArray[index] = new ProtocolDroid(materialString, modelString, colorString, numberOfLanguages);
            index++;
        }

        public void addDroid(string materialString, string modelString, string colorString, bool hasToolbox, bool hasComputerConnection, bool hasArm)
        {
            droidArray[index] = new UtilityDroid(materialString, modelString, colorString, hasToolbox, hasComputerConnection, hasArm);
            index++;
        }

        public void addDroid(string materialString, string modelString, string colorString, bool hasToolbox, bool hasComputerConnection, bool hasArm, bool hasTrashCompactor, bool hasVacuum)
        {
            droidArray[index] = new JanitorDroid(materialString, modelString, colorString, hasToolbox, hasComputerConnection, hasArm, hasTrashCompactor, hasVacuum);
            index++;
        }

        public void addDroid(string materialString, string modelString, string colorString, bool hasToolbox, bool hasComputerConnection, bool hasArm, bool hasFireExtinguisher, int numberOfShips)
        {
            droidArray[index] = new AstromechDroid(materialString, modelString, colorString, hasToolbox, hasComputerConnection, hasArm, hasFireExtinguisher, numberOfShips);
            index++;
        }

        // this method will collect all of the droid data and output it based on the type of droid
        public string outputDroidArray()
        {
            string allOutPut = "";  // creates a new blank string
            foreach (Droid droid in droidArray) // foreach loop for each droid in the array
            {
                if (droid != null)   // checks to see if the list is full or not 
                {
                    // for the type checking I opted to use the "is" expression because it looked the cleanest
                    // reference:   http://stackoverflow.com/questions/983030/type-checking-typeof-gettype-or-is
                    //              http://net-informations.com/q/faq/type.html
                    //              https://msdn.microsoft.com/en-us/library/scekt9xw.aspx

                    // is the droid of type Protocol?
                    if (droid is ProtocolDroid)
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((ProtocolDroid)droid).ToString() + " " +
                            ((ProtocolDroid)droid).TotalCost.ToString("c") + Environment.NewLine;
                    }
                    // is the droid of type Utility?
                    else if (droid is UtilityDroid)
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((UtilityDroid)droid).ToString() + " " +
                            ((UtilityDroid)droid).TotalCost.ToString("c") + Environment.NewLine;
                    }
                    // is the droid of type Janitor?
                    else if (droid is JanitorDroid)
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((JanitorDroid)droid).ToString() + " " +
                            ((JanitorDroid)droid).TotalCost.ToString("c") + Environment.NewLine;
                    }
                    // is the droid of type Astromech?
                    else if (droid is AstromechDroid)
                    {
                        // add the results of the ToString overrides to the alloutput string
                        allOutPut += ((AstromechDroid)droid).ToString() + " " +
                            ((AstromechDroid)droid).TotalCost.ToString("c") + Environment.NewLine;
                    }
                }
            }
            if (allOutPut == null || allOutPut == string.Empty) // checks to see if there is anything in the alloutput string
                allOutPut = "There are no droids to show";      // if it is empty or null then let the user know

            return allOutPut;   // return the alloutput final results
        }
    }
}
