using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_ROMS
{
    public partial class RestaurantBillingApp : Form
    {
        public RestaurantBillingApp()
        {
            InitializeComponent();
            PopulateMenu();
        }

        private void PopulateMenu()
        {
            listBoxMenu.Items.Add("Beverage: Coffee - $3.00");
            listBoxMenu.Items.Add("Beverage: Tea - $2.50");
            listBoxMenu.Items.Add("Meal: Burger - $8.00");
            listBoxMenu.Items.Add("Meal: Pizza - $10.00");
            listBoxMenu.Items.Add("Beverage: Soda - $2.00");
            listBoxMenu.Items.Add("Meal: Pasta - $9.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double total = 0; 

            foreach (string selectedItem in listBoxMenu.SelectedItems)
            {
                if (selectedItem.Contains("Coffee"))
                    total += 3.00 * 0.90; 
                else if (selectedItem.Contains("Tea"))
                    total += 2.50 * 0.90;
                else if (selectedItem.Contains("Soda"))
                    total += 2.00 * 0.90;
                else if (selectedItem.Contains("Burger"))
                    total += 8.00 * 1.18; 
                else if (selectedItem.Contains("Pizza"))
                    total += 10.00 * 1.18;
                else if (selectedItem.Contains("Pasta"))
                    total += 9.00 * 1.18;
            }

            lblTotalBill.Text = $"Total Bill: ${total:F2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RestaurantBillingApp_Load(object sender, EventArgs e)
        {

        }
    }
}
