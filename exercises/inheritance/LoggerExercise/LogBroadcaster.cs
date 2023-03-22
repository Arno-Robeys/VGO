using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerExercise
{
    internal class LogBroadcaster : Logger
    {
        private readonly IEnumerable<Logger> loggers;

        public LogBroadcaster(IEnumerable<Logger> loggers)
        {
            this.loggers = loggers;
        }

        public override void Log(string message)
        {
            foreach (var logger in loggers)
            {
                logger.Log(message);
            }
        }

        public override void Close()
        {
            foreach(var logger in loggers)
            {
                logger.Close();
            }
        }
    }
}
