using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class Square2Test
    {
        [TestMethod]
        public void TestSquare2CalcArea()
        {
            Square2 mySqu = new Square2(2);
            Assert.AreEqual(mySqu.Area(), 4);
        }

        [TestMethod]
        public void TestSquare2CalcPerimeter()
        {
            Square2 mySqu = new Square2(2);
            Assert.AreEqual(mySqu.Perimeter(), 8);
        }
    }

}
