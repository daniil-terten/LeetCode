using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SingleNumber.App;

namespace SingleNumber.Tests
{
    public class UnitTests
    {
        SingleNumberApp app;

        [SetUp]
        public void Setup()
        {
            app = new SingleNumberApp();
        }

        [Test]
        public void PositiveTest1()
        {
            int expectedValue = 1;
            var inputArr = new int[] { 2, 2, 1 };
            var outputValue = app.SingleNumber(inputArr);
            Assert.AreEqual(expectedValue, outputValue);
        }

        [Test]
        public void PositiveTest2()
        {
            int expectedValue = 4;
            var inputArr = new int[] { 1, 3, 4, 5, 6, 7, 8, 1, 3, 5, 6 };
            var outputValue = app.SingleNumber(inputArr);
            Assert.AreEqual(expectedValue, outputValue);
        }

        [Test]
        public void PositiveTest3()
        {
            int expectedValue = 1;
            var inputArr = new int[] { 1 };
            var outputValue = app.SingleNumber(inputArr);
            Assert.AreEqual(expectedValue, outputValue);
        }

        [Test]
        public void PositiveTest4()
        {
            int expectedValue = 4;
            var inputArr = new int[] { 4, 1, 2, 1, 2 };
            var outputValue = app.SingleNumber(inputArr);
            Assert.AreEqual(expectedValue, outputValue);
        }

        [Test]
        public void NegativeTest1()
        {
            int? expectedValue = null;
            var inputArr = new int[2];
            var outputValue = app.SingleNumber(inputArr);
            Assert.AreEqual(expectedValue, outputValue);
        }
    }
}
