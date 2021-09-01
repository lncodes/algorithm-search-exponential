using BenchmarkDotNet.Running;

namespace Lncodes.Algorithm.Search.Exponential.Benchmark
{
    public sealed class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<ExponentialSearchBenchmark>();
        }
    }
}
