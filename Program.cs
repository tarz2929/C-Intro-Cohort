using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // string myString = "Hello, world!";

            // int counter = 0;
            // while (counter < myString.Length) // Test step;
            // {
            //     Console.WriteLine($"String index {counter} is {myString[counter]}."); // Process step.
            //     // counter = counter + 1; 
            //     // counter += 1;
            //     counter++; // Modify step.
            // }
            // Console.WriteLine("Done!");




            string myString = "Hello, world!";

            for (int i = 0 /* Initialize */; i < myString.Length /* Test */; i++ /* Modify */)
            {
                Console.WriteLine($"String index {i} is {myString[i]}.");
            }
            Console.WriteLine("Done!");
        }
    }
}
 