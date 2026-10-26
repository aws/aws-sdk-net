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
    /// AWS Sign-In manages authentication for AWS services. It implements OAuth 2.0, providing
    /// secure token exchange and refresh capabilities.
    /// </summary>
    public partial interface IAmazonSignin : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISigninPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Exchanges an authorization code or refresh token for an OAuth 2.0 access token and
        /// refresh token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2Token service method.</param>
        /// <returns>The response from the CreateOAuth2Token service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2Token">REST API Reference for CreateOAuth2Token Operation</seealso>
        CreateOAuth2TokenResponse CreateOAuth2Token(CreateOAuth2TokenRequest request);
#endif

        /// <summary>
        /// Exchanges an authorization code or refresh token for an OAuth 2.0 access token and
        /// refresh token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2Token service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateOAuth2Token service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2Token">REST API Reference for CreateOAuth2Token Operation</seealso>
        Task<CreateOAuth2TokenResponse> CreateOAuth2TokenAsync(CreateOAuth2TokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Exchanges client credentials for an OAuth 2.0 access token scoped to a resource, which
        /// you can use to access AWS services from applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2TokenWithIAM service method.</param>
        /// <returns>The response from the CreateOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2TokenWithIAM">REST API Reference for CreateOAuth2TokenWithIAM Operation</seealso>
        CreateOAuth2TokenWithIAMResponse CreateOAuth2TokenWithIAM(CreateOAuth2TokenWithIAMRequest request);
#endif

        /// <summary>
        /// Exchanges client credentials for an OAuth 2.0 access token scoped to a resource, which
        /// you can use to access AWS services from applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2TokenWithIAM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2TokenWithIAM">REST API Reference for CreateOAuth2TokenWithIAM Operation</seealso>
        Task<CreateOAuth2TokenWithIAMResponse> CreateOAuth2TokenWithIAMAsync(CreateOAuth2TokenWithIAMRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Exchanges a supported token for an OAuth 2.0 access token scoped to a resource, which
        /// you can use to access AWS services from applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2TokenWithTokenExchange service method.</param>
        /// <returns>The response from the CreateOAuth2TokenWithTokenExchange service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InvalidGrantException">
        /// The request failed because the provided grant is invalid or expired.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InvalidScopeException">
        /// The request failed because the requested scope is invalid or exceeds the scope that
        /// can be granted.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ServiceUnavailableException">
        /// The request failed because a dependency is temporarily unavailable. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2TokenWithTokenExchange">REST API Reference for CreateOAuth2TokenWithTokenExchange Operation</seealso>
        CreateOAuth2TokenWithTokenExchangeResponse CreateOAuth2TokenWithTokenExchange(CreateOAuth2TokenWithTokenExchangeRequest request);
#endif

        /// <summary>
        /// Exchanges a supported token for an OAuth 2.0 access token scoped to a resource, which
        /// you can use to access AWS services from applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOAuth2TokenWithTokenExchange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateOAuth2TokenWithTokenExchange service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InvalidGrantException">
        /// The request failed because the provided grant is invalid or expired.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InvalidScopeException">
        /// The request failed because the requested scope is invalid or exceeds the scope that
        /// can be granted.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ServiceUnavailableException">
        /// The request failed because a dependency is temporarily unavailable. You can retry
        /// the request.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/CreateOAuth2TokenWithTokenExchange">REST API Reference for CreateOAuth2TokenWithTokenExchange Operation</seealso>
        Task<CreateOAuth2TokenWithTokenExchangeResponse> CreateOAuth2TokenWithTokenExchangeAsync(CreateOAuth2TokenWithTokenExchangeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete console authorization configuration with automatic scope detection
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConsoleAuthorizationConfiguration service method.</param>
        /// <returns>The response from the DeleteConsoleAuthorizationConfiguration service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Inspects the metadata and active state of an OAuth 2.0 access token or refresh token.
        /// Implements RFC 7662 OAuth 2.0 Token Introspection over a SigV4-authenticated endpoint.
        /// Returns the claims associated with a token issued by AWS Sign-In.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IntrospectOAuth2TokenWithIAM service method.</param>
        /// <returns>The response from the IntrospectOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/IntrospectOAuth2TokenWithIAM">REST API Reference for IntrospectOAuth2TokenWithIAM Operation</seealso>
        IntrospectOAuth2TokenWithIAMResponse IntrospectOAuth2TokenWithIAM(IntrospectOAuth2TokenWithIAMRequest request);
#endif

        /// <summary>
        /// Inspects the metadata and active state of an OAuth 2.0 access token or refresh token.
        /// Implements RFC 7662 OAuth 2.0 Token Introspection over a SigV4-authenticated endpoint.
        /// Returns the claims associated with a token issued by AWS Sign-In.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IntrospectOAuth2TokenWithIAM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the IntrospectOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state HTTP Status Code: 409 Conflict
        /// Used when the request conflicts with the current state of the resource
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state HTTP Status Code: 409 Conflict
        /// Used when the request conflicts with the current state of the resource
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ResourceNotFoundException">
        /// Error thrown when requested resource is not found HTTP Status Code: 404 Not Found
        /// Used when the specified resource does not exist
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state HTTP Status Code: 409 Conflict
        /// Used when the request conflicts with the current state of the resource
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ServiceQuotaExceededException">
        /// Error thrown when service quota is exceeded HTTP Status Code: 402 Payment Required
        /// (used as quota exceeded indicator) Used when the request would cause a service quota
        /// to be exceeded
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ConflictException">
        /// Error thrown when request conflicts with current state HTTP Status Code: 409 Conflict
        /// Used when the request conflicts with the current state of the resource
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ServiceQuotaExceededException">
        /// Error thrown when service quota is exceeded HTTP Status Code: 402 Payment Required
        /// (used as quota exceeded indicator) Used when the request would cause a service quota
        /// to be exceeded
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/PutResourcePermissionStatement">REST API Reference for PutResourcePermissionStatement Operation</seealso>
        Task<PutResourcePermissionStatementResponse> PutResourcePermissionStatementAsync(PutResourcePermissionStatementRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Revokes an OAuth 2.0 refresh token and its associated token chain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeOAuth2TokenWithIAM service method.</param>
        /// <returns>The response from the RevokeOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signin-2023-01-01/RevokeOAuth2TokenWithIAM">REST API Reference for RevokeOAuth2TokenWithIAM Operation</seealso>
        RevokeOAuth2TokenWithIAMResponse RevokeOAuth2TokenWithIAM(RevokeOAuth2TokenWithIAMRequest request);
#endif

        /// <summary>
        /// Revokes an OAuth 2.0 refresh token and its associated token chain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeOAuth2TokenWithIAM service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RevokeOAuth2TokenWithIAM service method, as returned by Signin.</returns>
        /// <exception cref="Amazon.Signin.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.InternalServerException">
        /// The request failed because of an internal server error.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.TooManyRequestsErrorException">
        /// The request failed because you exceeded the request rate limit for this operation.
        /// </exception>
        /// <exception cref="Amazon.Signin.Model.ValidationException">
        /// The request failed because it contains a malformed, missing, or invalid parameter.
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
