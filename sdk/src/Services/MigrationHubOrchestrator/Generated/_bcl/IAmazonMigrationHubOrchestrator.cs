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
 * Do not modify this file. This file is generated from the migrationhuborchestrator-2021-08-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MigrationHubOrchestrator.Model;

#pragma warning disable CS1570
namespace Amazon.MigrationHubOrchestrator
{
    /// <summary>
    /// <para>Interface for accessing MigrationHubOrchestrator</para>
    ///
    /// This API reference provides descriptions, syntax, and other details about each of
    /// the actions and data types for AWS Migration Hub Orchestrator. The topic for each
    /// action shows the API request parameters and responses. Alternatively, you can use
    /// one of the AWS SDKs to access an API that is tailored to the programming language
    /// or platform that you're using.
    /// </summary>
    public partial interface IAmazonMigrationHubOrchestrator : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMigrationHubOrchestratorPaginatorFactory Paginators { get; }

        
        #region  CreateTemplate


        /// <summary>
        /// Creates a migration workflow template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ConflictException">
        /// This exception is thrown when an attempt to update or delete a resource would cause
        /// an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        CreateTemplateResponse CreateTemplate(CreateTemplateRequest request);



        /// <summary>
        /// Creates a migration workflow template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ConflictException">
        /// This exception is thrown when an attempt to update or delete a resource would cause
        /// an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateTemplate">REST API Reference for CreateTemplate Operation</seealso>
        Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWorkflow


        /// <summary>
        /// Create a workflow to orchestrate your migrations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        CreateWorkflowResponse CreateWorkflow(CreateWorkflowRequest request);



        /// <summary>
        /// Create a workflow to orchestrate your migrations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        Task<CreateWorkflowResponse> CreateWorkflowAsync(CreateWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWorkflowStep


        /// <summary>
        /// Create a step in the migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowStep service method.</param>
        /// 
        /// <returns>The response from the CreateWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflowStep">REST API Reference for CreateWorkflowStep Operation</seealso>
        CreateWorkflowStepResponse CreateWorkflowStep(CreateWorkflowStepRequest request);



        /// <summary>
        /// Create a step in the migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflowStep">REST API Reference for CreateWorkflowStep Operation</seealso>
        Task<CreateWorkflowStepResponse> CreateWorkflowStepAsync(CreateWorkflowStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWorkflowStepGroup


        /// <summary>
        /// Create a step group in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowStepGroup service method.</param>
        /// 
        /// <returns>The response from the CreateWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflowStepGroup">REST API Reference for CreateWorkflowStepGroup Operation</seealso>
        CreateWorkflowStepGroupResponse CreateWorkflowStepGroup(CreateWorkflowStepGroupRequest request);



        /// <summary>
        /// Create a step group in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowStepGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflowStepGroup">REST API Reference for CreateWorkflowStepGroup Operation</seealso>
        Task<CreateWorkflowStepGroupResponse> CreateWorkflowStepGroupAsync(CreateWorkflowStepGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTemplate


        /// <summary>
        /// Deletes a migration workflow template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        DeleteTemplateResponse DeleteTemplate(DeleteTemplateRequest request);



        /// <summary>
        /// Deletes a migration workflow template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteTemplate">REST API Reference for DeleteTemplate Operation</seealso>
        Task<DeleteTemplateResponse> DeleteTemplateAsync(DeleteTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWorkflow


        /// <summary>
        /// Delete a migration workflow. You must pause a running workflow in Migration Hub Orchestrator
        /// console to delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        DeleteWorkflowResponse DeleteWorkflow(DeleteWorkflowRequest request);



        /// <summary>
        /// Delete a migration workflow. You must pause a running workflow in Migration Hub Orchestrator
        /// console to delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        Task<DeleteWorkflowResponse> DeleteWorkflowAsync(DeleteWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWorkflowStep


        /// <summary>
        /// Delete a step in a migration workflow. Pause the workflow to delete a running step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowStep service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflowStep">REST API Reference for DeleteWorkflowStep Operation</seealso>
        DeleteWorkflowStepResponse DeleteWorkflowStep(DeleteWorkflowStepRequest request);



        /// <summary>
        /// Delete a step in a migration workflow. Pause the workflow to delete a running step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflowStep">REST API Reference for DeleteWorkflowStep Operation</seealso>
        Task<DeleteWorkflowStepResponse> DeleteWorkflowStepAsync(DeleteWorkflowStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteWorkflowStepGroup


        /// <summary>
        /// Delete a step group in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowStepGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflowStepGroup">REST API Reference for DeleteWorkflowStepGroup Operation</seealso>
        DeleteWorkflowStepGroupResponse DeleteWorkflowStepGroup(DeleteWorkflowStepGroupRequest request);



        /// <summary>
        /// Delete a step group in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowStepGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflowStepGroup">REST API Reference for DeleteWorkflowStepGroup Operation</seealso>
        Task<DeleteWorkflowStepGroupResponse> DeleteWorkflowStepGroupAsync(DeleteWorkflowStepGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemplate


        /// <summary>
        /// Get the template you want to use for creating a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        GetTemplateResponse GetTemplate(GetTemplateRequest request);



        /// <summary>
        /// Get the template you want to use for creating a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        Task<GetTemplateResponse> GetTemplateAsync(GetTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemplateStep


        /// <summary>
        /// Get a specific step in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateStep service method.</param>
        /// 
        /// <returns>The response from the GetTemplateStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplateStep">REST API Reference for GetTemplateStep Operation</seealso>
        GetTemplateStepResponse GetTemplateStep(GetTemplateStepRequest request);



        /// <summary>
        /// Get a specific step in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplateStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplateStep">REST API Reference for GetTemplateStep Operation</seealso>
        Task<GetTemplateStepResponse> GetTemplateStepAsync(GetTemplateStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTemplateStepGroup


        /// <summary>
        /// Get a step group in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateStepGroup service method.</param>
        /// 
        /// <returns>The response from the GetTemplateStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplateStepGroup">REST API Reference for GetTemplateStepGroup Operation</seealso>
        GetTemplateStepGroupResponse GetTemplateStepGroup(GetTemplateStepGroupRequest request);



        /// <summary>
        /// Get a step group in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateStepGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTemplateStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplateStepGroup">REST API Reference for GetTemplateStepGroup Operation</seealso>
        Task<GetTemplateStepGroupResponse> GetTemplateStepGroupAsync(GetTemplateStepGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWorkflow


        /// <summary>
        /// Get migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        GetWorkflowResponse GetWorkflow(GetWorkflowRequest request);



        /// <summary>
        /// Get migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        Task<GetWorkflowResponse> GetWorkflowAsync(GetWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWorkflowStep


        /// <summary>
        /// Get a step in the migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowStep service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflowStep">REST API Reference for GetWorkflowStep Operation</seealso>
        GetWorkflowStepResponse GetWorkflowStep(GetWorkflowStepRequest request);



        /// <summary>
        /// Get a step in the migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflowStep">REST API Reference for GetWorkflowStep Operation</seealso>
        Task<GetWorkflowStepResponse> GetWorkflowStepAsync(GetWorkflowStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetWorkflowStepGroup


        /// <summary>
        /// Get the step group of a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowStepGroup service method.</param>
        /// 
        /// <returns>The response from the GetWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflowStepGroup">REST API Reference for GetWorkflowStepGroup Operation</seealso>
        GetWorkflowStepGroupResponse GetWorkflowStepGroup(GetWorkflowStepGroupRequest request);



        /// <summary>
        /// Get the step group of a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowStepGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflowStepGroup">REST API Reference for GetWorkflowStepGroup Operation</seealso>
        Task<GetWorkflowStepGroupResponse> GetWorkflowStepGroupAsync(GetWorkflowStepGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPlugins


        /// <summary>
        /// List AWS Migration Hub Orchestrator plugins.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlugins service method.</param>
        /// 
        /// <returns>The response from the ListPlugins service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        ListPluginsResponse ListPlugins(ListPluginsRequest request);



        /// <summary>
        /// List AWS Migration Hub Orchestrator plugins.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPlugins service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPlugins service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        Task<ListPluginsResponse> ListPluginsAsync(ListPluginsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List the tags added to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// List the tags added to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTemplates


        /// <summary>
        /// List the templates available in Migration Hub Orchestrator to create a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse ListTemplates(ListTemplatesRequest request);



        /// <summary>
        /// List the templates available in Migration Hub Orchestrator to create a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplates service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        Task<ListTemplatesResponse> ListTemplatesAsync(ListTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTemplateStepGroups


        /// <summary>
        /// List the step groups in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateStepGroups service method.</param>
        /// 
        /// <returns>The response from the ListTemplateStepGroups service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplateStepGroups">REST API Reference for ListTemplateStepGroups Operation</seealso>
        ListTemplateStepGroupsResponse ListTemplateStepGroups(ListTemplateStepGroupsRequest request);



        /// <summary>
        /// List the step groups in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateStepGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateStepGroups service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplateStepGroups">REST API Reference for ListTemplateStepGroups Operation</seealso>
        Task<ListTemplateStepGroupsResponse> ListTemplateStepGroupsAsync(ListTemplateStepGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTemplateSteps


        /// <summary>
        /// List the steps in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateSteps service method.</param>
        /// 
        /// <returns>The response from the ListTemplateSteps service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplateSteps">REST API Reference for ListTemplateSteps Operation</seealso>
        ListTemplateStepsResponse ListTemplateSteps(ListTemplateStepsRequest request);



        /// <summary>
        /// List the steps in a template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTemplateSteps service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplateSteps">REST API Reference for ListTemplateSteps Operation</seealso>
        Task<ListTemplateStepsResponse> ListTemplateStepsAsync(ListTemplateStepsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorkflows


        /// <summary>
        /// List the migration workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        ListWorkflowsResponse ListWorkflows(ListWorkflowsRequest request);



        /// <summary>
        /// List the migration workflows.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflows service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        Task<ListWorkflowsResponse> ListWorkflowsAsync(ListWorkflowsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorkflowStepGroups


        /// <summary>
        /// List the step groups in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowStepGroups service method.</param>
        /// 
        /// <returns>The response from the ListWorkflowStepGroups service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflowStepGroups">REST API Reference for ListWorkflowStepGroups Operation</seealso>
        ListWorkflowStepGroupsResponse ListWorkflowStepGroups(ListWorkflowStepGroupsRequest request);



        /// <summary>
        /// List the step groups in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowStepGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowStepGroups service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflowStepGroups">REST API Reference for ListWorkflowStepGroups Operation</seealso>
        Task<ListWorkflowStepGroupsResponse> ListWorkflowStepGroupsAsync(ListWorkflowStepGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListWorkflowSteps


        /// <summary>
        /// List the steps in a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowSteps service method.</param>
        /// 
        /// <returns>The response from the ListWorkflowSteps service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflowSteps">REST API Reference for ListWorkflowSteps Operation</seealso>
        ListWorkflowStepsResponse ListWorkflowSteps(ListWorkflowStepsRequest request);



        /// <summary>
        /// List the steps in a workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkflowSteps service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflowSteps">REST API Reference for ListWorkflowSteps Operation</seealso>
        Task<ListWorkflowStepsResponse> ListWorkflowStepsAsync(ListWorkflowStepsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RetryWorkflowStep


        /// <summary>
        /// Retry a failed step in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryWorkflowStep service method.</param>
        /// 
        /// <returns>The response from the RetryWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/RetryWorkflowStep">REST API Reference for RetryWorkflowStep Operation</seealso>
        RetryWorkflowStepResponse RetryWorkflowStep(RetryWorkflowStepRequest request);



        /// <summary>
        /// Retry a failed step in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetryWorkflowStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RetryWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/RetryWorkflowStep">REST API Reference for RetryWorkflowStep Operation</seealso>
        Task<RetryWorkflowStepResponse> RetryWorkflowStepAsync(RetryWorkflowStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartWorkflow


        /// <summary>
        /// Start a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflow service method.</param>
        /// 
        /// <returns>The response from the StartWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/StartWorkflow">REST API Reference for StartWorkflow Operation</seealso>
        StartWorkflowResponse StartWorkflow(StartWorkflowRequest request);



        /// <summary>
        /// Start a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/StartWorkflow">REST API Reference for StartWorkflow Operation</seealso>
        Task<StartWorkflowResponse> StartWorkflowAsync(StartWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopWorkflow


        /// <summary>
        /// Stop an ongoing migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkflow service method.</param>
        /// 
        /// <returns>The response from the StopWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/StopWorkflow">REST API Reference for StopWorkflow Operation</seealso>
        StopWorkflowResponse StopWorkflow(StopWorkflowRequest request);



        /// <summary>
        /// Stop an ongoing migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/StopWorkflow">REST API Reference for StopWorkflow Operation</seealso>
        Task<StopWorkflowResponse> StopWorkflowAsync(StopWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tag a resource by specifying its Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Tag a resource by specifying its Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Deletes the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Deletes the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateTemplate


        /// <summary>
        /// Updates a migration workflow template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        UpdateTemplateResponse UpdateTemplate(UpdateTemplateRequest request);



        /// <summary>
        /// Updates a migration workflow template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTemplate service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateTemplate">REST API Reference for UpdateTemplate Operation</seealso>
        Task<UpdateTemplateResponse> UpdateTemplateAsync(UpdateTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWorkflow


        /// <summary>
        /// Update a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        UpdateWorkflowResponse UpdateWorkflow(UpdateWorkflowRequest request);



        /// <summary>
        /// Update a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkflow service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        Task<UpdateWorkflowResponse> UpdateWorkflowAsync(UpdateWorkflowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWorkflowStep


        /// <summary>
        /// Update a step in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowStep service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflowStep">REST API Reference for UpdateWorkflowStep Operation</seealso>
        UpdateWorkflowStepResponse UpdateWorkflowStep(UpdateWorkflowStepRequest request);



        /// <summary>
        /// Update a step in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkflowStep service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflowStep">REST API Reference for UpdateWorkflowStep Operation</seealso>
        Task<UpdateWorkflowStepResponse> UpdateWorkflowStepAsync(UpdateWorkflowStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateWorkflowStepGroup


        /// <summary>
        /// Update the step group in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowStepGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflowStepGroup">REST API Reference for UpdateWorkflowStepGroup Operation</seealso>
        UpdateWorkflowStepGroupResponse UpdateWorkflowStepGroup(UpdateWorkflowStepGroupRequest request);



        /// <summary>
        /// Update the step group in a migration workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowStepGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkflowStepGroup service method, as returned by MigrationHubOrchestrator.</returns>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.InternalServerException">
        /// An internal error has occurred.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ResourceNotFoundException">
        /// The resource is not available.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MigrationHubOrchestrator.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflowStepGroup">REST API Reference for UpdateWorkflowStepGroup Operation</seealso>
        Task<UpdateWorkflowStepGroupResponse> UpdateWorkflowStepGroupAsync(UpdateWorkflowStepGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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