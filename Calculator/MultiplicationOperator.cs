﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MultiplicationOperator
    {
        public decimal result;
        public void Multiply(decimal value1, decimal value2)
        {
            try
            {
                result = value1 * value2;
                Console.WriteLine("\nResult: " + result);
                Console.WriteLine(result > 999999 ? "That is a large number." : "Cool number!");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("\nOverflow error. Cannot perform operation.", e);
            }
        }
    }
}
