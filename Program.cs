using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuOption = -1;
            
            while (menuOption != 0)
            {
                Console.WriteLine("Menu\n------\n1. Option 1\n2. Option 2\n3. Option 3\n4. Option 4\n0. Exit");

                Console.Write("Please enter a menu option:");
                menuOption = int.Parse(Console.ReadLine());

                switch (menuOption)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Running option {0}.", menuOption);
                        break;
                    default:
                        Console.WriteLine("Not a valid menu option.");
                        break;
                }
            }
        }
    }
}
 