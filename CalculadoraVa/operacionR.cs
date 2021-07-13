using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraVa
{
    class operacionR
    {
        public decimal Resta(double num1, double num2)
        {
            double rest;
            rest = num1 - num2;
            return (decimal)rest;
        }
    }
}
