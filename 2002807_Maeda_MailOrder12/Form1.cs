using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2002807_Maeda_MailOrder12;

namespace _2002807_Maeda_MailOrder12
{
    public partial class Form1 : Form
    {

        List<customerInfo> customers { get; set; } = new List<customerInfo>();

        
        //imports variables
        private int quantity;
        private double price,
            weight,
            salesTax,
            totalCharge = 0,
            totalSales = 0,
            handling;
        private string p,
            w,
            q;

        public Form1()
        {
            InitializeComponent();
            //sets summary textboxes to readonly
            totalAmountOutput.ReadOnly = true;
            salesTaxOutput.ReadOnly = true;
            amountDueOutput.ReadOnly = true;
            handlingOutput.ReadOnly = true;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void Orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerInfo cusInfo = customers[Customers.SelectedIndex];

            customerInformation ciDlg = new customerInformation();
            ciDlg.SelectedCustomer = cusInfo;
            ciDlg.ShowDialog();
        }

        private void addThisItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name = nameInput.Text;
            String address = addressInput.Text;
            String city = cityInput.Text;
            String state = stateInput.Text;
            String zipCode = zipInput.Text;
            String quantity = quantityInput.Text;
            String weight = weightInput.Text;
            String price = priceInput.Text;

            customerInfo cusInfo = new customerInfo(name, address, city, state, zipCode);

            customers.Add(cusInfo);

            Customers.Items.Add(cusInfo.name);

            //Create order item
            orderItems orderItems = new orderItems(quantity, weight, price, state);

            //Validate order inputs
            if (orderItems.validateInputs() == true)
            {
                //Call order item calcuation
                orderItems.calculate();

                customerInfo ciDlg = new customerInfo(name, address, city, state, zipCode);
                totalAmountOutput.Text = orderItems.totalCharge.ToString("C");
                salesTaxOutput.Text = orderItems.salesTax.ToString("C");
                handlingOutput.Text = orderItems.handling.ToString("C");
                amountDueOutput.Text = orderItems.totalSales.ToString("C");


            }
            else
            {
                MessageBox.Show("Please enter a valid input", "Error");
            }
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clears all values
            totalAmountOutput.Clear();
            salesTaxOutput.Clear();
            amountDueOutput.Clear();
            handlingOutput.Clear();
            quantity = 0;
            weight = 0;
            price = 0;
            totalCharge = 0;
            totalSales = 0;
        }

        //selects font and color
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectFont();
            totalAmountOutput.ForeColor = fontChange.Color;
        }

        private void selectFont()
        {
            fontChange.ShowDialog();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectColor();
            this.ForeColor = colorChange.Color;
        }

        private void selectColor()
        {
            colorChange.ShowDialog();
        }

        //message box to display program name and programmer
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            info box = new info();
            box.ShowDialog();
        }
    }
}
