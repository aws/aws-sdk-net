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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the ListRecommendationTemplates operation.
    /// </summary>
    public partial class ListRecommendationTemplatesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RecommendationTemplate> _recommendationTemplates = new List<RecommendationTemplate>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results, or null if there are no more results.
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
        /// Gets and sets the property RecommendationTemplates. 
        /// <para>
        /// The recommendation templates for the Resilience Hub applications.
        /// </para>
        /// </summary>
        public List<RecommendationTemplate> RecommendationTemplates
        {
            get { return this._recommendationTemplates; }
            set { this._recommendationTemplates = value; }
        }

        // Check to see if RecommendationTemplates property is set
        internal bool IsSetRecommendationTemplates()
        {
            return this._recommendationTemplates != null && this._recommendationTemplates.Count > 0; 
        }

    }
}