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

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetCostAndUsageComparisons operation.
    /// </summary>
    public partial class GetCostAndUsageComparisonsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CostAndUsageComparisons. 
        /// <para>
        /// An array of comparison results showing cost and usage metrics between <c>BaselineTimePeriod</c>
        /// and <c>ComparisonTimePeriod</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CostAndUsageComparison> CostAndUsageComparisons { get; set; } = AWSConfigs.InitializeCollections ? new List<CostAndUsageComparison>() : null;

        /// <summary>
        /// Checks to see if the CostAndUsageComparisons property is set.
        /// </summary>
        internal bool IsSetCostAndUsageComparisons() => this.CostAndUsageComparisons != null && (this.CostAndUsageComparisons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of paginated results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property TotalCostAndUsage. 
        /// <para>
        /// A summary of the total cost and usage, comparing amounts between <c>BaselineTimePeriod</c>
        /// and <c>ComparisonTimePeriod</c> and their differences. This total represents the aggregate
        /// total across all paginated results, if the response spans multiple pages.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ComparisonMetricValue> TotalCostAndUsage { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, ComparisonMetricValue>() : null;

        /// <summary>
        /// Checks to see if the TotalCostAndUsage property is set.
        /// </summary>
        internal bool IsSetTotalCostAndUsage() => this.TotalCostAndUsage != null && (this.TotalCostAndUsage.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
