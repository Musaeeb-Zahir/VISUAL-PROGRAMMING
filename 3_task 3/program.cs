using System;

namespace VariableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Declare variables first, then initialize on the next line
            string studentName;
            studentName = "Musaeeb"; // Name of the student

            bool isEnrolled;
            isEnrolled = true; // Enrollment status

            int studentAge;
            studentAge = 21; // Age of the student

            // 2. Declare and initialize variables on the same line
            string department = "Computer Science"; // Department of the student
            char grade = 'A'; // Grade achieved
            double feeBalance = 43000.50; // Fee balance of the student

            // Output the values
            Console.WriteLine("Student Name: " + studentName);
            Console.WriteLine("Student Age: " + studentAge);
            Console.WriteLine("Is Enrolled: " + isEnrolled);
            Console.WriteLine("Fee Balance: $" + feeBalance);
            Console.WriteLine("Grade: " + grade);
            Console.WriteLine("Department: " + department);
        }
    }
}