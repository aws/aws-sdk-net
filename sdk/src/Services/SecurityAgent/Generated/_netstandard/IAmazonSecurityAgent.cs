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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SecurityAgent.Model;

#pragma warning disable CS1570
namespace Amazon.SecurityAgent
{
    /// <summary>
    /// <para>Interface for accessing SecurityAgent</para>
    ///
    /// AWS Security Agent is a frontier agent that proactively secures your applications
    /// throughout the development lifecycle. It conducts automated security reviews tailored
    /// to your organizational requirements and delivers context-aware penetration testing
    /// on demand. By continuously validating security from design to deployment, AWS Security
    /// Agent helps prevent vulnerabilities early across all your environments. Key capabilities
    /// include design security review for architecture documents, code security review for
    /// pull requests in connected repositories, and on-demand penetration testing that discovers,
    /// validates, and remediates security vulnerabilities through tailored multi-step attack
    /// scenarios. For more information, see the <a href="https://docs.aws.amazon.com/securityagent/latest/userguide/what-is.html">AWS
    /// Security Agent User Guide</a>.
    /// </summary>
    public partial interface IAmazonSecurityAgent : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISecurityAgentPaginatorFactory Paginators { get; }
#endif
                
        #region  AddArtifact



        /// <summary>
        /// Uploads an artifact to an agent space. Artifacts provide additional context for security
        /// testing, such as architecture diagrams, API specifications, or configuration files.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/AddArtifact">REST API Reference for AddArtifact Operation</seealso>
        Task<AddArtifactResponse> AddArtifactAsync(AddArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchCreateSecurityRequirements



        /// <summary>
        /// Batch creates security requirements in a customer managed pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchCreateSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota. Review your current usage and request a quota
        /// increase if needed.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchCreateSecurityRequirements">REST API Reference for BatchCreateSecurityRequirements Operation</seealso>
        Task<BatchCreateSecurityRequirementsResponse> BatchCreateSecurityRequirementsAsync(BatchCreateSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteCodeReviews



        /// <summary>
        /// Deletes one or more code reviews from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteCodeReviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteCodeReviews service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeleteCodeReviews">REST API Reference for BatchDeleteCodeReviews Operation</seealso>
        Task<BatchDeleteCodeReviewsResponse> BatchDeleteCodeReviewsAsync(BatchDeleteCodeReviewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeletePentests



        /// <summary>
        /// Deletes one or more pentests from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePentests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeletePentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeletePentests">REST API Reference for BatchDeletePentests Operation</seealso>
        Task<BatchDeletePentestsResponse> BatchDeletePentestsAsync(BatchDeletePentestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteSecurityRequirements



        /// <summary>
        /// Batch deletes security requirements from a customer managed pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeleteSecurityRequirements">REST API Reference for BatchDeleteSecurityRequirements Operation</seealso>
        Task<BatchDeleteSecurityRequirementsResponse> BatchDeleteSecurityRequirementsAsync(BatchDeleteSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchDeleteThreatModels



        /// <summary>
        /// Deletes one or more threat models from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteThreatModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteThreatModels service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeleteThreatModels">REST API Reference for BatchDeleteThreatModels Operation</seealso>
        Task<BatchDeleteThreatModelsResponse> BatchDeleteThreatModelsAsync(BatchDeleteThreatModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetAgentSpaces



        /// <summary>
        /// Retrieves information about one or more agent spaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAgentSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetAgentSpaces service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetAgentSpaces">REST API Reference for BatchGetAgentSpaces Operation</seealso>
        Task<BatchGetAgentSpacesResponse> BatchGetAgentSpacesAsync(BatchGetAgentSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetArtifactMetadata



        /// <summary>
        /// Retrieves metadata for one or more artifacts in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetArtifactMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetArtifactMetadata service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetArtifactMetadata">REST API Reference for BatchGetArtifactMetadata Operation</seealso>
        Task<BatchGetArtifactMetadataResponse> BatchGetArtifactMetadataAsync(BatchGetArtifactMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetCodeReviewJobs



        /// <summary>
        /// Retrieves information about one or more code review jobs in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeReviewJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCodeReviewJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetCodeReviewJobs">REST API Reference for BatchGetCodeReviewJobs Operation</seealso>
        Task<BatchGetCodeReviewJobsResponse> BatchGetCodeReviewJobsAsync(BatchGetCodeReviewJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetCodeReviewJobTasks



        /// <summary>
        /// Retrieves information about one or more tasks within a code review job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeReviewJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCodeReviewJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetCodeReviewJobTasks">REST API Reference for BatchGetCodeReviewJobTasks Operation</seealso>
        Task<BatchGetCodeReviewJobTasksResponse> BatchGetCodeReviewJobTasksAsync(BatchGetCodeReviewJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetCodeReviews



        /// <summary>
        /// Retrieves information about one or more code reviews in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCodeReviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetCodeReviews service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetCodeReviews">REST API Reference for BatchGetCodeReviews Operation</seealso>
        Task<BatchGetCodeReviewsResponse> BatchGetCodeReviewsAsync(BatchGetCodeReviewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetFindings



        /// <summary>
        /// Retrieves information about one or more security findings in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetFindings service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetFindings">REST API Reference for BatchGetFindings Operation</seealso>
        Task<BatchGetFindingsResponse> BatchGetFindingsAsync(BatchGetFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetPentestJobs



        /// <summary>
        /// Retrieves information about one or more pentest jobs in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentestJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPentestJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentestJobs">REST API Reference for BatchGetPentestJobs Operation</seealso>
        Task<BatchGetPentestJobsResponse> BatchGetPentestJobsAsync(BatchGetPentestJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetPentestJobTasks



        /// <summary>
        /// Retrieves information about one or more tasks within a pentest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentestJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPentestJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentestJobTasks">REST API Reference for BatchGetPentestJobTasks Operation</seealso>
        Task<BatchGetPentestJobTasksResponse> BatchGetPentestJobTasksAsync(BatchGetPentestJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetPentests



        /// <summary>
        /// Retrieves information about one or more pentests in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentests">REST API Reference for BatchGetPentests Operation</seealso>
        Task<BatchGetPentestsResponse> BatchGetPentestsAsync(BatchGetPentestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetSecurityRequirements



        /// <summary>
        /// Batch retrieves security requirements from a pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetSecurityRequirements">REST API Reference for BatchGetSecurityRequirements Operation</seealso>
        Task<BatchGetSecurityRequirementsResponse> BatchGetSecurityRequirementsAsync(BatchGetSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetTargetDomains



        /// <summary>
        /// Retrieves information about one or more target domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTargetDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetTargetDomains service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetTargetDomains">REST API Reference for BatchGetTargetDomains Operation</seealso>
        Task<BatchGetTargetDomainsResponse> BatchGetTargetDomainsAsync(BatchGetTargetDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetThreatModelJobs



        /// <summary>
        /// Retrieves information about one or more threat model jobs in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetThreatModelJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetThreatModelJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetThreatModelJobs">REST API Reference for BatchGetThreatModelJobs Operation</seealso>
        Task<BatchGetThreatModelJobsResponse> BatchGetThreatModelJobsAsync(BatchGetThreatModelJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetThreatModelJobTasks



        /// <summary>
        /// Retrieves information about one or more tasks within a threat model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetThreatModelJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetThreatModelJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetThreatModelJobTasks">REST API Reference for BatchGetThreatModelJobTasks Operation</seealso>
        Task<BatchGetThreatModelJobTasksResponse> BatchGetThreatModelJobTasksAsync(BatchGetThreatModelJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetThreatModels



        /// <summary>
        /// Retrieves information about one or more threat models in an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetThreatModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetThreatModels service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetThreatModels">REST API Reference for BatchGetThreatModels Operation</seealso>
        Task<BatchGetThreatModelsResponse> BatchGetThreatModelsAsync(BatchGetThreatModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchGetThreats



        /// <summary>
        /// Retrieves information about one or more threats.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetThreats service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetThreats service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetThreats">REST API Reference for BatchGetThreats Operation</seealso>
        Task<BatchGetThreatsResponse> BatchGetThreatsAsync(BatchGetThreatsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchUpdateSecurityRequirements



        /// <summary>
        /// Batch updates security requirements within a customer managed pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchUpdateSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchUpdateSecurityRequirements">REST API Reference for BatchUpdateSecurityRequirements Operation</seealso>
        Task<BatchUpdateSecurityRequirementsResponse> BatchUpdateSecurityRequirementsAsync(BatchUpdateSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAgentSpace



        /// <summary>
        /// Creates a new agent space. An agent space is a dedicated workspace for securing a
        /// specific application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateAgentSpace">REST API Reference for CreateAgentSpace Operation</seealso>
        Task<CreateAgentSpaceResponse> CreateAgentSpaceAsync(CreateAgentSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApplication



        /// <summary>
        /// Creates a new application. An application is the top-level organizational unit that
        /// supports IAM Identity Center integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateCodeReview



        /// <summary>
        /// Creates a new code review configuration in an agent space. A code review defines the
        /// parameters for automated security-focused code analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCodeReview service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateCodeReview">REST API Reference for CreateCodeReview Operation</seealso>
        Task<CreateCodeReviewResponse> CreateCodeReviewAsync(CreateCodeReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIntegration



        /// <summary>
        /// Creates a new integration with a third-party provider, such as GitHub, for code review
        /// and remediation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateMembership



        /// <summary>
        /// Creates a new membership, granting a user access to an agent space within an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        Task<CreateMembershipResponse> CreateMembershipAsync(CreateMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePentest



        /// <summary>
        /// Creates a new pentest configuration in an agent space. A pentest defines the security
        /// test parameters, including target assets, risk type exclusions, and logging configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePentest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreatePentest">REST API Reference for CreatePentest Operation</seealso>
        Task<CreatePentestResponse> CreatePentestAsync(CreatePentestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePrivateConnection



        /// <summary>
        /// Creates a private connection for reaching a self-hosted provider instance over private
        /// networking using Amazon VPC Lattice.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrivateConnection service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreatePrivateConnection">REST API Reference for CreatePrivateConnection Operation</seealso>
        Task<CreatePrivateConnectionResponse> CreatePrivateConnectionAsync(CreatePrivateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSecurityRequirementPack



        /// <summary>
        /// Creates a customer managed security requirement pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityRequirementPack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityRequirementPack service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota. Review your current usage and request a quota
        /// increase if needed.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateSecurityRequirementPack">REST API Reference for CreateSecurityRequirementPack Operation</seealso>
        Task<CreateSecurityRequirementPackResponse> CreateSecurityRequirementPackAsync(CreateSecurityRequirementPackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTargetDomain



        /// <summary>
        /// Creates a new target domain for penetration testing. A target domain is a web domain
        /// that must be registered and verified before it can be tested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateTargetDomain">REST API Reference for CreateTargetDomain Operation</seealso>
        Task<CreateTargetDomainResponse> CreateTargetDomainAsync(CreateTargetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateThreat



        /// <summary>
        /// Creates a new threat under a threat model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThreat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateThreat service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateThreat">REST API Reference for CreateThreat Operation</seealso>
        Task<CreateThreatResponse> CreateThreatAsync(CreateThreatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateThreatModel



        /// <summary>
        /// Creates a new threat model configuration in an agent space. A threat model defines
        /// the parameters for automated threat analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThreatModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateThreatModel service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateThreatModel">REST API Reference for CreateThreatModel Operation</seealso>
        Task<CreateThreatModelResponse> CreateThreatModelAsync(CreateThreatModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAgentSpace



        /// <summary>
        /// Deletes an agent space and all of its associated resources, including pentests, findings,
        /// and artifacts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteAgentSpace">REST API Reference for DeleteAgentSpace Operation</seealso>
        Task<DeleteAgentSpaceResponse> DeleteAgentSpaceAsync(DeleteAgentSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplication



        /// <summary>
        /// Deletes an application and its associated configuration, including IAM Identity Center
        /// settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteArtifact



        /// <summary>
        /// Deletes an artifact from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteArtifact">REST API Reference for DeleteArtifact Operation</seealso>
        Task<DeleteArtifactResponse> DeleteArtifactAsync(DeleteArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIntegration



        /// <summary>
        /// Deletes an integration with a third-party provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteMembership



        /// <summary>
        /// Deletes a membership, revoking a user's access to an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMembership service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        Task<DeleteMembershipResponse> DeleteMembershipAsync(DeleteMembershipRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePrivateConnection



        /// <summary>
        /// Deletes a private connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrivateConnection service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeletePrivateConnection">REST API Reference for DeletePrivateConnection Operation</seealso>
        Task<DeletePrivateConnectionResponse> DeletePrivateConnectionAsync(DeletePrivateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSecurityRequirementPack



        /// <summary>
        /// Deletes a customer managed security requirement pack and all its associated security
        /// requirements.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityRequirementPack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityRequirementPack service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteSecurityRequirementPack">REST API Reference for DeleteSecurityRequirementPack Operation</seealso>
        Task<DeleteSecurityRequirementPackResponse> DeleteSecurityRequirementPackAsync(DeleteSecurityRequirementPackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTargetDomain



        /// <summary>
        /// Deletes a target domain registration. After deletion, the domain can no longer be
        /// used for penetration testing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteTargetDomain">REST API Reference for DeleteTargetDomain Operation</seealso>
        Task<DeleteTargetDomainResponse> DeleteTargetDomainAsync(DeleteTargetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePrivateConnection



        /// <summary>
        /// Retrieves the details of a private connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrivateConnection service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DescribePrivateConnection">REST API Reference for DescribePrivateConnection Operation</seealso>
        Task<DescribePrivateConnectionResponse> DescribePrivateConnectionAsync(DescribePrivateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplication



        /// <summary>
        /// Retrieves information about an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetArtifact



        /// <summary>
        /// Retrieves an artifact from an agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetArtifact">REST API Reference for GetArtifact Operation</seealso>
        Task<GetArtifactResponse> GetArtifactAsync(GetArtifactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetIntegration



        /// <summary>
        /// Retrieves information about an integration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetSecurityRequirementPack



        /// <summary>
        /// Retrieves information about a security requirement pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecurityRequirementPack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSecurityRequirementPack service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetSecurityRequirementPack">REST API Reference for GetSecurityRequirementPack Operation</seealso>
        Task<GetSecurityRequirementPackResponse> GetSecurityRequirementPackAsync(GetSecurityRequirementPackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportSecurityRequirements



        /// <summary>
        /// Imports security requirements from uploaded documents into a customer managed security
        /// requirement pack. The import process asynchronously extracts and generates structured
        /// security requirements from the provided source files.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota. Review your current usage and request a quota
        /// increase if needed.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ImportSecurityRequirements">REST API Reference for ImportSecurityRequirements Operation</seealso>
        Task<ImportSecurityRequirementsResponse> ImportSecurityRequirementsAsync(ImportSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InitiateProviderRegistration



        /// <summary>
        /// Initiates the OAuth registration flow with a third-party provider. Returns a redirect
        /// URL and CSRF state token for completing the authorization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateProviderRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateProviderRegistration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/InitiateProviderRegistration">REST API Reference for InitiateProviderRegistration Operation</seealso>
        Task<InitiateProviderRegistrationResponse> InitiateProviderRegistrationAsync(InitiateProviderRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAgentSpaces



        /// <summary>
        /// Returns a paginated list of agent space summaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentSpaces service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListAgentSpaces">REST API Reference for ListAgentSpaces Operation</seealso>
        Task<ListAgentSpacesResponse> ListAgentSpacesAsync(ListAgentSpacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplications



        /// <summary>
        /// Returns a paginated list of application summaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListArtifacts



        /// <summary>
        /// Returns a paginated list of artifact summaries for the specified agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCodeReviewJobsForCodeReview



        /// <summary>
        /// Returns a paginated list of code review job summaries for the specified code review
        /// configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviewJobsForCodeReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeReviewJobsForCodeReview service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListCodeReviewJobsForCodeReview">REST API Reference for ListCodeReviewJobsForCodeReview Operation</seealso>
        Task<ListCodeReviewJobsForCodeReviewResponse> ListCodeReviewJobsForCodeReviewAsync(ListCodeReviewJobsForCodeReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCodeReviewJobTasks



        /// <summary>
        /// Returns a paginated list of task summaries for the specified code review job, optionally
        /// filtered by step name or category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviewJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeReviewJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListCodeReviewJobTasks">REST API Reference for ListCodeReviewJobTasks Operation</seealso>
        Task<ListCodeReviewJobTasksResponse> ListCodeReviewJobTasksAsync(ListCodeReviewJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCodeReviews



        /// <summary>
        /// Returns a paginated list of code review summaries for the specified agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeReviews service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCodeReviews service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListCodeReviews">REST API Reference for ListCodeReviews Operation</seealso>
        Task<ListCodeReviewsResponse> ListCodeReviewsAsync(ListCodeReviewsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDiscoveredEndpoints



        /// <summary>
        /// Returns a paginated list of endpoints discovered during a pentest job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoveredEndpoints service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListDiscoveredEndpoints">REST API Reference for ListDiscoveredEndpoints Operation</seealso>
        Task<ListDiscoveredEndpointsResponse> ListDiscoveredEndpointsAsync(ListDiscoveredEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFindings



        /// <summary>
        /// Lists the security findings for a pentest job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListFindings">REST API Reference for ListFindings Operation</seealso>
        Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIntegratedResources



        /// <summary>
        /// Lists the integrated resources for an agent space, optionally filtered by integration
        /// or resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegratedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegratedResources service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListIntegratedResources">REST API Reference for ListIntegratedResources Operation</seealso>
        Task<ListIntegratedResourcesResponse> ListIntegratedResourcesAsync(ListIntegratedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIntegrations



        /// <summary>
        /// Lists the integrations in your account, optionally filtered by provider or provider
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        Task<ListIntegrationsResponse> ListIntegrationsAsync(ListIntegrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMemberships



        /// <summary>
        /// Returns a paginated list of membership summaries for the specified agent space within
        /// an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        Task<ListMembershipsResponse> ListMembershipsAsync(ListMembershipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPentestJobsForPentest



        /// <summary>
        /// Returns a paginated list of pentest job summaries for the specified pentest configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentestJobsForPentest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPentestJobsForPentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentestJobsForPentest">REST API Reference for ListPentestJobsForPentest Operation</seealso>
        Task<ListPentestJobsForPentestResponse> ListPentestJobsForPentestAsync(ListPentestJobsForPentestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPentestJobTasks



        /// <summary>
        /// Returns a paginated list of task summaries for the specified pentest job, optionally
        /// filtered by step name or category.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentestJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPentestJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentestJobTasks">REST API Reference for ListPentestJobTasks Operation</seealso>
        Task<ListPentestJobTasksResponse> ListPentestJobTasksAsync(ListPentestJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPentests



        /// <summary>
        /// Returns a paginated list of pentest summaries for the specified agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentests">REST API Reference for ListPentests Operation</seealso>
        Task<ListPentestsResponse> ListPentestsAsync(ListPentestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPrivateConnections



        /// <summary>
        /// Lists the private connections in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivateConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrivateConnections service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPrivateConnections">REST API Reference for ListPrivateConnections Operation</seealso>
        Task<ListPrivateConnectionsResponse> ListPrivateConnectionsAsync(ListPrivateConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSecurityRequirementPacks



        /// <summary>
        /// Lists all security requirement packs in the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityRequirementPacks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityRequirementPacks service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListSecurityRequirementPacks">REST API Reference for ListSecurityRequirementPacks Operation</seealso>
        Task<ListSecurityRequirementPacksResponse> ListSecurityRequirementPacksAsync(ListSecurityRequirementPacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSecurityRequirements



        /// <summary>
        /// Lists security requirements within a pack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityRequirements service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityRequirements service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListSecurityRequirements">REST API Reference for ListSecurityRequirements Operation</seealso>
        Task<ListSecurityRequirementsResponse> ListSecurityRequirementsAsync(ListSecurityRequirementsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTargetDomains



        /// <summary>
        /// Returns a paginated list of target domain summaries in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetDomains service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListTargetDomains">REST API Reference for ListTargetDomains Operation</seealso>
        Task<ListTargetDomainsResponse> ListTargetDomainsAsync(ListTargetDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListThreatModelJobs



        /// <summary>
        /// Returns a paginated list of threat model job summaries for the specified threat model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatModelJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThreatModelJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListThreatModelJobs">REST API Reference for ListThreatModelJobs Operation</seealso>
        Task<ListThreatModelJobsResponse> ListThreatModelJobsAsync(ListThreatModelJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListThreatModelJobTasks



        /// <summary>
        /// Returns a paginated list of task summaries for the specified threat model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatModelJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThreatModelJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListThreatModelJobTasks">REST API Reference for ListThreatModelJobTasks Operation</seealso>
        Task<ListThreatModelJobTasksResponse> ListThreatModelJobTasksAsync(ListThreatModelJobTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListThreatModels



        /// <summary>
        /// Returns a paginated list of threat model summaries for the specified agent space.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreatModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThreatModels service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListThreatModels">REST API Reference for ListThreatModels Operation</seealso>
        Task<ListThreatModelsResponse> ListThreatModelsAsync(ListThreatModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListThreats



        /// <summary>
        /// Returns a paginated list of threats for a threat model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThreats service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThreats service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListThreats">REST API Reference for ListThreats Operation</seealso>
        Task<ListThreatsResponse> ListThreatsAsync(ListThreatsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartCodeRemediation



        /// <summary>
        /// Initiates code remediation for one or more security findings. This creates pull requests
        /// in integrated repositories to fix the identified vulnerabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeRemediation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCodeRemediation service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartCodeRemediation">REST API Reference for StartCodeRemediation Operation</seealso>
        Task<StartCodeRemediationResponse> StartCodeRemediationAsync(StartCodeRemediationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartCodeReviewJob



        /// <summary>
        /// Starts a new code review job for a code review configuration. The job executes the
        /// security-focused code analysis defined in the code review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeReviewJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCodeReviewJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartCodeReviewJob">REST API Reference for StartCodeReviewJob Operation</seealso>
        Task<StartCodeReviewJobResponse> StartCodeReviewJobAsync(StartCodeReviewJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartPentestJob



        /// <summary>
        /// Starts a new pentest job for a pentest configuration. The job executes the security
        /// tests defined in the pentest.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPentestJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPentestJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartPentestJob">REST API Reference for StartPentestJob Operation</seealso>
        Task<StartPentestJobResponse> StartPentestJobAsync(StartPentestJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartThreatModelJob



        /// <summary>
        /// Starts a new threat model job for a threat model configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartThreatModelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartThreatModelJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartThreatModelJob">REST API Reference for StartThreatModelJob Operation</seealso>
        Task<StartThreatModelJobResponse> StartThreatModelJobAsync(StartThreatModelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopCodeReviewJob



        /// <summary>
        /// Stops a running code review job. The job transitions to a stopping state and then
        /// to stopped after cleanup completes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCodeReviewJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopCodeReviewJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StopCodeReviewJob">REST API Reference for StopCodeReviewJob Operation</seealso>
        Task<StopCodeReviewJobResponse> StopCodeReviewJobAsync(StopCodeReviewJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopPentestJob



        /// <summary>
        /// Stops a running pentest job. The job transitions to a stopping state and then to stopped
        /// after cleanup completes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPentestJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopPentestJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StopPentestJob">REST API Reference for StopPentestJob Operation</seealso>
        Task<StopPentestJobResponse> StopPentestJobAsync(StopPentestJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopThreatModelJob



        /// <summary>
        /// Stops a running threat model job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopThreatModelJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopThreatModelJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StopThreatModelJob">REST API Reference for StopThreatModelJob Operation</seealso>
        Task<StopThreatModelJobResponse> StopThreatModelJobAsync(StopThreatModelJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateAgentSpace



        /// <summary>
        /// Updates the configuration of an existing agent space, including its name, description,
        /// AWS resources, target domains, and code review settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateAgentSpace">REST API Reference for UpdateAgentSpace Operation</seealso>
        Task<UpdateAgentSpaceResponse> UpdateAgentSpaceAsync(UpdateAgentSpaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplication



        /// <summary>
        /// Updates the configuration of an existing application, including the IAM role and default
        /// KMS key.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateCodeReview



        /// <summary>
        /// Updates an existing code review configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeReview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCodeReview service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateCodeReview">REST API Reference for UpdateCodeReview Operation</seealso>
        Task<UpdateCodeReviewResponse> UpdateCodeReviewAsync(UpdateCodeReviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFinding



        /// <summary>
        /// Updates the status or risk level of a security finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFinding service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateFinding">REST API Reference for UpdateFinding Operation</seealso>
        Task<UpdateFindingResponse> UpdateFindingAsync(UpdateFindingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIntegratedResources



        /// <summary>
        /// Updates the integrated resources for an agent space, including their capabilities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegratedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIntegratedResources service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateIntegratedResources">REST API Reference for UpdateIntegratedResources Operation</seealso>
        Task<UpdateIntegratedResourcesResponse> UpdateIntegratedResourcesAsync(UpdateIntegratedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePentest



        /// <summary>
        /// Updates an existing pentest configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePentest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdatePentest">REST API Reference for UpdatePentest Operation</seealso>
        Task<UpdatePentestResponse> UpdatePentestAsync(UpdatePentestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePrivateConnectionCertificate



        /// <summary>
        /// Updates the certificate associated with a private connection. Certificates can be
        /// added or replaced but not removed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivateConnectionCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrivateConnectionCertificate service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdatePrivateConnectionCertificate">REST API Reference for UpdatePrivateConnectionCertificate Operation</seealso>
        Task<UpdatePrivateConnectionCertificateResponse> UpdatePrivateConnectionCertificateAsync(UpdatePrivateConnectionCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSecurityRequirementPack



        /// <summary>
        /// Updates a security requirement pack. For customer managed packs, both metadata and
        /// status can be updated. For AWS managed packs, only status can be updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityRequirementPack service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSecurityRequirementPack service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// An unexpected error occurred during the processing of your request.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// The specified resource was not found. Verify that the resource identifier is correct
        /// and that the resource exists in the specified agent space or account.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateSecurityRequirementPack">REST API Reference for UpdateSecurityRequirementPack Operation</seealso>
        Task<UpdateSecurityRequirementPackResponse> UpdateSecurityRequirementPackAsync(UpdateSecurityRequirementPackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTargetDomain



        /// <summary>
        /// Updates the verification method for a target domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateTargetDomain">REST API Reference for UpdateTargetDomain Operation</seealso>
        Task<UpdateTargetDomainResponse> UpdateTargetDomainAsync(UpdateTargetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateThreat



        /// <summary>
        /// Updates a threat.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThreat service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateThreat">REST API Reference for UpdateThreat Operation</seealso>
        Task<UpdateThreatResponse> UpdateThreatAsync(UpdateThreatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateThreatModel



        /// <summary>
        /// Updates an existing threat model configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThreatModel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateThreatModel service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateThreatModel">REST API Reference for UpdateThreatModel Operation</seealso>
        Task<UpdateThreatModelResponse> UpdateThreatModelAsync(UpdateThreatModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  VerifyTargetDomain



        /// <summary>
        /// Initiates verification of a target domain. This checks whether the domain ownership
        /// verification token has been properly configured.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/VerifyTargetDomain">REST API Reference for VerifyTargetDomain Operation</seealso>
        Task<VerifyTargetDomainResponse> VerifyTargetDomainAsync(VerifyTargetDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSecurityAgentConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSecurityAgentConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSecurityAgentConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSecurityAgentConfig to create AmazonSecurityAgentClient");
            }

            return awsCredentials == null ? 
                    new AmazonSecurityAgentClient(serviceClientConfig) :
                    new AmazonSecurityAgentClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}