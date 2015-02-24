using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedPill.Business;

namespace Readify_RedPill_Tests
{
    [TestClass]
    public class ReverseWordsManagerTests
    {
        [TestMethod]
        [ExpectedExceptionAttribute(typeof(ArgumentNullException))]
        public void TestNullStringParamTestMethod()
        {
            ReverseWordsManager.Reverse(null);
        }

        [TestMethod]
        public void ReverseTestMethod()
        {
            string expected = @"hello";
            string actual = ReverseWordsManager.Reverse(@"olleh");
            Assert.AreEqual(expected, actual);

            expected = @"dlrow olleh";
            actual = ReverseWordsManager.Reverse(@"hello world");
            Assert.AreEqual(expected, actual);
        }
    }
}
