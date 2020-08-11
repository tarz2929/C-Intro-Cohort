using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Declare" (create) a variable using the datatype followed by the name.
            string name; // Strings store text.
            int wholeNumber; // Int stores a number without a decimal point (positive or negative).
            double number; // Double stores a number with a decimal point.

            Console.WriteLine("Please enter your name below:"); // Tell the user what we're expecting.
            name = Console.ReadLine(); // Assign a value to the variable (that we get from the user).

            Console.WriteLine("Hello, " + name + "."); // Retrieve the value from the variable and send it to the console.

        }
    }
}
