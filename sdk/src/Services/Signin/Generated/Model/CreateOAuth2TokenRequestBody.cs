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
 * Do not modify this file. This file is generated from the signin-2023-01-01.normal.json service model.
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
namespace Amazon.Signin.Model
{
    /// <summary>
    /// Request body payload for CreateOAuth2Token operation
    /// 
    ///  
    /// <para>
    /// The operation type is determined by the grant_type parameter:
    /// </para>
    ///  <ul> <li>grant_type=authorization_code: Requires code, redirect_uri, code_verifier</li>
    /// <li>grant_type=refresh_token: Requires refresh_token</li> </ul>
    /// </summary>
    public partial class CreateOAuth2TokenRequestBody
    {
        private string _clientId;
        private string _code;
        private string _codeVerifier;
        private string _grantType;
        private string _redirectUri;
        private string _refreshToken;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The client identifier (ARN) used during Sign-In onboarding Required for both authorization
        /// code and refresh token flows
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Code. 
        /// <para>
        /// The authorization code received from /v1/authorize Required only when grant_type=authorization_code
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// PKCE code verifier to prove possession of the original code challenge Required only
        /// when grant_type=authorization_code
        /// </para>
        /// </summary>
        [AWSProperty(Min=43, Max=128)]
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
        /// OAuth 2.0 grant type - determines which flow is used Must be &quot;authorization_code&quot;
        /// or &quot;refresh_token&quot;
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RedirectUri. 
        /// <para>
        /// The redirect URI that must match the original authorization request Required only
        /// when grant_type=authorization_code
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// The refresh token returned from auth_code redemption Required only when grant_type=refresh_token
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string RefreshToken
        {
            get { return this._refreshToken; }
            set { this._refreshToken = value; }
        }

        // Check to see if RefreshToken property is set
        internal bool IsSetRefreshToken()
        {
            return this._refreshToken != null;
        }

    }
}