namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        // Create Professors
        Professor prof1 = new Professor("Alice", "Java", 9000);
        Professor prof2 = new Professor("Bob", "Math", 8000);

        // Create Students
        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        // Print Professor Details
        Console.WriteLine("Professor Details:");
        Console.WriteLine($"Name: {prof1.ProfName}, Class: {prof1.ClassTeach}, Salary: {prof1.GetSalary()}");
        Console.WriteLine($"Name: {prof2.ProfName}, Class: {prof2.ClassTeach}, Salary: {prof2.GetSalary()}");

        // Print Student Details
        Console.WriteLine("\nStudent Details:");
        Console.WriteLine($"Name: {student1.StudentName}, Enrolled Class: {student1.ClassEnroll}, Grade: {student1.GetGrade()}");
        Console.WriteLine($"Name: {student2.StudentName}, Enrolled Class: {student2.ClassEnroll}, Grade: {student2.GetGrade()}");

        // Calculate and print the salary difference
        double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine($"\nSalary Difference: {salaryDifference}");

        // Calculate and print total grade
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"Total Grade: {totalGrade}");
    }
}

class Professor
{
    // Private attributes
    private string profName;
    private string classTeach;
    private double salary;

    // Constructor
    public Professor(string name, string classTaught, double salaryAmount)
    {
        profName = name;
        classTeach = classTaught;
        salary = salaryAmount;
    }

    // Properties to access private fields
    public string ProfName => profName;
    public string ClassTeach => classTeach;

    // Set and Get methods for salary
    public void SetSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Student
{
    // Private attributes
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    // Constructor
    public Student(string name, string enrolledClass, double grade)
    {
        studentName = name;
        classEnroll = enrolledClass;
        studentGrade = grade;
    }

    // Properties to access private fields
    public string StudentName => studentName;
    public string ClassEnroll => classEnroll;

    // Set and Get methods for student grade
    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}