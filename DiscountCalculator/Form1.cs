using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscountCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            string itemS = itemBox.Text; //the cost of the item entered by the user
            string discountS = discountBox.Text; //% discount entered by the user
            
            double item; //original cost of the item
            double discount; //%discount of item


            /* checks to see if both the cost of the item and the % discount entered by the use are really numbers and text or something else. 
             * if they are the tryParse assigns the values to the item and discount variables. Otherwise it displays "Not a number"
             */
            if(Double.TryParse(itemS, out item) && Double.TryParse(discountS, out discount))
            {
                discount = item * discount / 100; //calculates the ammount of money discounted
                item = item - discount; //calculates new cost of item after discount

                newCost.Text = item.ToString("C"); //displays cost of item after discount in the format of currency
            }
            else //if either itemS or discountS can not be converted to numbers displays "Not a number"
            {
                newCost.Text = "Not a number";
            }


            
        }
    }
}
