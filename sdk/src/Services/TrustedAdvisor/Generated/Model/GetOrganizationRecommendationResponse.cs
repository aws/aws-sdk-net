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
    /// This is the response object from the GetOrganizationRecommendation operation.
    /// </summary>
    public partial class GetOrganizationRecommendationResponse : AmazonWebServiceResponse
    {
        private OrganizationRecommendation _organizationRecommendation;

        /// <summary>
        /// Gets and sets the property OrganizationRecommendation. 
        /// <para>
        /// The Recommendation
        /// </para>
        /// </summary>
        public OrganizationRecommendation OrganizationRecommendation
        {
            get { return this._organizationRecommendation; }
            set { this._organizationRecommendation = value; }
        }

        // Check to see if OrganizationRecommendation property is set
        internal bool IsSetOrganizationRecommendation()
        {
            return this._organizationRecommendation != null;
        }

    }
}