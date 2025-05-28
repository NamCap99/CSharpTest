using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.Question
{
    // public delegate string showLog(string mess);
    // public delegate int Type1();
    public class delegateExample
    {
        static void showInfo(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Show Info\n" + s);
            Console.ResetColor();
        }
        static void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Warning\n" + s);
            Console.ResetColor();
        }
        static void Warning2(string s, int number)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Warning 2\n" + s);
            Console.ResetColor();
        }

        public static void Run()
        {
            Action action; // return void ==> return nothing // equivalent ~ delegate void Type();
            Action<string> action1; // deleaget void Type(string s)
            // Action<string, int> action2;
            action1 = showInfo;
            action1 += Warning;
            // action2 = Warning;
            action1?.Invoke("Notice from Action");
            // action2 += showInfo;

            Func<int> f1; // ~~ delegate int Type()
            Func<string, bool, string> f2; // ~ delegate string Type(string s, bool check);
                                           // tại sao biết ở đây là delegate kiểu string. 
            /* Chúng ta nhìn vào <string, bool, string> nghĩa là giá trị thứ 3 = string 
            --> delagate là string. 
            Và string thứ 1 và bool thứ 2
            --> Type(string s, bool check);
            */

        }
    }
}