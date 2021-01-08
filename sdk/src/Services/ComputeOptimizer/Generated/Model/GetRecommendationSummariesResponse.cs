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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// This is the response object from the GetRecommendationSummaries operation.
    /// </summary>
    public partial class GetRecommendationSummariesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RecommendationSummary> _recommendationSummaries = new List<RecommendationSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to advance to the next page of recommendation summaries.
        /// </para>
        ///  
        /// <para>
        /// This value is null when there are no more pages of recommendation summaries to return.
        /// </para>
        /// </summary>
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
        /// An array of objects that summarize a recommendation.
        /// </para>
        /// </summary>
        public List<RecommendationSummary> RecommendationSummaries
        {
            get { return this._recommendationSummaries; }
            set { this._recommendationSummaries = value; }
        }

        // Check to see if RecommendationSummaries property is set
        internal bool IsSetRecommendationSummaries()
        {
            return this._recommendationSummaries != null && this._recommendationSummaries.Count > 0; 
        }

    }
}