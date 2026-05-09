using System;

namespace PolymorphismAssignment
{
    // 2. Inherit the IQuittable interface.
    public class Employee : IQuittable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 2 (cont). Implement the Quit() method.
        public void Quit()
        {
            // Implementation of the Quit method as required.
            Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has officially quit the organization.");
        }
    }
}
