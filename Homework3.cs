using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Prime Number Check
            Console.WriteLine("Q1: Prime Number Check");
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());
            // A number less than 2 is not prime.
            if (number < 2)
            {
                Console.WriteLine($"{number} is non-prime");
            }
            else
            {
                bool isPrime = true;
                // Check divisibility from 2 up to number-1.
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine($"{number} is prime");
                else
                    Console.WriteLine($"{number} is non-prime");
            }
            Console.WriteLine(); // Blank line for separation
            // Q2: Simple Square Pattern
            Console.WriteLine("Q2: Simple Square Pattern");
            Console.Write("Enter the size of the square (N): ");
            int nSimple = int.Parse(Console.ReadLine());
            // Print an N x N square of stars.
            for (int row = 0; row < nSimple; row++)
            {
                for (int col = 0; col < nSimple; col++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // Q3: Diagonal (X) Pattern 
            Console.WriteLine("Q3: X Pattern");
            Console.Write("Enter the size of the square (N): ");
            int nX = int.Parse(Console.ReadLine());
            // Print an N x N grid with stars on the two diagonals.
            for (int i = 0; i < nX; i++)
            {
                for (int j = 0; j < nX; j++)
                {
                    // If we are on the main diagonal (i == j) or the secondary diagonal (i + j == nX - 1)
                    if (i == j || i + j == nX - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            // Bonus: Border and Diagonals Pattern
                     Console.WriteLine("Bonus: Border and Diagonals Pattern");
            Console.Write("Enter the size of the square (N): ");
            int nBonus = int.Parse(Console.ReadLine());
            // For each cell, print a star if it is on the border OR on either diagonal.
            for (int i = 0; i < nBonus; i++)
            {
                for (int j = 0; j < nBonus; j++)
                {
                    if (i == 0 || i == nBonus - 1 || j == 0 || j == nBonus - 1 || i == j || i + j == nBonus - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
