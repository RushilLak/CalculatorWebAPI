using CalculatorWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebAPI.Services
{
    public class CalculatorService: ICalculator
    {
    
        public float sum(CalculatorItem a, CalculatorItem b)
        {
            var result = a.Number + b.Number;

            return result;
        }

        public float substract(CalculatorItem a, CalculatorItem b)
        {
            var result = a.Number - b.Number;

            return result;
        }

    }
}
