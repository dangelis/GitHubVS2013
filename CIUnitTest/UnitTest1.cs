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

            if (sumClassToTest.TheSum != x + y)
            {
                var fileName = @"C:\Users\Public\tmpTest\CIDemoOut.txt";
                Console.WriteLine("Unexpected sum, writing to {0}!", fileName);
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
                {
                    file.WriteLine(sumClassToTest.TheSum);
                }
            }

            Assert.AreEqual(sumClassToTest.TheSum, x + y);
        }
    }
}
