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
    /// Container for the parameters to the PutMetricData operation.
    /// Publishes metric data points to Amazon CloudWatch. CloudWatch associates the data
    /// points with the specified metric. If the specified metric does not exist, CloudWatch
    /// creates the metric. When CloudWatch creates a metric, it can take up to fifteen minutes
    /// for the metric to appear in calls to <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_ListMetrics.html">ListMetrics</a>.
    /// 
    ///  
    /// <para>
    /// You can publish either individual data points in the <code>Value</code> field, or
    /// arrays of values and the number of times each value occurred during the period by
    /// using the <code>Values</code> and <code>Counts</code> fields in the <code>MetricDatum</code>
    /// structure. Using the <code>Values</code> and <code>Counts</code> method enables you
    /// to publish up to 150 values per metric with one <code>PutMetricData</code> request,
    /// and supports retrieving percentile statistics on this data.
    /// </para>
    ///  
    /// <para>
    /// Each <code>PutMetricData</code> request is limited to 1 MB in size for HTTP POST requests.
    /// You can send a payload compressed by gzip. Each request is also limited to no more
    /// than 1000 different metrics.
    /// </para>
    ///  
    /// <para>
    /// Although the <code>Value</code> parameter accepts numbers of type <code>Double</code>,
    /// CloudWatch rejects values that are either too small or too large. Values must be in
    /// the range of -2^360 to 2^360. In addition, special values (for example, NaN, +Infinity,
    /// -Infinity) are not supported.
    /// </para>
    ///  
    /// <para>
    /// You can use up to 30 dimensions per metric to further clarify what data the metric
    /// collects. Each dimension consists of a Name and Value pair. For more information about
    /// specifying dimensions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html">Publishing
    /// Metrics</a> in the <i>Amazon CloudWatch User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You specify the time stamp to be associated with each data point. You can specify
    /// time stamps that are as much as two weeks before the current date, and as much as
    /// 2 hours after the current day and time.
    /// </para>
    ///  
    /// <para>
    /// Data points with time stamps from 24 hours ago or longer can take at least 48 hours
    /// to become available for <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>
    /// from the time they are submitted. Data points with time stamps between 3 and 24 hours
    /// ago can take as much as 2 hours to become available for for <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
    /// </para>
    ///  
    /// <para>
    /// CloudWatch needs raw data points to calculate percentile statistics. If you publish
    /// data using a statistic set instead, you can only retrieve percentile statistics for
    /// this data if one of the following conditions is true:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <code>SampleCount</code> value of the statistic set is 1 and <code>Min</code>,
    /// <code>Max</code>, and <code>Sum</code> are all equal.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>Min</code> and <code>Max</code> are equal, and <code>Sum</code> is equal
    /// to <code>Min</code> multiplied by <code>SampleCount</code>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutMetricDataRequest : AmazonCloudWatchRequest
    {
        private List<MetricDatum> _metricData = new List<MetricDatum>();
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property MetricData. 
        /// <para>
        /// The data for the metric. The array can include no more than 1000 metrics per call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MetricDatum> MetricData
        {
            get { return this._metricData; }
            set { this._metricData = value; }
        }

        // Check to see if MetricData property is set
        internal bool IsSetMetricData()
        {
            return this._metricData != null && this._metricData.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace for the metric data. You can use ASCII characters for the namespace,
        /// except for control characters which are not supported.
        /// </para>
        ///  
        /// <para>
        /// To avoid conflicts with Amazon Web Services service namespaces, you should not specify
        /// a namespace that begins with <code>AWS/</code> 
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

    }
}