using System;

namespace lab8
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string inputString = Console.ReadLine();

            char[] charArray = inputString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            Console.WriteLine($"\nReversed String: {reversedString}");

            Console.ReadKey();
        }
    }
}
