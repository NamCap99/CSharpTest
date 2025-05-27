using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.Question
{
    public class readonlyInCSharp
    {
        public readonly string AccountId; // readonly -- locked after constructor

        public readonlyInCSharp(string id)
        {
            AccountId = id;
        }
        public void Print()
        {
            System.Console.WriteLine("Account id = " + AccountId);
        }
        public static void Run()
        {
            readonlyInCSharp acc = new readonlyInCSharp("ABCXYZ");
            // acc.AccountId = "ok or not"; // compile-time error because cant change readonly field
            acc.Print();
        }
    }
}