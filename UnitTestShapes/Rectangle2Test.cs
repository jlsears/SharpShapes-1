using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Linq;
using System.Reflection;

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

        [TestMethod]
        public void TestCorrectNumberofArguments()
        {
            var theClass = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.Name == "Rectangle2").First();
            var theClassConstructor = theClass.GetConstructors().First();
            Assert.AreEqual(2, theClassConstructor.GetParameters().Length);
        }
    }

}
