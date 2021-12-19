using BenchmarkDotNet.Running;

namespace ExceptionsPerformances
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<HandleExceptionsBenchmark>();
        }

    }
}
