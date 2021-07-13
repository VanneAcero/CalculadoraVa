using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraVa
{
    class operacionD
    {
        public decimal Divide(double num1, double num2)
        {
            double div;
            div = num1 / num2;
            return (decimal)div;
        }
    }
}
