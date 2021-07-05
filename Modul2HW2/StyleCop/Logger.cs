using System;
using System.Text;

namespace StyleCop
{
    internal class Logger
    {
        private static Logger _user = new Logger();
        private StringBuilder _logs;

        static Logger()
        {
        }

        private Logger()
        {
            _logs = new StringBuilder();
        }

        public static Logger User
        {
            get
            {
                return _user;
            }
        }

        public void Write(LogType type, string message)
        {
            var log = $"{DateTime.UtcNow}: {type.ToString()}: {message}";
            _logs.AppendLine(log);
            Console.WriteLine(log);
        }

        public override string ToString()
        {
            return _logs.ToString();
        }
    }
}
