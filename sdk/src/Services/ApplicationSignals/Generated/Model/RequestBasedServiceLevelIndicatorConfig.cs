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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This structure specifies the information about the service and the performance metric
    /// that a request-based SLO is to monitor.
    /// </summary>
    public partial class RequestBasedServiceLevelIndicatorConfig
    {
        private ServiceLevelIndicatorComparisonOperator _comparisonOperator;
        private double? _metricThreshold;
        private RequestBasedServiceLevelIndicatorMetricConfig _requestBasedSliMetricConfig;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The arithmetic operation to use when comparing the specified metric to the threshold.
        /// This parameter is required if this SLO is tracking the <c>Latency</c> metric.
        /// </para>
        /// </summary>
        public ServiceLevelIndicatorComparisonOperator ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property MetricThreshold. 
        /// <para>
        /// The value that the SLI metric is compared to. This parameter is required if this SLO
        /// is tracking the <c>Latency</c> metric.
        /// </para>
        /// </summary>
        public double? MetricThreshold
        {
            get { return this._metricThreshold; }
            set { this._metricThreshold = value; }
        }

        // Check to see if MetricThreshold property is set
        internal bool IsSetMetricThreshold()
        {
            return this._metricThreshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RequestBasedSliMetricConfig. 
        /// <para>
        /// Use this structure to specify the metric to be used for the SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RequestBasedServiceLevelIndicatorMetricConfig RequestBasedSliMetricConfig
        {
            get { return this._requestBasedSliMetricConfig; }
            set { this._requestBasedSliMetricConfig = value; }
        }

        // Check to see if RequestBasedSliMetricConfig property is set
        internal bool IsSetRequestBasedSliMetricConfig()
        {
            return this._requestBasedSliMetricConfig != null;
        }

    }
}