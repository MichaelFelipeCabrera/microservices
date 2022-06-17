using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }



            return BadRequest("Invalid Input");
        }

        [HttpGet("sub/{firstNumber}/{secondNumber}")]
        public IActionResult GetSub(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }



            return BadRequest("Invalid Input");
        }

        [HttpGet("mult/{firstNumber}/{secondNumber}")]
        public IActionResult GetMult(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }



            return BadRequest("Invalid Input");
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult GetDiv(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }



            return BadRequest("Invalid Input");
        }


        [HttpGet("media/{firstNumber}/{secondNumber}")]
        public IActionResult GetMedia(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }



            return BadRequest("Invalid Input");
        }


        [HttpGet("sq/{firstNumber}")]
        public IActionResult GetSq(string firstNumber)
        {
            if (IsNumeric(firstNumber) )
            {
                var sum = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }






        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(
                    strNumber
                    , System.Globalization.NumberStyles.Any
                    , System.Globalization.NumberFormatInfo.InvariantInfo
                    , out number
                    );

            return isNumber;

        }

        private decimal ConvertToDecimal(string strNumber)
        {
            {
                decimal decimalValue;
                if (decimal.TryParse(strNumber, out decimalValue))
                    return decimalValue;

                else
                    return 0;

            }

        }

    }
}
