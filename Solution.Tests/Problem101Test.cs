using System;
using Xunit;
using Solution;

namespace Solution.Tests
{
    public class Problem101Test
    {
        [Theory]
        [InlineData(3)]
        [InlineData(2)]
        [InlineData(-10)]
        public void InvalidInputTest(int sum)
        {
            int[] actual;
            try
            {
                actual = Problem101.ListPrimes(sum);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Contains(Problem101.OutOfRangeMessage, e.Message);
                return;
            }
            Assert.True(false, "Not catch expected exception.");
        }

        [Theory]
        [InlineData(4, new int[] { 2, 2 })]
        [InlineData(6, new int[] { 3, 3 })]
        [InlineData(8, new int[] { 3, 5 })]
        [InlineData(10, new int[] { 3, 7 })]
        [InlineData(12, new int[] { 5, 7 })]
        [InlineData(14, new int[] { 3, 11 })]
        [InlineData(16, new int[] { 3, 13 })]
        [InlineData(18, new int[] { 5, 13 })]
        [InlineData(20, new int[] { 3, 17 })]
        [InlineData(22, new int[] { 3, 19 })]
        [InlineData(24, new int[] { 5, 19 })]
        public void MainTest(int sum, int[] expected)
        {
            var actual = Problem101.ListPrimes(sum);
            Assert.Equal(expected, actual);
        }
    }
}
