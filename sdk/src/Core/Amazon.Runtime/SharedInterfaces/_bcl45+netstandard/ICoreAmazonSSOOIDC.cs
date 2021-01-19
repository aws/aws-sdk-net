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
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Amazon.Runtime.SharedInterfaces
{
    /// <summary>
    /// ICoreAmazonSSOOIDC is not meant to be used directly. It defines SSO OIDC
    /// service with basic .NET types and allows other services to be able to use the service as 
    /// a runtime dependency. This interface is implemented by the AmazonSSOOIDCClient 
    /// defined in the AWSSDK.SSOOIDC assembly.
    /// </summary>
    public interface ICoreAmazonSSOOIDC
    {
#if BCL
        /// <summary>
        /// This method is used internally to access the Amazon SSO OIDC service within other service assemblies.
        /// Please use AmazonSSOOIDCClient to access the Amazon SSO OIDC service instead.
        /// 
        /// Use Amazon SSO OIDC to get an SSO Token
        /// </summary>
        GetSsoTokenResponse GetSsoToken(GetSsoTokenRequest getSsoTokenRequest);
#endif

#if AWS_ASYNC_API
        /// <summary>
        /// This method is used internally to access the Amazon SSO OIDC service within other service assemblies.
        /// Please use AmazonSSOOIDCClient to access the Amazon SSO OIDC service instead.
        /// 
        /// Use Amazon SSO OIDC to get an SSO Token
        /// </summary>
        Task<GetSsoTokenResponse> GetSsoTokenAsync(GetSsoTokenRequest getSsoTokenRequest);
#endif
    }

    public class GetSsoTokenRequest
    {
        /// <summary>
        /// Name of the application or system used during SSO client registration.
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// OAuth client type
        /// </summary>
        public string ClientType { get; set; }

        /// <summary>
        /// The StartUrl to request an SSO Token from.
        /// </summary>
        public string StartUrl { get; set; }

        /// <summary>
        /// Callback for presenting the user with a SSO Login flow.
        /// </summary>
        public Action<SsoVerificationArguments> SsoVerificationCallback { get; set; }

        /// <summary>
        /// Additional properties to provide to the operation.
        /// Optional, can be null.
        /// </summary>
        public IDictionary<string, object> AdditionalProperties { get; set; }
    }

    public class GetSsoTokenResponse
    {
        /// <summary>
        /// The SSO login token that can be exchanged for temporary AWS credentials.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// When <see cref="AccessToken"/> expires
        /// </summary>
        public DateTime ExpiresAt { get; set; }
    }
}
