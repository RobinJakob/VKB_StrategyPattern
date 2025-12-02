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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
