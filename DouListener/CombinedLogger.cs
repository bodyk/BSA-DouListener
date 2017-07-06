using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouListener
{
    class CombinedLogger : ILogger
    {
        private readonly FileLogger _fileLog;
        private readonly ConsoleLogger _consoleLog;

        public CombinedLogger()
        {
            _fileLog = new FileLogger();
            _consoleLog = new ConsoleLogger();
        }

        public void Log(string message)
        {
            _fileLog.Log(message);
            _consoleLog.Log(message);
        }
    }
}
