using CalculatorWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebAPI.Services
{
    public interface ICalculator
    {
        float sum(CalculatorItem number);
        float substract(CalculatorItem number);
        float multiply(CalculatorItem number);
        float divide(CalculatorItem number);
    }
}
