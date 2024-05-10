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
 * Do not modify this file. This file is generated from the trustedadvisor-2022-09-15.normal.json service model.
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
namespace Amazon.TrustedAdvisor.Model
{
    /// <summary>
    /// This is the response object from the ListRecommendations operation.
    /// </summary>
    public partial class ListRecommendationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RecommendationSummary> _recommendationSummaries = AWSConfigs.InitializeCollections ? new List<RecommendationSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results. Use the value returned in the previous response
        /// in the next request to retrieve the next set of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=10000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationSummaries. 
        /// <para>
        /// The list of Recommendations
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RecommendationSummary> RecommendationSummaries
        {
            get { return this._recommendationSummaries; }
            set { this._recommendationSummaries = value; }
        }

        // Check to see if RecommendationSummaries property is set
        internal bool IsSetRecommendationSummaries()
        {
            return this._recommendationSummaries != null && (this._recommendationSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}