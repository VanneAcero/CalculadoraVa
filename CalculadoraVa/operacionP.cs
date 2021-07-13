using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraVa
{
    class operacionP
    {
        public decimal porcentaje (double num1, double num2)
        {
            double por;
            por = ((num1 * num2)/100);
            return (decimal)por;
        }
    }
}
