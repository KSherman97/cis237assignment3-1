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
    class JanitorDroid : UtilityDroid
    {
        //*****************************************
        //*             Backing fields            *
        //*****************************************
        protected bool _hasTrashCompactor, _hasVacuum;
        private decimal _totalCost;

        //*****************************************
        //*             Constructor               *
        //*****************************************
        public JanitorDroid(string materialString, string modelString, string colorString, bool hasToolbox, bool hasComputerConnection, bool hasArm, bool hasTrashCompactor, bool hasVacuum) 
            : base(materialString, modelString, colorString, hasToolbox, hasComputerConnection, hasArm)
        {
            _hasTrashCompactor = hasTrashCompactor;
            _hasVacuum = hasVacuum;

            CalculateTotalCost();

        }

        //*****************************************
        //*            Properties                 *
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
            string description = "";

            if (_hasTrashCompactor)
                description += "Trash Compactor, ";

            if (_hasVacuum)
                description += "Vacuum, ";

            return base.ToString() + description;
        }

        public override void CalculateTotalCost() // calculates the total cost for the droid
        {
            base.CalculateTotalCost();
            this._totalCost = base.TotalCost; // assigns the base total to the current total

            if (_hasTrashCompactor) // checks to see if a Trash Compactor is added
                this._totalCost += 500;

            if (_hasVacuum)  // checks to see if a vacuum has been added
                this._totalCost += 100; 
        }
    }
}
