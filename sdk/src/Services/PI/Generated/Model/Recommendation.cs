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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// The list of recommendations for the insight.
    /// </summary>
    public partial class Recommendation
    {
        private string _recommendationDescription;
        private string _recommendationId;

        /// <summary>
        /// Gets and sets the property RecommendationDescription. 
        /// <para>
        /// The recommendation details to help resolve the performance issue. For example, <c>Investigate
        /// the following SQLs that contributed to 100% of the total DBLoad during that time period:
        /// sql-id</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=8000)]
        public string RecommendationDescription
        {
            get { return this._recommendationDescription; }
            set { this._recommendationDescription = value; }
        }

        // Check to see if RecommendationDescription property is set
        internal bool IsSetRecommendationDescription()
        {
            return this._recommendationDescription != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationId. 
        /// <para>
        /// The unique identifier for the recommendation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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