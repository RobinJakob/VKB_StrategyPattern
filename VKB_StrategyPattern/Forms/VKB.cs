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
    public partial class VKB : Form
    {
        private Product selectedProduct;

        public VKB()
        {
            InitializeComponent();
            selectedProduct = Controller.GetSelectedProduct();
            if (selectedProduct != null)
            {
                if (selectedProduct.price < 100m)
                {
                    radioButton1.Text = "Standardversand 5,00€";
                }
                else
                {
                    radioButton1.Text = "Standardversand 0,00€";
                }
                radioButton2.Text = "Expressversand 2€/kg";
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
