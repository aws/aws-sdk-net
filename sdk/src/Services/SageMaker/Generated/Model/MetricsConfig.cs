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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration for Utilization metrics.
    /// </summary>
    public partial class MetricsConfig
    {
        private bool? _enableEnhancedMetrics;
        private int? _metricPublishFrequencyInSeconds;

        /// <summary>
        /// Gets and sets the property EnableEnhancedMetrics. 
        /// <para>
        /// Specifies whether to enable enhanced metrics for the endpoint. Enhanced metrics provide
        /// utilization and invocation data at instance and container granularity. Container granularity
        /// is supported for Inference Components. The default is <c>False</c>.
        /// </para>
        /// </summary>
        public bool? EnableEnhancedMetrics
        {
            get { return this._enableEnhancedMetrics; }
            set { this._enableEnhancedMetrics = value; }
        }

        // Check to see if EnableEnhancedMetrics property is set
        internal bool IsSetEnableEnhancedMetrics()
        {
            return this._enableEnhancedMetrics.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricPublishFrequencyInSeconds. 
        /// <para>
        /// The interval, in seconds, at which metrics are published to Amazon CloudWatch. Defaults
        /// to <c>60</c>. Valid values: <c>10</c>, <c>30</c>, <c>60</c>, <c>120</c>, <c>180</c>,
        /// <c>240</c>, <c>300</c>. When <c>EnableEnhancedMetrics</c> is set to <c>False</c>,
        /// this interval applies to utilization metrics only; invocation metrics continue to
        /// be published at the default 60-second interval. When <c>EnableEnhancedMetrics</c>
        /// is set to <c>True</c>, this interval applies to both utilization and invocation metrics.
        /// </para>
        /// </summary>
        public int? MetricPublishFrequencyInSeconds
        {
            get { return this._metricPublishFrequencyInSeconds; }
            set { this._metricPublishFrequencyInSeconds = value; }
        }

        // Check to see if MetricPublishFrequencyInSeconds property is set
        internal bool IsSetMetricPublishFrequencyInSeconds()
        {
            return this._metricPublishFrequencyInSeconds.HasValue; 
        }

    }
}