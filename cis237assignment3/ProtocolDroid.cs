using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    class ProtocolDroid : Droid
    {
        private const int COST_PER_LANGUAGE = 100;
        protected int _numberOfLanguages;
        private decimal _totalCost;


        public ProtocolDroid(string materialString, string modelString, string colorString, int numberOfLanguages) : base (materialString, modelString, colorString)
        {
            _numberOfLanguages = numberOfLanguages;
            CalculateTotalCost();
        }

        public int LanguagesCost
        {
            get { return _numberOfLanguages * COST_PER_LANGUAGE; }
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

            _totalCost += LanguagesCost;
        }
    }
}
