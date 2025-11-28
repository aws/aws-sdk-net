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
    /// Container for the parameters to the CreateOAuth2Token operation.
    /// CreateOAuth2Token API
    /// 
    ///  
    /// <para>
    /// Path: /v1/token Request Method: POST Content-Type: application/json or application/x-www-form-urlencoded
    /// </para>
    ///  
    /// <para>
    /// This API implements OAuth 2.0 flows for AWS Sign-In CLI clients, supporting both:
    /// </para>
    ///  <ol> <li>Authorization code redemption (grant_type=authorization_code) - NOT idempotent</li>
    /// <li>Token refresh (grant_type=refresh_token) - Idempotent within token validity window</li>
    /// </ol> 
    /// <para>
    /// The operation behavior is determined by the grant_type parameter in the request body:
    /// </para>
    ///  
    /// <para>
    /// <strong>Authorization Code Flow (NOT Idempotent):</strong>
    /// </para>
    ///  <ul> <li>JSON or form-encoded body with client_id, grant_type=authorization_code,
    /// code, redirect_uri, code_verifier</li> <li>Returns access_token, token_type, expires_in,
    /// refresh_token, and id_token</li> <li>Each authorization code can only be used ONCE
    /// for security (prevents replay attacks)</li> </ul> 
    /// <para>
    /// <strong>Token Refresh Flow (Idempotent):</strong>
    /// </para>
    ///  <ul> <li>JSON or form-encoded body with client_id, grant_type=refresh_token, refresh_token</li>
    /// <li>Returns access_token, token_type, expires_in, and refresh_token (no id_token)</li>
    /// <li>Multiple calls with same refresh_token return consistent results within validity
    /// window</li> </ul> 
    /// <para>
    /// Authentication and authorization:
    /// </para>
    ///  <ul> <li>Confidential clients: sigv4 signing required with signin:ExchangeToken permissions</li>
    /// <li>CLI clients (public): authn/authz skipped based on client_id &amp; grant_type</li>
    /// </ul> 
    /// <para>
    /// Note: This operation cannot be marked as @idempotent because it handles both idempotent
    /// (token refresh) and non-idempotent (auth code redemption) flows in a single endpoint.
    /// </para>
    /// </summary>
    public partial class CreateOAuth2TokenRequest : AmazonSigninRequest
    {
        private CreateOAuth2TokenRequestBody _tokenInput;

        /// <summary>
        /// Gets and sets the property TokenInput. 
        /// <para>
        /// Flattened token operation inputs The specific operation is determined by grant_type
        /// in the request body
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CreateOAuth2TokenRequestBody TokenInput
        {
            get { return this._tokenInput; }
            set { this._tokenInput = value; }
        }

        // Check to see if TokenInput property is set
        internal bool IsSetTokenInput()
        {
            return this._tokenInput != null;
        }

    }
}