namespace Homework9
{
    // 1. Student class definition
    class Student
    {
        // Private fields
        private int studentID;
        private string studentName;

        // Public static list to hold all Student objects
        public static List<Student> studentList = new List<Student>();

        // Constructor that initializes student information and adds the student to studentList
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            studentList.Add(this);
        }

        // Method to print student's information
        public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Name: {studentName}");
        }

        // Helper method to retrieve the student's name
        public string GetName()
        {
            return studentName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Create 4 students with the given information.
            Student s1 = new Student(111, "Alice");
            Student s2 = new Student(222, "Bob");
            Student s3 = new Student(333, "Cathy");
            Student s4 = new Student(444, "David");

            // 3. Create a Dictionary to hold student names and their GPAs.
            Dictionary<string, double> gradebook = new Dictionary<string, double>
            {
                { "Alice", 4.0 },
                { "Bob", 3.6 },
                { "Cathy", 2.5 },
                { "David", 1.8 }
            };

            // 4. Check if "Tom" exists in the gradebook. If not, add "Tom" with a GPA of 3.3.
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook.Add("Tom", 3.3);
            }

            // 5. Calculate the average GPA of all students.
            double averageGPA = gradebook.Values.Average();
            Console.WriteLine($"Average GPA: {averageGPA:F2}");
            Console.WriteLine();

            // 6. Print out information about students whose GPA is greater than the average GPA.
            Console.WriteLine("Students with GPA greater than the average:");
            foreach (Student student in Student.studentList)
            {
                string name = student.GetName();
                if (gradebook.ContainsKey(name) && gradebook[name] > averageGPA)
                {
                    student.PrintInfo();
                    Console.WriteLine($"GPA: {gradebook[name]}");
                    Console.WriteLine();
                }
            }

            // Wait for a key press before closing (for debugging purposes).
            Console.ReadKey();
        }
    }
}