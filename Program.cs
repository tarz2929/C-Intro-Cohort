using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 5;
            int[] myNumbers = {3, 7, 12, 42, 56, 100};

            int newNum = myNum;
            int[] myNewNumbers = myNumbers;

            Console.WriteLine("BEFORE:");
            Console.WriteLine($"myNum: {myNum} | newNum: {newNum}");
            Console.WriteLine($"myNumbers[1]: {myNumbers[1]} | newNumbers[1]: {myNewNumbers[1]}");
            Console.WriteLine($"myNumbers[3]: {myNumbers[3]} | newNumbers[3]: {myNewNumbers[3]}");


            myNewNumbers[3] = 125;
            // will ALSO change myNumbers[3] to 125 because they are both pointing to the SAME array in memory

            Console.WriteLine("AFTER:");
            Console.WriteLine($"myNum: {myNum} | newNum: {newNum}");
            Console.WriteLine($"myNumbers[1]: {myNumbers[1]} | newNumbers[1]: {myNewNumbers[1]}");
            Console.WriteLine($"myNumbers[3]: {myNumbers[3]} | newNumbers[3]: {myNewNumbers[3]}");
        }
        
    }
}
