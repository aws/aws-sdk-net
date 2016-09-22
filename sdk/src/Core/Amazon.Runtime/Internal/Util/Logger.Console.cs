﻿using Amazon.Util;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace Amazon.Runtime.Internal.Util
{

    internal class InternalConsoleLogger : InternalLogger
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

        public static long _sequanceId;

        public InternalConsoleLogger(Type declaringType)
            : base(declaringType)
        {}

        #region Overrides

        public override void Flush()
        {
        }


        /// <summary>
        /// Simple wrapper around the log4net Error method.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Error(Exception exception, string messageFormat, params object[] args)
        {
            this.Log(LogLevel.Error, string.Format(CultureInfo.CurrentCulture, messageFormat, args), exception);
        }


        /// <summary>
        /// Write debug message to Console
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Debug(Exception exception, string messageFormat, params object[] args)
        {
            this.Log(LogLevel.Debug, string.Format(CultureInfo.CurrentCulture, messageFormat, args), exception);
        }

        /// <summary>
        /// Write debug message to Console
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void DebugFormat(string message, params object[] arguments)
        {
            this.Log(LogLevel.Debug, string.Format(CultureInfo.CurrentCulture, message, arguments), (Exception)null);
        }

        /// <summary>
        /// Simple wrapper around the log4net InfoFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void InfoFormat(string message, params object[] arguments)
        {
            this.Log(LogLevel.Info, string.Format(CultureInfo.CurrentCulture, message, arguments), (Exception)null);
        }

        #endregion

        private void Log(LogLevel logLevel, string message, Exception ex)
        {
            string formatted = null;
            long sequence = Interlocked.Increment(ref _sequanceId);
            string dt = DateTime.Now.ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture);
            string asString = logLevel.ToString().ToUpper(CultureInfo.InvariantCulture);

            if (ex != null)
                formatted = string.Format(CultureInfo.CurrentCulture, "{0}|{1}|{2}|{3} --> {4}", sequence, dt, asString, message, ex.ToString());
            else
                formatted = string.Format(CultureInfo.CurrentCulture, "{0}|{1}|{2}|{3}", sequence, dt, asString, message);

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
#elif PCL
			System.Diagnostics.Debug.WriteLine(formatted);
#else
            Console.WriteLine(@"{0} {1}", DeclaringType.Name, formatted);
#endif

        }

    }
}
