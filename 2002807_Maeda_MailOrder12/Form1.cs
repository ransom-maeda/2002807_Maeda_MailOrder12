using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002807_Maeda_MailOrder12
{
    public partial class Form1 : Form
    {

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


        private void updateSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pushes values to UI
            totalAmountOutput.Text = totalCharge.ToString("C");
            salesTaxOutput.Text = salesTax.ToString("C");
            amountDueOutput.Text = totalSales.ToString("C");
            handlingOutput.Text = handling.ToString("C");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //closes form
            this.Close();
        }

        private void addThisItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                q = quantityInput.Text;
                bool quantityResult = int.TryParse(q, out quantity);
                if(quantityResult == true)
                {
                    w = weightInput.Text;
                    bool weightResult = double.TryParse(w, out weight);
                    if(weightResult == true)
                    {
                        p = priceInput.Text;
                        bool priceResult = double.TryParse(p, out price);
                        if(priceResult == true)
                        {
                            weight = quantity * int.Parse(weightInput.Text);
                            //calculates the handling charge
                            if (weight < 10)
                            {
                                handling = 1.00;
                            }
                            else if(weight > 10 || weight  < 100)
                            {
                                handling = 3.00;
                            }
                            else if(weight > 100)
                            {
                                handling = 5.00;
                            }
                            //checks if order is in California
                            if (stateInput.Text == "CA" || stateInput.Text == "ca" || stateInput.Text == "Ca" || stateInput.Text == "cA")
                            {
                                salesTax = 0.08 * (price * quantity);
                            }
                            else
                            {
                                salesTax = 0;
                            }
                            //calculates stuff
                            totalSales += price * quantity;
                            totalCharge += (price * quantity) + handling + salesTax;
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid input", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid input", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid input", "Error");
                }
            }
            catch
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
            MessageBox.Show("Program Name - Mail Order 12\n Programmer - Ransom Maeda");
        }
    }
}
