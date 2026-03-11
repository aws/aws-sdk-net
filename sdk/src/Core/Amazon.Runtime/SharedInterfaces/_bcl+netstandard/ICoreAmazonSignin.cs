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

using Amazon.Runtime.Internal;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.SharedInterfaces
{
    /// <summary>
    /// ICoreAmazonSignin is not meant to be used directly. It defines Signin 
    /// service with basic .NET types and allows other services to be able to use the service as 
    /// a runtime dependency. This interface is implemented by the AmazonSigninClient 
    /// defined in the AWSSDK.Signin assembly.
    /// </summary>
    public interface ICoreAmazonSignin
    {
#if BCL
        /// <summary>
        /// Invoke CreateOAuth2Token to get access and refresh tokens.
        /// </summary>
        /// <param name="request">CoreCreateOAuth2TokenRequest instance.</param>
        /// <param name="invokedFromTool">Indicates if this method was invoked from a tool.</param>
        /// <returns>CoreCreateOAuth2TokenResponse instance representing response from Signin service for CreateOAuth2Token operation.</returns>
        CoreCreateOAuth2TokenResponse CreateOAuth2Token(CoreCreateOAuth2TokenRequest request, bool invokedFromTool);

#endif

        /// <summary>
        /// Invoke CreateOAuth2Token to get access and refresh tokens.
        /// </summary>
        /// <param name="request">CoreCreateOAuth2TokenRequest instance.</param>
        /// <param name="invokedFromTool">Indicates if this method was invoked from a tool.</param>
        /// <param name="cancellationToken">CancellationToken instance.</param>
        /// <returns>CoreCreateOAuth2TokenResponse instance representing response from Signin service for CreateOAuth2Token operation.</returns>
        Task<CoreCreateOAuth2TokenResponse> CreateOAuth2TokenAsync(CoreCreateOAuth2TokenRequest request, bool invokedFromTool, CancellationToken cancellationToken);

        /// <summary>
        /// Generates DPoP Proof as a signed JSON Web Token (JWT).
        /// </summary>
        /// <param name="httpMethod">The HTTP method of the request the DPoP proof is for, such as POST for token requests and GET for API calls.</param>
        /// <param name="uri">The HTTP URI of the request the DPoP Proof JWT is for, without the fragment and query parameters.</param>
        /// <param name="dpopKey">PEM file contents containing the base64-encoding of the Elliptic Curve Private Key.</param>
        /// <returns>JWT token representing DPoP Proof.</returns>
        string GenerateDPoPProof(string httpMethod, string uri, ref string dpopKey);

        /// <summary>
        /// Returns the base endpoint URL for Signin service.
        /// </summary>
        /// <returns>Base Endpoint URL for Signin service.</returns>
        string GetBaseEndpoint();
    }

    public class CoreCreateOAuth2TokenRequest
    {
        /// <summary>
        /// Flattened token operation inputs The specific operation is determined by grant_type
        /// in the request body
        /// </summary>
        public CoreCreateOAuth2TokenRequestBody TokenInput { get; set; }
    }

    public class CoreCreateOAuth2TokenRequestBody
    {
        /// <summary>
        /// The client identifier (ARN) used during Sign-In onboarding Required for both authorization
        /// code and refresh token flows
        /// </summary>
        public string ClientId { get; set; }
        
        /// <summary>
        /// The authorization code received from /v1/authorize Required only when grant_type=authorization_code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// PKCE code verifier to prove possession of the original code challenge Required only
        /// when grant_type=authorization_code
        /// </summary>
        public string CodeVerifier { get; set; }
 
        /// <summary>
        /// OAuth 2.0 grant type - determines which flow is used Must be &quot;authorization_code&quot;
        /// or &quot;refresh_token&quot;
        /// </summary>
        public string GrantType { get; set; }

        /// <summary>
        /// The redirect URI that must match the original authorization request Required only
        /// when grant_type=authorization_code
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// The refresh token returned from auth_code redemption Required only when grant_type=refresh_token
        /// </summary>
        public string RefreshToken { get; set; }
    }

    public class CoreCreateOAuth2TokenResponse
    {
        /// <summary>
        /// Gets and sets the property TokenOutput. 
        /// <para>
        /// Flattened token operation outputs The specific response fields depend on the grant_type
        /// used in the request
        /// </para>
        /// </summary>
        public CoreCreateOAuth2TokenResponseBody TokenOutput { get; set; }
    }

    public class CoreCreateOAuth2TokenResponseBody
    {
        /// <summary>
        /// JSON encoded scoped-down AWS credentials (15 minute duration) Present for both authorization
        /// code redemption and token refresh
        /// </summary>
        public CoreAccessToken AccessToken { get; set; }

        /// <summary>
        /// Time to expiry in seconds (maximum 900) Present for both authorization code redemption
        /// and token refresh
        /// </summary>
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// ID token containing user identity information Present only in authorization code redemption
        /// response (grant_type=authorization_code) Not included in token refresh responses
        /// </summary>
        public string IdToken { get; set; }

        /// <summary>
        /// Encrypted refresh token with cnf.jkt (SHA-256 thumbprint of presented jwk) Always
        /// present in responses (required for both flows)
        /// </summary>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Token type indicating this is AWS SigV4 credentials Value is &quot;aws_sigv4&quot;
        /// for both flows
        /// </summary>
        public string TokenType { get; set; }
    }

    /// <summary>
    /// AWS credentials structure containing temporary access credentials
    /// <para>
    /// The scoped-down, 15 minute duration AWS credentials. Scoping down will be based on
    /// CLI policy (CLI team needs to create it). Similar to cloud shell implementation.
    /// </para>
    /// </summary>
    public partial class CoreAccessToken
    {
        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// AWS access key ID for temporary credentials
        /// </para>
        /// </summary>
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        /// AWS secret access key for temporary credentials
        /// </para>
        /// </summary>
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Gets and sets the property SessionToken. 
        /// <para>
        /// AWS session token for temporary credentials
        /// </para>
        /// </summary>
        public string SessionToken { get; set; }
    }
}
