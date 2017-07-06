using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouListener
{
    class FileLogger : ILogger
    {
        public string FilePath { get; set; } = @"\";
        public string FileName { get; set; } = "Log.txt";
        public void Log(string message)
        {
            File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + FilePath + FileName, $"Status: {message}\n");
        }
    }
}
