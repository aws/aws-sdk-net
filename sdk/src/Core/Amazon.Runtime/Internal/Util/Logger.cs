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
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.ComponentModel;
using Amazon.Runtime;
using Amazon.Util.Internal;
using ThirdParty.RuntimeBackports;
using Amazon.Runtime.Logging;
using System.Collections.Concurrent;

namespace Amazon.Runtime.Internal.Util
{
    /// <summary>
    /// This is a dynamic wrapper around log4net so we can avoid log4net being required
    /// to be distributed with the SDK.
    /// </summary>
    public class Logger : ILogger
    {
        private readonly static ConcurrentDictionary<string, IAdaptorLoggerFactory> _adaptorFactories = new ConcurrentDictionary<string, IAdaptorLoggerFactory>();
        private readonly static ConcurrentDictionary<Type, Logger> _cachedLoggers = new ConcurrentDictionary<Type, Logger>();

        private List<IAdaptorLogger> _loggers;
        private static Logger emptyLogger = new Logger();

        private Logger()
        {
            _loggers = new List<IAdaptorLogger>();
        }

        private Logger(Type type)
        {
            _loggers = new List<IAdaptorLogger>();

            foreach (var factory in _adaptorFactories.Values)
            {
                _loggers.Add(factory.CreateAdaptorLogger(type));
            }
        }

        internal static void RegisterAdaptorLoggerFactory(IAdaptorLoggerFactory factory)
        {
            _adaptorFactories.AddOrUpdate(factory.Name, factory, (key, oldValue) => factory);
            _cachedLoggers.Clear();
        }

        internal static void DeregisterAdaptorLoggerFactory(string factoryName)
        {
            if (_adaptorFactories.TryRemove(factoryName, out _))
            {
                _cachedLoggers.Clear();
            }
        }

        #region Static accessor

        public static Logger GetLogger(Type type)
        {
            if (type == null) throw new ArgumentNullException("type");

            // ConcurrentDictionary already synchronizes; a lock here would serialize every caller on the hot path.
            // GetOrAdd may run the factory more than once for the same type if two threads race on first use; the
            // extra Logger is discarded and building one has no side effects, so that is cheaper than a Lazy<T>
            // indirection on every lookup.
            return _cachedLoggers.GetOrAdd(type, static t => new Logger(t));
        }

        public static void ClearLoggerCache()
        {
            _cachedLoggers.Clear();
        }

        public static Logger EmptyLogger { get { return emptyLogger; } }

        #endregion

        #region Logging methods

        public void Error(Exception exception, string messageFormat, params object[] args)
        {
            foreach (var logger in _loggers)
            {
                if (logger.IsEnabled(SdkLogLevel.Error))
                {
                    logger.Log(SdkLogLevel.Error, messageFormat, exception, args);
                }
            }
        }

        public void Debug(Exception exception, string messageFormat, params object[] args)
        {
            foreach (var logger in _loggers)
            {
                if (logger.IsEnabled(SdkLogLevel.Debug))
                {
                    logger.Log(SdkLogLevel.Debug, messageFormat, exception, args);
                }
            }
        }

        /// <summary>
        /// Returns true if at least one registered adaptor logger is enabled for <paramref name="level"/>.
        /// Callers can use this to skip building expensive log arguments.
        /// </summary>
        internal bool IsEnabled(SdkLogLevel level)
        {
            foreach (var logger in _loggers)
            {
                if (logger.IsEnabled(level))
                {
                    return true;
                }
            }

            return false;
        }

        public void DebugFormat(string messageFormat, params object[] args)
        {
            foreach (var logger in _loggers)
            {
                if (logger.IsEnabled(SdkLogLevel.Debug))
                {
                    logger.Log(SdkLogLevel.Debug, messageFormat, null, args);
                }
            }
        }

        public void InfoFormat(string messageFormat, params object[] args)
        {
            foreach (var logger in _loggers)
            {
                if (logger.IsEnabled(SdkLogLevel.Info))
                {
                    logger.Log(SdkLogLevel.Info, messageFormat, null, args);
                }
            }
        }

        #endregion

    }
}
