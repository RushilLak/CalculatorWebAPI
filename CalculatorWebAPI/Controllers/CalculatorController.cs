using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [Route("Sum/{a:float}/{b:float}")]
        public ActionResult<float> SumElements(float a, float b)
        {
            var result = _services.sum(a, b);

            return result;
        }

        [HttpPost]
        [Route("Substract/{a:float}/{b:float}")]
        public ActionResult<float> SubstractElements(float a, float b)
        {
            var result = _services.substract(a, b);

            return result;
        }

        [HttpPost]
        [Route("Multiply/{a:float}/{b:float}")]
        public ActionResult<float> MultiplyElements(float a, float b)
        {
            var result = _services.multiply(a, b);

            return result;
        }

        [HttpPost]
        [Route("Divide/{a:float}/{b:float}")]
        public ActionResult<float> DivideElements(float a, float b)
        {
            var result = _services.divide(a, b);

            return result;
        }
    }
}
