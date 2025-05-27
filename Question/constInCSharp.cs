using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.obj
{
    public class constInCSharp
    {
        static int number = 0;

        public constInCSharp()
        {
            number += 1;
            System.Console.WriteLine("For the first object = " + number);
        }

        public static void Run()
        {
            constInCSharp p1 = new constInCSharp();
            constInCSharp p2 = new constInCSharp();
            constInCSharp p3 = new constInCSharp();
            constInCSharp p4 = new constInCSharp();
        }
    }
}