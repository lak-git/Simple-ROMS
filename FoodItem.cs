using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_ROMS
{
    // Abstraction and Encapsulation
    public abstract class FoodItem 
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public FoodItem(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public abstract double CalculatePrice();

        public override string ToString()
        {
            return $"{Name}: ${CalculatePrice(): 0}";
        }

    }
}
