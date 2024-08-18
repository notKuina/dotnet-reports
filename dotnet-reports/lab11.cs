using System;

namespace lab11
{
    class MatrixMultiplication
    {
        static void Main(string[] args)
        {
              Console.Write("Enter the number of rows for the first matrix: ");
            int rows1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns for the first matrix (and rows for the second matrix): ");
            int cols1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns for the second matrix: ");
            int cols2 = int.Parse(Console.ReadLine());


            int[,] matrix1 = new int[rows1, cols1];
            int[,] matrix2 = new int[cols1, cols2];
            int[,] resultMatrix = new int[rows1, cols2];

            Console.WriteLine("\nEnter the elements of the first matrix:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter the elements of the second matrix:");
            for (int i = 0; i < cols1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write($"Element [{i + 1}, {j + 1}]: ");
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    resultMatrix[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            Console.WriteLine("\nThe result of matrix multiplication is:");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(resultMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
