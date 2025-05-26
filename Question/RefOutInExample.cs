using System;

namespace MyCSharpNote.Question
{
    public class RefOutInExample
    {
        public static void Modify(ref int a, out int b, in int c)
        {
            a += 10;        // allowed
            b = 100;        // must assign in method
            // c += 5;      // ❌ not allowed — 'in' is read-only

            Console.WriteLine($"Inside method: a = {a}, b = {b}, c = {c}");
        }

        public static void Run()
        {
            int x = 5;
            int y;          // does not need to be initialized
            int z = 20;

            Modify(ref x, out y, in z);

            Console.WriteLine($"After method: x = {x}, y = {y}, z = {z}");
        }
    }
}
