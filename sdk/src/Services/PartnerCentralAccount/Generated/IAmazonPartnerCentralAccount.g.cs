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
using Amazon.PartnerCentralAccount.Model;

#pragma warning disable CS1570

namespace Amazon.PartnerCentralAccount
{
    /// <summary>
    /// <para>Interface for accessing PartnerCentralAccount</para>
    ///
    /// AWS Partner Central Account service provides APIs for managing partner accounts, connections,
    /// and profiles within the AWS Partner Network. This service enables partners to create
    /// and manage their partner profiles, establish connections with other partners, and
    /// maintain their account information.
    /// </summary>
    public partial interface IAmazonPartnerCentralAccount : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPartnerCentralAccountPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Accepts a connection invitation from another partner, establishing a formal partnership
        /// connection between the two parties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptConnectionInvitation service method.</param>
        /// <returns>The response from the AcceptConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AcceptConnectionInvitation">REST API Reference for AcceptConnectionInvitation Operation</seealso>
        AcceptConnectionInvitationResponse AcceptConnectionInvitation(AcceptConnectionInvitationRequest request);
#endif

        /// <summary>
        /// Accepts a connection invitation from another partner, establishing a formal partnership
        /// connection between the two parties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AcceptConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AcceptConnectionInvitation">REST API Reference for AcceptConnectionInvitation Operation</seealso>
        Task<AcceptConnectionInvitationResponse> AcceptConnectionInvitationAsync(AcceptConnectionInvitationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Associates an email domain with AWS training and certification for the partner account,
        /// enabling automatic verification of employee certifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsTrainingCertificationEmailDomain service method.</param>
        /// <returns>The response from the AssociateAwsTrainingCertificationEmailDomain service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AssociateAwsTrainingCertificationEmailDomain">REST API Reference for AssociateAwsTrainingCertificationEmailDomain Operation</seealso>
        AssociateAwsTrainingCertificationEmailDomainResponse AssociateAwsTrainingCertificationEmailDomain(AssociateAwsTrainingCertificationEmailDomainRequest request);
#endif

        /// <summary>
        /// Associates an email domain with AWS training and certification for the partner account,
        /// enabling automatic verification of employee certifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsTrainingCertificationEmailDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateAwsTrainingCertificationEmailDomain service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AssociateAwsTrainingCertificationEmailDomain">REST API Reference for AssociateAwsTrainingCertificationEmailDomain Operation</seealso>
        Task<AssociateAwsTrainingCertificationEmailDomainResponse> AssociateAwsTrainingCertificationEmailDomainAsync(AssociateAwsTrainingCertificationEmailDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Cancels an existing connection between partners, terminating the partnership relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConnection service method.</param>
        /// <returns>The response from the CancelConnection service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelConnection">REST API Reference for CancelConnection Operation</seealso>
        CancelConnectionResponse CancelConnection(CancelConnectionRequest request);
#endif

        /// <summary>
        /// Cancels an existing connection between partners, terminating the partnership relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CancelConnection service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelConnection">REST API Reference for CancelConnection Operation</seealso>
        Task<CancelConnectionResponse> CancelConnectionAsync(CancelConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Cancels a pending connection invitation before it has been accepted or rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConnectionInvitation service method.</param>
        /// <returns>The response from the CancelConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelConnectionInvitation">REST API Reference for CancelConnectionInvitation Operation</seealso>
        CancelConnectionInvitationResponse CancelConnectionInvitation(CancelConnectionInvitationRequest request);
#endif

        /// <summary>
        /// Cancels a pending connection invitation before it has been accepted or rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CancelConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelConnectionInvitation">REST API Reference for CancelConnectionInvitation Operation</seealso>
        Task<CancelConnectionInvitationResponse> CancelConnectionInvitationAsync(CancelConnectionInvitationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Cancels an in-progress profile update task, stopping any pending changes to the partner
        /// profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelProfileUpdateTask service method.</param>
        /// <returns>The response from the CancelProfileUpdateTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelProfileUpdateTask">REST API Reference for CancelProfileUpdateTask Operation</seealso>
        CancelProfileUpdateTaskResponse CancelProfileUpdateTask(CancelProfileUpdateTaskRequest request);
#endif

        /// <summary>
        /// Cancels an in-progress profile update task, stopping any pending changes to the partner
        /// profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelProfileUpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CancelProfileUpdateTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CancelProfileUpdateTask">REST API Reference for CancelProfileUpdateTask Operation</seealso>
        Task<CancelProfileUpdateTaskResponse> CancelProfileUpdateTaskAsync(CancelProfileUpdateTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new connection invitation to establish a partnership with another organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionInvitation service method.</param>
        /// <returns>The response from the CreateConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreateConnectionInvitation">REST API Reference for CreateConnectionInvitation Operation</seealso>
        CreateConnectionInvitationResponse CreateConnectionInvitation(CreateConnectionInvitationRequest request);
#endif

        /// <summary>
        /// Creates a new connection invitation to establish a partnership with another organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreateConnectionInvitation">REST API Reference for CreateConnectionInvitation Operation</seealso>
        Task<CreateConnectionInvitationResponse> CreateConnectionInvitationAsync(CreateConnectionInvitationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new partner account in the AWS Partner Network with the specified details
        /// and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartner service method.</param>
        /// <returns>The response from the CreatePartner service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreatePartner">REST API Reference for CreatePartner Operation</seealso>
        CreatePartnerResponse CreatePartner(CreatePartnerRequest request);
#endif

        /// <summary>
        /// Creates a new partner account in the AWS Partner Network with the specified details
        /// and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartner service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreatePartner service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreatePartner">REST API Reference for CreatePartner Operation</seealso>
        Task<CreatePartnerResponse> CreatePartnerAsync(CreatePartnerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes the association between an email domain and AWS training and certification
        /// for the partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsTrainingCertificationEmailDomain service method.</param>
        /// <returns>The response from the DisassociateAwsTrainingCertificationEmailDomain service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/DisassociateAwsTrainingCertificationEmailDomain">REST API Reference for DisassociateAwsTrainingCertificationEmailDomain Operation</seealso>
        DisassociateAwsTrainingCertificationEmailDomainResponse DisassociateAwsTrainingCertificationEmailDomain(DisassociateAwsTrainingCertificationEmailDomainRequest request);
#endif

        /// <summary>
        /// Removes the association between an email domain and AWS training and certification
        /// for the partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsTrainingCertificationEmailDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateAwsTrainingCertificationEmailDomain service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/DisassociateAwsTrainingCertificationEmailDomain">REST API Reference for DisassociateAwsTrainingCertificationEmailDomain Operation</seealso>
        Task<DisassociateAwsTrainingCertificationEmailDomainResponse> DisassociateAwsTrainingCertificationEmailDomainAsync(DisassociateAwsTrainingCertificationEmailDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the alliance lead contact information for a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAllianceLeadContact service method.</param>
        /// <returns>The response from the GetAllianceLeadContact service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetAllianceLeadContact">REST API Reference for GetAllianceLeadContact Operation</seealso>
        GetAllianceLeadContactResponse GetAllianceLeadContact(GetAllianceLeadContactRequest request);
#endif

        /// <summary>
        /// Retrieves the alliance lead contact information for a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAllianceLeadContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAllianceLeadContact service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetAllianceLeadContact">REST API Reference for GetAllianceLeadContact Operation</seealso>
        Task<GetAllianceLeadContactResponse> GetAllianceLeadContactAsync(GetAllianceLeadContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves detailed information about a specific connection between partners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <returns>The response from the GetConnection service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnection">REST API Reference for GetConnection Operation</seealso>
        GetConnectionResponse GetConnection(GetConnectionRequest request);
#endif

        /// <summary>
        /// Retrieves detailed information about a specific connection between partners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetConnection service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnection">REST API Reference for GetConnection Operation</seealso>
        Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves detailed information about a specific connection invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionInvitation service method.</param>
        /// <returns>The response from the GetConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnectionInvitation">REST API Reference for GetConnectionInvitation Operation</seealso>
        GetConnectionInvitationResponse GetConnectionInvitation(GetConnectionInvitationRequest request);
#endif

        /// <summary>
        /// Retrieves detailed information about a specific connection invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnectionInvitation">REST API Reference for GetConnectionInvitation Operation</seealso>
        Task<GetConnectionInvitationResponse> GetConnectionInvitationAsync(GetConnectionInvitationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the connection preferences for a partner account, including access settings
        /// and exclusions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionPreferences service method.</param>
        /// <returns>The response from the GetConnectionPreferences service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnectionPreferences">REST API Reference for GetConnectionPreferences Operation</seealso>
        GetConnectionPreferencesResponse GetConnectionPreferences(GetConnectionPreferencesRequest request);
#endif

        /// <summary>
        /// Retrieves the connection preferences for a partner account, including access settings
        /// and exclusions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetConnectionPreferences service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetConnectionPreferences">REST API Reference for GetConnectionPreferences Operation</seealso>
        Task<GetConnectionPreferencesResponse> GetConnectionPreferencesAsync(GetConnectionPreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves detailed information about a specific partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartner service method.</param>
        /// <returns>The response from the GetPartner service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetPartner">REST API Reference for GetPartner Operation</seealso>
        GetPartnerResponse GetPartner(GetPartnerRequest request);
#endif

        /// <summary>
        /// Retrieves detailed information about a specific partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartner service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetPartner service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetPartner">REST API Reference for GetPartner Operation</seealso>
        Task<GetPartnerResponse> GetPartnerAsync(GetPartnerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves information about a specific profile update task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileUpdateTask service method.</param>
        /// <returns>The response from the GetProfileUpdateTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetProfileUpdateTask">REST API Reference for GetProfileUpdateTask Operation</seealso>
        GetProfileUpdateTaskResponse GetProfileUpdateTask(GetProfileUpdateTaskRequest request);
#endif

        /// <summary>
        /// Retrieves information about a specific profile update task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileUpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProfileUpdateTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetProfileUpdateTask">REST API Reference for GetProfileUpdateTask Operation</seealso>
        Task<GetProfileUpdateTaskResponse> GetProfileUpdateTaskAsync(GetProfileUpdateTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the visibility settings for a partner profile, determining who can see the
        /// profile information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileVisibility service method.</param>
        /// <returns>The response from the GetProfileVisibility service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetProfileVisibility">REST API Reference for GetProfileVisibility Operation</seealso>
        GetProfileVisibilityResponse GetProfileVisibility(GetProfileVisibilityRequest request);
#endif

        /// <summary>
        /// Retrieves the visibility settings for a partner profile, determining who can see the
        /// profile information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProfileVisibility service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetProfileVisibility">REST API Reference for GetProfileVisibility Operation</seealso>
        Task<GetProfileVisibilityResponse> GetProfileVisibilityAsync(GetProfileVisibilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns your current qualifications association status, the primary partner, and the
        /// full list of partners associated under the primary partner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationsAssociationDetails service method.</param>
        /// <returns>The response from the GetQualificationsAssociationDetails service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetQualificationsAssociationDetails">REST API Reference for GetQualificationsAssociationDetails Operation</seealso>
        GetQualificationsAssociationDetailsResponse GetQualificationsAssociationDetails(GetQualificationsAssociationDetailsRequest request);
#endif

        /// <summary>
        /// Returns your current qualifications association status, the primary partner, and the
        /// full list of partners associated under the primary partner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationsAssociationDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQualificationsAssociationDetails service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetQualificationsAssociationDetails">REST API Reference for GetQualificationsAssociationDetails Operation</seealso>
        Task<GetQualificationsAssociationDetailsResponse> GetQualificationsAssociationDetailsAsync(GetQualificationsAssociationDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the status and details of the most recent qualifications association task
        /// for your partner account. Use this operation to poll the progress of an association
        /// task initiated by <c>StartQualificationsAssociationTask</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationsAssociationTask service method.</param>
        /// <returns>The response from the GetQualificationsAssociationTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetQualificationsAssociationTask">REST API Reference for GetQualificationsAssociationTask Operation</seealso>
        GetQualificationsAssociationTaskResponse GetQualificationsAssociationTask(GetQualificationsAssociationTaskRequest request);
#endif

        /// <summary>
        /// Retrieves the status and details of the most recent qualifications association task
        /// for your partner account. Use this operation to poll the progress of an association
        /// task initiated by <c>StartQualificationsAssociationTask</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationsAssociationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQualificationsAssociationTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetQualificationsAssociationTask">REST API Reference for GetQualificationsAssociationTask Operation</seealso>
        Task<GetQualificationsAssociationTaskResponse> GetQualificationsAssociationTaskAsync(GetQualificationsAssociationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the status and details of the most recent qualifications disassociation
        /// task for your partner account. Use this operation to poll the progress of a disassociation
        /// task initiated by <c>StartQualificationsDisassociationTask</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationsDisassociationTask service method.</param>
        /// <returns>The response from the GetQualificationsDisassociationTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetQualificationsDisassociationTask">REST API Reference for GetQualificationsDisassociationTask Operation</seealso>
        GetQualificationsDisassociationTaskResponse GetQualificationsDisassociationTask(GetQualificationsDisassociationTaskRequest request);
#endif

        /// <summary>
        /// Retrieves the status and details of the most recent qualifications disassociation
        /// task for your partner account. Use this operation to poll the progress of a disassociation
        /// task initiated by <c>StartQualificationsDisassociationTask</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQualificationsDisassociationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetQualificationsDisassociationTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetQualificationsDisassociationTask">REST API Reference for GetQualificationsDisassociationTask Operation</seealso>
        Task<GetQualificationsDisassociationTaskResponse> GetQualificationsDisassociationTaskAsync(GetQualificationsDisassociationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current status and details of a verification process for a partner account.
        /// This operation allows partners to check the progress and results of business or registrant
        /// verification processes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVerification service method.</param>
        /// <returns>The response from the GetVerification service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetVerification">REST API Reference for GetVerification Operation</seealso>
        GetVerificationResponse GetVerification(GetVerificationRequest request);
#endif

        /// <summary>
        /// Retrieves the current status and details of a verification process for a partner account.
        /// This operation allows partners to check the progress and results of business or registrant
        /// verification processes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetVerification service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/GetVerification">REST API Reference for GetVerification Operation</seealso>
        Task<GetVerificationResponse> GetVerificationAsync(GetVerificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists connection invitations for the partner account, with optional filtering by status,
        /// type, and other criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionInvitations service method.</param>
        /// <returns>The response from the ListConnectionInvitations service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListConnectionInvitations">REST API Reference for ListConnectionInvitations Operation</seealso>
        ListConnectionInvitationsResponse ListConnectionInvitations(ListConnectionInvitationsRequest request);
#endif

        /// <summary>
        /// Lists connection invitations for the partner account, with optional filtering by status,
        /// type, and other criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListConnectionInvitations service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListConnectionInvitations">REST API Reference for ListConnectionInvitations Operation</seealso>
        Task<ListConnectionInvitationsResponse> ListConnectionInvitationsAsync(ListConnectionInvitationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists active connections for the partner account, with optional filtering by connection
        /// type and participant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <returns>The response from the ListConnections service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListConnections">REST API Reference for ListConnections Operation</seealso>
        ListConnectionsResponse ListConnections(ListConnectionsRequest request);
#endif

        /// <summary>
        /// Lists active connections for the partner account, with optional filtering by connection
        /// type and participant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListConnections service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListConnections">REST API Reference for ListConnections Operation</seealso>
        Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists partner accounts in the catalog, providing a summary view of all partners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartners service method.</param>
        /// <returns>The response from the ListPartners service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListPartners">REST API Reference for ListPartners Operation</seealso>
        ListPartnersResponse ListPartners(ListPartnersRequest request);
#endif

        /// <summary>
        /// Lists partner accounts in the catalog, providing a summary view of all partners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListPartners service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListPartners">REST API Reference for ListPartners Operation</seealso>
        Task<ListPartnersResponse> ListPartnersAsync(ListPartnersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all tags associated with a specific AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// Lists all tags associated with a specific AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates or updates the alliance lead contact information for a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAllianceLeadContact service method.</param>
        /// <returns>The response from the PutAllianceLeadContact service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutAllianceLeadContact">REST API Reference for PutAllianceLeadContact Operation</seealso>
        PutAllianceLeadContactResponse PutAllianceLeadContact(PutAllianceLeadContactRequest request);
#endif

        /// <summary>
        /// Creates or updates the alliance lead contact information for a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAllianceLeadContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutAllianceLeadContact service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutAllianceLeadContact">REST API Reference for PutAllianceLeadContact Operation</seealso>
        Task<PutAllianceLeadContactResponse> PutAllianceLeadContactAsync(PutAllianceLeadContactRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Sets the visibility level for a partner profile, controlling who can view the profile
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileVisibility service method.</param>
        /// <returns>The response from the PutProfileVisibility service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutProfileVisibility">REST API Reference for PutProfileVisibility Operation</seealso>
        PutProfileVisibilityResponse PutProfileVisibility(PutProfileVisibilityRequest request);
#endif

        /// <summary>
        /// Sets the visibility level for a partner profile, controlling who can view the profile
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutProfileVisibility service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutProfileVisibility">REST API Reference for PutProfileVisibility Operation</seealso>
        Task<PutProfileVisibilityResponse> PutProfileVisibilityAsync(PutProfileVisibilityRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Rejects a connection invitation from another partner, declining the partnership request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectConnectionInvitation service method.</param>
        /// <returns>The response from the RejectConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/RejectConnectionInvitation">REST API Reference for RejectConnectionInvitation Operation</seealso>
        RejectConnectionInvitationResponse RejectConnectionInvitation(RejectConnectionInvitationRequest request);
#endif

        /// <summary>
        /// Rejects a connection invitation from another partner, declining the partnership request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RejectConnectionInvitation service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/RejectConnectionInvitation">REST API Reference for RejectConnectionInvitation Operation</seealso>
        Task<RejectConnectionInvitationResponse> RejectConnectionInvitationAsync(RejectConnectionInvitationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Sends an email verification code to the specified email address for account verification
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmailVerificationCode service method.</param>
        /// <returns>The response from the SendEmailVerificationCode service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/SendEmailVerificationCode">REST API Reference for SendEmailVerificationCode Operation</seealso>
        SendEmailVerificationCodeResponse SendEmailVerificationCode(SendEmailVerificationCodeRequest request);
#endif

        /// <summary>
        /// Sends an email verification code to the specified email address for account verification
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmailVerificationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SendEmailVerificationCode service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/SendEmailVerificationCode">REST API Reference for SendEmailVerificationCode Operation</seealso>
        Task<SendEmailVerificationCodeResponse> SendEmailVerificationCodeAsync(SendEmailVerificationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Initiates a profile update task to modify partner profile information asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProfileUpdateTask service method.</param>
        /// <returns>The response from the StartProfileUpdateTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartProfileUpdateTask">REST API Reference for StartProfileUpdateTask Operation</seealso>
        StartProfileUpdateTaskResponse StartProfileUpdateTask(StartProfileUpdateTaskRequest request);
#endif

        /// <summary>
        /// Initiates a profile update task to modify partner profile information asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProfileUpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartProfileUpdateTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartProfileUpdateTask">REST API Reference for StartProfileUpdateTask Operation</seealso>
        Task<StartProfileUpdateTaskResponse> StartProfileUpdateTaskAsync(StartProfileUpdateTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Initiates an asynchronous task to associate your partner qualifications with a primary
        /// account. You must be a subsidiary of the primary account with an active subsidiary
        /// connection. Use <c>GetQualificationsAssociationTask</c> to monitor task progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQualificationsAssociationTask service method.</param>
        /// <returns>The response from the StartQualificationsAssociationTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartQualificationsAssociationTask">REST API Reference for StartQualificationsAssociationTask Operation</seealso>
        StartQualificationsAssociationTaskResponse StartQualificationsAssociationTask(StartQualificationsAssociationTaskRequest request);
#endif

        /// <summary>
        /// Initiates an asynchronous task to associate your partner qualifications with a primary
        /// account. You must be a subsidiary of the primary account with an active subsidiary
        /// connection. Use <c>GetQualificationsAssociationTask</c> to monitor task progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQualificationsAssociationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartQualificationsAssociationTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartQualificationsAssociationTask">REST API Reference for StartQualificationsAssociationTask Operation</seealso>
        Task<StartQualificationsAssociationTaskResponse> StartQualificationsAssociationTaskAsync(StartQualificationsAssociationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Initiates an asynchronous task to disassociate your partner qualifications from a
        /// primary account. You must currently be associated and cannot disassociate if you are
        /// the primary partner. Use <c>GetQualificationsDisassociationTask</c> to monitor task
        /// progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQualificationsDisassociationTask service method.</param>
        /// <returns>The response from the StartQualificationsDisassociationTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartQualificationsDisassociationTask">REST API Reference for StartQualificationsDisassociationTask Operation</seealso>
        StartQualificationsDisassociationTaskResponse StartQualificationsDisassociationTask(StartQualificationsDisassociationTaskRequest request);
#endif

        /// <summary>
        /// Initiates an asynchronous task to disassociate your partner qualifications from a
        /// primary account. You must currently be associated and cannot disassociate if you are
        /// the primary partner. Use <c>GetQualificationsDisassociationTask</c> to monitor task
        /// progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQualificationsDisassociationTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartQualificationsDisassociationTask service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartQualificationsDisassociationTask">REST API Reference for StartQualificationsDisassociationTask Operation</seealso>
        Task<StartQualificationsDisassociationTaskResponse> StartQualificationsDisassociationTaskAsync(StartQualificationsDisassociationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Initiates a new verification process for a partner account. This operation begins
        /// the verification workflow for either business registration or individual registrant
        /// identity verification as required by AWS Partner Central.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVerification service method.</param>
        /// <returns>The response from the StartVerification service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartVerification">REST API Reference for StartVerification Operation</seealso>
        StartVerificationResponse StartVerification(StartVerificationRequest request);
#endif

        /// <summary>
        /// Initiates a new verification process for a partner account. This operation begins
        /// the verification workflow for either business registration or individual registrant
        /// identity verification as required by AWS Partner Central.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartVerification service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ServiceQuotaExceededException">
        /// The request was rejected because it would exceed a service quota or limit. This may
        /// occur when trying to create more resources than allowed by the service limits.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartVerification">REST API Reference for StartVerification Operation</seealso>
        Task<StartVerificationResponse> StartVerificationAsync(StartVerificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds or updates tags for a specified AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds or updates tags for a specified AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes specified tags from an AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Removes specified tags from an AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ResourceNotFoundException">
        /// The specified resource could not be found. This may occur when referencing a resource
        /// that does not exist or has been deleted.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the connection preferences for a partner account, modifying access settings
        /// and exclusions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionPreferences service method.</param>
        /// <returns>The response from the UpdateConnectionPreferences service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/UpdateConnectionPreferences">REST API Reference for UpdateConnectionPreferences Operation</seealso>
        UpdateConnectionPreferencesResponse UpdateConnectionPreferences(UpdateConnectionPreferencesRequest request);
#endif

        /// <summary>
        /// Updates the connection preferences for a partner account, modifying access settings
        /// and exclusions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateConnectionPreferences service method, as returned by PartnerCentralAccount.</returns>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.AccessDeniedException">
        /// The request was denied due to insufficient permissions. The caller does not have the
        /// required permissions to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource. This typically occurs when trying to create a resource that already exists
        /// or modify a resource that has been changed by another process.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.InternalServerException">
        /// An internal server error occurred while processing the request. This is typically
        /// a temporary condition and the request may be retried.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/UpdateConnectionPreferences">REST API Reference for UpdateConnectionPreferences Operation</seealso>
        Task<UpdateConnectionPreferencesResponse> UpdateConnectionPreferencesAsync(UpdateConnectionPreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonPartnerCentralAccountConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonPartnerCentralAccountConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonPartnerCentralAccountConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonPartnerCentralAccountConfig to create AmazonPartnerCentralAccountClient");
            }

            return awsCredentials == null ?
                    new AmazonPartnerCentralAccountClient(serviceClientConfig) :
                    new AmazonPartnerCentralAccountClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
