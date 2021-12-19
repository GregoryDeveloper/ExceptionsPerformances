namespace ExceptionsPerformances
{
    public class HandleResultObjectWithIf
    {
        public void Test()
        {
            var result = GetResultObject();
            if (!result.HasSucceeded) 
            {
                return;
            }
        }

        private Result GetResultObject()
        {
            return new Result(false, "There is an error");
        }
    }
}
