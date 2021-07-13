using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraVa
{
    class operacionM
    {
        public decimal Multiplica(double num1, double num2)
        {
            double mult;
            mult = num1 * num2;
            return (decimal)mult;
        }
    }
}
