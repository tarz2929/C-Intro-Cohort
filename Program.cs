﻿using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1; // Initialize step;

            while (counter <= 10) // Test step;
            {
                Console.WriteLine($"Counter is at {counter}."); // Process step.
                // counter = counter + 1; 
                // counter += 1;
                counter++; // Modify step.
            }
            Console.WriteLine("Done!");


            for (int i = 1 /* Initialize */; i <= 10 /* Test */; i++ /* Modify */)
            {
                Console.WriteLine($"Counter is at {i}."); // Process
            }
            Console.WriteLine("Done!");
        }
    }
}
 