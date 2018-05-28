using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    [TestClass]
    public class ValutTupleTests
    {
        [TestMethod]
        public void Tuples_Are_Mutable()
        {
            var fero = (name: "Fero", age: 42);
            fero.age++;
            Assert.AreEqual(43, fero.age);
        }

        [TestMethod]
        public void Tuples_Are_Equalable()
        {
            var fero = (name: "Fero", age: 42);
            var nero = (abc: "Fero", size: 42);
            Assert.IsTrue(fero.Equals(nero));
        }

        [TestMethod]
        public void Tuples_Are_Comparable()
        {
            var fero = (name: "Fero", age: 42);
            var nero = (name: "Fero", age: 43);
            Assert.IsTrue(0 > fero.CompareTo(nero));
        }
    }
}
