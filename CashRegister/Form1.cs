using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister
{
    public partial class HappyLittleFrogShop : Form
    {
        public HappyLittleFrogShop()
        {
            InitializeComponent();
        }

        //global variables
        int frogNum, toadNum, lilypadNum;
        double subtotal, tax, total, taxRate, frogPrice, toadPrice, lilypadPrice, frogCost, toadCost, lilypadCost, amountTendered, change;

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //re-initialize all variables
            frogNum = 0;
            toadNum = 0;
            lilypadNum = 0;
            subtotal = 0;
            tax = 0;
            total = 0;
            taxRate = 0;
            frogPrice = 0;
            toadPrice = 0;
            lilypadPrice = 0;
            frogCost = 0;
            toadCost = 0;
            lilypadCost = 0;
            amountTendered = 0;
            change = 0;

            //reset outputs
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            changeOutput.Text = "";

            //reset inputs
            frogsInput.Text = "";
            toadsInput.Text = "";
            lilypadsInput.Text = "";
            tenderedInput.Text = "";

            //hide buttons, receipt, & goodbye message
            tenderedLabel.Visible = false;
            tenderedInput.Visible = false;
            changeLabel.Visible = false;
            changeOutput.Visible = false;
            changeButton.Visible = false;
            receiptbutton.Visible = false;
            newOrderButton.Visible = false;
            receiptTitleLabel.Visible = false;
            receiptOrderedLabel.Visible = false;
            receiptTotalsLabel.Visible = false;
            receiptEndLabel.Visible = false;
            receiptPricesLabel.Visible = false;
            frogPicturebox.Visible = false;
            goodbyeLabel.Visible = false;
        }

        private void totalsButton_Click(object sender, EventArgs e)
        {
            try
            {
                //calculate
                frogPrice = 4.33;
                toadPrice = 5.55;
                lilypadPrice = 2.27;
                frogNum = Convert.ToInt32(frogsInput.Text);
                toadNum = Convert.ToInt32(toadsInput.Text);
                lilypadNum = Convert.ToInt32(lilypadsInput.Text);
                frogCost = frogNum * frogPrice;
                toadCost = toadNum * toadPrice;
                lilypadCost = lilypadNum * lilypadPrice;
                subtotal = frogCost + toadCost + lilypadCost;
                taxRate = 0.13;
                tax = subtotal * taxRate;
                total = subtotal + tax;

                //output
                subtotalOutput.Text = subtotal.ToString("C");
                taxOutput.Text = tax.ToString("C");
                totalOutput.Text = total.ToString("C");

                //make paying available
                tenderedLabel.Visible = true;
                tenderedInput.Visible = true;
                changeButton.Visible = true;
                changeLabel.Visible = true;
                changeOutput.Visible = true;
            }
            catch
            {
                frogsInput.Text = "";
                toadsInput.Text = "";
                lilypadsInput.Text = "";
                totalsErrorLabel.Text = $"ERROR\nPlease enter a number";
            }
        }

        
        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //calculate change
                amountTendered = Convert.ToInt32(tenderedInput.Text);
                change = amountTendered - total;

                //output
                changeOutput.Text = change.ToString("C");

                //make receipt available
                receiptbutton.Visible = true;
            }
            catch
            {
                tenderedInput.Text = "";
                changeErrorLabel.Text = $"Error: Please enter a number";
            }

        }
    
        private void receiptbutton_Click(object sender, EventArgs e)
        {
            //receipt printing sound?
            
            //print receipt title
            receiptTitleLabel.Text = "The Happy Frog Shop";
            receiptTitleLabel.Visible = true;

            //sleep?

            //print receipt body
            receiptOrderedLabel.Visible = true;
            receiptOrderedLabel.Text = $"   Frog    x{frogNum}\n   Toad    x{toadNum}\n   Lilypad x{lilypadNum}";
            receiptPricesLabel.Visible = true;
            receiptPricesLabel.Text = $"{frogCost.ToString("C")}\n{toadCost.ToString("C")}\n{lilypadCost.ToString("C")}";

            //sleep?

            //print receipt end
            receiptEndLabel.Visible = true;
            receiptEndLabel.Text = $"   Subtotal\n   HST\n   Total\n\n   Amount Tendered\n   Change\n";
            receiptTotalsLabel.Visible = true;
            receiptTotalsLabel.Text = $"{subtotal.ToString("C")}\n{tax.ToString("C")}\n{total.ToString("C")}\n\n{amountTendered.ToString("C")}\n{change.ToString("C")}";

            //sleep?

            //print goodbye message
            frogPicturebox.Visible = true;
            goodbyeLabel.Visible = true;
            newOrderButton.Visible = true;


        }
    }
}
