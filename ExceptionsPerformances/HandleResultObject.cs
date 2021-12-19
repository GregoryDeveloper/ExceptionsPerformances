namespace ExceptionsPerformances
{
    public class HandleResultObject
    {
        public void Test()
        {
            GetResultObject();
        }

        private Result GetResultObject()
        {
            return new Result(false, "There is an error");
        }
    }
}
