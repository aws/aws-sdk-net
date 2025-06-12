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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.PersonalizeRuntime.Model
{
    /// <summary>
    /// This is the response object from the GetActionRecommendations operation.
    /// </summary>
    public partial class GetActionRecommendationsResponse : AmazonWebServiceResponse
    {
        private List<PredictedAction> _actionList = AWSConfigs.InitializeCollections ? new List<PredictedAction>() : null;
        private string _recommendationId;

        /// <summary>
        /// Gets and sets the property ActionList. 
        /// <para>
        /// A list of action recommendations sorted in descending order by prediction score. There
        /// can be a maximum of 100 actions in the list. For information about action scores,
        /// see <a href="https://docs.aws.amazon.com/personalize/latest/dg/how-action-recommendation-scoring-works.html">How
        /// action recommendation scoring works</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PredictedAction> ActionList
        {
            get { return this._actionList; }
            set { this._actionList = value; }
        }

        // Check to see if ActionList property is set
        internal bool IsSetActionList()
        {
            return this._actionList != null && (this._actionList.Count > 0 || !AWSConfigs.InitializeCollections); 
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