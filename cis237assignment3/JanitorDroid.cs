using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class JanitorDroid : UtilityDroid
    {
        protected bool _hasTrashCompactor, _hasVacuum;
        private decimal _totalCost;

        public JanitorDroid(string materialString, string modelString, string colorString, bool hasToolbox, bool hasComputerConnection, bool hasArm, bool hasTrashCompactor, bool hasVacuum) 
            : base(materialString, modelString, colorString, hasToolbox, hasComputerConnection, hasArm)
        {
            _hasTrashCompactor = hasTrashCompactor;
            _hasVacuum = hasVacuum;

            CalculateTotalCost();

        }

        public decimal TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        public override string ToString()
        {
            string description = "";

            if (_hasTrashCompactor)
                description += "Trash Compactor, ";

            if (_hasVacuum)
                description += "Vacuum, ";

            return base.ToString() + description;
        }

        public override void CalculateTotalCost()
        {
            base.CalculateTotalCost();
            this._totalCost = base.TotalCost;

            if (_hasTrashCompactor)
                this._totalCost += 500;

            if (_hasVacuum)
                this._totalCost += 100;
        }
    }
}
