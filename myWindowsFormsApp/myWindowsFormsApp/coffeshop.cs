using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myWindowsFormsApp
{
    public partial class coffeshop : Form

    {
        const int size = 10;
        int index = 0;
        string[] customerName = new string[size];
        string[] customercontact = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];

        int[] quantity = new int[size];
        public coffeshop()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int totalPrice = 0;
            if (size > index)
            {
                customerName[index] = NametTextBox.Text;
                customercontact[index] = contactTextBox.Text;
                address[index] = addressTextBox.Text;
                order[index] = orderComboBox.Text;
                quantity[index] = Convert.ToInt32(quantityTextbox.Text);
                //index++;
            }

            if (order[index] == "Black")
            {
                totalPrice = quantity[index] * 120;
            }
            else if (order[index] == "Cold")
            {
                totalPrice = quantity[index] * 100;
            }
            else if (order[index] == "Hot")
            {
                totalPrice = quantity[index] * 90;
            }
            else if (order[index] == "Regular")
            {
                totalPrice = quantity[index] * 80;
            }
            richTextBox.AppendText("\nName: " + customerName[index]
                    + "\nContact: " + customercontact[index] + "\nAddress: " + address[index]
                    + "\nOrder: " + order[index] + "\nQuantity: " + quantity[index]
                    + "\nTotal Price " + totalPrice);

            NametTextBox.Text = " ";
            contactTextBox.Text = " ";
            addressTextBox.Text = " ";
            orderComboBox.Text = "Select An Item";
            quantityTextbox.Text = " ";

        }
    }
}
