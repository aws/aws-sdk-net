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
    /// Container for the parameters to the PutMetricData operation.
    /// Publishes metric data points to Amazon CloudWatch. Amazon CloudWatch associates the
    /// data points with the specified metric. If the specified metric does not exist, Amazon
    /// CloudWatch creates the metric. When Amazon CloudWatch creates a metric, it can take
    /// up to fifteen minutes for the metric to appear in calls to <a>ListMetrics</a>. 
    /// 
    ///  
    /// <para>
    ///  Each <code>PutMetricData</code> request is limited to 8 KB in size for HTTP GET requests
    /// and is limited to 40 KB in size for HTTP POST requests. 
    /// </para>
    ///  <important> 
    /// <para>
    /// Although the <code>Value</code> parameter accepts numbers of type <code>Double</code>,
    /// Amazon CloudWatch rejects values that are either too small or too large. Values must
    /// be in the range of 8.515920e-109 to 1.174271e+108 (Base 10) or 2e-360 to 2e360 (Base
    /// 2). In addition, special values (e.g., NaN, +Infinity, -Infinity) are not supported.
    /// </para>
    ///  </important> 
    /// <para>
    /// Data that is timestamped 24 hours or more in the past may take in excess of 48 hours
    /// to become available from submission time using <code>GetMetricStatistics</code>.
    /// </para>
    /// </summary>
    public partial class PutMetricDataRequest : AmazonCloudWatchRequest
    {
        private List<MetricDatum> _metricData = new List<MetricDatum>();
        private string _awsNamespace;

        /// <summary>
        /// Gets and sets the property MetricData. 
        /// <para>
        /// A list of data describing the metric.
        /// </para>
        /// </summary>
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
        /// The namespace for the metric data.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot specify a namespace that begins with "AWS/". Namespaces that begin with
        /// "AWS/" are reserved for other Amazon Web Services products that send metrics to Amazon
        /// CloudWatch.
        /// </para>
        ///  </note>
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

    }
}