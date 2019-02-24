using CalculatorWebAPI.Models;
using CalculatorWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        private readonly ICalculator _services;

        public CalculatorController(ICalculator services)
        {
            _services = services;
        }

        [HttpPost]
        [Route("Sum")]
        public ActionResult<float> SumElements(CalculatorItem number)
        {
            var result = _services.sum(number);

            return result;
        }

        [HttpPost]
        [Route("Substract")]
        public ActionResult<float> SubstractElements(CalculatorItem number)
        {
            var result = _services.substract(number);

            return result;
        }

        [HttpPost]
        [Route("Multiply")]
        public ActionResult<float> MultiplyElements(CalculatorItem number)
        {
            var result = _services.multiply(number);

            return result;
        }

        [HttpPost]
        [Route("Divide")]
        public ActionResult<float> DivideElements(CalculatorItem number)
        {
            var result = _services.divide(number);

            return result;
        }
    }
}
