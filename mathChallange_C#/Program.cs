using System;

namespace BasicMathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;

            // Input first number
            Console.Write("Enter the first number: ");
            while (!double.TryParse(Console.ReadLine(), out number1))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            // Input second number
            Console.Write("Enter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out number2))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            // Addition
            double sum = number1 + number2;
            Console.WriteLine($"Addition: {number1} + {number2} = {sum}");

            // Subtraction
            double difference = number1 - number2;
            Console.WriteLine($"Subtraction: {number1} - {number2} = {difference}");

            // Multiplication
            double product = number1 * number2;
            Console.WriteLine($"Multiplication: {number1} * {number2} = {product}");

            // Division
            if (number2 != 0)
            {
                double quotient = number1 / number2;
                Console.WriteLine($"Division: {number1} / {number2} = {quotient}");
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }

            Console.ReadLine(); // Keeps the console window open
        }
    }
}
