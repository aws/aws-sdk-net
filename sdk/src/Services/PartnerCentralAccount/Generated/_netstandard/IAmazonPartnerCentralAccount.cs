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
 * Do not modify this file. This file is generated from the partnercentral-account-2025-04-04.normal.json service model.
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
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPartnerCentralAccountPaginatorFactory Paginators { get; }
#endif
                
        #region  AcceptConnectionInvitation



        /// <summary>
        /// Accepts a connection invitation from another partner, establishing a formal partnership
        /// connection between the two parties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/AcceptConnectionInvitation">REST API Reference for AcceptConnectionInvitation Operation</seealso>
        Task<AcceptConnectionInvitationResponse> AcceptConnectionInvitationAsync(AcceptConnectionInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociateAwsTrainingCertificationEmailDomain



        /// <summary>
        /// Associates an email domain with AWS training and certification for the partner account,
        /// enabling automatic verification of employee certifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsTrainingCertificationEmailDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<AssociateAwsTrainingCertificationEmailDomainResponse> AssociateAwsTrainingCertificationEmailDomainAsync(AssociateAwsTrainingCertificationEmailDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelConnection



        /// <summary>
        /// Cancels an existing connection between partners, terminating the partnership relationship.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<CancelConnectionResponse> CancelConnectionAsync(CancelConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelConnectionInvitation



        /// <summary>
        /// Cancels a pending connection invitation before it has been accepted or rejected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<CancelConnectionInvitationResponse> CancelConnectionInvitationAsync(CancelConnectionInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelProfileUpdateTask



        /// <summary>
        /// Cancels an in-progress profile update task, stopping any pending changes to the partner
        /// profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelProfileUpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<CancelProfileUpdateTaskResponse> CancelProfileUpdateTaskAsync(CancelProfileUpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateConnectionInvitation



        /// <summary>
        /// Creates a new connection invitation to establish a partnership with another organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/CreateConnectionInvitation">REST API Reference for CreateConnectionInvitation Operation</seealso>
        Task<CreateConnectionInvitationResponse> CreateConnectionInvitationAsync(CreateConnectionInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePartner



        /// <summary>
        /// Creates a new partner account in the AWS Partner Network with the specified details
        /// and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartner service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<CreatePartnerResponse> CreatePartnerAsync(CreatePartnerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateAwsTrainingCertificationEmailDomain



        /// <summary>
        /// Removes the association between an email domain and AWS training and certification
        /// for the partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsTrainingCertificationEmailDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<DisassociateAwsTrainingCertificationEmailDomainResponse> DisassociateAwsTrainingCertificationEmailDomainAsync(DisassociateAwsTrainingCertificationEmailDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetAllianceLeadContact



        /// <summary>
        /// Retrieves the alliance lead contact information for a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAllianceLeadContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetAllianceLeadContactResponse> GetAllianceLeadContactAsync(GetAllianceLeadContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConnection



        /// <summary>
        /// Retrieves detailed information about a specific connection between partners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConnectionInvitation



        /// <summary>
        /// Retrieves detailed information about a specific connection invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetConnectionInvitationResponse> GetConnectionInvitationAsync(GetConnectionInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConnectionPreferences



        /// <summary>
        /// Retrieves the connection preferences for a partner account, including access settings
        /// and exclusions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectionPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetConnectionPreferencesResponse> GetConnectionPreferencesAsync(GetConnectionPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPartner



        /// <summary>
        /// Retrieves detailed information about a specific partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartner service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetPartnerResponse> GetPartnerAsync(GetPartnerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProfileUpdateTask



        /// <summary>
        /// Retrieves information about a specific profile update task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileUpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetProfileUpdateTaskResponse> GetProfileUpdateTaskAsync(GetProfileUpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetProfileVisibility



        /// <summary>
        /// Retrieves the visibility settings for a partner profile, determining who can see the
        /// profile information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<GetProfileVisibilityResponse> GetProfileVisibilityAsync(GetProfileVisibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConnectionInvitations



        /// <summary>
        /// Lists connection invitations for the partner account, with optional filtering by status,
        /// type, and other criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectionInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListConnectionInvitationsResponse> ListConnectionInvitationsAsync(ListConnectionInvitationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListConnections



        /// <summary>
        /// Lists active connections for the partner account, with optional filtering by connection
        /// type and participant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPartners



        /// <summary>
        /// Lists partner accounts in the catalog, providing a summary view of all partners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListPartnersResponse> ListPartnersAsync(ListPartnersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all tags associated with a specific AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAllianceLeadContact



        /// <summary>
        /// Creates or updates the alliance lead contact information for a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAllianceLeadContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<PutAllianceLeadContactResponse> PutAllianceLeadContactAsync(PutAllianceLeadContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutProfileVisibility



        /// <summary>
        /// Sets the visibility level for a partner profile, controlling who can view the profile
        /// information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProfileVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/PutProfileVisibility">REST API Reference for PutProfileVisibility Operation</seealso>
        Task<PutProfileVisibilityResponse> PutProfileVisibilityAsync(PutProfileVisibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectConnectionInvitation



        /// <summary>
        /// Rejects a connection invitation from another partner, declining the partnership request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectConnectionInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<RejectConnectionInvitationResponse> RejectConnectionInvitationAsync(RejectConnectionInvitationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SendEmailVerificationCode



        /// <summary>
        /// Sends an email verification code to the specified email address for account verification
        /// purposes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendEmailVerificationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<SendEmailVerificationCodeResponse> SendEmailVerificationCodeAsync(SendEmailVerificationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartProfileUpdateTask



        /// <summary>
        /// Initiates a profile update task to modify partner profile information asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartProfileUpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ThrottlingException">
        /// The request was throttled due to too many requests being sent in a short period of
        /// time. The client should implement exponential backoff and retry the request.
        /// </exception>
        /// <exception cref="Amazon.PartnerCentralAccount.Model.ValidationException">
        /// The request failed validation. One or more input parameters are invalid, missing,
        /// or do not meet the required format or constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/partnercentral-account-2025-04-04/StartProfileUpdateTask">REST API Reference for StartProfileUpdateTask Operation</seealso>
        Task<StartProfileUpdateTaskResponse> StartProfileUpdateTaskAsync(StartProfileUpdateTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds or updates tags for a specified AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes specified tags from an AWS Partner Central Account resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateConnectionPreferences



        /// <summary>
        /// Updates the connection preferences for a partner account, modifying access settings
        /// and exclusions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnectionPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
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
        Task<UpdateConnectionPreferencesResponse> UpdateConnectionPreferencesAsync(UpdateConnectionPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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