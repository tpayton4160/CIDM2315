using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Q1_method
            int max2 = Q1_method();
            Console.WriteLine($"The largest of two numbers: {max2}\n");

            // Call Q2_method
            int max4 = Q2_method();
            Console.WriteLine($"The largest of four numbers: {max4}\n");

            // Call Q3_method
            createAccount();
        }

        // Q1 (2 points): Method to get 2 integers and return the largest one
        static int Q1_method()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            return Math.Max(num1, num2);
        }

        // Q2 (3 points): Method to get 4 integers and return the largest one using Q1_method
        static int Q2_method()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("Enter fourth number: ");
            int num4 = int.Parse(Console.ReadLine());

            int max1 = Math.Max(num1, num2); // Compare first two numbers
            int max2 = Math.Max(num3, num4); // Compare last two numbers

            return Math.Max(max1, max2); // Return the largest of all
        }

        // Q3 (5 points): Method to check age eligibility
        static bool checkAge(int birth_year)
        {
            int current_year = DateTime.Now.Year;
            int age = current_year - birth_year;
            return age >= 18;
        }

        // Q3 (5 points): Method to create an account
        static void createAccount()
        {
            Console.Write("Enter Your Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Your Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Your Password Again: ");
            string confirmPassword = Console.ReadLine();

            Console.Write("Enter Your Birthyear: ");
            int birthYear = int.Parse(Console.ReadLine());

            if (checkAge(birthYear))
            {
                if (password == confirmPassword)
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account.");
            }
        }
    }
}