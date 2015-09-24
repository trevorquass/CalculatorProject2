using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorDisplay calculator = new CalculatorDisplay();
            calculator.RunCalculator();
            Console.Read();
        }
    }
}
