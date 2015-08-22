using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes; //added this

namespace UnitTestShapes
{
    [TestClass]
    public class QuadrilateralTests
    {
        public class QuadTestClass : Quadrilateral
        {
            public override float Area()
            {
                throw new NotImplementedException();
            }
        }

        [TestMethod]
        public void TestQuadrilateralCanComputePerimeter()
        {
            QuadTestClass myQuadrilatral = new QuadTestClass();
            myQuadrilatral.Side1 = 2;
            myQuadrilatral.Side2 = 4;
            myQuadrilatral.Side3 = 99;
            myQuadrilatral.Side4 = 6;
            Assert.AreEqual(myQuadrilatral.Perimeter(), 111);
        }
    }
}
