using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class Rectangle2Test
    {

        [TestMethod]
        public void TestRectangle2CalcArea()
        {
            Rectangle2 myRec = new Rectangle2(2, 3);
            Assert.AreEqual(myRec.Area(), 6);
        }

        [TestMethod]
        public void TestRectangle2CalcPerimeter()
        {
            Rectangle2 myRec = new Rectangle2(2, 3);
            Assert.AreEqual(myRec.Perimeter(), 10);
        }
    }

}
