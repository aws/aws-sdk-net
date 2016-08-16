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
    ///  The maximum number of data points that can be queried is 50,850, whereas the maximum
    /// number of data points returned from a single <code>GetMetricStatistics</code> request
    /// is 1,440. If you make a request that generates more than 1,440 data points, Amazon
    /// CloudWatch returns an error. In such a case, you can alter the request by narrowing
    /// the specified time range or increasing the specified period. A period can be as short
    /// as one minute (60 seconds) or as long as one day (86,400 seconds). Alternatively,
    /// you can make multiple requests across adjacent time ranges. <code>GetMetricStatistics</code>
    /// does not return the data in chronological order. 
    /// </para>
    ///  
    /// <para>
    ///  Amazon CloudWatch aggregates data points based on the length of the <code>period</code>
    /// that you specify. For example, if you request statistics with a one-minute granularity,
    /// Amazon CloudWatch aggregates data points with time stamps that fall within the same
    /// one-minute period. In such a case, the data points queried can greatly outnumber the
    /// data points returned. 
    /// </para>
    ///  
    /// <para>
    ///  The following examples show various statistics allowed by the data point query maximum
    /// of 50,850 when you call <code>GetMetricStatistics</code> on Amazon EC2 instances with
    /// detailed (one-minute) monitoring enabled: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Statistics for up to 400 instances for a span of one hour
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Statistics for up to 35 instances over a span of 24 hours
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Statistics for up to 2 instances over a span of 2 weeks
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  For information about the namespace, metric names, and dimensions that other Amazon
    /// Web Services products use to send metrics to CloudWatch, go to <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/CW_Support_For_AWS.html">Amazon
    /// CloudWatch Metrics, Namespaces, and Dimensions Reference</a> in the <i>Amazon CloudWatch
    /// Developer Guide</i>. 
    /// </para>
    /// </summary>
    public partial class GetMetricStatisticsRequest : AmazonCloudWatchRequest
    {
        private List<Dimension> _dimensions = new List<Dimension>();
        private DateTime? _endTime;
        private string _metricName;
        private string _awsNamespace;
        private int? _period;
        private DateTime? _startTime;
        private List<string> _statistics = new List<string>();
        private StandardUnit _unit;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// A list of dimensions describing qualities of the metric.
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
        /// The time stamp to use for determining the last datapoint to return. The value specified
        /// is exclusive; results will include datapoints up to the time stamp specified. The
        /// time stamp must be in ISO 8601 UTC format (e.g., 2014-09-03T23:00:00Z).
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
        ///  The granularity, in seconds, of the returned datapoints. A <code>Period</code> can
        /// be as short as one minute (60 seconds) or as long as one day (86,400 seconds), and
        /// must be a multiple of 60. The default value is 60. 
        /// </para>
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
        /// The time stamp to use for determining the first datapoint to return. The value specified
        /// is inclusive; results include datapoints with the time stamp specified. The time stamp
        /// must be in ISO 8601 UTC format (e.g., 2014-09-03T23:00:00Z).
        /// </para>
        ///  <note> 
        /// <para>
        /// The specified start time is rounded down to the nearest value. Datapoints are returned
        /// for start times up to two weeks in the past. Specified start times that are more than
        /// two weeks in the past will not return datapoints for metrics that are older than two
        /// weeks.
        /// </para>
        ///  
        /// <para>
        /// Data that is timestamped 24 hours or more in the past may take in excess of 48 hours
        /// to become available from submission time using <code>GetMetricStatistics</code>.
        /// </para>
        ///  </note>
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
        ///  The metric statistics to return. For information about specific statistics returned
        /// by GetMetricStatistics, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/cloudwatch_concepts.html#Statistic">Statistics</a>
        /// in the <i>Amazon CloudWatch Developer Guide</i>. 
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
        /// The specific unit for a given metric. Metrics may be reported in multiple units. Not
        /// supplying a unit results in all units being returned. If the metric only ever reports
        /// one unit, specifying a unit will have no effect.
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