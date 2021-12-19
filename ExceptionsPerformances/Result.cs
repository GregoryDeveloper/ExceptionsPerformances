namespace ExceptionsPerformances
{
    public class Result
    {
        public bool HasSucceeded { get; set; }
        public string Error { get; set; }
        public Result(bool hasSucceeded, string error)
        {
            HasSucceeded = hasSucceeded;
            Error = error;
        }
    }
}
