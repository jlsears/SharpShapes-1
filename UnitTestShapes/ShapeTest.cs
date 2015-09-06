using System;
using System.Windows.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;

namespace UnitTestShapes
{
    [TestClass]
    public class ShapeTest
    {
        public class ConcreteShape : Shapes.Shape
        {
            public ConcreteShape()
            {
                BorderColor = Colors.NavajoWhite;
                FillColor = Colors.PapayaWhip;
            }
        }

        [TestMethod]
        public void TestAbstractShapeHasBorderColor()
        {
            ConcreteShape cs = new ConcreteShape();
            Assert.AreEqual(Colors.NavajoWhite, cs.BorderColor);
        }

        [TestMethod]
        public void TestAbstractShapeHasFillColor()
        {
            ConcreteShape cs = new ConcreteShape();
            Assert.AreEqual(Colors.PapayaWhip, cs.FillColor);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestAbstractShapeHasArea()
        {
            ConcreteShape cs = new ConcreteShape();
            cs.Area();
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void TestAbstractShapeHasPerimeter()
        {
            ConcreteShape cs = new ConcreteShape();
            cs.Perimeter();
        }

        [TestMethod] // Make sure what you think and what system thinks is the same thing
        public void FindShapesTest()
        {
            List<string> classes = new List<string> { "Square", "Rectangle", "Shape" };
            CollectionAssert.AreEqual(classes, Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes());
        }

        [TestMethod]
        public void TestSquareIsASubclassOfRectangle2()
        {
            Assert.IsTrue(typeof(Shapes.Square2).IsSubclassOf(typeof(Shapes.Rectangle2)));
        }

        [TestMethod]
        public void TestSquareIsASubclassQuadrilateral()
        {
            Assert.IsTrue(typeof(Shapes.Square).IsSubclassOf(typeof(Shapes.Quadrilateral)));
        }

    }
}