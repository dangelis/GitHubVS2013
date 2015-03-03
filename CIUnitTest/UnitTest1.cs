using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CIDemo;

namespace CIUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSumClass()
        {
            int x = 2;
            int y = 2;

            var sumClassToTest = new SumClass(x, y);

            Assert.AreEqual(sumClassToTest.TheSum, x + y);
        }
    }
}
