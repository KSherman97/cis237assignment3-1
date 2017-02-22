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
    class ProtocolDroid : Droid
    {
        //*****************************************
        //*             Backing fields            *
        //*****************************************
        private const int COST_PER_LANGUAGE = 100;
        protected int _numberOfLanguages;
        private decimal _totalCost;

        //*****************************************
        //*             Constructor               *
        //*****************************************
        public ProtocolDroid(string materialString, string modelString, string colorString, int numberOfLanguages) : base (materialString, modelString, colorString)
        {
            _numberOfLanguages = numberOfLanguages;
            CalculateTotalCost();
        }

        //*****************************************
        //*             Properties                *
        //*****************************************
        public int LanguagesCost
        {
            get { return _numberOfLanguages * COST_PER_LANGUAGE; }
        }

        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        //*****************************************
        //*             Methods                   *
        //*****************************************
        public override string ToString() // tostring method override
        {
            string description = "";
            if(_numberOfLanguages > 0)
                description = " Extra features: Number Of Lanuges: " + _numberOfLanguages + ", ";

            return base.ToString() + description;
        }

        public override void CalculateTotalCost() // calculates the total cost for the droid
        {
            base.CalculateTotalCost();
            this._totalCost = base.TotalCost; // assigns the base total to the current total

            this.TotalCost += LanguagesCost; // rolls the cost of the number of languages into the total
        }
    }
}
