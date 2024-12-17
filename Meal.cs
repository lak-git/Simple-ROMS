using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_ROMS
{
    internal class Meal : FoodItem
    {
        private const double ValueAddedTax = 1.18; //18% Vat
        public Meal(string name, double baseprice) : base(name, baseprice) { }

        public override double CalculatePrice()
        {
            return Price * ValueAddedTax;
        }
    }
}
