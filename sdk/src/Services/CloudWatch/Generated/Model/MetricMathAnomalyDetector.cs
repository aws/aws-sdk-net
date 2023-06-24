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
    /// Indicates the CloudWatch math expression that provides the time series the anomaly
    /// detector uses as input. The designated math expression must return a single time series.
    /// </summary>
    public partial class MetricMathAnomalyDetector
    {
        private List<MetricDataQuery> _metricDataQueries = new List<MetricDataQuery>();

        /// <summary>
        /// Gets and sets the property MetricDataQueries. 
        /// <para>
        /// An array of metric data query structures that enables you to create an anomaly detector
        /// based on the result of a metric math expression. Each item in <code>MetricDataQueries</code>
        /// gets a metric or performs a math expression. One item in <code>MetricDataQueries</code>
        /// is the expression that provides the time series that the anomaly detector uses as
        /// input. Designate the expression by setting <code>ReturnData</code> to <code>true</code>
        /// for this object in the array. For all other expressions and metrics, set <code>ReturnData</code>
        /// to <code>false</code>. The designated expression must return a single time series.
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

    }
}