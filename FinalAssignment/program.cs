using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentApp
{
    // 1. THE MODEL (Entity)
    // This class represents the "Students" table in your database.
    public class Student
    {
        public int StudentId { get; set; } // Primary Key
        public string Name { get; set; }
    }

    // 2. THE DATABASE CONTEXT
    // This class manages the connection and data operations.
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // We are using SQLite for a simple local database file named "students.db"
            optionsBuilder.UseSqlite("Data Source=students.db");
        }
    }

    // 3. THE MAIN PROGRAM
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SchoolContext())
            {
                // Ensure the database file is created based on the Model
                db.Database.EnsureCreated();

                Console.WriteLine("Adding a new student to the database...");

                // Create a new Student object
                var newStudent = new Student { Name = "John Smith" };

                // Add and Save changes to the database
                db.Students.Add(newStudent);
                db.SaveChanges();

                Console.WriteLine("Success! Student saved.");

                // Retrieve and display the student to verify
                var student = db.Students.First();
                Console.WriteLine($"\nRecord Retrieved:\nID: {student.StudentId}\nName: {student.Name}");
                
                Console.WriteLine("\nPress any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
