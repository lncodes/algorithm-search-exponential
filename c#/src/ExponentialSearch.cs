using System;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Exponential
{
    public sealed class ExponentialSearch
    {
        /// <summary>
        /// Method for exponential search
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <param name="element"></param>
        /// <returns cref="int"></returns>
        public int Search<T>(IReadOnlyList<T> data, T element) where T : IComparable
        {
            var maxRangeIndex = 1;
            var binarySearch = new BinarySearch();

            while (maxRangeIndex < data.Count && data[maxRangeIndex].CompareTo(element) < 0)
                maxRangeIndex *= 2;

            return binarySearch.Search(data, element, maxRangeIndex / 2, Math.Min(data.Count, maxRangeIndex));
        }
    }
}
