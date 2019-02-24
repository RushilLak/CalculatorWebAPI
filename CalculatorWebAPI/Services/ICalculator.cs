﻿using CalculatorWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorWebAPI.Services
{
    public interface ICalculator
    {
        float sum(CalculatorItem a);
        float substract(CalculatorItem a);
    }
}
