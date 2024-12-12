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

namespace Amazon.Runtime.Credentials.Internal
{
    /// <summary>
    /// An <see cref="SsoToken"/> is used by the <see cref="SSOAWSCredentials"/> provider to request
    /// permission to get credentials and by the <see cref="SSOTokenProvider"/> when a Service is using
    /// <see cref="BearerTokenSigner"/>.
    /// <para />
    /// <see cref="SsoToken"/>s are persisted using <see cref="SSOTokenManager"/>.
    /// </summary>
    /// <remarks>
    /// This class is meant to be used internally.  It may be projected to a
    /// <see cref="AWSToken"/>
    /// </remarks>
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
        ///  An opaque string returned by the sso-oidc service.
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// The client ID generated when performing the registration portion of the OIDC authorization flow.
        /// The clientId is used alongside the <see cref="RefreshToken"/> to refresh the <see cref="AccessToken"/>.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// The client secret generated when performing the registration portion of the OIDC authorization flow.
        /// The <see cref="ClientSecret"/> is used alongside the <see cref="RefreshToken"/> to refresh the <see cref="AccessToken"/>.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        /// The expiration time of the client registration (<see cref="ClientId"/> and <see cref="ClientSecret"/>) as
        /// an RFC 3339 formatted timestamp.
        /// </summary>
        public string RegistrationExpiresAt { get; set; }

        /// <summary>
        /// The configured sso_region for the profile that credentials are being resolved for.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// The configured sso_start_url for the profile that credentials are being resolved for.
        /// </summary>
        public string StartUrl { get; set; }

        /// <summary>
        /// The configured sso_session for the profile that credentials are being resolved for.
        /// </summary>
        public string Session { get; set; }
    }
}