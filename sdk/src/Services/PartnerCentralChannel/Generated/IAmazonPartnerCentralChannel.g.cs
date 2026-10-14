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
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPartnerCentralChannelPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Accepts a pending channel handshake request from another AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptChannelHandshake service method.</param>
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
        AcceptChannelHandshakeResponse AcceptChannelHandshake(AcceptChannelHandshakeRequest request);
#endif

        /// <summary>
        /// Accepts a pending channel handshake request from another AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptChannelHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AcceptChannelHandshakeResponse> AcceptChannelHandshakeAsync(AcceptChannelHandshakeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Cancels a pending channel handshake request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelChannelHandshake service method.</param>
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
        CancelChannelHandshakeResponse CancelChannelHandshake(CancelChannelHandshakeRequest request);
#endif

        /// <summary>
        /// Cancels a pending channel handshake request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelChannelHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CancelChannelHandshakeResponse> CancelChannelHandshakeAsync(CancelChannelHandshakeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new channel handshake request to establish a partnership with another AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelHandshake service method.</param>
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
        CreateChannelHandshakeResponse CreateChannelHandshake(CreateChannelHandshakeRequest request);
#endif

        /// <summary>
        /// Creates a new channel handshake request to establish a partnership with another AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateChannelHandshakeResponse> CreateChannelHandshakeAsync(CreateChannelHandshakeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new program management account for managing partner relationships.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgramManagementAccount service method.</param>
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
        CreateProgramManagementAccountResponse CreateProgramManagementAccount(CreateProgramManagementAccountRequest request);
#endif

        /// <summary>
        /// Creates a new program management account for managing partner relationships.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProgramManagementAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateProgramManagementAccountResponse> CreateProgramManagementAccountAsync(CreateProgramManagementAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new partner relationship between accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationship service method.</param>
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
        CreateRelationshipResponse CreateRelationship(CreateRelationshipRequest request);
#endif

        /// <summary>
        /// Creates a new partner relationship between accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateRelationshipResponse> CreateRelationshipAsync(CreateRelationshipRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a program management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgramManagementAccount service method.</param>
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
        DeleteProgramManagementAccountResponse DeleteProgramManagementAccount(DeleteProgramManagementAccountRequest request);
#endif

        /// <summary>
        /// Deletes a program management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProgramManagementAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteProgramManagementAccountResponse> DeleteProgramManagementAccountAsync(DeleteProgramManagementAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationship service method.</param>
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
        DeleteRelationshipResponse DeleteRelationship(DeleteRelationshipRequest request);
#endif

        /// <summary>
        /// Deletes a partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteRelationshipResponse> DeleteRelationshipAsync(DeleteRelationshipRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves details of a specific partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationship service method.</param>
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
        GetRelationshipResponse GetRelationship(GetRelationshipRequest request);
#endif

        /// <summary>
        /// Retrieves details of a specific partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetRelationshipResponse> GetRelationshipAsync(GetRelationshipRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists channel handshakes based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelHandshakes service method.</param>
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
        ListChannelHandshakesResponse ListChannelHandshakes(ListChannelHandshakesRequest request);
#endif

        /// <summary>
        /// Lists channel handshakes based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelHandshakes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListChannelHandshakesResponse> ListChannelHandshakesAsync(ListChannelHandshakesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists program management accounts based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProgramManagementAccounts service method.</param>
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
        ListProgramManagementAccountsResponse ListProgramManagementAccounts(ListProgramManagementAccountsRequest request);
#endif

        /// <summary>
        /// Lists program management accounts based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProgramManagementAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListProgramManagementAccountsResponse> ListProgramManagementAccountsAsync(ListProgramManagementAccountsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists partner relationships based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelationships service method.</param>
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
        ListRelationshipsResponse ListRelationships(ListRelationshipsRequest request);
#endif

        /// <summary>
        /// Lists partner relationships based on specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelationships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListRelationshipsResponse> ListRelationshipsAsync(ListRelationshipsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists tags associated with a specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Lists tags associated with a specific resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Rejects a pending channel handshake request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectChannelHandshake service method.</param>
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
        RejectChannelHandshakeResponse RejectChannelHandshake(RejectChannelHandshakeRequest request);
#endif

        /// <summary>
        /// Rejects a pending channel handshake request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectChannelHandshake service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<RejectChannelHandshakeResponse> RejectChannelHandshakeAsync(RejectChannelHandshakeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds or updates tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds or updates tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the properties of a program management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgramManagementAccount service method.</param>
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
        UpdateProgramManagementAccountResponse UpdateProgramManagementAccount(UpdateProgramManagementAccountRequest request);
#endif

        /// <summary>
        /// Updates the properties of a program management account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProgramManagementAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateProgramManagementAccountResponse> UpdateProgramManagementAccountAsync(UpdateProgramManagementAccountRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the properties of a partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationship service method.</param>
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
        UpdateRelationshipResponse UpdateRelationship(UpdateRelationshipRequest request);
#endif

        /// <summary>
        /// Updates the properties of a partner relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRelationship service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateRelationshipResponse> UpdateRelationshipAsync(UpdateRelationshipRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonPartnerCentralChannelConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonPartnerCentralChannelConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonPartnerCentralChannelConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonPartnerCentralChannelConfig to create AmazonPartnerCentralChannelClient");
            }

            return awsCredentials == null ?
                    new AmazonPartnerCentralChannelClient(serviceClientConfig) :
                    new AmazonPartnerCentralChannelClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
