using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Exponential.Test
{
    public sealed class ExponentialSearchTest
    {
        [Theory]
        [ClassData(typeof(ExponentialSearchTheoryData))]
        public void Search_Exponential_ShouldEqual(IReadOnlyList<int> data, int element, int expected)
        {
            var instance = new ExponentialSearch();
            var actual = instance.Search(data, element);
            Assert.Equal(expected, actual);
        }
    }
}
