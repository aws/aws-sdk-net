using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Runtime.Logging
{
    internal class ConsoleAdaptorLogger : IAdaptorLogger
    {
        public bool IsEnabled(SdkLogLevel level) => true;

        public void Log(SdkLogLevel level, string message, params string[] parameters)
        {
            throw new NotImplementedException();
        }
    }

    internal class ConsoleAdaptorLoggerFactory : IAdaptorLoggerFactory
    {
        private static IAdaptorLogger _defaultLogger = new ConsoleAdaptorLogger();

        public IAdaptorLogger CreateAdaptorLogger<T>()
        {
            return _defaultLogger;
        }
    }
}
