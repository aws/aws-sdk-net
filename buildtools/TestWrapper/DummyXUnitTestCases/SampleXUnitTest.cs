using System;
using Xunit;

namespace DummyXUnitTestCases
{
    public class TestCases
    {
        private int Add(int a, int b)
        {
            return a + b;
        }

        [Fact]
        public void PassingTest()
        {
            Assert.True(4 == Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
          Assert.True(3 == Add(2, 2));
        }


        private bool Odd(int val)
        {
            return val % 2 != 0;
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(9)]
        public void SucceedingTheory(int val)
        {
            Assert.True(Odd(val));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(9)]
        public void FailingTheory(int val)
        {
            Assert.True(Odd(val));
        }

        [Fact(Skip = "Skipped Test")]
        public void TestSkip()
        {
            throw new Exception("This should have been skipped!");
        }
    }
}
