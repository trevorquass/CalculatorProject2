using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class DivisionOperator
    {
        public decimal total;
        public void Division(decimal amount, decimal amount2)
        {
            try
            {
                total = amount / amount2;
                Console.WriteLine("\nResult: " + total);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\nException caught, cannot divide by zero.", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("\nOverflow error. Cannot perform operation.", e);
            }
        }
    }
}
