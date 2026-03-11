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
    /// Container for the parameters to the GetRecommendation operation.
    /// Get a specific Recommendation. This API provides global recommendations, eliminating
    /// the need to call the API in each AWS Region.
    /// </summary>
    public partial class GetRecommendationRequest : AmazonTrustedAdvisorRequest
    {
        private RecommendationLanguage _language;
        private string _recommendationIdentifier;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The ISO 639-1 code for the language that you want your recommendations to appear in.
        /// </para>
        /// </summary>
        public RecommendationLanguage Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendationIdentifier. 
        /// <para>
        /// The Recommendation identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=200)]
        public string RecommendationIdentifier
        {
            get { return this._recommendationIdentifier; }
            set { this._recommendationIdentifier = value; }
        }

        // Check to see if RecommendationIdentifier property is set
        internal bool IsSetRecommendationIdentifier()
        {
            return this._recommendationIdentifier != null;
        }

    }
}