using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class AstromechDroid : UtilityDroid
    {
        protected bool _hasFireExtinguisher;
        protected int _numberOfShips;
        private decimal _totalCost;

        private const int COST_PER_SHIP = 1000;

        public AstromechDroid(string materialString, string modelString, string colorString, bool hasToolbox, bool hasComputerConnection, bool hasArm, bool hasFireExtinguisher, int numberOfShips) 
            : base(materialString, modelString, colorString, hasToolbox, hasComputerConnection, hasArm)
        {
            _hasFireExtinguisher = hasFireExtinguisher;
            _numberOfShips = numberOfShips;

            CalculateTotalCost();

        }

        public decimal CostOfShips
        {
            get { return _numberOfShips * COST_PER_SHIP; }
        }

        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            this._totalCost = base.TotalCost;

            if (_hasFireExtinguisher)
                this.TotalCost += 100;

            TotalCost += CostOfShips;
        }

    }
}
