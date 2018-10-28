using Microsoft.AspNetCore.Mvc;
using restful_api.Interfaces;
using restful_api.Services;

namespace restful_api.Controllers
{
    [Produces("application/json")]
    [Route("api/Calculator")]
    public class CalculatorController : Controller
    {
        private IMathService MathService;
        public CalculatorController(IMathService mathService)
        {
            MathService = mathService;
        }
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber)
        {

            if (MathService.IsNumeric(firstNumber) && MathService.IsNumeric(secondNumber))
            {
                var sum = MathService.ConvertToDecimal(firstNumber) + MathService.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Request");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {

            if (MathService.IsNumeric(firstNumber) && MathService.IsNumeric(secondNumber))
            {
                var sum = MathService.ConvertToDecimal(firstNumber) - MathService.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Request");
        }

        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {

            if (MathService.IsNumeric(firstNumber) && MathService.IsNumeric(secondNumber))
            {
                var sum = MathService.ConvertToDecimal(firstNumber) * MathService.ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("Invalid Request");
        }

    }
}