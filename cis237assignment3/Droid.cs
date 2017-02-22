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

            //CalculateTotalCost();
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
            get { return _totalCost; }
            set { _totalCost = value; } 
        }

        public override string ToString()
        {
            return "Model: " + ModelString + " Color: " + ColorString + " Material: " + MaterialString;
        }

        public virtual void CalculateBaseCost()
        {
            _baseCost += CalculateModelCost();
            _baseCost += CalculateMaterialCost();
            _baseCost += CalculateColorCost();
        }

        private decimal CalculateModelCost()
        {
            decimal modelCost = 0;

            if (ModelString == "Protocol")
                modelCost = 100;

            else if (ModelString == "Utility")
                modelCost = 250;

            else if (ModelString == "Astromech")
                modelCost = 500;

            else if (ModelString == "Janitor")
                modelCost = 500;

            return modelCost;
        }
        
        private decimal CalculateMaterialCost()
        {
            decimal materialCost = 0;

            if (MaterialString == "Cerillium")
                materialCost = 200;

            else if (MaterialString == "Polyfibe")
                materialCost = 250;

            else if (MaterialString == "Tekonite")
                materialCost = 500;

            return materialCost;
        }

        private decimal CalculateColorCost()
        {
            decimal colorCost = 0;

            if (ColorString == "Red")
                colorCost = 200;

            else if (ColorString == "Orange")
                colorCost = 200;

            else if (ColorString == "Gold")
                colorCost = 1000;

            return colorCost;

        }

        public virtual void CalculateTotalCost()
        {
            CalculateBaseCost();
            this._totalCost = _baseCost;
        }
    }
}
