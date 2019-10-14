using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestHypotenuseResult()
        {
            Triangle obj = new Triangle();
            float result = obj.CalculateHypotenuse(3, 4);
            Assert.AreEqual(5, result);
        }
    }
}
