using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKB_StrategyPattern.Strategies
{
    /// <summary>
    /// Strategie 1: Standardversand.
    /// Fester Preis, unabhängig von Gewicht oder Wert.
    /// </summary>
    public class StandardShippingStrategy : IShippingStrategy
    {
        private readonly decimal _flatRate;

        public StandardShippingStrategy(decimal flatRate = 5.00m)
        {
            _flatRate = flatRate;
        }

        public decimal CalculateCost(decimal orderValue, decimal weightInKg)
        {
            return _flatRate;
        }
    }
}
