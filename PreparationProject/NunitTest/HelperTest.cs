using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HelperLibrary;

namespace NunitTest
{
    [TestFixture]
    public class HelperTest
    {
        [Test]
        public void TestMethod1()
        {
            int A = 2;
            int B = 3;
            int expected = 5;

            Helper helper = new Helper();
            int actual = helper.AddNumbers(A, B);

            Assert.AreEqual(expected, actual);
        }
    }
}
