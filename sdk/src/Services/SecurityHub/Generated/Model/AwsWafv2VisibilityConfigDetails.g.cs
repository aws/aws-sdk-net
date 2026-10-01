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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Defines and enables Amazon CloudWatch metrics and web request sample collection.
    /// </summary>
    public partial class AwsWafv2VisibilityConfigDetails
    {
        /// <summary>
        /// Gets and sets the property CloudWatchMetricsEnabled. 
        /// <para>
        ///  A boolean indicating whether the associated resource sends metrics to Amazon CloudWatch.
        /// For the list of available metrics, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/monitoring-cloudwatch.html#waf-metrics">WAF
        /// metrics and dimensions</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// </summary>
        public bool? CloudWatchMetricsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchMetricsEnabled property is set.
        /// </summary>
        internal bool IsSetCloudWatchMetricsEnabled() => this.CloudWatchMetricsEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        ///  A name of the Amazon CloudWatch metric. 
        /// </para>
        /// </summary>
        public string MetricName { get; set; }

        /// <summary>
        /// Checks to see if the MetricName property is set.
        /// </summary>
        internal bool IsSetMetricName() => this.MetricName != null;

        /// <summary>
        /// Gets and sets the property SampledRequestsEnabled. 
        /// <para>
        ///  A boolean indicating whether WAF should store a sampling of the web requests that
        /// match the rules. You can view the sampled requests through the WAF console. 
        /// </para>
        /// </summary>
        public bool? SampledRequestsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the SampledRequestsEnabled property is set.
        /// </summary>
        internal bool IsSetSampledRequestsEnabled() => this.SampledRequestsEnabled.HasValue;
    }
}
