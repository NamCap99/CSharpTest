using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.Question
{
    public class boxingUnboxing
    {
        public static void RunUseGeneric()
        {
            //use generic
            List<int> list = new List<int>();
            list.Add(123);
            list.Add(456);

            Print(list);
        }

        public static void RunWithBoxingUnBoxing()
        {
            ArrayList list = new ArrayList();
            list.Add(789); // boxing happens here --> (int --> object)

            // Access the unbox
            int number = (int)list[0]; // uboxing
            Console.WriteLine("box value = " + list[0] + ", unbox value = " + number);
        }

        public static void Print(List<int> list)
        {
            Console.WriteLine("Use generic: ");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}