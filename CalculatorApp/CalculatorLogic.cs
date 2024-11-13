using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CalculatorLogic  // Обратите внимание на "public"
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string Operation { get; set; }

        public double Calculate()
        {
            return Operation switch
            {
                "+" => FirstNumber + SecondNumber,
                "-" => FirstNumber - SecondNumber,
                "*" => FirstNumber * SecondNumber,
                "/" => SecondNumber != 0 ? FirstNumber / SecondNumber : throw new DivideByZeroException("Cannot divide by zero"),
                _ => 0
            };
        }
    }
}
