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

        private const string LOG_FILE_FORMAT = @"awssdk.{0}.log";
        private const string LOG_FILE_PATTERN = @"awssdk.[0-9].log";
        private const string LOGS_FOLDER_NAME = @"aws-logs";

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
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, DebugMsgFormat, currentTime, string.Format(message, arguments));
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
            LogMessage msg = new LogMessage(CultureInfo.InvariantCulture, InfoMsgFormat, currentTime, string.Format(message, arguments));
            LogAsync(msg);
        }

        #endregion


        private void LogAsync(LogMessage message)
        {
            lock (_lock)
            {
                FileSystem.Current.LocalStorage.CreateFolderAsync(LOGS_FOLDER_NAME, CreationCollisionOption.OpenIfExists).ContinueWith(async (folderTask) =>
                {
                    var folder = folderTask.Result;
                    var fileName = await RollingLogFileName(folder).ConfigureAwait(false);
                    var file = await folder.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists).ConfigureAwait(false);
                    var stream = await file.OpenAsync(PCLStorage.FileAccess.ReadAndWrite).ConfigureAwait(false);

                    using (var writer = new StreamWriter(stream))
                    {
                        writer.BaseStream.Seek(0, SeekOrigin.End);
                        writer.WriteLine(message.ToString());
                    }
                });
            }
        }


        private async Task<string> RollingLogFileName(IFolder folder)
        {
            var files = await folder.GetFilesAsync().ConfigureAwait(false);

            var counter = 0;
            if (files.Count > 0)
            {
                var logFiles = new List<IFile>();
                foreach (var f in files)
                {
                    var match = Regex.Match(f.Name, LOG_FILE_PATTERN);
                    if (match.Success)
                        logFiles.Add(f);
                }


                if (logFiles.Count > 0)
                {
                    logFiles.Sort();

                    //if the number of files are greater than the max number of files allowed then,
                    //delete the oldest file. oldest file is the file with the higest number
                    if (logFiles.Count > MAX_FILES_COUNT)
                    {
                        await logFiles[logFiles.Count - 1].DeleteAsync().ConfigureAwait(false);
                        for (int i = logFiles.Count - 2; i >= 0; i--)
                        {
                            var newPath = logFiles[i].Path.Replace(logFiles[i].Name, string.Format(LOG_FILE_FORMAT, i + 1));
                            await logFiles[i].MoveAsync(newPath).ConfigureAwait(false);
                        }
                        counter--;
                    }

                    // the current file is the file at the zeroth index.
                    var currentFile = logFiles[0];

                    var fileData = await currentFile.ReadAllTextAsync().ConfigureAwait(false);

                    //this is not ideal, but is used due to lack of fileinfo api in pcl
                    var fileSize = System.Text.Encoding.UTF8.GetByteCount(fileData);

                    if (fileSize < MAX_SIZE)
                    {
                        return currentFile.Name;
                    }
                    else
                    {
                        counter++;
                    }
                }
            }

            return string.Format(LOG_FILE_FORMAT, counter);
        }
    }
}
