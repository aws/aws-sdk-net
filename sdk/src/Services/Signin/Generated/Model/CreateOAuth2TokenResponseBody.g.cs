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

namespace Amazon.Signin.Model
{
    /// <summary>
    /// Response body payload for CreateOAuth2Token operation The response content depends
    /// on the grant_type from the request: - grant_type=authorization_code: Returns all fields
    /// including refresh_token and id_token - grant_type=refresh_token: Returns access_token,
    /// token_type, expires_in, refresh_token (no id_token)
    /// </summary>
    public partial class CreateOAuth2TokenResponseBody
    {
        /// <summary>
        /// Gets and sets the property AccessToken. Scoped-down AWS credentials (15 minute duration)
        /// Present for both authorization code redemption and token refresh
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public AccessToken AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property ExpiresIn. Time to expiry in seconds (maximum 900) Present
        /// for both authorization code redemption and token refresh
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 900)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresIn property is set.
        /// </summary>
        internal bool IsSetExpiresIn() => this.ExpiresIn.HasValue;

        /// <summary>
        /// Gets and sets the property IdToken. ID token containing user identity information
        /// Present only in authorization code redemption response (grant_type=authorization_code)
        /// Not included in token refresh responses
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string IdToken { get; set; }

        /// <summary>
        /// Checks to see if the IdToken property is set.
        /// </summary>
        internal bool IsSetIdToken() => this.IdToken != null;

        /// <summary>
        /// Gets and sets the property RefreshToken. Encrypted refresh token with cnf.jkt (SHA-256
        /// thumbprint of presented jwk) Always present in responses (required for both flows)
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2048)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the RefreshToken property is set.
        /// </summary>
        internal bool IsSetRefreshToken() => this.RefreshToken != null;

        /// <summary>
        /// Gets and sets the property TokenType. Token type indicating this is AWS SigV4 credentials
        /// Value is "aws_sigv4" for both flows
        /// </summary>
        [AWSProperty(Required = true)]
        public string TokenType { get; set; }

        /// <summary>
        /// Checks to see if the TokenType property is set.
        /// </summary>
        internal bool IsSetTokenType() => this.TokenType != null;
    }
}
