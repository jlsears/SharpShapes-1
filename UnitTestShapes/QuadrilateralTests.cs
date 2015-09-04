using System;
using Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestShapes
{
    [TestClass]
    public class QuadrilateralTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadHasDefaultSize()
        {
            Quadrilateral myquad = new Quadrilateral();
            myquad.Perimeter();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadNoNegativeSides()
        {
            Quadrilateral myquad = new Quadrilateral();
            myquad.Top = 2;
            myquad.Right = 2;
            myquad.Left = -2;
            myquad.Bottom = 2;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestQuadNoNegativeSidesInConstructor()
        {
            Quadrilateral myquad = new Quadrilateral(2, -2, 2, 2);
        }

        [TestMethod]
        public void TestQuadCanComputePerimeter()
        {
            Quadrilateral myquad = new Quadrilateral();
            myquad.Top = 2;
            myquad.Right = 2;
            myquad.Left = 2;
            myquad.Bottom = 2;
            Assert.AreEqual(8, myquad.Perimeter());
        }

        [TestMethod]
        public void TestQuadCanComputePerimeter2()
        {
            Quadrilateral myquad = new Quadrilateral(2, 2, 2, 2);
            Assert.AreEqual(8, myquad.Perimeter());
        }

        [TestMethod]
        public void TestQuadPerimetersAreTheSame()
        {
            Quadrilateral myquad1 = new Quadrilateral();
            myquad1.Top = 2;
            myquad1.Right = 2;
            myquad1.Left = 2;
            myquad1.Bottom = 2;
            Quadrilateral myquad2 = new Quadrilateral(2, 2, 2, 2);
            Assert.AreEqual(myquad1.Perimeter(), myquad2.Perimeter());
        }

        [TestMethod] // Note the "ExpectedException" here
        [ExpectedException(typeof(NotImplementedException))]
        public void TestQuadCanComputeArea()
        {
            Quadrilateral myquad = new Quadrilateral();
            myquad.Area();
        }

        [TestMethod] // Outputs are 3 because: 2 + 1 (50% of 2) = 3
        public void QuadScalingUpTest()
        {
            Quadrilateral myquad = new Quadrilateral(2, 2, 2, 2);
            myquad.Scale(50);
            Assert.AreEqual(3, myquad.Top);
            Assert.AreEqual(3, myquad.Bottom);
            Assert.AreEqual(3, myquad.Left);
            Assert.AreEqual(3, myquad.Right);
        }

        [TestMethod]
        public void QuadScaleDownTest()
        {
            // Negative scaling
            // Likewise, 10 - 5 (50% of 10) = 5
            Quadrilateral myquad = new Quadrilateral(10, 10, 10, 10);
            myquad.Scale(-50);
            Assert.AreEqual(5, myquad.Top);
            Assert.AreEqual(5, myquad.Bottom);
            Assert.AreEqual(5, myquad.Left);
            Assert.AreEqual(5, myquad.Right);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidScaleArg()
        {
            Quadrilateral myquad = new Quadrilateral(2, 2, 2, 2);
            myquad.Scale(0);
        }

    }
}