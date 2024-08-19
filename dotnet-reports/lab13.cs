using System;

namespace lab13
{
    class StringArrayToString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of strings in the array: ");
            int numberOfStrings = int.Parse(Console.ReadLine());

 
            string[] stringArray = new string[numberOfStrings];

            Console.WriteLine("\nEnter the strings:");
            for (int i = 0; i < numberOfStrings; i++)
            {
                Console.Write($"String {i + 1}: ");
                stringArray[i] = Console.ReadLine();
            }

            string resultString = string.Join(", ", stringArray);

            Console.WriteLine($"\nThe combined string is: {resultString}");

            Console.ReadKey();
        }
    }
}
