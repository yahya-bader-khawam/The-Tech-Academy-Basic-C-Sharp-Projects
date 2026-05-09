using System;

namespace OperatorsAssignment
{
    // 1. Create an Employee class with Id, FirstName and LastName properties.
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // 2. Overload the "==" operator to compare Employee objects by their Id.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Handle cases where one or both objects might be null to avoid errors.
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            {
                return ReferenceEquals(emp1, emp2);
            }

            // Compare the Id properties as requested.
            return emp1.Id == emp2.Id;
        }

        // 2 (cont). Comparison operators must be overloaded in pairs. 
        // If you overload "==", you MUST also overload "!=".
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // This simply returns the opposite of the "==" comparison.
            return !(emp1 == emp2);
        }

        // Note: It's good practice to override Equals() and GetHashCode() 
        // when overloading "==", though not explicitly required by your prompt.
    }
}
