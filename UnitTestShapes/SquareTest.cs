using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTest
    {
        public class SquareTestClass : Square
        {
            public override float Perimeter()
            {
                throw new NotImplementedException();
            }
        }
        [TestMethod]
        public void TestSquareCalcArea()
        {
            SquareTestClass mySqu = new SquareTestClass();
            mySqu.side = 2;
            Assert.AreEqual(mySqu.Area(), 8);
        }
    }
}
