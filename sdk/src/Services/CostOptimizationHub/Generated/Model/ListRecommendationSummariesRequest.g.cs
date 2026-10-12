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

namespace Amazon.CostOptimizationHub.Model
{
    /// <summary>
    /// Container for the parameters to the ListRecommendationSummaries operation. Returns
    /// a concise representation of savings estimates for resources. Also returns de-duped
    /// savings across different types of recommendations. <note> <para> The following filters
    /// are not supported for this API: <c>recommendationIds</c>, <c>resourceArns</c>, and
    /// <c>resourceIds</c>. </para> </note>
    /// </summary>
    public partial class ListRecommendationSummariesRequest : AmazonCostOptimizationHubRequest
    {
        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public Filter Filter { get; set; }

        /// <summary>
        /// Checks to see if the Filter property is set.
        /// </summary>
        internal bool IsSetFilter() => this.Filter != null;

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The grouping of recommendations by a dimension.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string GroupBy { get; set; }

        /// <summary>
        /// Checks to see if the GroupBy property is set.
        /// </summary>
        internal bool IsSetGroupBy() => this.GroupBy != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of recommendations to be returned for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Metrics. 
        /// <para>
        /// Additional metrics to be returned for the request. The only valid value is <c>savingsPercentage</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> Metrics { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Metrics property is set.
        /// </summary>
        internal bool IsSetMetrics() => this.Metrics != null && (this.Metrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to retrieve the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
