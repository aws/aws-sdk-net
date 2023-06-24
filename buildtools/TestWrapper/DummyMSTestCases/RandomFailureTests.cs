using System;
using NUnit.Framework;

namespace TestCases
{
    public class RandomFailureTests
    {
        private static readonly Random random = new Random();
        private static readonly int FREQUENCY = 25;

        private const string SAMPLE_S3_MULTILINE_STRING =
            "B;chunk-signature=6a4d50a3307c001ad83900a73442136a0a0f203520fd8c0e966f655cc830bbe8\r\n" +
            "Hello world\r\n" +
            "0;chunk-signature=9384094dc67fd7c29a4c7e0aa3866233b3774e41d1470b8f51a96becbd91f60c\r\n" +
            "x-amz-checksum-sha1:e1AsOh9IyGCa4hLN+2Od7jlnP14=\r\n" +
            "x-amz-trailer-signature:5e9fae6e80d8cb558e2c43d228a8c36d6b36b5f6f8b86fb8f6596111f3f229a1\r\n" +
            "\r\n";

        [Test]
        public void TestMethod01()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod02()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod03()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod04()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod05()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod06()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod07()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod08()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod09()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod10()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod11()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod12()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod13()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod14()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod15()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod16()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod17()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod18()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod19()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod20()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod21()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod22()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod23()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod24()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [Test]
        public void TestMethod25()
        {
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }

        [TestCase(SAMPLE_S3_MULTILINE_STRING)]
        [TestCase("another multiline\r\n string\r\n")]
        public void TestMethod26(string input)
        {
            Assert.IsTrue(input.Contains("\r\n"));
            Assert.IsFalse(random.Next(100) < FREQUENCY);
        }
    }
}
