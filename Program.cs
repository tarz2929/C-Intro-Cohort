using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Please enter a your age: ");
            age = int.Parse(Console.ReadLine());

            if (age > 5)
            {
                Console.WriteLine("You are older than five years old.");
            }
            // Without else, the second check is run. With else, only if the first check is false.
            if (age > 10)
            {
                Console.WriteLine("You are older than ten years old.");
            }
            

        }
    }
}
 