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
    /// Response body payload for CreateOAuth2Token operation
    /// 
    ///  
    /// <para>
    /// The response content depends on the grant_type from the request:
    /// </para>
    ///  <ul> <li>grant_type=authorization_code: Returns all fields including refresh_token
    /// and id_token</li> <li>grant_type=refresh_token: Returns access_token, token_type,
    /// expires_in, refresh_token (no id_token)</li> </ul>
    /// </summary>
    public partial class CreateOAuth2TokenResponseBody
    {
        private AccessToken _accessToken;
        private int? _expiresIn;
        private string _idToken;
        private string _refreshToken;
        private string _tokenType;

        /// <summary>
        /// Gets and sets the property AccessToken. 
        /// <para>
        /// Scoped-down AWS credentials (15 minute duration) Present for both authorization code
        /// redemption and token refresh
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public AccessToken AccessToken
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
        /// Gets and sets the property ExpiresIn. 
        /// <para>
        /// Time to expiry in seconds (maximum 900) Present for both authorization code redemption
        /// and token refresh
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=900)]
        public int? ExpiresIn
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
        /// ID token containing user identity information Present only in authorization code redemption
        /// response (grant_type=authorization_code) Not included in token refresh responses
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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
        /// Encrypted refresh token with cnf.jkt (SHA-256 thumbprint of presented jwk) Always
        /// present in responses (required for both flows)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048)]
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
        /// Token type indicating this is AWS SigV4 credentials Value is &quot;aws_sigv4&quot;
        /// for both flows
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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