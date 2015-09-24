using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorDisplay
    {
        public decimal firstNumber, secondNumber;
        public string mathOperator;
        public void RunCalculator()
        {
            Console.WriteLine("Enter first number:");
            try
            {
                firstNumber = decimal.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("\nInvalid input entered.\n", e);
                CalculatorDisplay calculatorDisplay = new CalculatorDisplay();
                calculatorDisplay.RunCalculator();
            }
            Console.WriteLine("\nEnter operator choice (+,-,*,/):");
            mathOperator = Console.ReadLine();

            if (mathOperator == "+")
            {
                Console.WriteLine("\nEnter second number:");
                try
                {
                    secondNumber = decimal.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid input entered.\n", e);
                    CalculatorDisplay calculatorDisplay = new CalculatorDisplay();
                    calculatorDisplay.RunCalculator();
                }
                AdditionOperator add = new AdditionOperator();
                add.Add(firstNumber, secondNumber);
                add.PrintResult();
            }
            else if (mathOperator == "-")
            {
                Console.WriteLine("\nEnter second number:");
                try
                {
                    secondNumber = decimal.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid input entered.\n", e);
                    CalculatorDisplay calculatorDisplay = new CalculatorDisplay();
                    calculatorDisplay.RunCalculator();
                }
                SubtractionOperator subtract = new SubtractionOperator();
                subtract.Subtract(firstNumber, secondNumber);
                subtract.PrintResult();
            }
            else if (mathOperator == "*")
            {
                Console.WriteLine("\nEnter second number:");
                try
                {
                    secondNumber = decimal.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid input entered.\n", e);
                    CalculatorDisplay calculatorDisplay = new CalculatorDisplay();
                    calculatorDisplay.RunCalculator();
                }
                MultiplicationOperator multiply = new MultiplicationOperator();
                multiply.Multiply(firstNumber, secondNumber);
                multiply.PrintResult();
            }
            else if (mathOperator == "/")
            {
                Console.WriteLine("\nEnter second number:");
                try
                {
                    secondNumber = decimal.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid input entered.\n", e);
                    CalculatorDisplay calculatorDisplay = new CalculatorDisplay();
                    calculatorDisplay.RunCalculator();
                }
                DivisionOperator divide = new DivisionOperator();
                divide.Division(firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("\nInvalid operator entered.");
            }
            
            Console.WriteLine("\nPerform new operation? (yes/no):\n");
            string performNewOperationResponse = Console.ReadLine();

            if (performNewOperationResponse == "yes")
            {
                CalculatorDisplay calculatorDisplay = new CalculatorDisplay();
                calculatorDisplay.RunCalculator();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
