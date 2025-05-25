using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCSharpNote.Question
{
    public class aNullObject
    {
        class Person
        {
            public string Name { get; set; }
            public void Greet() => Console.WriteLine($"Hello, Im {Name}");
        }

        public static void Run()
        {
            Person person = null; // when person is null
                                  // Person person = new Person { Name = "Nam Cap" };// when person is not null
                                  // person.Greet();// would throw NullReferenceException
                                  // if (person != null)
                                  // {
                                  //     person.Greet();
                                  // }
                                  // else
                                  // {
                                  //     Console.WriteLine("person is null. Greet failed");
                                  // }
                                  // simply does nothing
            person?.Greet();
        }
    }
}