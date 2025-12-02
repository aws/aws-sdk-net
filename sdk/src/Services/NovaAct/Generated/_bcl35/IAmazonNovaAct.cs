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
 * Do not modify this file. This file is generated from the nova-act-2025-08-22.normal.json service model.
 */


using System;
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INovaActPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateAct


        /// <summary>
        /// Creates a new AI task (act) within a session that can interact with tools and perform
        /// specific actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAct service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAct operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateAct">REST API Reference for CreateAct Operation</seealso>
        IAsyncResult BeginCreateAct(CreateActRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAct.</param>
        /// 
        /// <returns>Returns a  CreateActResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateAct">REST API Reference for CreateAct Operation</seealso>
        CreateActResponse EndCreateAct(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSession


        /// <summary>
        /// Creates a new session context within a workflow run to manage conversation state and
        /// acts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSession service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSession operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateSession">REST API Reference for CreateSession Operation</seealso>
        IAsyncResult BeginCreateSession(CreateSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSession.</param>
        /// 
        /// <returns>Returns a  CreateSessionResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateSession">REST API Reference for CreateSession Operation</seealso>
        CreateSessionResponse EndCreateSession(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkflowDefinition


        /// <summary>
        /// Creates a new workflow definition template that can be used to execute multiple workflow
        /// runs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowDefinition service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowDefinition operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowDefinition">REST API Reference for CreateWorkflowDefinition Operation</seealso>
        IAsyncResult BeginCreateWorkflowDefinition(CreateWorkflowDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflowDefinition.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowDefinitionResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowDefinition">REST API Reference for CreateWorkflowDefinition Operation</seealso>
        CreateWorkflowDefinitionResponse EndCreateWorkflowDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkflowRun


        /// <summary>
        /// Creates a new execution instance of a workflow definition with specified parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowRun service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkflowRun operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowRun">REST API Reference for CreateWorkflowRun Operation</seealso>
        IAsyncResult BeginCreateWorkflowRun(CreateWorkflowRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkflowRun.</param>
        /// 
        /// <returns>Returns a  CreateWorkflowRunResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/CreateWorkflowRun">REST API Reference for CreateWorkflowRun Operation</seealso>
        CreateWorkflowRunResponse EndCreateWorkflowRun(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkflowDefinition


        /// <summary>
        /// Deletes a workflow definition and all associated resources. This operation cannot
        /// be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowDefinition service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowDefinition operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowDefinition">REST API Reference for DeleteWorkflowDefinition Operation</seealso>
        IAsyncResult BeginDeleteWorkflowDefinition(DeleteWorkflowDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflowDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowDefinitionResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowDefinition">REST API Reference for DeleteWorkflowDefinition Operation</seealso>
        DeleteWorkflowDefinitionResponse EndDeleteWorkflowDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkflowRun


        /// <summary>
        /// Terminates and cleans up a workflow run, stopping all associated acts and sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowRun service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkflowRun operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowRun">REST API Reference for DeleteWorkflowRun Operation</seealso>
        IAsyncResult BeginDeleteWorkflowRun(DeleteWorkflowRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkflowRun.</param>
        /// 
        /// <returns>Returns a  DeleteWorkflowRunResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/DeleteWorkflowRun">REST API Reference for DeleteWorkflowRun Operation</seealso>
        DeleteWorkflowRunResponse EndDeleteWorkflowRun(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkflowDefinition


        /// <summary>
        /// Retrieves the details and configuration of a specific workflow definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowDefinition service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowDefinition operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowDefinition">REST API Reference for GetWorkflowDefinition Operation</seealso>
        IAsyncResult BeginGetWorkflowDefinition(GetWorkflowDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowDefinition.</param>
        /// 
        /// <returns>Returns a  GetWorkflowDefinitionResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowDefinition">REST API Reference for GetWorkflowDefinition Operation</seealso>
        GetWorkflowDefinitionResponse EndGetWorkflowDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkflowRun


        /// <summary>
        /// Retrieves the current state, configuration, and execution details of a workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkflowRun operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        IAsyncResult BeginGetWorkflowRun(GetWorkflowRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkflowRun.</param>
        /// 
        /// <returns>Returns a  GetWorkflowRunResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/GetWorkflowRun">REST API Reference for GetWorkflowRun Operation</seealso>
        GetWorkflowRunResponse EndGetWorkflowRun(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeActStep


        /// <summary>
        /// Executes the next step of an act, processing tool call results and returning new tool
        /// calls if needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeActStep service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeActStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeActStep operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeActStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/InvokeActStep">REST API Reference for InvokeActStep Operation</seealso>
        IAsyncResult BeginInvokeActStep(InvokeActStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeActStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeActStep.</param>
        /// 
        /// <returns>Returns a  InvokeActStepResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/InvokeActStep">REST API Reference for InvokeActStep Operation</seealso>
        InvokeActStepResponse EndInvokeActStep(IAsyncResult asyncResult);

        #endregion
        
        #region  ListActs


        /// <summary>
        /// Lists all acts within a specific session with their current status and execution details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActs service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the ListActs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActs operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListActs">REST API Reference for ListActs Operation</seealso>
        IAsyncResult BeginListActs(ListActsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListActs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActs.</param>
        /// 
        /// <returns>Returns a  ListActsResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListActs">REST API Reference for ListActs Operation</seealso>
        ListActsResponse EndListActs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModels


        /// <summary>
        /// Lists all available AI models that can be used for workflow execution, including their
        /// status and compatibility information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the ListModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListModels">REST API Reference for ListModels Operation</seealso>
        IAsyncResult BeginListModels(ListModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModels.</param>
        /// 
        /// <returns>Returns a  ListModelsResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListModels">REST API Reference for ListModels Operation</seealso>
        ListModelsResponse EndListModels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSessions


        /// <summary>
        /// Lists all sessions within a specific workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListSessions">REST API Reference for ListSessions Operation</seealso>
        IAsyncResult BeginListSessions(ListSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessions.</param>
        /// 
        /// <returns>Returns a  ListSessionsResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListSessions">REST API Reference for ListSessions Operation</seealso>
        ListSessionsResponse EndListSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkflowDefinitions


        /// <summary>
        /// Lists all workflow definitions in your account with optional filtering and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowDefinitions service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowDefinitions operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowDefinitions">REST API Reference for ListWorkflowDefinitions Operation</seealso>
        IAsyncResult BeginListWorkflowDefinitions(ListWorkflowDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflowDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowDefinitions.</param>
        /// 
        /// <returns>Returns a  ListWorkflowDefinitionsResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowDefinitions">REST API Reference for ListWorkflowDefinitions Operation</seealso>
        ListWorkflowDefinitionsResponse EndListWorkflowDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkflowRuns


        /// <summary>
        /// Lists all workflow runs for a specific workflow definition with optional filtering
        /// and pagination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkflowRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkflowRuns operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkflowRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        IAsyncResult BeginListWorkflowRuns(ListWorkflowRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkflowRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkflowRuns.</param>
        /// 
        /// <returns>Returns a  ListWorkflowRunsResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/ListWorkflowRuns">REST API Reference for ListWorkflowRuns Operation</seealso>
        ListWorkflowRunsResponse EndListWorkflowRuns(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAct


        /// <summary>
        /// Updates an existing act's configuration, status, or error information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAct service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAct operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateAct">REST API Reference for UpdateAct Operation</seealso>
        IAsyncResult BeginUpdateAct(UpdateActRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAct.</param>
        /// 
        /// <returns>Returns a  UpdateActResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateAct">REST API Reference for UpdateAct Operation</seealso>
        UpdateActResponse EndUpdateAct(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkflowRun


        /// <summary>
        /// Updates the configuration or state of an active workflow run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowRun service method.</param>
        /// 
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

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkflowRun operation on AmazonNovaActClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkflowRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateWorkflowRun">REST API Reference for UpdateWorkflowRun Operation</seealso>
        IAsyncResult BeginUpdateWorkflowRun(UpdateWorkflowRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkflowRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkflowRun.</param>
        /// 
        /// <returns>Returns a  UpdateWorkflowRunResult from NovaAct.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/nova-act-2025-08-22/UpdateWorkflowRun">REST API Reference for UpdateWorkflowRun Operation</seealso>
        UpdateWorkflowRunResponse EndUpdateWorkflowRun(IAsyncResult asyncResult);

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