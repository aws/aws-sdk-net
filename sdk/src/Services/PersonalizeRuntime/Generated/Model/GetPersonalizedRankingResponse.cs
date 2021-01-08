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
 * Do not modify this file. This file is generated from the personalize-runtime-2018-05-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PersonalizeRuntime.Model
{
    /// <summary>
    /// This is the response object from the GetPersonalizedRanking operation.
    /// </summary>
    public partial class GetPersonalizedRankingResponse : AmazonWebServiceResponse
    {
        private List<PredictedItem> _personalizedRanking = new List<PredictedItem>();
        private string _recommendationId;

        /// <summary>
        /// Gets and sets the property PersonalizedRanking. 
        /// <para>
        /// A list of items in order of most likely interest to the user. The maximum is 500.
        /// </para>
        /// </summary>
        public List<PredictedItem> PersonalizedRanking
        {
            get { return this._personalizedRanking; }
            set { this._personalizedRanking = value; }
        }

        // Check to see if PersonalizedRanking property is set
        internal bool IsSetPersonalizedRanking()
        {
            return this._personalizedRanking != null && this._personalizedRanking.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The ID of the recommendation.
        /// </para>
        /// </summary>
        public string RecommendationId
        {
            get { return this._recommendationId; }
            set { this._recommendationId = value; }
        }

        // Check to see if RecommendationId property is set
        internal bool IsSetRecommendationId()
        {
            return this._recommendationId != null;
        }

    }
}