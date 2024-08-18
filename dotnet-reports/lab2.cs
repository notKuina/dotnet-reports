using System;

namespace lab2
{
    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first integer: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second integer: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Please enter the third integer: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber + thirdNumber;

            Console.WriteLine($"The sum of {firstNumber}, {secondNumber}, and {thirdNumber} is: {sum}");

            Console.ReadKey();
        }
    }
}