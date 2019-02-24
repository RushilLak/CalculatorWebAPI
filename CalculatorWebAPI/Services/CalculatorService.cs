using CalculatorWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebAPI.Services
{
    public class CalculatorService: ICalculator
    {
    
        public float sum(CalculatorItem number)
        {
            var result = number.A + number.B;

            return result;
        }

        public float substract(CalculatorItem number)
        {
            var result = number.A - number.B;

            return result;
        }

        public float multiply(CalculatorItem number)
        {
            var result = number.A * number.B;

            return result;
        }

        public float divide(CalculatorItem number)
        {
            var result = number.A / number.B;

            return result;
        }

    }
}
