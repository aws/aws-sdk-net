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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.DevOpsAgent.Model;

#pragma warning disable CS1570
namespace Amazon.DevOpsAgent
{
    /// <summary>
    /// <para>Interface for accessing DevOpsAgent</para>
    ///
    /// AWS DevOps Agent is a frontier agent that resolves and proactively prevents incidents,
    /// continuously improving reliability and performance. AWS DevOps Agent investigates
    /// incidents and identifies operational improvements as an experienced DevOps engineer.
    /// 
    ///  
    /// <para>
    /// The agent works by:
    /// </para>
    ///  <ul> <li>Learning your resources and their relationships.</li> <li>Working with your
    /// observability tools, runbooks, code repositories, and CI/CD pipelines.</li> <li>Correlating
    /// telemetry, code, and deployment data to understand relationships between your application
    /// resources.</li> <li>Supporting applications in multicloud and hybrid environments.</li>
    /// </ul>
    /// </summary>
    public partial interface IAmazonDevOpsAgent : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDevOpsAgentPaginatorFactory Paginators { get; }

        
        #region  AssociateService


        /// <summary>
        /// Adds a specific service association to an AgentSpace. It overwrites the existing association
        /// of the same service. Returns 201 Created on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateService service method.</param>
        /// 
        /// <returns>The response from the AssociateService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/AssociateService">REST API Reference for AssociateService Operation</seealso>
        AssociateServiceResponse AssociateService(AssociateServiceRequest request);



        /// <summary>
        /// Adds a specific service association to an AgentSpace. It overwrites the existing association
        /// of the same service. Returns 201 Created on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/AssociateService">REST API Reference for AssociateService Operation</seealso>
        Task<AssociateServiceResponse> AssociateServiceAsync(AssociateServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAgentSpace


        /// <summary>
        /// Creates a new AgentSpace with the specified name and description. Duplicate space
        /// names are allowed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentSpace service method.</param>
        /// 
        /// <returns>The response from the CreateAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreateAgentSpace">REST API Reference for CreateAgentSpace Operation</seealso>
        CreateAgentSpaceResponse CreateAgentSpace(CreateAgentSpaceRequest request);



        /// <summary>
        /// Creates a new AgentSpace with the specified name and description. Duplicate space
        /// names are allowed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreateAgentSpace">REST API Reference for CreateAgentSpace Operation</seealso>
        Task<CreateAgentSpaceResponse> CreateAgentSpaceAsync(CreateAgentSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBacklogTask


        /// <summary>
        /// Creates a new backlog task in the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBacklogTask service method.</param>
        /// 
        /// <returns>The response from the CreateBacklogTask service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreateBacklogTask">REST API Reference for CreateBacklogTask Operation</seealso>
        CreateBacklogTaskResponse CreateBacklogTask(CreateBacklogTaskRequest request);



        /// <summary>
        /// Creates a new backlog task in the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBacklogTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBacklogTask service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreateBacklogTask">REST API Reference for CreateBacklogTask Operation</seealso>
        Task<CreateBacklogTaskResponse> CreateBacklogTaskAsync(CreateBacklogTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateChat


        /// <summary>
        /// Creates a new chat execution in the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChat service method.</param>
        /// 
        /// <returns>The response from the CreateChat service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreateChat">REST API Reference for CreateChat Operation</seealso>
        CreateChatResponse CreateChat(CreateChatRequest request);



        /// <summary>
        /// Creates a new chat execution in the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChat service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreateChat">REST API Reference for CreateChat Operation</seealso>
        Task<CreateChatResponse> CreateChatAsync(CreateChatRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePrivateConnection


        /// <summary>
        /// Creates a Private Connection to a target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateConnection service method.</param>
        /// 
        /// <returns>The response from the CreatePrivateConnection service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreatePrivateConnection">REST API Reference for CreatePrivateConnection Operation</seealso>
        CreatePrivateConnectionResponse CreatePrivateConnection(CreatePrivateConnectionRequest request);



        /// <summary>
        /// Creates a Private Connection to a target resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrivateConnection service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/CreatePrivateConnection">REST API Reference for CreatePrivateConnection Operation</seealso>
        Task<CreatePrivateConnectionResponse> CreatePrivateConnectionAsync(CreatePrivateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAgentSpace


        /// <summary>
        /// Deletes an AgentSpace. This operation is idempotent and returns a 204 No Content response
        /// on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentSpace service method.</param>
        /// 
        /// <returns>The response from the DeleteAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DeleteAgentSpace">REST API Reference for DeleteAgentSpace Operation</seealso>
        DeleteAgentSpaceResponse DeleteAgentSpace(DeleteAgentSpaceRequest request);



        /// <summary>
        /// Deletes an AgentSpace. This operation is idempotent and returns a 204 No Content response
        /// on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DeleteAgentSpace">REST API Reference for DeleteAgentSpace Operation</seealso>
        Task<DeleteAgentSpaceResponse> DeleteAgentSpaceAsync(DeleteAgentSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePrivateConnection


        /// <summary>
        /// Deletes a Private Connection. The deletion is asynchronous and returns DELETE_IN_PROGRESS
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivateConnection service method.</param>
        /// 
        /// <returns>The response from the DeletePrivateConnection service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DeletePrivateConnection">REST API Reference for DeletePrivateConnection Operation</seealso>
        DeletePrivateConnectionResponse DeletePrivateConnection(DeletePrivateConnectionRequest request);



        /// <summary>
        /// Deletes a Private Connection. The deletion is asynchronous and returns DELETE_IN_PROGRESS
        /// status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePrivateConnection service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DeletePrivateConnection">REST API Reference for DeletePrivateConnection Operation</seealso>
        Task<DeletePrivateConnectionResponse> DeletePrivateConnectionAsync(DeletePrivateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeregisterService


        /// <summary>
        /// Deregister a service
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterService service method.</param>
        /// 
        /// <returns>The response from the DeregisterService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DeregisterService">REST API Reference for DeregisterService Operation</seealso>
        DeregisterServiceResponse DeregisterService(DeregisterServiceRequest request);



        /// <summary>
        /// Deregister a service
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DeregisterService">REST API Reference for DeregisterService Operation</seealso>
        Task<DeregisterServiceResponse> DeregisterServiceAsync(DeregisterServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePrivateConnection


        /// <summary>
        /// Retrieves details of an existing Private Connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrivateConnection service method.</param>
        /// 
        /// <returns>The response from the DescribePrivateConnection service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DescribePrivateConnection">REST API Reference for DescribePrivateConnection Operation</seealso>
        DescribePrivateConnectionResponse DescribePrivateConnection(DescribePrivateConnectionRequest request);



        /// <summary>
        /// Retrieves details of an existing Private Connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrivateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePrivateConnection service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DescribePrivateConnection">REST API Reference for DescribePrivateConnection Operation</seealso>
        Task<DescribePrivateConnectionResponse> DescribePrivateConnectionAsync(DescribePrivateConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableOperatorApp


        /// <summary>
        /// Disable the Operator App for the specified AgentSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOperatorApp service method.</param>
        /// 
        /// <returns>The response from the DisableOperatorApp service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.IdentityCenterServiceException">
        /// Calls to the customer Identity Center have failed
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DisableOperatorApp">REST API Reference for DisableOperatorApp Operation</seealso>
        DisableOperatorAppResponse DisableOperatorApp(DisableOperatorAppRequest request);



        /// <summary>
        /// Disable the Operator App for the specified AgentSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableOperatorApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableOperatorApp service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.IdentityCenterServiceException">
        /// Calls to the customer Identity Center have failed
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DisableOperatorApp">REST API Reference for DisableOperatorApp Operation</seealso>
        Task<DisableOperatorAppResponse> DisableOperatorAppAsync(DisableOperatorAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateService


        /// <summary>
        /// Deletes a specific service association from an AgentSpace. This operation is idempotent
        /// and returns a 204 No Content response on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateService service method.</param>
        /// 
        /// <returns>The response from the DisassociateService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DisassociateService">REST API Reference for DisassociateService Operation</seealso>
        DisassociateServiceResponse DisassociateService(DisassociateServiceRequest request);



        /// <summary>
        /// Deletes a specific service association from an AgentSpace. This operation is idempotent
        /// and returns a 204 No Content response on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/DisassociateService">REST API Reference for DisassociateService Operation</seealso>
        Task<DisassociateServiceResponse> DisassociateServiceAsync(DisassociateServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableOperatorApp


        /// <summary>
        /// Enable the Operator App to access the given AgentSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOperatorApp service method.</param>
        /// 
        /// <returns>The response from the EnableOperatorApp service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.IdentityCenterServiceException">
        /// Calls to the customer Identity Center have failed
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/EnableOperatorApp">REST API Reference for EnableOperatorApp Operation</seealso>
        EnableOperatorAppResponse EnableOperatorApp(EnableOperatorAppRequest request);



        /// <summary>
        /// Enable the Operator App to access the given AgentSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableOperatorApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableOperatorApp service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.IdentityCenterServiceException">
        /// Calls to the customer Identity Center have failed
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/EnableOperatorApp">REST API Reference for EnableOperatorApp Operation</seealso>
        Task<EnableOperatorAppResponse> EnableOperatorAppAsync(EnableOperatorAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAccountUsage


        /// <summary>
        /// Retrieves monthly account usage metrics and limits for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountUsage service method.</param>
        /// 
        /// <returns>The response from the GetAccountUsage service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetAccountUsage">REST API Reference for GetAccountUsage Operation</seealso>
        GetAccountUsageResponse GetAccountUsage(GetAccountUsageRequest request);



        /// <summary>
        /// Retrieves monthly account usage metrics and limits for the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountUsage service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetAccountUsage">REST API Reference for GetAccountUsage Operation</seealso>
        Task<GetAccountUsageResponse> GetAccountUsageAsync(GetAccountUsageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAgentSpace


        /// <summary>
        /// Retrieves detailed information about a specific AgentSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentSpace service method.</param>
        /// 
        /// <returns>The response from the GetAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetAgentSpace">REST API Reference for GetAgentSpace Operation</seealso>
        GetAgentSpaceResponse GetAgentSpace(GetAgentSpaceRequest request);



        /// <summary>
        /// Retrieves detailed information about a specific AgentSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetAgentSpace">REST API Reference for GetAgentSpace Operation</seealso>
        Task<GetAgentSpaceResponse> GetAgentSpaceAsync(GetAgentSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetAssociation


        /// <summary>
        /// Retrieves given associations configured for a specific AgentSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociation service method.</param>
        /// 
        /// <returns>The response from the GetAssociation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetAssociation">REST API Reference for GetAssociation Operation</seealso>
        GetAssociationResponse GetAssociation(GetAssociationRequest request);



        /// <summary>
        /// Retrieves given associations configured for a specific AgentSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAssociation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetAssociation">REST API Reference for GetAssociation Operation</seealso>
        Task<GetAssociationResponse> GetAssociationAsync(GetAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBacklogTask


        /// <summary>
        /// Gets a backlog task for the specified agent space and task id
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBacklogTask service method.</param>
        /// 
        /// <returns>The response from the GetBacklogTask service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetBacklogTask">REST API Reference for GetBacklogTask Operation</seealso>
        GetBacklogTaskResponse GetBacklogTask(GetBacklogTaskRequest request);



        /// <summary>
        /// Gets a backlog task for the specified agent space and task id
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBacklogTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBacklogTask service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetBacklogTask">REST API Reference for GetBacklogTask Operation</seealso>
        Task<GetBacklogTaskResponse> GetBacklogTaskAsync(GetBacklogTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOperatorApp


        /// <summary>
        /// Get the full auth configuration of operator including any enabled auth flow
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperatorApp service method.</param>
        /// 
        /// <returns>The response from the GetOperatorApp service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetOperatorApp">REST API Reference for GetOperatorApp Operation</seealso>
        GetOperatorAppResponse GetOperatorApp(GetOperatorAppRequest request);



        /// <summary>
        /// Get the full auth configuration of operator including any enabled auth flow
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOperatorApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOperatorApp service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetOperatorApp">REST API Reference for GetOperatorApp Operation</seealso>
        Task<GetOperatorAppResponse> GetOperatorAppAsync(GetOperatorAppRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRecommendation


        /// <summary>
        /// Retrieves a specific recommendation by its ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        GetRecommendationResponse GetRecommendation(GetRecommendationRequest request);



        /// <summary>
        /// Retrieves a specific recommendation by its ID
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetRecommendation">REST API Reference for GetRecommendation Operation</seealso>
        Task<GetRecommendationResponse> GetRecommendationAsync(GetRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetService


        /// <summary>
        /// Retrieves given service by it's unique identifier
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// 
        /// <returns>The response from the GetService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetService">REST API Reference for GetService Operation</seealso>
        GetServiceResponse GetService(GetServiceRequest request);



        /// <summary>
        /// Retrieves given service by it's unique identifier
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/GetService">REST API Reference for GetService Operation</seealso>
        Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAgentSpaces


        /// <summary>
        /// Lists all AgentSpaces with optional pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentSpaces service method.</param>
        /// 
        /// <returns>The response from the ListAgentSpaces service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListAgentSpaces">REST API Reference for ListAgentSpaces Operation</seealso>
        ListAgentSpacesResponse ListAgentSpaces(ListAgentSpacesRequest request);



        /// <summary>
        /// Lists all AgentSpaces with optional pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAgentSpaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAgentSpaces service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListAgentSpaces">REST API Reference for ListAgentSpaces Operation</seealso>
        Task<ListAgentSpacesResponse> ListAgentSpacesAsync(ListAgentSpacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAssociations


        /// <summary>
        /// List all associations for given AgentSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        ListAssociationsResponse ListAssociations(ListAssociationsRequest request);



        /// <summary>
        /// List all associations for given AgentSpace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBacklogTasks


        /// <summary>
        /// Lists backlog tasks in the specified agent space with optional filtering and sorting
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBacklogTasks service method.</param>
        /// 
        /// <returns>The response from the ListBacklogTasks service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListBacklogTasks">REST API Reference for ListBacklogTasks Operation</seealso>
        ListBacklogTasksResponse ListBacklogTasks(ListBacklogTasksRequest request);



        /// <summary>
        /// Lists backlog tasks in the specified agent space with optional filtering and sorting
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBacklogTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBacklogTasks service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListBacklogTasks">REST API Reference for ListBacklogTasks Operation</seealso>
        Task<ListBacklogTasksResponse> ListBacklogTasksAsync(ListBacklogTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListChats


        /// <summary>
        /// Retrieves a paginated list of the user's recent chat executions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChats service method.</param>
        /// 
        /// <returns>The response from the ListChats service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListChats">REST API Reference for ListChats Operation</seealso>
        ListChatsResponse ListChats(ListChatsRequest request);



        /// <summary>
        /// Retrieves a paginated list of the user's recent chat executions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChats service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChats service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListChats">REST API Reference for ListChats Operation</seealso>
        Task<ListChatsResponse> ListChatsAsync(ListChatsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListExecutions


        /// <summary>
        /// List executions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        ListExecutionsResponse ListExecutions(ListExecutionsRequest request);



        /// <summary>
        /// List executions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        Task<ListExecutionsResponse> ListExecutionsAsync(ListExecutionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListGoals


        /// <summary>
        /// Lists goals in the specified agent space with optional filtering
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGoals service method.</param>
        /// 
        /// <returns>The response from the ListGoals service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListGoals">REST API Reference for ListGoals Operation</seealso>
        ListGoalsResponse ListGoals(ListGoalsRequest request);



        /// <summary>
        /// Lists goals in the specified agent space with optional filtering
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListGoals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListGoals service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListGoals">REST API Reference for ListGoals Operation</seealso>
        Task<ListGoalsResponse> ListGoalsAsync(ListGoalsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJournalRecords


        /// <summary>
        /// List journal records for a specific execution
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJournalRecords service method.</param>
        /// 
        /// <returns>The response from the ListJournalRecords service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListJournalRecords">REST API Reference for ListJournalRecords Operation</seealso>
        ListJournalRecordsResponse ListJournalRecords(ListJournalRecordsRequest request);



        /// <summary>
        /// List journal records for a specific execution
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJournalRecords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJournalRecords service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListJournalRecords">REST API Reference for ListJournalRecords Operation</seealso>
        Task<ListJournalRecordsResponse> ListJournalRecordsAsync(ListJournalRecordsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPendingMessages


        /// <summary>
        /// List pending messages for a specific execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPendingMessages service method.</param>
        /// 
        /// <returns>The response from the ListPendingMessages service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListPendingMessages">REST API Reference for ListPendingMessages Operation</seealso>
        ListPendingMessagesResponse ListPendingMessages(ListPendingMessagesRequest request);



        /// <summary>
        /// List pending messages for a specific execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPendingMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPendingMessages service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListPendingMessages">REST API Reference for ListPendingMessages Operation</seealso>
        Task<ListPendingMessagesResponse> ListPendingMessagesAsync(ListPendingMessagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPrivateConnections


        /// <summary>
        /// Lists all Private Connections in the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivateConnections service method.</param>
        /// 
        /// <returns>The response from the ListPrivateConnections service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListPrivateConnections">REST API Reference for ListPrivateConnections Operation</seealso>
        ListPrivateConnectionsResponse ListPrivateConnections(ListPrivateConnectionsRequest request);



        /// <summary>
        /// Lists all Private Connections in the caller's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrivateConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrivateConnections service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListPrivateConnections">REST API Reference for ListPrivateConnections Operation</seealso>
        Task<ListPrivateConnectionsResponse> ListPrivateConnectionsAsync(ListPrivateConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRecommendations


        /// <summary>
        /// Lists recommendations for the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        ListRecommendationsResponse ListRecommendations(ListRecommendationsRequest request);



        /// <summary>
        /// Lists recommendations for the specified agent space
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendations service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListRecommendations">REST API Reference for ListRecommendations Operation</seealso>
        Task<ListRecommendationsResponse> ListRecommendationsAsync(ListRecommendationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListServices


        /// <summary>
        /// List a list of registered service on the account level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListServices">REST API Reference for ListServices Operation</seealso>
        ListServicesResponse ListServices(ListServicesRequest request);



        /// <summary>
        /// List a list of registered service on the account level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListServices">REST API Reference for ListServices Operation</seealso>
        Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for the specified AWS DevOps Agent resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists tags for the specified AWS DevOps Agent resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWebhooks


        /// <summary>
        /// List all webhooks for given Association
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks service method.</param>
        /// 
        /// <returns>The response from the ListWebhooks service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        ListWebhooksResponse ListWebhooks(ListWebhooksRequest request);



        /// <summary>
        /// List all webhooks for given Association
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWebhooks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWebhooks service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ListWebhooks">REST API Reference for ListWebhooks Operation</seealso>
        Task<ListWebhooksResponse> ListWebhooksAsync(ListWebhooksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterService


        /// <summary>
        /// This operation registers the specified service
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterService service method.</param>
        /// 
        /// <returns>The response from the RegisterService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/RegisterService">REST API Reference for RegisterService Operation</seealso>
        RegisterServiceResponse RegisterService(RegisterServiceRequest request);



        /// <summary>
        /// This operation registers the specified service
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterService service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/RegisterService">REST API Reference for RegisterService Operation</seealso>
        Task<RegisterServiceResponse> RegisterServiceAsync(RegisterServiceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SendMessage


        /// <summary>
        /// Sends a chat message and streams the response for the specified agent space execution
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/SendMessage">REST API Reference for SendMessage Operation</seealso>
        SendMessageResponse SendMessage(SendMessageRequest request);



        /// <summary>
        /// Sends a chat message and streams the response for the specified agent space execution
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/SendMessage">REST API Reference for SendMessage Operation</seealso>
        Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or overwrites tags for the specified AWS DevOps Agent resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Adds or overwrites tags for the specified AWS DevOps Agent resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags from the specified AWS DevOps Agent resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes tags from the specified AWS DevOps Agent resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAgentSpace


        /// <summary>
        /// Updates the information of an existing AgentSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentSpace service method.</param>
        /// 
        /// <returns>The response from the UpdateAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateAgentSpace">REST API Reference for UpdateAgentSpace Operation</seealso>
        UpdateAgentSpaceResponse UpdateAgentSpace(UpdateAgentSpaceRequest request);



        /// <summary>
        /// Updates the information of an existing AgentSpace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAgentSpace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAgentSpace service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateAgentSpace">REST API Reference for UpdateAgentSpace Operation</seealso>
        Task<UpdateAgentSpaceResponse> UpdateAgentSpaceAsync(UpdateAgentSpaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAssociation


        /// <summary>
        /// Partially updates the configuration of an existing service association for an AgentSpace.
        /// Present fields are fully replaced; absent fields are left unchanged. Returns 200 OK
        /// on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateAssociation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        UpdateAssociationResponse UpdateAssociation(UpdateAssociationRequest request);



        /// <summary>
        /// Partially updates the configuration of an existing service association for an AgentSpace.
        /// Present fields are fully replaced; absent fields are left unchanged. Returns 200 OK
        /// on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAssociation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateAssociation">REST API Reference for UpdateAssociation Operation</seealso>
        Task<UpdateAssociationResponse> UpdateAssociationAsync(UpdateAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateBacklogTask


        /// <summary>
        /// Update an existing backlog task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBacklogTask service method.</param>
        /// 
        /// <returns>The response from the UpdateBacklogTask service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateBacklogTask">REST API Reference for UpdateBacklogTask Operation</seealso>
        UpdateBacklogTaskResponse UpdateBacklogTask(UpdateBacklogTaskRequest request);



        /// <summary>
        /// Update an existing backlog task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBacklogTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBacklogTask service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateBacklogTask">REST API Reference for UpdateBacklogTask Operation</seealso>
        Task<UpdateBacklogTaskResponse> UpdateBacklogTaskAsync(UpdateBacklogTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateGoal


        /// <summary>
        /// Update an existing goal
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGoal service method.</param>
        /// 
        /// <returns>The response from the UpdateGoal service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateGoal">REST API Reference for UpdateGoal Operation</seealso>
        UpdateGoalResponse UpdateGoal(UpdateGoalRequest request);



        /// <summary>
        /// Update an existing goal
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGoal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGoal service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateGoal">REST API Reference for UpdateGoal Operation</seealso>
        Task<UpdateGoalResponse> UpdateGoalAsync(UpdateGoalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateOperatorAppIdpConfig


        /// <summary>
        /// Update the external Identity Provider configuration for the Operator App
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOperatorAppIdpConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateOperatorAppIdpConfig service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateOperatorAppIdpConfig">REST API Reference for UpdateOperatorAppIdpConfig Operation</seealso>
        UpdateOperatorAppIdpConfigResponse UpdateOperatorAppIdpConfig(UpdateOperatorAppIdpConfigRequest request);



        /// <summary>
        /// Update the external Identity Provider configuration for the Operator App
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateOperatorAppIdpConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateOperatorAppIdpConfig service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateOperatorAppIdpConfig">REST API Reference for UpdateOperatorAppIdpConfig Operation</seealso>
        Task<UpdateOperatorAppIdpConfigResponse> UpdateOperatorAppIdpConfigAsync(UpdateOperatorAppIdpConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePrivateConnectionCertificate


        /// <summary>
        /// Updates the certificate associated with a Private Connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivateConnectionCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdatePrivateConnectionCertificate service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdatePrivateConnectionCertificate">REST API Reference for UpdatePrivateConnectionCertificate Operation</seealso>
        UpdatePrivateConnectionCertificateResponse UpdatePrivateConnectionCertificate(UpdatePrivateConnectionCertificateRequest request);



        /// <summary>
        /// Updates the certificate associated with a Private Connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePrivateConnectionCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePrivateConnectionCertificate service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdatePrivateConnectionCertificate">REST API Reference for UpdatePrivateConnectionCertificate Operation</seealso>
        Task<UpdatePrivateConnectionCertificateResponse> UpdatePrivateConnectionCertificateAsync(UpdatePrivateConnectionCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRecommendation


        /// <summary>
        /// Updates an existing recommendation with new content, status, or metadata
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommendation service method.</param>
        /// 
        /// <returns>The response from the UpdateRecommendation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateRecommendation">REST API Reference for UpdateRecommendation Operation</seealso>
        UpdateRecommendationResponse UpdateRecommendation(UpdateRecommendationRequest request);



        /// <summary>
        /// Updates an existing recommendation with new content, status, or metadata
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRecommendation service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/UpdateRecommendation">REST API Reference for UpdateRecommendation Operation</seealso>
        Task<UpdateRecommendationResponse> UpdateRecommendationAsync(UpdateRecommendationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ValidateAwsAssociations


        /// <summary>
        /// Validates an aws association and set status and returns a 204 No Content response
        /// on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateAwsAssociations service method.</param>
        /// 
        /// <returns>The response from the ValidateAwsAssociations service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ValidateAwsAssociations">REST API Reference for ValidateAwsAssociations Operation</seealso>
        ValidateAwsAssociationsResponse ValidateAwsAssociations(ValidateAwsAssociationsRequest request);



        /// <summary>
        /// Validates an aws association and set status and returns a 204 No Content response
        /// on success.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateAwsAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateAwsAssociations service method, as returned by DevOpsAgent.</returns>
        /// <exception cref="Amazon.DevOpsAgent.Model.AccessDeniedException">
        /// Access to the requested resource is denied due to insufficient permissions.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ContentSizeExceededException">
        /// This exception is thrown when the content size exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InternalServerException">
        /// This exception is thrown when an unexpected error occurs in the processing of a request.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.InvalidParameterException">
        /// One or more parameters provided in the request are invalid.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ServiceQuotaExceededException">
        /// The request would exceed the service quota limit.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please slow down and try again.
        /// </exception>
        /// <exception cref="Amazon.DevOpsAgent.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devops-agent-2026-01-01/ValidateAwsAssociations">REST API Reference for ValidateAwsAssociations Operation</seealso>
        Task<ValidateAwsAssociationsResponse> ValidateAwsAssociationsAsync(ValidateAwsAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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