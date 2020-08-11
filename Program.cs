using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Title: Decisions Problem #3

                Purpose: Determine whether a number entered by the user is a perfect square of a 
                whole number or not.

                Author: James Grieve
                Date of Last Edit: August 11, 2020
            */

            int menuChoice;

            Console.WriteLine("Menu\n----------\n1. Option 1\n2. Option 2\n3. Option 3");
            Console.Write("Please enter a menu choice: ");
            menuChoice = int.Parse(Console.ReadLine());

            // Menu with a switch.
            switch (menuChoice)
            {
                case 1:
                    // Do the option 1 stuff.
                    break;
                case 2:
                    // Do the option 2 stuff.
                    break;
                case 3:
                    // Do the option 3 stuff.
                    break;
                default:
                    // Invalid menu choice.
                    break;
            }
            
            // Menu with a if/else
            if (menuChoice == 1)
            {
                // Do the option 1 stuff.
            }
            else if (menuChoice == 2)
            {
                // Do the option 2 stuff.
            }
            else if (menuChoice == 3)
            {
                // Do the option 1 stuff.
            }
            else
            {
                // Invalid menu choice.
            }

        }
    }
}
 