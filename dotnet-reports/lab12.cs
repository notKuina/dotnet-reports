using System;

namespace lab12
{
    class MarksAnalysis
    {
        static void Main(string[] args)
        {
  
            Console.Write("Enter the number of .NET technology marks you want to input: ");
            int numberOfMarks = int.Parse(Console.ReadLine());

            int[] marks = new int[numberOfMarks];

            Console.WriteLine("\nEnter the marks:");
            for (int i = 0; i < numberOfMarks; i++)
            {
                Console.Write($"Mark {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());
            }

            int minMark = marks[0];
            int maxMark = marks[0];
            int sum = 0;

            foreach (int mark in marks)
            {
                if (mark < minMark)
                {
                    minMark = mark;
                }
                if (mark > maxMark)
                {
                    maxMark = mark;
                }
                sum += mark;
            }

            double averageMark = (double)sum / numberOfMarks;

            Console.WriteLine($"\nMinimum Mark: {minMark}");
            Console.WriteLine($"Maximum Mark: {maxMark}");
            Console.WriteLine($"Average Mark: {averageMark:F2}");

            Console.ReadKey();
        }
    }
}
