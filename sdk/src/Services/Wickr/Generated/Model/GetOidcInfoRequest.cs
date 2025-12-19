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
    /// Container for the parameters to the GetOidcInfo operation.
    /// Retrieves the OpenID Connect (OIDC) configuration for a Wickr network, including SSO
    /// settings and optional token information if access token parameters are provided.
    /// </summary>
    public partial class GetOidcInfoRequest : AmazonWickrRequest
    {
        private string _certificate;
        private string _clientId;
        private string _clientSecret;
        private string _code;
        private string _codeVerifier;
        private string _grantType;
        private string _networkId;
        private string _redirectUri;
        private string _url;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The CA certificate for secure communication with the OIDC provider (optional).
        /// </para>
        /// </summary>
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The OAuth client ID for retrieving access tokens (optional).
        /// </para>
        /// </summary>
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientSecret. 
        /// <para>
        /// The OAuth client secret for retrieving access tokens (optional).
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ClientSecret
        {
            get { return this._clientSecret; }
            set { this._clientSecret = value; }
        }

        // Check to see if ClientSecret property is set
        internal bool IsSetClientSecret()
        {
            return this._clientSecret != null;
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The authorization code for retrieving access tokens (optional).
        /// </para>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property CodeVerifier. 
        /// <para>
        /// The PKCE code verifier for enhanced security in the OAuth flow (optional).
        /// </para>
        /// </summary>
        public string CodeVerifier
        {
            get { return this._codeVerifier; }
            set { this._codeVerifier = value; }
        }

        // Check to see if CodeVerifier property is set
        internal bool IsSetCodeVerifier()
        {
            return this._codeVerifier != null;
        }

        /// <summary>
        /// Gets and sets the property GrantType. 
        /// <para>
        /// The OAuth grant type for retrieving access tokens (optional).
        /// </para>
        /// </summary>
        public string GrantType
        {
            get { return this._grantType; }
            set { this._grantType = value; }
        }

        // Check to see if GrantType property is set
        internal bool IsSetGrantType()
        {
            return this._grantType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network whose OIDC configuration will be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=8)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property RedirectUri. 
        /// <para>
        /// The redirect URI for the OAuth flow (optional).
        /// </para>
        /// </summary>
        public string RedirectUri
        {
            get { return this._redirectUri; }
            set { this._redirectUri = value; }
        }

        // Check to see if RedirectUri property is set
        internal bool IsSetRedirectUri()
        {
            return this._redirectUri != null;
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL for the OIDC provider (optional).
        /// </para>
        /// </summary>
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}