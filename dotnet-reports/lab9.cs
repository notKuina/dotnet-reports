using System;

namespace lab9
{
    class OddEvenChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"\n{number} is an even number.");
            }
            else
            {
                Console.WriteLine($"\n{number} is an odd number.");
            }

            Console.ReadKey();
        }
    }
}
