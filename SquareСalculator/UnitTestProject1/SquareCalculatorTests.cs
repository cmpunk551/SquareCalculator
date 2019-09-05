using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareСalculatorLibrary;


namespace UnitTestSquareCalculator
{
    [TestClass]
    public class SquareCalculatorTests
    {
        [TestMethod]
        public void CirclesSquareTest()
        {
            double testRadius = 4.564;

            double result = SquareСalculator.CalculateSquare(testRadius);
            Assert.AreEqual(result, Math.Pow(testRadius,2) * Math.PI);

        }
        [TestMethod]
        public void TrianglesSquareTest()
        {
            double testFirstSide = 5;
            double testSecondSide = 9;
            double testThirdSide = 7;
            double testHalfOfPerimeter = 0.5 * (testFirstSide + testSecondSide + testThirdSide);

            double expectedSquare = Math.Sqrt(testHalfOfPerimeter * (testHalfOfPerimeter - testFirstSide) * (testHalfOfPerimeter - testSecondSide) * (testHalfOfPerimeter - testThirdSide));

            double result = SquareСalculator.CalculateSquare(testFirstSide,testSecondSide,testThirdSide);

            Assert.AreEqual(result, expectedSquare);
        }
    }
}
