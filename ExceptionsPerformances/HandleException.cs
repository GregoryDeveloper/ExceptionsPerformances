using System;

namespace ExceptionsPerformances
{
    public class HandleException
    {
        public void Test()
        {
            try
            {
                ThrowException();
            }
            catch (Exception ) { }
        }

        private void ThrowException()
        {
            throw new Exception("Simulate exception");
        }
    }
}
