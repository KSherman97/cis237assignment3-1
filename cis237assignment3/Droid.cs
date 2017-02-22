using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment3
{
    abstract class Droid : IDroid
    {
        protected string _materialString;
        protected string _modelString;
        protected string _colorString;

        protected decimal materialCost = 0;
        protected decimal modelCost = 0;
        protected decimal colorCost = 0;
        protected decimal _baseCost;
        private decimal _totalCost;

        public Droid(string modelString, string materialString, string colorString)
        {
            _modelString = modelString;
            _materialString = materialString;
            _colorString = colorString;

            CalculateTotalCost();
        }

        public string ModelString
        {
            get { return _modelString; }
            set { _modelString = value; }
        }

        public string MaterialString
        {
            get { return _materialString; }
            set { _modelString = value; }
        }

        public string ColorString
        {
            get { return _colorString; }
            set { _colorString = value; }
        }

        public decimal TotalCost {
            get { return _baseCost; }
            set { _baseCost = value; } 
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public virtual decimal CalculateBaseCost()
        {
            _baseCost = 0;
            _baseCost += CalculateModelCost();
            _baseCost += CalculateMaterialCost();
            _baseCost += CalculateColorCost();
            return _baseCost;
        }

        private decimal CalculateModelCost()
        {
            int modelCost = 0;

            if (ModelString == "Protocol")
                modelCost = 100;

            if (ModelString == "Utility")
                modelCost = 250;

            if (ModelString == "Astromech")
                modelCost = 500;

            if (ModelString == "Janitor")
                modelCost = 500;

            return modelCost;
        }
        
        private decimal CalculateMaterialCost()
        {
            int materialCost = 0;

            if (MaterialString == "Cerillium")
                materialCost = 200;

            if (MaterialString == "Polyfibe")
                materialCost = 250;

            if (MaterialString == "Tekonite")
                materialCost = 500;

            return materialCost;
        }

        private decimal CalculateColorCost()
        {
            int colorCost = 0;

            if (ColorString == "Red")
                colorCost = 200;

            if (ColorString == "Orange")
                colorCost = 200;

            if (ColorString == "Gold")
                colorCost = 1000;

            return colorCost;

        }

        public virtual void CalculateTotalCost()
        {
            _totalCost = CalculateBaseCost();
        }
    }
}
