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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the StartOTelEnrichment operation.
    /// Enables enrichment and PromQL access for CloudWatch vended metrics for <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/UsingResourceTagsForTelemetry.html">supported
    /// Amazon Web Services resources</a> in the account. Once enabled, metrics that contain
    /// a resource identifier dimension (for example, EC2 <c>CPUUtilization</c> with an <c>InstanceId</c>
    /// dimension) are enriched with resource ARN and resource tag labels and become queryable
    /// using PromQL.
    /// 
    ///  
    /// <para>
    /// Before calling this operation, you must enable resource tags on telemetry for your
    /// account. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/EnableResourceTagsOnTelemetry.html">Enable
    /// resource tags on telemetry</a>.
    /// </para>
    ///  
    /// <para>
    /// Optionally, <c>IncludeFilters</c> and <c>ExcludeFilters</c> limit enrichment to a
    /// subset of the account's metrics. These filters are stored only when this operation
    /// starts enrichment. Calling <c>StartOTelEnrichment</c> for an account where enrichment
    /// is already running has no effect and does not modify the filters that are applied.
    /// To change them, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_UpdateOTelEnrichment.html">UpdateOTelEnrichment</a>.
    /// </para>
    /// </summary>
    public partial class StartOTelEnrichmentRequest : AmazonCloudWatchRequest
    {
        private List<OTelEnrichmentMetricSelector> _excludeFilters = AWSConfigs.InitializeCollections ? new List<OTelEnrichmentMetricSelector>() : null;
        private List<OTelEnrichmentMetricSelector> _includeFilters = AWSConfigs.InitializeCollections ? new List<OTelEnrichmentMetricSelector>() : null;

        /// <summary>
        /// Gets and sets the property ExcludeFilters. 
        /// <para>
        /// The metric namespaces, and the metric names, to leave unenriched. If this parameter
        /// is omitted, nothing is excluded.
        /// </para>
        ///  
        /// <para>
        /// Amazon CloudWatch applies <c>ExcludeFilters</c> after <c>IncludeFilters</c>, so a
        /// metric that both parameters match is not enriched.
        /// </para>
        ///  
        /// <para>
        /// A maximum of 100 filters is allowed across <c>IncludeFilters</c> and <c>ExcludeFilters</c>
        /// combined.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<OTelEnrichmentMetricSelector> ExcludeFilters
        {
            get { return this._excludeFilters; }
            set { this._excludeFilters = value; }
        }

        // Check to see if ExcludeFilters property is set
        internal bool IsSetExcludeFilters()
        {
            return this._excludeFilters != null && (this._excludeFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludeFilters. 
        /// <para>
        /// The metric namespaces, and the metric names, to enrich. If this parameter is omitted,
        /// every namespace that Amazon CloudWatch supports for enrichment is in scope.
        /// </para>
        ///  
        /// <para>
        /// A maximum of 100 filters is allowed across <c>IncludeFilters</c> and <c>ExcludeFilters</c>
        /// combined.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<OTelEnrichmentMetricSelector> IncludeFilters
        {
            get { return this._includeFilters; }
            set { this._includeFilters = value; }
        }

        // Check to see if IncludeFilters property is set
        internal bool IsSetIncludeFilters()
        {
            return this._includeFilters != null && (this._includeFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}