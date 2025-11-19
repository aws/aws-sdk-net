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
 * Do not modify this file. This file is generated from the partnercentral-channel-2024-03-18.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PartnerCentralChannel.Model;

#pragma warning disable CS1570
namespace Amazon.PartnerCentralChannel
{
    /// <summary>
    /// <para>Interface for accessing PartnerCentralChannel</para>
    ///
    /// AWS Partner Central Channel service for managing partner relationships, handshakes,
    /// and program management accounts.
    /// </summary>
    public partial interface IAmazonPartnerCentralChannel : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPartnerCentralChannelPaginatorFactory Paginators { get; }
#endif
                
        #region  AcceptChannelHandshake



        /// <summary>
        /// Accepts a pending channel handshake request from another AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptChannelHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/AcceptChannelHandshake">REST API Reference for AcceptChannelHandshake Operation</seealso>
        Task<AcceptChannelHandshakeResponse> AcceptChannelHandshakeAsync(AcceptChannelHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelChannelHandshake



        /// <summary>
        /// Cancels a pending channel handshake request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelChannelHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CancelChannelHandshake">REST API Reference for CancelChannelHandshake Operation</seealso>
        Task<CancelChannelHandshakeResponse> CancelChannelHandshakeAsync(CancelChannelHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateChannelHandshake



        /// <summary>
        /// Creates a new channel handshake request to establish a partnership with another AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateChannelHandshake">REST API Reference for CreateChannelHandshake Operation</seealso>
        Task<CreateChannelHandshakeResponse> CreateChannelHandshakeAsync(CreateChannelHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateProgramManagementAccount



        /// <summary>
        /// Creates a new program management account for managing partner relationships.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgramManagementAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProgramManagementAccount service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateProgramManagementAccount">REST API Reference for CreateProgramManagementAccount Operation</seealso>
        Task<CreateProgramManagementAccountResponse> CreateProgramManagementAccountAsync(CreateProgramManagementAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRelationship



        /// <summary>
        /// Creates a new partner relationship between accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/CreateRelationship">REST API Reference for CreateRelationship Operation</seealso>
        Task<CreateRelationshipResponse> CreateRelationshipAsync(CreateRelationshipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteProgramManagementAccount



        /// <summary>
        /// Deletes a program management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgramManagementAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProgramManagementAccount service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteProgramManagementAccount">REST API Reference for DeleteProgramManagementAccount Operation</seealso>
        Task<DeleteProgramManagementAccountResponse> DeleteProgramManagementAccountAsync(DeleteProgramManagementAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRelationship



        /// <summary>
        /// Deletes a partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/DeleteRelationship">REST API Reference for DeleteRelationship Operation</seealso>
        Task<DeleteRelationshipResponse> DeleteRelationshipAsync(DeleteRelationshipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetRelationship



        /// <summary>
        /// Retrieves details of a specific partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/GetRelationship">REST API Reference for GetRelationship Operation</seealso>
        Task<GetRelationshipResponse> GetRelationshipAsync(GetRelationshipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChannelHandshakes



        /// <summary>
        /// Lists channel handshakes based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelHandshakes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChannelHandshakes service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListChannelHandshakes">REST API Reference for ListChannelHandshakes Operation</seealso>
        Task<ListChannelHandshakesResponse> ListChannelHandshakesAsync(ListChannelHandshakesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListProgramManagementAccounts



        /// <summary>
        /// Lists program management accounts based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProgramManagementAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProgramManagementAccounts service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListProgramManagementAccounts">REST API Reference for ListProgramManagementAccounts Operation</seealso>
        Task<ListProgramManagementAccountsResponse> ListProgramManagementAccountsAsync(ListProgramManagementAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRelationships



        /// <summary>
        /// Lists partner relationships based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelationships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRelationships service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListRelationships">REST API Reference for ListRelationships Operation</seealso>
        Task<ListRelationshipsResponse> ListRelationshipsAsync(ListRelationshipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists tags associated with a specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectChannelHandshake



        /// <summary>
        /// Rejects a pending channel handshake request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectChannelHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectChannelHandshake service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/RejectChannelHandshake">REST API Reference for RejectChannelHandshake Operation</seealso>
        Task<RejectChannelHandshakeResponse> RejectChannelHandshakeAsync(RejectChannelHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or updates tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateProgramManagementAccount



        /// <summary>
        /// Updates the properties of a program management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgramManagementAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProgramManagementAccount service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateProgramManagementAccount">REST API Reference for UpdateProgramManagementAccount Operation</seealso>
        Task<UpdateProgramManagementAccountResponse> UpdateProgramManagementAccountAsync(UpdateProgramManagementAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateRelationship



        /// <summary>
        /// Updates the properties of a partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRelationship service method, as returned by PartnerCentralChannel.</returns>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.InternalServerException">
        /// An internal server error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralChannel.Model.ValidationException">
        /// The request failed validation due to invalid input parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-channel-2024-03-18/UpdateRelationship">REST API Reference for UpdateRelationship Operation</seealso>
        Task<UpdateRelationshipResponse> UpdateRelationshipAsync(UpdateRelationshipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}