using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Declare" (create) a variable using the datatype followed by the name.
            string text; // Strings store text.
            char character; // Stores a single character (including space, newline, etc).
            int wholeNumber; // Int stores a number without a decimal point (positive or negative).
            // byte, short and long are other integer types with varying size limits.
            double number; // Double stores a number with a decimal point.
            // float and decimal are alternatives with quirks. Google them if you plan to use them.
            bool boolean; // Bool stores a true or false value.

            string name; // Declare our variable.
            int age, birthYear;

            Console.WriteLine("Please enter your name below:"); // Tell the user what we're expecting.
            name = Console.ReadLine(); // Assign a value to the variable (that we get from the user).

            Console.WriteLine("Please enter your age below:"); // Tell the user what we're expecting.
            age = int.Parse(Console.ReadLine()); // Convert the user's input to an integer and store it.
            // If the user enters something that isn't an integer, IT WILL BLOW UP.

            birthYear = DateTime.Now.Year - age;

            Console.WriteLine("Hello, " + name + ". You were born in the year " + birthYear + ", assuming your birthday this year has passed."); // Retrieve the values from the variables and send them to the console.


        }
    }
}
 