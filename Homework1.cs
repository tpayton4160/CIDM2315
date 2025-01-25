namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define variables X and Y
            double X = 2.5;
            double Y = 3.3;

            // Calculate the value of Z using the formula Z = 4X^2 + 3Y
            double Z = 4 * X * X + 3 * Y;

            // Print the result using a formatted string
            Console.WriteLine($"The value of Z is: {Z:F2}");
        }
    }
}