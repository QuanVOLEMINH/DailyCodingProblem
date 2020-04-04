using System;
using Xunit;

namespace Solution.Tests
{
    public class Problem122Test
    {

        [Fact]
        public void Test_MaxCoins()
        {
            var matrix = new[,]
            {
                {0, 3, 1}, 
                {2, 0, 0}, 
                {1, 5, 3}
            };
            Assert.Equal(11, Problem122.GetMaxCoins(matrix));
        }
    }
}
