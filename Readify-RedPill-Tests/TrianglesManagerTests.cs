using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RedPill.Business;

namespace Readify_RedPill_Tests
{
    [TestClass]
    public class TrianglesManagerTests
    {
        [TestMethod]
        public void TriangleInvalidParamsTestMethod()
        {
            var expected = TriangleType.Error;
            var actual = TrianglesManager.GetType(-1, 1, 1);
            Assert.AreEqual(expected, actual);
            
            actual = TrianglesManager.GetType(1, 0, 1);
            Assert.AreEqual(expected, actual);
            
            actual = TrianglesManager.GetType(1, 1, -1);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EquilateralTriangleTestMethod()
        {
            var expected = TriangleType.Equilateral;
            var actual = TrianglesManager.GetType(1, 1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsoscelesTriangleTestMethod()
        {
            var expected = TriangleType.Isosceles;
            var actual = TrianglesManager.GetType(1, 1, 5);
            Assert.AreEqual(expected, actual);

            actual = TrianglesManager.GetType(1, 5, 5);
            Assert.AreEqual(expected, actual);

            actual = TrianglesManager.GetType(5, 6, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ScaleneTriangleTestMethod()
        {
            var expected = TriangleType.Scalene;
            var actual = TrianglesManager.GetType(1, 2, 5);
            Assert.AreEqual(expected, actual);

            
        }
    }
}
