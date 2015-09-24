using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class SubtractionOperator
    {
        public decimal result;
        public decimal Subtract(decimal value1, decimal value2)
        {
            result = value1 - value2;
            return result;
        }
        public void PrintResult()
        {
            Console.WriteLine("\nResult: " + result);
        }            
    }
}
