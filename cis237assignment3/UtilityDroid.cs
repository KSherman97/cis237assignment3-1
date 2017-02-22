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

namespace cis237assignment3
{
    class UtilityDroid : Droid
    {
        //*****************************************
        //*             Backing fields            *
        //*****************************************
        protected bool _hasToolbox;
        protected bool _hasComputerConnection;
        protected bool _hasArm;
        private decimal _totalCost;

        //*****************************************
        //*             Constructor               *
        //*****************************************
        public UtilityDroid(string materialString, string modelString, string colorString, bool hasToolbox, bool hasComputerConnection, bool hasArm) 
            : base (materialString, modelString, colorString)
        {
            _hasToolbox = hasToolbox;
            _hasComputerConnection = hasComputerConnection;
            _hasArm = hasArm;

            CalculateTotalCost();
        }

        //*****************************************
        //*             Properties                *
        //*****************************************
        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        //*****************************************
        //*             Methods                   *
        //*****************************************
        public override string ToString() // override for the ToString method
        {
            string description = " Extra features: ";

            if(_hasToolbox)
                description += "Toolbox, ";

            if(_hasComputerConnection)
                description += "Computer Connection, ";

            if(_hasArm)
                description += "Arm, ";

            return base.ToString() + description;
        }

        public override void CalculateTotalCost()  // calculates the total cost for the droid
        {
            base.CalculateTotalCost();
            this.TotalCost = base.TotalCost; // assigns the base total to the current total

            if (_hasToolbox) // checks to see if a toolbox is added
            {
                this.TotalCost += 100;
            }

            if (_hasComputerConnection) // checks to see if a computer connection is added
            {
                this.TotalCost += 500;
            }

            if (_hasArm) // checks to see if an arm has been added
            {
                this.TotalCost += 250;
            }
        }
    }
}
