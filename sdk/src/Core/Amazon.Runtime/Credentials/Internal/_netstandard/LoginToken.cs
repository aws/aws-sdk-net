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

using Amazon.Runtime.Internal.Auth;
using System;
using System.Globalization;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// Class representing Login Token.
    /// </summary>
    public class LoginToken
    {
        /// <summary>
        /// An object containing the access token and its metadata.
        /// </summary>
        public LoginImmutableCredentials AccessToken { get; set; }

        /// <summary>
        /// Returned by Sign-In, only expected to be `aws_sigv4` initially.
        /// </summary>
        public string TokenType { get; set; }

        /// <summary>
        /// A JWT, containing info from Sign-In about which account/role/etc. the AccessToken is for.
        /// </summary>
        public string IdentityToken { get; set; }

        /// <summary>
        /// An opaque string returned by Sign-In.
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// The ARN of the client ID used when acquiring the token (`arn:aws:signin:::devtools/same-device` OR `arn:aws:signin:::devtools/cross-device`).
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// PEM file contents containing the base64-encoding of the ECPrivateKey format.
        /// </summary>
        public string DPoPKey { get; set; }
    }
}