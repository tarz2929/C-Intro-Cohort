using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("Please enter a number: ");
            number = int.Parse(Console.ReadLine());

            // Ternary Expression
            Console.WriteLine("The number "+number+" is "+ (number % 2 == 0 ? "even" : "odd") + ".");


        }
    }
}
 