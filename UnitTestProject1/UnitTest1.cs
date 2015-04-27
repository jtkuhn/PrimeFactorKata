using System.Collections.Generic;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using PrimeFactorKata;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        private PrimeFactors numberToFactor;
        List<int> list;

        [SetUp]
        public void Init()
        {
            list = new List<int>();
            numberToFactor =  new PrimeFactors();
        }

        [Test]
        public void Test1()
        {
            numberToFactor.SetNumber(1);
            Assert.IsEmpty(numberToFactor.GetPrimeFactors());
        }

        [Test]
        public void Test2()
        {
            list.Add(2);
            numberToFactor.SetNumber(2);
            Assert.AreEqual(list, numberToFactor.GetPrimeFactors());
        }

        [Test]
        public void Test4()
        {
            list.Add(2);
            list.Add(2);
            numberToFactor.SetNumber(4);
            Assert.AreEqual(list, numberToFactor.GetPrimeFactors());
        }

        [Test]
        public void Test3()
        {
            list.Add(3);
            numberToFactor.SetNumber(3);
            Assert.AreEqual(list, numberToFactor.GetPrimeFactors());
        }

        [Test]
        public void Test6()
        {
            list.Add(2);
            list.Add(3);
            numberToFactor.SetNumber(6);
            Assert.AreEqual(list, numberToFactor.GetPrimeFactors());
        }

        [Test]
        public void Test10()
        {
            list.Add(2);
            list.Add(5);
            numberToFactor.SetNumber(10);
            Assert.AreEqual(list, numberToFactor.GetPrimeFactors());
        }

        [Test]
        public void Test180()
        {
            list.Add(2);
            list.Add(2);
            list.Add(3);
            list.Add(3);
            list.Add(5);
            numberToFactor.SetNumber(180);
            Assert.AreEqual(list, numberToFactor.GetPrimeFactors());
        }

        [Test]
        public void Test368()
        {
            list.Add(2);
            list.Add(2); 
            list.Add(2);
            list.Add(2);
            list.Add(23);
            numberToFactor.SetNumber(368);
            Assert.AreEqual(list, numberToFactor.GetPrimeFactors());
        }

        [TestCase(20, new[] {2, 2, 5})]
        [TestCase(25, new[] {5, 5})]
        public void Test20(int number, IEnumerable<int> expectedPrimes)
        {
            numberToFactor.SetNumber(number);
            Assert.AreEqual(expectedPrimes, numberToFactor.GetPrimeFactors());
        }
    }
}
