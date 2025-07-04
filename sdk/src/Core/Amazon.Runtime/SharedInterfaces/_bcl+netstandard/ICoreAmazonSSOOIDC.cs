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
using System.Threading;
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
        /// <para>
        /// This method is used internally to access the Amazon SSO OIDC service within other service assemblies.
        /// Please use AmazonSSOOIDCClient to access the Amazon SSO OIDC service instead.
        /// </para>
        /// 
        /// <para>
        /// Use Amazon SSO OIDC to get an SSO Token.
        /// </para>
        /// </summary>
        GetSsoTokenResponse GetSsoToken(GetSsoTokenRequest getSsoTokenRequest);
#endif

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon SSO OIDC service within other service assemblies.
        /// Please use AmazonSSOOIDCClient to access the Amazon SSO OIDC service instead.
        /// </para>
        /// 
        /// <para>
        /// Use Amazon SSO OIDC to get an SSO Token.
        /// </para>
        /// </summary>
        Task<GetSsoTokenResponse> GetSsoTokenAsync(GetSsoTokenRequest getSsoTokenRequest);

#if BCL
        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon SSO OIDC service within other service assemblies.
        /// Please use AmazonSSOOIDCClient to access the Amazon SSO OIDC service instead.
        /// </para>
        /// 
        /// <para>
        /// Use Amazon SSO OIDC to refresh <paramref name="previousResponse"/>.
        /// </para>
        /// </summary>
        GetSsoTokenResponse RefreshToken(GetSsoTokenResponse previousResponse);
#endif

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon SSO OIDC service within other service assemblies.
        /// Please use AmazonSSOOIDCClient to access the Amazon SSO OIDC service instead.
        /// </para>
        /// 
        /// <para>
        /// Use Amazon SSO OIDC to refresh <paramref name="previousResponse"/>.
        /// </para>
        /// </summary>
        Task<GetSsoTokenResponse> RefreshTokenAsync(GetSsoTokenResponse previousResponse);
    }

    /// <summary>
    /// ICoreAmazonSSOOIDC_V2 is not meant to be used directly. It defines SSO OIDC
    /// service with basic .NET types and allows other services to be able to use the service as 
    /// a runtime dependency. This interface is implemented by the AmazonSSOOIDCClient 
    /// defined in the AWSSDK.SSOOIDC assembly.
    /// </summary>
    public interface ICoreAmazonSSOOIDC_V2
    {
        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon SSO OIDC service within other service assemblies.
        /// Please use AmazonSSOOIDCClient to access the Amazon SSO OIDC service instead.
        /// </para>
        /// 
        /// <para>
        /// Use Amazon SSO OIDC to get an SSO Token.
        /// </para>
        /// </summary>
        Task<GetSsoTokenResponse> GetSsoTokenAsync(GetSsoTokenRequest getSsoTokenRequest, CancellationToken cancellationToken);
    }

    /// <summary>
    /// Options applicable for the Authorization Code Flow with PKCE. 
    /// </summary>
    public class PkceFlowOptions
    {
        /// <summary>
        /// Redirect URI defined by the client. 
        /// At completion of authorization, it is used to restrict what location the user agent can be redirected back to.
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// List of OAuth grant types that are defined by the client (it's used to restrict the token granting flows available to the client).
        /// In addition to <c>authorization_code</c>, <c>refresh_token</c> must be included in order for the SSO Token Manager
        /// to be able to refresh the access token before it expires.
        /// </summary>
        /// <remarks>Defaults to <c>["authorization_code", "refresh_token"]</c></remarks>
        public IList<string> GrantTypes { get; set; } = new List<string>
        {
            "authorization_code",
            "refresh_token"
        };

        /// <summary>
        /// Used by Identity Center to issue tokens to registered applications and clients.
        /// </summary>
        public string IssuerUrl { get; set; }

#if BCL
        /// <summary>
        /// The SDK will construct an authorization URL which the client must send an HTTP GET to retrieve the authorization code (as described in RFC 7636). 
        /// The return value of this delegate will then be used when invoking the <c>CreateToken</c> operation (in addition to the generated <c>code_verifier</c>).
        /// </summary>
        /// <remarks>
        /// This callback will only be invoked in the synchronous code path of the SSO token manager.
        /// </remarks>
        public Func<Uri, string> RetrieveAuthorizationCodeCallback { get; set; }
#endif

        /// <summary>
        /// The SDK will construct an authorization URL which the client must send an HTTP GET to retrieve the authorization code (as described in RFC 7636). 
        /// The return value of this delegate will then be used when invoking the <c>CreateToken</c> operation (in addition to the generated <c>code_verifier</c>).
        /// </summary>
        /// <remarks>
        /// This callback will only be invoked in the asynchronous code path of the SSO token manager.
        /// </remarks>
        public Func<Uri, CancellationToken, Task<string>> RetrieveAuthorizationCodeCallbackAsync { get; set; }
    }

    public class GetSsoTokenRequest
    {
        /// <summary>
        /// Name of the application or system used during SSO client registration.
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// OAuth client type (e.g. <c>public</c>).
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

        /// <summary>
        /// The SSO scopes that are provided for authorization when using AWS SSO.
        /// </summary>
        public IList<string> Scopes { get; set; }

        /// <summary>
        /// This property MUST be specified if the client wishes to use the Authorization Code Flow 
        /// with PKCE (if null, the SSO Token Manager will default to the Device Authorization Flow).
        /// </summary>
        public PkceFlowOptions PkceFlowOptions { get; set; }
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
        /// This field is set as a convenience and is not directly used by the token provider but is useful in other contexts.
        /// Logic that requires the SSO region as part of the SSO token provider MUST use the SSO region configured on the profile
        /// and MUST NOT use the region in the cached token.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// The configured sso_start_url for the profile that credentials are being resolved for.
        /// This field is set as a convenience and is not directly used by the token provider but
        /// is useful in other contexts. Logic that requires the SSO start URL as part of the SSO
        /// token provider MUST use the SSO start URL configured on the profile and MUST NOT
        /// use the SSO start URL in the cached token.
        /// </summary>
        public string StartUrl { get; set; }

        /// <summary>
        /// When using the Authorization Code Flow with PKCE, the SDK will generate a verifier that's used to
        /// validate the client as the originator of the request (as defined in RFC 7636).
        /// This field is set as a convenience and is not directly used by the token provider but is useful in other contexts.
        /// </summary>
        public string CodeVerifier { get; set; }
    }
}
