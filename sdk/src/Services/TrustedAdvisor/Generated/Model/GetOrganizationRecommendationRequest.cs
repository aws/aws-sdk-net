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
    /// Container for the parameters to the GetOrganizationRecommendation operation.
    /// Get a specific recommendation within an AWS Organizations organization. This API supports
    /// only prioritized recommendations.
    /// </summary>
    public partial class GetOrganizationRecommendationRequest : AmazonTrustedAdvisorRequest
    {
        private string _organizationRecommendationIdentifier;

        /// <summary>
        /// Gets and sets the property OrganizationRecommendationIdentifier. 
        /// <para>
        /// The Recommendation identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=200)]
        public string OrganizationRecommendationIdentifier
        {
            get { return this._organizationRecommendationIdentifier; }
            set { this._organizationRecommendationIdentifier = value; }
        }

        // Check to see if OrganizationRecommendationIdentifier property is set
        internal bool IsSetOrganizationRecommendationIdentifier()
        {
            return this._organizationRecommendationIdentifier != null;
        }

    }
}