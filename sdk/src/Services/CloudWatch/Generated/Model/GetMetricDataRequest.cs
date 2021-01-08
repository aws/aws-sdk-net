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

/*
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the GetMetricData operation.
    /// You can use the <code>GetMetricData</code> API to retrieve as many as 500 different
    /// metrics in a single request, with a total of as many as 100,800 data points. You can
    /// also optionally perform math expressions on the values of the returned statistics,
    /// to create new time series that represent new insights into your data. For example,
    /// using Lambda metrics, you could divide the Errors metric by the Invocations metric
    /// to get an error rate time series. For more information about metric math expressions,
    /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/using-metric-math.html#metric-math-syntax">Metric
    /// Math Syntax and Functions</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// 
    ///  
    /// <para>
    /// Calls to the <code>GetMetricData</code> API have a different pricing structure than
    /// calls to <code>GetMetricStatistics</code>. For more information about pricing, see
    /// <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon CloudWatch Pricing</a>.
    /// </para>
    ///  
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
    /// If you omit <code>Unit</code> in your request, all data that was collected with any
    /// unit is returned, along with the corresponding units that were specified when the
    /// data was reported to CloudWatch. If you specify a unit, the operation returns only
    /// data that was collected with that unit specified. If you specify a unit that does
    /// not match the data collected, the results of the operation are null. CloudWatch does
    /// not perform unit conversions.
    /// </para>
    /// </summary>
    public partial class GetMetricDataRequest : AmazonCloudWatchRequest
    {
        private DateTime? _endTimeUtc;
        private int? _maxDatapoints;
        private List<MetricDataQuery> _metricDataQueries = new List<MetricDataQuery>();
        private string _nextToken;
        private ScanBy _scanBy;
        private DateTime? _startTimeUtc;

        /// <summary>
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// The time stamp indicating the latest data to be returned.
        /// </para>
        ///  
        /// <para>
        /// The value specified is exclusive; results include data points up to the specified
        /// time stamp.
        /// </para>
        ///  
        /// <para>
        /// For better performance, specify <code>StartTime</code> and <code>EndTime</code> values
        /// that align with the value of the metric's <code>Period</code> and sync up with the
        /// beginning and end of an hour. For example, if the <code>Period</code> of a metric
        /// is 5 minutes, specifying 12:05 or 12:30 as <code>EndTime</code> can get a faster response
        /// from CloudWatch than setting 12:07 or 12:29 as the <code>EndTime</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTimeUtc
        {
            get { return this._endTimeUtc.GetValueOrDefault(); }
            set { this._endTime = this._endTimeUtc = value; }
        }

        // Check to see if EndTimeUtc property is set
        internal bool IsSetEndTimeUtc()
        {
            return this._endTimeUtc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDatapoints. 
        /// <para>
        /// The maximum number of data points the request should return before paginating. If
        /// you omit this, the default of 100,800 is used.
        /// </para>
        /// </summary>
        public int MaxDatapoints
        {
            get { return this._maxDatapoints.GetValueOrDefault(); }
            set { this._maxDatapoints = value; }
        }

        // Check to see if MaxDatapoints property is set
        internal bool IsSetMaxDatapoints()
        {
            return this._maxDatapoints.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricDataQueries. 
        /// <para>
        /// The metric queries to be returned. A single <code>GetMetricData</code> call can include
        /// as many as 500 <code>MetricDataQuery</code> structures. Each of these structures can
        /// specify either a metric to retrieve, or a math expression to perform on retrieved
        /// data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MetricDataQuery> MetricDataQueries
        {
            get { return this._metricDataQueries; }
            set { this._metricDataQueries = value; }
        }

        // Check to see if MetricDataQueries property is set
        internal bool IsSetMetricDataQueries()
        {
            return this._metricDataQueries != null && this._metricDataQueries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Include this value, if it was returned by the previous <code>GetMetricData</code>
        /// operation, to get the next set of data points.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ScanBy. 
        /// <para>
        /// The order in which data points should be returned. <code>TimestampDescending</code>
        /// returns the newest data first and paginates when the <code>MaxDatapoints</code> limit
        /// is reached. <code>TimestampAscending</code> returns the oldest data first and paginates
        /// when the <code>MaxDatapoints</code> limit is reached.
        /// </para>
        /// </summary>
        public ScanBy ScanBy
        {
            get { return this._scanBy; }
            set { this._scanBy = value; }
        }

        // Check to see if ScanBy property is set
        internal bool IsSetScanBy()
        {
            return this._scanBy != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// The time stamp indicating the earliest data to be returned.
        /// </para>
        ///  
        /// <para>
        /// The value specified is inclusive; results include data points with the specified time
        /// stamp. 
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
        ///  
        /// <para>
        /// For better performance, specify <code>StartTime</code> and <code>EndTime</code> values
        /// that align with the value of the metric's <code>Period</code> and sync up with the
        /// beginning and end of an hour. For example, if the <code>Period</code> of a metric
        /// is 5 minutes, specifying 12:05 or 12:30 as <code>StartTime</code> can get a faster
        /// response from CloudWatch than setting 12:07 or 12:29 as the <code>StartTime</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTimeUtc
        {
            get { return this._startTimeUtc.GetValueOrDefault(); }
            set { this._startTime = this._startTimeUtc = value; }
        }

        // Check to see if StartTimeUtc property is set
        internal bool IsSetStartTimeUtc()
        {
            return this._startTimeUtc.HasValue; 
        }

#region Backwards compatible properties
        private DateTime? _endTime;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use EndTimeUtc instead. Setting either EndTime or EndTimeUtc
        /// results in both EndTime and EndTimeUtc being assigned, the latest assignment to either
        /// one of the two property is reflected in the value of both. EndTime is provided for
        /// backwards compatibility only and assigning a non-Utc DateTime to it results in the
        /// wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The time stamp indicating the latest data to be returned.
        /// </para>
        ///  
        /// <para>
        /// The value specified is exclusive; results include data points up to the specified
        /// time stamp.
        /// </para>
        ///  
        /// <para>
        /// For better performance, specify <code>StartTime</code> and <code>EndTime</code> values
        /// that align with the value of the metric's <code>Period</code> and sync up with the
        /// beginning and end of an hour. For example, if the <code>Period</code> of a metric
        /// is 5 minutes, specifying 12:05 or 12:30 as <code>EndTime</code> can get a faster response
        /// from CloudWatch than setting 12:07 or 12:29 as the <code>EndTime</code>.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use EndTimeUtc instead. Setting either EndTime or EndTimeUtc results in both EndTime and " +
            "EndTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. EndTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set
            {
                this._endTime = value;
                this._endTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
        /// <summary>
        /// Gets and sets the property StartTimeUtc. 
        /// <para>
        /// This property is deprecated. Setting this property results in non-UTC DateTimes not
        /// being marshalled correctly. Use StartTimeUtc instead. Setting either StartTime or
        /// StartTimeUtc results in both StartTime and StartTimeUtc being assigned, the latest
        /// assignment to either one of the two property is reflected in the value of both. StartTime
        /// is provided for backwards compatibility only and assigning a non-Utc DateTime to it
        /// results in the wrong timestamp being passed to the service.
        /// </para>
        ///  
        /// <para>
        /// The time stamp indicating the earliest data to be returned.
        /// </para>
        ///  
        /// <para>
        /// The value specified is inclusive; results include data points with the specified time
        /// stamp. 
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
        ///  
        /// <para>
        /// For better performance, specify <code>StartTime</code> and <code>EndTime</code> values
        /// that align with the value of the metric's <code>Period</code> and sync up with the
        /// beginning and end of an hour. For example, if the <code>Period</code> of a metric
        /// is 5 minutes, specifying 12:05 or 12:30 as <code>StartTime</code> can get a faster
        /// response from CloudWatch than setting 12:07 or 12:29 as the <code>StartTime</code>.
        /// </para>
        /// </summary>
        [Obsolete("Setting this property results in non-UTC DateTimes not being marshalled correctly. " +
            "Use StartTimeUtc instead. Setting either StartTime or StartTimeUtc results in both StartTime and " +
            "StartTimeUtc being assigned, the latest assignment to either one of the two property is " + 
            "reflected in the value of both. StartTime is provided for backwards compatibility only and " +
            "assigning a non-Utc DateTime to it results in the wrong timestamp being passed to the service.", false)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set
            {
                this._startTime = value;
                this._startTimeUtc = new DateTime(value.Ticks, DateTimeKind.Utc);
            }
        }
#endregion
    }
}