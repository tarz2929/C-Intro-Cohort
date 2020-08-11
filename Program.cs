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

            if (number % 2 == 0)
            {
                // Concatenation
                // Console.WriteLine("The number "+number+" is even.");
                // Parameterized Output
                // Console.WriteLine("The number {0} is even.", number);
                // String Interpolation
                Console.WriteLine($"The number {number} is even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd.");
            }


        }
    }
}
 