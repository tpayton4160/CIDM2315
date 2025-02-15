using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Get two numbers from user input
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // Call the method to find the largest of two numbers
            int largest = GetLargest(num1, num2);
            Console.WriteLine($"Q1 - The largest number between {num1} and {num2} is: {largest}\n");

            // Q2: Get shape type and size from user input
            Console.Write("Enter the size of the triangle (N): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter the shape (left or right): ");
            string shape = Console.ReadLine().ToLower();

            // Call the method to print triangles
            Console.WriteLine("\nQ2 - Triangle Output:");
            PrintTriangle(n, shape);
        }

        // Q1 Method: Takes two numbers and returns the largest one
        static int GetLargest(int num1, int num2)
        {
            return (num1 > num2) ? num1 : num2;
        }

        // Q2 Method: Takes an integer N and a shape (left or right) and prints the triangle
        static void PrintTriangle(int n, string shape)
        {
            Console.WriteLine($"\nN: {n}, Shape: {shape}");

            if (shape == "left")
            {
                // Print left-aligned triangle
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (shape == "right")
            {
                // Print right-aligned triangle
                for (int i = 1; i <= n; i++)
                {
                    // Print spaces first
                    for (int j = 1; j <= n - i; j++)
                    {
                        Console.Write(" ");
                    }
                    // Print stars
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid shape input. Use 'left' or 'right'.");
            }
        }
    }
}