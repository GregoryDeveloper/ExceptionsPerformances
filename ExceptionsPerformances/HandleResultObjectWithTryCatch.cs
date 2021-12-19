using System;

namespace ExceptionsPerformances
{
    public class HandleResultObjectWithTryCatch
    {
        public void Test()
        {
            try
            {
                GetResultObject();
            }
            catch (Exception) {}
        }

        private Result GetResultObject()
        {
            return new Result(false, "There is an error");
        }
    }
}
