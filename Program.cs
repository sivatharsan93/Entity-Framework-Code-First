using System;
using System.Linq;

namespace StudentDatabaseApp
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
                    LastName = "Doe",
                    Age = 20
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save the changes to the database
                context.SaveChanges();

                // Retrieve and display the student from the database
                var query = from s in context.Students
                            orderby s.StudentId
                            select s;

                Console.WriteLine("All students in the database:");
                foreach (var s in query)
                {
                    Console.WriteLine($"{s.StudentId}: {s.FirstName} {s.LastName}, Age: {s.Age}");
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
