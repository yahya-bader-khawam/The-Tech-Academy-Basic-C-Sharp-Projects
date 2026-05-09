using System;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Instantiate two objects of the Employee class and assign values.
            Employee employee1 = new Employee 
            { 
                Id = 101, 
                FirstName = "John", 
                LastName = "Doe" 
            };

            Employee employee2 = new Employee 
            { 
                Id = 102, 
                FirstName = "Jane", 
                LastName = "Smith" 
            };

            // Compare the two objects using the overloaded "==" operator.
            Console.WriteLine("Checking if Employee 1 and Employee 2 are equal (by ID):");
            if (employee1 == employee2)
            {
                Console.WriteLine("Result: The employees are equal.");
            }
            else
            {
                Console.WriteLine("Result: The employees are NOT equal.");
            }

            // 3 (cont). Testing with identical IDs to demonstrate the overload.
            employee2.Id = 101; 
            Console.WriteLine("\nUpdating Employee 2 ID to 101...");
            Console.WriteLine("New Comparison Result: " + (employee1 == employee2));

            // Keep the console window open.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
