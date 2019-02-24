using CalculatorWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebAPI.Services
{
    public class CalculatorService: ICalculator
    {
    
        public float sum(float a, float b)
        {
            var result = a + b;

            return result;
        }

        public float substract(float a, float b)
        {
            var result = a- b;

            return result;
        }

        public float multiply(float a, float b)
        {
            var result = a * b;

            return result;
        }

        public float divide(float a, float b)
        {
            var result = a / b;

            return result;
        }

    }
}
