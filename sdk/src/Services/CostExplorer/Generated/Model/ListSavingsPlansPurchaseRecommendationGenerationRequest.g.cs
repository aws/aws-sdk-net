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
    /// Container for the parameters to the ListSavingsPlansPurchaseRecommendationGeneration
    /// operation. Retrieves a list of your historical recommendation generations within the
    /// past 30 days.
    /// </summary>
    public partial class ListSavingsPlansPurchaseRecommendationGenerationRequest : AmazonCostExplorerRequest
    {
        /// <summary>
        /// Gets and sets the property GenerationStatus. 
        /// <para>
        /// The status of the recommendation generation.
        /// </para>
        /// </summary>
        public GenerationStatus GenerationStatus { get; set; }

        /// <summary>
        /// Checks to see if the GenerationStatus property is set.
        /// </summary>
        internal bool IsSetGenerationStatus() => this.GenerationStatus != null;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// Checks to see if the NextPageToken property is set.
        /// </summary>
        internal bool IsSetNextPageToken() => this.NextPageToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of recommendations that you want returned in a single response object.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 6000)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;

        /// <summary>
        /// Gets and sets the property RecommendationIds. 
        /// <para>
        /// The IDs for each specific recommendation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RecommendationIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendationIds property is set.
        /// </summary>
        internal bool IsSetRecommendationIds() => this.RecommendationIds != null && (this.RecommendationIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
