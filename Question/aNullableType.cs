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
            int? age = null;
            if (age.HasValue)
            {
                Console.WriteLine($"Age is {age.Value}");
            }
            else
            {
                Console.WriteLine("Age is not provided");
            }

            // using coalesing operator
            int displayAge = age ?? -1;
            Console.WriteLine($"Display Age: {displayAge}");
        }
    }
}