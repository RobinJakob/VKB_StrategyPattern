using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKB_StrategyPattern.Strategies
{
    /// <summary>
    /// Strategie 3: Kostenlos ab Schwellenwert.
    /// </summary>
    public class FreeShippingThresholdStrategy : IShippingStrategy
    {
        private readonly decimal _threshold;
        private readonly decimal _fallbackCost;

        public FreeShippingThresholdStrategy(decimal threshold = 100.00m, decimal fallbackCost = 5.00m)
        {
            _threshold = threshold;
            _fallbackCost = fallbackCost;
        }

        public decimal CalculateCost(decimal orderValue, decimal weightInKg)
        {
            // Wenn Schwellenwert erreicht: 0 Euro.
            // Sonst: Fallback (z.B. Standardpreis), da Versand nie "nichts" kostet, 
            // wenn man die Bedingung nicht erfüllt.
            return orderValue >= _threshold ? 0m : _fallbackCost;
        }
    }
}
