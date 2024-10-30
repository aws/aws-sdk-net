using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Runtime.Logging
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAdaptorLogger
    {
        bool IsEnabled(SdkLogLevel level);

        void Log(SdkLogLevel level, string message, params string[] parameters);
    }

    public interface IAdaptorLoggerFactory
    {
        IAdaptorLogger CreateAdaptorLogger<T>();
    }
}
