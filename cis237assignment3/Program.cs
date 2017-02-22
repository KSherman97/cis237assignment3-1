using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = Int16.MaxValue - 1;  // resets the console bufferhieght to allow the entire file
            // to be read into a single console window
            Console.SetWindowSize(150, 30);             // resizes the window to fit the special output formatting
            UserInterface userInterface = new UserInterface();
            userInterface.MainMenu();
        }
    }
}
