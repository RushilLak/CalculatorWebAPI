using CalculatorWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebAPI.Services
{
    public interface ICalculator
    {
        float sum(float a, float b);
        float substract(float a, float b);
    }
}
