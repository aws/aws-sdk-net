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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// Percentile statistics are not available for metrics when any of the metric values
    /// are negative numbers.
    /// </para>
    ///  
    /// <para>
    /// Amazon CloudWatch retains metric data as follows:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Data points with a period of less than 60 seconds are available for 3 hours. These
    /// data points are high-resolution metrics and are available only for custom metrics
    /// that have been defined with a <c>StorageResolution</c> of 1.
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
    /// For information about metrics and dimensions supported by Amazon Web Services services,
    /// see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CW_Support_For_AWS.html">Amazon
    /// CloudWatch Metrics and Dimensions Reference</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetMetricStatisticsRequest : AmazonCloudWatchRequest
    {
        private List<Dimension> _dimensions = AWSConfigs.InitializeCollections ? new List<Dimension>() : null;
        private DateTime? _endTime;
        private List<string> _extendedStatistics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _metricName;
        private string _awsNamespace;
        private int? _period;
        private DateTime? _startTime;
        private List<string> _statistics = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions. If the metric contains multiple dimensions, you must include a value
        /// for each dimension. CloudWatch treats each unique combination of dimensions as a separate
        /// metric. If a specific combination of dimensions was not published, you can't retrieve
        /// statistics for it. You must specify the same dimensions that were used when the metrics
        /// were created. For an example, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html#dimension-combinations">Dimension
        /// Combinations</a> in the <i>Amazon CloudWatch User Guide</i>. For more information
        /// about specifying dimensions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html">Publishing
        /// Metrics</a> in the <i>Amazon CloudWatch User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=30)]
        public List<Dimension> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time stamp that determines the last data point to return.
        /// </para>
        ///  
        /// <para>
        /// The value specified is exclusive; results include data points up to the specified
        /// time stamp. In a raw HTTP query, the time stamp must be in ISO 8601 UTC format (for
        /// example, 2016-10-10T23:00:00Z).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? EndTime
        {
            get { return this._endTime; }
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
        /// The percentile statistics. Specify values between p0.0 and p100. When calling <c>GetMetricStatistics</c>,
        /// you must specify either <c>Statistics</c> or <c>ExtendedStatistics</c>, but not both.
        /// Percentile statistics are not available for metrics when any of the metric values
        /// are negative numbers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ExtendedStatistics
        {
            get { return this._extendedStatistics; }
            set { this._extendedStatistics = value; }
        }

        // Check to see if ExtendedStatistics property is set
        internal bool IsSetExtendedStatistics()
        {
            return this._extendedStatistics != null && (this._extendedStatistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric, with or without spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// minute, the period can be 1, 5, 10, 20, 30, 60, or any multiple of 60. High-resolution
        /// metrics are those metrics stored by a <c>PutMetricData</c> call that includes a <c>StorageResolution</c>
        /// of 1 second.
        /// </para>
        ///  
        /// <para>
        /// If the <c>StartTime</c> parameter specifies a time stamp that is greater than 3 hours
        /// ago, you must specify the period as follows or no data points in that time range is
        /// returned:
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
        [AWSProperty(Required=true, Min=1)]
        public int? Period
        {
            get { return this._period; }
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
        /// stamp. In a raw HTTP query, the time stamp must be in ISO 8601 UTC format (for example,
        /// 2016-10-03T23:00:00Z).
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
        /// If you set <c>Period</c> to 5, 10, 20, or 30, the start time of your request is rounded
        /// down to the nearest time that corresponds to even 5-, 10-, 20-, or 30-second divisions
        /// of a minute. For example, if you make a query at (HH:mm:ss) 01:05:23 for the previous
        /// 10-second period, the start time of your request is rounded down and you receive data
        /// from 01:05:10 to 01:05:20. If you make a query at 15:07:17 for the previous 5 minutes
        /// of data, using a period of 5 seconds, you receive data timestamped between 15:02:15
        /// and 15:07:15. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
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
        /// The metric statistics, other than percentile. For percentile statistics, use <c>ExtendedStatistics</c>.
        /// When calling <c>GetMetricStatistics</c>, you must specify either <c>Statistics</c>
        /// or <c>ExtendedStatistics</c>, but not both.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<string> Statistics
        {
            get { return this._statistics; }
            set { this._statistics = value; }
        }

        // Check to see if Statistics property is set
        internal bool IsSetStatistics()
        {
            return this._statistics != null && (this._statistics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        /// The unit for a given metric. If you omit <c>Unit</c>, all data that was collected
        /// with any unit is returned, along with the corresponding units that were specified
        /// when the data was reported to CloudWatch. If you specify a unit, the operation returns
        /// only data that was collected with that unit specified. If you specify a unit that
        /// does not match the data collected, the results of the operation are null. CloudWatch
        /// does not perform unit conversions.
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