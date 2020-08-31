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

using System;

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// An SSO Token is used by the SSO AWS Credentials provider to request permission to get credentials.
    /// SSO Tokens are persisted using <see cref="SsoTokenCache"/>.
    /// </summary>
    public class SsoToken
    {
        /// <summary>
        /// Token string returned by the SSOOIDC service (IAmazonSSOOIDC).
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Expiration time of <see cref="AccessToken"/>
        /// </summary>
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// The configured sso_region for the profile that credentials are being resolved for.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// The configured sso_start_url for the profile that credentials are being resolved for.
        /// </summary>
        public string StartUrl { get; set; }
    }
}