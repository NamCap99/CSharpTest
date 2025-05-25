using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.Question
{
    public class aNullableType
    {
        public static void Run()
        {
            int? age = 30;
            if (age.HasValue)
            {
                Console.WriteLine($"Age is {age.Value}");
            }
            else
            {
                Console.WriteLine("Age is not provided");
            }
        }
    }
}