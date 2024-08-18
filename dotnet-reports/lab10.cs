using System;

namespace lab10
{
    class VowelOrConsonant
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an alphabet: ");
            char alphabet = char.ToLower(Console.ReadKey().KeyChar); // Convert to lowercase for simplicity

            switch (alphabet)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("\n\nThe alphabet is a vowel.");
                    break;
                default:
                    if (char.IsLetter(alphabet))
                    {
                        Console.WriteLine("\n\nThe alphabet is a consonant.");
                    }
                    else
                    {
                        Console.WriteLine("\n\nThe input is not a valid alphabet.");
                    }
                    break;
            }

            Console.ReadKey();
        }
    }
}
