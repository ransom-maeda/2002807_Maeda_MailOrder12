using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002807_Maeda_MailOrder12
{
    public class orderItems
    {
        public String quantityInput { get; set; }
        public String weightInput { get; set; }
        public String priceInput { get; set; }
        public String stateInput { get; set; }

        public orderItems(String quantity, String weight, String price, String state)
        {
            quantityInput = quantity;
            weightInput = weight;
            priceInput = price;
            stateInput = state;
        }

        private int quantity;
        private double price,
            weight;
        public double totalCharge = 0,
            totalSales = 0,
            handling,
            salesTax;

        public bool validateInputs()
        {
            // Return whether or not inputs are valid
            bool quantityResult = int.TryParse(quantityInput, out quantity);
            bool weightResult = double.TryParse(weightInput, out weight);
            bool priceResult = double.TryParse(priceInput, out price);

            if (quantityResult && weightResult && priceResult)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void calculate()
        {
            weight = quantity * int.Parse(weightInput);
            //calculates the handling charge
            if (weight < 10)
            {
                handling = 1.00;
            }
            else if (weight > 10 || weight < 100)
            {
                handling = 3.00;
            }
            else if (weight > 100)
            {
                handling = 5.00;
            }
            //checks if order is in California
            if (stateInput == "CA" || stateInput == "ca" || stateInput == "Ca" || stateInput == "cA")
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
    }
}
