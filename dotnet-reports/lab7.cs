using System;

namespace lab7
{
    class MultiplicationTable
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nMultiplication Table for {number}:");

            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} x {i} = {result}");
            }

            Console.ReadKey();
        }
    }
}
