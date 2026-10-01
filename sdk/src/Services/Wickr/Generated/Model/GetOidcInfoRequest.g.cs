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
    /// Container for the parameters to the GetOidcInfo operation. Retrieves the OpenID Connect
    /// (OIDC) configuration for a Wickr network, including SSO settings and optional token
    /// information if access token parameters are provided.
    /// </summary>
    public partial class GetOidcInfoRequest : AmazonWickrRequest
    {
        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The CA certificate for secure communication with the OIDC provider (optional).
        /// </para>
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OAuth client ID for retrieving access tokens (optional).
        /// </para>
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The OAuth client secret for retrieving access tokens (optional).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Checks to see if the ClientSecret property is set.
        /// </summary>
        internal bool IsSetClientSecret() => this.ClientSecret != null;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The authorization code for retrieving access tokens (optional).
        /// </para>
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property CodeVerifier. 
        /// <para>
        /// The PKCE code verifier for enhanced security in the OAuth flow (optional).
        /// </para>
        /// </summary>
        public string CodeVerifier { get; set; }

        /// <summary>
        /// Checks to see if the CodeVerifier property is set.
        /// </summary>
        internal bool IsSetCodeVerifier() => this.CodeVerifier != null;

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// The OAuth grant type for retrieving access tokens (optional).
        /// </para>
        /// </summary>
        public string GrantType { get; set; }

        /// <summary>
        /// Checks to see if the GrantType property is set.
        /// </summary>
        internal bool IsSetGrantType() => this.GrantType != null;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network whose OIDC configuration will be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 8, Max = 8)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property RedirectUri. 
        /// <para>
        /// The redirect URI for the OAuth flow (optional).
        /// </para>
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUri property is set.
        /// </summary>
        internal bool IsSetRedirectUri() => this.RedirectUri != null;

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL for the OIDC provider (optional).
        /// </para>
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Checks to see if the Url property is set.
        /// </summary>
        internal bool IsSetUrl() => this.Url != null;
    }
}
