using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSpizza
{
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int quantity;
            bool isQuantityValid = int.TryParse(TxtQuantity.Text, out quantity);

            // Error if a pizza type isn't selected
            if(!Rddeluxe.Checked && !RdPromo.Checked && !RdSpecial.Checked)
            {
                MessageBox.Show("Please select a pizza type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Error if the quantity is empty
            if (!isQuantityValid)
            {
                MessageBox.Show("Input Quantity!", "Quantity Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Error if the quantity is less than 1
            if (quantity < 1)
            {
                MessageBox.Show("Quantity should be greater than 0.", "Quantity Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price = double.Parse(TxtPrice.Text);

            // Calculate the total bill
            double totalBill = price * quantity;

            // Display the total bill in the Bill textbox
            TxtBill.Text = totalBill.ToString("C2"); // C2 formats as currency
        }

        private void Rddeluxe_CheckedChanged(object sender, EventArgs e)
        {
            // When the radio is selected, the price and quantity is
            // set to P185 pesos and 1 respectively. 
            TxtPrice.Text = 185.ToString();
            TxtQuantity.Text = 1.ToString();
            Ckbcheese.Checked = true;
            Ckbbaconham.Checked = true;
            Ckbmushroom.Checked = false;
            CkbOnions.Checked = true;
            Ckbtomato.Checked = false;
            Ckbpepper.Checked = true;
        }

        private void RdSpecial_CheckedChanged(object sender, EventArgs e)
        {
            // Special Pizza - P 250 pesos
            TxtPrice.Text = 250.ToString();
            TxtQuantity.Text = 1.ToString();
            Ckbcheese.Checked = true;
            Ckbbaconham.Checked = true;
            Ckbmushroom.Checked = true;
            CkbOnions.Checked = true;
            Ckbtomato.Checked = false;
            Ckbpepper.Checked = true;
        }

        private void RdPromo_CheckedChanged(object sender, EventArgs e)
        {
            // Promo Pizza - P 290 pesos
            TxtPrice.Text = 290.ToString();
            TxtQuantity.Text = 1.ToString();
            Ckbcheese.Checked = true;
            Ckbbaconham.Checked = true;
            Ckbmushroom.Checked = true;
            CkbOnions.Checked = true;
            Ckbtomato.Checked = true;
            Ckbpepper.Checked = true;
        }
    }
}
