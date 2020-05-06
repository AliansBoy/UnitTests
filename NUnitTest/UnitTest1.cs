using HomeWork_1_Library;
using NUnit.Framework;
using System;

namespace NUnitTest
{
    public class Tests
    {
        private QuadraticLibraty quadraticLibraty;
        [SetUp]
        public void Setup()
        {
            quadraticLibraty = new QuadraticLibraty();
        }

        [TestCase(2, 5, -7, new double[] { -3.5, 1 })]
        [TestCase(1, 3, -4, new double[] { -4, 1 })]
        [TestCase(1, 6, 9, new double[] { -3, -3 })]
        [TestCase(16, -8, 1, new double[] { 0.25, 0.25 })]
        [TestCase(double.MinValue, 3, 7, new double[] { double.NaN, double.NaN })]
        [TestCase(3, double.MinValue, 9, new double[] { double.NegativeInfinity, double.PositiveInfinity })]
        public void GetResult_CorrectValues(double a, double b, double c, double[] expectedResult)
        {
            var actualResult = quadraticLibraty.GetResult(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase(0, 5, -7)]
        public void GetResult_FirstCoeficientZero(double a, double b, double c)
        {
            Assert.Throws<InvalidOperationException>(() => quadraticLibraty.GetResult(a, b, c));
        }

        [TestCase(5, 3, 7)]
        [TestCase(6, 1, 1)]
        public void GetResult_InvalidValues(double a, double b, double c)
        {
            Assert.Throws<OperationCanceledException>(() => quadraticLibraty.GetResult(a, b, c));
        }
    }
}