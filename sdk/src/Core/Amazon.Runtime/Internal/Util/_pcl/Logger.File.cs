using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCLStorage;
using System.Globalization;

namespace Amazon.Runtime.Internal.Util
{
    internal class InternalFileLogger : InternalLogger
    {
        private const string DebugMsgFormat = "AWSSDK DEBUG {1} {2} {3}";
        private const string ErrorMsgFormat = "AWSSDK ERROR {1} {2} {3}";
        private const string InfoMsgFormat = "AWSSDK INFO {1} {2} {3}";

        //awssdk, log level, utc timestamp, message

        private const string LOG_FILE_NAME = "awssdk.log";
        private static object _lock = new object();



        public InternalFileLogger(Type declaringType)
            : base(declaringType)
        {
        }


        #region Overrides

        public override void Flush()
        {
            // not supported for pcl type
        }

        /// <summary>
        /// Error is always enabled
        /// </summary>
        public override bool IsErrorEnabled
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Simple wrapper around the Error method.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Error(Exception exception, string messageFormat, params object[] args)
        {
            string error = @"{0} {1}";
            string message = string.Format(messageFormat, args);
            string errorMessage = string.Format(error, message, exception != null ? exception.StackTrace : "");
            string currentTime = DateTime.UtcNow
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, ErrorMsgFormat, currentTime, errorMessage);
            LogAsync(msg);
        }

        /// <summary>
        /// Debug is always enabled
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
            string debug = @"{0} {1}";
            string message = string.Format(messageFormat, args);
            string errorMessage = string.Format(debug, message, exception != null ? exception.StackTrace : "");
            string currentTime = DateTime.UtcNow
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, DebugMsgFormat, currentTime, errorMessage);
            LogAsync(msg);
        }

        /// <summary>
        /// Simple wrapper around the log4net DebugFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void DebugFormat(string message, params object[] arguments)
        {
            string currentTime = DateTime.UtcNow
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, ErrorMsgFormat, currentTime, string.Format(message, arguments));
            LogAsync(msg);
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
            string currentTime = DateTime.UtcNow
                         .ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'");
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, ErrorMsgFormat, currentTime, string.Format(message, arguments));
            LogAsync(msg);
        }

        #endregion


        private void LogAsync(LogMessage message)
        {
            lock (_lock)
            {
                FileSystem.Current.LocalStorage.CreateFolderAsync("logs", CreationCollisionOption.OpenIfExists).ContinueWith((folderTask) =>
                {
                    var folder = folderTask.Result;
#if __ANDROID__
                    Android.Util.Log.Debug("LogTag", @"folder created/opened " + folder.Path);
#endif
                    folder.CreateFileAsync(LOG_FILE_NAME, CreationCollisionOption.OpenIfExists).ContinueWith((fileTask) =>
                    {
                        var file = fileTask.Result;
#if __ANDROID__
                        Android.Util.Log.Debug("LogTag", @"file created/opened " + file.Path);
#endif
                        file.OpenAsync(PCLStorage.FileAccess.ReadAndWrite).ContinueWith((streamTask) =>
                        {
                            using (var writer = new StreamWriter(streamTask.Result))
                            {
                                writer.BaseStream.Seek(0, SeekOrigin.End);
                                writer.WriteLine(message.ToString());
#if __ANDROID__
                                Android.Util.Log.Debug("LogTag", @"wrote to file " + message.ToString());
#endif
                            }
                        });

                    });
                });

            }
        }
    }
}
