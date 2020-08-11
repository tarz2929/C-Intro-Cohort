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
                Console.WriteLine("The number "+number+" is even.");
            }
            else
            {
                Console.WriteLine("The number "+number+" is odd.");
            }


        }
    }
}
 