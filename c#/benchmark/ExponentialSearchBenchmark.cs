using BenchmarkDotNet.Attributes;

namespace Lncodes.Algorithm.Search.Exponential.Benchmark
{
    [MinColumn]
    [MaxColumn]
    [MemoryDiagnoser]
    public class ExponentialSearchBenchmark
    {
        private readonly ExponentialSearch _exponentialSearch = new ExponentialSearch();
        private readonly int[] _data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        private readonly int _element = 10;

        [Benchmark]
        public int Search() =>
            _exponentialSearch.Search(_data, _element);
    }
}
