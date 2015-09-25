using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class AdditionOperator
    {
        public decimal result;
        public void Add(decimal value1, decimal value2)
        {
            try
            {
                result = value1 + value2;
                Console.WriteLine("\nResult: " + result);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("\nOverflow error. Cannot perform operation.", e);
            }
        }
    }
}
