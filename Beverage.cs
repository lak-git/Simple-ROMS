using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_ROMS
{
    // Inheritance
    internal class Beverage : FoodItem
    {
        private const double Discount = 0.9; // 10% discount
        public Beverage(string name, double baseprice) : base(name, baseprice) { }

        public override double CalculatePrice()
        {
            return Price * Discount;
        }
    }
}
