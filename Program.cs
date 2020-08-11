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

            int userNumber;

            Console.Write("Please enter a number: ");
            userNumber = int.Parse(Console.ReadLine());


            if (Math.Sqrt(userNumber) % 1 == 0)
            {
                Console.WriteLine("That number is a perfect square.");
            }
            else 
            {
                Console.WriteLine("That number is not a perfect square.");
            }



            /*
                Pseudo-code
                -declare variables (input from user)
                -get input from the user (number to check)
                if the number is a perfect square 
                    -output "number is perfect square"
                otherwise
                    -output "number is not perfect square"
            */


        }
    }
}
 