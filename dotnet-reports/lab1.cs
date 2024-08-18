
using System;

namespace lab1
{
    class Name
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their name
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            // Print the welcome message
            Console.WriteLine($"Welcome {userName}!");
            Console.ReadKey();
        }
    }
}
