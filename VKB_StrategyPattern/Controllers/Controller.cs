using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKB_StrategyPattern.Models;

namespace VKB_StrategyPattern.Controllers
{
    internal static class Controller
    {
        private static Product selectedProduct;

        public static Product GetSelectedProduct()
        {
            return selectedProduct;
        }

        public static void SetSelectedProduct(Product product)
        {
            selectedProduct = product;
        }
    }
}
