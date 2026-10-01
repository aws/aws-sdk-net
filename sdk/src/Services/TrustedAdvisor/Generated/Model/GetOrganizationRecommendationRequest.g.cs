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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the GetOrganizationRecommendation operation. Get a
    /// specific recommendation within an AWS Organizations organization. This API supports
    /// only prioritized recommendations and provides global priority recommendations, eliminating
    /// the need to call the API in each AWS Region.
    /// </summary>
    public partial class GetOrganizationRecommendationRequest : AmazonTrustedAdvisorRequest
    {
        /// <summary>
        /// Gets and sets the property OrganizationRecommendationIdentifier. 
        /// <para>
        /// The Recommendation identifier
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 200)]
        public string OrganizationRecommendationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationRecommendationIdentifier property is set.
        /// </summary>
        internal bool IsSetOrganizationRecommendationIdentifier() => this.OrganizationRecommendationIdentifier != null;
    }
}
