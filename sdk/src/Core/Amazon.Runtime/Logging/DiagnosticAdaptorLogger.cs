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
using System.Diagnostics;
using System.Globalization;
using System.Text;
using System.Threading;

namespace Amazon.Runtime.Logging
{
    /// <summary>
    /// Adaptor for outputing the SDK logs to the System.Diagnostics.
    /// </summary>
    internal class DiagnosticAdaptorLogger : IAdaptorLogger
    {
        int eventId = 0;
        private TraceSource _trace;

        public bool IsEnabled(SdkLogLevel level) => _trace != null;

        internal DiagnosticAdaptorLogger(TraceSource trace)
        {
            _trace = trace;
        }

        public void Log(SdkLogLevel level, string message, Exception ex, params object[] parameters)
        {
            var localEventId = Interlocked.Increment(ref eventId);
            _trace.TraceData(ConvertLogLevel(level), localEventId, new DiagnosticLogMessage(CultureInfo.InvariantCulture, message, parameters));
        }

        private TraceEventType ConvertLogLevel(SdkLogLevel level) => level switch
        {
            SdkLogLevel.Trace => TraceEventType.Verbose,
            SdkLogLevel.Debug => TraceEventType.Verbose,
            SdkLogLevel.Info => TraceEventType.Information,
            SdkLogLevel.Warn => TraceEventType.Warning,
            SdkLogLevel.Error => TraceEventType.Error,
            SdkLogLevel.Fatal => TraceEventType.Critical,
            _ => TraceEventType.Information
        };

        /// <summary>
        /// A single logged message
        /// </summary>
        internal class DiagnosticLogMessage : ILogMessage
        {
            /// <summary>
            /// Log message arguments.
            /// </summary>
            public object[] Args { get; private set; }

            /// <summary>
            /// Culture-specific formatting provider.
            /// </summary>
            public IFormatProvider Provider { get; private set; }

            /// <summary>
            /// Log message format.
            /// </summary>
            public string Format { get; private set; }

            public DiagnosticLogMessage(string message) : this(CultureInfo.InvariantCulture, message) { }
            public DiagnosticLogMessage(string format, params object[] args) : this(CultureInfo.InvariantCulture, format, args) { }
            public DiagnosticLogMessage(IFormatProvider provider, string format, params object[] args)
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
    }

    internal class DiagnosticAdaptorLoggerFactory : IAdaptorLoggerFactory
    {
        public string Name { get; } = "Diagnostic";

        public IAdaptorLogger CreateAdaptorLogger(Type type)
        {
            return new DiagnosticAdaptorLogger(TraceSourceUtil.GetTraceSource(type));
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
                    TraceSource ts = new TraceSource(testName, sourceLevels);

                    ts.Listeners.AddRange(AWSConfigs.TraceListeners(testName));

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
}
