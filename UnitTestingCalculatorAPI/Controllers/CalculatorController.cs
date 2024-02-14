using CalculatorClassLibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestingCalculatorAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {


        private readonly calculatorlib _calculatorService;

        public CalculatorController(calculatorlib calculatorService)
        {
            _calculatorService = calculatorService;
        }
        [HttpGet("add")]
        public decimal Add(decimal num1, decimal num2)
        {
            return _calculatorService.Add(num1, num2);

        }

        [HttpGet("subtract")]
        public decimal Subtract(decimal num1, decimal num2)
        {
            return _calculatorService.Subtract(num1, num2);
        }
        [HttpGet("multiply")]
        public decimal Multiply(decimal num1, decimal num2)
        {
            return _calculatorService.Multiply(num1, num2);
        }
        [HttpGet("divide")]
        public decimal Divide(decimal num1, decimal num2)
        {
            return _calculatorService.Divide(num1, num2);

        }
        [HttpGet("modulo")]
        public decimal Modulo(decimal num1, decimal num2)
        {
            return _calculatorService.Modulo(num1, num2);

        }
    }
}
