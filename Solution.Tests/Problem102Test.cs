using Xunit;

namespace Solution.Tests
{
    public class Problem102Test
    {
        [Theory]
        [InlineData(9, new[] { 1, 2, 3, 4, 5 }, new[] { 2, 3, 4 })]
        public void DistinctSortedListTest(int sum, int[] inputList, int[] expected)
        {
            var result = Problem102.GetTheList(sum, inputList);
            Assert.Equal(result, expected);
        }
    }
}
