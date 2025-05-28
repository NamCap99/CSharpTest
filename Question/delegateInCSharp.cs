using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.Question
{
    delegate int Calculator(int a, int b);
    public class delegateInCSharp
    {
        // public static int Add(int a, int b)
        // {
        //     return a + b;
        // }

        public static int Substract(int a, int b)
        {
            return a - b;
        }

        public static void Run()
        {
            Calculator cal = delegate (int x, int y)
            {
                return x + y;
            };
            int result = cal(10, 8);
            System.Console.WriteLine("Add = " + result);
            cal = new Calculator(Substract);
            int result2 = Substract(10, 8);
            System.Console.WriteLine("Subtract = " + result2);
            System.Console.WriteLine("Add = " + result);
        }
    }
}