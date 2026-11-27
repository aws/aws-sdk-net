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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the StartOTelEnrichment operation. Enables enrichment
    /// and PromQL access for CloudWatch vended metrics for <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/UsingResourceTagsForTelemetry.html">supported
    /// Amazon Web Services resources</a> in the account. Once enabled, metrics that contain
    /// a resource identifier dimension (for example, EC2 <c>CPUUtilization</c> with an <c>InstanceId</c>
    /// dimension) are enriched with resource ARN labels and, optionally, resource tag labels,
    /// and become queryable using PromQL. <para> To include resource tag labels, you must
    /// also enable resource tags on telemetry for the account. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/EnableResourceTagsOnTelemetry.html">Enable
    /// resource tags on telemetry</a>. If <c>EnableTagEnrichment</c> is <c>false</c>, enrichment
    /// reads no resource tags, so it does not require resource tags on telemetry. </para>
    /// <para> Optionally, <c>IncludeFilters</c> and <c>ExcludeFilters</c> limit enrichment
    /// to a subset of the account's metrics, and <c>EnableTagEnrichment</c> controls whether
    /// enriched metrics include resource tag labels. These settings are stored only when
    /// this operation starts enrichment. Calling <c>StartOTelEnrichment</c> for an account
    /// where enrichment is already running has no effect and does not modify the filters
    /// or the tag enrichment setting that are applied. To change them, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_UpdateOTelEnrichment.html">UpdateOTelEnrichment</a>.
    /// </para>
    /// </summary>
    public partial class StartOTelEnrichmentRequest : AmazonCloudWatchRequest
    {
        /// <summary>
        /// Gets and sets the property EnableTagEnrichment. 
        /// <para>
        /// Specifies whether enriched metrics include resource tag labels. If <c>true</c>, enriched
        /// metrics include resource tag labels. If <c>false</c>, they include resource ARN labels
        /// but no resource tag labels. If you omit this parameter, the default is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// When <c>EnableTagEnrichment</c> is <c>true</c>, enriched metrics that carry resource
        /// tag labels are charged at the OTel enrichment rate. For more information, see <a href="https://aws.amazon.com/cloudwatch/pricing/">Amazon
        /// CloudWatch Pricing</a>.
        /// </para>
        /// </summary>
        public bool? EnableTagEnrichment { get; set; }

        /// <summary>
        /// Checks to see if the EnableTagEnrichment property is set.
        /// </summary>
        internal bool IsSetEnableTagEnrichment() => this.EnableTagEnrichment.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<OTelEnrichmentMetricSelector> ExcludeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<OTelEnrichmentMetricSelector>() : null;

        /// <summary>
        /// Checks to see if the ExcludeFilters property is set.
        /// </summary>
        internal bool IsSetExcludeFilters() => this.ExcludeFilters != null && (this.ExcludeFilters.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<OTelEnrichmentMetricSelector> IncludeFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<OTelEnrichmentMetricSelector>() : null;

        /// <summary>
        /// Checks to see if the IncludeFilters property is set.
        /// </summary>
        internal bool IsSetIncludeFilters() => this.IncludeFilters != null && (this.IncludeFilters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
