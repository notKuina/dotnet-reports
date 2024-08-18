using System;

namespace lab4
{
    class SimpleInterestCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the principal amount: ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("Please enter the time in years: ");
            double time = double.Parse(Console.ReadLine());

            Console.Write("Please enter the rate of interest (in percentage): ");
            double rate = double.Parse(Console.ReadLine());

            double simpleInterest = (principal * time * rate) / 100;

            Console.WriteLine($"\nThe Simple Interest is: {simpleInterest}");

            Console.ReadKey();
        }
    }
}
