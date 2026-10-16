using System;
using System.Collections.Generic;
using System.Linq;

namespace LuizHenrique.Exemplos
{
    public sealed class Calculator
    {
        public decimal Average(IEnumerable<decimal> values)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));
            var items = values.ToArray();
            if (items.Length == 0) throw new ArgumentException("Informe ao menos um valor.", nameof(values));
            return items.Average();
        }
    }
}
