using System;
using BenchmarkDotNet.Attributes;
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

    public class HandleExceptions
    {
        public void Test()
        {
            try
            {
                ThrowException();
            }
            catch (Exception ex)
            {

                //Console.WriteLine(ex.Message);
            }
        }

        private void ThrowException()
        {
            throw new Exception("Simulate exception");
        }
    }

    [MemoryDiagnoser]
    public class HandleExceptionsBenchmark
    {
        private static readonly HandleExceptions handleExceptions = new HandleExceptions();

        [Benchmark]
        public void Test()
        {
            handleExceptions.Test();
        }
    }
}
