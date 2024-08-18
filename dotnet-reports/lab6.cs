using System;

namespace lab6
{
    class SwapNumbers
    {
        static void Main(string[] args)
        {
 
            Console.Write("Please enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nBefore Swapping: Number 1 = {number1}, Number 2 = {number2}");

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine($"\nAfter Swapping: Number 1 = {number1}, Number 2 = {number2}");


            Console.ReadKey();
        }
    }
}
