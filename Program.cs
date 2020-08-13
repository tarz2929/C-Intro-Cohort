using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = -1, favourite = -1;

            age = GetValidInt("Please enter your age: ");
     
            favourite = GetValidInt("Please enter your favourite number: ");

            Console.WriteLine($"Your age is {age}, your favourite number is {favourite}.");


        }
        static int GetValidInt(string prompt)
        {
            bool valid = false;
            int myInt = -1;

            do
            {
                Console.Write(prompt);
                try
                {
                    myInt = int.Parse(Console.ReadLine());
                    valid = true;
                }
                catch 
                {
                    Console.WriteLine("Parse failed, please ensure you have entered an integer.");
                }
            } while (!valid);

            return myInt;
        }
    }
}
