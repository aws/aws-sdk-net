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
    /// This structure contains information about the performance metric that a request-based
    /// SLO monitors.
    /// </summary>
    public partial class RequestBasedServiceLevelIndicator
    {
        private ServiceLevelIndicatorComparisonOperator _comparisonOperator;
        private double? _metricThreshold;
        private RequestBasedServiceLevelIndicatorMetric _requestBasedSliMetric;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The arithmetic operation used when comparing the specified metric to the threshold.
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
        /// This value is the threshold that the observed metric values of the SLI metric are
        /// compared to.
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
        /// Gets and sets the property RequestBasedSliMetric. 
        /// <para>
        /// A structure that contains information about the metric that the SLO monitors. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RequestBasedServiceLevelIndicatorMetric RequestBasedSliMetric
        {
            get { return this._requestBasedSliMetric; }
            set { this._requestBasedSliMetric = value; }
        }

        // Check to see if RequestBasedSliMetric property is set
        internal bool IsSetRequestBasedSliMetric()
        {
            return this._requestBasedSliMetric != null;
        }

    }
}