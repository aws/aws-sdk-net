/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the response to a successful <a>ListOpenIDConnectProviders</a> request.
    /// </summary>
    public partial class ListOpenIDConnectProvidersResponse : AmazonWebServiceResponse
    {
        private List<OpenIDConnectProviderListEntry> _openIDConnectProviderList = new List<OpenIDConnectProviderListEntry>();

        /// <summary>
        /// Gets and sets the property OpenIDConnectProviderList. 
        /// <para>
        /// The list of IAM OpenID Connect providers in the AWS account.
        /// </para>
        /// </summary>
        public List<OpenIDConnectProviderListEntry> OpenIDConnectProviderList
        {
            get { return this._openIDConnectProviderList; }
            set { this._openIDConnectProviderList = value; }
        }

        // Check to see if OpenIDConnectProviderList property is set
        internal bool IsSetOpenIDConnectProviderList()
        {
            return this._openIDConnectProviderList != null && this._openIDConnectProviderList.Count > 0; 
        }

    }
}