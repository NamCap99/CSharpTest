using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.Question
{
    delegate int Calculator(int a, int b);
    public class delegateInCSharp
    {
        public static int Sum(int a, int b) => a + b;

        public static int Substract(int a, int b) => a - b;

        public static void Run()
        {
            System.Console.WriteLine("App is running...");

            Func<int, int, int> cal; // ~ delegate int Type(int a, int b);
            cal = Sum;

            System.Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine()); ;

            System.Console.WriteLine($"Sum = {cal(firstNumber, secondNumber)}");

            cal += Substract;
            System.Console.WriteLine($"Substract = {cal(firstNumber, secondNumber)}");
        }
    }
}