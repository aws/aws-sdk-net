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

namespace Amazon.Wickr.Model
{
    /// <summary>
    /// This is the response object from the GetOidcInfo operation.
    /// </summary>
    public partial class GetOidcInfoResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property OpenidConnectInfo. 
        /// <para>
        /// The OpenID Connect configuration information for the network, including issuer, client
        /// ID, scopes, and other SSO settings.
        /// </para>
        /// </summary>
        public OidcConfigInfo OpenidConnectInfo { get; set; }

        /// <summary>
        /// Checks to see if the OpenidConnectInfo property is set.
        /// </summary>
        internal bool IsSetOpenidConnectInfo() => this.OpenidConnectInfo != null;

        /// <summary>
        /// Gets and sets the property TokenInfo. 
        /// <para>
        /// OAuth token information including access token, refresh token, and expiration details
        /// (only present if token parameters were provided in the request).
        /// </para>
        /// </summary>
        public OidcTokenInfo TokenInfo { get; set; }

        /// <summary>
        /// Checks to see if the TokenInfo property is set.
        /// </summary>
        internal bool IsSetTokenInfo() => this.TokenInfo != null;
    }
}
