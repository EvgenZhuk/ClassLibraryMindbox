using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShapeLib_MindBox.Tests
{
    [TestClass]
    public class ShapeLib_MindBoxTests
    {
        [TestMethod]
        public void TriangleArea_6returned()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            // act
            Triangle TR = new Triangle(a, b, c);
            double actual = TR.GetArea();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CircleArea_314returned()
        {
            // arrange
            double a = 1;
            double expected = 3.141592653589793;

            // act
            Circle R = new Circle(a);
            double actual = R.GetArea();

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
