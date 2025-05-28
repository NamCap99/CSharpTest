using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.Question
{
    public class Person
    {
        string Name;

        public void Greet()
        {
            Person p = new Person();
            p.Name = "Nam Cap";
            System.Console.WriteLine($"My name is {Name}");
        }
        // public static void Run()
        // {   
        // }
    }
}