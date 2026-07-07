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
 * Do not modify this file. This file is generated from the partnercentral-revenue-measurement-2022-07-26.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PartnerCentralRevenueMeasurement.Model;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralRevenueMeasurement
{
    /// <summary>
    /// <para>Interface for accessing PartnerCentralRevenueMeasurement</para>
    ///
    /// AWS Partner Central Revenue Measurement API for creating, managing, and tracking revenue
    /// attributions and their allocations with deal entities such as offers and opportunities.
    /// </summary>
    public partial interface IAmazonPartnerCentralRevenueMeasurement : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPartnerCentralRevenueMeasurementPaginatorFactory Paginators { get; }
#endif
                
        #region  CreateMarketplaceRevenueShare



        /// <summary>
        /// Creates a new marketplace revenue share resource in the specified catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMarketplaceRevenueShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMarketplaceRevenueShare service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/CreateMarketplaceRevenueShare">REST API Reference for CreateMarketplaceRevenueShare Operation</seealso>
        Task<CreateMarketplaceRevenueShareResponse> CreateMarketplaceRevenueShareAsync(CreateMarketplaceRevenueShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMarketplaceRevenueShareAllocation



        /// <summary>
        /// Creates a new marketplace revenue share allocation for the specified product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMarketplaceRevenueShareAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMarketplaceRevenueShareAllocation service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/CreateMarketplaceRevenueShareAllocation">REST API Reference for CreateMarketplaceRevenueShareAllocation Operation</seealso>
        Task<CreateMarketplaceRevenueShareAllocationResponse> CreateMarketplaceRevenueShareAllocationAsync(CreateMarketplaceRevenueShareAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRevenueAttribution



        /// <summary>
        /// Creates a new revenue attribution record in the specified catalog.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRevenueAttribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRevenueAttribution service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/CreateRevenueAttribution">REST API Reference for CreateRevenueAttribution Operation</seealso>
        Task<CreateRevenueAttributionResponse> CreateRevenueAttributionAsync(CreateRevenueAttributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMarketplaceRevenueShare



        /// <summary>
        /// Retrieves the details of a specific marketplace revenue share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMarketplaceRevenueShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMarketplaceRevenueShare service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/GetMarketplaceRevenueShare">REST API Reference for GetMarketplaceRevenueShare Operation</seealso>
        Task<GetMarketplaceRevenueShareResponse> GetMarketplaceRevenueShareAsync(GetMarketplaceRevenueShareRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMarketplaceRevenueShareAllocation



        /// <summary>
        /// Retrieves the details of a specific marketplace revenue share allocation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMarketplaceRevenueShareAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMarketplaceRevenueShareAllocation service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/GetMarketplaceRevenueShareAllocation">REST API Reference for GetMarketplaceRevenueShareAllocation Operation</seealso>
        Task<GetMarketplaceRevenueShareAllocationResponse> GetMarketplaceRevenueShareAllocationAsync(GetMarketplaceRevenueShareAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRevenueAttribution



        /// <summary>
        /// Retrieves the details of a specific revenue attribution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevenueAttribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevenueAttribution service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/GetRevenueAttribution">REST API Reference for GetRevenueAttribution Operation</seealso>
        Task<GetRevenueAttributionResponse> GetRevenueAttributionAsync(GetRevenueAttributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRevenueAttributionAllocation



        /// <summary>
        /// Retrieves a single allocation by its RevenueAttributionAllocationId. Supports optional
        /// point-in-time version queries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevenueAttributionAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevenueAttributionAllocation service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/GetRevenueAttributionAllocation">REST API Reference for GetRevenueAttributionAllocation Operation</seealso>
        Task<GetRevenueAttributionAllocationResponse> GetRevenueAttributionAllocationAsync(GetRevenueAttributionAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRevenueAttributionAllocationsTask



        /// <summary>
        /// Retrieves the current status of a previously submitted allocations task. When COMPLETE,
        /// includes the latest revision. When FAILED, includes error details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRevenueAttributionAllocationsTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRevenueAttributionAllocationsTask service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/GetRevenueAttributionAllocationsTask">REST API Reference for GetRevenueAttributionAllocationsTask Operation</seealso>
        Task<GetRevenueAttributionAllocationsTaskResponse> GetRevenueAttributionAllocationsTaskAsync(GetRevenueAttributionAllocationsTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMarketplaceRevenueShareAllocations



        /// <summary>
        /// Returns a paginated list of allocations under a marketplace revenue share, with optional
        /// filtering by status and effective date range. Supports historical reads at a specific
        /// share revision.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMarketplaceRevenueShareAllocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMarketplaceRevenueShareAllocations service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/ListMarketplaceRevenueShareAllocations">REST API Reference for ListMarketplaceRevenueShareAllocations Operation</seealso>
        Task<ListMarketplaceRevenueShareAllocationsResponse> ListMarketplaceRevenueShareAllocationsAsync(ListMarketplaceRevenueShareAllocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMarketplaceRevenueShares



        /// <summary>
        /// Returns a paginated list of marketplace revenue shares with optional filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMarketplaceRevenueShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMarketplaceRevenueShares service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/ListMarketplaceRevenueShares">REST API Reference for ListMarketplaceRevenueShares Operation</seealso>
        Task<ListMarketplaceRevenueSharesResponse> ListMarketplaceRevenueSharesAsync(ListMarketplaceRevenueSharesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRevenueAttributionAllocations



        /// <summary>
        /// Returns a paginated list of committed allocations with support for filtering by entity,
        /// customer, status, or date range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRevenueAttributionAllocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRevenueAttributionAllocations service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/ListRevenueAttributionAllocations">REST API Reference for ListRevenueAttributionAllocations Operation</seealso>
        Task<ListRevenueAttributionAllocationsResponse> ListRevenueAttributionAllocationsAsync(ListRevenueAttributionAllocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRevenueAttributions



        /// <summary>
        /// Returns a paginated list of revenue attributions with optional filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRevenueAttributions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRevenueAttributions service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/ListRevenueAttributions">REST API Reference for ListRevenueAttributions Operation</seealso>
        Task<ListRevenueAttributionsResponse> ListRevenueAttributionsAsync(ListRevenueAttributionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Returns the tags associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartRevenueAttributionAllocationsTask



        /// <summary>
        /// Submits a batch of up to 250 allocation changes (CREATE and/or UPDATE) for asynchronous
        /// processing. Returns a TaskId for tracking.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRevenueAttributionAllocationsTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRevenueAttributionAllocationsTask service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/StartRevenueAttributionAllocationsTask">REST API Reference for StartRevenueAttributionAllocationsTask Operation</seealso>
        Task<StartRevenueAttributionAllocationsTaskResponse> StartRevenueAttributionAllocationsTaskAsync(StartRevenueAttributionAllocationsTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or overwrites one or more tags for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateMarketplaceRevenueShareAllocation



        /// <summary>
        /// Updates an existing marketplace revenue share allocation. Supports modifying effective
        /// dates, revenue share percentage, and status with time-based mutability rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMarketplaceRevenueShareAllocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMarketplaceRevenueShareAllocation service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/UpdateMarketplaceRevenueShareAllocation">REST API Reference for UpdateMarketplaceRevenueShareAllocation Operation</seealso>
        Task<UpdateMarketplaceRevenueShareAllocationResponse> UpdateMarketplaceRevenueShareAllocationAsync(UpdateMarketplaceRevenueShareAllocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRevenueAttribution



        /// <summary>
        /// Updates an existing revenue attribution record.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRevenueAttribution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRevenueAttribution service method, as returned by PartnerCentralRevenueMeasurement.</returns>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.InternalServerException">
        /// An internal server error occurred. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralRevenueMeasurement.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-revenue-measurement-2022-07-26/UpdateRevenueAttribution">REST API Reference for UpdateRevenueAttribution Operation</seealso>
        Task<UpdateRevenueAttributionResponse> UpdateRevenueAttributionAsync(UpdateRevenueAttributionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonPartnerCentralRevenueMeasurementConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonPartnerCentralRevenueMeasurementConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonPartnerCentralRevenueMeasurementConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonPartnerCentralRevenueMeasurementConfig to create AmazonPartnerCentralRevenueMeasurementClient");
            }

            return awsCredentials == null ? 
                    new AmazonPartnerCentralRevenueMeasurementClient(serviceClientConfig) :
                    new AmazonPartnerCentralRevenueMeasurementClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}