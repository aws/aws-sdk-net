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
    /// The response body for an OAuth 2.0 token request. The fields returned depend on the
    /// "grant_type". The authorization code flow returns "refresh_token" and "id_token".
    /// The refresh token flow omits "id_token".
    /// </summary>
    public partial class CreateOAuth2TokenResponseBody
    {
        /// <summary>
        /// Gets and sets the property AccessToken. The access token issued by the authorization
        /// server. The token contains temporary AWS security credentials that you use to sign
        /// requests with SigV4.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public AccessToken AccessToken { get; set; }

        /// <summary>
        /// Checks to see if the AccessToken property is set.
        /// </summary>
        internal bool IsSetAccessToken() => this.AccessToken != null;

        /// <summary>
        /// Gets and sets the property ExpiresIn. The number of seconds until the access token
        /// expires. Maximum value is 900 seconds (15 minutes).
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 900)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresIn property is set.
        /// </summary>
        internal bool IsSetExpiresIn() => this.ExpiresIn.HasValue;

        /// <summary>
        /// Gets and sets the property IdToken. A JSON Web Token (JWT) containing user identity
        /// claims. Present only when "grant_type=authorization_code". Not included in refresh
        /// token responses.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string IdToken { get; set; }

        /// <summary>
        /// Checks to see if the IdToken property is set.
        /// </summary>
        internal bool IsSetIdToken() => this.IdToken != null;

        /// <summary>
        /// Gets and sets the property RefreshToken. A refresh token that can be used to obtain
        /// new access tokens without re-authenticating.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 2048)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the RefreshToken property is set.
        /// </summary>
        internal bool IsSetRefreshToken() => this.RefreshToken != null;

        /// <summary>
        /// Gets and sets the property TokenType. The type of token issued. Value is "aws_sigv4".
        /// </summary>
        [AWSProperty(Required = true)]
        public string TokenType { get; set; }

        /// <summary>
        /// Checks to see if the TokenType property is set.
        /// </summary>
        internal bool IsSetTokenType() => this.TokenType != null;
    }
}
