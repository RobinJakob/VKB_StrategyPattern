using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKB_StrategyPattern.Models
{
    public class Product
    {
        public string productName { get; set; }
        public decimal price { get; set; }
        public decimal weightInKg { get; set; }
        public Product(string productName, decimal price, decimal weightInKg)
        {
            this.productName = productName;
            this.price = price;
            this.weightInKg = weightInKg;
        }
    }
}
