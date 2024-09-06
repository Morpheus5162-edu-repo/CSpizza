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
            // Determine the pizza type and set price and ingredients
            if(!Rddeluxe.Checked && !RdPromo.Checked && !RdSpecial.Checked)
            {
                MessageBox.Show("Please select a pizza type.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price = double.Parse(TxtPrice.Text);
            int quantity = int.Parse(TxtQuantity.Text);

            // Calculate the total bill
            double totalBill = price * quantity;

            // Display the total bill in the Bill textbox
            TxtBill.Text = totalBill.ToString("C2"); // C2 formats as currency
        }

        private void Rddeluxe_CheckedChanged(object sender, EventArgs e)
        {
            // Deluxe Pizza - P 185 pesos
            TxtPrice.Text = 185.ToString();
            TxtQuantity.Text = 1.ToString();
            Ckbcheese.Checked = true;
            Ckbbaconham.Checked = true;
            Ckbmushroom.Checked = false;
            CkbOnions.Checked = true;
            Ckbtomato.Checked = false;
            Ckbpepper.Checked = true; // Assuming "Chili" is represented as "Pepper"
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
            Ckbpepper.Checked = true; // Assuming "Chili" is represented as "Pepper"
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
            Ckbpepper.Checked = true; // Assuming "Chili" is represented as "Pepper"
        }
    }
}
