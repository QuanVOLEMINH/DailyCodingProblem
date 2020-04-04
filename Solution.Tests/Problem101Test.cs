using System;
using Xunit;

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
            try
            {
                var actual = Problem101.ListPrimes(sum);
            } 
            catch (ArgumentOutOfRangeException e)
            {
                Assert.Contains(Problem101.OutOfRangeMessage, e.Message);
            }
        }

        [Theory]
        [InlineData(4, new[] { 2, 2 })]
        [InlineData(6, new[] { 3, 3 })]
        [InlineData(8, new[] { 3, 5 })]
        [InlineData(10, new[] { 3, 7 })]
        [InlineData(12, new[] { 5, 7 })]
        [InlineData(14, new[] { 3, 11 })]
        [InlineData(16, new[] { 3, 13 })]
        [InlineData(18, new[] { 5, 13 })]
        [InlineData(20, new[] { 3, 17 })]
        [InlineData(22, new[] { 3, 19 })]
        [InlineData(24, new[] { 5, 19 })]
        public void MainTest(int sum, int[] expected)
        {
            var actual = Problem101.ListPrimes(sum);
            Assert.Equal(expected, actual);
        }
    }
}
