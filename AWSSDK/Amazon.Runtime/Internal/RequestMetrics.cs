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
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
    public class RequestMetrics
    {
        #region Enums/classes

        // Set of predefined Metrics.
        public enum Metric
        {
            // response enums
            AWSErrorCode,
            AWSRequestID,
            BytesProcessed,
            Exception,
            RedirectLocation,
            ResponseProcessingTime,
            ResponseUnmarshallTime,
            ResponseReadTime,
            StatusCode,

            // request enums
            AttemptCount,
            CredentialsRequestTime,
            HttpRequestTime,
            ProxyHost,
            RequestSigningTime,
            RetryPauseTime,

            // overall enums
            AsyncCall,
            ClientExecuteTime,
            MethodName,
            ServiceEndpoint,
            ServiceName,
            RequestSize,
        }

        /// <summary>
        /// Timing information for a metric
        /// </summary>
        public class Timing
        {
            private long startTime;
            private long endTime;

            /// <summary>
            /// Empty, stopped timing object
            /// </summary>
            public Timing()
            {
                startTime = endTime = 0;
                IsFinished = true;
            }

            /// <summary>
            /// Timing object in a started state
            /// </summary>
            /// <param name="currentTime"></param>
            public Timing(long currentTime)
            {
                startTime = currentTime;
                IsFinished = false;
            }


            /// <summary>
            /// Stops timing
            /// </summary>
            /// <param name="currentTime"></param>
            public void Stop(long currentTime)
            {
                endTime = currentTime;
                IsFinished = true;
            }

            /// <summary>
            /// Whether the timing has been stopped
            /// </summary>
            public bool IsFinished { get; private set; }

            /// <summary>
            /// Elapsed ticks from start to stop.
            /// If timing hasn't been stopped yet, returns 0.
            /// </summary>
            public long ElapsedTicks { get { return !IsFinished ? 0 : endTime - startTime; } }

            /// <summary>
            /// Elapsed time from start to stop.
            /// If timing hasn't been stopped yet, returns TimeSpan.Zero
            /// </summary>
            public TimeSpan ElapsedTime { get { return TimeSpan.FromTicks(ElapsedTicks); } }
        }

        /// <summary>
        /// Timing event, stops timing of a metric when disposed
        /// </summary>
        public class TimingEvent : IDisposable
        {
            private Metric metric;
            private RequestMetrics metrics;

            internal TimingEvent(RequestMetrics metrics, Metric metric)
            {
                this.metrics = metrics;
                this.metric = metric;
            }

            #region IDisposable Members

            public void Dispose()
            {
                metrics.StopEvent(metric);
            }

            #endregion
        }

        // Error encountered in metrics logging
        private class MetricError
        {
            public Metric Metric { get; private set; }
            public string Message { get; private set; }
            public Exception Exception { get; private set; }
            public DateTime Time { get; private set; }

            public MetricError(Metric metric, string messageFormat, params object[] args) : this(metric, null, messageFormat, args) { }
            public MetricError(Metric metric, Exception exception, string messageFormat, params object[] args)
            {
                Time = DateTime.Now;
                try
                {
                    Message = string.Format(messageFormat, args);
                }
                catch
                {
                    Message = string.Format("Error message: {0}", messageFormat);
                }
                Exception = exception;
                Metric = metric;
            }
        }

        #endregion

        #region Private members

        private object metricsLock = new object();
        private Stopwatch stopWatch;
        private Dictionary<Metric, Timing> inFlightTimings;
        private List<MetricError> errors = new List<MetricError>();
        private long CurrentTime { get { return stopWatch.GetElapsedDateTimeTicks(); } }
        private void LogError_Locked(Metric metric, string messageFormat, params object[] args)
        {
            errors.Add(new MetricError(metric, messageFormat, args));
        }
        private void LogError_Locked(Metric metric, Exception exception, string messageFormat, params object[] args)
        {
            errors.Add(new MetricError(metric, exception, messageFormat, args));
        }
        private static void Log(StringWriter writer, Metric metric, object metricValue)
        {
            writer.Write("{0} = {1}; ", metric, metricValue);
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Collection of properties being tracked
        /// </summary>
        public Dictionary<Metric, List<object>> Properties { get; private set; }
        /// <summary>
        /// Timings for metrics being tracked
        /// </summary>
        public Dictionary<Metric, List<Timing>> Timings { get; private set; }

        /// <summary>
        /// Counters being tracked
        /// </summary>
        public Dictionary<Metric, long> Counters { get; private set; }

        /// <summary>
        /// Whether metrics are enabled for the request
        /// </summary>
        public bool IsEnabled { get; internal set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs an empty, disabled metrics object
        /// </summary>
        public RequestMetrics()
        {
            stopWatch = Stopwatch.StartNew();
            Properties = new Dictionary<Metric, List<object>>();
            Timings = new Dictionary<Metric, List<Timing>>();
            Counters = new Dictionary<Metric, long>();
            inFlightTimings = new Dictionary<Metric, Timing>();
            IsEnabled = false;
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Starts timing an event. Logs an exception if an event
        /// of the same type was started but not stopped.
        /// </summary>
        /// <param name="metric"></param>
        /// <returns></returns>
        public TimingEvent StartEvent(Metric metric)
        {
            lock (metricsLock)
            {
                if (inFlightTimings.ContainsKey(metric))
                    LogError_Locked(metric, "Starting multiple events for the same metric");
                inFlightTimings[metric] = new Timing(CurrentTime);
            }
            return new TimingEvent(this, metric);
        }
        /// <summary>
        /// Stops timing an event. Logs an exception if the event wasn't started.
        /// </summary>
        /// <param name="metric"></param>
        /// <returns></returns>
        public Timing StopEvent(Metric metric)
        {
            Timing timing;
            lock (metricsLock)
            {
                if (!inFlightTimings.TryGetValue(metric, out timing))
                {
                    LogError_Locked(metric, "Trying to stop event that has not been started");
                    return new Timing();
                }
                inFlightTimings.Remove(metric);
                timing.Stop(CurrentTime);

                if (IsEnabled)
                {
                    List<Timing> list;
                    if (!Timings.TryGetValue(metric, out list))
                    {
                        list = new List<Timing>();
                        Timings[metric] = list;
                    }
                    list.Add(timing);
                }
            }
            return timing;
        }

        /// <summary>
        /// Adds a property for a metric. If there are multiple, the
        /// object is added as a new item in a list.
        /// </summary>
        /// <param name="metric"></param>
        /// <param name="property"></param>
        public void AddProperty(Metric metric, object property)
        {
            if (!IsEnabled) return;

            List<object> list;
            lock (metricsLock)
            {
                if (!Properties.TryGetValue(metric, out list))
                {
                    list = new List<object>();
                    Properties[metric] = list;
                }
                list.Add(property);
            }
        }

        /// <summary>
        /// Sets a counter for a specific metric.
        /// </summary>
        /// <param name="metric"></param>
        /// <param name="value"></param>
        public void SetCounter(Metric metric, long value)
        {
            if (!IsEnabled) return;

            lock (metricsLock)
            {
                Counters[metric] = value;
            }
        }
        /// <summary>
        /// Increments a specific metric counter.
        /// If counter doesn't exist yet, it is set to 1.
        /// </summary>
        /// <param name="metric"></param>
        public void IncrementCounter(Metric metric)
        {
            if (!IsEnabled) return;

            lock (metricsLock)
            {
                long value;
                if (!Counters.TryGetValue(metric, out value))
                {
                    value = 1;
                }
                else
                {
                    value++;
                }
                Counters[metric] = value;
            }
        }

        /// <summary>
        /// Returns errors associated with the metric, including
        /// if there are still any timing events in-flight.
        /// </summary>
        /// <returns></returns>
        public string GetErrors()
        {
            using (StringWriter writer = new StringWriter())
            {
                lock (metricsLock)
                {
                    if (inFlightTimings.Count > 0)
                    {
                        string inFlightTimingsValue = string.Join(", ", inFlightTimings.Keys.Select(k => k.ToString()).ToArray());
                        writer.Write("Timings are still in flight: {0}.", inFlightTimingsValue);
                    }
                    if (errors.Count > 0)
                    {
                        writer.Write("Logged {0} metrics errors: ", errors.Count);
                        foreach (MetricError error in errors)
                        {
                            // skip empty errors
                            if (error.Exception == null && string.IsNullOrEmpty(error.Message))
                                continue;

                            writer.Write("{0} - {1} - ",
                                error.Time.ToString(AWSSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture),
                                error.Metric);
                            if (!string.IsNullOrEmpty(error.Message))
                            {
                                writer.Write(error.Message);
                                writer.Write(";");
                            }
                            if (error.Exception != null)
                            {
                                writer.Write(error.Exception);
                                writer.Write("; ");
                            }
                        }
                    }
                }

                return writer.ToString();
            }
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string representation of the current metrics.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!IsEnabled)
                return "Metrics logging disabled";

            string log;
            using (StringWriter writer = new StringWriter(CultureInfo.InvariantCulture))
            {
                lock (metricsLock)
                {
                    foreach (var kvp in Properties)
                    {
                        Metric metric = kvp.Key;
                        List<object> values = kvp.Value;
                        string[] stringValues = values.Select(o => o == null ? "NULL" : o.ToString()).ToArray();
                        string metricValue = string.Join(", ", stringValues);
                        Log(writer, metric, metricValue);
                    }
                    foreach (var kvp in Timings)
                    {
                        Metric metric = kvp.Key;
                        List<Timing> list = kvp.Value;
                        foreach (var timing in list)
                        {
                            if (timing.IsFinished)
                                Log(writer, metric, timing.ElapsedTime);
                        }
                    }
                    foreach (var kvp in Counters)
                    {
                        Metric metric = kvp.Key;
                        long value = kvp.Value;
                        Log(writer, metric, value);
                    }
                }
                log = writer.ToString();
                log = log.Replace(Environment.NewLine, string.Empty);
                return log;
            }
        }

        #endregion
    }
}
