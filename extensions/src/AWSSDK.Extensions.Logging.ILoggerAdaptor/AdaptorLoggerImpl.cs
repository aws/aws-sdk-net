using Amazon.Runtime.Logging;
using Microsoft.Extensions.Logging;
using System;

namespace AWSSDK.Extensions.Logging.ILoggerAdaptor
{
    internal class AdaptorLoggerImpl : IAdaptorLogger
    {
        private ILogger _logger;

        internal AdaptorLoggerImpl(ILogger logger)
        {
            _logger = logger;
        }

        public bool IsEnabled(SdkLogLevel level)
        {
            return _logger.IsEnabled(ConvertLogLevel(level));
        }

        public void Log(SdkLogLevel level, string message, Exception ex, params object[] parameters)
        {
            _logger.Log(ConvertLogLevel(level), ex, message, parameters);
        }

        private LogLevel ConvertLogLevel(SdkLogLevel level) => level switch
        {
            SdkLogLevel.Trace => LogLevel.Trace,
            SdkLogLevel.Debug => LogLevel.Debug,
            SdkLogLevel.Info => LogLevel.Information,
            SdkLogLevel.Warn => LogLevel.Warning,
            SdkLogLevel.Error => LogLevel.Error,
            SdkLogLevel.Fatal => LogLevel.Critical,
            _ => LogLevel.Information // If the SDK ever adds a new log level that the adaptor doesn't know about default to INFO log level
        };
    }

    internal class AdaptorLoggerFactoryImpl : IAdaptorLoggerFactory
    {
        ILoggerFactory _LogFactory;

        internal AdaptorLoggerFactoryImpl(ILoggerFactory logFactory)
        {
            _LogFactory = logFactory;
        }

        public string Name { get; } = "ILogger";

        public IAdaptorLogger CreateAdaptorLogger(Type type)
        {
            return new AdaptorLoggerImpl(_LogFactory.CreateLogger(type));
        }
    }
}
