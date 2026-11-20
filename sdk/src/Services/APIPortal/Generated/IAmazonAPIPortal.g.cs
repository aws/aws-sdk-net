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
using Amazon.APIPortal.Model;

#pragma warning disable CS1570

namespace Amazon.APIPortal
{
    /// <summary>
    /// <para>Interface for accessing APIPortal</para>
    ///
    /// API Portal discovers the APIs running in your AWS accounts and organization, lets
    /// you manage them as Managed APIs, and publishes their documentation to developer portals.
    /// </summary>
    public partial interface IAmazonAPIPortal : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IAPIPortalPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Associate one or more Managed APIs with a product. Best-effort — IDs that fail are
        /// returned in {@link AssociateManagedApisResponse#failedItems}; IDs that succeed are
        /// omitted. Associating an already-associated Managed API is a no-op (not reported as
        /// failure).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedApis service method.</param>
        /// <returns>The response from the AssociateManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/AssociateManagedApis">REST API Reference for AssociateManagedApis Operation</seealso>
        AssociateManagedApisResponse AssociateManagedApis(AssociateManagedApisRequest request);
#endif

        /// <summary>
        /// Associate one or more Managed APIs with a product. Best-effort — IDs that fail are
        /// returned in {@link AssociateManagedApisResponse#failedItems}; IDs that succeed are
        /// omitted. Associating an already-associated Managed API is a no-op (not reported as
        /// failure).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateManagedApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/AssociateManagedApis">REST API Reference for AssociateManagedApis Operation</seealso>
        Task<AssociateManagedApisResponse> AssociateManagedApisAsync(AssociateManagedApisRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Promote a discovered API in the API inventory into the managed API list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedApi service method.</param>
        /// <returns>The response from the CreateManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateManagedApi">REST API Reference for CreateManagedApi Operation</seealso>
        CreateManagedApiResponse CreateManagedApi(CreateManagedApiRequest request);
#endif

        /// <summary>
        /// Promote a discovered API in the API inventory into the managed API list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateManagedApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateManagedApi">REST API Reference for CreateManagedApi Operation</seealso>
        Task<CreateManagedApiResponse> CreateManagedApiAsync(CreateManagedApiRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a portal that publishes documentation for the products it includes. Use UpdatePortalPublishStatus
        /// to publish it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// <returns>The response from the CreatePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        CreatePortalResponse CreatePortal(CreatePortalRequest request);
#endif

        /// <summary>
        /// Creates a portal that publishes documentation for the products it includes. Use UpdatePortalPublishStatus
        /// to publish it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreatePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreatePortal">REST API Reference for CreatePortal Operation</seealso>
        Task<CreatePortalResponse> CreatePortalAsync(CreatePortalRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts building a preview of the portal's current content. Use GetPortal to check
        /// the preview status and get the preview URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortalPreview service method.</param>
        /// <returns>The response from the CreatePortalPreview service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreatePortalPreview">REST API Reference for CreatePortalPreview Operation</seealso>
        CreatePortalPreviewResponse CreatePortalPreview(CreatePortalPreviewRequest request);
#endif

        /// <summary>
        /// Starts building a preview of the portal's current content. Use GetPortal to check
        /// the preview status and get the preview URL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePortalPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreatePortalPreview service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreatePortalPreview">REST API Reference for CreatePortalPreview Operation</seealso>
        Task<CreatePortalPreviewResponse> CreatePortalPreviewAsync(CreatePortalPreviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a product. A product groups Managed APIs with their API pages and product
        /// pages so a portal can publish them together.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct service method.</param>
        /// <returns>The response from the CreateProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        CreateProductResponse CreateProduct(CreateProductRequest request);
#endif

        /// <summary>
        /// Creates a product. A product groups Managed APIs with their API pages and product
        /// pages so a portal can publish them together.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProduct">REST API Reference for CreateProduct Operation</seealso>
        Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates an API page that documents a Managed API in a product. The page content is
        /// generated asynchronously. Use `status` to track it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductApiPage service method.</param>
        /// <returns>The response from the CreateProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProductApiPage">REST API Reference for CreateProductApiPage Operation</seealso>
        CreateProductApiPageResponse CreateProductApiPage(CreateProductApiPageRequest request);
#endif

        /// <summary>
        /// Creates an API page that documents a Managed API in a product. The page content is
        /// generated asynchronously. Use `status` to track it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductApiPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProductApiPage">REST API Reference for CreateProductApiPage Operation</seealso>
        Task<CreateProductApiPageResponse> CreateProductApiPageAsync(CreateProductApiPageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a product page with free-form documentation. A product can have up to 40 pages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductPage service method.</param>
        /// <returns>The response from the CreateProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProductPage">REST API Reference for CreateProductPage Operation</seealso>
        CreateProductPageResponse CreateProductPage(CreateProductPageRequest request);
#endif

        /// <summary>
        /// Creates a product page with free-form documentation. A product can have up to 40 pages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/CreateProductPage">REST API Reference for CreateProductPage Operation</seealso>
        Task<CreateProductPageResponse> CreateProductPageAsync(CreateProductPageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the discovery configuration and stops any running discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoveryConfiguration service method.</param>
        /// <returns>The response from the DeleteDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteDiscoveryConfiguration">REST API Reference for DeleteDiscoveryConfiguration Operation</seealso>
        DeleteDiscoveryConfigurationResponse DeleteDiscoveryConfiguration(DeleteDiscoveryConfigurationRequest request);
#endif

        /// <summary>
        /// Deletes the discovery configuration and stops any running discovery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteDiscoveryConfiguration">REST API Reference for DeleteDiscoveryConfiguration Operation</seealso>
        Task<DeleteDiscoveryConfigurationResponse> DeleteDiscoveryConfigurationAsync(DeleteDiscoveryConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a Managed API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedApi service method.</param>
        /// <returns>The response from the DeleteManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteManagedApi">REST API Reference for DeleteManagedApi Operation</seealso>
        DeleteManagedApiResponse DeleteManagedApi(DeleteManagedApiRequest request);
#endif

        /// <summary>
        /// Deletes a Managed API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteManagedApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteManagedApi">REST API Reference for DeleteManagedApi Operation</seealso>
        Task<DeleteManagedApiResponse> DeleteManagedApiAsync(DeleteManagedApiRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the organization-wide discovery configuration and stops any running discovery
        /// across the organization. Only the organization management account may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationDiscoveryConfiguration service method.</param>
        /// <returns>The response from the DeleteOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteOrganizationDiscoveryConfiguration">REST API Reference for DeleteOrganizationDiscoveryConfiguration Operation</seealso>
        DeleteOrganizationDiscoveryConfigurationResponse DeleteOrganizationDiscoveryConfiguration(DeleteOrganizationDiscoveryConfigurationRequest request);
#endif

        /// <summary>
        /// Deletes the organization-wide discovery configuration and stops any running discovery
        /// across the organization. Only the organization management account may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteOrganizationDiscoveryConfiguration">REST API Reference for DeleteOrganizationDiscoveryConfiguration Operation</seealso>
        Task<DeleteOrganizationDiscoveryConfigurationResponse> DeleteOrganizationDiscoveryConfigurationAsync(DeleteOrganizationDiscoveryConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// <returns>The response from the DeletePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        DeletePortalResponse DeletePortal(DeletePortalRequest request);
#endif

        /// <summary>
        /// Deletes a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeletePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeletePortal">REST API Reference for DeletePortal Operation</seealso>
        Task<DeletePortalResponse> DeletePortalAsync(DeletePortalRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct service method.</param>
        /// <returns>The response from the DeleteProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        DeleteProductResponse DeleteProduct(DeleteProductRequest request);
#endif

        /// <summary>
        /// Deletes a product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProduct">REST API Reference for DeleteProduct Operation</seealso>
        Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an API page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductApiPage service method.</param>
        /// <returns>The response from the DeleteProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductApiPage">REST API Reference for DeleteProductApiPage Operation</seealso>
        DeleteProductApiPageResponse DeleteProductApiPage(DeleteProductApiPageRequest request);
#endif

        /// <summary>
        /// Deletes an API page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductApiPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductApiPage">REST API Reference for DeleteProductApiPage Operation</seealso>
        Task<DeleteProductApiPageResponse> DeleteProductApiPageAsync(DeleteProductApiPageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a product page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductPage service method.</param>
        /// <returns>The response from the DeleteProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductPage">REST API Reference for DeleteProductPage Operation</seealso>
        DeleteProductPageResponse DeleteProductPage(DeleteProductPageRequest request);
#endif

        /// <summary>
        /// Deletes a product page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductPage">REST API Reference for DeleteProductPage Operation</seealso>
        Task<DeleteProductPageResponse> DeleteProductPageAsync(DeleteProductPageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes the sharing policy of a product. The product is no longer shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductSharingPolicy service method.</param>
        /// <returns>The response from the DeleteProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductSharingPolicy">REST API Reference for DeleteProductSharingPolicy Operation</seealso>
        DeleteProductSharingPolicyResponse DeleteProductSharingPolicy(DeleteProductSharingPolicyRequest request);
#endif

        /// <summary>
        /// Deletes the sharing policy of a product. The product is no longer shared.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProductSharingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DeleteProductSharingPolicy">REST API Reference for DeleteProductSharingPolicy Operation</seealso>
        Task<DeleteProductSharingPolicyResponse> DeleteProductSharingPolicyAsync(DeleteProductSharingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disassociate one or more Managed APIs from a product. Best-effort — IDs that fail
        /// are returned in {@link DisassociateManagedApisResponse#failedItems}; IDs that succeed
        /// are omitted. Disassociating an unmapped Managed API is a no-op (not reported as failure).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedApis service method.</param>
        /// <returns>The response from the DisassociateManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DisassociateManagedApis">REST API Reference for DisassociateManagedApis Operation</seealso>
        DisassociateManagedApisResponse DisassociateManagedApis(DisassociateManagedApisRequest request);
#endif

        /// <summary>
        /// Disassociate one or more Managed APIs from a product. Best-effort — IDs that fail
        /// are returned in {@link DisassociateManagedApisResponse#failedItems}; IDs that succeed
        /// are omitted. Disassociating an unmapped Managed API is a no-op (not reported as failure).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateManagedApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/DisassociateManagedApis">REST API Reference for DisassociateManagedApis Operation</seealso>
        Task<DisassociateManagedApisResponse> DisassociateManagedApisAsync(DisassociateManagedApisRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Gets full details of a single API inventory item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiInventoryItem service method.</param>
        /// <returns>The response from the GetApiInventoryItem service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetApiInventoryItem">REST API Reference for GetApiInventoryItem Operation</seealso>
        GetApiInventoryItemResponse GetApiInventoryItem(GetApiInventoryItemRequest request);
#endif

        /// <summary>
        /// Gets full details of a single API inventory item.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApiInventoryItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetApiInventoryItem service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetApiInventoryItem">REST API Reference for GetApiInventoryItem Operation</seealso>
        Task<GetApiInventoryItemResponse> GetApiInventoryItemAsync(GetApiInventoryItemRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the discovery configuration for the account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveryConfiguration service method.</param>
        /// <returns>The response from the GetDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetDiscoveryConfiguration">REST API Reference for GetDiscoveryConfiguration Operation</seealso>
        GetDiscoveryConfigurationResponse GetDiscoveryConfiguration(GetDiscoveryConfigurationRequest request);
#endif

        /// <summary>
        /// Retrieves the discovery configuration for the account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetDiscoveryConfiguration">REST API Reference for GetDiscoveryConfiguration Operation</seealso>
        Task<GetDiscoveryConfigurationResponse> GetDiscoveryConfigurationAsync(GetDiscoveryConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a Managed API, including its security posture findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedApi service method.</param>
        /// <returns>The response from the GetManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetManagedApi">REST API Reference for GetManagedApi Operation</seealso>
        GetManagedApiResponse GetManagedApi(GetManagedApiRequest request);
#endif

        /// <summary>
        /// Returns a Managed API, including its security posture findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedApi service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetManagedApi service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetManagedApi">REST API Reference for GetManagedApi Operation</seealso>
        Task<GetManagedApiResponse> GetManagedApiAsync(GetManagedApiRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the organization-wide discovery configuration. Only the organization management
        /// account and registered delegated administrators may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationDiscoveryConfiguration service method.</param>
        /// <returns>The response from the GetOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetOrganizationDiscoveryConfiguration">REST API Reference for GetOrganizationDiscoveryConfiguration Operation</seealso>
        GetOrganizationDiscoveryConfigurationResponse GetOrganizationDiscoveryConfiguration(GetOrganizationDiscoveryConfigurationRequest request);
#endif

        /// <summary>
        /// Retrieves the organization-wide discovery configuration. Only the organization management
        /// account and registered delegated administrators may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetOrganizationDiscoveryConfiguration">REST API Reference for GetOrganizationDiscoveryConfiguration Operation</seealso>
        Task<GetOrganizationDiscoveryConfigurationResponse> GetOrganizationDiscoveryConfigurationAsync(GetOrganizationDiscoveryConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns the configuration, publish status, and preview status of a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// <returns>The response from the GetPortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetPortal">REST API Reference for GetPortal Operation</seealso>
        GetPortalResponse GetPortal(GetPortalRequest request);
#endif

        /// <summary>
        /// Returns the configuration, publish status, and preview status of a portal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetPortal">REST API Reference for GetPortal Operation</seealso>
        Task<GetPortalResponse> GetPortalAsync(GetPortalRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a product. To read a product shared with you by another account, supply `resourceOwnerAccountId`.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProduct service method.</param>
        /// <returns>The response from the GetProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProduct">REST API Reference for GetProduct Operation</seealso>
        GetProductResponse GetProduct(GetProductRequest request);
#endif

        /// <summary>
        /// Returns a product. To read a product shared with you by another account, supply `resourceOwnerAccountId`.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProduct">REST API Reference for GetProduct Operation</seealso>
        Task<GetProductResponse> GetProductAsync(GetProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns an API page, including its body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductApiPage service method.</param>
        /// <returns>The response from the GetProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductApiPage">REST API Reference for GetProductApiPage Operation</seealso>
        GetProductApiPageResponse GetProductApiPage(GetProductApiPageRequest request);
#endif

        /// <summary>
        /// Returns an API page, including its body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductApiPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductApiPage">REST API Reference for GetProductApiPage Operation</seealso>
        Task<GetProductApiPageResponse> GetProductApiPageAsync(GetProductApiPageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns a product page, including its body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductPage service method.</param>
        /// <returns>The response from the GetProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductPage">REST API Reference for GetProductPage Operation</seealso>
        GetProductPageResponse GetProductPage(GetProductPageRequest request);
#endif

        /// <summary>
        /// Returns a product page, including its body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductPage">REST API Reference for GetProductPage Operation</seealso>
        Task<GetProductPageResponse> GetProductPageAsync(GetProductPageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns the sharing policy of a product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductSharingPolicy service method.</param>
        /// <returns>The response from the GetProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductSharingPolicy">REST API Reference for GetProductSharingPolicy Operation</seealso>
        GetProductSharingPolicyResponse GetProductSharingPolicy(GetProductSharingPolicyRequest request);
#endif

        /// <summary>
        /// Returns the sharing policy of a product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProductSharingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/GetProductSharingPolicy">REST API Reference for GetProductSharingPolicy Operation</seealso>
        Task<GetProductSharingPolicyResponse> GetProductSharingPolicyAsync(GetProductSharingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists discovered API inventory items with filtering and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiInventoryItems service method.</param>
        /// <returns>The response from the ListApiInventoryItems service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListApiInventoryItems">REST API Reference for ListApiInventoryItems Operation</seealso>
        ListApiInventoryItemsResponse ListApiInventoryItems(ListApiInventoryItemsRequest request);
#endif

        /// <summary>
        /// Lists discovered API inventory items with filtering and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApiInventoryItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListApiInventoryItems service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListApiInventoryItems">REST API Reference for ListApiInventoryItems Operation</seealso>
        Task<ListApiInventoryItemsResponse> ListApiInventoryItemsAsync(ListApiInventoryItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists discovery statuses for services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveryStatuses service method.</param>
        /// <returns>The response from the ListDiscoveryStatuses service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListDiscoveryStatuses">REST API Reference for ListDiscoveryStatuses Operation</seealso>
        ListDiscoveryStatusesResponse ListDiscoveryStatuses(ListDiscoveryStatusesRequest request);
#endif

        /// <summary>
        /// Lists discovery statuses for services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveryStatuses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListDiscoveryStatuses service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListDiscoveryStatuses">REST API Reference for ListDiscoveryStatuses Operation</seealso>
        Task<ListDiscoveryStatusesResponse> ListDiscoveryStatusesAsync(ListDiscoveryStatusesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists API-security events for a single managed API, most recent first. Returns up
        /// to 20 of the most recent events (not paginated).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedApiEvents service method.</param>
        /// <returns>The response from the ListManagedApiEvents service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListManagedApiEvents">REST API Reference for ListManagedApiEvents Operation</seealso>
        ListManagedApiEventsResponse ListManagedApiEvents(ListManagedApiEventsRequest request);
#endif

        /// <summary>
        /// Lists API-security events for a single managed API, most recent first. Returns up
        /// to 20 of the most recent events (not paginated).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedApiEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListManagedApiEvents service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListManagedApiEvents">REST API Reference for ListManagedApiEvents Operation</seealso>
        Task<ListManagedApiEventsResponse> ListManagedApiEventsAsync(ListManagedApiEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the Managed APIs in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedApis service method.</param>
        /// <returns>The response from the ListManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListManagedApis">REST API Reference for ListManagedApis Operation</seealso>
        ListManagedApisResponse ListManagedApis(ListManagedApisRequest request);
#endif

        /// <summary>
        /// Lists the Managed APIs in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedApis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListManagedApis service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListManagedApis">REST API Reference for ListManagedApis Operation</seealso>
        Task<ListManagedApisResponse> ListManagedApisAsync(ListManagedApisRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the portals in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// <returns>The response from the ListPortals service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListPortals">REST API Reference for ListPortals Operation</seealso>
        ListPortalsResponse ListPortals(ListPortalsRequest request);
#endif

        /// <summary>
        /// Lists the portals in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPortals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPortals service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListPortals">REST API Reference for ListPortals Operation</seealso>
        Task<ListPortalsResponse> ListPortalsAsync(ListPortalsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the API pages in a product. The results do not include page bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductApiPages service method.</param>
        /// <returns>The response from the ListProductApiPages service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProductApiPages">REST API Reference for ListProductApiPages Operation</seealso>
        ListProductApiPagesResponse ListProductApiPages(ListProductApiPagesRequest request);
#endif

        /// <summary>
        /// Lists the API pages in a product. The results do not include page bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductApiPages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProductApiPages service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProductApiPages">REST API Reference for ListProductApiPages Operation</seealso>
        Task<ListProductApiPagesResponse> ListProductApiPagesAsync(ListProductApiPagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the product pages in a product. The results do not include page bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductPages service method.</param>
        /// <returns>The response from the ListProductPages service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProductPages">REST API Reference for ListProductPages Operation</seealso>
        ListProductPagesResponse ListProductPages(ListProductPagesRequest request);
#endif

        /// <summary>
        /// Lists the product pages in a product. The results do not include page bodies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProductPages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProductPages service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProductPages">REST API Reference for ListProductPages Operation</seealso>
        Task<ListProductPagesResponse> ListProductPagesAsync(ListProductPagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists products you own, products shared with you, or both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProducts service method.</param>
        /// <returns>The response from the ListProducts service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProducts">REST API Reference for ListProducts Operation</seealso>
        ListProductsResponse ListProducts(ListProductsRequest request);
#endif

        /// <summary>
        /// Lists products you own, products shared with you, or both.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProducts service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListProducts">REST API Reference for ListProducts Operation</seealso>
        Task<ListProductsResponse> ListProductsAsync(ListProductsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists the tags for an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Lists the tags for an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates or updates the discovery configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDiscoveryConfiguration service method.</param>
        /// <returns>The response from the PutDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutDiscoveryConfiguration">REST API Reference for PutDiscoveryConfiguration Operation</seealso>
        PutDiscoveryConfigurationResponse PutDiscoveryConfiguration(PutDiscoveryConfigurationRequest request);
#endif

        /// <summary>
        /// Creates or updates the discovery configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutDiscoveryConfiguration">REST API Reference for PutDiscoveryConfiguration Operation</seealso>
        Task<PutDiscoveryConfigurationResponse> PutDiscoveryConfigurationAsync(PutDiscoveryConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates or updates the organization-wide discovery configuration. This is a singleton
        /// per organization. Only the organization management account and registered delegated
        /// administrators may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOrganizationDiscoveryConfiguration service method.</param>
        /// <returns>The response from the PutOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutOrganizationDiscoveryConfiguration">REST API Reference for PutOrganizationDiscoveryConfiguration Operation</seealso>
        PutOrganizationDiscoveryConfigurationResponse PutOrganizationDiscoveryConfiguration(PutOrganizationDiscoveryConfigurationRequest request);
#endif

        /// <summary>
        /// Creates or updates the organization-wide discovery configuration. This is a singleton
        /// per organization. Only the organization management account and registered delegated
        /// administrators may call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOrganizationDiscoveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutOrganizationDiscoveryConfiguration service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutOrganizationDiscoveryConfiguration">REST API Reference for PutOrganizationDiscoveryConfiguration Operation</seealso>
        Task<PutOrganizationDiscoveryConfigurationResponse> PutOrganizationDiscoveryConfigurationAsync(PutOrganizationDiscoveryConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates or replaces the sharing policy of a product. The policy controls which other
        /// accounts can read the product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProductSharingPolicy service method.</param>
        /// <returns>The response from the PutProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutProductSharingPolicy">REST API Reference for PutProductSharingPolicy Operation</seealso>
        PutProductSharingPolicyResponse PutProductSharingPolicy(PutProductSharingPolicyRequest request);
#endif

        /// <summary>
        /// Creates or replaces the sharing policy of a product. The policy controls which other
        /// accounts can read the product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProductSharingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutProductSharingPolicy service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/PutProductSharingPolicy">REST API Reference for PutProductSharingPolicy Operation</seealso>
        Task<PutProductSharingPolicyResponse> PutProductSharingPolicyAsync(PutProductSharingPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts the API discovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscovery service method.</param>
        /// <returns>The response from the StartDiscovery service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/StartDiscovery">REST API Reference for StartDiscovery Operation</seealso>
        StartDiscoveryResponse StartDiscovery(StartDiscoveryRequest request);
#endif

        /// <summary>
        /// Starts the API discovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDiscovery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartDiscovery service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/StartDiscovery">REST API Reference for StartDiscovery Operation</seealso>
        Task<StartDiscoveryResponse> StartDiscoveryAsync(StartDiscoveryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Stops the running API discovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscovery service method.</param>
        /// <returns>The response from the StopDiscovery service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/StopDiscovery">REST API Reference for StopDiscovery Operation</seealso>
        StopDiscoveryResponse StopDiscovery(StopDiscoveryRequest request);
#endif

        /// <summary>
        /// Stops the running API discovery process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopDiscovery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StopDiscovery service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.InternalServerException">
        /// The service encountered an internal error. Try the request again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/StopDiscovery">REST API Reference for StopDiscovery Operation</seealso>
        Task<StopDiscoveryResponse> StopDiscoveryAsync(StopDiscoveryRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds or updates tags on an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds or updates tags on an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes tags from an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// tagKeys is a query string parameter: for tag-based access control (TBAC/ABAC) to work
        /// correctly, API Gateway requires the keys to be removed to be passed as a query string
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes tags from an API Portal resource. One of the three basic tagging operations
        /// generated for Tagris integration (ListTagsForResource / TagResource / UntagResource).
        /// tagKeys is a query string parameter: for tag-based access control (TBAC/ABAC) to work
        /// correctly, API Gateway requires the keys to be removed to be passed as a query string
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a portal. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// <returns>The response from the UpdatePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        UpdatePortalResponse UpdatePortal(UpdatePortalRequest request);
#endif

        /// <summary>
        /// Updates a portal. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdatePortal service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdatePortal">REST API Reference for UpdatePortal Operation</seealso>
        Task<UpdatePortalResponse> UpdatePortalAsync(UpdatePortalRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Publishes or disables a portal. The change runs asynchronously. Use GetPortal to track
        /// `publishStatus`.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortalPublishStatus service method.</param>
        /// <returns>The response from the UpdatePortalPublishStatus service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdatePortalPublishStatus">REST API Reference for UpdatePortalPublishStatus Operation</seealso>
        UpdatePortalPublishStatusResponse UpdatePortalPublishStatus(UpdatePortalPublishStatusRequest request);
#endif

        /// <summary>
        /// Publishes or disables a portal. The change runs asynchronously. Use GetPortal to track
        /// `publishStatus`.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePortalPublishStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdatePortalPublishStatus service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ConflictException">
        /// The request conflicts with the current state of the resource, for example because
        /// another operation on it is still in progress.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdatePortalPublishStatus">REST API Reference for UpdatePortalPublishStatus Operation</seealso>
        Task<UpdatePortalPublishStatusResponse> UpdatePortalPublishStatusAsync(UpdatePortalPublishStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a product. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct service method.</param>
        /// <returns>The response from the UpdateProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        UpdateProductResponse UpdateProduct(UpdateProductRequest request);
#endif

        /// <summary>
        /// Updates a product. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProduct service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProduct">REST API Reference for UpdateProduct Operation</seealso>
        Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an API page. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductApiPage service method.</param>
        /// <returns>The response from the UpdateProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProductApiPage">REST API Reference for UpdateProductApiPage Operation</seealso>
        UpdateProductApiPageResponse UpdateProductApiPage(UpdateProductApiPageRequest request);
#endif

        /// <summary>
        /// Updates an API page. Only the fields supplied in the request are changed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductApiPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProductApiPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProductApiPage">REST API Reference for UpdateProductApiPage Operation</seealso>
        Task<UpdateProductApiPageResponse> UpdateProductApiPageAsync(UpdateProductApiPageRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates a product page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductPage service method.</param>
        /// <returns>The response from the UpdateProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProductPage">REST API Reference for UpdateProductPage Operation</seealso>
        UpdateProductPageResponse UpdateProductPage(UpdateProductPageRequest request);
#endif

        /// <summary>
        /// Updates a product page.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProductPage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProductPage service method, as returned by APIPortal.</returns>
        /// <exception cref="Amazon.APIPortal.Model.AccessDeniedException">
        /// You do not have permission to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.BadRequestException">
        /// The request is not valid. The message identifies the field or value that failed validation.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.LimitExceededException">
        /// The request rate or a service quota was exceeded. Reduce the request rate or the number
        /// of resources and try again.
        /// </exception>
        /// <exception cref="Amazon.APIPortal.Model.ResourceNotFoundException">
        /// The requested resource does not exist, or you do not have access to it.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apiportal-2026-04-30/UpdateProductPage">REST API Reference for UpdateProductPage Operation</seealso>
        Task<UpdateProductPageResponse> UpdateProductPageAsync(UpdateProductPageRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonAPIPortalConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonAPIPortalConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonAPIPortalConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonAPIPortalConfig to create AmazonAPIPortalClient");
            }

            return awsCredentials == null ?
                    new AmazonAPIPortalClient(serviceClientConfig) :
                    new AmazonAPIPortalClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
