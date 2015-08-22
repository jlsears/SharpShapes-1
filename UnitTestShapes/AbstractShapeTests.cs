using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Drawing;

namespace UnitTestShapes
{
    [TestClass]
    public class AbstractShapeTests
    {
        private class MyMockShape : Shape
        {
            public override float Area()
            {
                throw new NotImplementedException();
            }

            public override float Perimeter()
            {
                throw new NotImplementedException();
            }
        }

        MyMockShape omgMyShape = new MyMockShape();

        [TestMethod]
        public void TestThatAbstractShapeClassHasFillColor()
        {
            omgMyShape.FillColor = Color.PapayaWhip;
            Assert.AreEqual(Color.PapayaWhip, omgMyShape.FillColor);
        }

        [TestMethod] // testm tab tab (shortcut)
        public void TestThatAbstractShapeClassHasBorderColor()
        {
            omgMyShape.BorderColor = Color.NavajoWhite;
            Assert.AreEqual(Color.NavajoWhite, omgMyShape.BorderColor);
        }
    }
}
