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
        /// utilization data at instance and container granularity. Container granularity is supported
        /// for Inference Components. The default is <c>False</c>.
        /// </para>
        /// </summary>
        public bool EnableEnhancedMetrics
        {
            get { return this._enableEnhancedMetrics.GetValueOrDefault(); }
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
        /// The frequency, in seconds, at which utilization metrics are published to Amazon CloudWatch.
        /// The default is <c>60</c> seconds.
        /// </para>
        /// </summary>
        public int MetricPublishFrequencyInSeconds
        {
            get { return this._metricPublishFrequencyInSeconds.GetValueOrDefault(); }
            set { this._metricPublishFrequencyInSeconds = value; }
        }

        // Check to see if MetricPublishFrequencyInSeconds property is set
        internal bool IsSetMetricPublishFrequencyInSeconds()
        {
            return this._metricPublishFrequencyInSeconds.HasValue; 
        }

    }
}