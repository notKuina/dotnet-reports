using System;

namespace lab5
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter an operator (+, -, *, /, %): ");
            char operation = char.Parse(Console.ReadLine());

            double result;

            // Perform the specified operation
            switch (operation)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine($"\nThe result of {number1} + {number2} is: {result}");
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine($"\nThe result of {number1} - {number2} is: {result}");
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine($"\nThe result of {number1} * {number2} is: {result}");
                    break;
                case '/':
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                        Console.WriteLine($"\nThe result of {number1} / {number2} is: {result}");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Division by zero is not allowed.");
                    }
                    break;
                case '%':
                    if (number2 != 0)
                    {
                        result = number1 % number2;
                        Console.WriteLine($"\nThe result of {number1} % {number2} is: {result}");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid operator. Please enter one of the following operators: +, -, *, /, %");
                    break;
            }

            Console.ReadKey();
        }
    }
}
