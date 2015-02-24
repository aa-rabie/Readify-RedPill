using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedPill.Business;

namespace Readify_RedPill_Tests
{
    [TestClass]
    public class FibonacciManagerTests
    {
        [TestMethod]
        public void FibonacciOfZeroTestMethod()
        {
            var actual = FibonacciManager.Calculate(0);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciOfOneTestMethod()
        {
            var actual = FibonacciManager.Calculate(1);
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciOfTwentyTestMethod()
        {
            var actual = FibonacciManager.Calculate(20);
            var expected = 6765;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FibonacciNegativeNumbersTestMethod()
        {
            long[] values = { -8,-7,-6,-5,-4,-3,-2,-1 };
            long[] expected = { -21 ,13,-8,5,-3,2,-1, 1 };
            for (byte index = 0; index < values.Length; index++)
            {
                Assert.AreEqual(FibonacciManager.Calculate(values[index]), expected[index]);
            }
        }
    }
}
