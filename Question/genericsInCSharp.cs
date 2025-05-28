using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.Question
{
    public class genericsInCSharp
    {
        // Non generic
        // public int Max(int a, int b)
        // {
        //     return a > b ? a : b;
        // }
        public static void Run()
        {
            // genericsInCSharp cal = new genericsInCSharp();
            int result = MaxGeneric(5, 8);

            System.Console.WriteLine("Max value = " + result);
        }

        // Generic
        public static T MaxGeneric<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}