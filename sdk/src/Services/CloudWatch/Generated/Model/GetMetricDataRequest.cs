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
    /// Container for the parameters to the GetMetricData operation.
    /// You can use the <c>GetMetricData</c> API to retrieve CloudWatch metric values. The
    /// operation can also include a CloudWatch Metrics Insights query, and one or more metric
    /// math functions.
    /// 
    ///  
    /// <para>
    /// A <c>GetMetricData</c> operation that does not include a query can retrieve as many
    /// as 500 different metrics in a single request, with a total of as many as 100,800 data
    /// points. You can also optionally perform metric math expressions on the values of the
    /// returned statistics, to create new time series that represent new insights into your
    /// data. For example, using Lambda metrics, you could divide the Errors metric by the
    /// Invocations metric to get an error rate time series. For more information about metric
    /// math expressions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/using-metric-math.html#metric-math-syntax">Metric
    /// Math Syntax and Functions</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you include a Metrics Insights query, each <c>GetMetricData</c> operation can include
    /// only one query. But the same <c>GetMetricData</c> operation can also retrieve other
    /// metrics. Metrics Insights queries can query only the most recent three hours of metric
    /// data. For more information about Metrics Insights, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/query_with_cloudwatch-metrics-insights.html">Query
    /// your metrics with CloudWatch Metrics Insights</a>.
    /// </para>
    ///  
    /// <para>
    /// Calls to the <c>GetMetricData</c> API have a different pricing structure than calls
    /// to <c>GetMetricStatistics</c>. For more information about pricing, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon
    /// CloudWatch Pricing</a>.
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
    /// If you omit <c>Unit</c> in your request, all data that was collected with any unit
    /// is returned, along with the corresponding units that were specified when the data
    /// was reported to CloudWatch. If you specify a unit, the operation returns only data
    /// that was collected with that unit specified. If you specify a unit that does not match
    /// the data collected, the results of the operation are null. CloudWatch does not perform
    /// unit conversions.
    /// </para>
    ///  
    /// <para>
    ///  <b>Using Metrics Insights queries with metric math</b> 
    /// </para>
    ///  
    /// <para>
    /// You can't mix a Metric Insights query and metric math syntax in the same expression,
    /// but you can reference results from a Metrics Insights query within other Metric math
    /// expressions. A Metrics Insights query without a <b>GROUP BY</b> clause returns a single
    /// time-series (TS), and can be used as input for a metric math expression that expects
    /// a single time series. A Metrics Insights query with a <b>GROUP BY</b> clause returns
    /// an array of time-series (TS[]), and can be used as input for a metric math expression
    /// that expects an array of time series. 
    /// </para>
    /// </summary>
    public partial class GetMetricDataRequest : AmazonCloudWatchRequest
    {
        private DateTime? _endTime;
        private LabelOptions _labelOptions;
        private int? _maxDatapoints;
        private List<MetricDataQuery> _metricDataQueries = AWSConfigs.InitializeCollections ? new List<MetricDataQuery>() : null;
        private string _nextToken;
        private ScanBy _scanBy;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
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
        /// For better performance, specify <c>StartTime</c> and <c>EndTime</c> values that align
        /// with the value of the metric's <c>Period</c> and sync up with the beginning and end
        /// of an hour. For example, if the <c>Period</c> of a metric is 5 minutes, specifying
        /// 12:05 or 12:30 as <c>EndTime</c> can get a faster response from CloudWatch than setting
        /// 12:07 or 12:29 as the <c>EndTime</c>.
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
        /// Gets and sets the property LabelOptions. 
        /// <para>
        /// This structure includes the <c>Timezone</c> parameter, which you can use to specify
        /// your time zone so that the labels of returned data display the correct time for your
        /// time zone. 
        /// </para>
        /// </summary>
        public LabelOptions LabelOptions
        {
            get { return this._labelOptions; }
            set { this._labelOptions = value; }
        }

        // Check to see if LabelOptions property is set
        internal bool IsSetLabelOptions()
        {
            return this._labelOptions != null;
        }

        /// <summary>
        /// Gets and sets the property MaxDatapoints. 
        /// <para>
        /// The maximum number of data points the request should return before paginating. If
        /// you omit this, the default of 100,800 is used.
        /// </para>
        /// </summary>
        public int? MaxDatapoints
        {
            get { return this._maxDatapoints; }
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
        /// The metric queries to be returned. A single <c>GetMetricData</c> call can include
        /// as many as 500 <c>MetricDataQuery</c> structures. Each of these structures can specify
        /// either a metric to retrieve, a Metrics Insights query, or a math expression to perform
        /// on retrieved data. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._metricDataQueries != null && (this._metricDataQueries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Include this value, if it was returned by the previous <c>GetMetricData</c> operation,
        /// to get the next set of data points.
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
        /// The order in which data points should be returned. <c>TimestampDescending</c> returns
        /// the newest data first and paginates when the <c>MaxDatapoints</c> limit is reached.
        /// <c>TimestampAscending</c> returns the oldest data first and paginates when the <c>MaxDatapoints</c>
        /// limit is reached.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the default of <c>TimestampDescending</c> is used.
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
        /// Gets and sets the property StartTime. 
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
        /// If you set <c>Period</c> to 5, 10, 20, or 30, the start time of your request is rounded
        /// down to the nearest time that corresponds to even 5-, 10-, 20-, or 30-second divisions
        /// of a minute. For example, if you make a query at (HH:mm:ss) 01:05:23 for the previous
        /// 10-second period, the start time of your request is rounded down and you receive data
        /// from 01:05:10 to 01:05:20. If you make a query at 15:07:17 for the previous 5 minutes
        /// of data, using a period of 5 seconds, you receive data timestamped between 15:02:15
        /// and 15:07:15. 
        /// </para>
        ///  
        /// <para>
        /// For better performance, specify <c>StartTime</c> and <c>EndTime</c> values that align
        /// with the value of the metric's <c>Period</c> and sync up with the beginning and end
        /// of an hour. For example, if the <c>Period</c> of a metric is 5 minutes, specifying
        /// 12:05 or 12:30 as <c>StartTime</c> can get a faster response from CloudWatch than
        /// setting 12:07 or 12:29 as the <c>StartTime</c>.
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

    }
}