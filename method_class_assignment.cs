using System;

namespace MethodAssignment
{
    // 1. Create a class.
    public class MathOperations
    {
        // 1 (cont). Create a void method that takes two integers as parameters.
        public void CalculateAndDisplay(int numberOne, int numberTwo)
        {
            // Have the method do a math operation on the first integer.
            // (We will multiply it by 10, though the result isn't required to be displayed).
            int result = numberOne * 10;

            // Display the second integer to the screen.
            Console.WriteLine("The second integer provided is: " + numberTwo);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method, instantiate the class.
            MathOperations mathOp = new MathOperations();

            // 3. Call the method in the class, passing in two numbers (positional arguments).
            // This passes 5 as numberOne and 10 as numberTwo.
            mathOp.CalculateAndDisplay(5, 10);

            // 4. Call the method in the class, specifying the parameters by name (named arguments).
            // This explicitly tells the program which value belongs to which parameter.
            mathOp.CalculateAndDisplay(numberOne: 25, numberTwo: 50);

            // Keeps the console window open until a key is pressed.
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
