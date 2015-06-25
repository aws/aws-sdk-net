using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCases
{
    [TestClass]
    public class RandomFailureTests
    {
        static Random random = new Random();
        static int FREQUENCY = 25;

        [TestMethod]
        public void TestMethod01()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);   
        }

        [TestMethod]
        public void TestMethod02()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod03()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod04()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod05()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod06()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod07()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod08()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod09()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod10()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod11()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod12()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod13()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod14()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod15()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod16()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod17()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod18()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod19()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod20()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod21()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod22()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod23()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod24()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestMethod]
        public void TestMethod25()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }
    }
}
