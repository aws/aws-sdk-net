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
 * Do not modify this file. This file is generated from the wisdom-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConnectWisdomService.Model
{
    /// <summary>
    /// This is the response object from the GetRecommendations operation.
    /// </summary>
    public partial class GetRecommendationsResponse : AmazonWebServiceResponse
    {
        private List<RecommendationData> _recommendations = new List<RecommendationData>();
        private List<RecommendationTrigger> _triggers = new List<RecommendationTrigger>();

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// The recommendations.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RecommendationData> Recommendations
        {
            get { return this._recommendations; }
            set { this._recommendations = value; }
        }

        // Check to see if Recommendations property is set
        internal bool IsSetRecommendations()
        {
            return this._recommendations != null && this._recommendations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Triggers. 
        /// <para>
        /// The triggers corresponding to recommendations.
        /// </para>
        /// </summary>
        public List<RecommendationTrigger> Triggers
        {
            get { return this._triggers; }
            set { this._triggers = value; }
        }

        // Check to see if Triggers property is set
        internal bool IsSetTriggers()
        {
            return this._triggers != null && this._triggers.Count > 0; 
        }

    }
}