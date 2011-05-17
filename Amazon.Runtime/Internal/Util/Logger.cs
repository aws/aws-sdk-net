/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Globalization;
using System.Text;

namespace Amazon.Runtime.Internal.Util
{
    public class LogMessage
    {
        public object[] Args { get; private set; }
        public IFormatProvider Provider { get; private set; }
        public string Format { get; private set; }

        public LogMessage(string message) : this(CultureInfo.InvariantCulture, message) { }
        public LogMessage(string format, params object[] args) : this(CultureInfo.InvariantCulture, format, args) { }
        public LogMessage(IFormatProvider provider, string format, params object[] args)
        {
            Args = args;
            Format = format;
            Provider = provider;
        }

        public override string ToString()
        {
            return string.Format(Provider, Format, Args);
        }
    }

    /// <summary>
    /// This is a dynamic wrapper around log4net so we can avoid log4net being required
    /// to be distributed with the SDK.
    /// </summary>
    internal class Logger
    {
        enum LoadState { Uninitialized, Failed, Loading, Success };

        #region Reflected Types and methods
        static LoadState loadState = LoadState.Uninitialized;
        static readonly object LOCK = new object();

        static Type logMangerType;
        static MethodInfo getLoggerWithTypeMethod;

        static Type logType;
        static MethodInfo logMethod;

        static Type levelType;
        static object debugLevelPropertyValue;
        static object infoLevelPropertyValue;
        static object errorLevelPropertyValue;

        static Type systemStringFormatType;

        static Type loggerType;

        #endregion

        object internalLogger;
        Type declaringType;

        public Logger(Type type)
        {
            if (loadState == LoadState.Uninitialized)
            {
                loadStatics();
            }

            if (logMangerType == null)
                return;

            declaringType = type;

            this.internalLogger = getLoggerWithTypeMethod.Invoke(null, new object[] { Assembly.GetCallingAssembly(), type }); //Assembly.GetCallingAssembly()
        }

        /// <summary>
        /// This should be a one time call to use reflection to find all the types and methods
        /// needed for the logging API.
        /// </summary>
        private static void loadStatics()
        {
            lock (Logger.LOCK)
            {
                if (loadState != LoadState.Uninitialized)
                    return;

                loadState = LoadState.Loading;
                try
                {
                    loggerType = Type.GetType("Amazon.Runtime.Internal.Util.Logger");

                    // The LogManager and its methods
                    logMangerType = Type.GetType("log4net.Core.LoggerManager, log4net");
                    if (logMangerType == null)
                    {
                        loadState = LoadState.Failed;
                        return;
                    }
                    getLoggerWithTypeMethod = logMangerType.GetMethod("GetLogger", new Type[] { typeof(Assembly), typeof(Type) });

                    // The ILog and its methdods
                    logType = Type.GetType("log4net.Core.ILogger, log4net");
                    levelType = Type.GetType("log4net.Core.Level, log4net");
                    debugLevelPropertyValue = levelType.GetField("Debug").GetValue(null);
                    infoLevelPropertyValue = levelType.GetField("Info").GetValue(null);
                    errorLevelPropertyValue = levelType.GetField("Error").GetValue(null);

                    systemStringFormatType = Type.GetType("log4net.Util.SystemStringFormat, log4net");

                    logMethod = logType.GetMethod("Log", new Type[] { typeof(Type), levelType, typeof(object), typeof(Exception) });

                    if (getLoggerWithTypeMethod == null ||
                        logType == null ||
                        levelType == null ||
                        logMethod == null)
                    {
                        loadState = LoadState.Failed;
                        return;
                    }

                    loadState = LoadState.Success;
                }
                catch
                {
                    // Mark as failed so no attempted will be made on the logging methods.
                    loadState = LoadState.Failed;
                }
            }
        }


        /// <summary>
        /// Simple wrapper around the log4net Error method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Error(string message, Exception exception)
        {
            if (loadState != LoadState.Success || this.internalLogger == null || loggerType == null || systemStringFormatType == null || errorLevelPropertyValue == null)
                return;

            logMethod.Invoke(
                this.internalLogger,
                new object[]
                {
                    loggerType, errorLevelPropertyValue,
                    new LogMessage(CultureInfo.InvariantCulture, message),
                    exception
                });
        }

        /// <summary>
        /// Simple wrapper around the log4net Debug method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Debug(string message, Exception exception)
        {
            if (loadState != LoadState.Success || this.internalLogger == null || loggerType == null || systemStringFormatType == null || debugLevelPropertyValue == null)
                return;

            logMethod.Invoke(
                this.internalLogger,
                new object[]
                {
                    loggerType, debugLevelPropertyValue,
                    new LogMessage(CultureInfo.InvariantCulture, message),
                    exception
                });
        }

        /// <summary>
        /// Simple wrapper around the log4net DebugFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public void DebugFormat(string message, params object[] arguments)
        {
            if (loadState != LoadState.Success || this.internalLogger == null || loggerType == null || systemStringFormatType == null || debugLevelPropertyValue == null)
                return;

            logMethod.Invoke(
                this.internalLogger,
                new object[]
                {
                    loggerType, debugLevelPropertyValue,
                    new LogMessage(CultureInfo.InvariantCulture, message, arguments),
                    null
                });

        }

        /// <summary>
        /// Simple wrapper around the log4net InfoFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public void InfoFormat(string message, params object[] arguments)
        {
            if (loadState != LoadState.Success || this.internalLogger == null || loggerType == null || systemStringFormatType == null || infoLevelPropertyValue == null)
                return;

            logMethod.Invoke(
                this.internalLogger,
                new object[]
                {
                    loggerType, infoLevelPropertyValue,
                    new LogMessage(CultureInfo.InvariantCulture, message, arguments),
                    null
                });
        }
    }
}
