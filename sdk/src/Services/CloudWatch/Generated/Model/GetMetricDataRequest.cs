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
    /// Container for the parameters to the GetMetricData operation.
    /// You can use the <code>GetMetricData</code> API to retrieve as many as 100 different
    /// metrics in a single request, with a total of as many as 100,800 datapoints. You can
    /// also optionally perform math expressions on the values of the returned statistics,
    /// to create new time series that represent new insights into your data. For example,
    /// using Lambda metrics, you could divide the Errors metric by the Invocations metric
    /// to get an error rate time series. For more information about metric math expressions,
    /// see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/using-metric-math.html#metric-math-syntax">Metric
    /// Math Syntax and Functions</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// 
    ///  
    /// <para>
    /// Calls to the <code>GetMetricData</code> API have a different pricing structure than
    /// calls to <code>GetMetricStatistics</code>. For more information about pricing, see
    /// <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon CloudWatch Pricing</a>.
    /// </para>
    /// </summary>
    public partial class GetMetricDataRequest : AmazonCloudWatchRequest
    {
        private DateTime? _endTime;
        private int? _maxDatapoints;
        private List<MetricDataQuery> _metricDataQueries = new List<MetricDataQuery>();
        private string _nextToken;
        private ScanBy _scanBy;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time stamp indicating the latest data to be returned.
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
        /// as many as 100 <code>MetricDataQuery</code> structures. Each of these structures can
        /// specify either a metric to retrieve, or a math expression to perform on retrieved
        /// data. 
        /// </para>
        /// </summary>
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
        /// Include this value, if it was returned by the previous call, to get the next set of
        /// data points.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time stamp indicating the earliest data to be returned.
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

    }
}