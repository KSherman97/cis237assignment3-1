/**
 * Kyle sherman
 * Assignment 3
 * DUE 2/22/2017
**/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// droid interface class
// creates the variables that must exist in the child classes
namespace cis237assignment3
{
    interface IDroid
    {
        void CalculateTotalCost(); // total cost void method

        decimal TotalCost { get; set; } // total cost decimal
    }
}
