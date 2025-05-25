using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.Question
{
    public class equalInCSharp
    {
        public static void Run()
        {
            string a = "Hello";
            string b = new string("Hello".ToCharArray());
            // == returns true because string overrides == compare the content instead of references 
            Console.WriteLine(a == b); // return true 
            Console.WriteLine(a.Equals(b)); // return true

            object x = a, y = b;
            Console.WriteLine(x == y); // return false becase x and y refer to difference object
            Console.WriteLine(x.Equals(y)); // return true because both x and y refer to the same content
        }
    }
}