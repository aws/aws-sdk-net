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
        private bool? _enableDetailedObservability;
        private bool? _enableEnhancedMetrics;
        private int? _metricPublishFrequencyInSeconds;

        /// <summary>
        /// Gets and sets the property EnableDetailedObservability. 
        /// <para>
        /// Indicates whether detailed observability is enabled for the endpoint. When set to
        /// <c>True</c>, the following metrics are published at the configured frequency:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Container-level inference metrics scraped from the container's Prometheus endpoint
        /// (such as request latency, error counts, and throughput). Available metrics vary by
        /// framework.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Per-GPU metrics (utilization, memory, and temperature) attributed to individual inference
        /// components.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Per-instance host metrics (CPU, memory, and disk utilization).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Inference component placement metrics (copy count per Availability Zone).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For first-party and Deep Learning Containers (DLC), the Prometheus endpoint path is
        /// determined automatically. For Bring-Your-Own-Container (BYOC) cases, you can optionally
        /// set <c>ContainerMetricsConfig</c> to specify a custom endpoint path. If not specified,
        /// the default path <c>/metrics</c> on port <c>8080</c> is used.
        /// </para>
        ///  
        /// <para>
        /// When set to <c>False</c>, these additional metrics are not published. Standard invocation
        /// and utilization metrics controlled by <c>EnableEnhancedMetrics</c> are unaffected.
        /// </para>
        ///  
        /// <para>
        /// The default value for new endpoint configurations is <c>True</c>. For existing endpoint
        /// configurations created before this feature, the value is <c>False</c> unless explicitly
        /// set.
        /// </para>
        /// </summary>
        public bool? EnableDetailedObservability
        {
            get { return this._enableDetailedObservability; }
            set { this._enableDetailedObservability = value; }
        }

        // Check to see if EnableDetailedObservability property is set
        internal bool IsSetEnableDetailedObservability()
        {
            return this._enableDetailedObservability.HasValue; 
        }

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
        /// <c>240</c>, <c>300</c>.
        /// </para>
        ///  
        /// <para>
        /// When <c>EnableEnhancedMetrics</c> is set to <c>False</c>, this interval applies to
        /// utilization metrics only. Invocation metrics continue to be published at the default
        /// 60-second interval. When <c>EnableEnhancedMetrics</c> is set to <c>True</c>, this
        /// interval applies to both utilization and invocation metrics.
        /// </para>
        ///  
        /// <para>
        /// When <c>EnableDetailedObservability</c> is set to <c>True</c>, this interval applies
        /// to per-GPU metrics, per-instance host metrics, container metrics, and fleet-level
        /// inference component lifecycle and placement metrics.
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