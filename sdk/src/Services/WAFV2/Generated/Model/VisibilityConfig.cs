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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Defines and enables Amazon CloudWatch metrics and web request sample collection.
    /// </summary>
    public partial class VisibilityConfig
    {
        private bool? _cloudWatchMetricsEnabled;
        private string _metricName;
        private bool? _sampledRequestsEnabled;

        /// <summary>
        /// Gets and sets the property CloudWatchMetricsEnabled. 
        /// <para>
        /// A boolean indicating whether the associated resource sends metrics to Amazon CloudWatch.
        /// For the list of available metrics, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/monitoring-cloudwatch.html#waf-metrics">WAF
        /// Metrics</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool CloudWatchMetricsEnabled
        {
            get { return this._cloudWatchMetricsEnabled.GetValueOrDefault(); }
            set { this._cloudWatchMetricsEnabled = value; }
        }

        // Check to see if CloudWatchMetricsEnabled property is set
        internal bool IsSetCloudWatchMetricsEnabled()
        {
            return this._cloudWatchMetricsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// A name of the Amazon CloudWatch metric dimension. The name can contain only the characters:
        /// A-Z, a-z, 0-9, - (hyphen), and _ (underscore). The name can be from one to 128 characters
        /// long. It can't contain whitespace or metric names that are reserved for WAF, for example
        /// <code>All</code> and <code>Default_Action</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property SampledRequestsEnabled. 
        /// <para>
        /// A boolean indicating whether WAF should store a sampling of the web requests that
        /// match the rules. You can view the sampled requests through the WAF console. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool SampledRequestsEnabled
        {
            get { return this._sampledRequestsEnabled.GetValueOrDefault(); }
            set { this._sampledRequestsEnabled = value; }
        }

        // Check to see if SampledRequestsEnabled property is set
        internal bool IsSetSampledRequestsEnabled()
        {
            return this._sampledRequestsEnabled.HasValue; 
        }

    }
}