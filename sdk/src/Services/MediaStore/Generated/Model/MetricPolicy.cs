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
 * Do not modify this file. This file is generated from the mediastore-2017-09-01.normal.json service model.
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
namespace Amazon.MediaStore.Model
{
    /// <summary>
    /// The metric policy that is associated with the container. A metric policy allows AWS
    /// Elemental MediaStore to send metrics to Amazon CloudWatch. In the policy, you must
    /// indicate whether you want MediaStore to send container-level metrics. You can also
    /// include rules to define groups of objects that you want MediaStore to send object-level
    /// metrics for.
    /// 
    ///  
    /// <para>
    /// To view examples of how to construct a metric policy for your use case, see <a href="https://docs.aws.amazon.com/mediastore/latest/ug/policies-metric-examples.html">Example
    /// Metric Policies</a>.
    /// </para>
    /// </summary>
    public partial class MetricPolicy
    {
        private ContainerLevelMetrics _containerLevelMetrics;
        private List<MetricPolicyRule> _metricPolicyRules = AWSConfigs.InitializeCollections ? new List<MetricPolicyRule>() : null;

        /// <summary>
        /// Gets and sets the property ContainerLevelMetrics. 
        /// <para>
        /// A setting to enable or disable metrics at the container level.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerLevelMetrics ContainerLevelMetrics
        {
            get { return this._containerLevelMetrics; }
            set { this._containerLevelMetrics = value; }
        }

        // Check to see if ContainerLevelMetrics property is set
        internal bool IsSetContainerLevelMetrics()
        {
            return this._containerLevelMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property MetricPolicyRules. 
        /// <para>
        /// A parameter that holds an array of rules that enable metrics at the object level.
        /// This parameter is optional, but if you choose to include it, you must also include
        /// at least one rule. By default, you can include up to five rules. You can also <a href="https://console.aws.amazon.com/servicequotas/home?region=us-east-1#!/services/mediastore/quotas">request
        /// a quota increase</a> to allow up to 300 rules per policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public List<MetricPolicyRule> MetricPolicyRules
        {
            get { return this._metricPolicyRules; }
            set { this._metricPolicyRules = value; }
        }

        // Check to see if MetricPolicyRules property is set
        internal bool IsSetMetricPolicyRules()
        {
            return this._metricPolicyRules != null && (this._metricPolicyRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}