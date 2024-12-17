using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_ROMS
{
    internal class Order
    {
        public List<FoodItem> OrderedFood { get; set; }

        public Order()
        {
            OrderedFood = new List<FoodItem>();
        }

        public void AddFoodItem(FoodItem food)
        {
            if (food != null) // Null check for safety
            {
                OrderedFood.Add(food);
            }
        }

        public double CalculateBill()
        {
            double billAmount = 0;

            foreach (var item in OrderedFood)
            {
                billAmount += item.CalculatePrice();
            }

            return billAmount;
        }
    }
}
