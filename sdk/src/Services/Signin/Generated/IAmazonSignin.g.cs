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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Signin.Model;

#pragma warning disable CS1570

namespace Amazon.Signin
{
    /// <summary>
    /// <para>Interface for accessing Signin</para>
    ///
    /// AWS Sign-In manages authentication for AWS services. This service provides secure
    /// authentication flows for accessing AWS resources from the console and developer tools.
    /// </summary>
    public partial interface IAmazonSignin : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISigninPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// CreateOAuth2Token API Path: /v1/token Request Method: POST Content-Type: application/json
        /// or application/x-www-form-urlencoded This API implements OAuth 2.0 flows for AWS Sign-In
        /// CLI clients, supporting both: 1. Authorization code redemption (grant_type=authorization_code)
        /// - NOT idempotent 2. Token refresh (grant_type=refresh_token) - Idempotent within token
        /// validity window The operation behavior is determined by the grant_type parameter in
        /// the request body: **Authorization Code Flow (NOT Idempotent):** - JSON or form-encoded
        /// body with client_id, grant_type=authorization_code, code, redirect_uri, code_verifier
        /// - Returns access_token, token_type, expires_in, refresh_token, and id_token - Each
        /// authorization code can only be used ONCE for security (prevents replay attacks) **Token
        /// Refresh Flow (Idempotent):** - JSON or form-encoded body with client_id, grant_type=refresh_token,
        /// refresh_token - Returns access_token, token_type, expires_in, and refresh_token (no
        /// id_token) - Multiple calls with same refresh_token return consistent results within
        /// validity window Authentication and authorization: - Confidential clients: sigv4 signing
        /// required with signin:ExchangeToken permissions - CLI clients (public): authn/authz
        /// skipped based on client_id &amp; grant_type Note: This operation cannot be marked
        /// as @idempotent because it handles both idempotent (token refresh) and non-idempotent
        /// (auth code redemption) flows in a single endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2Token service method.</param>
        /// <returns>The response from the CreateOAuth2Token service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2Token">REST API Reference for CreateOAuth2Token Operation</seealso>
        CreateOAuth2TokenResponse CreateOAuth2Token(CreateOAuth2TokenRequest request);
#endif

        /// <summary>
        /// CreateOAuth2Token API Path: /v1/token Request Method: POST Content-Type: application/json
        /// or application/x-www-form-urlencoded This API implements OAuth 2.0 flows for AWS Sign-In
        /// CLI clients, supporting both: 1. Authorization code redemption (grant_type=authorization_code)
        /// - NOT idempotent 2. Token refresh (grant_type=refresh_token) - Idempotent within token
        /// validity window The operation behavior is determined by the grant_type parameter in
        /// the request body: **Authorization Code Flow (NOT Idempotent):** - JSON or form-encoded
        /// body with client_id, grant_type=authorization_code, code, redirect_uri, code_verifier
        /// - Returns access_token, token_type, expires_in, refresh_token, and id_token - Each
        /// authorization code can only be used ONCE for security (prevents replay attacks) **Token
        /// Refresh Flow (Idempotent):** - JSON or form-encoded body with client_id, grant_type=refresh_token,
        /// refresh_token - Returns access_token, token_type, expires_in, and refresh_token (no
        /// id_token) - Multiple calls with same refresh_token return consistent results within
        /// validity window Authentication and authorization: - Confidential clients: sigv4 signing
        /// required with signin:ExchangeToken permissions - CLI clients (public): authn/authz
        /// skipped based on client_id &amp; grant_type Note: This operation cannot be marked
        /// as @idempotent because it handles both idempotent (token refresh) and non-idempotent
        /// (auth code redemption) flows in a single endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2Token service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateOAuth2Token service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2Token">REST API Reference for CreateOAuth2Token Operation</seealso>
        Task<CreateOAuth2TokenResponse> CreateOAuth2TokenAsync(CreateOAuth2TokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Grants permission to exchange client credentials for an OAuth 2.0 access token scoped
        /// to a resource that can be used to access AWS services from applications
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2TokenWithIAM service method.</param>
        /// <returns>The response from the CreateOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2TokenWithIAM">REST API Reference for CreateOAuth2TokenWithIAM Operation</seealso>
        CreateOAuth2TokenWithIAMResponse CreateOAuth2TokenWithIAM(CreateOAuth2TokenWithIAMRequest request);
#endif

        /// <summary>
        /// Grants permission to exchange client credentials for an OAuth 2.0 access token scoped
        /// to a resource that can be used to access AWS services from applications
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2TokenWithIAM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2TokenWithIAM">REST API Reference for CreateOAuth2TokenWithIAM Operation</seealso>
        Task<CreateOAuth2TokenWithIAMResponse> CreateOAuth2TokenWithIAMAsync(CreateOAuth2TokenWithIAMRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConsoleAuthorizationConfiguration service method.</param>
        /// <returns>The response from the DeleteConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/DeleteConsoleAuthorizationConfiguration">REST API Reference for DeleteConsoleAuthorizationConfiguration Operation</seealso>
        DeleteConsoleAuthorizationConfigurationResponse DeleteConsoleAuthorizationConfiguration(DeleteConsoleAuthorizationConfigurationRequest request);
#endif

        /// <summary>
        /// Delete console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConsoleAuthorizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/DeleteConsoleAuthorizationConfiguration">REST API Reference for DeleteConsoleAuthorizationConfiguration Operation</seealso>
        Task<DeleteConsoleAuthorizationConfigurationResponse> DeleteConsoleAuthorizationConfigurationAsync(DeleteConsoleAuthorizationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Remove a permission statement from the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermissionStatement service method.</param>
        /// <returns>The response from the DeleteResourcePermissionStatement service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/DeleteResourcePermissionStatement">REST API Reference for DeleteResourcePermissionStatement Operation</seealso>
        DeleteResourcePermissionStatementResponse DeleteResourcePermissionStatement(DeleteResourcePermissionStatementRequest request);
#endif

        /// <summary>
        /// Remove a permission statement from the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePermissionStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteResourcePermissionStatement service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/DeleteResourcePermissionStatement">REST API Reference for DeleteResourcePermissionStatement Operation</seealso>
        Task<DeleteResourcePermissionStatementResponse> DeleteResourcePermissionStatementAsync(DeleteResourcePermissionStatementRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleAuthorizationConfiguration service method.</param>
        /// <returns>The response from the GetConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/GetConsoleAuthorizationConfiguration">REST API Reference for GetConsoleAuthorizationConfiguration Operation</seealso>
        GetConsoleAuthorizationConfigurationResponse GetConsoleAuthorizationConfiguration(GetConsoleAuthorizationConfigurationRequest request);
#endif

        /// <summary>
        /// Get console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleAuthorizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/GetConsoleAuthorizationConfiguration">REST API Reference for GetConsoleAuthorizationConfiguration Operation</seealso>
        Task<GetConsoleAuthorizationConfigurationResponse> GetConsoleAuthorizationConfigurationAsync(GetConsoleAuthorizationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieve the account's consolidated SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <returns>The response from the GetResourcePolicy service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request);
#endif

        /// <summary>
        /// Retrieve the account's consolidated SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetResourcePolicy service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Grants permission to inspect the metadata and state of an OAuth 2.0 access token or
        /// refresh token Implements RFC 7662 OAuth 2.0 Token Introspection over a SigV4-authenticated
        /// endpoint. Inspects the metadata of an access_token or refresh_token issued by AWS
        /// Sign-In and returns the claims associated with it. Inactive token semantics (RFC 7662
        /// §2.2): when the supplied token is unknown, expired, revoked, malformed, or owned by
        /// a different account, the response body is exactly { "active": false } with all other
        /// claims omitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IntrospectOAuth2TokenWithIAM service method.</param>
        /// <returns>The response from the IntrospectOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/IntrospectOAuth2TokenWithIAM">REST API Reference for IntrospectOAuth2TokenWithIAM Operation</seealso>
        IntrospectOAuth2TokenWithIAMResponse IntrospectOAuth2TokenWithIAM(IntrospectOAuth2TokenWithIAMRequest request);
#endif

        /// <summary>
        /// Grants permission to inspect the metadata and state of an OAuth 2.0 access token or
        /// refresh token Implements RFC 7662 OAuth 2.0 Token Introspection over a SigV4-authenticated
        /// endpoint. Inspects the metadata of an access_token or refresh_token issued by AWS
        /// Sign-In and returns the claims associated with it. Inactive token semantics (RFC 7662
        /// §2.2): when the supplied token is unknown, expired, revoked, malformed, or owned by
        /// a different account, the response body is exactly { "active": false } with all other
        /// claims omitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IntrospectOAuth2TokenWithIAM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the IntrospectOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/IntrospectOAuth2TokenWithIAM">REST API Reference for IntrospectOAuth2TokenWithIAM Operation</seealso>
        Task<IntrospectOAuth2TokenWithIAMResponse> IntrospectOAuth2TokenWithIAMAsync(IntrospectOAuth2TokenWithIAMRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieve all permission statements in the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePermissionStatements service method.</param>
        /// <returns>The response from the ListResourcePermissionStatements service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/ListResourcePermissionStatements">REST API Reference for ListResourcePermissionStatements Operation</seealso>
        ListResourcePermissionStatementsResponse ListResourcePermissionStatements(ListResourcePermissionStatementsRequest request);
#endif

        /// <summary>
        /// Retrieve all permission statements in the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePermissionStatements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListResourcePermissionStatements service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/ListResourcePermissionStatements">REST API Reference for ListResourcePermissionStatements Operation</seealso>
        Task<ListResourcePermissionStatementsResponse> ListResourcePermissionStatementsAsync(ListResourcePermissionStatementsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Enable console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConsoleAuthorizationConfiguration service method.</param>
        /// <returns>The response from the PutConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state HTTP Status Code: 409 Conflict
        /// Used when the request conflicts with the current state of the resource
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/PutConsoleAuthorizationConfiguration">REST API Reference for PutConsoleAuthorizationConfiguration Operation</seealso>
        PutConsoleAuthorizationConfigurationResponse PutConsoleAuthorizationConfiguration(PutConsoleAuthorizationConfigurationRequest request);
#endif

        /// <summary>
        /// Enable console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConsoleAuthorizationConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state HTTP Status Code: 409 Conflict
        /// Used when the request conflicts with the current state of the resource
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/PutConsoleAuthorizationConfiguration">REST API Reference for PutConsoleAuthorizationConfiguration Operation</seealso>
        Task<PutConsoleAuthorizationConfigurationResponse> PutConsoleAuthorizationConfigurationAsync(PutConsoleAuthorizationConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a permission statement in the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermissionStatement service method.</param>
        /// <returns>The response from the PutResourcePermissionStatement service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state HTTP Status Code: 409 Conflict
        /// Used when the request conflicts with the current state of the resource
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ServiceQuotaExceededException">
        /// Error thrown when service quota is exceeded HTTP Status Code: 402 Payment Required
        /// (used as quota exceeded indicator) Used when the request would cause a service quota
        /// to be exceeded
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/PutResourcePermissionStatement">REST API Reference for PutResourcePermissionStatement Operation</seealso>
        PutResourcePermissionStatementResponse PutResourcePermissionStatement(PutResourcePermissionStatementRequest request);
#endif

        /// <summary>
        /// Create a permission statement in the account's SignIn resource-based policy
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePermissionStatement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutResourcePermissionStatement service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state HTTP Status Code: 409 Conflict
        /// Used when the request conflicts with the current state of the resource
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ServiceQuotaExceededException">
        /// Error thrown when service quota is exceeded HTTP Status Code: 402 Payment Required
        /// (used as quota exceeded indicator) Used when the request would cause a service quota
        /// to be exceeded
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/PutResourcePermissionStatement">REST API Reference for PutResourcePermissionStatement Operation</seealso>
        Task<PutResourcePermissionStatementResponse> PutResourcePermissionStatementAsync(PutResourcePermissionStatementRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Grants permission to revoke an OAuth 2.0 refresh token and its associated refresh
        /// tokens Revokes a refresh_token issued by AWS Sign-In, invalidating the entire token
        /// chain so that the refresh_token can no longer be used to mint new access_tokens. Idempotency:
        /// revoking an already-revoked, expired, or otherwise invalid token still returns 200
        /// OK with an empty body. Only the refresh_token type is accepted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeOAuth2TokenWithIAM service method.</param>
        /// <returns>The response from the RevokeOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/RevokeOAuth2TokenWithIAM">REST API Reference for RevokeOAuth2TokenWithIAM Operation</seealso>
        RevokeOAuth2TokenWithIAMResponse RevokeOAuth2TokenWithIAM(RevokeOAuth2TokenWithIAMRequest request);
#endif

        /// <summary>
        /// Grants permission to revoke an OAuth 2.0 refresh token and its associated refresh
        /// tokens Revokes a refresh_token issued by AWS Sign-In, invalidating the entire token
        /// chain so that the refresh_token can no longer be used to mint new access_tokens. Idempotency:
        /// revoking an already-revoked, expired, or otherwise invalid token still returns 200
        /// OK with an empty body. Only the refresh_token type is accepted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeOAuth2TokenWithIAM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RevokeOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// Error thrown for access denied scenarios with flexible HTTP status mapping Runtime
        /// HTTP Status Code Mapping: - HTTP 401 (Unauthorized): TOKEN_EXPIRED, AUTHCODE_EXPIRED
        /// - HTTP 403 (Forbidden): USER_CREDENTIALS_CHANGED, INSUFFICIENT_PERMISSIONS The specific
        /// HTTP status code is determined at runtime based on the error enum value. Consumers
        /// should use the error field to determine the specific access denial reason.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// Error thrown when an internal server error occurs HTTP Status Code: 500 Internal Server
        /// Error Used for unexpected server-side errors that prevent request processing.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// Error thrown when rate limit is exceeded HTTP Status Code: 429 Too Many Requests Possible
        /// OAuth2ErrorCode values: - INVALID_REQUEST: Rate limiting, too many requests, abuse
        /// prevention Possible causes: - Too many token requests from the same client - Rate
        /// limiting based on client_id or IP address - Abuse prevention mechanisms triggered
        /// - Service protection against excessive token generation
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// Error thrown when request validation fails HTTP Status Code: 400 Bad Request Used
        /// for request validation errors such as malformed parameters, missing required fields,
        /// or invalid parameter values.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/RevokeOAuth2TokenWithIAM">REST API Reference for RevokeOAuth2TokenWithIAM Operation</seealso>
        Task<RevokeOAuth2TokenWithIAMResponse> RevokeOAuth2TokenWithIAMAsync(RevokeOAuth2TokenWithIAMRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSigninConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSigninConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSigninConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSigninConfig to create AmazonSigninClient");
            }

            return awsCredentials == null ?
                    new AmazonSigninClient(serviceClientConfig) :
                    new AmazonSigninClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
