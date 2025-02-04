using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Q1: Grade to GPA Program
            Console.Write("Enter a letter grade (A, B, C, D, F): ");
            string grade = Console.ReadLine().ToUpper();  // Input and convert to uppercase

            if (grade == "A")
            {
                Console.WriteLine("The corresponding GPA is 4");
            }
            else if (grade == "B")
            {
                Console.WriteLine("The corresponding GPA is 3");
            }
            else if (grade == "C")
            {
                Console.WriteLine("The corresponding GPA is 2");
            }
            else if (grade == "D")
            {
                Console.WriteLine("The corresponding GPA is 1");
            }
            else if (grade == "F")
            {
                Console.WriteLine("The corresponding GPA is 0");
            }
            else
            {
                Console.WriteLine("Wrong Letter Grade!");
            }

            // Q2: Find the smallest number
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int smallest = num1;

            if (num2 < smallest)
            {
                smallest = num2;
            }
            if (num3 < smallest)
            {
                smallest = num3;
            }

            Console.WriteLine($"The smallest number is {smallest}");

            // Bonus: Check if the year is a leap year
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
        }
    }
}