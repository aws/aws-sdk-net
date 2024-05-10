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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
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
namespace Amazon.LicenseManagerUserSubscriptions.Model
{
    /// <summary>
    /// This is the response object from the ListIdentityProviders operation.
    /// </summary>
    public partial class ListIdentityProvidersResponse : AmazonWebServiceResponse
    {
        private List<IdentityProviderSummary> _identityProviderSummaries = AWSConfigs.InitializeCollections ? new List<IdentityProviderSummary>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IdentityProviderSummaries. 
        /// <para>
        /// Metadata that describes the list identity providers operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<IdentityProviderSummary> IdentityProviderSummaries
        {
            get { return this._identityProviderSummaries; }
            set { this._identityProviderSummaries = value; }
        }

        // Check to see if IdentityProviderSummaries property is set
        internal bool IsSetIdentityProviderSummaries()
        {
            return this._identityProviderSummaries != null && (this._identityProviderSummaries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for the next set of results.
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

    }
}