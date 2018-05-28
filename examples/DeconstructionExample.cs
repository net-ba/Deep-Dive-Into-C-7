using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JakubSturc.CSharp7DeepDive.Examples
{
    [TestClass]
    public class DeconstructionExample
    {
        [TestMethod]
        public void DeconstuctingTuple()
        {
            var fero = (name: "Fero", age: 42);
            (var name, var age) = fero;
            Assert.AreEqual("Fero", name);
            Assert.AreEqual(42, age);
        }

        public class Person
        {
            public string Name { get; }
            public int Age { get; }
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void Deconstruct(out string name, out int age)
            {
                name = Name;
                age = Age;
            }
        }

        [TestMethod]
        public void DeconstuctingCustomTypes()
        {
            var fero = new Person(name: "Fero", age: 42);
            (var name, var age) = fero;
            Assert.AreEqual("Fero", name);
            Assert.AreEqual(42, age);
        }
    }
}
