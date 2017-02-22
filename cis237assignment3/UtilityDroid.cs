using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class UtilityDroid : Droid
    {
        protected bool _hasToolbox;
        protected bool _hasComputerConnection;
        protected bool _hasArm;
        private decimal _totalCost;

        public UtilityDroid(string materialString, string modelString, string colorString, bool hasToolbox, bool hasComputerConnection, bool hasArm) 
            : base (materialString, modelString, colorString)
        {
            _hasToolbox = hasToolbox;
            _hasComputerConnection = hasComputerConnection;
            _hasArm = hasArm;

            CalculateTotalCost();
        }

        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        public override string ToString()
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

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            this.TotalCost = base.TotalCost;

            if (_hasToolbox)
            {
                this.TotalCost += 100;
            }

            if (_hasComputerConnection)
            {
                this.TotalCost += 500;
            }

            if (_hasArm)
            {
                this.TotalCost += 250;
            }
        }
    }
}
