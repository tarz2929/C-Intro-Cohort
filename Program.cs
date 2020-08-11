using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // > - Greater Than
            // < - Less Than
            // >= - Greater Than or Equal To
            // <= - Less Than or Equal To
            // == - Equal To
            // != - Not Equal To

            // && - And (True if both are true)
            // || - Or (True if one is true)

            string password;

            Console.WriteLine("Please enter your password: ");
            password = Console.ReadLine();

            if (password == "Hello123")
            {
                // This code is executed if the condition evaluates to true.
                Console.WriteLine("The answer to life, the universe and everything is 42.");
            }
            // If the condition evaluates to false, nothing happens.

        }
    }
}
 