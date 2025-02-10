using Amazon.Runtime.Internal.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Amazon.Runtime.Logging
{
    internal class DiagnosticAdaptorLogger : IAdaptorLogger
    {
        int eventId = 0;
        private TraceSource _trace;

        public bool IsEnabled(SdkLogLevel level) => true;

        internal DiagnosticAdaptorLogger(TraceSource trace)
        {
            _trace = trace;
        }

        public void Log(SdkLogLevel level, string message, Exception ex, params string[] parameters)
        {
            var localEventId = Interlocked.Increment(ref eventId);
            _trace.TraceData(ConvertLogLevel(level), localEventId, new LogMessage(CultureInfo.InvariantCulture, message, parameters));
        }

        private TraceEventType ConvertLogLevel(SdkLogLevel level) => level switch
        {
            SdkLogLevel.Trace => TraceEventType.Verbose,
            SdkLogLevel.Debug => TraceEventType.Verbose,
            SdkLogLevel.Info => TraceEventType.Information,
            SdkLogLevel.Warn => TraceEventType.Warning,
            SdkLogLevel.Error => TraceEventType.Error,
            SdkLogLevel.Fatal => TraceEventType.Critical,
            _ => TraceEventType.Information
        };
    }

    internal class DiagnosticAdaptorLoggerFactory : IAdaptorLoggerFactory
    {
        public IAdaptorLogger CreateAdaptorLogger<T>()
        {
            return new DiagnosticAdaptorLogger(TraceSourceUtil.GetTraceSource(typeof(T)));
        }
    }
}
