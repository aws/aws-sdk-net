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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the response to a successful <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListOpenIDConnectProviders.html">ListOpenIDConnectProviders</a>
    /// request.
    /// </summary>
    public partial class ListOpenIDConnectProvidersResponse : AmazonWebServiceResponse
    {
        private List<OpenIDConnectProviderListEntry> _openIDConnectProviderList = AWSConfigs.InitializeCollections ? new List<OpenIDConnectProviderListEntry>() : null;

        /// <summary>
        /// Gets and sets the property OpenIDConnectProviderList. 
        /// <para>
        /// The list of IAM OIDC provider resource objects defined in the Amazon Web Services
        /// account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OpenIDConnectProviderListEntry> OpenIDConnectProviderList
        {
            get { return this._openIDConnectProviderList; }
            set { this._openIDConnectProviderList = value; }
        }

        // Check to see if OpenIDConnectProviderList property is set
        internal bool IsSetOpenIDConnectProviderList()
        {
            return this._openIDConnectProviderList != null && (this._openIDConnectProviderList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}