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
using Amazon.AccountAccessRuntime.Model;

#pragma warning disable CS1570

namespace Amazon.AccountAccessRuntime
{
    /// <summary>
    /// <para>Interface for accessing AccountAccessRuntime</para>
    ///
    /// Use the Account Access Runtime API to list the roles that you can access and retrieve
    /// temporary Amazon Web Services credentials for those roles. You authenticate with a
    /// bearer token from IAM Identity Center. Each request is scoped to a tenant.
    /// </summary>
    public partial interface IAmazonAccountAccessRuntime : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAccountAccessRuntimePaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Returns temporary Amazon Web Services credentials for a role that you are entitled
        /// to assume within a tenant. You can use these credentials for programmatic access with
        /// the CLI or an Amazon Web Services SDK. If you aren't entitled to the role, the request
        /// fails with an <c>AccessDeniedException</c> error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoleCredentials service method.</param>
        /// <returns>The response from the GetRoleCredentials service method, as returned by AccountAccessRuntime.</returns>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.AccessDeniedException">
        /// You are authenticated but not authorized to perform the requested action, such as
        /// assuming a role that you aren't entitled to. This error returns an HTTP 403 status
        /// code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry the request. If the problem persists, contact
        /// Amazon Web Services Support. This error returns an HTTP 500 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Reduce your request rate, and then retry
        /// the request. This error returns an HTTP 429 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.UnauthorizedException">
        /// The bearer token is missing, invalid, or expired. Obtain a new token, and then retry
        /// the request. This error returns an HTTP 401 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ValidationException">
        /// The request is missing a required parameter, or a parameter value doesn't satisfy
        /// its constraints, such as its length or pattern. Correct the input, and then retry
        /// the request. This error returns an HTTP 400 status code.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-runtime-2018-05-10/GetRoleCredentials">REST API Reference for GetRoleCredentials Operation</seealso>
        GetRoleCredentialsResponse GetRoleCredentials(GetRoleCredentialsRequest request);
#endif

        /// <summary>
        /// Returns temporary Amazon Web Services credentials for a role that you are entitled
        /// to assume within a tenant. You can use these credentials for programmatic access with
        /// the CLI or an Amazon Web Services SDK. If you aren't entitled to the role, the request
        /// fails with an <c>AccessDeniedException</c> error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRoleCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetRoleCredentials service method, as returned by AccountAccessRuntime.</returns>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.AccessDeniedException">
        /// You are authenticated but not authorized to perform the requested action, such as
        /// assuming a role that you aren't entitled to. This error returns an HTTP 403 status
        /// code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry the request. If the problem persists, contact
        /// Amazon Web Services Support. This error returns an HTTP 500 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Reduce your request rate, and then retry
        /// the request. This error returns an HTTP 429 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.UnauthorizedException">
        /// The bearer token is missing, invalid, or expired. Obtain a new token, and then retry
        /// the request. This error returns an HTTP 401 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ValidationException">
        /// The request is missing a required parameter, or a parameter value doesn't satisfy
        /// its constraints, such as its length or pattern. Correct the input, and then retry
        /// the request. This error returns an HTTP 400 status code.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-runtime-2018-05-10/GetRoleCredentials">REST API Reference for GetRoleCredentials Operation</seealso>
        Task<GetRoleCredentialsResponse> GetRoleCredentialsAsync(GetRoleCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns the roles that you are entitled to access within a tenant. The results are
        /// paginated. Use a returned role with <c>GetRoleCredentials</c> to obtain temporary
        /// credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// <returns>The response from the ListRoles service method, as returned by AccountAccessRuntime.</returns>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry the request. If the problem persists, contact
        /// Amazon Web Services Support. This error returns an HTTP 500 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Reduce your request rate, and then retry
        /// the request. This error returns an HTTP 429 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.UnauthorizedException">
        /// The bearer token is missing, invalid, or expired. Obtain a new token, and then retry
        /// the request. This error returns an HTTP 401 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ValidationException">
        /// The request is missing a required parameter, or a parameter value doesn't satisfy
        /// its constraints, such as its length or pattern. Correct the input, and then retry
        /// the request. This error returns an HTTP 400 status code.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-runtime-2018-05-10/ListRoles">REST API Reference for ListRoles Operation</seealso>
        ListRolesResponse ListRoles(ListRolesRequest request);
#endif

        /// <summary>
        /// Returns the roles that you are entitled to access within a tenant. The results are
        /// paginated. Use a returned role with <c>GetRoleCredentials</c> to obtain temporary
        /// credentials.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListRoles service method, as returned by AccountAccessRuntime.</returns>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.InternalServerException">
        /// An internal server error occurred. Retry the request. If the problem persists, contact
        /// Amazon Web Services Support. This error returns an HTTP 500 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ThrottlingException">
        /// The request rate exceeded the allowed limit. Reduce your request rate, and then retry
        /// the request. This error returns an HTTP 429 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.UnauthorizedException">
        /// The bearer token is missing, invalid, or expired. Obtain a new token, and then retry
        /// the request. This error returns an HTTP 401 status code.
        /// </exception>
        /// <exception cref="Amazon.AccountAccessRuntime.Model.ValidationException">
        /// The request is missing a required parameter, or a parameter value doesn't satisfy
        /// its constraints, such as its length or pattern. Correct the input, and then retry
        /// the request. This error returns an HTTP 400 status code.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-access-runtime-2018-05-10/ListRoles">REST API Reference for ListRoles Operation</seealso>
        Task<ListRolesResponse> ListRolesAsync(ListRolesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAccountAccessRuntimeConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAccountAccessRuntimeConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAccountAccessRuntimeConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAccountAccessRuntimeConfig to create AmazonAccountAccessRuntimeClient");
            }

            return awsCredentials == null ?
                    new AmazonAccountAccessRuntimeClient(serviceClientConfig) :
                    new AmazonAccountAccessRuntimeClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
