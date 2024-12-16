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
        }

        public void AddFoodItem(FoodItem food)
        {
            OrderedFood.Add(food);
        }

        public void CalculateBill()
        {
            float billCost = 0;

            foreach (var item in OrderedFood)
            {
                if (item.Equals(Meal))
                {
                    // Add appropriate value
                }

                if (item.Equals(Beverage))
                {
                    //Add appropriate value
                }
            }
        }
    }
}
