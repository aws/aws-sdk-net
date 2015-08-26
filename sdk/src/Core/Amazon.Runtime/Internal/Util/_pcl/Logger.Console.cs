using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
    //mapped to android logcat
    enum LogLevel
    {
        Verbose = 2,
        Debug = 3,
        Info = 4,
        Warn = 5,
        Error = 6,
        Assert = 7
    }

    internal class InternalConsoleLogger : InternalLogger
    {

        public static long _sequanceId;

        public InternalConsoleLogger(Type declaringType)
            : base(declaringType)
        {}

        #region Overrides

        public override void Flush()
        {
        }

        /// <summary>
        /// Simple wrapper around the log4net IsErrorEnabled property.
        /// </summary>
        public override bool IsErrorEnabled
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Simple wrapper around the log4net Error method.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Error(Exception exception, string messageFormat, params object[] args)
        {
            this.Log(LogLevel.Error, string.Format(messageFormat, args), exception);
        }

        /// <summary>
        /// Simple wrapper around the log4net IsDebugEnabled property.
        /// </summary>
        public override bool IsDebugEnabled
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Simple wrapper around the log4net Debug method.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Debug(Exception exception, string messageFormat, params object[] args)
        {
            this.Log(LogLevel.Debug, string.Format(messageFormat, args), exception);
        }

        /// <summary>
        /// Simple wrapper around the log4net DebugFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void DebugFormat(string message, params object[] arguments)
        {
            this.Log(LogLevel.Debug, string.Format(message, arguments), (Exception)null);
        }

        /// <summary>
        /// Simple wrapper around the log4net IsInfoEnabled property.
        /// </summary>
        public override bool IsInfoEnabled
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Simple wrapper around the log4net InfoFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void InfoFormat(string message, params object[] arguments)
        {
            this.Log(LogLevel.Info, string.Format(message, arguments), (Exception)null);
        }

        #endregion

        public void Log(LogLevel logLevel, string message, Exception ex)
        {
            string formatted = null;
            long sequence = Interlocked.Increment(ref _sequanceId);
            string dt = DateTime.Now.ToString(AWSSDKUtils.ISO8601DateFormat);
            string asString = logLevel.ToString().ToUpper();
            int thread = Environment.CurrentManagedThreadId;
            if (ex != null)
                formatted = string.Format("{0}|{1}|{2}|{3}|{4} --> {5}", sequence, dt, asString, thread, message, ex.ToString());
            else
                formatted = string.Format("{0}|{1}|{2}|{3}|{4}", sequence, dt, asString, thread, message);

#if __ANDROID__ 
            switch(logLevel)
            {
                case LogLevel.Warn:
                    Android.Util.Log.Warn(DeclaringType.Name, formatted);
                    break;
                case LogLevel.Debug:
                    Android.Util.Log.Debug(DeclaringType.Name, formatted);
                    break;
                case LogLevel.Error:
                    Android.Util.Log.Error(DeclaringType.Name, formatted);
                    break;
                case LogLevel.Verbose:
                    Android.Util.Log.Verbose(DeclaringType.Name, formatted);
                    break;
                case LogLevel.Info:
                default:
                    Android.Util.Log.Info(DeclaringType.Name, formatted);
                    break;
            }
#elif __IOS__
            Console.WriteLine(@"{0} {1}", DeclaringType.Name, formatted);

#else
            System.Diagnostics.Debug.WriteLine(formatted);
#endif

        }

    }
}
