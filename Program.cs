using System;
using System.Collections.Generic;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray;
            List<int> intList = new List<int>();

            intList.Add(7);

            intList.Add(42);

            intList.Remove(7);

            intList.RemoveAt(0);

            Console.WriteLine(intList.Count);
        }
    }
}
