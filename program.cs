using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Display initial welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // 2. Prompt user for package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            // 3. Check if weight exceeds the limit
            if (weight > 50)
            {
                // Display error and terminate program if package is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; 
            }

            // 4. Prompt for package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // 5. Prompt for package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // 6. Prompt for package length
            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            // 7. Check if total dimensions exceed the limit
            if ((width + height + length) > 50)
            {
                // Display error and terminate program if package is too large
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return;
            }

            // 8. Calculate the quote
            // Formula: (Width * Height * Length * Weight) / 100
            // Using decimal to ensure the currency output is accurate
            decimal quote = (decimal)(width * height * length * weight) / 100;

            // 9 & 10. Display the final quote formatted as a dollar amount
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Keep console window open
            Console.ReadLine();
        }
    }
}
