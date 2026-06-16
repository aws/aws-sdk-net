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
    /// Specifies a metrics endpoint for a container, including the path where the container
    /// exposes Prometheus-formatted metrics and the frequency at which to publish them to
    /// Amazon CloudWatch.
    /// </summary>
    public partial class MetricsEndpoint
    {
        private int? _metricPublishFrequencyInSeconds;
        private string _metricsEndpointPath;

        /// <summary>
        /// Gets and sets the property MetricPublishFrequencyInSeconds. 
        /// <para>
        /// The interval, in seconds, at which container metrics scraped from the endpoint are
        /// published to Amazon CloudWatch. Valid values: <c>10</c>, <c>30</c>, <c>60</c>, <c>120</c>,
        /// <c>180</c>, <c>240</c>, <c>300</c>. Defaults to <c>60</c>.
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

        /// <summary>
        /// Gets and sets the property MetricsEndpointPath. 
        /// <para>
        /// The path to the metrics endpoint exposed by the container. For example, <c>/metrics</c>
        /// or <c>/server/metrics</c>. The path must start with <c>/</c> and can contain alphanumeric
        /// characters, forward slashes, underscores, hyphens, and periods. Maximum length is
        /// 256 characters. If not specified, defaults to <c>/metrics</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string MetricsEndpointPath
        {
            get { return this._metricsEndpointPath; }
            set { this._metricsEndpointPath = value; }
        }

        // Check to see if MetricsEndpointPath property is set
        internal bool IsSetMetricsEndpointPath()
        {
            return this._metricsEndpointPath != null;
        }

    }
}