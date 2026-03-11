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
    /// Contains OAuth token information returned from the identity provider, including access
    /// tokens, ID tokens, and PKCE parameters used for secure authentication.
    /// </summary>
    public partial class OidcTokenInfo
    {
        private string _accessToken;
        private string _codeChallenge;
        private string _codeVerifier;
        private long? _expiresIn;
        private string _idToken;
        private string _refreshToken;
        private string _tokenType;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// The OAuth access token that can be used to access protected resources on behalf of
        /// the authenticated user.
        /// </para>
        /// </summary>
        public string AccessToken
        {
            get { return this._accessToken; }
            set { this._accessToken = value; }
        }

        // Check to see if AccessToken property is set
        internal bool IsSetAccessToken()
        {
            return this._accessToken != null;
        }

        /// <summary>
        /// Gets and sets the property CodeChallenge. 
        /// <para>
        /// The PKCE code challenge, a transformed version of the code verifier sent during the
        /// authorization request for verification.
        /// </para>
        /// </summary>
        public string CodeChallenge
        {
            get { return this._codeChallenge; }
            set { this._codeChallenge = value; }
        }

        // Check to see if CodeChallenge property is set
        internal bool IsSetCodeChallenge()
        {
            return this._codeChallenge != null;
        }

        /// <summary>
        /// Gets and sets the property CodeVerifier. 
        /// <para>
        /// The PKCE (Proof Key for Code Exchange) code verifier, a cryptographically random string
        /// used to enhance security in the OAuth flow.
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
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// The lifetime of the access token in seconds, indicating when the token will expire
        /// and need to be refreshed.
        /// </para>
        /// </summary>
        public long? ExpiresIn
        {
            get { return this._expiresIn; }
            set { this._expiresIn = value; }
        }

        // Check to see if ExpiresIn property is set
        internal bool IsSetExpiresIn()
        {
            return this._expiresIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdToken. 
        /// <para>
        /// The OpenID Connect ID token containing user identity information and authentication
        /// context as a signed JWT.
        /// </para>
        /// </summary>
        public string IdToken
        {
            get { return this._idToken; }
            set { this._idToken = value; }
        }

        // Check to see if IdToken property is set
        internal bool IsSetIdToken()
        {
            return this._idToken != null;
        }

        /// <summary>
        /// Gets and sets the property RefreshToken. 
        /// <para>
        /// The OAuth refresh token that can be used to obtain new access tokens without requiring
        /// the user to re-authenticate.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TokenType. 
        /// <para>
        /// The type of access token issued, typically 'Bearer', which indicates how the token
        /// should be used in API requests.
        /// </para>
        /// </summary>
        public string TokenType
        {
            get { return this._tokenType; }
            set { this._tokenType = value; }
        }

        // Check to see if TokenType property is set
        internal bool IsSetTokenType()
        {
            return this._tokenType != null;
        }

    }
}