using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKB_StrategyPattern.Strategies
{
    /// <summary>
    /// Strategie 2: Expressversand.
    /// Preis basiert rein auf dem Gewicht.
    /// </summary>
    public class ExpressShippingStrategy : IShippingStrategy
    {
        private readonly decimal _costPerKg;

        public ExpressShippingStrategy(decimal costPerKg = 2.00m)
        {
            _costPerKg = costPerKg;
        }

        public decimal CalculateCost(decimal orderValue, decimal weightInKg)
        {
            return weightInKg * _costPerKg;
        }
    }
}
