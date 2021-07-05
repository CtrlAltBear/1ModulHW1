using System;
using System.Text;

namespace StyleCop
{
    internal class Actions
    {
        private Logger _log = Logger.User;
        public Result Method_1()
        {
            _log.Write(LogType.Info, "Start method:");

            return new Result(true);
        }

        public Result Method_2()
        {
            _log.Write(LogType.Warning, "Skipped logic in method:");

            return new Result(true);
        }

        public Result Method_3()
        {
            return new Result(false, "I broke a logic");
        }
    }
}
