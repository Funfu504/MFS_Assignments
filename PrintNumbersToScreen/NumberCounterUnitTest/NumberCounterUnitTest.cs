using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace NumberCounterUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NegativeNumberTest()
        {
            Assert.Throws<System.Exception>(() => NumberCounter.NumberCounter.PrintNumbers(-1, "Maurice", "Smith"));
        }

        [Test]
        public void DivisibleBy3()
        {
            Assert.IsTrue(NumberCounter.NumberCounter.isDivisibleBy3(6));
        }

        [Test]
        public void NotDivisibleBy3()
        {
            Assert.IsFalse(NumberCounter.NumberCounter.isDivisibleBy3(5));
        }

        [Test]
        public void DivisibleBy5()
        {
            Assert.IsTrue(NumberCounter.NumberCounter.isDivisibleBy5(10));
        }

        [Test]
        public void NotDivisibleBy5()
        {
            Assert.IsFalse(NumberCounter.NumberCounter.isDivisibleBy5(11));
        }

        /// <summary>
        /// Functional Test to confirm the method in it's entirety.
        /// </summary>
        [Test]
        public void PrintNumbersFunctionalTest()
        {
            var actual = NumberCounter.NumberCounter.PrintNumbers(15, "Forest", "Gump");

            List<string> expected = new List<String>() { "1", "2", "Forest", "4", "Gump", "Forest", "7", "8", "Forest", "Gump", "11", "Forest", "13", "14", "Forest Gump" };

            Assert.IsTrue(actual.Count == 15);

            for (int index = 0; index < 15; index++)
            {
                Assert.IsTrue(expected[index].Equals(actual[index]));
            }            
        }
    }
}