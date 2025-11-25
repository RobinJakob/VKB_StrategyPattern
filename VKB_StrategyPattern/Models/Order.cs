using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VKB_StrategyPattern.Strategies;

namespace VKB_StrategyPattern.Models
{
    public class Order
    {
        // Die aktuell gewählte Strategie
        private IShippingStrategy _shippingStrategy;

        public decimal OrderValue { get; set; }
        public decimal WeightInKg { get; set; }

        public Order(IShippingStrategy defaultStrategy)
        {
            // Setze eine Standardstrategie, um NullReferenceExceptions zu vermeiden
            _shippingStrategy = defaultStrategy ?? throw new ArgumentNullException(nameof(defaultStrategy));
        }

        /// <summary>
        /// Ermöglicht das Austauschen der Strategie zur Laufzeit.
        /// </summary>
        public void SetStrategy(IShippingStrategy strategy)
        {
            _shippingStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        /// <summary>
        /// Führt die Berechnung über die aktuelle Strategie aus.
        /// </summary>
        public decimal CalculateShipping()
        {
            return _shippingStrategy.CalculateCost(OrderValue, WeightInKg);
        }
    }
}
