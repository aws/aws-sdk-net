/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the GetMetricStatistics operation.
    /// Gets statistics for the specified metric.
    /// 
    ///  
    /// <para>
    /// The maximum number of data points returned from a single call is 1,440. If you request
    /// more than 1,440 data points, CloudWatch returns an error. To reduce the number of
    /// data points, you can narrow the specified time range and make multiple requests across
    /// adjacent time ranges, or you can increase the specified period. Data points are not
    /// returned in chronological order.
    /// </para>
    ///  
    /// <para>
    /// CloudWatch aggregates data points based on the length of the period that you specify.
    /// For example, if you request statistics with a one-hour period, CloudWatch aggregates
    /// all data points with time stamps that fall within each one-hour period. Therefore,
    /// the number of values aggregated by CloudWatch is larger than the number of data points
    /// returned.
    /// </para>
    ///  
    /// <para>
    /// CloudWatch needs raw data points to calculate percentile statistics. If you publish
    /// data using a statistic set instead, you can only retrieve percentile statistics for
    /// this data if one of the following conditions is true:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The SampleCount value of the statistic set is 1.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The Min and the Max values of the statistic set are equal.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Amazon CloudWatch retains metric data as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Data points with a period of less than 60 seconds are available for 3 hours. These
    /// data points are high-resolution metrics and are available only for custom metrics
    /// that have been defined with a <code>StorageResolution</code> of 1.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Data points with a period of 60 seconds (1-minute) are available for 15 days.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Data points with a period of 300 seconds (5-minute) are available for 63 days.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Data points with a period of 3600 seconds (1 hour) are available for 455 days (15
    /// months).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Data points that are initially published with a shorter period are aggregated together
    /// for long-term storage. For example, if you collect data using a period of 1 minute,
    /// the data remains available for 15 days with 1-minute resolution. After 15 days, this
    /// data is still available, but is aggregated and retrievable only with a resolution
    /// of 5 minutes. After 63 days, the data is further aggregated and is available with
    /// a resolution of 1 hour.
    /// </para>
    ///  
    /// <para>
    /// CloudWatch started retaining 5-minute and 1-hour metric data as of July 9, 2016.
    /// </para>
    ///  
    /// <para>
    /// For information about metrics and dimensions supported by AWS services, see the <a
    /// href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CW_Support_For_AWS.html">Amazon
    /// CloudWatch Metrics and Dimensions Reference</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetMetricStatisticsRequest : AmazonCloudWatchRequest
    {
        private List<Dimension> _dimensions = new List<Dimension>();
        private DateTime? _endTime;
        private List<string> _extendedStatistics = new List<string>();
        private string _metricName;
        private string _awsNamespace;
        private int? _period;
        private DateTime? _startTime;
        private List<string> _statistics = new List<string>();
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions. If the metric contains multiple dimensions, you must include a value
        /// for each dimension. CloudWatch treats each unique combination of dimensions as a separate
        /// metric. If a specific combination of dimensions was not published, you can't retrieve
        /// statistics for it. You must specify the same dimensions that were used when the metrics
        /// were created. For an example, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html#dimension-combinations">Dimension
        /// Combinations</a> in the <i>Amazon CloudWatch User Guide</i>. For more information
        /// about specifying dimensions, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html">Publishing
        /// Metrics</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// </summary>
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time stamp that determines the last data point to return.
        /// </para>
        ///  
        /// <para>
        /// The value specified is exclusive; results include data points up to the specified
        /// time stamp. The time stamp must be in ISO 8601 UTC format (for example, 2016-10-10T23:00:00Z).
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExtendedStatistics. 
        /// <para>
        /// The percentile statistics. Specify values between p0.0 and p100. When calling <code>GetMetricStatistics</code>,
        /// you must specify either <code>Statistics</code> or <code>ExtendedStatistics</code>,
        /// but not both.
        /// </para>
        /// </summary>
        public List<string> ExtendedStatistics
        {
            get { return this._extendedStatistics; }
            set { this._extendedStatistics = value; }
        }

        // Check to see if ExtendedStatistics property is set
        internal bool IsSetExtendedStatistics()
        {
            return this._extendedStatistics != null && this._extendedStatistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric, with or without spaces.
        /// </para>
        /// </summary>
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace of the metric, with or without spaces.
        /// </para>
        /// </summary>
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The granularity, in seconds, of the returned data points. For metrics with regular
        /// resolution, a period can be as short as one minute (60 seconds) and must be a multiple
        /// of 60. For high-resolution metrics that are collected at intervals of less than one
        /// minute, the period can be 1, 5, 10, 30, 60, or any multiple of 60. High-resolution
        /// metrics are those metrics stored by a <code>PutMetricData</code> call that includes
        /// a <code>StorageResolution</code> of 1 second.
        /// </para>
        ///  
        /// <para>
        /// If the <code>StartTime</code> parameter specifies a time stamp that is greater than
        /// 3 hours ago, you must specify the period as follows or no data points in that time
        /// range is returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Start time between 3 hours and 15 days ago - Use a multiple of 60 seconds (1 minute).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start time between 15 and 63 days ago - Use a multiple of 300 seconds (5 minutes).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start time greater than 63 days ago - Use a multiple of 3600 seconds (1 hour).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int Period
        {
            get { return this._period.GetValueOrDefault(); }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time stamp that determines the first data point to return. Start times are evaluated
        /// relative to the time that CloudWatch receives the request.
        /// </para>
        ///  
        /// <para>
        /// The value specified is inclusive; results include data points with the specified time
        /// stamp. The time stamp must be in ISO 8601 UTC format (for example, 2016-10-03T23:00:00Z).
        /// </para>
        ///  
        /// <para>
        /// CloudWatch rounds the specified time stamp as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Start time less than 15 days ago - Round down to the nearest whole minute. For example,
        /// 12:32:34 is rounded down to 12:32:00.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start time between 15 and 63 days ago - Round down to the nearest 5-minute clock interval.
        /// For example, 12:32:34 is rounded down to 12:30:00.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start time greater than 63 days ago - Round down to the nearest 1-hour clock interval.
        /// For example, 12:32:34 is rounded down to 12:00:00.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set <code>Period</code> to 5, 10, or 30, the start time of your request is
        /// rounded down to the nearest time that corresponds to even 5-, 10-, or 30-second divisions
        /// of a minute. For example, if you make a query at (HH:mm:ss) 01:05:23 for the previous
        /// 10-second period, the start time of your request is rounded down and you receive data
        /// from 01:05:10 to 01:05:20. If you make a query at 15:07:17 for the previous 5 minutes
        /// of data, using a period of 5 seconds, you receive data timestamped between 15:02:15
        /// and 15:07:15. 
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// The metric statistics, other than percentile. For percentile statistics, use <code>ExtendedStatistics</code>.
        /// When calling <code>GetMetricStatistics</code>, you must specify either <code>Statistics</code>
        /// or <code>ExtendedStatistics</code>, but not both.
        /// </para>
        /// </summary>
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && this._statistics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for a given metric. Metrics may be reported in multiple units. Not supplying
        /// a unit results in all units being returned. If you specify only a unit that the metric
        /// does not report, the results of the call are null.
        /// </para>
        /// </summary>
        public StandardUnit Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}