using LengthOfLastWord;
using NUnit.Framework;
using System;

namespace LengthOfLastWordTests
{
    public class UnitTests
    {
        LengthOfLastWordApp app;

        [SetUp]
        public void Setup()
        {
            app = new LengthOfLastWordApp();
        }

        [Test]
        public void PositiveTest1()
        {
            int expectedValue = 5;
            var inputString = "Hello World";
            var outputValue = app.LengthOfLastWord(inputString);
            Assert.AreEqual(expectedValue, outputValue);
        }

        [Test]
        public void PositiveTest2()
        {
            int expectedValue = 4;
            var inputString = "   fly me   to   the moon  ";
            var outputValue = app.LengthOfLastWord(inputString);
            Assert.AreEqual(expectedValue, outputValue);
        }

        [Test]
        public void PositiveTest3()
        {
            int expectedValue = 6;
            var inputString = "luffy is still joyboy";
            var outputValue = app.LengthOfLastWord(inputString);
            Assert.AreEqual(expectedValue, outputValue);
        }

        [Test]
        public void NegativeTest1()
        {
            var inputString = "     ";
            try
            {
                var dd = app.LengthOfLastWord(inputString);
                Assert.Fail("Exception не выброшен");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Sequence contains no elements", ex.Message);
            }
        }
    }
}