using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            string name; // "Declare" (create) a variable using the datatype followed by the name.

            Console.WriteLine("Please enter your name below:"); // Tell the user what we're expecting.
            name = Console.ReadLine(); // Assign a value to the variable (that we get from the user).

            Console.WriteLine("Hello, " + name + "."); // Retrieve the value from the variable and send it to the console.

        }
    }
}
