using CalculatorWebAPI.Models;


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
