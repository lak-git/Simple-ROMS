using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_ROMS
{
    internal class Beverage : FoodItem
    {
        public Beverage(string name, float baseprice) : base(name, baseprice) { }

        public override float CalculatePrice()
        {
            return Price * 0.9f;
        }
    }
}
