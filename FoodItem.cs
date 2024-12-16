using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_ROMS
{
    public abstract class FoodItem
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public FoodItem(string name, float price)
        {
            this.Name = name;
            this.Price = price;
        }

        public abstract float CalculatePrice();

        public override string ToString()
        {
            return $"{Name}: ${CalculatePrice(): 0}";
        }

    }
}
