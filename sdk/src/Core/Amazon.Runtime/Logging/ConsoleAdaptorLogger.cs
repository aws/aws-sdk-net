using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;

namespace Amazon.Runtime.Logging
{
    internal class ConsoleAdaptorLogger : IAdaptorLogger
    {
        public static long _sequanceId;

        private Type _declaredLoggerType;

        public bool IsEnabled(SdkLogLevel level) => true;

        public ConsoleAdaptorLogger(Type declaredLoggerType)
        {
            _declaredLoggerType = declaredLoggerType;
        }

        public void Log(SdkLogLevel level, string message, Exception ex, params string[] parameters)
        {
            TextWriter writer;
            if (level == SdkLogLevel.Error || level == SdkLogLevel.Fatal)
                writer = Console.Error;
            else
                writer = Console.Out;

            writer.WriteLine(message, parameters);

            string formatted = null;
            long sequence = Interlocked.Increment(ref _sequanceId);
            string dt = AWSSDKUtils.CorrectedUtcNow.ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture);
            string asString = level.ToString().ToUpper(CultureInfo.InvariantCulture);

            if (ex != null)
                formatted = string.Format(CultureInfo.CurrentCulture, "{0}|{1}|{2}|{3} --> {4}", sequence, dt, asString, message, ex.ToString());
            else
                formatted = string.Format(CultureInfo.CurrentCulture, "{0}|{1}|{2}|{3}", sequence, dt, asString, message);

            Console.WriteLine(@"{0} {1}", _declaredLoggerType.Name, formatted);
        }
    }

    internal class ConsoleAdaptorLoggerFactory : IAdaptorLoggerFactory
    {
        public IAdaptorLogger CreateAdaptorLogger<T>()
        {
            return new ConsoleAdaptorLogger(typeof(T));
        }
    }
}
