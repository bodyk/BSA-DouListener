﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DouListener
{
    public enum LogLevel
    {
        Info,
        Error
    }
    interface ILogger
    {
        void Log(LogLevel level, string message);
    }
}
