using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote
{
    public class valueTypeAndReferenceType
    {
        struct Point
        {
            public int X, Y; // value type
        }
        class Person
        {
            public string Name; // reference Type
        }

        public static void Run()
        {
            Point a = new Point { X = 1, Y = 2 };
            Point b = a; // copy by value
            b.X = 10;
            Console.WriteLine($"a.X = {a.X}"); // Output = 1

            Person p1 = new Person { Name = "William" };
            Person p2 = p1;
            p2.Name = "Nam Cap";
            Console.WriteLine($"p1.Name = {p1.Name}");
        }
    }
}