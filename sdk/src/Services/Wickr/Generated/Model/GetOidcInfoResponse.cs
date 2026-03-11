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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// This is the response object from the GetOidcInfo operation.
    /// </summary>
    public partial class GetOidcInfoResponse : AmazonWebServiceResponse
    {
        private OidcConfigInfo _openidConnectInfo;
        private OidcTokenInfo _tokenInfo;

        /// <summary>
        /// Gets and sets the property OpenidConnectInfo. 
        /// <para>
        /// The OpenID Connect configuration information for the network, including issuer, client
        /// ID, scopes, and other SSO settings.
        /// </para>
        /// </summary>
        public OidcConfigInfo OpenidConnectInfo
        {
            get { return this._openidConnectInfo; }
            set { this._openidConnectInfo = value; }
        }

        // Check to see if OpenidConnectInfo property is set
        internal bool IsSetOpenidConnectInfo()
        {
            return this._openidConnectInfo != null;
        }

        /// <summary>
        /// Gets and sets the property TokenInfo. 
        /// <para>
        /// OAuth token information including access token, refresh token, and expiration details
        /// (only present if token parameters were provided in the request).
        /// </para>
        /// </summary>
        public OidcTokenInfo TokenInfo
        {
            get { return this._tokenInfo; }
            set { this._tokenInfo = value; }
        }

        // Check to see if TokenInfo property is set
        internal bool IsSetTokenInfo()
        {
            return this._tokenInfo != null;
        }

    }
}