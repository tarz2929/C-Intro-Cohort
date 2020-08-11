using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            bool valid = false;
            
            Console.Write("Please enter a single word that does not contain the letter e, and does not start with a capital letter: ");
            userInput = Console.ReadLine();

            while (!valid) 
            {
                valid = true;

                if (userInput.Contains(' '))
                {
                    valid = false;
                    Console.WriteLine("Your input contains a space and is therefore more than one word.");
                }
                if (userInput.Contains('e'))
                {
                    valid = false;
                    Console.WriteLine("Your input contains the letter e.");
                }
                if (char.IsUpper(userInput[0]))
                {
                    valid = false;
                    Console.WriteLine("Your input has a first character that is a capital letter.");
                }

                if (!valid)
                {
                    Console.Write("Please try again. Please enter a single word that does not contain the letter e, and does not start with a capital letter: ");
                    userInput = Console.ReadLine();
                }
            }

        }
    }
}
 