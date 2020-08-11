using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double leftOperand, rightOperand, result;

            Console.WriteLine("Please enter the left operand: ");
            leftOperand = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the right operand: ");
            rightOperand = int.Parse(Console.ReadLine());
            
            result = leftOperand * rightOperand;

            Console.WriteLine("The result of "+leftOperand+" * "+rightOperand+ " is: "+result);

            // Remember that dividing an integer by an integer will always produce an integer (no decimals).
            
        }
    }
}
 