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
    class AstromechDroid : UtilityDroid
    {
    
        //*****************************************
        //*             Backing fields            *
        //*****************************************
        protected bool _hasFireExtinguisher;
        protected int _numberOfShips;
        private decimal _totalCost;

        private const int COST_PER_SHIP = 1000;

        //*****************************************
        //*             Constructor               *
        //*****************************************
        public AstromechDroid(string materialString, string modelString, string colorString, bool hasToolbox, bool hasComputerConnection, bool hasArm, bool hasFireExtinguisher, int numberOfShips) 
            : base(materialString, modelString, colorString, hasToolbox, hasComputerConnection, hasArm)
        {
            _hasFireExtinguisher = hasFireExtinguisher;
            _numberOfShips = numberOfShips;

            CalculateTotalCost();

        }

        //*****************************************
        //*             Properties                *
        //*****************************************
        public decimal CostOfShips
        {
            get { return _numberOfShips * COST_PER_SHIP; }
        }

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
            string description = "";

            if(_hasFireExtinguisher)
                description += "Fire Extinguisher, ";

            if(_numberOfShips > 0)
                description += " Number of Ships: " + _numberOfShips + ", ";

            return base.ToString() + description;
        }

        public override void CalculateTotalCost() // calculates the total cost
        {
            base.CalculateTotalCost();
            this._totalCost = base.TotalCost; // assigns the base total to the current total

            if (_hasFireExtinguisher) // checks to see if a fireextinguisher is added
            {
                this._totalCost += 100;
            }

            this.TotalCost += CostOfShips; // rolls the ship cose into the new total
        }

    }
}
