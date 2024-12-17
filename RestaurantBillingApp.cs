using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_ROMS
{
    public partial class RestaurantBillingApp : Form
    {
        private List<FoodItem> menuItems;
        public RestaurantBillingApp()
        {
            InitializeComponent();
            PopulateMenu();
        }

        private void PopulateMenu()
        {
            // Polymorphism
            menuItems = new List<FoodItem>
            {
                new Meal("Pizza", 10.0),
                new Meal("Burger", 8.0),
                new Meal("Pasta", 9.0),
                new Beverage("Coffee", 3.0),
                new Beverage("Tea", 2.5),
                new Beverage("Soda", 9.0)
            };

            foreach (FoodItem item in menuItems) 
            {
                listBoxMenu.Items.Add($"{item.Name} - ${item.Price:F2}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var order = new Order();

            foreach (int selectedIndex in listBoxMenu.SelectedIndices) 
            {
                Console.WriteLine($"Selected Index: {selectedIndex}");
                order.AddFoodItem(menuItems[selectedIndex]);
            }

            DisplayOrder(order);

        }

        private void DisplayOrder(Order order)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Customer Order:");

            foreach (var item in order.OrderedFood) 
            { 
                sb.AppendLine($"{item.Name}: ${item.CalculatePrice():F2}");
            }
            sb.AppendLine($"Total Bill: ${order.CalculateBill():F2}");

            OrderSummary.Text = sb.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RestaurantBillingApp_Load(object sender, EventArgs e)
        {

        }
    }
}
