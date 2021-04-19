using System;

namespace MrYusufssingment4
{
    public class Calculator
    
    {
        public double Calculate(string Calculation, double number1, double number2)
        {
            double result;

            switch (Calculation.ToLower())
            {
                case "plus":
                case "+":
                    result = number1 + number2;
                    break;
                case "subtract":
                case "-":
                    result = number1 - number2;
                    break;
                case "divide":
                case "/":
                    result = number1 / number2;
                    break;
                case "multiply":
                case "*":
                    result = number1 * number2;
                    break;
                case "modulus":
                case "%":
                    result = number1 % number2;
                    break;
                   default:
                    throw new InvalidOperationException("Invalid Expression");

            }
            return result;
        }
    }
}


