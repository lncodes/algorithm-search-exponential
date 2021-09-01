using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Exponential.Test
{
    public sealed class ExponentialSearchTheoryData : TheoryData<IReadOnlyList<int>, int, int>
    {
        public ExponentialSearchTheoryData()
        {
            Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, 0);
            Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 9);
            Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }, 5, 4);
        }
    }
}
