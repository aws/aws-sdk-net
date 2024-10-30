using Amazon.Runtime.Logging;
using log4net;
using log4net.Core;
using System;

namespace AWSSDK.Extensions.Logging.Log4NetAdaptor
{
    internal class AdaptorLoggerImpl : IAdaptorLogger
    {
        private ILog _logger;

        internal AdaptorLoggerImpl(ILog logger)
        {
            _logger = logger;
        }

        public bool IsEnabled(SdkLogLevel level)
        {
            switch (level)
            {
                case SdkLogLevel.Trace: // Log4net does not have a Trace level logging so grouping with Debug
                case SdkLogLevel.Debug:
                    return _logger.IsDebugEnabled;
                case SdkLogLevel.Info:
                    return _logger.IsInfoEnabled;
                case SdkLogLevel.Warn:
                    return _logger.IsWarnEnabled;
                case SdkLogLevel.Error:
                    return _logger.IsErrorEnabled;
                case SdkLogLevel.Fatal:
                    return _logger.IsFatalEnabled;
                default:
                    return _logger.IsInfoEnabled; // If the SDK ever adds a new log level that the adaptor doesn't know about default to INFO log level
            }
        }

        public void Log(SdkLogLevel level, string message, params string[] parameters)
        {
            switch(level)
            {
                case SdkLogLevel.Trace: // Log4net does not have a Trace level logging so grouping with Debug
                case SdkLogLevel.Debug:
                    _logger.DebugFormat(message, parameters);
                    break;
                case SdkLogLevel.Info:
                    _logger.InfoFormat(message, parameters);
                    break;
                case SdkLogLevel.Warn:
                    _logger.WarnFormat(message, parameters);
                    break;
                case SdkLogLevel.Error:
                    _logger.ErrorFormat(message, parameters);
                    break;
                case SdkLogLevel.Fatal:
                    _logger.FatalFormat(message, parameters);
                    break;
                default:
                    _logger.InfoFormat(message, parameters); // If the SDK ever adds a new log level that the adaptor doesn't know about default to INFO log level
                    break;
            }
        }
    }

    internal class AdaptorLoggerFactoryImpl : IAdaptorLoggerFactory
    {
        public IAdaptorLogger CreateAdaptorLogger<T>()
        {
            return new AdaptorLoggerImpl(LogManager.GetLogger(typeof(T)));
        }
    }
}
