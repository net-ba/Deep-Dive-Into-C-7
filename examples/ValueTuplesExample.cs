using System;
using System.Collections.Generic;
using System.Text;

namespace JakubSturc.CSharp7DeepDive.Examples
{
    public class ValueTuplesExample
    {
        public class SystemTupleExample
        {
            public Tuple<string, int> GetPerson()
            {
                return new Tuple<string, int>("Fero", 22);
            }

            public void Print()
            {
                var person = GetPerson();
                Console.Write($"Name:{person.Item1}; Age:{person.Item2}");
            }
        }

        public class ValueTupleExample
        {
            public (string, int) GetPerson()
            {
                return ("Fero", 22);
            }

            public void Print()
            {
                var person = GetPerson();                
                Console.Write($"Name:{person.Item1}; Age:{person.Item2}");
            }

            public void Conversion()
            {
                // covariace
                (int, int) ints = (0, 42);
                (double, double) doubles = ints;
                
                // names are only compile time hints
                var feroWithAge = (name: "Fero", age: 42);
                (string name, int heigh) feroWithHeight = feroWithAge;
            }
        }

        public class NamedValueTupleExample
        {
            public (string name, int age) GetPerson()
            {
                return (name: "Fero", age: 22);
            }

            public void Print()
            {                
                var person = GetPerson();
                person.age += 42;
                Console.Write($"Name:{person.name}; Age:{person.age}");
            }
        }
    }
}
