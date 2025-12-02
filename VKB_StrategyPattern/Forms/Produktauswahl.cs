using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VKB_StrategyPattern.Controllers;
using VKB_StrategyPattern.Models;

namespace VKB_StrategyPattern
{
    public partial class Produktauswahl : Form
    {
        Product selectedProduct;

        public Produktauswahl()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Bitte wählen Sie ein Produkt aus.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Controller.SetSelectedProduct(selectedProduct);
                VKB vkb = new VKB();
                vkb.ShowDialog();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                selectedProduct = new Product("10L Leitungswasser", 20.0m, 10.0m);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                selectedProduct = new Product("10L Mineralwasser", 75.0m, 10.01m);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                selectedProduct = new Product("1L Kristallwasser", 259.99m, 1.02m);
            }
        }
    }
}
