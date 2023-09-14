using System;

namespace CSharpCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation (+, -, *, /):");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero.");
                    }
                    else
                    {
                        Console.WriteLine($"Result: {num1 / num2}");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }
        public static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;
    }
}
