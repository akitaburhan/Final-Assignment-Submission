using System;

namespace CodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe"
                };

                // Add student to context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added to the database.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}