using System;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Use polymorphism to create an object of type IQuittable.
            // We instantiate an Employee, but the variable type is IQuittable.
            IQuittable quitter = new Employee() 
            { 
                Id = 505, 
                FirstName = "Alex", 
                LastName = "Johnson" 
            };

            // 3 (cont). Call the Quit() method on the IQuittable object.
            quitter.Quit();

            // Keeps the console window open.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
