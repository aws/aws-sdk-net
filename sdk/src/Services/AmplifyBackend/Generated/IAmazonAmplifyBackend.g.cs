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
using Amazon.AmplifyBackend.Model;

#pragma warning disable CS1570

namespace Amazon.AmplifyBackend
{
    /// <summary>
    /// <para>Interface for accessing AmplifyBackend</para>
    ///
    /// AWS Amplify Admin API
    /// </summary>
    public partial interface IAmazonAmplifyBackend : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAmplifyBackendPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// This operation clones an existing backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloneBackend service method.</param>
        /// <returns>The response from the CloneBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CloneBackend">REST API Reference for CloneBackend Operation</seealso>
        CloneBackendResponse CloneBackend(CloneBackendRequest request);
#endif

        /// <summary>
        /// This operation clones an existing backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CloneBackend service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CloneBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CloneBackend">REST API Reference for CloneBackend Operation</seealso>
        Task<CloneBackendResponse> CloneBackendAsync(CloneBackendRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This operation creates a backend for an Amplify app. Backends are automatically created
        /// at the time of app creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackend service method.</param>
        /// <returns>The response from the CreateBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackend">REST API Reference for CreateBackend Operation</seealso>
        CreateBackendResponse CreateBackend(CreateBackendRequest request);
#endif

        /// <summary>
        /// This operation creates a backend for an Amplify app. Backends are automatically created
        /// at the time of app creation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackend service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackend">REST API Reference for CreateBackend Operation</seealso>
        Task<CreateBackendResponse> CreateBackendAsync(CreateBackendRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAPI service method.</param>
        /// <returns>The response from the CreateBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAPI">REST API Reference for CreateBackendAPI Operation</seealso>
        CreateBackendAPIResponse CreateBackendAPI(CreateBackendAPIRequest request);
#endif

        /// <summary>
        /// Creates a new backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAPI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAPI">REST API Reference for CreateBackendAPI Operation</seealso>
        Task<CreateBackendAPIResponse> CreateBackendAPIAsync(CreateBackendAPIRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAuth service method.</param>
        /// <returns>The response from the CreateBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAuth">REST API Reference for CreateBackendAuth Operation</seealso>
        CreateBackendAuthResponse CreateBackendAuth(CreateBackendAuthRequest request);
#endif

        /// <summary>
        /// Creates a new backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendAuth">REST API Reference for CreateBackendAuth Operation</seealso>
        Task<CreateBackendAuthResponse> CreateBackendAuthAsync(CreateBackendAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a config object for a backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendConfig service method.</param>
        /// <returns>The response from the CreateBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendConfig">REST API Reference for CreateBackendConfig Operation</seealso>
        CreateBackendConfigResponse CreateBackendConfig(CreateBackendConfigRequest request);
#endif

        /// <summary>
        /// Creates a config object for a backend.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendConfig">REST API Reference for CreateBackendConfig Operation</seealso>
        Task<CreateBackendConfigResponse> CreateBackendConfigAsync(CreateBackendConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendStorage service method.</param>
        /// <returns>The response from the CreateBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendStorage">REST API Reference for CreateBackendStorage Operation</seealso>
        CreateBackendStorageResponse CreateBackendStorage(CreateBackendStorageRequest request);
#endif

        /// <summary>
        /// Creates a backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackendStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateBackendStorage">REST API Reference for CreateBackendStorage Operation</seealso>
        Task<CreateBackendStorageResponse> CreateBackendStorageAsync(CreateBackendStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Generates a one-time challenge code to authenticate a user into your Amplify Admin
        /// UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// <returns>The response from the CreateToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateToken">REST API Reference for CreateToken Operation</seealso>
        CreateTokenResponse CreateToken(CreateTokenRequest request);
#endif

        /// <summary>
        /// Generates a one-time challenge code to authenticate a user into your Amplify Admin
        /// UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/CreateToken">REST API Reference for CreateToken Operation</seealso>
        Task<CreateTokenResponse> CreateTokenAsync(CreateTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes an existing environment from your Amplify project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackend service method.</param>
        /// <returns>The response from the DeleteBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackend">REST API Reference for DeleteBackend Operation</seealso>
        DeleteBackendResponse DeleteBackend(DeleteBackendRequest request);
#endif

        /// <summary>
        /// Removes an existing environment from your Amplify project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackend service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackend">REST API Reference for DeleteBackend Operation</seealso>
        Task<DeleteBackendResponse> DeleteBackendAsync(DeleteBackendRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAPI service method.</param>
        /// <returns>The response from the DeleteBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAPI">REST API Reference for DeleteBackendAPI Operation</seealso>
        DeleteBackendAPIResponse DeleteBackendAPI(DeleteBackendAPIRequest request);
#endif

        /// <summary>
        /// Deletes an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAPI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAPI">REST API Reference for DeleteBackendAPI Operation</seealso>
        Task<DeleteBackendAPIResponse> DeleteBackendAPIAsync(DeleteBackendAPIRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAuth service method.</param>
        /// <returns>The response from the DeleteBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAuth">REST API Reference for DeleteBackendAuth Operation</seealso>
        DeleteBackendAuthResponse DeleteBackendAuth(DeleteBackendAuthRequest request);
#endif

        /// <summary>
        /// Deletes an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendAuth">REST API Reference for DeleteBackendAuth Operation</seealso>
        Task<DeleteBackendAuthResponse> DeleteBackendAuthAsync(DeleteBackendAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes the specified backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendStorage service method.</param>
        /// <returns>The response from the DeleteBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendStorage">REST API Reference for DeleteBackendStorage Operation</seealso>
        DeleteBackendStorageResponse DeleteBackendStorage(DeleteBackendStorageRequest request);
#endif

        /// <summary>
        /// Removes the specified backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackendStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteBackendStorage">REST API Reference for DeleteBackendStorage Operation</seealso>
        Task<DeleteBackendStorageResponse> DeleteBackendStorageAsync(DeleteBackendStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the challenge token based on the given appId and sessionId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken service method.</param>
        /// <returns>The response from the DeleteToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        DeleteTokenResponse DeleteToken(DeleteTokenRequest request);
#endif

        /// <summary>
        /// Deletes the challenge token based on the given appId and sessionId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/DeleteToken">REST API Reference for DeleteToken Operation</seealso>
        Task<DeleteTokenResponse> DeleteTokenAsync(DeleteTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Generates a model schema for an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateBackendAPIModels service method.</param>
        /// <returns>The response from the GenerateBackendAPIModels service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GenerateBackendAPIModels">REST API Reference for GenerateBackendAPIModels Operation</seealso>
        GenerateBackendAPIModelsResponse GenerateBackendAPIModels(GenerateBackendAPIModelsRequest request);
#endif

        /// <summary>
        /// Generates a model schema for an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateBackendAPIModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GenerateBackendAPIModels service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GenerateBackendAPIModels">REST API Reference for GenerateBackendAPIModels Operation</seealso>
        Task<GenerateBackendAPIModelsResponse> GenerateBackendAPIModelsAsync(GenerateBackendAPIModelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Provides project-level details for your Amplify UI project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackend service method.</param>
        /// <returns>The response from the GetBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackend">REST API Reference for GetBackend Operation</seealso>
        GetBackendResponse GetBackend(GetBackendRequest request);
#endif

        /// <summary>
        /// Provides project-level details for your Amplify UI project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackend service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetBackend service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackend">REST API Reference for GetBackend Operation</seealso>
        Task<GetBackendResponse> GetBackendAsync(GetBackendRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets the details for a backend API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPI service method.</param>
        /// <returns>The response from the GetBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPI">REST API Reference for GetBackendAPI Operation</seealso>
        GetBackendAPIResponse GetBackendAPI(GetBackendAPIRequest request);
#endif

        /// <summary>
        /// Gets the details for a backend API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPI">REST API Reference for GetBackendAPI Operation</seealso>
        Task<GetBackendAPIResponse> GetBackendAPIAsync(GetBackendAPIRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets a model introspection schema for an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPIModels service method.</param>
        /// <returns>The response from the GetBackendAPIModels service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPIModels">REST API Reference for GetBackendAPIModels Operation</seealso>
        GetBackendAPIModelsResponse GetBackendAPIModels(GetBackendAPIModelsRequest request);
#endif

        /// <summary>
        /// Gets a model introspection schema for an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAPIModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetBackendAPIModels service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAPIModels">REST API Reference for GetBackendAPIModels Operation</seealso>
        Task<GetBackendAPIModelsResponse> GetBackendAPIModelsAsync(GetBackendAPIModelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets a backend auth details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAuth service method.</param>
        /// <returns>The response from the GetBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAuth">REST API Reference for GetBackendAuth Operation</seealso>
        GetBackendAuthResponse GetBackendAuth(GetBackendAuthRequest request);
#endif

        /// <summary>
        /// Gets a backend auth details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendAuth">REST API Reference for GetBackendAuth Operation</seealso>
        Task<GetBackendAuthResponse> GetBackendAuthAsync(GetBackendAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns information about a specific job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendJob service method.</param>
        /// <returns>The response from the GetBackendJob service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendJob">REST API Reference for GetBackendJob Operation</seealso>
        GetBackendJobResponse GetBackendJob(GetBackendJobRequest request);
#endif

        /// <summary>
        /// Returns information about a specific job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetBackendJob service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendJob">REST API Reference for GetBackendJob Operation</seealso>
        Task<GetBackendJobResponse> GetBackendJobAsync(GetBackendJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets details for a backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendStorage service method.</param>
        /// <returns>The response from the GetBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendStorage">REST API Reference for GetBackendStorage Operation</seealso>
        GetBackendStorageResponse GetBackendStorage(GetBackendStorageRequest request);
#endif

        /// <summary>
        /// Gets details for a backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBackendStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetBackendStorage">REST API Reference for GetBackendStorage Operation</seealso>
        Task<GetBackendStorageResponse> GetBackendStorageAsync(GetBackendStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets the challenge token based on the given appId and sessionId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetToken service method.</param>
        /// <returns>The response from the GetToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetToken">REST API Reference for GetToken Operation</seealso>
        GetTokenResponse GetToken(GetTokenRequest request);
#endif

        /// <summary>
        /// Gets the challenge token based on the given appId and sessionId.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetToken service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/GetToken">REST API Reference for GetToken Operation</seealso>
        Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Imports an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendAuth service method.</param>
        /// <returns>The response from the ImportBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendAuth">REST API Reference for ImportBackendAuth Operation</seealso>
        ImportBackendAuthResponse ImportBackendAuth(ImportBackendAuthRequest request);
#endif

        /// <summary>
        /// Imports an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ImportBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendAuth">REST API Reference for ImportBackendAuth Operation</seealso>
        Task<ImportBackendAuthResponse> ImportBackendAuthAsync(ImportBackendAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Imports an existing backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendStorage service method.</param>
        /// <returns>The response from the ImportBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendStorage">REST API Reference for ImportBackendStorage Operation</seealso>
        ImportBackendStorageResponse ImportBackendStorage(ImportBackendStorageRequest request);
#endif

        /// <summary>
        /// Imports an existing backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportBackendStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ImportBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ImportBackendStorage">REST API Reference for ImportBackendStorage Operation</seealso>
        Task<ImportBackendStorageResponse> ImportBackendStorageAsync(ImportBackendStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the jobs for the backend of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackendJobs service method.</param>
        /// <returns>The response from the ListBackendJobs service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListBackendJobs">REST API Reference for ListBackendJobs Operation</seealso>
        ListBackendJobsResponse ListBackendJobs(ListBackendJobsRequest request);
#endif

        /// <summary>
        /// Lists the jobs for the backend of an Amplify app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBackendJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListBackendJobs service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListBackendJobs">REST API Reference for ListBackendJobs Operation</seealso>
        Task<ListBackendJobsResponse> ListBackendJobsAsync(ListBackendJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The list of S3 buckets in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3Buckets service method.</param>
        /// <returns>The response from the ListS3Buckets service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListS3Buckets">REST API Reference for ListS3Buckets Operation</seealso>
        ListS3BucketsResponse ListS3Buckets(ListS3BucketsRequest request);
#endif

        /// <summary>
        /// The list of S3 buckets in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListS3Buckets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListS3Buckets service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/ListS3Buckets">REST API Reference for ListS3Buckets Operation</seealso>
        Task<ListS3BucketsResponse> ListS3BucketsAsync(ListS3BucketsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes all backend environments from your Amplify project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllBackends service method.</param>
        /// <returns>The response from the RemoveAllBackends service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveAllBackends">REST API Reference for RemoveAllBackends Operation</seealso>
        RemoveAllBackendsResponse RemoveAllBackends(RemoveAllBackendsRequest request);
#endif

        /// <summary>
        /// Removes all backend environments from your Amplify project.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAllBackends service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RemoveAllBackends service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveAllBackends">REST API Reference for RemoveAllBackends Operation</seealso>
        Task<RemoveAllBackendsResponse> RemoveAllBackendsAsync(RemoveAllBackendsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes the AWS resources required to access the Amplify Admin UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveBackendConfig service method.</param>
        /// <returns>The response from the RemoveBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveBackendConfig">REST API Reference for RemoveBackendConfig Operation</seealso>
        RemoveBackendConfigResponse RemoveBackendConfig(RemoveBackendConfigRequest request);
#endif

        /// <summary>
        /// Removes the AWS resources required to access the Amplify Admin UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveBackendConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RemoveBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/RemoveBackendConfig">REST API Reference for RemoveBackendConfig Operation</seealso>
        Task<RemoveBackendConfigResponse> RemoveBackendConfigAsync(RemoveBackendConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAPI service method.</param>
        /// <returns>The response from the UpdateBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAPI">REST API Reference for UpdateBackendAPI Operation</seealso>
        UpdateBackendAPIResponse UpdateBackendAPI(UpdateBackendAPIRequest request);
#endif

        /// <summary>
        /// Updates an existing backend API resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAPI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateBackendAPI service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAPI">REST API Reference for UpdateBackendAPI Operation</seealso>
        Task<UpdateBackendAPIResponse> UpdateBackendAPIAsync(UpdateBackendAPIRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAuth service method.</param>
        /// <returns>The response from the UpdateBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAuth">REST API Reference for UpdateBackendAuth Operation</seealso>
        UpdateBackendAuthResponse UpdateBackendAuth(UpdateBackendAuthRequest request);
#endif

        /// <summary>
        /// Updates an existing backend authentication resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendAuth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateBackendAuth service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendAuth">REST API Reference for UpdateBackendAuth Operation</seealso>
        Task<UpdateBackendAuthResponse> UpdateBackendAuthAsync(UpdateBackendAuthRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the AWS resources required to access the Amplify Admin UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendConfig service method.</param>
        /// <returns>The response from the UpdateBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendConfig">REST API Reference for UpdateBackendConfig Operation</seealso>
        UpdateBackendConfigResponse UpdateBackendConfig(UpdateBackendConfigRequest request);
#endif

        /// <summary>
        /// Updates the AWS resources required to access the Amplify Admin UI.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateBackendConfig service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendConfig">REST API Reference for UpdateBackendConfig Operation</seealso>
        Task<UpdateBackendConfigResponse> UpdateBackendConfigAsync(UpdateBackendConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a specific job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendJob service method.</param>
        /// <returns>The response from the UpdateBackendJob service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendJob">REST API Reference for UpdateBackendJob Operation</seealso>
        UpdateBackendJobResponse UpdateBackendJob(UpdateBackendJobRequest request);
#endif

        /// <summary>
        /// Updates a specific job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateBackendJob service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendJob">REST API Reference for UpdateBackendJob Operation</seealso>
        Task<UpdateBackendJobResponse> UpdateBackendJobAsync(UpdateBackendJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendStorage service method.</param>
        /// <returns>The response from the UpdateBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendStorage">REST API Reference for UpdateBackendStorage Operation</seealso>
        UpdateBackendStorageResponse UpdateBackendStorage(UpdateBackendStorageRequest request);
#endif

        /// <summary>
        /// Updates an existing backend storage resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBackendStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateBackendStorage service method, as returned by AmplifyBackend.</returns>
        /// <exception cref="Amazon.AmplifyBackend.Model.BadRequestException">
        /// An error returned if a request is not formed properly.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.GatewayTimeoutException">
        /// An error returned if there's a temporary issue with the service.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.NotFoundException">
        /// An error returned when a specific resource type is not found.
        /// </exception>
        /// <exception cref="Amazon.AmplifyBackend.Model.TooManyRequestsException">
        /// An error that is returned when a limit of a specific type has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amplifybackend-2020-08-11/UpdateBackendStorage">REST API Reference for UpdateBackendStorage Operation</seealso>
        Task<UpdateBackendStorageResponse> UpdateBackendStorageAsync(UpdateBackendStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAmplifyBackendConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAmplifyBackendConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAmplifyBackendConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAmplifyBackendConfig to create AmazonAmplifyBackendClient");
            }

            return awsCredentials == null ?
                    new AmazonAmplifyBackendClient(serviceClientConfig) :
                    new AmazonAmplifyBackendClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
