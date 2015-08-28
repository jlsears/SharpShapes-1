using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTest
    {
        public class RectangleTestClass : Rectangle
        {
            public override float Perimeter()
            {
                throw new NotImplementedException();
            }

        }

        [TestMethod]
        public void TestRectangleCalcArea()
        {
            Rectangle myRec = new Rectangle();
            myRec.height = 2;
            myRec.width = 3;
            Assert.AreEqual(myRec.Area(), 6);
        }
    }

}
