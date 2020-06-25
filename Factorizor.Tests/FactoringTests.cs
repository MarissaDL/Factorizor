using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Factorizor.BLL;

namespace Factorizor.Tests
{
    [TestFixture]
    public class FactoringTests
    {
        [Test]
        public void TestSimple()
        {
            int[] result = FactorFinder.Execute(13);
            Assert.AreEqual(2, result.Length);
        }

        [Test]
        public void TestNonPrime()
        {
            int[] result = FactorFinder.Execute(42);
            //1, 2, 3, 6, 7, 14, 21, 42
            Assert.AreEqual(8, result.Length);
        }

        [TestCase(13, new int[] {1, 13})]
        [TestCase(42, new int[] { 1, 2, 3, 6, 7, 14, 21, 42})]
        public void TestWithTestCase(int number, int[] factors)
        {
            int[] result = FactorFinder.Execute(number);
            Assert.AreEqual(factors.Length, result.Length);
        }
    }
}
