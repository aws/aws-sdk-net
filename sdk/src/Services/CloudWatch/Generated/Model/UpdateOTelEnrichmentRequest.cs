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
    /// Container for the parameters to the UpdateOTelEnrichment operation.
    /// Replaces the filters that determine which CloudWatch vended metrics are enriched with
    /// resource ARN and resource tag labels for the account. Enrichment must already be running
    /// for the account. If it is not, this operation returns a <c>ResourceNotFoundException</c>.
    /// To start enrichment, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_StartOTelEnrichment.html">StartOTelEnrichment</a>.
    /// 
    ///  
    /// <para>
    /// The filters in the request completely replace the stored filters; they are not merged
    /// with them. <c>IncludeFilters</c> and <c>ExcludeFilters</c> are replaced as a pair,
    /// so a request that specifies only <c>IncludeFilters</c> also clears the stored <c>ExcludeFilters</c>,
    /// and a request that specifies neither clears both.
    /// </para>
    /// </summary>
    public partial class UpdateOTelEnrichmentRequest : AmazonCloudWatchRequest
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