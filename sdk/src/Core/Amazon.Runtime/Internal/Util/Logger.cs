/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.ComponentModel;
using Amazon.Runtime;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// This is a dynamic wrapper around log4net so we can avoid log4net being required
    /// to be distributed with the SDK.
    /// </summary>
    public class Logger : ILogger
    {
        private static IDictionary<Type, Logger> cachedLoggers = new Dictionary<Type, Logger>();
        private List<BaseLogger> loggers;
        private static Logger emptyLogger = new Logger();

        private Logger()
        {
            loggers = new List<BaseLogger>();
        }
        private Logger(Type type)
        {
            loggers = new List<BaseLogger>();

            InternalLog4netLogger log4netLogger = new InternalLog4netLogger(type);
            loggers.Add(log4netLogger);
            loggers.Add(new InternalConsoleLogger(type));
#if BCL
            InternalSystemDiagnosticsLogger sdLogger = new InternalSystemDiagnosticsLogger(type);
            loggers.Add(sdLogger);
#endif
#if UNITY
            UnityDebugLogger debugLogger = new UnityDebugLogger(type);
            loggers.Add(debugLogger);
#endif
#if PCL
            InternalFileLogger fileLogger = new InternalFileLogger(type);
            loggers.Add(fileLogger);
#endif

            ConfigureLoggers();
            AWSConfigs.PropertyChanged += ConfigsChanged;
        }
        private void ConfigsChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e != null && string.Equals(e.PropertyName, AWSConfigs.LoggingDestinationProperty, StringComparison.Ordinal))
            {
                ConfigureLoggers();
            }
        }
        private void ConfigureLoggers()
        {
            LoggingOptions logging = AWSConfigs.LoggingConfig.LogTo;
            foreach (BaseLogger il in loggers)
            {
                if (il is InternalLog4netLogger)
                    il.IsEnabled = (logging & LoggingOptions.Log4Net) == LoggingOptions.Log4Net;
                if (il is InternalConsoleLogger)
                    il.IsEnabled = (logging & LoggingOptions.Console) == LoggingOptions.Console;
#if BCL
                if (il is InternalSystemDiagnosticsLogger)
                    il.IsEnabled = (logging & LoggingOptions.SystemDiagnostics) == LoggingOptions.SystemDiagnostics;
#endif
#if UNITY
                if (il is UnityDebugLogger)
                    il.IsEnabled = (logging & LoggingOptions.UnityLogger) == LoggingOptions.UnityLogger;
#endif
#if __ANDROID__ || __IOS__
                if (il is InternalConsoleLogger)
                    il.IsEnabled = (logging & LoggingOptions.SystemDiagnostics) == LoggingOptions.SystemDiagnostics;
#endif
#if PCL
                if (il is InternalFileLogger)
                    il.IsEnabled = (logging & LoggingOptions.File) == LoggingOptions.File;
#endif

            }

            BaseLogger customLogger = AWSConfigs.LoggingConfig.CustomLogger;
            if ((logging & LoggingOptions.Custom) == LoggingOptions.Custom)
            {
                customLogger.IsEnabled = true;
                loggers.Add(customLogger);
            }
        }

        #region Static accessor

        public static Logger GetLogger(Type type)
        {
            if (type == null) throw new ArgumentNullException("type");

            Logger l;
            lock (cachedLoggers)
            {
                if (!cachedLoggers.TryGetValue(type, out l))
                {
                    l = new Logger(type);
                    cachedLoggers[type] = l;
                }
            }
            return l;
        }

        public static void ClearLoggerCache()
        {
            lock (cachedLoggers)
            {
                cachedLoggers = new Dictionary<Type, Logger>();
            }
        }

        public static Logger EmptyLogger { get { return emptyLogger; } }

        #endregion

        #region Logging methods

        public void Flush()
        {
            foreach (BaseLogger logger in loggers)
            {
                logger.Flush();
            }
        }

        public void Error(Exception exception, string messageFormat, params object[] args)
        {
            foreach (BaseLogger logger in loggers)
            {
                if (logger.IsEnabled && logger.IsErrorEnabled)
                    logger.Error(exception, messageFormat, args);
            }
        }

        public void Debug(Exception exception, string messageFormat, params object[] args)
        {
            foreach (BaseLogger logger in loggers)
            {
                if (logger.IsEnabled && logger.IsDebugEnabled)
                    logger.Debug(exception, messageFormat, args);
            }
        }

        public void DebugFormat(string messageFormat, params object[] args)
        {
            foreach (BaseLogger logger in loggers)
            {
                if (logger.IsEnabled && logger.IsDebugEnabled)
                    logger.DebugFormat(messageFormat, args);
            }
        }

        public void InfoFormat(string messageFormat, params object[] args)
        {
            foreach (BaseLogger logger in loggers)
            {
                if (logger.IsEnabled && logger.IsInfoEnabled)
                    logger.InfoFormat(messageFormat, args);
            }
        }

        #endregion

    }
}
