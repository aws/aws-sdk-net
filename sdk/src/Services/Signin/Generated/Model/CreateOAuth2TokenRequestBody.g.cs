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
    /// The request body for creating an OAuth 2.0 token. Supports both the authorization
    /// code and refresh token flows, selected by the "grant_type" parameter.
    /// </summary>
    public partial class CreateOAuth2TokenRequestBody
    {
        /// <summary>
        /// Gets and sets the property ClientId. The OAuth 2.0 client identifier. Expected values:
        /// "arn:aws:signin:::devtools/same-device" or "arn:aws:signin:::devtools/cross-device".
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property Code. The authorization code received from the "/v1/authorize"
        /// endpoint. Required when "grant_type=authorization_code".
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property CodeVerifier. The PKCE code verifier that proves possession
        /// of the original code challenge. Required when "grant_type=authorization_code".
        /// </summary>
        [AWSProperty(Min = 43, Max = 128)]
        public string CodeVerifier { get; set; }

        /// <summary>
        /// Checks to see if the CodeVerifier property is set.
        /// </summary>
        internal bool IsSetCodeVerifier() => this.CodeVerifier != null;

        /// <summary>
        /// Gets and sets the property GrantType. The OAuth 2.0 grant type. Supported values:
        /// - "authorization_code" - Exchange an authorization code for tokens. - "refresh_token"
        /// - Use a refresh token to obtain a new access token.
        /// </summary>
        [AWSProperty(Required = true)]
        public string GrantType { get; set; }

        /// <summary>
        /// Checks to see if the GrantType property is set.
        /// </summary>
        internal bool IsSetGrantType() => this.GrantType != null;

        /// <summary>
        /// Gets and sets the property RedirectUri. The redirect URI that was used in the original
        /// authorization request. Must match exactly. Required when "grant_type=authorization_code".
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Checks to see if the RedirectUri property is set.
        /// </summary>
        internal bool IsSetRedirectUri() => this.RedirectUri != null;

        /// <summary>
        /// Gets and sets the property RefreshToken. The refresh token issued by a previous token
        /// response. Required when "grant_type=refresh_token".
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 2048)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Checks to see if the RefreshToken property is set.
        /// </summary>
        internal bool IsSetRefreshToken() => this.RefreshToken != null;
    }
}
