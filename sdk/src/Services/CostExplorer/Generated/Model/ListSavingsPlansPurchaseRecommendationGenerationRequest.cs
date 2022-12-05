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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the ListSavingsPlansPurchaseRecommendationGeneration operation.
    /// Retrieves a list of your historical recommendation generations within the past 30
    /// days.
    /// </summary>
    public partial class ListSavingsPlansPurchaseRecommendationGenerationRequest : AmazonCostExplorerRequest
    {
        private GenerationStatus _generationStatus;
        private string _nextPageToken;
        private int? _pageSize;
        private List<string> _recommendationIds = new List<string>();

        /// <summary>
        /// Gets and sets the property GenerationStatus. 
        /// <para>
        /// The status of the recommendation generation.
        /// </para>
        /// </summary>
        public GenerationStatus GenerationStatus
        {
            get { return this._generationStatus; }
            set { this._generationStatus = value; }
        }

        // Check to see if GenerationStatus property is set
        internal bool IsSetGenerationStatus()
        {
            return this._generationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of recommendations that you want returned in a single response object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int PageSize
        {
            get { return this._pageSize.GetValueOrDefault(); }
            set { this._pageSize = value; }
        }

        // Check to see if PageSize property is set
        internal bool IsSetPageSize()
        {
            return this._pageSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationIds. 
        /// <para>
        /// The IDs for each specific recommendation.
        /// </para>
        /// </summary>
        public List<string> RecommendationIds
        {
            get { return this._recommendationIds; }
            set { this._recommendationIds = value; }
        }

        // Check to see if RecommendationIds property is set
        internal bool IsSetRecommendationIds()
        {
            return this._recommendationIds != null && this._recommendationIds.Count > 0; 
        }

    }
}