using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKB_StrategyPattern.Strategies
{
    public interface IShippingStrategy
    {
        /// <summary>
        /// Berechnet die Versandkosten basierend auf den Bestelldaten.
        /// </summary>
        /// <param name="orderValue">Der Warenwert in Euro.</param>
        /// <param name="weightInKg">Das Gewicht in Kilogramm.</param>
        /// <returns>Die berechneten Versandkosten.</returns>
        decimal CalculateCost(decimal orderValue, decimal weightInKg);
    }
}
