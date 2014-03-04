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
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.ComponentModel;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// A single logged message
    /// </summary>
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
        private static IDictionary<Type, Logger> cachedLoggers = new Dictionary<Type, Logger>();
        private List<InternalLogger> loggers;
        private static Logger emptyLogger = new Logger();

        private Logger()
        {
            loggers = new List<InternalLogger>();
        }
        private Logger(Type type)
        {
            loggers = new List<InternalLogger>();

            InternalLog4netLogger log4netLogger = new InternalLog4netLogger(type);
            loggers.Add(log4netLogger);
            InternalSystemDiagnosticsLogger sdLogger = new InternalSystemDiagnosticsLogger(type);
            loggers.Add(sdLogger);

            ConfigureLoggers();
            AWSConfigs.PropertyChanged += ConfigsChanged;
        }
        private void ConfigsChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e != null && string.Equals(e.PropertyName, "Logging", StringComparison.Ordinal))
            {
                ConfigureLoggers();
            }
        }
        private void ConfigureLoggers()
        {
            LoggingOptions logging = AWSConfigs.Logging;
            foreach (InternalLogger il in loggers)
            {
                if (il is InternalLog4netLogger)
                    il.IsEnabled = (logging & LoggingOptions.Log4Net) == LoggingOptions.Log4Net;
                if (il is InternalSystemDiagnosticsLogger)
                    il.IsEnabled = (logging & LoggingOptions.SystemDiagnostics) == LoggingOptions.SystemDiagnostics;
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
        public static Logger EmptyLogger { get { return emptyLogger; } }

        #endregion

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

    /// <summary>
    /// Logger wrapper for System.Diagnostics.TraceSource logger.
    /// </summary>
    internal class InternalSystemDiagnosticsLogger : InternalLogger
    {
        volatile int eventId = 0;
        TraceSource trace;

        public InternalSystemDiagnosticsLogger(Type declaringType)
            : base(declaringType)
        {
            this.trace = TraceSourceUtil.GetTraceSource(declaringType);
        }

        #region Overrides

        public override void Flush()
        {
            if (trace != null)
                this.trace.Flush();
        }

        public override void Error(Exception exception, string messageFormat, params object[] args)
        {
            trace.TraceData(TraceEventType.Error, eventId++, new LogMessage(CultureInfo.InvariantCulture, messageFormat, args), exception);
        }

        public override void Debug(Exception exception, string messageFormat, params object[] args)
        {
            trace.TraceData(TraceEventType.Verbose, eventId++, new LogMessage(CultureInfo.InvariantCulture, messageFormat, args), exception);
        }

        public override void DebugFormat(string messageFormat, params object[] args)
        {
            trace.TraceData(TraceEventType.Verbose, eventId++, new LogMessage(CultureInfo.InvariantCulture, messageFormat, args));
        }

        public override void InfoFormat(string message, params object[] arguments)
        {
            trace.TraceData(TraceEventType.Information, eventId++, new LogMessage(CultureInfo.InvariantCulture, message, arguments));
        }

        public override bool IsDebugEnabled { get { return (trace != null); } }

        public override bool IsErrorEnabled { get { return (trace != null); } }

        public override bool IsInfoEnabled { get { return (trace != null); } }

        #endregion
    }

    /// <summary>
    /// Logger wrapper for reflected log4net logging methods.
    /// </summary>
    internal class InternalLog4netLogger : InternalLogger
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

        static MethodInfo isEnabledForMethod;
        static Type systemStringFormatType;
        static Type loggerType;

        #endregion

        private object internalLogger;
        private bool? isErrorEnabled;
        private bool? isDebugEnabled;
        private bool? isInfoEnabled;

        /// <summary>
        /// This should be a one time call to use reflection to find all the types and methods
        /// needed for the logging API.
        /// </summary>
        private static void loadStatics()
        {
            lock (InternalLog4netLogger.LOCK)
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
                    isEnabledForMethod = logType.GetMethod("IsEnabledFor", new Type[] { levelType });

                    if (getLoggerWithTypeMethod == null ||
                        isEnabledForMethod == null ||
                        logType == null ||
                        levelType == null ||
                        logMethod == null)
                    {
                        loadState = LoadState.Failed;
                        return;
                    }

                    // If log4net logging is enabled, we attempt to activate log4net by calling XmlConfigurator.Configure()
                    if ((AWSConfigs.Logging & LoggingOptions.Log4Net) == LoggingOptions.Log4Net)
                    {
                        Type xmlConfiguratorType = Type.GetType("log4net.Config.XmlConfigurator, log4net");
                        if (xmlConfiguratorType != null)
                        {
                            MethodInfo configureMethod = xmlConfiguratorType.GetMethod("Configure", Type.EmptyTypes);
                            if (configureMethod != null)
                            {
                                configureMethod.Invoke(null, null);
                            }
                        }
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

        public InternalLog4netLogger(Type declaringType)
            : base(declaringType)
        {
            if (loadState == LoadState.Uninitialized)
            {
                loadStatics();
            }

            if (logMangerType == null)
                return;

            this.internalLogger = getLoggerWithTypeMethod.Invoke(null, new object[] { Assembly.GetCallingAssembly(), declaringType }); //Assembly.GetCallingAssembly()
        }

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
                if (!isErrorEnabled.HasValue)
                {
                    if (loadState != LoadState.Success || this.internalLogger == null || loggerType == null || systemStringFormatType == null || errorLevelPropertyValue == null)
                        isErrorEnabled = false;
                    else
                        isErrorEnabled = Convert.ToBoolean(isEnabledForMethod.Invoke(this.internalLogger, new object[] { errorLevelPropertyValue }));
                }
                return isErrorEnabled.Value;
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
            logMethod.Invoke(
                this.internalLogger,
                new object[]
                {
                    loggerType, errorLevelPropertyValue,
                    new LogMessage(CultureInfo.InvariantCulture, messageFormat, args),
                    exception
                });
        }

        /// <summary>
        /// Simple wrapper around the log4net IsDebugEnabled property.
        /// </summary>
        public override bool IsDebugEnabled
        {
            get
            {
                if (!isDebugEnabled.HasValue)
                {
                    if (loadState != LoadState.Success || this.internalLogger == null || loggerType == null || systemStringFormatType == null || debugLevelPropertyValue == null)
                        isDebugEnabled = false;
                    else
                        isDebugEnabled = Convert.ToBoolean(isEnabledForMethod.Invoke(this.internalLogger, new object[] { debugLevelPropertyValue }));
                }
                return isDebugEnabled.Value;
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
            logMethod.Invoke(
                this.internalLogger,
                new object[]
                {
                    loggerType, debugLevelPropertyValue,
                    new LogMessage(CultureInfo.InvariantCulture, messageFormat, args),
                    exception
                });
        }

        /// <summary>
        /// Simple wrapper around the log4net DebugFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void DebugFormat(string message, params object[] arguments)
        {
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
        /// Simple wrapper around the log4net IsInfoEnabled property.
        /// </summary>
        public override bool IsInfoEnabled
        {
            get
            {
                if (!isInfoEnabled.HasValue)
                {
                    if (loadState != LoadState.Success || this.internalLogger == null || loggerType == null || systemStringFormatType == null || infoLevelPropertyValue == null)
                        isInfoEnabled = false;
                    else
                        isInfoEnabled = Convert.ToBoolean(isEnabledForMethod.Invoke(this.internalLogger, new object[] { infoLevelPropertyValue }));
                }
                return isInfoEnabled.Value;
            }
        }

        /// <summary>
        /// Simple wrapper around the log4net InfoFormat method.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="arguments"></param>
        public override void InfoFormat(string message, params object[] arguments)
        {
            logMethod.Invoke(
                this.internalLogger,
                new object[]
                {
                    loggerType, infoLevelPropertyValue,
                    new LogMessage(CultureInfo.InvariantCulture, message, arguments),
                    null
                });
        }

        #endregion
    }

    /// <summary>
    /// Creates TraceRoute for a given Type or the closest "parent" that has a listener configured.
    /// Example: if type is Amazon.DynamoDB.AmazonDynamoDBClient, listeners can be configured for:
    /// -Amazon.DynamoDB.AmazonDynamoDBClient
    /// -Amazon.DynamoDB
    /// -Amazon
    /// The first matching TraceSource with listeners will be used.
    /// If no listeners are configured for type or one of its "parents", will return null.
    /// </summary>
    internal static class TraceSourceUtil
    {
        #region Private members

        private static object cacheLock = new object();
        private static Dictionary<string, string> sourceToSourceWithListenersMap = new Dictionary<string, string>();

        #endregion

        #region Public methods

        /// <summary>
        /// Gets a TraceSource for given Type with SourceLevels.All.
        /// If there are no listeners configured for targetType or one of its "parents", returns null.
        /// </summary>
        /// <param name="targetType"></param>
        /// <returns></returns>
        public static TraceSource GetTraceSource(Type targetType)
        {
            return GetTraceSource(targetType, SourceLevels.All);
        }

        /// <summary>
        /// Gets a TraceSource for given Type and SourceLevels.
        /// If there are no listeners configured for targetType or one of its "parents", returns null.
        /// </summary>
        /// <param name="targetType"></param>
        /// <param name="sourceLevels"></param>
        /// <returns></returns>
        public static TraceSource GetTraceSource(Type targetType, SourceLevels sourceLevels)
        {
            TraceSource traceSource = GetTraceSourceWithListeners(targetType.FullName, sourceLevels);
            return traceSource;
        }

        #endregion

        #region Private methods

        // Gets the name of the closest "parent" TraceRoute that has listeners, or null otherwise.
        private static TraceSource GetTraceSourceWithListeners(string name, SourceLevels sourceLevels)
        {
            lock (cacheLock)
            {
                TraceSource traceSource = null;
                string targetName;
                if (!sourceToSourceWithListenersMap.TryGetValue(name, out targetName))
                {
                    traceSource = GetTraceSourceWithListeners_Locked(name, sourceLevels);
                    targetName = traceSource == null ? null : traceSource.Name;
                    sourceToSourceWithListenersMap[name] = targetName;
                }
                else if (targetName != null)
                {
                    traceSource = new TraceSource(targetName, sourceLevels);
                }
                return traceSource;
            }
        }

        // Gets the name of the closest "parent" TraceRoute that has listeners, or null otherwise.
        private static TraceSource GetTraceSourceWithListeners_Locked(string name, SourceLevels sourceLevels)
        {
            string[] parts = name.Split(new char[] { '.' }, StringSplitOptions.None);

            List<string> namesToTest = new List<string>();
            StringBuilder sb = new StringBuilder();
            foreach (var part in parts)
            {
                if (sb.Length > 0)
                    sb.Append(".");
                sb.Append(part);

                string partialName = sb.ToString();
                namesToTest.Add(partialName);
            }

            namesToTest.Reverse();
            foreach (var testName in namesToTest)
            {
                TraceSource ts = null;
                ts = new TraceSource(testName, sourceLevels);
                // no listeners? skip
                if (ts.Listeners == null || ts.Listeners.Count == 0)
                {
                    ts.Close();
                    continue;
                }
                // more than one listener? use this TraceSource
                if (ts.Listeners.Count > 1)
                    return ts;
                TraceListener listener = ts.Listeners[0];
                // single listener isn't DefaultTraceListener? use this TraceRoute
                if (!(listener is DefaultTraceListener))
                    return ts;
                // single listener is DefaultTraceListener but isn't named Default? use this TraceRoute
                if (!string.Equals(listener.Name, "Default", StringComparison.Ordinal))
                    return ts;

                // not the TraceSource we're looking for, close it
                ts.Close();
            }

            // nothing found? no listeners are configured for any of the names, even the original,
            // so return null to signify failure
            return null;
        }

        #endregion
    }
}
