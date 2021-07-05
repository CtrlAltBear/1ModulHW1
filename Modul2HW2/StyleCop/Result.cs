using System;
namespace StyleCop
{
    internal class Result
    {
        public Result()
        {
        }

        public Result(bool status)
        {
            Status = status;
            Error = string.Empty;
        }

        public Result(bool status, string errorMessage)
        {
            Status = status;
            Error = errorMessage;
        }

        public bool Status { get;  set; }
        public string Error { get; set; }
    }
}
