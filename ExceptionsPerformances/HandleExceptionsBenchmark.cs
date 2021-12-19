using BenchmarkDotNet.Attributes;

namespace ExceptionsPerformances
{
    [MemoryDiagnoser]
    public class HandleExceptionsBenchmark
    {
        private static readonly HandleException handleExceptions = new HandleException();
        private static readonly HandleResultObject handleResultObject = new HandleResultObject();
        private static readonly HandleResultObjectWithTryCatch handleResultObjectWithTryCatch = new HandleResultObjectWithTryCatch();
        private static readonly HandleResultObjectWithIf handleResultObjectWithIf = new HandleResultObjectWithIf();


        [Benchmark]
        public void HandleExceptions()
        {
            handleExceptions.Test();
        }

        [Benchmark]
        public void HandleResultObject()
        {
            handleResultObject.Test();
        }

        [Benchmark]
        public void HandleResultObjectWithTryCatch()
        {
            handleResultObjectWithTryCatch.Test();
        }

        [Benchmark]
        public void HandleResultObjectWithIf()
        {
            handleResultObjectWithIf.Test();
        }
    }
}
