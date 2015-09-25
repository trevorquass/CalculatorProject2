using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorDisplay
    {     
        AdditionOperator add = new AdditionOperator();
        SubtractionOperator subtract = new SubtractionOperator();
        MultiplicationOperator multiply = new MultiplicationOperator();
        DivisionOperator divide = new DivisionOperator();
        public decimal firstNumber, secondNumber, result;
        public string mathOperator;
        public string reply, yes;

        public void RunCalculator()
        {while(true)
        {
            Console.WriteLine("Enter first number:");
            while (true)
            {
                try
                {
                    firstNumber = decimal.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid input entered. Enter Again\n", e);
                }
            }
                Console.WriteLine("\nEnter operator choice (+,-,*,/):");
                mathOperator = Console.ReadLine();                 
                while (true)
                {
                    if(mathOperator == "*" || mathOperator == "+" || mathOperator == "-" || mathOperator == "/"){                          
                    break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Operator Entered, enter again\n");
                        mathOperator = Console.ReadLine();
                    }
                }

                Console.WriteLine("\nEnter Second number:");
                while (true)
                {
                    try
                    {
                        secondNumber = decimal.Parse(Console.ReadLine());
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nInvalid input entered. Enter Again\n", e);
                    }
                }
                switch (mathOperator)
                {
                    case "+":
                        add.Add(firstNumber, secondNumber);
                        break;
                    case "-":
                        subtract.Subtract(firstNumber, secondNumber);
                        break;
                    case "*":
                        multiply.Multiply(firstNumber, secondNumber);
                        break;
                    case "/":
                        divide.Division(firstNumber, secondNumber);
                        break;
                    default:
                        Console.WriteLine("invalid operator");
                        break;
                       
                }
                Console.WriteLine("\n");
                Console.WriteLine("Do you want more math?" + "<yes/no>");
                
                if (Console.ReadLine() == "yes")
                {
                    Console.WriteLine("\n");
                    RunCalculator();
                }
                else
                {
                    Environment.Exit(0);
                }
                }                   
            }
        }
    
}
