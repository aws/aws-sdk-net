using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PCLStorage;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Amazon.Runtime.Internal.Util
{
    internal class InternalFileLogger : InternalLogger
    {
        private const string DebugMsgFormat = "AWSSDK DEBUG {0} {1}";
        private const string ErrorMsgFormat = "AWSSDK ERROR {0} {1}";
        private const string InfoMsgFormat = "AWSSDK INFO {0} {1}";

        private static object _lock = new object();
        private static StringBuilder _logBuffer = new StringBuilder();
        private const long MAX_BUFFER_SIZE = 50 * 1024;

        private const string LOG_FILE_FORMAT = @"awssdk.{0}.log";
        private const string LOG_FILE_PATTERN = @"awssdk\.(?<counter>[0-9]+)\.log";
        private const string LOGS_FOLDER_NAME = @"aws-logs";

        private const string DATE_FORMAT = @"yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'";

        //default max number of files to 5
        private const int MAX_FILES_COUNT = 5;

        //max size of file to 1MB
        private const long MAX_SIZE = 1024 * 1024;

        public InternalFileLogger(Type declaringType)
            : base(declaringType)
        {
        }


        #region Overrides

        public override void Flush()
        {
            lock (_lock)
            {
                LogAsync(_logBuffer);
                _logBuffer = new StringBuilder();
            }
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
        /// Debug logging is always enabled
        /// </summary>
        public override bool IsDebugEnabled
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Info logging is always enabled
        /// </summary>
        public override bool IsInfoEnabled
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Prints the Log With Error Level
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Error(Exception exception, string messageFormat, params object[] args)
        {
            string debug = @"{0} {1}";
            string message = string.Format(messageFormat, args);
            string errorMessage = string.Format(debug, message, exception != null ? exception.ToString() : "");
            Log(LogLevel.Error, errorMessage);
        }



        /// <summary>
        /// Prints the Log with Debug Level
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public override void Debug(Exception exception, string messageFormat, params object[] args)
        {
            string debug = @"{0} {1}";
            string message = string.Format(messageFormat, args);
            string debugMessage = string.Format(debug, message, exception != null ? exception.ToString() : "");
            Log(LogLevel.Debug, debugMessage);
        }

        /// <summary>
        /// Prints the Log with Debug Level
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void DebugFormat(string message, params object[] arguments)
        {
            Log(LogLevel.Debug, string.Format(message, arguments));
        }

        /// <summary>
        /// Prints the Log With Info Level
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void InfoFormat(string message, params object[] arguments)
        {
            Log(LogLevel.Info, string.Format(message, arguments));
        }

        #endregion

        private void Log(LogLevel level, string message)
        {

            string messageFormat = "";
            switch (level)
            {
                case LogLevel.Error:
                    messageFormat = ErrorMsgFormat;
                    break;
                case LogLevel.Debug:
                    messageFormat = DebugMsgFormat;
                    break;
                case LogLevel.Info:
                case LogLevel.Verbose:
                default:
                    messageFormat = InfoMsgFormat;
                    break;
            }
            string currentTime = DateTime.UtcNow
                         .ToString(DATE_FORMAT);
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, messageFormat, currentTime, message);
            Queue(msg);
        }

        private void Queue(LogMessage message)
        {
            lock (_lock)
            {
                _logBuffer.AppendLine(message.ToString());
                if (_logBuffer.Length >= MAX_BUFFER_SIZE)
                {
                    LogAsync(_logBuffer);
                    _logBuffer = new StringBuilder();
                }
            }
        }

        private void LogAsync(StringBuilder buffer)
        {
            Task.Run(async () =>
            {
                var folder = await FileSystem.Current.LocalStorage.CreateFolderAsync(LOGS_FOLDER_NAME, CreationCollisionOption.OpenIfExists).ConfigureAwait(false);

                var fileName = await RollingLogFileNameAsync(folder).ConfigureAwait(false);
                var file = await folder.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists).ConfigureAwait(false);
                var stream = await file.OpenAsync(PCLStorage.FileAccess.ReadAndWrite).ConfigureAwait(false);

                using (var writer = new StreamWriter(stream))
                {
                    writer.BaseStream.Seek(0, SeekOrigin.End);
                    writer.WriteLine(buffer.ToString());
                }
            });
        }


        private async Task<string> RollingLogFileNameAsync(IFolder folder)
        {
            var files = await folder.GetFilesAsync().ConfigureAwait(false);

            var counter = 0;
            if (files.Count > 0)
            {
                var logFiles = (from f in files where Regex.Match(f.Name, LOG_FILE_PATTERN).Success select f).OrderBy(f => f.Name).ToList();

                if (logFiles.Count > 0)
                {
                    //if the number of files are greater than the max number of files allowed then,
                    //delete the oldest file. oldest file is the file with the lowest number
                    while (logFiles.Count > MAX_FILES_COUNT)
                    {
                        await logFiles[0].DeleteAsync().ConfigureAwait(false);

                        logFiles.RemoveAt(0);
                    }

                    // the current file is the file at the zeroth index.
                    var currentFile = logFiles[logFiles.Count - 1];

                    long fileSize = 0;
                    using (var stream = await currentFile.OpenAsync(PCLStorage.FileAccess.Read).ConfigureAwait(false))
                    {
                        fileSize = stream.Length;
                    }

                    if (fileSize < MAX_SIZE)
                    {
                        return currentFile.Name;
                    }
                    else
                    {
                        var fileName = currentFile.Name;
                        var regex = new Regex(LOG_FILE_PATTERN);
                        var match = regex.Match(fileName);
                        if (match.Success)
                        {
                            if (int.TryParse(match.Groups["counter"].Value, out counter))
                                counter++;
                        }
                    }
                }
            }

            return string.Format(LOG_FILE_FORMAT, counter);
        }
    }

}
