using System;
using NUnit.Framework;
using SimpleFactory;

namespace Tests
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetResultTestAdd()
        {
            var calculator = new Calculator();
            calculator.Operation = "+";
            calculator.V1 = 1;
            calculator.V2 = 2;
            var result = calculator.GetResult();
            Assert.AreEqual(3, result);
        }

        [Test]
        public void GetResultTestSub()
        {
            var calculator = new Calculator();
            calculator.Operation = "-";
            calculator.V1 = 3;
            calculator.V2 = 2;
            var result = calculator.GetResult();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void GetResultTestMul()
        {
            var calculator = new Calculator();
            calculator.Operation = "*";
            calculator.V1 = 3;
            calculator.V2 = 2;
            var result = calculator.GetResult();
            Assert.AreEqual(6, result);
        }

        [Test]
        public void GetResultTestDiv()
        {
            var calculator = new Calculator();
            calculator.Operation = "/";
            calculator.V1 = 6;
            calculator.V2 = 2;
            var result = calculator.GetResult();
            Assert.AreEqual(3, result);
        }

        [Test]
        public void GetResultTestDiv_V1小於等於0_Exception()
        {
            var calculator = new Calculator();
            calculator.Operation = "/";
            calculator.V1 = 0;
            calculator.V2 = 2;
            var result =  Assert.Catch<Exception>(() => calculator.GetResult());
            StringAssert.Contains("V1 應該大於0", result.ToString());
        }

    }
}