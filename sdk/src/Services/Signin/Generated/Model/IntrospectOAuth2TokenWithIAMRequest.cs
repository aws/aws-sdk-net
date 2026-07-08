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
    /// Container for the parameters to the IntrospectOAuth2TokenWithIAM operation.
    /// Grants permission to inspect the metadata and state of an OAuth 2.0 access token or
    /// refresh token
    /// 
    ///  
    /// <para>
    /// Implements RFC 7662 OAuth 2.0 Token Introspection over a SigV4-authenticated endpoint.
    /// Inspects the metadata of an access_token or refresh_token issued by AWS Sign-In and
    /// returns the claims associated with it.
    /// </para>
    ///  
    /// <para>
    /// Inactive token semantics (RFC 7662 §2.2): when the supplied token is unknown, expired,
    /// revoked, malformed, or owned by a different account, the response body is exactly
    /// { &quot;active&quot;: false } with all other claims omitted.
    /// </para>
    /// </summary>
    public partial class IntrospectOAuth2TokenWithIAMRequest : AmazonSigninRequest
    {
        private string _token;
        private string _tokenTypeHint;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The string value of the token to introspect. May be either an access_token or a refresh_token
        /// issued by AWS Sign-In.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=4096)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

        /// <summary>
        /// Gets and sets the property TokenTypeHint. 
        /// <para>
        /// Optional hint about the type of the token submitted for introspection. The server
        /// uses this hint to optimize lookup, but still falls back to the other token type on
        /// miss. Allowed values: access_token, refresh_token.
        /// </para>
        /// </summary>
        public string TokenTypeHint
        {
            get { return this._tokenTypeHint; }
            set { this._tokenTypeHint = value; }
        }

        // Check to see if TokenTypeHint property is set
        internal bool IsSetTokenTypeHint()
        {
            return this._tokenTypeHint != null;
        }

    }
}