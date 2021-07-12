using System;
using System.Linq;

namespace CalculatorWithUnitTests
{
    public class CalculatorWithCommandLineParams
    {
        public static void Run(string[] args)
        {
            Console.WriteLine(string.Join(",", args));

            var operand1 = double.Parse(args[0]);

            var operation = args[1][0];

            var operand2 = double.Parse(args[2]);

            double result;

            switch (operation)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                default:
                    throw new ArgumentException($"Unsupported operation: {operation}");
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}