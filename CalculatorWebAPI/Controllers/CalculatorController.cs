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
        [Route("Sum")]
        public ActionResult<float> SumElements(CalculatorItem a)
        {
            var result = _services.sum(a);

            return result;
        }

        [HttpPost]
        [Route("Substract")]
        public ActionResult<float> SubstractElements(CalculatorItem a)
        {
            var result = _services.substract(a);

            return result;
        }
    }
}
