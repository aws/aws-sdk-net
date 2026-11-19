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
using Amazon.WellArchitected.Model;

#pragma warning disable CS1570

namespace Amazon.WellArchitected
{
    /// <summary>
    /// <para>Interface for accessing WellArchitected</para>
    ///
    /// Amazon Web Services Well-Architected 
    /// <para>
    /// This is the <i>Amazon Web Services Well-Architected API Reference</i>. Amazon Web
    /// Services Well-Architected helps you evaluate your architectures against Amazon Web
    /// Services best practices across operational excellence, security, reliability, performance
    /// efficiency, cost optimization, and sustainability.
    /// </para>
    ///  
    /// <para>
    /// To view API actions organized by service, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/wa-api-actions.html">API
    /// actions</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Amazon Web Services Well-Architected Agent (preview)</b> 
    /// </para>
    ///  
    /// <para>
    /// Describes the API operations for managing optimization profiles, goals, application
    /// context, and recommendations in the Amazon Web Services Well-Architected Agent. Through
    /// this API, you can create and configure agent profiles that define the scope of your
    /// Amazon Web Services environment to analyze, set optimization goals across cost, security,
    /// performance, and resilience pillars, start recommendation generation, retrieve prioritized
    /// recommendations with ready-to-deploy remediation scripts, and provide feedback to
    /// improve future recommendations.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/agent.html">What
    /// is Amazon Web Services Well-Architected Agent?</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Well-Architected Tool</b> 
    /// </para>
    ///  
    /// <para>
    /// Describes the API operations for creating and managing workloads, conducting lens
    /// reviews, tracking milestones, managing custom lenses, sharing workloads across accounts,
    /// and managing profiles with the Well-Architected Tool.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/tool.html">What
    /// is Well-Architected Tool?</a> 
    /// </para>
    /// </summary>
    public partial interface IAmazonWellArchitected : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IWellArchitectedPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Associate a lens to a workload.
        /// 
        ///  
        /// <para>
        /// Up to 10 lenses can be associated with a workload in a single API operation. A maximum
        /// of 20 lenses can be associated with a workload.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By accessing and/or applying custom lenses created by another Amazon Web Services
        /// user or account, you acknowledge that custom lenses created by other users and shared
        /// with you are Third Party Content as defined in the Amazon Web Services Customer Agreement.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLenses service method.</param>
        /// <returns>The response from the AssociateLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/AssociateLenses">REST API Reference for AssociateLenses Operation</seealso>
        AssociateLensesResponse AssociateLenses(AssociateLensesRequest request);
#endif

        /// <summary>
        /// Associate a lens to a workload.
        /// 
        ///  
        /// <para>
        /// Up to 10 lenses can be associated with a workload in a single API operation. A maximum
        /// of 20 lenses can be associated with a workload.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By accessing and/or applying custom lenses created by another Amazon Web Services
        /// user or account, you acknowledge that custom lenses created by other users and shared
        /// with you are Third Party Content as defined in the Amazon Web Services Customer Agreement.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLenses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/AssociateLenses">REST API Reference for AssociateLenses Operation</seealso>
        Task<AssociateLensesResponse> AssociateLensesAsync(AssociateLensesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Associate a profile with a workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProfiles service method.</param>
        /// <returns>The response from the AssociateProfiles service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/AssociateProfiles">REST API Reference for AssociateProfiles Operation</seealso>
        AssociateProfilesResponse AssociateProfiles(AssociateProfilesRequest request);
#endif

        /// <summary>
        /// Associate a profile with a workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AssociateProfiles service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/AssociateProfiles">REST API Reference for AssociateProfiles Operation</seealso>
        Task<AssociateProfilesResponse> AssociateProfilesAsync(AssociateProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a Basic profile for the calling account. No configuration input is required
        /// because the account and region are inferred from the caller. The profile uses the
        /// reserved name <c>basic</c>. This operation is idempotent. Calling it twice returns
        /// the same ARN. Each account can have at most one Basic profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentBasicProfile service method.</param>
        /// <returns>The response from the CreateAgentBasicProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentBasicProfile">REST API Reference for CreateAgentBasicProfile Operation</seealso>
        CreateAgentBasicProfileResponse CreateAgentBasicProfile(CreateAgentBasicProfileRequest request);
#endif

        /// <summary>
        /// Creates a Basic profile for the calling account. No configuration input is required
        /// because the account and region are inferred from the caller. The profile uses the
        /// reserved name <c>basic</c>. This operation is idempotent. Calling it twice returns
        /// the same ARN. Each account can have at most one Basic profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentBasicProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAgentBasicProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentBasicProfile">REST API Reference for CreateAgentBasicProfile Operation</seealso>
        Task<CreateAgentBasicProfileResponse> CreateAgentBasicProfileAsync(CreateAgentBasicProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a context associated with an optimization profile. Contexts provide application
        /// and environment information used during recommendation generation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentContext service method.</param>
        /// <returns>The response from the CreateAgentContext service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentContext">REST API Reference for CreateAgentContext Operation</seealso>
        CreateAgentContextResponse CreateAgentContext(CreateAgentContextRequest request);
#endif

        /// <summary>
        /// Creates a context associated with an optimization profile. Contexts provide application
        /// and environment information used during recommendation generation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAgentContext service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentContext">REST API Reference for CreateAgentContext Operation</seealso>
        Task<CreateAgentContextResponse> CreateAgentContextAsync(CreateAgentContextRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates an optimization goal associated with a profile. Goals define specific targets
        /// and objectives for the optimization process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentGoal service method.</param>
        /// <returns>The response from the CreateAgentGoal service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentGoal">REST API Reference for CreateAgentGoal Operation</seealso>
        CreateAgentGoalResponse CreateAgentGoal(CreateAgentGoalRequest request);
#endif

        /// <summary>
        /// Creates an optimization goal associated with a profile. Goals define specific targets
        /// and objectives for the optimization process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentGoal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAgentGoal service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentGoal">REST API Reference for CreateAgentGoal Operation</seealso>
        Task<CreateAgentGoalResponse> CreateAgentGoalAsync(CreateAgentGoalRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates an Organizational Profile for use with AWS Organizations integration. Organizational
        /// Profiles are scoped to an AWS Organization and do not require an execution role or
        /// aggregation configuration. The organization is inferred from the caller's identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentOrganizationalProfile service method.</param>
        /// <returns>The response from the CreateAgentOrganizationalProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentOrganizationalProfile">REST API Reference for CreateAgentOrganizationalProfile Operation</seealso>
        CreateAgentOrganizationalProfileResponse CreateAgentOrganizationalProfile(CreateAgentOrganizationalProfileRequest request);
#endif

        /// <summary>
        /// Creates an Organizational Profile for use with AWS Organizations integration. Organizational
        /// Profiles are scoped to an AWS Organization and do not require an execution role or
        /// aggregation configuration. The organization is inferred from the caller's identity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentOrganizationalProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAgentOrganizationalProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentOrganizationalProfile">REST API Reference for CreateAgentOrganizationalProfile Operation</seealso>
        Task<CreateAgentOrganizationalProfileResponse> CreateAgentOrganizationalProfileAsync(CreateAgentOrganizationalProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates an Organizational Report, which is an asynchronously-materialized, point-in-time
        /// snapshot of recommendations across all Agent Profiles within the caller's AWS Organization.
        /// You can optionally narrow the scope with filters. The operation is idempotent on the
        /// caller-supplied clientToken. The AWS Organization the report belongs to is inferred
        /// from the caller's authorization context. Reports are retained for 90 days from creation,
        /// after which they are automatically deleted. Use DeleteAgentOrganizationalReport to
        /// delete a report earlier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentOrganizationalReport service method.</param>
        /// <returns>The response from the CreateAgentOrganizationalReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentOrganizationalReport">REST API Reference for CreateAgentOrganizationalReport Operation</seealso>
        CreateAgentOrganizationalReportResponse CreateAgentOrganizationalReport(CreateAgentOrganizationalReportRequest request);
#endif

        /// <summary>
        /// Creates an Organizational Report, which is an asynchronously-materialized, point-in-time
        /// snapshot of recommendations across all Agent Profiles within the caller's AWS Organization.
        /// You can optionally narrow the scope with filters. The operation is idempotent on the
        /// caller-supplied clientToken. The AWS Organization the report belongs to is inferred
        /// from the caller's authorization context. Reports are retained for 90 days from creation,
        /// after which they are automatically deleted. Use DeleteAgentOrganizationalReport to
        /// delete a report earlier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentOrganizationalReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAgentOrganizationalReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentOrganizationalReport">REST API Reference for CreateAgentOrganizationalReport Operation</seealso>
        Task<CreateAgentOrganizationalReportResponse> CreateAgentOrganizationalReportAsync(CreateAgentOrganizationalReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates an optimization profile that defines the scope and configuration for generating
        /// recommendations. A profile specifies the execution role, target pillars, and aggregation
        /// settings for analyzing your Amazon Web Services resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentProfile service method.</param>
        /// <returns>The response from the CreateAgentProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentProfile">REST API Reference for CreateAgentProfile Operation</seealso>
        CreateAgentProfileResponse CreateAgentProfile(CreateAgentProfileRequest request);
#endif

        /// <summary>
        /// Creates an optimization profile that defines the scope and configuration for generating
        /// recommendations. A profile specifies the execution role, target pillars, and aggregation
        /// settings for analyzing your Amazon Web Services resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAgentProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateAgentProfile">REST API Reference for CreateAgentProfile Operation</seealso>
        Task<CreateAgentProfileResponse> CreateAgentProfileAsync(CreateAgentProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a lens share.
        /// 
        ///  
        /// <para>
        /// The owner of a lens can share it with other Amazon Web Services accounts, users, an
        /// organization, and organizational units (OUs) in the same Amazon Web Services Region.
        /// Lenses provided by Amazon Web Services (Amazon Web Services Official Content) cannot
        /// be shared.
        /// </para>
        ///  
        /// <para>
        ///  Shared access to a lens is not removed until the lens invitation is deleted.
        /// </para>
        ///  
        /// <para>
        /// If you share a lens with an organization or OU, all accounts in the organization or
        /// OU are granted access to the lens.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-sharing.html">Sharing
        /// a custom lens</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLensShare service method.</param>
        /// <returns>The response from the CreateLensShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateLensShare">REST API Reference for CreateLensShare Operation</seealso>
        CreateLensShareResponse CreateLensShare(CreateLensShareRequest request);
#endif

        /// <summary>
        /// Create a lens share.
        /// 
        ///  
        /// <para>
        /// The owner of a lens can share it with other Amazon Web Services accounts, users, an
        /// organization, and organizational units (OUs) in the same Amazon Web Services Region.
        /// Lenses provided by Amazon Web Services (Amazon Web Services Official Content) cannot
        /// be shared.
        /// </para>
        ///  
        /// <para>
        ///  Shared access to a lens is not removed until the lens invitation is deleted.
        /// </para>
        ///  
        /// <para>
        /// If you share a lens with an organization or OU, all accounts in the organization or
        /// OU are granted access to the lens.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-sharing.html">Sharing
        /// a custom lens</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLensShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateLensShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateLensShare">REST API Reference for CreateLensShare Operation</seealso>
        Task<CreateLensShareResponse> CreateLensShareAsync(CreateLensShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a new lens version.
        /// 
        ///  
        /// <para>
        /// A lens can have up to 100 versions.
        /// </para>
        ///  
        /// <para>
        /// Use this operation to publish a new lens version after you have imported a lens. The
        /// <c>LensAlias</c> is used to identify the lens to be published. The owner of a lens
        /// can share the lens with other Amazon Web Services accounts and users in the same Amazon
        /// Web Services Region. Only the owner of a lens can delete it. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLensVersion service method.</param>
        /// <returns>The response from the CreateLensVersion service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateLensVersion">REST API Reference for CreateLensVersion Operation</seealso>
        CreateLensVersionResponse CreateLensVersion(CreateLensVersionRequest request);
#endif

        /// <summary>
        /// Create a new lens version.
        /// 
        ///  
        /// <para>
        /// A lens can have up to 100 versions.
        /// </para>
        ///  
        /// <para>
        /// Use this operation to publish a new lens version after you have imported a lens. The
        /// <c>LensAlias</c> is used to identify the lens to be published. The owner of a lens
        /// can share the lens with other Amazon Web Services accounts and users in the same Amazon
        /// Web Services Region. Only the owner of a lens can delete it. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLensVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateLensVersion service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateLensVersion">REST API Reference for CreateLensVersion Operation</seealso>
        Task<CreateLensVersionResponse> CreateLensVersionAsync(CreateLensVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a milestone for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMilestone service method.</param>
        /// <returns>The response from the CreateMilestone service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateMilestone">REST API Reference for CreateMilestone Operation</seealso>
        CreateMilestoneResponse CreateMilestone(CreateMilestoneRequest request);
#endif

        /// <summary>
        /// Create a milestone for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMilestone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateMilestone service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateMilestone">REST API Reference for CreateMilestone Operation</seealso>
        Task<CreateMilestoneResponse> CreateMilestoneAsync(CreateMilestoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <returns>The response from the CreateProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        CreateProfileResponse CreateProfile(CreateProfileRequest request);
#endif

        /// <summary>
        /// Create a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a profile share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfileShare service method.</param>
        /// <returns>The response from the CreateProfileShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateProfileShare">REST API Reference for CreateProfileShare Operation</seealso>
        CreateProfileShareResponse CreateProfileShare(CreateProfileShareRequest request);
#endif

        /// <summary>
        /// Create a profile share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateProfileShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateProfileShare">REST API Reference for CreateProfileShare Operation</seealso>
        Task<CreateProfileShareResponse> CreateProfileShareAsync(CreateProfileShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a review template.
        /// 
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// Do not include or gather personal identifiable information (PII) of end users or other
        /// identifiable individuals in or via your review templates. If your review template
        /// or those shared with you and used in your account do include or collect PII you are
        /// responsible for: ensuring that the included PII is processed in accordance with applicable
        /// law, providing adequate privacy notices, and obtaining necessary consents for processing
        /// such data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReviewTemplate service method.</param>
        /// <returns>The response from the CreateReviewTemplate service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateReviewTemplate">REST API Reference for CreateReviewTemplate Operation</seealso>
        CreateReviewTemplateResponse CreateReviewTemplate(CreateReviewTemplateRequest request);
#endif

        /// <summary>
        /// Create a review template.
        /// 
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// Do not include or gather personal identifiable information (PII) of end users or other
        /// identifiable individuals in or via your review templates. If your review template
        /// or those shared with you and used in your account do include or collect PII you are
        /// responsible for: ensuring that the included PII is processed in accordance with applicable
        /// law, providing adequate privacy notices, and obtaining necessary consents for processing
        /// such data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReviewTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateReviewTemplate service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateReviewTemplate">REST API Reference for CreateReviewTemplate Operation</seealso>
        Task<CreateReviewTemplateResponse> CreateReviewTemplateAsync(CreateReviewTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a review template share.
        /// 
        ///  
        /// <para>
        /// The owner of a review template can share it with other Amazon Web Services accounts,
        /// users, an organization, and organizational units (OUs) in the same Amazon Web Services
        /// Region. 
        /// </para>
        ///  
        /// <para>
        ///  Shared access to a review template is not removed until the review template share
        /// invitation is deleted.
        /// </para>
        ///  
        /// <para>
        /// If you share a review template with an organization or OU, all accounts in the organization
        /// or OU are granted access to the review template.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your review template with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your review template available to those other accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateShare service method.</param>
        /// <returns>The response from the CreateTemplateShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateTemplateShare">REST API Reference for CreateTemplateShare Operation</seealso>
        CreateTemplateShareResponse CreateTemplateShare(CreateTemplateShareRequest request);
#endif

        /// <summary>
        /// Create a review template share.
        /// 
        ///  
        /// <para>
        /// The owner of a review template can share it with other Amazon Web Services accounts,
        /// users, an organization, and organizational units (OUs) in the same Amazon Web Services
        /// Region. 
        /// </para>
        ///  
        /// <para>
        ///  Shared access to a review template is not removed until the review template share
        /// invitation is deleted.
        /// </para>
        ///  
        /// <para>
        /// If you share a review template with an organization or OU, all accounts in the organization
        /// or OU are granted access to the review template.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your review template with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your review template available to those other accounts.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateTemplateShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateTemplateShare">REST API Reference for CreateTemplateShare Operation</seealso>
        Task<CreateTemplateShareResponse> CreateTemplateShareAsync(CreateTemplateShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a new workload.
        /// 
        ///  
        /// <para>
        /// The owner of a workload can share the workload with other Amazon Web Services accounts,
        /// users, an organization, and organizational units (OUs) in the same Amazon Web Services
        /// Region. Only the owner of a workload can delete it.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/define-workload.html">Defining
        /// a Workload</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Either <c>AwsRegions</c>, <c>NonAwsRegions</c>, or both must be specified when creating
        /// a workload.
        /// </para>
        ///  
        /// <para>
        /// You also must specify <c>ReviewOwner</c>, even though the parameter is listed as not
        /// being required in the following section. 
        /// </para>
        ///  </important> 
        /// <para>
        /// When creating a workload using a review template, you must have the following IAM
        /// permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>wellarchitected:GetReviewTemplate</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>wellarchitected:GetReviewTemplateAnswer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>wellarchitected:ListReviewTemplateAnswers</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>wellarchitected:GetReviewTemplateLensReview</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkload service method.</param>
        /// <returns>The response from the CreateWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkload">REST API Reference for CreateWorkload Operation</seealso>
        CreateWorkloadResponse CreateWorkload(CreateWorkloadRequest request);
#endif

        /// <summary>
        /// Create a new workload.
        /// 
        ///  
        /// <para>
        /// The owner of a workload can share the workload with other Amazon Web Services accounts,
        /// users, an organization, and organizational units (OUs) in the same Amazon Web Services
        /// Region. Only the owner of a workload can delete it.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/define-workload.html">Defining
        /// a Workload</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Either <c>AwsRegions</c>, <c>NonAwsRegions</c>, or both must be specified when creating
        /// a workload.
        /// </para>
        ///  
        /// <para>
        /// You also must specify <c>ReviewOwner</c>, even though the parameter is listed as not
        /// being required in the following section. 
        /// </para>
        ///  </important> 
        /// <para>
        /// When creating a workload using a review template, you must have the following IAM
        /// permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>wellarchitected:GetReviewTemplate</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>wellarchitected:GetReviewTemplateAnswer</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>wellarchitected:ListReviewTemplateAnswers</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>wellarchitected:GetReviewTemplateLensReview</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkload">REST API Reference for CreateWorkload Operation</seealso>
        Task<CreateWorkloadResponse> CreateWorkloadAsync(CreateWorkloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Create a workload share.
        /// 
        ///  
        /// <para>
        /// The owner of a workload can share it with other Amazon Web Services accounts and users
        /// in the same Amazon Web Services Region. Shared access to a workload is not removed
        /// until the workload invitation is deleted.
        /// </para>
        ///  
        /// <para>
        /// If you share a workload with an organization or OU, all accounts in the organization
        /// or OU are granted access to the workload.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/workloads-sharing.html">Sharing
        /// a workload</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadShare service method.</param>
        /// <returns>The response from the CreateWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkloadShare">REST API Reference for CreateWorkloadShare Operation</seealso>
        CreateWorkloadShareResponse CreateWorkloadShare(CreateWorkloadShareRequest request);
#endif

        /// <summary>
        /// Create a workload share.
        /// 
        ///  
        /// <para>
        /// The owner of a workload can share it with other Amazon Web Services accounts and users
        /// in the same Amazon Web Services Region. Shared access to a workload is not removed
        /// until the workload invitation is deleted.
        /// </para>
        ///  
        /// <para>
        /// If you share a workload with an organization or OU, all accounts in the organization
        /// or OU are granted access to the workload.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/workloads-sharing.html">Sharing
        /// a workload</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkloadShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/CreateWorkloadShare">REST API Reference for CreateWorkloadShare Operation</seealso>
        Task<CreateWorkloadShareResponse> CreateWorkloadShareAsync(CreateWorkloadShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a context associated with a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentContext service method.</param>
        /// <returns>The response from the DeleteAgentContext service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentContext">REST API Reference for DeleteAgentContext Operation</seealso>
        DeleteAgentContextResponse DeleteAgentContext(DeleteAgentContextRequest request);
#endif

        /// <summary>
        /// Deletes a context associated with a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAgentContext service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentContext">REST API Reference for DeleteAgentContext Operation</seealso>
        Task<DeleteAgentContextResponse> DeleteAgentContextAsync(DeleteAgentContextRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an optimization goal from a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentGoal service method.</param>
        /// <returns>The response from the DeleteAgentGoal service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentGoal">REST API Reference for DeleteAgentGoal Operation</seealso>
        DeleteAgentGoalResponse DeleteAgentGoal(DeleteAgentGoalRequest request);
#endif

        /// <summary>
        /// Deletes an optimization goal from a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentGoal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAgentGoal service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentGoal">REST API Reference for DeleteAgentGoal Operation</seealso>
        Task<DeleteAgentGoalResponse> DeleteAgentGoalAsync(DeleteAgentGoalRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an Organizational Report and its associated artifacts. The operation is idempotent,
        /// so repeated calls for a report that has already been deleted return success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentOrganizationalReport service method.</param>
        /// <returns>The response from the DeleteAgentOrganizationalReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentOrganizationalReport">REST API Reference for DeleteAgentOrganizationalReport Operation</seealso>
        DeleteAgentOrganizationalReportResponse DeleteAgentOrganizationalReport(DeleteAgentOrganizationalReportRequest request);
#endif

        /// <summary>
        /// Deletes an Organizational Report and its associated artifacts. The operation is idempotent,
        /// so repeated calls for a report that has already been deleted return success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentOrganizationalReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAgentOrganizationalReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentOrganizationalReport">REST API Reference for DeleteAgentOrganizationalReport Operation</seealso>
        Task<DeleteAgentOrganizationalReportResponse> DeleteAgentOrganizationalReportAsync(DeleteAgentOrganizationalReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes an optimization profile and its associated configuration. This action cannot
        /// be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentProfile service method.</param>
        /// <returns>The response from the DeleteAgentProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentProfile">REST API Reference for DeleteAgentProfile Operation</seealso>
        DeleteAgentProfileResponse DeleteAgentProfile(DeleteAgentProfileRequest request);
#endif

        /// <summary>
        /// Deletes an optimization profile and its associated configuration. This action cannot
        /// be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAgentProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentProfile">REST API Reference for DeleteAgentProfile Operation</seealso>
        Task<DeleteAgentProfileResponse> DeleteAgentProfileAsync(DeleteAgentProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes the resource-based policy from an Agent Profile. This revokes all cross-account
        /// access previously granted by the policy. Only the profile owner can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentProfilePolicy service method.</param>
        /// <returns>The response from the DeleteAgentProfilePolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentProfilePolicy">REST API Reference for DeleteAgentProfilePolicy Operation</seealso>
        DeleteAgentProfilePolicyResponse DeleteAgentProfilePolicy(DeleteAgentProfilePolicyRequest request);
#endif

        /// <summary>
        /// Removes the resource-based policy from an Agent Profile. This revokes all cross-account
        /// access previously granted by the policy. Only the profile owner can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentProfilePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAgentProfilePolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentProfilePolicy">REST API Reference for DeleteAgentProfilePolicy Operation</seealso>
        Task<DeleteAgentProfilePolicyResponse> DeleteAgentProfilePolicyAsync(DeleteAgentProfilePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Removes the resource-based policy from an individual Agent Recommendation. This revokes
        /// all cross-account access previously granted by the policy. The recommendation owner
        /// or any principal with profile write access on the parent profile can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRecommendationPolicy service method.</param>
        /// <returns>The response from the DeleteAgentRecommendationPolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentRecommendationPolicy">REST API Reference for DeleteAgentRecommendationPolicy Operation</seealso>
        DeleteAgentRecommendationPolicyResponse DeleteAgentRecommendationPolicy(DeleteAgentRecommendationPolicyRequest request);
#endif

        /// <summary>
        /// Removes the resource-based policy from an individual Agent Recommendation. This revokes
        /// all cross-account access previously granted by the policy. The recommendation owner
        /// or any principal with profile write access on the parent profile can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentRecommendationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteAgentRecommendationPolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteAgentRecommendationPolicy">REST API Reference for DeleteAgentRecommendationPolicy Operation</seealso>
        Task<DeleteAgentRecommendationPolicyResponse> DeleteAgentRecommendationPolicyAsync(DeleteAgentRecommendationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete an existing lens.
        /// 
        ///  
        /// <para>
        /// Only the owner of a lens can delete it. After the lens is deleted, Amazon Web Services
        /// accounts and users that you shared the lens with can continue to use it, but they
        /// will no longer be able to apply it to new workloads. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLens service method.</param>
        /// <returns>The response from the DeleteLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteLens">REST API Reference for DeleteLens Operation</seealso>
        DeleteLensResponse DeleteLens(DeleteLensRequest request);
#endif

        /// <summary>
        /// Delete an existing lens.
        /// 
        ///  
        /// <para>
        /// Only the owner of a lens can delete it. After the lens is deleted, Amazon Web Services
        /// accounts and users that you shared the lens with can continue to use it, but they
        /// will no longer be able to apply it to new workloads. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteLens">REST API Reference for DeleteLens Operation</seealso>
        Task<DeleteLensResponse> DeleteLensAsync(DeleteLensRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete a lens share.
        /// 
        ///  
        /// <para>
        /// After the lens share is deleted, Amazon Web Services accounts, users, organizations,
        /// and organizational units (OUs) that you shared the lens with can continue to use it,
        /// but they will no longer be able to apply it to new workloads.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLensShare service method.</param>
        /// <returns>The response from the DeleteLensShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteLensShare">REST API Reference for DeleteLensShare Operation</seealso>
        DeleteLensShareResponse DeleteLensShare(DeleteLensShareRequest request);
#endif

        /// <summary>
        /// Delete a lens share.
        /// 
        ///  
        /// <para>
        /// After the lens share is deleted, Amazon Web Services accounts, users, organizations,
        /// and organizational units (OUs) that you shared the lens with can continue to use it,
        /// but they will no longer be able to apply it to new workloads.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your custom lenses with other Amazon Web Services accounts, you acknowledge
        /// that Amazon Web Services will make your custom lenses available to those other accounts.
        /// Those other accounts may continue to access and use your shared custom lenses even
        /// if you delete the custom lenses from your own Amazon Web Services account or terminate
        /// your Amazon Web Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLensShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteLensShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteLensShare">REST API Reference for DeleteLensShare Operation</seealso>
        Task<DeleteLensShareResponse> DeleteLensShareAsync(DeleteLensShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete a profile.
        /// 
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your profile with other Amazon Web Services accounts, you acknowledge that
        /// Amazon Web Services will make your profile available to those other accounts. Those
        /// other accounts may continue to access and use your shared profile even if you delete
        /// the profile from your own Amazon Web Services account or terminate your Amazon Web
        /// Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <returns>The response from the DeleteProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        DeleteProfileResponse DeleteProfile(DeleteProfileRequest request);
#endif

        /// <summary>
        /// Delete a profile.
        /// 
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// By sharing your profile with other Amazon Web Services accounts, you acknowledge that
        /// Amazon Web Services will make your profile available to those other accounts. Those
        /// other accounts may continue to access and use your shared profile even if you delete
        /// the profile from your own Amazon Web Services account or terminate your Amazon Web
        /// Services account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete a profile share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileShare service method.</param>
        /// <returns>The response from the DeleteProfileShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteProfileShare">REST API Reference for DeleteProfileShare Operation</seealso>
        DeleteProfileShareResponse DeleteProfileShare(DeleteProfileShareRequest request);
#endif

        /// <summary>
        /// Delete a profile share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfileShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteProfileShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteProfileShare">REST API Reference for DeleteProfileShare Operation</seealso>
        Task<DeleteProfileShareResponse> DeleteProfileShareAsync(DeleteProfileShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete a review template.
        /// 
        ///  
        /// <para>
        /// Only the owner of a review template can delete it.
        /// </para>
        ///  
        /// <para>
        /// After the review template is deleted, Amazon Web Services accounts, users, organizations,
        /// and organizational units (OUs) that you shared the review template with will no longer
        /// be able to apply it to new workloads.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReviewTemplate service method.</param>
        /// <returns>The response from the DeleteReviewTemplate service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteReviewTemplate">REST API Reference for DeleteReviewTemplate Operation</seealso>
        DeleteReviewTemplateResponse DeleteReviewTemplate(DeleteReviewTemplateRequest request);
#endif

        /// <summary>
        /// Delete a review template.
        /// 
        ///  
        /// <para>
        /// Only the owner of a review template can delete it.
        /// </para>
        ///  
        /// <para>
        /// After the review template is deleted, Amazon Web Services accounts, users, organizations,
        /// and organizational units (OUs) that you shared the review template with will no longer
        /// be able to apply it to new workloads.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReviewTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteReviewTemplate service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteReviewTemplate">REST API Reference for DeleteReviewTemplate Operation</seealso>
        Task<DeleteReviewTemplateResponse> DeleteReviewTemplateAsync(DeleteReviewTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete a review template share.
        /// 
        ///  
        /// <para>
        /// After the review template share is deleted, Amazon Web Services accounts, users, organizations,
        /// and organizational units (OUs) that you shared the review template with will no longer
        /// be able to apply it to new workloads.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateShare service method.</param>
        /// <returns>The response from the DeleteTemplateShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteTemplateShare">REST API Reference for DeleteTemplateShare Operation</seealso>
        DeleteTemplateShareResponse DeleteTemplateShare(DeleteTemplateShareRequest request);
#endif

        /// <summary>
        /// Delete a review template share.
        /// 
        ///  
        /// <para>
        /// After the review template share is deleted, Amazon Web Services accounts, users, organizations,
        /// and organizational units (OUs) that you shared the review template with will no longer
        /// be able to apply it to new workloads.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteTemplateShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteTemplateShare">REST API Reference for DeleteTemplateShare Operation</seealso>
        Task<DeleteTemplateShareResponse> DeleteTemplateShareAsync(DeleteTemplateShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkload service method.</param>
        /// <returns>The response from the DeleteWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkload">REST API Reference for DeleteWorkload Operation</seealso>
        DeleteWorkloadResponse DeleteWorkload(DeleteWorkloadRequest request);
#endif

        /// <summary>
        /// Delete an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkload">REST API Reference for DeleteWorkload Operation</seealso>
        Task<DeleteWorkloadResponse> DeleteWorkloadAsync(DeleteWorkloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Delete a workload share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadShare service method.</param>
        /// <returns>The response from the DeleteWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkloadShare">REST API Reference for DeleteWorkloadShare Operation</seealso>
        DeleteWorkloadShareResponse DeleteWorkloadShare(DeleteWorkloadShareRequest request);
#endif

        /// <summary>
        /// Delete a workload share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkloadShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DeleteWorkloadShare">REST API Reference for DeleteWorkloadShare Operation</seealso>
        Task<DeleteWorkloadShareResponse> DeleteWorkloadShareAsync(DeleteWorkloadShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disassociate a lens from a workload.
        /// 
        ///  
        /// <para>
        /// Up to 10 lenses can be disassociated from a workload in a single API operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon Web Services Well-Architected Framework lens (<c>wellarchitected</c>) cannot
        /// be removed from a workload.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLenses service method.</param>
        /// <returns>The response from the DisassociateLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DisassociateLenses">REST API Reference for DisassociateLenses Operation</seealso>
        DisassociateLensesResponse DisassociateLenses(DisassociateLensesRequest request);
#endif

        /// <summary>
        /// Disassociate a lens from a workload.
        /// 
        ///  
        /// <para>
        /// Up to 10 lenses can be disassociated from a workload in a single API operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon Web Services Well-Architected Framework lens (<c>wellarchitected</c>) cannot
        /// be removed from a workload.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLenses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DisassociateLenses">REST API Reference for DisassociateLenses Operation</seealso>
        Task<DisassociateLensesResponse> DisassociateLensesAsync(DisassociateLensesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Disassociate a profile from a workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProfiles service method.</param>
        /// <returns>The response from the DisassociateProfiles service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DisassociateProfiles">REST API Reference for DisassociateProfiles Operation</seealso>
        DisassociateProfilesResponse DisassociateProfiles(DisassociateProfilesRequest request);
#endif

        /// <summary>
        /// Disassociate a profile from a workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DisassociateProfiles service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/DisassociateProfiles">REST API Reference for DisassociateProfiles Operation</seealso>
        Task<DisassociateProfilesResponse> DisassociateProfilesAsync(DisassociateProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Export an existing lens.
        /// 
        ///  
        /// <para>
        /// Only the owner of a lens can export it. Lenses provided by Amazon Web Services (Amazon
        /// Web Services Official Content) cannot be exported.
        /// </para>
        ///  
        /// <para>
        /// Lenses are defined in JSON. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-format-specification.html">JSON
        /// format specification</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// Do not include or gather personal identifiable information (PII) of end users or other
        /// identifiable individuals in or via your custom lenses. If your custom lens or those
        /// shared with you and used in your account do include or collect PII you are responsible
        /// for: ensuring that the included PII is processed in accordance with applicable law,
        /// providing adequate privacy notices, and obtaining necessary consents for processing
        /// such data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportLens service method.</param>
        /// <returns>The response from the ExportLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ExportLens">REST API Reference for ExportLens Operation</seealso>
        ExportLensResponse ExportLens(ExportLensRequest request);
#endif

        /// <summary>
        /// Export an existing lens.
        /// 
        ///  
        /// <para>
        /// Only the owner of a lens can export it. Lenses provided by Amazon Web Services (Amazon
        /// Web Services Official Content) cannot be exported.
        /// </para>
        ///  
        /// <para>
        /// Lenses are defined in JSON. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-format-specification.html">JSON
        /// format specification</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// Do not include or gather personal identifiable information (PII) of end users or other
        /// identifiable individuals in or via your custom lenses. If your custom lens or those
        /// shared with you and used in your account do include or collect PII you are responsible
        /// for: ensuring that the included PII is processed in accordance with applicable law,
        /// providing adequate privacy notices, and obtaining necessary consents for processing
        /// such data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportLens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ExportLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ExportLens">REST API Reference for ExportLens Operation</seealso>
        Task<ExportLensResponse> ExportLensAsync(ExportLensRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves detailed information about a specific context associated with a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentContext service method.</param>
        /// <returns>The response from the GetAgentContext service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentContext">REST API Reference for GetAgentContext Operation</seealso>
        GetAgentContextResponse GetAgentContext(GetAgentContextRequest request);
#endif

        /// <summary>
        /// Retrieves detailed information about a specific context associated with a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAgentContext service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentContext">REST API Reference for GetAgentContext Operation</seealso>
        Task<GetAgentContextResponse> GetAgentContextAsync(GetAgentContextRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves detailed information about a specific optimization goal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentGoal service method.</param>
        /// <returns>The response from the GetAgentGoal service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentGoal">REST API Reference for GetAgentGoal Operation</seealso>
        GetAgentGoalResponse GetAgentGoal(GetAgentGoalRequest request);
#endif

        /// <summary>
        /// Retrieves detailed information about a specific optimization goal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentGoal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAgentGoal service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentGoal">REST API Reference for GetAgentGoal Operation</seealso>
        Task<GetAgentGoalResponse> GetAgentGoalAsync(GetAgentGoalRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves metadata and current state for a single Organizational Report. The coverageSummary
        /// is populated once the report reaches COMPLETED and is absent for reports still in
        /// progress or in a failed state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentOrganizationalReport service method.</param>
        /// <returns>The response from the GetAgentOrganizationalReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentOrganizationalReport">REST API Reference for GetAgentOrganizationalReport Operation</seealso>
        GetAgentOrganizationalReportResponse GetAgentOrganizationalReport(GetAgentOrganizationalReportRequest request);
#endif

        /// <summary>
        /// Retrieves metadata and current state for a single Organizational Report. The coverageSummary
        /// is populated once the report reaches COMPLETED and is absent for reports still in
        /// progress or in a failed state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentOrganizationalReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAgentOrganizationalReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentOrganizationalReport">REST API Reference for GetAgentOrganizationalReport Operation</seealso>
        Task<GetAgentOrganizationalReportResponse> GetAgentOrganizationalReportAsync(GetAgentOrganizationalReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the data artifact for a completed Organizational Report as a short-lived
        /// presigned S3 URL. The response contains the URL in downloadUrl and its expiration
        /// in expiresAt. To have the service write the artifact directly into a caller-owned
        /// bucket instead, use SendAgentOrganizationalReportDataToS3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentOrganizationalReportData service method.</param>
        /// <returns>The response from the GetAgentOrganizationalReportData service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentOrganizationalReportData">REST API Reference for GetAgentOrganizationalReportData Operation</seealso>
        GetAgentOrganizationalReportDataResponse GetAgentOrganizationalReportData(GetAgentOrganizationalReportDataRequest request);
#endif

        /// <summary>
        /// Retrieves the data artifact for a completed Organizational Report as a short-lived
        /// presigned S3 URL. The response contains the URL in downloadUrl and its expiration
        /// in expiresAt. To have the service write the artifact directly into a caller-owned
        /// bucket instead, use SendAgentOrganizationalReportDataToS3.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentOrganizationalReportData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAgentOrganizationalReportData service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentOrganizationalReportData">REST API Reference for GetAgentOrganizationalReportData Operation</seealso>
        Task<GetAgentOrganizationalReportDataResponse> GetAgentOrganizationalReportDataAsync(GetAgentOrganizationalReportDataRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Returns the caller's complete set of Well-Architected Agent preferences with their
        /// current states.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentPreferences service method.</param>
        /// <returns>The response from the GetAgentPreferences service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentPreferences">REST API Reference for GetAgentPreferences Operation</seealso>
        GetAgentPreferencesResponse GetAgentPreferences(GetAgentPreferencesRequest request);
#endif

        /// <summary>
        /// Returns the caller's complete set of Well-Architected Agent preferences with their
        /// current states.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAgentPreferences service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentPreferences">REST API Reference for GetAgentPreferences Operation</seealso>
        Task<GetAgentPreferencesResponse> GetAgentPreferencesAsync(GetAgentPreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves detailed information about an optimization profile, including its configuration
        /// and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentProfile service method.</param>
        /// <returns>The response from the GetAgentProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentProfile">REST API Reference for GetAgentProfile Operation</seealso>
        GetAgentProfileResponse GetAgentProfile(GetAgentProfileRequest request);
#endif

        /// <summary>
        /// Retrieves detailed information about an optimization profile, including its configuration
        /// and metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAgentProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentProfile">REST API Reference for GetAgentProfile Operation</seealso>
        Task<GetAgentProfileResponse> GetAgentProfileAsync(GetAgentProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the resource-based policy attached to an Agent Profile. Only the profile
        /// owner can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentProfilePolicy service method.</param>
        /// <returns>The response from the GetAgentProfilePolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentProfilePolicy">REST API Reference for GetAgentProfilePolicy Operation</seealso>
        GetAgentProfilePolicyResponse GetAgentProfilePolicy(GetAgentProfilePolicyRequest request);
#endif

        /// <summary>
        /// Retrieves the resource-based policy attached to an Agent Profile. Only the profile
        /// owner can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentProfilePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAgentProfilePolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentProfilePolicy">REST API Reference for GetAgentProfilePolicy Operation</seealso>
        Task<GetAgentProfilePolicyResponse> GetAgentProfilePolicyAsync(GetAgentProfilePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// <important> 
        /// <para>
        /// Application-level recommendations are a new recommendation format currently in beta.
        /// We are actively seeking customer feedback to improve their quality and relevance.
        /// As with any AI-generated content, please thoroughly review each recommendation before
        /// taking any action based on it.
        /// </para>
        ///  </important> 
        /// <para>
        /// Retrieves detailed information about a specific optimization recommendation, including
        /// its impact analysis, content, and implementation guidance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRecommendation service method.</param>
        /// <returns>The response from the GetAgentRecommendation service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentRecommendation">REST API Reference for GetAgentRecommendation Operation</seealso>
        GetAgentRecommendationResponse GetAgentRecommendation(GetAgentRecommendationRequest request);
#endif

        /// <summary>
        /// <important> 
        /// <para>
        /// Application-level recommendations are a new recommendation format currently in beta.
        /// We are actively seeking customer feedback to improve their quality and relevance.
        /// As with any AI-generated content, please thoroughly review each recommendation before
        /// taking any action based on it.
        /// </para>
        ///  </important> 
        /// <para>
        /// Retrieves detailed information about a specific optimization recommendation, including
        /// its impact analysis, content, and implementation guidance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAgentRecommendation service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentRecommendation">REST API Reference for GetAgentRecommendation Operation</seealso>
        Task<GetAgentRecommendationResponse> GetAgentRecommendationAsync(GetAgentRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// <important> 
        /// <para>
        /// Application-level recommendations are a new recommendation format currently in beta.
        /// We are actively seeking customer feedback to improve their quality and relevance.
        /// As with any AI-generated content, please thoroughly review each recommendation before
        /// taking any action based on it.
        /// </para>
        ///  </important> 
        /// <para>
        /// Retrieves information about a recommendation generation process, including its status,
        /// progress, and results. Recommendation generation is asynchronous: poll this operation
        /// until status reaches a terminal value of COMPLETED (results are ready) or ERROR (see
        /// errorDetails). Intermediate values are QUEUED and IN_PROGRESS.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRecommendationGeneration service method.</param>
        /// <returns>The response from the GetAgentRecommendationGeneration service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentRecommendationGeneration">REST API Reference for GetAgentRecommendationGeneration Operation</seealso>
        GetAgentRecommendationGenerationResponse GetAgentRecommendationGeneration(GetAgentRecommendationGenerationRequest request);
#endif

        /// <summary>
        /// <important> 
        /// <para>
        /// Application-level recommendations are a new recommendation format currently in beta.
        /// We are actively seeking customer feedback to improve their quality and relevance.
        /// As with any AI-generated content, please thoroughly review each recommendation before
        /// taking any action based on it.
        /// </para>
        ///  </important> 
        /// <para>
        /// Retrieves information about a recommendation generation process, including its status,
        /// progress, and results. Recommendation generation is asynchronous: poll this operation
        /// until status reaches a terminal value of COMPLETED (results are ready) or ERROR (see
        /// errorDetails). Intermediate values are QUEUED and IN_PROGRESS.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRecommendationGeneration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAgentRecommendationGeneration service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentRecommendationGeneration">REST API Reference for GetAgentRecommendationGeneration Operation</seealso>
        Task<GetAgentRecommendationGenerationResponse> GetAgentRecommendationGenerationAsync(GetAgentRecommendationGenerationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the resource-based policy attached to an individual Agent Recommendation.
        /// The recommendation owner or any principal with profile write access on the parent
        /// profile can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRecommendationPolicy service method.</param>
        /// <returns>The response from the GetAgentRecommendationPolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentRecommendationPolicy">REST API Reference for GetAgentRecommendationPolicy Operation</seealso>
        GetAgentRecommendationPolicyResponse GetAgentRecommendationPolicy(GetAgentRecommendationPolicyRequest request);
#endif

        /// <summary>
        /// Retrieves the resource-based policy attached to an individual Agent Recommendation.
        /// The recommendation owner or any principal with profile write access on the parent
        /// profile can call this operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentRecommendationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAgentRecommendationPolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAgentRecommendationPolicy">REST API Reference for GetAgentRecommendationPolicy Operation</seealso>
        Task<GetAgentRecommendationPolicyResponse> GetAgentRecommendationPolicyAsync(GetAgentRecommendationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get the answer to a specific question in a workload review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnswer service method.</param>
        /// <returns>The response from the GetAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAnswer">REST API Reference for GetAnswer Operation</seealso>
        GetAnswerResponse GetAnswer(GetAnswerRequest request);
#endif

        /// <summary>
        /// Get the answer to a specific question in a workload review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetAnswer">REST API Reference for GetAnswer Operation</seealso>
        Task<GetAnswerResponse> GetAnswerAsync(GetAnswerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get a consolidated report of your workloads.
        /// 
        ///  
        /// <para>
        /// You can optionally choose to include workloads that have been shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsolidatedReport service method.</param>
        /// <returns>The response from the GetConsolidatedReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetConsolidatedReport">REST API Reference for GetConsolidatedReport Operation</seealso>
        GetConsolidatedReportResponse GetConsolidatedReport(GetConsolidatedReportRequest request);
#endif

        /// <summary>
        /// Get a consolidated report of your workloads.
        /// 
        ///  
        /// <para>
        /// You can optionally choose to include workloads that have been shared with you.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsolidatedReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetConsolidatedReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetConsolidatedReport">REST API Reference for GetConsolidatedReport Operation</seealso>
        Task<GetConsolidatedReportResponse> GetConsolidatedReportAsync(GetConsolidatedReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Global settings for all workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings service method.</param>
        /// <returns>The response from the GetGlobalSettings service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        GetGlobalSettingsResponse GetGlobalSettings(GetGlobalSettingsRequest request);
#endif

        /// <summary>
        /// Global settings for all workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetGlobalSettings service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetGlobalSettings">REST API Reference for GetGlobalSettings Operation</seealso>
        Task<GetGlobalSettingsResponse> GetGlobalSettingsAsync(GetGlobalSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get an existing lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLens service method.</param>
        /// <returns>The response from the GetLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLens">REST API Reference for GetLens Operation</seealso>
        GetLensResponse GetLens(GetLensRequest request);
#endif

        /// <summary>
        /// Get an existing lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLens">REST API Reference for GetLens Operation</seealso>
        Task<GetLensResponse> GetLensAsync(GetLensRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get lens review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensReview service method.</param>
        /// <returns>The response from the GetLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReview">REST API Reference for GetLensReview Operation</seealso>
        GetLensReviewResponse GetLensReview(GetLensReviewRequest request);
#endif

        /// <summary>
        /// Get lens review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReview">REST API Reference for GetLensReview Operation</seealso>
        Task<GetLensReviewResponse> GetLensReviewAsync(GetLensReviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get lens review report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensReviewReport service method.</param>
        /// <returns>The response from the GetLensReviewReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReviewReport">REST API Reference for GetLensReviewReport Operation</seealso>
        GetLensReviewReportResponse GetLensReviewReport(GetLensReviewReportRequest request);
#endif

        /// <summary>
        /// Get lens review report.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensReviewReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetLensReviewReport service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensReviewReport">REST API Reference for GetLensReviewReport Operation</seealso>
        Task<GetLensReviewReportResponse> GetLensReviewReportAsync(GetLensReviewReportRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get lens version differences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensVersionDifference service method.</param>
        /// <returns>The response from the GetLensVersionDifference service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensVersionDifference">REST API Reference for GetLensVersionDifference Operation</seealso>
        GetLensVersionDifferenceResponse GetLensVersionDifference(GetLensVersionDifferenceRequest request);
#endif

        /// <summary>
        /// Get lens version differences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLensVersionDifference service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetLensVersionDifference service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetLensVersionDifference">REST API Reference for GetLensVersionDifference Operation</seealso>
        Task<GetLensVersionDifferenceResponse> GetLensVersionDifferenceAsync(GetLensVersionDifferenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get a milestone for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMilestone service method.</param>
        /// <returns>The response from the GetMilestone service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetMilestone">REST API Reference for GetMilestone Operation</seealso>
        GetMilestoneResponse GetMilestone(GetMilestoneRequest request);
#endif

        /// <summary>
        /// Get a milestone for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMilestone service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetMilestone service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetMilestone">REST API Reference for GetMilestone Operation</seealso>
        Task<GetMilestoneResponse> GetMilestoneAsync(GetMilestoneRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get profile information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <returns>The response from the GetProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetProfile">REST API Reference for GetProfile Operation</seealso>
        GetProfileResponse GetProfile(GetProfileRequest request);
#endif

        /// <summary>
        /// Get profile information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetProfile">REST API Reference for GetProfile Operation</seealso>
        Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get profile template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileTemplate service method.</param>
        /// <returns>The response from the GetProfileTemplate service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetProfileTemplate">REST API Reference for GetProfileTemplate Operation</seealso>
        GetProfileTemplateResponse GetProfileTemplate(GetProfileTemplateRequest request);
#endif

        /// <summary>
        /// Get profile template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetProfileTemplate service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetProfileTemplate">REST API Reference for GetProfileTemplate Operation</seealso>
        Task<GetProfileTemplateResponse> GetProfileTemplateAsync(GetProfileTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReviewTemplate service method.</param>
        /// <returns>The response from the GetReviewTemplate service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetReviewTemplate">REST API Reference for GetReviewTemplate Operation</seealso>
        GetReviewTemplateResponse GetReviewTemplate(GetReviewTemplateRequest request);
#endif

        /// <summary>
        /// Get review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReviewTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetReviewTemplate service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetReviewTemplate">REST API Reference for GetReviewTemplate Operation</seealso>
        Task<GetReviewTemplateResponse> GetReviewTemplateAsync(GetReviewTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get review template answer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReviewTemplateAnswer service method.</param>
        /// <returns>The response from the GetReviewTemplateAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetReviewTemplateAnswer">REST API Reference for GetReviewTemplateAnswer Operation</seealso>
        GetReviewTemplateAnswerResponse GetReviewTemplateAnswer(GetReviewTemplateAnswerRequest request);
#endif

        /// <summary>
        /// Get review template answer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReviewTemplateAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetReviewTemplateAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetReviewTemplateAnswer">REST API Reference for GetReviewTemplateAnswer Operation</seealso>
        Task<GetReviewTemplateAnswerResponse> GetReviewTemplateAnswerAsync(GetReviewTemplateAnswerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get a lens review associated with a review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReviewTemplateLensReview service method.</param>
        /// <returns>The response from the GetReviewTemplateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetReviewTemplateLensReview">REST API Reference for GetReviewTemplateLensReview Operation</seealso>
        GetReviewTemplateLensReviewResponse GetReviewTemplateLensReview(GetReviewTemplateLensReviewRequest request);
#endif

        /// <summary>
        /// Get a lens review associated with a review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReviewTemplateLensReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetReviewTemplateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetReviewTemplateLensReview">REST API Reference for GetReviewTemplateLensReview Operation</seealso>
        Task<GetReviewTemplateLensReviewResponse> GetReviewTemplateLensReviewAsync(GetReviewTemplateLensReviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Get an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload service method.</param>
        /// <returns>The response from the GetWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        GetWorkloadResponse GetWorkload(GetWorkloadRequest request);
#endif

        /// <summary>
        /// Get an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/GetWorkload">REST API Reference for GetWorkload Operation</seealso>
        Task<GetWorkloadResponse> GetWorkloadAsync(GetWorkloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Import a new custom lens or update an existing custom lens.
        /// 
        ///  
        /// <para>
        /// To update an existing custom lens, specify its ARN as the <c>LensAlias</c>. If no
        /// ARN is specified, a new custom lens is created.
        /// </para>
        ///  
        /// <para>
        /// The new or updated lens will have a status of <c>DRAFT</c>. The lens cannot be applied
        /// to workloads or shared with other Amazon Web Services accounts until it's published
        /// with <a>CreateLensVersion</a>.
        /// </para>
        ///  
        /// <para>
        /// Lenses are defined in JSON. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-format-specification.html">JSON
        /// format specification</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A custom lens cannot exceed 500 KB in size.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// Do not include or gather personal identifiable information (PII) of end users or other
        /// identifiable individuals in or via your custom lenses. If your custom lens or those
        /// shared with you and used in your account do include or collect PII you are responsible
        /// for: ensuring that the included PII is processed in accordance with applicable law,
        /// providing adequate privacy notices, and obtaining necessary consents for processing
        /// such data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportLens service method.</param>
        /// <returns>The response from the ImportLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ImportLens">REST API Reference for ImportLens Operation</seealso>
        ImportLensResponse ImportLens(ImportLensRequest request);
#endif

        /// <summary>
        /// Import a new custom lens or update an existing custom lens.
        /// 
        ///  
        /// <para>
        /// To update an existing custom lens, specify its ARN as the <c>LensAlias</c>. If no
        /// ARN is specified, a new custom lens is created.
        /// </para>
        ///  
        /// <para>
        /// The new or updated lens will have a status of <c>DRAFT</c>. The lens cannot be applied
        /// to workloads or shared with other Amazon Web Services accounts until it's published
        /// with <a>CreateLensVersion</a>.
        /// </para>
        ///  
        /// <para>
        /// Lenses are defined in JSON. For more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/lenses-format-specification.html">JSON
        /// format specification</a> in the <i>Well-Architected Tool User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A custom lens cannot exceed 500 KB in size.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Disclaimer</b> 
        /// </para>
        ///  
        /// <para>
        /// Do not include or gather personal identifiable information (PII) of end users or other
        /// identifiable individuals in or via your custom lenses. If your custom lens or those
        /// shared with you and used in your account do include or collect PII you are responsible
        /// for: ensuring that the included PII is processed in accordance with applicable law,
        /// providing adequate privacy notices, and obtaining necessary consents for processing
        /// such data.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportLens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ImportLens service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ImportLens">REST API Reference for ImportLens Operation</seealso>
        Task<ImportLensResponse> ImportLensAsync(ImportLensRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists contexts associated with a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentContexts service method.</param>
        /// <returns>The response from the ListAgentContexts service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentContexts">REST API Reference for ListAgentContexts Operation</seealso>
        ListAgentContextsResponse ListAgentContexts(ListAgentContextsRequest request);
#endif

        /// <summary>
        /// Lists contexts associated with a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentContexts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAgentContexts service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentContexts">REST API Reference for ListAgentContexts Operation</seealso>
        Task<ListAgentContextsResponse> ListAgentContextsAsync(ListAgentContextsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists optimization goals associated with a specified profile. Goals define specific
        /// targets and objectives for the optimization process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentGoals service method.</param>
        /// <returns>The response from the ListAgentGoals service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentGoals">REST API Reference for ListAgentGoals Operation</seealso>
        ListAgentGoalsResponse ListAgentGoals(ListAgentGoalsRequest request);
#endif

        /// <summary>
        /// Lists optimization goals associated with a specified profile. Goals define specific
        /// targets and objectives for the optimization process.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentGoals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAgentGoals service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentGoals">REST API Reference for ListAgentGoals Operation</seealso>
        Task<ListAgentGoalsResponse> ListAgentGoalsAsync(ListAgentGoalsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists Organizational Reports owned by the caller's account within the caller's AWS
        /// Organization, ordered by most recently created first. Supports pagination and an optional
        /// state filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentOrganizationalReports service method.</param>
        /// <returns>The response from the ListAgentOrganizationalReports service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentOrganizationalReports">REST API Reference for ListAgentOrganizationalReports Operation</seealso>
        ListAgentOrganizationalReportsResponse ListAgentOrganizationalReports(ListAgentOrganizationalReportsRequest request);
#endif

        /// <summary>
        /// Lists Organizational Reports owned by the caller's account within the caller's AWS
        /// Organization, ordered by most recently created first. Supports pagination and an optional
        /// state filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentOrganizationalReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAgentOrganizationalReports service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentOrganizationalReports">REST API Reference for ListAgentOrganizationalReports Operation</seealso>
        Task<ListAgentOrganizationalReportsResponse> ListAgentOrganizationalReportsAsync(ListAgentOrganizationalReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists optimization profiles in your account. Profiles define the scope and configuration
        /// for generating optimization recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentProfiles service method.</param>
        /// <returns>The response from the ListAgentProfiles service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentProfiles">REST API Reference for ListAgentProfiles Operation</seealso>
        ListAgentProfilesResponse ListAgentProfiles(ListAgentProfilesRequest request);
#endif

        /// <summary>
        /// Lists optimization profiles in your account. Profiles define the scope and configuration
        /// for generating optimization recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAgentProfiles service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentProfiles">REST API Reference for ListAgentProfiles Operation</seealso>
        Task<ListAgentProfilesResponse> ListAgentProfilesAsync(ListAgentProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// <important> 
        /// <para>
        /// Application-level recommendations are a new recommendation format currently in beta.
        /// We are actively seeking customer feedback to improve their quality and relevance.
        /// As with any AI-generated content, please thoroughly review each recommendation before
        /// taking any action based on it.
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists recommendation generation processes for a specified profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRecommendationGenerations service method.</param>
        /// <returns>The response from the ListAgentRecommendationGenerations service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentRecommendationGenerations">REST API Reference for ListAgentRecommendationGenerations Operation</seealso>
        ListAgentRecommendationGenerationsResponse ListAgentRecommendationGenerations(ListAgentRecommendationGenerationsRequest request);
#endif

        /// <summary>
        /// <important> 
        /// <para>
        /// Application-level recommendations are a new recommendation format currently in beta.
        /// We are actively seeking customer feedback to improve their quality and relevance.
        /// As with any AI-generated content, please thoroughly review each recommendation before
        /// taking any action based on it.
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists recommendation generation processes for a specified profile.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRecommendationGenerations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAgentRecommendationGenerations service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentRecommendationGenerations">REST API Reference for ListAgentRecommendationGenerations Operation</seealso>
        Task<ListAgentRecommendationGenerationsResponse> ListAgentRecommendationGenerationsAsync(ListAgentRecommendationGenerationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// <important> 
        /// <para>
        /// Application-level recommendations are a new recommendation format currently in beta.
        /// We are actively seeking customer feedback to improve their quality and relevance.
        /// As with any AI-generated content, please thoroughly review each recommendation before
        /// taking any action based on it.
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists recommendation items for a specific recommendation. Recommendation items provide
        /// detailed information about individual optimization opportunities.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRecommendationItems service method.</param>
        /// <returns>The response from the ListAgentRecommendationItems service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentRecommendationItems">REST API Reference for ListAgentRecommendationItems Operation</seealso>
        ListAgentRecommendationItemsResponse ListAgentRecommendationItems(ListAgentRecommendationItemsRequest request);
#endif

        /// <summary>
        /// <important> 
        /// <para>
        /// Application-level recommendations are a new recommendation format currently in beta.
        /// We are actively seeking customer feedback to improve their quality and relevance.
        /// As with any AI-generated content, please thoroughly review each recommendation before
        /// taking any action based on it.
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists recommendation items for a specific recommendation. Recommendation items provide
        /// detailed information about individual optimization opportunities.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRecommendationItems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAgentRecommendationItems service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentRecommendationItems">REST API Reference for ListAgentRecommendationItems Operation</seealso>
        Task<ListAgentRecommendationItemsResponse> ListAgentRecommendationItemsAsync(ListAgentRecommendationItemsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// <important> 
        /// <para>
        /// Application-level recommendations are a new recommendation format currently in beta.
        /// We are actively seeking customer feedback to improve their quality and relevance.
        /// As with any AI-generated content, please thoroughly review each recommendation before
        /// taking any action based on it.
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists active optimization recommendations for a specified profile with optional filtering
        /// by state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRecommendations service method.</param>
        /// <returns>The response from the ListAgentRecommendations service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentRecommendations">REST API Reference for ListAgentRecommendations Operation</seealso>
        ListAgentRecommendationsResponse ListAgentRecommendations(ListAgentRecommendationsRequest request);
#endif

        /// <summary>
        /// <important> 
        /// <para>
        /// Application-level recommendations are a new recommendation format currently in beta.
        /// We are actively seeking customer feedback to improve their quality and relevance.
        /// As with any AI-generated content, please thoroughly review each recommendation before
        /// taking any action based on it.
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists active optimization recommendations for a specified profile with optional filtering
        /// by state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAgentRecommendations service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAgentRecommendations">REST API Reference for ListAgentRecommendations Operation</seealso>
        Task<ListAgentRecommendationsResponse> ListAgentRecommendationsAsync(ListAgentRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List of answers for a particular workload and lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnswers service method.</param>
        /// <returns>The response from the ListAnswers service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAnswers">REST API Reference for ListAnswers Operation</seealso>
        ListAnswersResponse ListAnswers(ListAnswersRequest request);
#endif

        /// <summary>
        /// List of answers for a particular workload and lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnswers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListAnswers service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListAnswers">REST API Reference for ListAnswers Operation</seealso>
        Task<ListAnswersResponse> ListAnswersAsync(ListAnswersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List of Trusted Advisor check details by account related to the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCheckDetails service method.</param>
        /// <returns>The response from the ListCheckDetails service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListCheckDetails">REST API Reference for ListCheckDetails Operation</seealso>
        ListCheckDetailsResponse ListCheckDetails(ListCheckDetailsRequest request);
#endif

        /// <summary>
        /// List of Trusted Advisor check details by account related to the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCheckDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCheckDetails service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListCheckDetails">REST API Reference for ListCheckDetails Operation</seealso>
        Task<ListCheckDetailsResponse> ListCheckDetailsAsync(ListCheckDetailsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List of Trusted Advisor checks summarized for all accounts related to the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCheckSummaries service method.</param>
        /// <returns>The response from the ListCheckSummaries service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListCheckSummaries">REST API Reference for ListCheckSummaries Operation</seealso>
        ListCheckSummariesResponse ListCheckSummaries(ListCheckSummariesRequest request);
#endif

        /// <summary>
        /// List of Trusted Advisor checks summarized for all accounts related to the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCheckSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListCheckSummaries service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListCheckSummaries">REST API Reference for ListCheckSummaries Operation</seealso>
        Task<ListCheckSummariesResponse> ListCheckSummariesAsync(ListCheckSummariesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List the improvements of a particular lens review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviewImprovements service method.</param>
        /// <returns>The response from the ListLensReviewImprovements service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviewImprovements">REST API Reference for ListLensReviewImprovements Operation</seealso>
        ListLensReviewImprovementsResponse ListLensReviewImprovements(ListLensReviewImprovementsRequest request);
#endif

        /// <summary>
        /// List the improvements of a particular lens review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviewImprovements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListLensReviewImprovements service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviewImprovements">REST API Reference for ListLensReviewImprovements Operation</seealso>
        Task<ListLensReviewImprovementsResponse> ListLensReviewImprovementsAsync(ListLensReviewImprovementsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List lens reviews for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviews service method.</param>
        /// <returns>The response from the ListLensReviews service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviews">REST API Reference for ListLensReviews Operation</seealso>
        ListLensReviewsResponse ListLensReviews(ListLensReviewsRequest request);
#endif

        /// <summary>
        /// List lens reviews for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensReviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListLensReviews service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensReviews">REST API Reference for ListLensReviews Operation</seealso>
        Task<ListLensReviewsResponse> ListLensReviewsAsync(ListLensReviewsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List the lens shares associated with the lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensShares service method.</param>
        /// <returns>The response from the ListLensShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensShares">REST API Reference for ListLensShares Operation</seealso>
        ListLensSharesResponse ListLensShares(ListLensSharesRequest request);
#endif

        /// <summary>
        /// List the lens shares associated with the lens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLensShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListLensShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLensShares">REST API Reference for ListLensShares Operation</seealso>
        Task<ListLensSharesResponse> ListLensSharesAsync(ListLensSharesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List the available lenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLenses service method.</param>
        /// <returns>The response from the ListLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLenses">REST API Reference for ListLenses Operation</seealso>
        ListLensesResponse ListLenses(ListLensesRequest request);
#endif

        /// <summary>
        /// List the available lenses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLenses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListLenses service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListLenses">REST API Reference for ListLenses Operation</seealso>
        Task<ListLensesResponse> ListLensesAsync(ListLensesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List all milestones for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMilestones service method.</param>
        /// <returns>The response from the ListMilestones service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListMilestones">REST API Reference for ListMilestones Operation</seealso>
        ListMilestonesResponse ListMilestones(ListMilestonesRequest request);
#endif

        /// <summary>
        /// List all milestones for an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMilestones service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListMilestones service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListMilestones">REST API Reference for ListMilestones Operation</seealso>
        Task<ListMilestonesResponse> ListMilestonesAsync(ListMilestonesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List lens notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// <returns>The response from the ListNotifications service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        ListNotificationsResponse ListNotifications(ListNotificationsRequest request);
#endif

        /// <summary>
        /// List lens notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListNotifications service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListNotifications">REST API Reference for ListNotifications Operation</seealso>
        Task<ListNotificationsResponse> ListNotificationsAsync(ListNotificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List profile notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileNotifications service method.</param>
        /// <returns>The response from the ListProfileNotifications service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListProfileNotifications">REST API Reference for ListProfileNotifications Operation</seealso>
        ListProfileNotificationsResponse ListProfileNotifications(ListProfileNotificationsRequest request);
#endif

        /// <summary>
        /// List profile notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileNotifications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProfileNotifications service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListProfileNotifications">REST API Reference for ListProfileNotifications Operation</seealso>
        Task<ListProfileNotificationsResponse> ListProfileNotificationsAsync(ListProfileNotificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List profile shares.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileShares service method.</param>
        /// <returns>The response from the ListProfileShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListProfileShares">REST API Reference for ListProfileShares Operation</seealso>
        ListProfileSharesResponse ListProfileShares(ListProfileSharesRequest request);
#endif

        /// <summary>
        /// List profile shares.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProfileShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListProfileShares">REST API Reference for ListProfileShares Operation</seealso>
        Task<ListProfileSharesResponse> ListProfileSharesAsync(ListProfileSharesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <returns>The response from the ListProfiles service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        ListProfilesResponse ListProfiles(ListProfilesRequest request);
#endif

        /// <summary>
        /// List profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListProfiles service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List the answers of a review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReviewTemplateAnswers service method.</param>
        /// <returns>The response from the ListReviewTemplateAnswers service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListReviewTemplateAnswers">REST API Reference for ListReviewTemplateAnswers Operation</seealso>
        ListReviewTemplateAnswersResponse ListReviewTemplateAnswers(ListReviewTemplateAnswersRequest request);
#endif

        /// <summary>
        /// List the answers of a review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReviewTemplateAnswers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListReviewTemplateAnswers service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListReviewTemplateAnswers">REST API Reference for ListReviewTemplateAnswers Operation</seealso>
        Task<ListReviewTemplateAnswersResponse> ListReviewTemplateAnswersAsync(ListReviewTemplateAnswersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List review templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReviewTemplates service method.</param>
        /// <returns>The response from the ListReviewTemplates service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListReviewTemplates">REST API Reference for ListReviewTemplates Operation</seealso>
        ListReviewTemplatesResponse ListReviewTemplates(ListReviewTemplatesRequest request);
#endif

        /// <summary>
        /// List review templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReviewTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListReviewTemplates service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListReviewTemplates">REST API Reference for ListReviewTemplates Operation</seealso>
        Task<ListReviewTemplatesResponse> ListReviewTemplatesAsync(ListReviewTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List the share invitations.
        /// 
        ///  
        /// <para>
        ///  <c>WorkloadNamePrefix</c>, <c>LensNamePrefix</c>, <c>ProfileNamePrefix</c>, and <c>TemplateNamePrefix</c>
        /// are mutually exclusive. Use the parameter that matches your <c>ShareResourceType</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListShareInvitations service method.</param>
        /// <returns>The response from the ListShareInvitations service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListShareInvitations">REST API Reference for ListShareInvitations Operation</seealso>
        ListShareInvitationsResponse ListShareInvitations(ListShareInvitationsRequest request);
#endif

        /// <summary>
        /// List the share invitations.
        /// 
        ///  
        /// <para>
        ///  <c>WorkloadNamePrefix</c>, <c>LensNamePrefix</c>, <c>ProfileNamePrefix</c>, and <c>TemplateNamePrefix</c>
        /// are mutually exclusive. Use the parameter that matches your <c>ShareResourceType</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListShareInvitations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListShareInvitations service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListShareInvitations">REST API Reference for ListShareInvitations Operation</seealso>
        Task<ListShareInvitationsResponse> ListShareInvitationsAsync(ListShareInvitationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List the tags for a resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be a workload ARN, a custom lens ARN, a profile ARN,
        /// or review template ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <returns>The response from the ListTagsForResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);
#endif

        /// <summary>
        /// List the tags for a resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be a workload ARN, a custom lens ARN, a profile ARN,
        /// or review template ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTagsForResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List review template shares.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateShares service method.</param>
        /// <returns>The response from the ListTemplateShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListTemplateShares">REST API Reference for ListTemplateShares Operation</seealso>
        ListTemplateSharesResponse ListTemplateShares(ListTemplateSharesRequest request);
#endif

        /// <summary>
        /// List review template shares.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListTemplateShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListTemplateShares">REST API Reference for ListTemplateShares Operation</seealso>
        Task<ListTemplateSharesResponse> ListTemplateSharesAsync(ListTemplateSharesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// List the workload shares associated with the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadShares service method.</param>
        /// <returns>The response from the ListWorkloadShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloadShares">REST API Reference for ListWorkloadShares Operation</seealso>
        ListWorkloadSharesResponse ListWorkloadShares(ListWorkloadSharesRequest request);
#endif

        /// <summary>
        /// List the workload shares associated with the workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloadShares service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListWorkloadShares service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloadShares">REST API Reference for ListWorkloadShares Operation</seealso>
        Task<ListWorkloadSharesResponse> ListWorkloadSharesAsync(ListWorkloadSharesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Paginated list of workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// <returns>The response from the ListWorkloads service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        ListWorkloadsResponse ListWorkloads(ListWorkloadsRequest request);
#endif

        /// <summary>
        /// Paginated list of workloads.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkloads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListWorkloads service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/ListWorkloads">REST API Reference for ListWorkloads Operation</seealso>
        Task<ListWorkloadsResponse> ListWorkloadsAsync(ListWorkloadsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates or replaces the caller's Well-Architected Agent preferences. Each supplied
        /// update sets the desired state of one preference. Preferences not named in the request
        /// are left unchanged. Enabling or disabling is performed synchronously, so a failure
        /// to reach the requested state is returned as a modeled exception rather than a FAILED
        /// status. On success the operation returns an empty response. Call GetAgentPreferences
        /// to read the resulting state. The account the preferences belong to is inferred from
        /// the caller's authorization context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAgentPreferences service method.</param>
        /// <returns>The response from the PutAgentPreferences service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/PutAgentPreferences">REST API Reference for PutAgentPreferences Operation</seealso>
        PutAgentPreferencesResponse PutAgentPreferences(PutAgentPreferencesRequest request);
#endif

        /// <summary>
        /// Creates or replaces the caller's Well-Architected Agent preferences. Each supplied
        /// update sets the desired state of one preference. Preferences not named in the request
        /// are left unchanged. Enabling or disabling is performed synchronously, so a failure
        /// to reach the requested state is returned as a modeled exception rather than a FAILED
        /// status. On success the operation returns an empty response. Call GetAgentPreferences
        /// to read the resulting state. The account the preferences belong to is inferred from
        /// the caller's authorization context.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAgentPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutAgentPreferences service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/PutAgentPreferences">REST API Reference for PutAgentPreferences Operation</seealso>
        Task<PutAgentPreferencesResponse> PutAgentPreferencesAsync(PutAgentPreferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Attaches or replaces a resource-based policy on an Agent Profile. The policy controls
        /// cross-account access to the profile and its child resources such as recommendations,
        /// goals, and contexts. Only the profile owner can call this operation. The policy must
        /// be valid IAM JSON with Allow-only statements and no negation condition operators.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAgentProfilePolicy service method.</param>
        /// <returns>The response from the PutAgentProfilePolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/PutAgentProfilePolicy">REST API Reference for PutAgentProfilePolicy Operation</seealso>
        PutAgentProfilePolicyResponse PutAgentProfilePolicy(PutAgentProfilePolicyRequest request);
#endif

        /// <summary>
        /// Attaches or replaces a resource-based policy on an Agent Profile. The policy controls
        /// cross-account access to the profile and its child resources such as recommendations,
        /// goals, and contexts. Only the profile owner can call this operation. The policy must
        /// be valid IAM JSON with Allow-only statements and no negation condition operators.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAgentProfilePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutAgentProfilePolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/PutAgentProfilePolicy">REST API Reference for PutAgentProfilePolicy Operation</seealso>
        Task<PutAgentProfilePolicyResponse> PutAgentProfilePolicyAsync(PutAgentProfilePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Submits user feedback on a recommendation to help improve future optimization suggestions
        /// and track implementation outcomes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAgentRecommendationFeedback service method.</param>
        /// <returns>The response from the PutAgentRecommendationFeedback service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/PutAgentRecommendationFeedback">REST API Reference for PutAgentRecommendationFeedback Operation</seealso>
        PutAgentRecommendationFeedbackResponse PutAgentRecommendationFeedback(PutAgentRecommendationFeedbackRequest request);
#endif

        /// <summary>
        /// Submits user feedback on a recommendation to help improve future optimization suggestions
        /// and track implementation outcomes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAgentRecommendationFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutAgentRecommendationFeedback service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/PutAgentRecommendationFeedback">REST API Reference for PutAgentRecommendationFeedback Operation</seealso>
        Task<PutAgentRecommendationFeedbackResponse> PutAgentRecommendationFeedbackAsync(PutAgentRecommendationFeedbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Attaches or replaces a resource-based policy on an individual Agent Recommendation.
        /// The policy controls cross-account access to the recommendation and its child resources
        /// such as items and remediations. The recommendation owner or any principal with profile
        /// write access on the parent profile can call this operation. The policy must be valid
        /// IAM JSON with Allow-only statements and no negation condition operators.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAgentRecommendationPolicy service method.</param>
        /// <returns>The response from the PutAgentRecommendationPolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/PutAgentRecommendationPolicy">REST API Reference for PutAgentRecommendationPolicy Operation</seealso>
        PutAgentRecommendationPolicyResponse PutAgentRecommendationPolicy(PutAgentRecommendationPolicyRequest request);
#endif

        /// <summary>
        /// Attaches or replaces a resource-based policy on an individual Agent Recommendation.
        /// The policy controls cross-account access to the recommendation and its child resources
        /// such as items and remediations. The recommendation owner or any principal with profile
        /// write access on the parent profile can call this operation. The policy must be valid
        /// IAM JSON with Allow-only statements and no negation condition operators.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAgentRecommendationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutAgentRecommendationPolicy service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/PutAgentRecommendationPolicy">REST API Reference for PutAgentRecommendationPolicy Operation</seealso>
        Task<PutAgentRecommendationPolicyResponse> PutAgentRecommendationPolicyAsync(PutAgentRecommendationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Writes the data artifact for a completed Organizational Report directly into a caller-owned
        /// S3 bucket. The artifact is written in the requested format to the supplied bucketArn
        /// and objectKey, and the resulting S3 location is returned in deliveredTo. This operation
        /// creates an S3 object and should not be retried indiscriminately. To download the artifact
        /// through a short-lived presigned URL instead, use GetAgentOrganizationalReportData.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendAgentOrganizationalReportDataToS3 service method.</param>
        /// <returns>The response from the SendAgentOrganizationalReportDataToS3 service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/SendAgentOrganizationalReportDataToS3">REST API Reference for SendAgentOrganizationalReportDataToS3 Operation</seealso>
        SendAgentOrganizationalReportDataToS3Response SendAgentOrganizationalReportDataToS3(SendAgentOrganizationalReportDataToS3Request request);
#endif

        /// <summary>
        /// Writes the data artifact for a completed Organizational Report directly into a caller-owned
        /// S3 bucket. The artifact is written in the requested format to the supplied bucketArn
        /// and objectKey, and the resulting S3 location is returned in deliveredTo. This operation
        /// creates an S3 object and should not be retried indiscriminately. To download the artifact
        /// through a short-lived presigned URL instead, use GetAgentOrganizationalReportData.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendAgentOrganizationalReportDataToS3 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SendAgentOrganizationalReportDataToS3 service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/SendAgentOrganizationalReportDataToS3">REST API Reference for SendAgentOrganizationalReportDataToS3 Operation</seealso>
        Task<SendAgentOrganizationalReportDataToS3Response> SendAgentOrganizationalReportDataToS3Async(SendAgentOrganizationalReportDataToS3Request request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Starts a recommendation generation process for the specified agent profile. This asynchronous
        /// operation returns immediately. Use <c>GetAgentRecommendationGeneration</c> to check
        /// the status of the generation.
        /// 
        ///  
        /// <para>
        /// Currently, only the <c>ARCHITECTURE</c> recommendation type is supported. <c>RESOURCE</c>
        /// and <c>APPLICATION</c> recommendations are generated only by the scheduled generation
        /// cycle and cannot be started with this operation.
        /// </para>
        ///  
        /// <para>
        /// For the <c>ARCHITECTURE</c> type, the generation analyzes the infrastructure as code
        /// (IaC) template that you specify in <c>additionalContext</c>, and returns updated templates
        /// with best practice fixes applied. You must specify <c>scope</c> and <c>additionalContext</c>.
        /// You can optionally specify <c>name</c>.
        /// </para>
        ///  
        /// <para>
        /// Architecture review generations are subject to a daily quota for each profile. For
        /// more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/agent-quotas.html">Quotas
        /// and limits</a> in the Amazon Web Services Well-Architected User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAgentRecommendationGeneration service method.</param>
        /// <returns>The response from the StartAgentRecommendationGeneration service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/StartAgentRecommendationGeneration">REST API Reference for StartAgentRecommendationGeneration Operation</seealso>
        StartAgentRecommendationGenerationResponse StartAgentRecommendationGeneration(StartAgentRecommendationGenerationRequest request);
#endif

        /// <summary>
        /// Starts a recommendation generation process for the specified agent profile. This asynchronous
        /// operation returns immediately. Use <c>GetAgentRecommendationGeneration</c> to check
        /// the status of the generation.
        /// 
        ///  
        /// <para>
        /// Currently, only the <c>ARCHITECTURE</c> recommendation type is supported. <c>RESOURCE</c>
        /// and <c>APPLICATION</c> recommendations are generated only by the scheduled generation
        /// cycle and cannot be started with this operation.
        /// </para>
        ///  
        /// <para>
        /// For the <c>ARCHITECTURE</c> type, the generation analyzes the infrastructure as code
        /// (IaC) template that you specify in <c>additionalContext</c>, and returns updated templates
        /// with best practice fixes applied. You must specify <c>scope</c> and <c>additionalContext</c>.
        /// You can optionally specify <c>name</c>.
        /// </para>
        ///  
        /// <para>
        /// Architecture review generations are subject to a daily quota for each profile. For
        /// more information, see <a href="https://docs.aws.amazon.com/wellarchitected/latest/userguide/agent-quotas.html">Quotas
        /// and limits</a> in the Amazon Web Services Well-Architected User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAgentRecommendationGeneration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the StartAgentRecommendationGeneration service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/StartAgentRecommendationGeneration">REST API Reference for StartAgentRecommendationGeneration Operation</seealso>
        Task<StartAgentRecommendationGenerationResponse> StartAgentRecommendationGenerationAsync(StartAgentRecommendationGenerationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be a workload ARN, a custom lens ARN, a profile ARN,
        /// or review template ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <returns>The response from the TagResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);
#endif

        /// <summary>
        /// Adds one or more tags to the specified resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be a workload ARN, a custom lens ARN, a profile ARN,
        /// or review template ARN.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TagResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes specified tags from a resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be a workload ARN, a custom lens ARN, a profile ARN,
        /// or review template ARN.
        /// </para>
        ///  </note> 
        /// <para>
        /// To specify multiple tags, use separate <b>tagKeys</b> parameters, for example:
        /// </para>
        ///  
        /// <para>
        ///  <c>DELETE /tags/WorkloadArn?tagKeys=key1&amp;tagKeys=key2</c> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <returns>The response from the UntagResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);
#endif

        /// <summary>
        /// Deletes specified tags from a resource.
        /// 
        ///  <note> 
        /// <para>
        /// The WorkloadArn parameter can be a workload ARN, a custom lens ARN, a profile ARN,
        /// or review template ARN.
        /// </para>
        ///  </note> 
        /// <para>
        /// To specify multiple tags, use separate <b>tagKeys</b> parameters, for example:
        /// </para>
        ///  
        /// <para>
        ///  <c>DELETE /tags/WorkloadArn?tagKeys=key1&amp;tagKeys=key2</c> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UntagResource service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing context associated with a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentContext service method.</param>
        /// <returns>The response from the UpdateAgentContext service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAgentContext">REST API Reference for UpdateAgentContext Operation</seealso>
        UpdateAgentContextResponse UpdateAgentContext(UpdateAgentContextRequest request);
#endif

        /// <summary>
        /// Updates an existing context associated with a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentContext service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAgentContext service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAgentContext">REST API Reference for UpdateAgentContext Operation</seealso>
        Task<UpdateAgentContextResponse> UpdateAgentContextAsync(UpdateAgentContextRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the pillars and title of an existing goal associated with a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentGoal service method.</param>
        /// <returns>The response from the UpdateAgentGoal service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAgentGoal">REST API Reference for UpdateAgentGoal Operation</seealso>
        UpdateAgentGoalResponse UpdateAgentGoal(UpdateAgentGoalRequest request);
#endif

        /// <summary>
        /// Updates the pillars and title of an existing goal associated with a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentGoal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAgentGoal service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAgentGoal">REST API Reference for UpdateAgentGoal Operation</seealso>
        Task<UpdateAgentGoalResponse> UpdateAgentGoalAsync(UpdateAgentGoalRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an Organizational Profile. Organizational Profiles are specific to Profiles
        /// created using AWS Organizations integration. Include only the fields you want to change;
        /// any field you omit from the request keeps its current value.
        /// 
        ///  
        /// <para>
        /// To clear an optional text field, supply an empty string for it; the field is then
        /// unset, and a subsequent read omits it rather than returning an empty string. Omitting
        /// the field from the request leaves the stored value in place. <c>description</c> and
        /// <c>businessOverview</c> can be cleared this way. <c>displayName</c> cannot be cleared
        /// because a display name is required, though you can change it. <c>pillars</c> cannot
        /// be cleared because a profile must target at least one pillar.
        /// </para>
        ///  
        /// <para>
        ///  <c>organizationalAggregationConfiguration</c> behaves differently because it is a
        /// structure rather than a text field. Supplying it with both its <c>organizationalUnits</c>
        /// and <c>accounts</c> lists empty removes every monitored organizational unit and account,
        /// but the field itself remains set: a subsequent read returns the structure with two
        /// empty lists rather than omitting it. Omitting the field from the request keeps the
        /// stored boundary.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentOrganizationalProfile service method.</param>
        /// <returns>The response from the UpdateAgentOrganizationalProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAgentOrganizationalProfile">REST API Reference for UpdateAgentOrganizationalProfile Operation</seealso>
        UpdateAgentOrganizationalProfileResponse UpdateAgentOrganizationalProfile(UpdateAgentOrganizationalProfileRequest request);
#endif

        /// <summary>
        /// Updates an Organizational Profile. Organizational Profiles are specific to Profiles
        /// created using AWS Organizations integration. Include only the fields you want to change;
        /// any field you omit from the request keeps its current value.
        /// 
        ///  
        /// <para>
        /// To clear an optional text field, supply an empty string for it; the field is then
        /// unset, and a subsequent read omits it rather than returning an empty string. Omitting
        /// the field from the request leaves the stored value in place. <c>description</c> and
        /// <c>businessOverview</c> can be cleared this way. <c>displayName</c> cannot be cleared
        /// because a display name is required, though you can change it. <c>pillars</c> cannot
        /// be cleared because a profile must target at least one pillar.
        /// </para>
        ///  
        /// <para>
        ///  <c>organizationalAggregationConfiguration</c> behaves differently because it is a
        /// structure rather than a text field. Supplying it with both its <c>organizationalUnits</c>
        /// and <c>accounts</c> lists empty removes every monitored organizational unit and account,
        /// but the field itself remains set: a subsequent read returns the structure with two
        /// empty lists rather than omitting it. Omitting the field from the request keeps the
        /// stored boundary.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentOrganizationalProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAgentOrganizationalProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAgentOrganizationalProfile">REST API Reference for UpdateAgentOrganizationalProfile Operation</seealso>
        Task<UpdateAgentOrganizationalProfileResponse> UpdateAgentOrganizationalProfileAsync(UpdateAgentOrganizationalProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing optimization profile's configuration, including its pillars, execution
        /// role, and aggregation settings. Include only the fields you want to change. Any field
        /// you omit from the request keeps its current value, so you do not need to retrieve
        /// the profile first and resend the fields you are not changing.
        /// 
        ///  
        /// <para>
        /// To clear an optional text field, supply an empty string for it; the field is then
        /// unset, and a subsequent read omits it rather than returning an empty string. Omitting
        /// the field from the request leaves the stored value in place. <c>description</c> and
        /// <c>businessOverview</c> can be cleared this way. <c>displayName</c> cannot be cleared
        /// because a display name is required, though you can change it. <c>pillars</c> cannot
        /// be cleared because a profile must target at least one pillar.
        /// </para>
        ///  
        /// <para>
        ///  <c>aggregationConfiguration</c> behaves differently because it is a list of per-account
        /// configurations rather than a text field. Supplying an empty list removes every account
        /// entry, but the field itself remains set: a subsequent read returns an empty list rather
        /// than omitting the field. Omitting it from the request keeps the stored entries.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentProfile service method.</param>
        /// <returns>The response from the UpdateAgentProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAgentProfile">REST API Reference for UpdateAgentProfile Operation</seealso>
        UpdateAgentProfileResponse UpdateAgentProfile(UpdateAgentProfileRequest request);
#endif

        /// <summary>
        /// Updates an existing optimization profile's configuration, including its pillars, execution
        /// role, and aggregation settings. Include only the fields you want to change. Any field
        /// you omit from the request keeps its current value, so you do not need to retrieve
        /// the profile first and resend the fields you are not changing.
        /// 
        ///  
        /// <para>
        /// To clear an optional text field, supply an empty string for it; the field is then
        /// unset, and a subsequent read omits it rather than returning an empty string. Omitting
        /// the field from the request leaves the stored value in place. <c>description</c> and
        /// <c>businessOverview</c> can be cleared this way. <c>displayName</c> cannot be cleared
        /// because a display name is required, though you can change it. <c>pillars</c> cannot
        /// be cleared because a profile must target at least one pillar.
        /// </para>
        ///  
        /// <para>
        ///  <c>aggregationConfiguration</c> behaves differently because it is a list of per-account
        /// configurations rather than a text field. Supplying an empty list removes every account
        /// entry, but the field itself remains set: a subsequent read returns an empty list rather
        /// than omitting the field. Omitting it from the request keeps the stored entries.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAgentProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAgentProfile">REST API Reference for UpdateAgentProfile Operation</seealso>
        Task<UpdateAgentProfileResponse> UpdateAgentProfileAsync(UpdateAgentProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the status of a recommendation to track its progress through the implementation
        /// lifecycle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRecommendationStatus service method.</param>
        /// <returns>The response from the UpdateAgentRecommendationStatus service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAgentRecommendationStatus">REST API Reference for UpdateAgentRecommendationStatus Operation</seealso>
        UpdateAgentRecommendationStatusResponse UpdateAgentRecommendationStatus(UpdateAgentRecommendationStatusRequest request);
#endif

        /// <summary>
        /// Updates the status of a recommendation to track its progress through the implementation
        /// lifecycle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentRecommendationStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAgentRecommendationStatus service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAgentRecommendationStatus">REST API Reference for UpdateAgentRecommendationStatus Operation</seealso>
        Task<UpdateAgentRecommendationStatusResponse> UpdateAgentRecommendationStatusAsync(UpdateAgentRecommendationStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update the answer to a specific question in a workload review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnswer service method.</param>
        /// <returns>The response from the UpdateAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAnswer">REST API Reference for UpdateAnswer Operation</seealso>
        UpdateAnswerResponse UpdateAnswer(UpdateAnswerRequest request);
#endif

        /// <summary>
        /// Update the answer to a specific question in a workload review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateAnswer">REST API Reference for UpdateAnswer Operation</seealso>
        Task<UpdateAnswerResponse> UpdateAnswerAsync(UpdateAnswerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update whether the Amazon Web Services account is opted into organization sharing
        /// and discovery integration features.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        UpdateGlobalSettingsResponse UpdateGlobalSettings(UpdateGlobalSettingsRequest request);
#endif

        /// <summary>
        /// Update whether the Amazon Web Services account is opted into organization sharing
        /// and discovery integration features.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateGlobalSettings service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateGlobalSettings">REST API Reference for UpdateGlobalSettings Operation</seealso>
        Task<UpdateGlobalSettingsResponse> UpdateGlobalSettingsAsync(UpdateGlobalSettingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update integration features.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <returns>The response from the UpdateIntegration service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request);
#endif

        /// <summary>
        /// Update integration features.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateIntegration service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateIntegration">REST API Reference for UpdateIntegration Operation</seealso>
        Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update lens review for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLensReview service method.</param>
        /// <returns>The response from the UpdateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateLensReview">REST API Reference for UpdateLensReview Operation</seealso>
        UpdateLensReviewResponse UpdateLensReview(UpdateLensReviewRequest request);
#endif

        /// <summary>
        /// Update lens review for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLensReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateLensReview">REST API Reference for UpdateLensReview Operation</seealso>
        Task<UpdateLensReviewResponse> UpdateLensReviewAsync(UpdateLensReviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// <returns>The response from the UpdateProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        UpdateProfileResponse UpdateProfile(UpdateProfileRequest request);
#endif

        /// <summary>
        /// Update a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateProfile service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update a review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReviewTemplate service method.</param>
        /// <returns>The response from the UpdateReviewTemplate service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateReviewTemplate">REST API Reference for UpdateReviewTemplate Operation</seealso>
        UpdateReviewTemplateResponse UpdateReviewTemplate(UpdateReviewTemplateRequest request);
#endif

        /// <summary>
        /// Update a review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReviewTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateReviewTemplate service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateReviewTemplate">REST API Reference for UpdateReviewTemplate Operation</seealso>
        Task<UpdateReviewTemplateResponse> UpdateReviewTemplateAsync(UpdateReviewTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update a review template answer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReviewTemplateAnswer service method.</param>
        /// <returns>The response from the UpdateReviewTemplateAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateReviewTemplateAnswer">REST API Reference for UpdateReviewTemplateAnswer Operation</seealso>
        UpdateReviewTemplateAnswerResponse UpdateReviewTemplateAnswer(UpdateReviewTemplateAnswerRequest request);
#endif

        /// <summary>
        /// Update a review template answer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReviewTemplateAnswer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateReviewTemplateAnswer service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateReviewTemplateAnswer">REST API Reference for UpdateReviewTemplateAnswer Operation</seealso>
        Task<UpdateReviewTemplateAnswerResponse> UpdateReviewTemplateAnswerAsync(UpdateReviewTemplateAnswerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update a lens review associated with a review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReviewTemplateLensReview service method.</param>
        /// <returns>The response from the UpdateReviewTemplateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateReviewTemplateLensReview">REST API Reference for UpdateReviewTemplateLensReview Operation</seealso>
        UpdateReviewTemplateLensReviewResponse UpdateReviewTemplateLensReview(UpdateReviewTemplateLensReviewRequest request);
#endif

        /// <summary>
        /// Update a lens review associated with a review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReviewTemplateLensReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateReviewTemplateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateReviewTemplateLensReview">REST API Reference for UpdateReviewTemplateLensReview Operation</seealso>
        Task<UpdateReviewTemplateLensReviewResponse> UpdateReviewTemplateLensReviewAsync(UpdateReviewTemplateLensReviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update a workload or custom lens share invitation.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation can be called independently of any resource. Previous documentation
        /// implied that a workload ARN must be specified.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateShareInvitation service method.</param>
        /// <returns>The response from the UpdateShareInvitation service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateShareInvitation">REST API Reference for UpdateShareInvitation Operation</seealso>
        UpdateShareInvitationResponse UpdateShareInvitation(UpdateShareInvitationRequest request);
#endif

        /// <summary>
        /// Update a workload or custom lens share invitation.
        /// 
        ///  <note> 
        /// <para>
        /// This API operation can be called independently of any resource. Previous documentation
        /// implied that a workload ARN must be specified.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateShareInvitation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateShareInvitation service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateShareInvitation">REST API Reference for UpdateShareInvitation Operation</seealso>
        Task<UpdateShareInvitationResponse> UpdateShareInvitationAsync(UpdateShareInvitationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkload service method.</param>
        /// <returns>The response from the UpdateWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        UpdateWorkloadResponse UpdateWorkload(UpdateWorkloadRequest request);
#endif

        /// <summary>
        /// Update an existing workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateWorkload service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkload">REST API Reference for UpdateWorkload Operation</seealso>
        Task<UpdateWorkloadResponse> UpdateWorkloadAsync(UpdateWorkloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Update a workload share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadShare service method.</param>
        /// <returns>The response from the UpdateWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkloadShare">REST API Reference for UpdateWorkloadShare Operation</seealso>
        UpdateWorkloadShareResponse UpdateWorkloadShare(UpdateWorkloadShareRequest request);
#endif

        /// <summary>
        /// Update a workload share.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkloadShare service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateWorkloadShare service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpdateWorkloadShare">REST API Reference for UpdateWorkloadShare Operation</seealso>
        Task<UpdateWorkloadShareResponse> UpdateWorkloadShareAsync(UpdateWorkloadShareRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Upgrade lens review for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeLensReview service method.</param>
        /// <returns>The response from the UpgradeLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeLensReview">REST API Reference for UpgradeLensReview Operation</seealso>
        UpgradeLensReviewResponse UpgradeLensReview(UpgradeLensReviewRequest request);
#endif

        /// <summary>
        /// Upgrade lens review for a particular workload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeLensReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpgradeLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeLensReview">REST API Reference for UpgradeLensReview Operation</seealso>
        Task<UpgradeLensReviewResponse> UpgradeLensReviewAsync(UpgradeLensReviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Upgrade a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeProfileVersion service method.</param>
        /// <returns>The response from the UpgradeProfileVersion service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeProfileVersion">REST API Reference for UpgradeProfileVersion Operation</seealso>
        UpgradeProfileVersionResponse UpgradeProfileVersion(UpgradeProfileVersionRequest request);
#endif

        /// <summary>
        /// Upgrade a profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeProfileVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpgradeProfileVersion service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ServiceQuotaExceededException">
        /// The user has reached their resource quota.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeProfileVersion">REST API Reference for UpgradeProfileVersion Operation</seealso>
        Task<UpgradeProfileVersionResponse> UpgradeProfileVersionAsync(UpgradeProfileVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Upgrade the lens review of a review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeReviewTemplateLensReview service method.</param>
        /// <returns>The response from the UpgradeReviewTemplateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeReviewTemplateLensReview">REST API Reference for UpgradeReviewTemplateLensReview Operation</seealso>
        UpgradeReviewTemplateLensReviewResponse UpgradeReviewTemplateLensReview(UpgradeReviewTemplateLensReviewRequest request);
#endif

        /// <summary>
        /// Upgrade the lens review of a review template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeReviewTemplateLensReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpgradeReviewTemplateLensReview service method, as returned by WellArchitected.</returns>
        /// <exception cref="Amazon.WellArchitected.Model.AccessDeniedException">
        /// User does not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ConflictException">
        /// The resource has already been processed, was deleted, or is too large.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.InternalServerException">
        /// There is a problem with the Well-Architected Tool API service.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.WellArchitected.Model.ValidationException">
        /// The user input is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/wellarchitected-2020-03-31/UpgradeReviewTemplateLensReview">REST API Reference for UpgradeReviewTemplateLensReview Operation</seealso>
        Task<UpgradeReviewTemplateLensReviewResponse> UpgradeReviewTemplateLensReviewAsync(UpgradeReviewTemplateLensReviewRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonWellArchitectedConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonWellArchitectedConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonWellArchitectedConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonWellArchitectedConfig to create AmazonWellArchitectedClient");
            }

            return awsCredentials == null ?
                    new AmazonWellArchitectedClient(serviceClientConfig) :
                    new AmazonWellArchitectedClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
