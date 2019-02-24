using CalculatorWebAPI.Models;

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
