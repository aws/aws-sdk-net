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
    /// Container for the parameters to the RevokeOAuth2TokenWithIAM operation.
    /// Grants permission to revoke an OAuth 2.0 refresh token and its associated refresh
    /// tokens
    /// 
    ///  
    /// <para>
    /// Revokes a refresh_token issued by AWS Sign-In, invalidating the entire token chain
    /// so that the refresh_token can no longer be used to mint new access_tokens.
    /// </para>
    ///  
    /// <para>
    /// Idempotency: revoking an already-revoked, expired, or otherwise invalid token still
    /// returns 200 OK with an empty body. Only the refresh_token type is accepted.
    /// </para>
    /// </summary>
    public partial class RevokeOAuth2TokenWithIAMRequest : AmazonSigninRequest
    {
        private string _token;

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The refresh_token to revoke. Must be a refresh_token issued by AWS Sign-In (prefix
        /// &quot;ASOR&quot;); access_tokens are not accepted for revocation.
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

    }
}