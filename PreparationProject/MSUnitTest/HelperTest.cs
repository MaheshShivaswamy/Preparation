using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelperLibrary;

namespace MSUnitTest
{
    [TestClass]
    public class HelperTest
    {
        [TestMethod]
        public void ShouldReturnSumOfNumbers()
        {
            int A = 3;
            int B = 2;
            int expected = 5;

            Helper helper = new Helper();
            var actual = helper.AddNumbers(A, B);

            Assert.AreEqual(expected, actual);
        }
    }
}
