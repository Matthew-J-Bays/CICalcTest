using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorForTests;

namespace CalcTests
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcConstructorTest()
        {
            Calculations calcObject = new Calculations();
        }

        [TestMethod]
        public void AddNumbersTest()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Add(3, 5);
            int expectedValue = 8;
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void SubtractNumbersTest()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Sub(32, 4);
            int expected = 28;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void DivideByZeroTest()
        {
            Calculations calcObject = new Calculations();
            double result = calcObject.Div(32, 0);
        }
        public void NormalDivTest()
        {
            Calculations calcObject = new Calculations();
            double result = calcObject.Div(32, 4);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void MidRandomTest1()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Mid(1, 2, 3);
            Assert.AreEqual(2, result);
        }
    } 
}