/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using Amazon.Util.Internal;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// This is a dynamic wrapper around log4net so we can avoid log4net being required
    /// to be distributed with the SDK.
    /// </summary>
    public class Logger : ILogger
    {
        private static ConcurrentDictionary<Type, Lazy<Logger>> cachedLoggers = new ConcurrentDictionary<Type, Lazy<Logger>>();
        private List<InternalLogger> loggers;

        private Logger()
        {
            loggers = new List<InternalLogger>();
        }

#if NET8_0_OR_GREATER
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026",
            Justification = "Constructor looks to see if running in a NativeAOT environment and if so skips the Log4net internal logger which is not Native AOT complaint.")]
#endif
        private Logger(Type type)
        {
            if(!InternalSDKUtils.IsRunningNativeAot())
            {
                loggers = new List<InternalLogger>(3);
#pragma warning disable
                InternalLog4netLogger log4netLogger = new InternalLog4netLogger(type);
                loggers.Add(log4netLogger);
#pragma warning restore
            }
            else
            {
                loggers = new List<InternalLogger>(2);
            }

            loggers.Add(new InternalConsoleLogger(type));
            InternalSystemDiagnosticsLogger sdLogger = new InternalSystemDiagnosticsLogger(type);
            loggers.Add(sdLogger);
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
            foreach (InternalLogger il in loggers)
            {
                if (il is InternalLog4netLogger)
                    il.IsEnabled = (logging & LoggingOptions.Log4Net) == LoggingOptions.Log4Net;
                if (il is InternalConsoleLogger)
                    il.IsEnabled = (logging & LoggingOptions.Console) == LoggingOptions.Console;
                if (il is InternalSystemDiagnosticsLogger)
                    il.IsEnabled = (logging & LoggingOptions.SystemDiagnostics) == LoggingOptions.SystemDiagnostics;

                if (!IsEnabled)
                {
                    IsEnabled = il.IsEnabled;
                }
                if (!IsErrorEnabled)
                {
                    IsErrorEnabled = il.IsErrorEnabled;
                }
                if (!IsInfoEnabled)
                {
                    IsInfoEnabled = il.IsInfoEnabled;
                }
                if (!IsDebugEnabled)
                {
                    IsDebugEnabled = il.IsDebugEnabled;
                }
            }
        }

        #region Static accessor

        public static Logger GetLogger(Type type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            // Use a lazy initialization to ensure that we only create a logger for a given type once because
            // the constructor does some heavy lifting including setting up event listeners.
            var lazyLogger = cachedLoggers.GetOrAdd(type, static t => new Lazy<Logger>(() => new Logger(t)));
            return lazyLogger.Value;
        }

        public static void ClearLoggerCache()
        {
            var newLoggerCache = new ConcurrentDictionary<Type, Lazy<Logger>>();
            ConcurrentDictionary<Type, Lazy<Logger>> oldLoggerCache;

            do
            {
                oldLoggerCache = cachedLoggers;
            } while (Interlocked.CompareExchange(ref cachedLoggers, newLoggerCache, oldLoggerCache) != oldLoggerCache);

            // Unregister all the loggers in the old cache
            foreach (var item in oldLoggerCache ?? Enumerable.Empty<KeyValuePair<Type, Lazy<Logger>>>())
            {
                var lazyLogger = item.Value;
                if (lazyLogger.IsValueCreated)
                {
                    lazyLogger.Value.Unregister();
                }
            }
        }

        public static Logger EmptyLogger { get; } = new Logger();

        #endregion

        internal bool IsEnabled { get; private set; }

        internal virtual bool IsErrorEnabled { get; private set; }

        internal virtual bool IsDebugEnabled { get; private set; }

        internal virtual bool IsInfoEnabled { get; private set; }

        internal void Unregister()
        {
            AWSConfigs.PropertyChanged -= ConfigsChanged;
        }

        #region Logging methods

        public void Flush()
        {
            foreach (InternalLogger logger in loggers)
            {
                logger.Flush();
            }
        }

        public void Error(Exception exception, string messageFormat, params object[] args)
        {
            foreach (InternalLogger logger in loggers)
            {
                if (logger.IsEnabled && logger.IsErrorEnabled)
                    logger.Error(exception, messageFormat, args);
            }
        }

        public void Debug(Exception exception, string messageFormat, params object[] args)
        {
            foreach (InternalLogger logger in loggers)
            {
                if (logger.IsEnabled && logger.IsDebugEnabled)
                    logger.Debug(exception, messageFormat, args);
            }
        }

        public void DebugFormat(string messageFormat, params object[] args)
        {
            foreach (InternalLogger logger in loggers)
            {
                if (logger.IsEnabled && logger.IsDebugEnabled)
                    logger.DebugFormat(messageFormat, args);
            }
        }

        public void InfoFormat(string messageFormat, params object[] args)
        {
            foreach (InternalLogger logger in loggers)
            {
                if (logger.IsEnabled && logger.IsInfoEnabled)
                    logger.InfoFormat(messageFormat, args);
            }
        }

        #endregion

    }

    /// <summary>
    /// Abstract logger class, base for any custom/specific loggers.
    /// </summary>
    internal abstract class InternalLogger
    {
        public Type DeclaringType { get; private set; }

        public bool IsEnabled { get; set; }

        public InternalLogger(Type declaringType)
        {
            DeclaringType = declaringType;
            IsEnabled = true;
        }

        #region Logging methods

        /// <summary>
        /// Flushes the logger contents.
        /// </summary>
        public abstract void Flush();

        /// <summary>
        /// Simple wrapper around the log4net IsErrorEnabled property.
        /// </summary>
        public virtual bool IsErrorEnabled { get { return true; } }

        /// <summary>
        /// Simple wrapper around the log4net IsDebugEnabled property.
        /// </summary>
        public virtual bool IsDebugEnabled { get { return true; } }

        /// <summary>
        /// Simple wrapper around the log4net IsInfoEnabled property.
        /// </summary>
        public virtual bool IsInfoEnabled { get { return true; } }

        /// <summary>
        /// Simple wrapper around the log4net Error method.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public abstract void Error(Exception exception, string messageFormat, params object[] args);

        /// <summary>
        /// Simple wrapper around the log4net Debug method.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="messageFormat"></param>
        /// <param name="args"></param>
        public abstract void Debug(Exception exception, string messageFormat, params object[] args);

        /// <summary>
        /// Simple wrapper around the log4net DebugFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public abstract void DebugFormat(string message, params object[] arguments);

        /// <summary>
        /// Simple wrapper around the log4net InfoFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public abstract void InfoFormat(string message, params object[] arguments);

        #endregion
    }

}
