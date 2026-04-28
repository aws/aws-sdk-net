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
    /// AWS Security Agent service documentation.
    /// </summary>
    public partial interface IAmazonSecurityAgent : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISecurityAgentPaginatorFactory Paginators { get; }

        
        #region  AddArtifact


        /// <summary>
        /// Adds an Artifact for the given agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddArtifact service method.</param>
        /// 
        /// <returns>The response from the AddArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/AddArtifact">REST API Reference for AddArtifact Operation</seealso>
        AddArtifactResponse AddArtifact(AddArtifactRequest request);



        /// <summary>
        /// Adds an Artifact for the given agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/AddArtifact">REST API Reference for AddArtifact Operation</seealso>
        Task<AddArtifactResponse> AddArtifactAsync(AddArtifactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeletePentests


        /// <summary>
        /// Deletes multiple pentests in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePentests service method.</param>
        /// 
        /// <returns>The response from the BatchDeletePentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeletePentests">REST API Reference for BatchDeletePentests Operation</seealso>
        BatchDeletePentestsResponse BatchDeletePentests(BatchDeletePentestsRequest request);



        /// <summary>
        /// Deletes multiple pentests in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeletePentests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeletePentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchDeletePentests">REST API Reference for BatchDeletePentests Operation</seealso>
        Task<BatchDeletePentestsResponse> BatchDeletePentestsAsync(BatchDeletePentestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetAgentSpaces


        /// <summary>
        /// Retrieves multiple agent spaces in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAgentSpaces service method.</param>
        /// 
        /// <returns>The response from the BatchGetAgentSpaces service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetAgentSpaces">REST API Reference for BatchGetAgentSpaces Operation</seealso>
        BatchGetAgentSpacesResponse BatchGetAgentSpaces(BatchGetAgentSpacesRequest request);



        /// <summary>
        /// Retrieves multiple agent spaces in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAgentSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetAgentSpaces service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetAgentSpaces">REST API Reference for BatchGetAgentSpaces Operation</seealso>
        Task<BatchGetAgentSpacesResponse> BatchGetAgentSpacesAsync(BatchGetAgentSpacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetArtifactMetadata


        /// <summary>
        /// Retrieve the list of artifact metadata for the given agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetArtifactMetadata service method.</param>
        /// 
        /// <returns>The response from the BatchGetArtifactMetadata service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetArtifactMetadata">REST API Reference for BatchGetArtifactMetadata Operation</seealso>
        BatchGetArtifactMetadataResponse BatchGetArtifactMetadata(BatchGetArtifactMetadataRequest request);



        /// <summary>
        /// Retrieve the list of artifact metadata for the given agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetArtifactMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetArtifactMetadata service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetArtifactMetadata">REST API Reference for BatchGetArtifactMetadata Operation</seealso>
        Task<BatchGetArtifactMetadataResponse> BatchGetArtifactMetadataAsync(BatchGetArtifactMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetFindings


        /// <summary>
        /// Retrieves multiple findings in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindings service method.</param>
        /// 
        /// <returns>The response from the BatchGetFindings service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetFindings">REST API Reference for BatchGetFindings Operation</seealso>
        BatchGetFindingsResponse BatchGetFindings(BatchGetFindingsRequest request);



        /// <summary>
        /// Retrieves multiple findings in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetFindings service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetFindings">REST API Reference for BatchGetFindings Operation</seealso>
        Task<BatchGetFindingsResponse> BatchGetFindingsAsync(BatchGetFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetPentestJobs


        /// <summary>
        /// Retrieves multiple pentest jobs in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentestJobs service method.</param>
        /// 
        /// <returns>The response from the BatchGetPentestJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentestJobs">REST API Reference for BatchGetPentestJobs Operation</seealso>
        BatchGetPentestJobsResponse BatchGetPentestJobs(BatchGetPentestJobsRequest request);



        /// <summary>
        /// Retrieves multiple pentest jobs in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentestJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPentestJobs service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentestJobs">REST API Reference for BatchGetPentestJobs Operation</seealso>
        Task<BatchGetPentestJobsResponse> BatchGetPentestJobsAsync(BatchGetPentestJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetPentestJobTasks


        /// <summary>
        /// Retrieves multiple tasks for a pentest job in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentestJobTasks service method.</param>
        /// 
        /// <returns>The response from the BatchGetPentestJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentestJobTasks">REST API Reference for BatchGetPentestJobTasks Operation</seealso>
        BatchGetPentestJobTasksResponse BatchGetPentestJobTasks(BatchGetPentestJobTasksRequest request);



        /// <summary>
        /// Retrieves multiple tasks for a pentest job in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentestJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPentestJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentestJobTasks">REST API Reference for BatchGetPentestJobTasks Operation</seealso>
        Task<BatchGetPentestJobTasksResponse> BatchGetPentestJobTasksAsync(BatchGetPentestJobTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetPentests


        /// <summary>
        /// Retrieves multiple pentests in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentests service method.</param>
        /// 
        /// <returns>The response from the BatchGetPentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentests">REST API Reference for BatchGetPentests Operation</seealso>
        BatchGetPentestsResponse BatchGetPentests(BatchGetPentestsRequest request);



        /// <summary>
        /// Retrieves multiple pentests in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetPentests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetPentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetPentests">REST API Reference for BatchGetPentests Operation</seealso>
        Task<BatchGetPentestsResponse> BatchGetPentestsAsync(BatchGetPentestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchGetTargetDomains


        /// <summary>
        /// Retrieves multiple target domains in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTargetDomains service method.</param>
        /// 
        /// <returns>The response from the BatchGetTargetDomains service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetTargetDomains">REST API Reference for BatchGetTargetDomains Operation</seealso>
        BatchGetTargetDomainsResponse BatchGetTargetDomains(BatchGetTargetDomainsRequest request);



        /// <summary>
        /// Retrieves multiple target domains in a single request
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetTargetDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetTargetDomains service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/BatchGetTargetDomains">REST API Reference for BatchGetTargetDomains Operation</seealso>
        Task<BatchGetTargetDomainsResponse> BatchGetTargetDomainsAsync(BatchGetTargetDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAgentSpace


        /// <summary>
        /// Creates an agent space record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentSpace service method.</param>
        /// 
        /// <returns>The response from the CreateAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateAgentSpace">REST API Reference for CreateAgentSpace Operation</seealso>
        CreateAgentSpaceResponse CreateAgentSpace(CreateAgentSpaceRequest request);



        /// <summary>
        /// Creates an agent space record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateAgentSpace">REST API Reference for CreateAgentSpace Operation</seealso>
        Task<CreateAgentSpaceResponse> CreateAgentSpaceAsync(CreateAgentSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateApplication


        /// <summary>
        /// Creates a new application
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        CreateApplicationResponse CreateApplication(CreateApplicationRequest request);



        /// <summary>
        /// Creates a new application
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateIntegration


        /// <summary>
        /// Creates the Integration of the Security Agent App with an external Provider
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// Request conflicts with current resource state
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        CreateIntegrationResponse CreateIntegration(CreateIntegrationRequest request);



        /// <summary>
        /// Creates the Integration of the Security Agent App with an external Provider
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// Request conflicts with current resource state
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateIntegration">REST API Reference for CreateIntegration Operation</seealso>
        Task<CreateIntegrationResponse> CreateIntegrationAsync(CreateIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateMembership


        /// <summary>
        /// Adds a single member to an agent space with specified role
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        CreateMembershipResponse CreateMembership(CreateMembershipRequest request);



        /// <summary>
        /// Adds a single member to an agent space with specified role
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMembership service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateMembership">REST API Reference for CreateMembership Operation</seealso>
        Task<CreateMembershipResponse> CreateMembershipAsync(CreateMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePentest


        /// <summary>
        /// Creates a new pentest configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePentest service method.</param>
        /// 
        /// <returns>The response from the CreatePentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreatePentest">REST API Reference for CreatePentest Operation</seealso>
        CreatePentestResponse CreatePentest(CreatePentestRequest request);



        /// <summary>
        /// Creates a new pentest configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePentest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreatePentest">REST API Reference for CreatePentest Operation</seealso>
        Task<CreatePentestResponse> CreatePentestAsync(CreatePentestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTargetDomain


        /// <summary>
        /// Creates a target domain record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetDomain service method.</param>
        /// 
        /// <returns>The response from the CreateTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateTargetDomain">REST API Reference for CreateTargetDomain Operation</seealso>
        CreateTargetDomainResponse CreateTargetDomain(CreateTargetDomainRequest request);



        /// <summary>
        /// Creates a target domain record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/CreateTargetDomain">REST API Reference for CreateTargetDomain Operation</seealso>
        Task<CreateTargetDomainResponse> CreateTargetDomainAsync(CreateTargetDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgentSpace


        /// <summary>
        /// Deletes an agent space record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentSpace service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteAgentSpace">REST API Reference for DeleteAgentSpace Operation</seealso>
        DeleteAgentSpaceResponse DeleteAgentSpace(DeleteAgentSpaceRequest request);



        /// <summary>
        /// Deletes an agent space record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteAgentSpace">REST API Reference for DeleteAgentSpace Operation</seealso>
        Task<DeleteAgentSpaceResponse> DeleteAgentSpaceAsync(DeleteAgentSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteApplication


        /// <summary>
        /// Deletes an application
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request);



        /// <summary>
        /// Deletes an application
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteArtifact


        /// <summary>
        /// Delete an Artifact from the given agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArtifact service method.</param>
        /// 
        /// <returns>The response from the DeleteArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteArtifact">REST API Reference for DeleteArtifact Operation</seealso>
        DeleteArtifactResponse DeleteArtifact(DeleteArtifactRequest request);



        /// <summary>
        /// Delete an Artifact from the given agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteArtifact">REST API Reference for DeleteArtifact Operation</seealso>
        Task<DeleteArtifactResponse> DeleteArtifactAsync(DeleteArtifactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIntegration


        /// <summary>
        /// Deletes the Integration of the Security Agent App with an external Provider
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// Request conflicts with current resource state
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request);



        /// <summary>
        /// Deletes the Integration of the Security Agent App with an external Provider
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// Request conflicts with current resource state
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMembership


        /// <summary>
        /// Removes a single member associated to an agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership service method.</param>
        /// 
        /// <returns>The response from the DeleteMembership service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        DeleteMembershipResponse DeleteMembership(DeleteMembershipRequest request);



        /// <summary>
        /// Removes a single member associated to an agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembership service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMembership service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteMembership">REST API Reference for DeleteMembership Operation</seealso>
        Task<DeleteMembershipResponse> DeleteMembershipAsync(DeleteMembershipRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTargetDomain


        /// <summary>
        /// Deletes a target domain record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteTargetDomain">REST API Reference for DeleteTargetDomain Operation</seealso>
        DeleteTargetDomainResponse DeleteTargetDomain(DeleteTargetDomainRequest request);



        /// <summary>
        /// Deletes a target domain record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/DeleteTargetDomain">REST API Reference for DeleteTargetDomain Operation</seealso>
        Task<DeleteTargetDomainResponse> DeleteTargetDomainAsync(DeleteTargetDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetApplication


        /// <summary>
        /// Retrieves application details by application ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetApplication">REST API Reference for GetApplication Operation</seealso>
        GetApplicationResponse GetApplication(GetApplicationRequest request);



        /// <summary>
        /// Retrieves application details by application ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetArtifact


        /// <summary>
        /// Retrieve an Artifact for the given agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArtifact service method.</param>
        /// 
        /// <returns>The response from the GetArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetArtifact">REST API Reference for GetArtifact Operation</seealso>
        GetArtifactResponse GetArtifact(GetArtifactRequest request);



        /// <summary>
        /// Retrieve an Artifact for the given agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetArtifact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetArtifact service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetArtifact">REST API Reference for GetArtifact Operation</seealso>
        Task<GetArtifactResponse> GetArtifactAsync(GetArtifactRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIntegration


        /// <summary>
        /// Gets Integration metadata from the provided id
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        GetIntegrationResponse GetIntegration(GetIntegrationRequest request);



        /// <summary>
        /// Gets Integration metadata from the provided id
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InitiateProviderRegistration


        /// <summary>
        /// Initiates the registration of Security Agent App for an external Provider
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateProviderRegistration service method.</param>
        /// 
        /// <returns>The response from the InitiateProviderRegistration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// Request conflicts with current resource state
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/InitiateProviderRegistration">REST API Reference for InitiateProviderRegistration Operation</seealso>
        InitiateProviderRegistrationResponse InitiateProviderRegistration(InitiateProviderRegistrationRequest request);



        /// <summary>
        /// Initiates the registration of Security Agent App for an external Provider
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateProviderRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateProviderRegistration service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// Request conflicts with current resource state
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/InitiateProviderRegistration">REST API Reference for InitiateProviderRegistration Operation</seealso>
        Task<InitiateProviderRegistrationResponse> InitiateProviderRegistrationAsync(InitiateProviderRegistrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgentSpaces


        /// <summary>
        /// Lists agent spaces
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentSpaces service method.</param>
        /// 
        /// <returns>The response from the ListAgentSpaces service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListAgentSpaces">REST API Reference for ListAgentSpaces Operation</seealso>
        ListAgentSpacesResponse ListAgentSpaces(ListAgentSpacesRequest request);



        /// <summary>
        /// Lists agent spaces
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentSpaces service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListAgentSpaces">REST API Reference for ListAgentSpaces Operation</seealso>
        Task<ListAgentSpacesResponse> ListAgentSpacesAsync(ListAgentSpacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListApplications


        /// <summary>
        /// Lists all applications in the account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListApplications">REST API Reference for ListApplications Operation</seealso>
        ListApplicationsResponse ListApplications(ListApplicationsRequest request);



        /// <summary>
        /// Lists all applications in the account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListArtifacts


        /// <summary>
        /// Lists the artifacts for the associated agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        ListArtifactsResponse ListArtifacts(ListArtifactsRequest request);



        /// <summary>
        /// Lists the artifacts for the associated agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListArtifacts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListArtifacts service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListArtifacts">REST API Reference for ListArtifacts Operation</seealso>
        Task<ListArtifactsResponse> ListArtifactsAsync(ListArtifactsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDiscoveredEndpoints


        /// <summary>
        /// Lists discovered endpoints associated with a pentest job with optional URI prefix
        /// filtering
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListDiscoveredEndpoints service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListDiscoveredEndpoints">REST API Reference for ListDiscoveredEndpoints Operation</seealso>
        ListDiscoveredEndpointsResponse ListDiscoveredEndpoints(ListDiscoveredEndpointsRequest request);



        /// <summary>
        /// Lists discovered endpoints associated with a pentest job with optional URI prefix
        /// filtering
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDiscoveredEndpoints service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListDiscoveredEndpoints">REST API Reference for ListDiscoveredEndpoints Operation</seealso>
        Task<ListDiscoveredEndpointsResponse> ListDiscoveredEndpointsAsync(ListDiscoveredEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListFindings


        /// <summary>
        /// Lists findings with filtering and pagination support. When filters are applied, the
        /// actual number of results returned may be less than the specified limit
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListFindings">REST API Reference for ListFindings Operation</seealso>
        ListFindingsResponse ListFindings(ListFindingsRequest request);



        /// <summary>
        /// Lists findings with filtering and pagination support. When filters are applied, the
        /// actual number of results returned may be less than the specified limit
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFindings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFindings service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListFindings">REST API Reference for ListFindings Operation</seealso>
        Task<ListFindingsResponse> ListFindingsAsync(ListFindingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIntegratedResources


        /// <summary>
        /// Lists the integrated resources for an agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegratedResources service method.</param>
        /// 
        /// <returns>The response from the ListIntegratedResources service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListIntegratedResources">REST API Reference for ListIntegratedResources Operation</seealso>
        ListIntegratedResourcesResponse ListIntegratedResources(ListIntegratedResourcesRequest request);



        /// <summary>
        /// Lists the integrated resources for an agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegratedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegratedResources service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListIntegratedResources">REST API Reference for ListIntegratedResources Operation</seealso>
        Task<ListIntegratedResourcesResponse> ListIntegratedResourcesAsync(ListIntegratedResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIntegrations


        /// <summary>
        /// Retrieves the Integrations associated with the user's account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        ListIntegrationsResponse ListIntegrations(ListIntegrationsRequest request);



        /// <summary>
        /// Retrieves the Integrations associated with the user's account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        Task<ListIntegrationsResponse> ListIntegrationsAsync(ListIntegrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListMemberships


        /// <summary>
        /// Lists all members associated to an agent space with pagination support
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        ListMembershipsResponse ListMemberships(ListMembershipsRequest request);



        /// <summary>
        /// Lists all members associated to an agent space with pagination support
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemberships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMemberships service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListMemberships">REST API Reference for ListMemberships Operation</seealso>
        Task<ListMembershipsResponse> ListMembershipsAsync(ListMembershipsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPentestJobsForPentest


        /// <summary>
        /// Lists pentest jobs associated with a pentest
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentestJobsForPentest service method.</param>
        /// 
        /// <returns>The response from the ListPentestJobsForPentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentestJobsForPentest">REST API Reference for ListPentestJobsForPentest Operation</seealso>
        ListPentestJobsForPentestResponse ListPentestJobsForPentest(ListPentestJobsForPentestRequest request);



        /// <summary>
        /// Lists pentest jobs associated with a pentest
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentestJobsForPentest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPentestJobsForPentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentestJobsForPentest">REST API Reference for ListPentestJobsForPentest Operation</seealso>
        Task<ListPentestJobsForPentestResponse> ListPentestJobsForPentestAsync(ListPentestJobsForPentestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPentestJobTasks


        /// <summary>
        /// Lists tasks associated with a specific pentest job
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentestJobTasks service method.</param>
        /// 
        /// <returns>The response from the ListPentestJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentestJobTasks">REST API Reference for ListPentestJobTasks Operation</seealso>
        ListPentestJobTasksResponse ListPentestJobTasks(ListPentestJobTasksRequest request);



        /// <summary>
        /// Lists tasks associated with a specific pentest job
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentestJobTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPentestJobTasks service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentestJobTasks">REST API Reference for ListPentestJobTasks Operation</seealso>
        Task<ListPentestJobTasksResponse> ListPentestJobTasksAsync(ListPentestJobTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPentests


        /// <summary>
        /// Lists pentests with optional filtering by status
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentests service method.</param>
        /// 
        /// <returns>The response from the ListPentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentests">REST API Reference for ListPentests Operation</seealso>
        ListPentestsResponse ListPentests(ListPentestsRequest request);



        /// <summary>
        /// Lists pentests with optional filtering by status
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPentests service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPentests service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListPentests">REST API Reference for ListPentests Operation</seealso>
        Task<ListPentestsResponse> ListPentestsAsync(ListPentestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for a Security Agent resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists tags for a Security Agent resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTargetDomains


        /// <summary>
        /// Lists target domains
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetDomains service method.</param>
        /// 
        /// <returns>The response from the ListTargetDomains service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListTargetDomains">REST API Reference for ListTargetDomains Operation</seealso>
        ListTargetDomainsResponse ListTargetDomains(ListTargetDomainsRequest request);



        /// <summary>
        /// Lists target domains
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTargetDomains service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/ListTargetDomains">REST API Reference for ListTargetDomains Operation</seealso>
        Task<ListTargetDomainsResponse> ListTargetDomainsAsync(ListTargetDomainsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartCodeRemediation


        /// <summary>
        /// Starts code remediation for the specified findings
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeRemediation service method.</param>
        /// 
        /// <returns>The response from the StartCodeRemediation service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartCodeRemediation">REST API Reference for StartCodeRemediation Operation</seealso>
        StartCodeRemediationResponse StartCodeRemediation(StartCodeRemediationRequest request);



        /// <summary>
        /// Starts code remediation for the specified findings
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeRemediation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartCodeRemediation service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartCodeRemediation">REST API Reference for StartCodeRemediation Operation</seealso>
        Task<StartCodeRemediationResponse> StartCodeRemediationAsync(StartCodeRemediationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartPentestJob


        /// <summary>
        /// Initiates the execution of a pentest
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPentestJob service method.</param>
        /// 
        /// <returns>The response from the StartPentestJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartPentestJob">REST API Reference for StartPentestJob Operation</seealso>
        StartPentestJobResponse StartPentestJob(StartPentestJobRequest request);



        /// <summary>
        /// Initiates the execution of a pentest
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartPentestJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartPentestJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StartPentestJob">REST API Reference for StartPentestJob Operation</seealso>
        Task<StartPentestJobResponse> StartPentestJobAsync(StartPentestJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopPentestJob


        /// <summary>
        /// Stops the execution of a running pentest
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPentestJob service method.</param>
        /// 
        /// <returns>The response from the StopPentestJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StopPentestJob">REST API Reference for StopPentestJob Operation</seealso>
        StopPentestJobResponse StopPentestJob(StopPentestJobRequest request);



        /// <summary>
        /// Stops the execution of a running pentest
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopPentestJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopPentestJob service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/StopPentestJob">REST API Reference for StopPentestJob Operation</seealso>
        Task<StopPentestJobResponse> StopPentestJobAsync(StopPentestJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds tags to a Security Agent resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds tags to a Security Agent resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from a Security Agent resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from a Security Agent resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgentSpace


        /// <summary>
        /// Updates an agent space record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentSpace service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateAgentSpace">REST API Reference for UpdateAgentSpace Operation</seealso>
        UpdateAgentSpaceResponse UpdateAgentSpace(UpdateAgentSpaceRequest request);



        /// <summary>
        /// Updates an agent space record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentSpace service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateAgentSpace">REST API Reference for UpdateAgentSpace Operation</seealso>
        Task<UpdateAgentSpaceResponse> UpdateAgentSpaceAsync(UpdateAgentSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateApplication


        /// <summary>
        /// Updates application configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request);



        /// <summary>
        /// Updates application configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateFinding


        /// <summary>
        /// Updates an existing security finding with new details or status
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFinding service method.</param>
        /// 
        /// <returns>The response from the UpdateFinding service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateFinding">REST API Reference for UpdateFinding Operation</seealso>
        UpdateFindingResponse UpdateFinding(UpdateFindingRequest request);



        /// <summary>
        /// Updates an existing security finding with new details or status
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFinding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFinding service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateFinding">REST API Reference for UpdateFinding Operation</seealso>
        Task<UpdateFindingResponse> UpdateFindingAsync(UpdateFindingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIntegratedResources


        /// <summary>
        /// Updates the integrated resources for an agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegratedResources service method.</param>
        /// 
        /// <returns>The response from the UpdateIntegratedResources service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// Request conflicts with current resource state
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateIntegratedResources">REST API Reference for UpdateIntegratedResources Operation</seealso>
        UpdateIntegratedResourcesResponse UpdateIntegratedResources(UpdateIntegratedResourcesRequest request);



        /// <summary>
        /// Updates the integrated resources for an agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegratedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIntegratedResources service method, as returned by SecurityAgent.</returns>
        /// <exception cref="Amazon.SecurityAgent.Model.AccessDeniedException">
        /// Request denied due to insufficient permissions
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ConflictException">
        /// Request conflicts with current resource state
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.InternalServerException">
        /// Unexpected server error occurred
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ResourceNotFoundException">
        /// Specified resource was not found
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ThrottlingException">
        /// Request denied due to throttling
        /// </exception>
        /// <exception cref="Amazon.SecurityAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateIntegratedResources">REST API Reference for UpdateIntegratedResources Operation</seealso>
        Task<UpdateIntegratedResourcesResponse> UpdateIntegratedResourcesAsync(UpdateIntegratedResourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePentest


        /// <summary>
        /// Updates an existing pentest with new configuration or settings
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePentest service method.</param>
        /// 
        /// <returns>The response from the UpdatePentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdatePentest">REST API Reference for UpdatePentest Operation</seealso>
        UpdatePentestResponse UpdatePentest(UpdatePentestRequest request);



        /// <summary>
        /// Updates an existing pentest with new configuration or settings
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePentest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePentest service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdatePentest">REST API Reference for UpdatePentest Operation</seealso>
        Task<UpdatePentestResponse> UpdatePentestAsync(UpdatePentestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTargetDomain


        /// <summary>
        /// Updates a target domain record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetDomain service method.</param>
        /// 
        /// <returns>The response from the UpdateTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateTargetDomain">REST API Reference for UpdateTargetDomain Operation</seealso>
        UpdateTargetDomainResponse UpdateTargetDomain(UpdateTargetDomainRequest request);



        /// <summary>
        /// Updates a target domain record
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/UpdateTargetDomain">REST API Reference for UpdateTargetDomain Operation</seealso>
        Task<UpdateTargetDomainResponse> UpdateTargetDomainAsync(UpdateTargetDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  VerifyTargetDomain


        /// <summary>
        /// Verifies ownership for a registered target domain
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyTargetDomain service method.</param>
        /// 
        /// <returns>The response from the VerifyTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/VerifyTargetDomain">REST API Reference for VerifyTargetDomain Operation</seealso>
        VerifyTargetDomainResponse VerifyTargetDomain(VerifyTargetDomainRequest request);



        /// <summary>
        /// Verifies ownership for a registered target domain
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyTargetDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyTargetDomain service method, as returned by SecurityAgent.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityagent-2025-09-06/VerifyTargetDomain">REST API Reference for VerifyTargetDomain Operation</seealso>
        Task<VerifyTargetDomainResponse> VerifyTargetDomainAsync(VerifyTargetDomainRequest request, CancellationToken cancellationToken = default(CancellationToken));

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