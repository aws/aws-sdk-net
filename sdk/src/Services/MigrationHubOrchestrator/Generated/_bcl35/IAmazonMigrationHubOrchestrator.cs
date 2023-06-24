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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MigrationHubOrchestrator.Model;

namespace Amazon.MigrationHubOrchestrator
{
    /// <summary>
    /// Interface for accessing MigrationHubOrchestrator
    ///
    /// This API reference provides descriptions, syntax, and other details about each of
    /// the actions and data types for AWS Migration Hub Orchestrator. he topic for each action
    /// shows the API request parameters and the response. Alternatively, you can use one
    /// of the AWS SDKs to access an API that is tailored to the programming language or platform
    /// that you're using.
    /// </summary>
    public partial interface IAmazonMigrationHubOrchestrator : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMigrationHubOrchestratorPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflow operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        IAsyncResult BeginCreateWorkflow(CreateWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflow">REST API Reference for CreateWorkflow Operation</seealso>
        CreateWorkflowResponse EndCreateWorkflow(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateWorkflowStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowStep operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflowStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflowStep">REST API Reference for CreateWorkflowStep Operation</seealso>
        IAsyncResult BeginCreateWorkflowStep(CreateWorkflowStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflowStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflowStep.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowStepResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflowStep">REST API Reference for CreateWorkflowStep Operation</seealso>
        CreateWorkflowStepResponse EndCreateWorkflowStep(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateWorkflowStepGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowStepGroup operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflowStepGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflowStepGroup">REST API Reference for CreateWorkflowStepGroup Operation</seealso>
        IAsyncResult BeginCreateWorkflowStepGroup(CreateWorkflowStepGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflowStepGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflowStepGroup.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowStepGroupResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/CreateWorkflowStepGroup">REST API Reference for CreateWorkflowStepGroup Operation</seealso>
        CreateWorkflowStepGroupResponse EndCreateWorkflowStepGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflow operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        IAsyncResult BeginDeleteWorkflow(DeleteWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflow">REST API Reference for DeleteWorkflow Operation</seealso>
        DeleteWorkflowResponse EndDeleteWorkflow(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteWorkflowStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowStep operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflowStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflowStep">REST API Reference for DeleteWorkflowStep Operation</seealso>
        IAsyncResult BeginDeleteWorkflowStep(DeleteWorkflowStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflowStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflowStep.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowStepResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflowStep">REST API Reference for DeleteWorkflowStep Operation</seealso>
        DeleteWorkflowStepResponse EndDeleteWorkflowStep(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteWorkflowStepGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowStepGroup operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflowStepGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflowStepGroup">REST API Reference for DeleteWorkflowStepGroup Operation</seealso>
        IAsyncResult BeginDeleteWorkflowStepGroup(DeleteWorkflowStepGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflowStepGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflowStepGroup.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowStepGroupResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/DeleteWorkflowStepGroup">REST API Reference for DeleteWorkflowStepGroup Operation</seealso>
        DeleteWorkflowStepGroupResponse EndDeleteWorkflowStepGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplate operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        IAsyncResult BeginGetTemplate(GetTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplate.</param>
        /// 
        /// <returns>Returns a  GetTemplateResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplate">REST API Reference for GetTemplate Operation</seealso>
        GetTemplateResponse EndGetTemplate(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetTemplateStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateStep operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplateStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplateStep">REST API Reference for GetTemplateStep Operation</seealso>
        IAsyncResult BeginGetTemplateStep(GetTemplateStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplateStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplateStep.</param>
        /// 
        /// <returns>Returns a  GetTemplateStepResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplateStep">REST API Reference for GetTemplateStep Operation</seealso>
        GetTemplateStepResponse EndGetTemplateStep(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetTemplateStepGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateStepGroup operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplateStepGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplateStepGroup">REST API Reference for GetTemplateStepGroup Operation</seealso>
        IAsyncResult BeginGetTemplateStepGroup(GetTemplateStepGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplateStepGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplateStepGroup.</param>
        /// 
        /// <returns>Returns a  GetTemplateStepGroupResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetTemplateStepGroup">REST API Reference for GetTemplateStepGroup Operation</seealso>
        GetTemplateStepGroupResponse EndGetTemplateStepGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflow operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        IAsyncResult BeginGetWorkflow(GetWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflow.</param>
        /// 
        /// <returns>Returns a  GetWorkflowResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflow">REST API Reference for GetWorkflow Operation</seealso>
        GetWorkflowResponse EndGetWorkflow(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetWorkflowStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowStep operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflowStep">REST API Reference for GetWorkflowStep Operation</seealso>
        IAsyncResult BeginGetWorkflowStep(GetWorkflowStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowStep.</param>
        /// 
        /// <returns>Returns a  GetWorkflowStepResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflowStep">REST API Reference for GetWorkflowStep Operation</seealso>
        GetWorkflowStepResponse EndGetWorkflowStep(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetWorkflowStepGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowStepGroup operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowStepGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflowStepGroup">REST API Reference for GetWorkflowStepGroup Operation</seealso>
        IAsyncResult BeginGetWorkflowStepGroup(GetWorkflowStepGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowStepGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowStepGroup.</param>
        /// 
        /// <returns>Returns a  GetWorkflowStepGroupResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/GetWorkflowStepGroup">REST API Reference for GetWorkflowStepGroup Operation</seealso>
        GetWorkflowStepGroupResponse EndGetWorkflowStepGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListPlugins operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlugins operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPlugins
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        IAsyncResult BeginListPlugins(ListPluginsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPlugins operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPlugins.</param>
        /// 
        /// <returns>Returns a  ListPluginsResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListPlugins">REST API Reference for ListPlugins Operation</seealso>
        ListPluginsResponse EndListPlugins(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplates operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        IAsyncResult BeginListTemplates(ListTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplates.</param>
        /// 
        /// <returns>Returns a  ListTemplatesResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplates">REST API Reference for ListTemplates Operation</seealso>
        ListTemplatesResponse EndListTemplates(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTemplateStepGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateStepGroups operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateStepGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplateStepGroups">REST API Reference for ListTemplateStepGroups Operation</seealso>
        IAsyncResult BeginListTemplateStepGroups(ListTemplateStepGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateStepGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateStepGroups.</param>
        /// 
        /// <returns>Returns a  ListTemplateStepGroupsResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplateStepGroups">REST API Reference for ListTemplateStepGroups Operation</seealso>
        ListTemplateStepGroupsResponse EndListTemplateStepGroups(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTemplateSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTemplateSteps operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTemplateSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplateSteps">REST API Reference for ListTemplateSteps Operation</seealso>
        IAsyncResult BeginListTemplateSteps(ListTemplateStepsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTemplateSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTemplateSteps.</param>
        /// 
        /// <returns>Returns a  ListTemplateStepsResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListTemplateSteps">REST API Reference for ListTemplateSteps Operation</seealso>
        ListTemplateStepsResponse EndListTemplateSteps(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflows operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        IAsyncResult BeginListWorkflows(ListWorkflowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflows.</param>
        /// 
        /// <returns>Returns a  ListWorkflowsResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflows">REST API Reference for ListWorkflows Operation</seealso>
        ListWorkflowsResponse EndListWorkflows(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListWorkflowStepGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowStepGroups operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowStepGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflowStepGroups">REST API Reference for ListWorkflowStepGroups Operation</seealso>
        IAsyncResult BeginListWorkflowStepGroups(ListWorkflowStepGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflowStepGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowStepGroups.</param>
        /// 
        /// <returns>Returns a  ListWorkflowStepGroupsResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflowStepGroups">REST API Reference for ListWorkflowStepGroups Operation</seealso>
        ListWorkflowStepGroupsResponse EndListWorkflowStepGroups(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListWorkflowSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowSteps operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflowSteps">REST API Reference for ListWorkflowSteps Operation</seealso>
        IAsyncResult BeginListWorkflowSteps(ListWorkflowStepsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflowSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowSteps.</param>
        /// 
        /// <returns>Returns a  ListWorkflowStepsResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/ListWorkflowSteps">REST API Reference for ListWorkflowSteps Operation</seealso>
        ListWorkflowStepsResponse EndListWorkflowSteps(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the RetryWorkflowStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetryWorkflowStep operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetryWorkflowStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/RetryWorkflowStep">REST API Reference for RetryWorkflowStep Operation</seealso>
        IAsyncResult BeginRetryWorkflowStep(RetryWorkflowStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetryWorkflowStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetryWorkflowStep.</param>
        /// 
        /// <returns>Returns a  RetryWorkflowStepResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/RetryWorkflowStep">REST API Reference for RetryWorkflowStep Operation</seealso>
        RetryWorkflowStepResponse EndRetryWorkflowStep(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StartWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkflow operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/StartWorkflow">REST API Reference for StartWorkflow Operation</seealso>
        IAsyncResult BeginStartWorkflow(StartWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWorkflow.</param>
        /// 
        /// <returns>Returns a  StartWorkflowResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/StartWorkflow">REST API Reference for StartWorkflow Operation</seealso>
        StartWorkflowResponse EndStartWorkflow(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the StopWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopWorkflow operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/StopWorkflow">REST API Reference for StopWorkflow Operation</seealso>
        IAsyncResult BeginStopWorkflow(StopWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopWorkflow.</param>
        /// 
        /// <returns>Returns a  StopWorkflowResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/StopWorkflow">REST API Reference for StopWorkflow Operation</seealso>
        StopWorkflowResponse EndStopWorkflow(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflow operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        IAsyncResult BeginUpdateWorkflow(UpdateWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkflow.</param>
        /// 
        /// <returns>Returns a  UpdateWorkflowResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflow">REST API Reference for UpdateWorkflow Operation</seealso>
        UpdateWorkflowResponse EndUpdateWorkflow(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateWorkflowStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowStep operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkflowStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflowStep">REST API Reference for UpdateWorkflowStep Operation</seealso>
        IAsyncResult BeginUpdateWorkflowStep(UpdateWorkflowStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkflowStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkflowStep.</param>
        /// 
        /// <returns>Returns a  UpdateWorkflowStepResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflowStep">REST API Reference for UpdateWorkflowStep Operation</seealso>
        UpdateWorkflowStepResponse EndUpdateWorkflowStep(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateWorkflowStepGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowStepGroup operation on AmazonMigrationHubOrchestratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkflowStepGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflowStepGroup">REST API Reference for UpdateWorkflowStepGroup Operation</seealso>
        IAsyncResult BeginUpdateWorkflowStepGroup(UpdateWorkflowStepGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkflowStepGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkflowStepGroup.</param>
        /// 
        /// <returns>Returns a  UpdateWorkflowStepGroupResult from MigrationHubOrchestrator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/migrationhuborchestrator-2021-08-28/UpdateWorkflowStepGroup">REST API Reference for UpdateWorkflowStepGroup Operation</seealso>
        UpdateWorkflowStepGroupResponse EndUpdateWorkflowStepGroup(IAsyncResult asyncResult);

        #endregion
        
    }
}