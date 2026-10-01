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
using Amazon.NovaAct.Model;

#pragma warning disable CS1570

namespace Amazon.NovaAct
{
    /// <summary>
    /// <para>Interface for accessing NovaAct</para>
    ///
    /// The Nova Act service provides a REST API for managing AI-powered workflow automation.
    /// It enables users to create workflow definitions, execute workflow runs, manage sessions,
    /// and orchestrate acts (individual AI tasks) with tool integrations.
    /// </summary>
    public partial interface IAmazonNovaAct : IAmazonService, IDisposable
    {
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INovaActPaginatorFactory Paginators { get; }

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new AI task (act) within a session that can interact with tools and perform
        /// specific actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAct service method.</param>
        /// <returns>The response from the CreateAct service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateAct">REST API Reference for CreateAct Operation</seealso>
        CreateActResponse CreateAct(CreateActRequest request);
#endif

        /// <summary>
        /// Creates a new AI task (act) within a session that can interact with tools and perform
        /// specific actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateAct service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateAct">REST API Reference for CreateAct Operation</seealso>
        Task<CreateActResponse> CreateActAsync(CreateActRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new session context within a workflow run to manage conversation state and
        /// acts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// <returns>The response from the CreateSession service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateSession">REST API Reference for CreateSession Operation</seealso>
        CreateSessionResponse CreateSession(CreateSessionRequest request);
#endif

        /// <summary>
        /// Creates a new session context within a workflow run to manage conversation state and
        /// acts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateSession service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateSession">REST API Reference for CreateSession Operation</seealso>
        Task<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new workflow definition template that can be used to execute multiple workflow
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowDefinition service method.</param>
        /// <returns>The response from the CreateWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowDefinition">REST API Reference for CreateWorkflowDefinition Operation</seealso>
        CreateWorkflowDefinitionResponse CreateWorkflowDefinition(CreateWorkflowDefinitionRequest request);
#endif

        /// <summary>
        /// Creates a new workflow definition template that can be used to execute multiple workflow
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowDefinition">REST API Reference for CreateWorkflowDefinition Operation</seealso>
        Task<CreateWorkflowDefinitionResponse> CreateWorkflowDefinitionAsync(CreateWorkflowDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Creates a new execution instance of a workflow definition with specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowRun service method.</param>
        /// <returns>The response from the CreateWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowRun">REST API Reference for CreateWorkflowRun Operation</seealso>
        CreateWorkflowRunResponse CreateWorkflowRun(CreateWorkflowRunRequest request);
#endif

        /// <summary>
        /// Creates a new execution instance of a workflow definition with specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the CreateWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowRun">REST API Reference for CreateWorkflowRun Operation</seealso>
        Task<CreateWorkflowRunResponse> CreateWorkflowRunAsync(CreateWorkflowRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Deletes a workflow definition and all associated resources. This operation cannot
        /// be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowDefinition service method.</param>
        /// <returns>The response from the DeleteWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowDefinition">REST API Reference for DeleteWorkflowDefinition Operation</seealso>
        DeleteWorkflowDefinitionResponse DeleteWorkflowDefinition(DeleteWorkflowDefinitionRequest request);
#endif

        /// <summary>
        /// Deletes a workflow definition and all associated resources. This operation cannot
        /// be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowDefinition">REST API Reference for DeleteWorkflowDefinition Operation</seealso>
        Task<DeleteWorkflowDefinitionResponse> DeleteWorkflowDefinitionAsync(DeleteWorkflowDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Terminates and cleans up a workflow run, stopping all associated acts and sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowRun service method.</param>
        /// <returns>The response from the DeleteWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowRun">REST API Reference for DeleteWorkflowRun Operation</seealso>
        DeleteWorkflowRunResponse DeleteWorkflowRun(DeleteWorkflowRunRequest request);
#endif

        /// <summary>
        /// Terminates and cleans up a workflow run, stopping all associated acts and sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DeleteWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowRun">REST API Reference for DeleteWorkflowRun Operation</seealso>
        Task<DeleteWorkflowRunResponse> DeleteWorkflowRunAsync(DeleteWorkflowRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the details and configuration of a specific workflow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowDefinition service method.</param>
        /// <returns>The response from the GetWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowDefinition">REST API Reference for GetWorkflowDefinition Operation</seealso>
        GetWorkflowDefinitionResponse GetWorkflowDefinition(GetWorkflowDefinitionRequest request);
#endif

        /// <summary>
        /// Retrieves the details and configuration of a specific workflow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetWorkflowDefinition service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowDefinition">REST API Reference for GetWorkflowDefinition Operation</seealso>
        Task<GetWorkflowDefinitionResponse> GetWorkflowDefinitionAsync(GetWorkflowDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Retrieves the current state, configuration, and execution details of a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
        /// <returns>The response from the GetWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        GetWorkflowRunResponse GetWorkflowRun(GetWorkflowRunRequest request);
#endif

        /// <summary>
        /// Retrieves the current state, configuration, and execution details of a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GetWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        Task<GetWorkflowRunResponse> GetWorkflowRunAsync(GetWorkflowRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Executes the next step of an act, processing tool call results and returning new tool
        /// calls if needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeActStep service method.</param>
        /// <returns>The response from the InvokeActStep service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/InvokeActStep">REST API Reference for InvokeActStep Operation</seealso>
        InvokeActStepResponse InvokeActStep(InvokeActStepRequest request);
#endif

        /// <summary>
        /// Executes the next step of an act, processing tool call results and returning new tool
        /// calls if needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeActStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the InvokeActStep service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota limit.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/InvokeActStep">REST API Reference for InvokeActStep Operation</seealso>
        Task<InvokeActStepResponse> InvokeActStepAsync(InvokeActStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all acts within a specific session with their current status and execution details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActs service method.</param>
        /// <returns>The response from the ListActs service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListActs">REST API Reference for ListActs Operation</seealso>
        ListActsResponse ListActs(ListActsRequest request);
#endif

        /// <summary>
        /// Lists all acts within a specific session with their current status and execution details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListActs service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListActs">REST API Reference for ListActs Operation</seealso>
        Task<ListActsResponse> ListActsAsync(ListActsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all available AI models that can be used for workflow execution, including their
        /// status and compatibility information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// <returns>The response from the ListModels service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListModels">REST API Reference for ListModels Operation</seealso>
        ListModelsResponse ListModels(ListModelsRequest request);
#endif

        /// <summary>
        /// Lists all available AI models that can be used for workflow execution, including their
        /// status and compatibility information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListModels service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListModels">REST API Reference for ListModels Operation</seealso>
        Task<ListModelsResponse> ListModelsAsync(ListModelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all sessions within a specific workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <returns>The response from the ListSessions service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListSessions">REST API Reference for ListSessions Operation</seealso>
        ListSessionsResponse ListSessions(ListSessionsRequest request);
#endif

        /// <summary>
        /// Lists all sessions within a specific workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListSessions service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListSessions">REST API Reference for ListSessions Operation</seealso>
        Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all workflow definitions in your account with optional filtering and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowDefinitions service method.</param>
        /// <returns>The response from the ListWorkflowDefinitions service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowDefinitions">REST API Reference for ListWorkflowDefinitions Operation</seealso>
        ListWorkflowDefinitionsResponse ListWorkflowDefinitions(ListWorkflowDefinitionsRequest request);
#endif

        /// <summary>
        /// Lists all workflow definitions in your account with optional filtering and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListWorkflowDefinitions service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowDefinitions">REST API Reference for ListWorkflowDefinitions Operation</seealso>
        Task<ListWorkflowDefinitionsResponse> ListWorkflowDefinitionsAsync(ListWorkflowDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Lists all workflow runs for a specific workflow definition with optional filtering
        /// and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns service method.</param>
        /// <returns>The response from the ListWorkflowRuns service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        ListWorkflowRunsResponse ListWorkflowRuns(ListWorkflowRunsRequest request);
#endif

        /// <summary>
        /// Lists all workflow runs for a specific workflow definition with optional filtering
        /// and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ListWorkflowRuns service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        Task<ListWorkflowRunsResponse> ListWorkflowRunsAsync(ListWorkflowRunsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates an existing act's configuration, status, or error information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAct service method.</param>
        /// <returns>The response from the UpdateAct service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateAct">REST API Reference for UpdateAct Operation</seealso>
        UpdateActResponse UpdateAct(UpdateActRequest request);
#endif

        /// <summary>
        /// Updates an existing act's configuration, status, or error information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateAct service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateAct">REST API Reference for UpdateAct Operation</seealso>
        Task<UpdateActResponse> UpdateActAsync(UpdateActRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Updates the configuration or state of an active workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowRun service method.</param>
        /// <returns>The response from the UpdateWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateWorkflowRun">REST API Reference for UpdateWorkflowRun Operation</seealso>
        UpdateWorkflowRunResponse UpdateWorkflowRun(UpdateWorkflowRunRequest request);
#endif

        /// <summary>
        /// Updates the configuration or state of an active workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowRun service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UpdateWorkflowRun service method, as returned by NovaAct.</returns>
        /// <exception cref="Amazon.NovaAct.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ConflictException">
        /// The request could not be completed due to a conflict with the current state of the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.InternalServerException">
        /// An internal server error occurred. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ResourceNotFoundException">
        /// The requested resource was not found.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ThrottlingException">
        /// The request was throttled due to too many requests. Please try again later.
        /// </exception>
        /// <exception cref="Amazon.NovaAct.Model.ValidationException">
        /// The input parameters for the request are invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateWorkflowRun">REST API Reference for UpdateWorkflowRun Operation</seealso>
        Task<UpdateWorkflowRunResponse> UpdateWorkflowRunAsync(UpdateWorkflowRunRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonNovaActConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonNovaActConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonNovaActConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonNovaActConfig to create AmazonNovaActClient");
            }

            return awsCredentials == null ?
                    new AmazonNovaActClient(serviceClientConfig) :
                    new AmazonNovaActClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
