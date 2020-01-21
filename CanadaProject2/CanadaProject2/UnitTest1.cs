using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CanadaProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            Square s3 = s1;

            Assert.AreEqual(s1.getSize(), 5);
            Assert.AreEqual(s2.getSize(), 10);
            Assert.AreEqual(s3.getSize(), 5);

            s3.setSize(15);

            Assert.AreEqual(s1.getSize(), 15);


        }
    }
}
