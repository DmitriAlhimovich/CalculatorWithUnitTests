using System;

namespace CalculatorWithUnitTests
{
    public class SimpleCalculator
    {
        public static void Run()
        {
            Console.WriteLine("Input a number:");

            var operand1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input an operation (+, -):");

            var operation = Console.ReadLine()[0];

            Console.WriteLine("Input a number:");

            var operand2 = double.Parse(Console.ReadLine());

            double result;

            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                default:
                    throw new ArgumentException($"Unsupported operation: {operation}");
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}