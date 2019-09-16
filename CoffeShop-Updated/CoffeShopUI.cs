using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShop_Updated
{
    public partial class CoffeShopUI : Form
    {
        const int size = 5;
        string[] customerName = new string[size];
        string[] contactNumber = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];
        int[] quantity = new int[size];
        int position = 0;
        string output = "";

        public CoffeShopUI()
        {
            InitializeComponent();
        }
        private void entryButton_Click(object sender, EventArgs e)
        {
            if (position < size)
            {
                customerName[position] = customerTextBox.Text;
                contactNumber[position] = contactTextBox.Text;
                address[position] = addressTextBox.Text;
                order[position] = orderComboBox.Text;
                quantity[position] = Convert.ToInt32(quantityTextBox.Text);
                position++;
            }
            else
            {
                MessageBox.Show("You Cannot add more than 5 person data");
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            for (int position = 0; position < size; position++)
            {
                if (orderComboBox.SelectedItem.ToString() == "Black")
                {
                    quantity[position] = ((quantity[position]) * 120);
                }
                else if (orderComboBox.SelectedItem.ToString() == "Cold")
                {
                    quantity[position] = ((quantity[position]) * 100);
                }
                else if (orderComboBox.SelectedItem.ToString() == "Hot")
                {
                    quantity[position] = ((quantity[position]) * 90);
                }
                else if (orderComboBox.SelectedItem.ToString() == "Regular")
                {
                    quantity[position] = ((quantity[position]) * 80);
                }
                else
                {
                    MessageBox.Show("Select an item");
                }
                output += "Customer Name: " + customerName[position] + "\n" + "Customer No: " + contactNumber[position] + "\n" + "Address: " + address[position] + "\n" + "Order: " + order[position] + "\n" + "Price: " + quantity[position] + "\n" + "\n";
            }


            outputRichBox.Text = output;
        }
    }
}
