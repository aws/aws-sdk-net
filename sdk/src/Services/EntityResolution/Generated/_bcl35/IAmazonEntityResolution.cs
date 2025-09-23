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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EntityResolution.Model;

#pragma warning disable CS1570
namespace Amazon.EntityResolution
{
    /// <summary>
    /// <para>Interface for accessing EntityResolution</para>
    ///
    /// Welcome to the <i>Entity Resolution API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Entity Resolution is an Amazon Web Services service that provides pre-configured entity
    /// resolution capabilities that enable developers and analysts at advertising and marketing
    /// companies to build an accurate and complete view of their consumers.
    /// </para>
    ///  
    /// <para>
    ///  With Entity Resolution, you can match source records containing consumer identifiers,
    /// such as name, email address, and phone number. This is true even when these records
    /// have incomplete or conflicting identifiers. For example, Entity Resolution can effectively
    /// match a source record from a customer relationship management (CRM) system with a
    /// source record from a marketing system containing campaign information.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Entity Resolution concepts, procedures, and best practices, see
    /// the <a href="https://docs.aws.amazon.com/entityresolution/latest/userguide/what-is-service.html">Entity
    /// Resolution User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonEntityResolution : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IEntityResolutionPaginatorFactory Paginators { get; }
#endif


        
        #region  AddPolicyStatement


        /// <summary>
        /// Adds a policy statement object. To retrieve a list of existing policy statements,
        /// use the <c>GetPolicy</c> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPolicyStatement service method.</param>
        /// 
        /// <returns>The response from the AddPolicyStatement service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/AddPolicyStatement">REST API Reference for AddPolicyStatement Operation</seealso>
        AddPolicyStatementResponse AddPolicyStatement(AddPolicyStatementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddPolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPolicyStatement operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddPolicyStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/AddPolicyStatement">REST API Reference for AddPolicyStatement Operation</seealso>
        IAsyncResult BeginAddPolicyStatement(AddPolicyStatementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddPolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPolicyStatement.</param>
        /// 
        /// <returns>Returns a  AddPolicyStatementResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/AddPolicyStatement">REST API Reference for AddPolicyStatement Operation</seealso>
        AddPolicyStatementResponse EndAddPolicyStatement(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteUniqueId


        /// <summary>
        /// Deletes multiple unique IDs in a matching workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUniqueId service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteUniqueId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/BatchDeleteUniqueId">REST API Reference for BatchDeleteUniqueId Operation</seealso>
        BatchDeleteUniqueIdResponse BatchDeleteUniqueId(BatchDeleteUniqueIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteUniqueId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteUniqueId operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteUniqueId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/BatchDeleteUniqueId">REST API Reference for BatchDeleteUniqueId Operation</seealso>
        IAsyncResult BeginBatchDeleteUniqueId(BatchDeleteUniqueIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteUniqueId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteUniqueId.</param>
        /// 
        /// <returns>Returns a  BatchDeleteUniqueIdResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/BatchDeleteUniqueId">REST API Reference for BatchDeleteUniqueId Operation</seealso>
        BatchDeleteUniqueIdResponse EndBatchDeleteUniqueId(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIdMappingWorkflow


        /// <summary>
        /// Creates an <c>IdMappingWorkflow</c> object which stores the configuration of the data
        /// processing job to be run. Each <c>IdMappingWorkflow</c> must have a unique workflow
        /// name. To modify an existing workflow, use the UpdateIdMappingWorkflow API.
        /// 
        ///  <important> 
        /// <para>
        /// Incremental processing is not supported for ID mapping workflows. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdMappingWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdMappingWorkflow">REST API Reference for CreateIdMappingWorkflow Operation</seealso>
        CreateIdMappingWorkflowResponse CreateIdMappingWorkflow(CreateIdMappingWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdMappingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdMappingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdMappingWorkflow">REST API Reference for CreateIdMappingWorkflow Operation</seealso>
        IAsyncResult BeginCreateIdMappingWorkflow(CreateIdMappingWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdMappingWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateIdMappingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdMappingWorkflow">REST API Reference for CreateIdMappingWorkflow Operation</seealso>
        CreateIdMappingWorkflowResponse EndCreateIdMappingWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateIdNamespace


        /// <summary>
        /// Creates an ID namespace object which will help customers provide metadata explaining
        /// their dataset and how to use it. Each ID namespace must have a unique name. To modify
        /// an existing ID namespace, use the UpdateIdNamespace API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdNamespace service method.</param>
        /// 
        /// <returns>The response from the CreateIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdNamespace">REST API Reference for CreateIdNamespace Operation</seealso>
        CreateIdNamespaceResponse CreateIdNamespace(CreateIdNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdNamespace operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdNamespace">REST API Reference for CreateIdNamespace Operation</seealso>
        IAsyncResult BeginCreateIdNamespace(CreateIdNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdNamespace.</param>
        /// 
        /// <returns>Returns a  CreateIdNamespaceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateIdNamespace">REST API Reference for CreateIdNamespace Operation</seealso>
        CreateIdNamespaceResponse EndCreateIdNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMatchingWorkflow


        /// <summary>
        /// Creates a matching workflow that defines the configuration for a data processing job.
        /// The workflow name must be unique. To modify an existing workflow, use <c>UpdateMatchingWorkflow</c>.
        /// 
        /// 
        ///  <important> 
        /// <para>
        /// For workflows where <c>resolutionType</c> is <c>ML_MATCHING</c> or <c>PROVIDER</c>,
        /// incremental processing is not supported. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateMatchingWorkflow">REST API Reference for CreateMatchingWorkflow Operation</seealso>
        CreateMatchingWorkflowResponse CreateMatchingWorkflow(CreateMatchingWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMatchingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateMatchingWorkflow">REST API Reference for CreateMatchingWorkflow Operation</seealso>
        IAsyncResult BeginCreateMatchingWorkflow(CreateMatchingWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMatchingWorkflow.</param>
        /// 
        /// <returns>Returns a  CreateMatchingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateMatchingWorkflow">REST API Reference for CreateMatchingWorkflow Operation</seealso>
        CreateMatchingWorkflowResponse EndCreateMatchingWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSchemaMapping


        /// <summary>
        /// Creates a schema mapping, which defines the schema of the input customer records table.
        /// The <c>SchemaMapping</c> also provides Entity Resolution with some metadata about
        /// the table, such as the attribute types of the columns and which columns to match on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the CreateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateSchemaMapping">REST API Reference for CreateSchemaMapping Operation</seealso>
        CreateSchemaMappingResponse CreateSchemaMapping(CreateSchemaMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchemaMapping operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchemaMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateSchemaMapping">REST API Reference for CreateSchemaMapping Operation</seealso>
        IAsyncResult BeginCreateSchemaMapping(CreateSchemaMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchemaMapping.</param>
        /// 
        /// <returns>Returns a  CreateSchemaMappingResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/CreateSchemaMapping">REST API Reference for CreateSchemaMapping Operation</seealso>
        CreateSchemaMappingResponse EndCreateSchemaMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIdMappingWorkflow


        /// <summary>
        /// Deletes the <c>IdMappingWorkflow</c> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdMappingWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdMappingWorkflow">REST API Reference for DeleteIdMappingWorkflow Operation</seealso>
        DeleteIdMappingWorkflowResponse DeleteIdMappingWorkflow(DeleteIdMappingWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdMappingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdMappingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdMappingWorkflow">REST API Reference for DeleteIdMappingWorkflow Operation</seealso>
        IAsyncResult BeginDeleteIdMappingWorkflow(DeleteIdMappingWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdMappingWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteIdMappingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdMappingWorkflow">REST API Reference for DeleteIdMappingWorkflow Operation</seealso>
        DeleteIdMappingWorkflowResponse EndDeleteIdMappingWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteIdNamespace


        /// <summary>
        /// Deletes the <c>IdNamespace</c> with a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdNamespace service method.</param>
        /// 
        /// <returns>The response from the DeleteIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdNamespace">REST API Reference for DeleteIdNamespace Operation</seealso>
        DeleteIdNamespaceResponse DeleteIdNamespace(DeleteIdNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdNamespace operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdNamespace">REST API Reference for DeleteIdNamespace Operation</seealso>
        IAsyncResult BeginDeleteIdNamespace(DeleteIdNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdNamespace.</param>
        /// 
        /// <returns>Returns a  DeleteIdNamespaceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteIdNamespace">REST API Reference for DeleteIdNamespace Operation</seealso>
        DeleteIdNamespaceResponse EndDeleteIdNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMatchingWorkflow


        /// <summary>
        /// Deletes the <c>MatchingWorkflow</c> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteMatchingWorkflow">REST API Reference for DeleteMatchingWorkflow Operation</seealso>
        DeleteMatchingWorkflowResponse DeleteMatchingWorkflow(DeleteMatchingWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMatchingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteMatchingWorkflow">REST API Reference for DeleteMatchingWorkflow Operation</seealso>
        IAsyncResult BeginDeleteMatchingWorkflow(DeleteMatchingWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMatchingWorkflow.</param>
        /// 
        /// <returns>Returns a  DeleteMatchingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteMatchingWorkflow">REST API Reference for DeleteMatchingWorkflow Operation</seealso>
        DeleteMatchingWorkflowResponse EndDeleteMatchingWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePolicyStatement


        /// <summary>
        /// Deletes the policy statement.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyStatement service method.</param>
        /// 
        /// <returns>The response from the DeletePolicyStatement service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeletePolicyStatement">REST API Reference for DeletePolicyStatement Operation</seealso>
        DeletePolicyStatementResponse DeletePolicyStatement(DeletePolicyStatementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyStatement operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicyStatement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeletePolicyStatement">REST API Reference for DeletePolicyStatement Operation</seealso>
        IAsyncResult BeginDeletePolicyStatement(DeletePolicyStatementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicyStatement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicyStatement.</param>
        /// 
        /// <returns>Returns a  DeletePolicyStatementResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeletePolicyStatement">REST API Reference for DeletePolicyStatement Operation</seealso>
        DeletePolicyStatementResponse EndDeletePolicyStatement(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSchemaMapping


        /// <summary>
        /// Deletes the <c>SchemaMapping</c> with a given name. This operation will succeed even
        /// if a schema with the given name does not exist. This operation will fail if there
        /// is a <c>MatchingWorkflow</c> object that references the <c>SchemaMapping</c> in the
        /// workflow's <c>InputSourceConfig</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteSchemaMapping">REST API Reference for DeleteSchemaMapping Operation</seealso>
        DeleteSchemaMappingResponse DeleteSchemaMapping(DeleteSchemaMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaMapping operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchemaMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteSchemaMapping">REST API Reference for DeleteSchemaMapping Operation</seealso>
        IAsyncResult BeginDeleteSchemaMapping(DeleteSchemaMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchemaMapping.</param>
        /// 
        /// <returns>Returns a  DeleteSchemaMappingResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/DeleteSchemaMapping">REST API Reference for DeleteSchemaMapping Operation</seealso>
        DeleteSchemaMappingResponse EndDeleteSchemaMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  GenerateMatchId


        /// <summary>
        /// Generates or retrieves Match IDs for records using a rule-based matching workflow.
        /// When you call this operation, it processes your records against the workflow's matching
        /// rules to identify potential matches. For existing records, it retrieves their Match
        /// IDs and associated rules. For records without matches, it generates new Match IDs.
        /// The operation saves results to Amazon S3. 
        /// 
        ///  
        /// <para>
        /// The processing type (<c>processingType</c>) you choose affects both the accuracy and
        /// response time of the operation. Additional charges apply for each API call, whether
        /// made through the Entity Resolution console or directly via the API. The rule-based
        /// matching workflow must exist and be active before calling this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GenerateMatchId service method.</param>
        /// 
        /// <returns>The response from the GenerateMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GenerateMatchId">REST API Reference for GenerateMatchId Operation</seealso>
        GenerateMatchIdResponse GenerateMatchId(GenerateMatchIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateMatchId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateMatchId operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGenerateMatchId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GenerateMatchId">REST API Reference for GenerateMatchId Operation</seealso>
        IAsyncResult BeginGenerateMatchId(GenerateMatchIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GenerateMatchId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGenerateMatchId.</param>
        /// 
        /// <returns>Returns a  GenerateMatchIdResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GenerateMatchId">REST API Reference for GenerateMatchId Operation</seealso>
        GenerateMatchIdResponse EndGenerateMatchId(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIdMappingJob


        /// <summary>
        /// Returns the status, metrics, and errors (if there are any) that are associated with
        /// a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingJob service method.</param>
        /// 
        /// <returns>The response from the GetIdMappingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingJob">REST API Reference for GetIdMappingJob Operation</seealso>
        GetIdMappingJobResponse GetIdMappingJob(GetIdMappingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdMappingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingJob operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdMappingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingJob">REST API Reference for GetIdMappingJob Operation</seealso>
        IAsyncResult BeginGetIdMappingJob(GetIdMappingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdMappingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdMappingJob.</param>
        /// 
        /// <returns>Returns a  GetIdMappingJobResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingJob">REST API Reference for GetIdMappingJob Operation</seealso>
        GetIdMappingJobResponse EndGetIdMappingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIdMappingWorkflow


        /// <summary>
        /// Returns the <c>IdMappingWorkflow</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingWorkflow">REST API Reference for GetIdMappingWorkflow Operation</seealso>
        GetIdMappingWorkflowResponse GetIdMappingWorkflow(GetIdMappingWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdMappingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdMappingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingWorkflow">REST API Reference for GetIdMappingWorkflow Operation</seealso>
        IAsyncResult BeginGetIdMappingWorkflow(GetIdMappingWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdMappingWorkflow.</param>
        /// 
        /// <returns>Returns a  GetIdMappingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdMappingWorkflow">REST API Reference for GetIdMappingWorkflow Operation</seealso>
        GetIdMappingWorkflowResponse EndGetIdMappingWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIdNamespace


        /// <summary>
        /// Returns the <c>IdNamespace</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdNamespace service method.</param>
        /// 
        /// <returns>The response from the GetIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdNamespace">REST API Reference for GetIdNamespace Operation</seealso>
        GetIdNamespaceResponse GetIdNamespace(GetIdNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdNamespace operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdNamespace">REST API Reference for GetIdNamespace Operation</seealso>
        IAsyncResult BeginGetIdNamespace(GetIdNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdNamespace.</param>
        /// 
        /// <returns>Returns a  GetIdNamespaceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetIdNamespace">REST API Reference for GetIdNamespace Operation</seealso>
        GetIdNamespaceResponse EndGetIdNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMatchId


        /// <summary>
        /// Returns the corresponding Match ID of a customer record if the record has been processed
        /// in a rule-based matching workflow.
        /// 
        ///  
        /// <para>
        /// You can call this API as a dry run of an incremental load on the rule-based matching
        /// workflow.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchId service method.</param>
        /// 
        /// <returns>The response from the GetMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchId">REST API Reference for GetMatchId Operation</seealso>
        GetMatchIdResponse GetMatchId(GetMatchIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMatchId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMatchId operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMatchId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchId">REST API Reference for GetMatchId Operation</seealso>
        IAsyncResult BeginGetMatchId(GetMatchIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMatchId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMatchId.</param>
        /// 
        /// <returns>Returns a  GetMatchIdResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchId">REST API Reference for GetMatchId Operation</seealso>
        GetMatchIdResponse EndGetMatchId(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMatchingJob


        /// <summary>
        /// Returns the status, metrics, and errors (if there are any) that are associated with
        /// a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingJob service method.</param>
        /// 
        /// <returns>The response from the GetMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingJob">REST API Reference for GetMatchingJob Operation</seealso>
        GetMatchingJobResponse GetMatchingJob(GetMatchingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMatchingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingJob operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMatchingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingJob">REST API Reference for GetMatchingJob Operation</seealso>
        IAsyncResult BeginGetMatchingJob(GetMatchingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMatchingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMatchingJob.</param>
        /// 
        /// <returns>Returns a  GetMatchingJobResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingJob">REST API Reference for GetMatchingJob Operation</seealso>
        GetMatchingJobResponse EndGetMatchingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMatchingWorkflow


        /// <summary>
        /// Returns the <c>MatchingWorkflow</c> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingWorkflow">REST API Reference for GetMatchingWorkflow Operation</seealso>
        GetMatchingWorkflowResponse GetMatchingWorkflow(GetMatchingWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMatchingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingWorkflow">REST API Reference for GetMatchingWorkflow Operation</seealso>
        IAsyncResult BeginGetMatchingWorkflow(GetMatchingWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMatchingWorkflow.</param>
        /// 
        /// <returns>Returns a  GetMatchingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetMatchingWorkflow">REST API Reference for GetMatchingWorkflow Operation</seealso>
        GetMatchingWorkflowResponse EndGetMatchingWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Returns the resource-based policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetProviderService


        /// <summary>
        /// Returns the <c>ProviderService</c> of a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProviderService service method.</param>
        /// 
        /// <returns>The response from the GetProviderService service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetProviderService">REST API Reference for GetProviderService Operation</seealso>
        GetProviderServiceResponse GetProviderService(GetProviderServiceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetProviderService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetProviderService operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetProviderService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetProviderService">REST API Reference for GetProviderService Operation</seealso>
        IAsyncResult BeginGetProviderService(GetProviderServiceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetProviderService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetProviderService.</param>
        /// 
        /// <returns>Returns a  GetProviderServiceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetProviderService">REST API Reference for GetProviderService Operation</seealso>
        GetProviderServiceResponse EndGetProviderService(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSchemaMapping


        /// <summary>
        /// Returns the SchemaMapping of a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the GetSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetSchemaMapping">REST API Reference for GetSchemaMapping Operation</seealso>
        GetSchemaMappingResponse GetSchemaMapping(GetSchemaMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaMapping operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchemaMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetSchemaMapping">REST API Reference for GetSchemaMapping Operation</seealso>
        IAsyncResult BeginGetSchemaMapping(GetSchemaMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchemaMapping.</param>
        /// 
        /// <returns>Returns a  GetSchemaMappingResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/GetSchemaMapping">REST API Reference for GetSchemaMapping Operation</seealso>
        GetSchemaMappingResponse EndGetSchemaMapping(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIdMappingJobs


        /// <summary>
        /// Lists all ID mapping jobs for a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingJobs service method.</param>
        /// 
        /// <returns>The response from the ListIdMappingJobs service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingJobs">REST API Reference for ListIdMappingJobs Operation</seealso>
        ListIdMappingJobsResponse ListIdMappingJobs(ListIdMappingJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdMappingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingJobs operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdMappingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingJobs">REST API Reference for ListIdMappingJobs Operation</seealso>
        IAsyncResult BeginListIdMappingJobs(ListIdMappingJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdMappingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdMappingJobs.</param>
        /// 
        /// <returns>Returns a  ListIdMappingJobsResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingJobs">REST API Reference for ListIdMappingJobs Operation</seealso>
        ListIdMappingJobsResponse EndListIdMappingJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIdMappingWorkflows


        /// <summary>
        /// Returns a list of all the <c>IdMappingWorkflows</c> that have been created for an
        /// Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListIdMappingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingWorkflows">REST API Reference for ListIdMappingWorkflows Operation</seealso>
        ListIdMappingWorkflowsResponse ListIdMappingWorkflows(ListIdMappingWorkflowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdMappingWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdMappingWorkflows operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdMappingWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingWorkflows">REST API Reference for ListIdMappingWorkflows Operation</seealso>
        IAsyncResult BeginListIdMappingWorkflows(ListIdMappingWorkflowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdMappingWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdMappingWorkflows.</param>
        /// 
        /// <returns>Returns a  ListIdMappingWorkflowsResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdMappingWorkflows">REST API Reference for ListIdMappingWorkflows Operation</seealso>
        ListIdMappingWorkflowsResponse EndListIdMappingWorkflows(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIdNamespaces


        /// <summary>
        /// Returns a list of all ID namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdNamespaces service method.</param>
        /// 
        /// <returns>The response from the ListIdNamespaces service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdNamespaces">REST API Reference for ListIdNamespaces Operation</seealso>
        ListIdNamespacesResponse ListIdNamespaces(ListIdNamespacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdNamespaces operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdNamespaces">REST API Reference for ListIdNamespaces Operation</seealso>
        IAsyncResult BeginListIdNamespaces(ListIdNamespacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdNamespaces.</param>
        /// 
        /// <returns>Returns a  ListIdNamespacesResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListIdNamespaces">REST API Reference for ListIdNamespaces Operation</seealso>
        ListIdNamespacesResponse EndListIdNamespaces(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMatchingJobs


        /// <summary>
        /// Lists all jobs for a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingJobs service method.</param>
        /// 
        /// <returns>The response from the ListMatchingJobs service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingJobs">REST API Reference for ListMatchingJobs Operation</seealso>
        ListMatchingJobsResponse ListMatchingJobs(ListMatchingJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMatchingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingJobs operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMatchingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingJobs">REST API Reference for ListMatchingJobs Operation</seealso>
        IAsyncResult BeginListMatchingJobs(ListMatchingJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMatchingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMatchingJobs.</param>
        /// 
        /// <returns>Returns a  ListMatchingJobsResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingJobs">REST API Reference for ListMatchingJobs Operation</seealso>
        ListMatchingJobsResponse EndListMatchingJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMatchingWorkflows


        /// <summary>
        /// Returns a list of all the <c>MatchingWorkflows</c> that have been created for an Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListMatchingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingWorkflows">REST API Reference for ListMatchingWorkflows Operation</seealso>
        ListMatchingWorkflowsResponse ListMatchingWorkflows(ListMatchingWorkflowsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMatchingWorkflows operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingWorkflows operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMatchingWorkflows
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingWorkflows">REST API Reference for ListMatchingWorkflows Operation</seealso>
        IAsyncResult BeginListMatchingWorkflows(ListMatchingWorkflowsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMatchingWorkflows operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMatchingWorkflows.</param>
        /// 
        /// <returns>Returns a  ListMatchingWorkflowsResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListMatchingWorkflows">REST API Reference for ListMatchingWorkflows Operation</seealso>
        ListMatchingWorkflowsResponse EndListMatchingWorkflows(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProviderServices


        /// <summary>
        /// Returns a list of all the <c>ProviderServices</c> that are available in this Amazon
        /// Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProviderServices service method.</param>
        /// 
        /// <returns>The response from the ListProviderServices service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListProviderServices">REST API Reference for ListProviderServices Operation</seealso>
        ListProviderServicesResponse ListProviderServices(ListProviderServicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProviderServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProviderServices operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProviderServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListProviderServices">REST API Reference for ListProviderServices Operation</seealso>
        IAsyncResult BeginListProviderServices(ListProviderServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProviderServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProviderServices.</param>
        /// 
        /// <returns>Returns a  ListProviderServicesResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListProviderServices">REST API Reference for ListProviderServices Operation</seealso>
        ListProviderServicesResponse EndListProviderServices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSchemaMappings


        /// <summary>
        /// Returns a list of all the <c>SchemaMappings</c> that have been created for an Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaMappings service method.</param>
        /// 
        /// <returns>The response from the ListSchemaMappings service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListSchemaMappings">REST API Reference for ListSchemaMappings Operation</seealso>
        ListSchemaMappingsResponse ListSchemaMappings(ListSchemaMappingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSchemaMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaMappings operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchemaMappings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListSchemaMappings">REST API Reference for ListSchemaMappings Operation</seealso>
        IAsyncResult BeginListSchemaMappings(ListSchemaMappingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchemaMappings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchemaMappings.</param>
        /// 
        /// <returns>Returns a  ListSchemaMappingsResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListSchemaMappings">REST API Reference for ListSchemaMappings Operation</seealso>
        ListSchemaMappingsResponse EndListSchemaMappings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with an Entity Resolution resource. In Entity Resolution,
        /// <c>SchemaMapping</c>, and <c>MatchingWorkflow</c> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPolicy


        /// <summary>
        /// Updates the resource-based policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy service method.</param>
        /// 
        /// <returns>The response from the PutPolicy service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        PutPolicyResponse PutPolicy(PutPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPolicy operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        IAsyncResult BeginPutPolicy(PutPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPolicy.</param>
        /// 
        /// <returns>Returns a  PutPolicyResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/PutPolicy">REST API Reference for PutPolicy Operation</seealso>
        PutPolicyResponse EndPutPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  StartIdMappingJob


        /// <summary>
        /// Starts the <c>IdMappingJob</c> of a workflow. The workflow must have previously been
        /// created using the <c>CreateIdMappingWorkflow</c> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartIdMappingJob service method.</param>
        /// 
        /// <returns>The response from the StartIdMappingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartIdMappingJob">REST API Reference for StartIdMappingJob Operation</seealso>
        StartIdMappingJobResponse StartIdMappingJob(StartIdMappingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartIdMappingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartIdMappingJob operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartIdMappingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartIdMappingJob">REST API Reference for StartIdMappingJob Operation</seealso>
        IAsyncResult BeginStartIdMappingJob(StartIdMappingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartIdMappingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartIdMappingJob.</param>
        /// 
        /// <returns>Returns a  StartIdMappingJobResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartIdMappingJob">REST API Reference for StartIdMappingJob Operation</seealso>
        StartIdMappingJobResponse EndStartIdMappingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMatchingJob


        /// <summary>
        /// Starts the <c>MatchingJob</c> of a workflow. The workflow must have previously been
        /// created using the <c>CreateMatchingWorkflow</c> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchingJob service method.</param>
        /// 
        /// <returns>The response from the StartMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartMatchingJob">REST API Reference for StartMatchingJob Operation</seealso>
        StartMatchingJobResponse StartMatchingJob(StartMatchingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMatchingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMatchingJob operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMatchingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartMatchingJob">REST API Reference for StartMatchingJob Operation</seealso>
        IAsyncResult BeginStartMatchingJob(StartMatchingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMatchingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMatchingJob.</param>
        /// 
        /// <returns>Returns a  StartMatchingJobResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/StartMatchingJob">REST API Reference for StartMatchingJob Operation</seealso>
        StartMatchingJobResponse EndStartMatchingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified Entity Resolution resource.
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values. In Entity Resolution, <c>SchemaMapping</c> and <c>MatchingWorkflow</c>
        /// can be tagged. Tags don't have any semantic meaning to Amazon Web Services and are
        /// interpreted strictly as strings of characters. You can use the <c>TagResource</c>
        /// action with a resource that already has tags. If you specify a new tag key, this tag
        /// is appended to the list of tags associated with the resource. If you specify a tag
        /// key that is already associated with the resource, the new tag value that you specify
        /// replaces the previous value for that tag.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified Entity Resolution resource. In Entity
        /// Resolution, <c>SchemaMapping</c>, and <c>MatchingWorkflow</c> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIdMappingWorkflow


        /// <summary>
        /// Updates an existing <c>IdMappingWorkflow</c>. This method is identical to CreateIdMappingWorkflow,
        /// except it uses an HTTP <c>PUT</c> request instead of a <c>POST</c> request, and the
        /// <c>IdMappingWorkflow</c> must already exist for the method to succeed.
        /// 
        ///  <important> 
        /// <para>
        /// Incremental processing is not supported for ID mapping workflows. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdMappingWorkflow service method.</param>
        /// 
        /// <returns>The response from the UpdateIdMappingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdMappingWorkflow">REST API Reference for UpdateIdMappingWorkflow Operation</seealso>
        UpdateIdMappingWorkflowResponse UpdateIdMappingWorkflow(UpdateIdMappingWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdMappingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdMappingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdMappingWorkflow">REST API Reference for UpdateIdMappingWorkflow Operation</seealso>
        IAsyncResult BeginUpdateIdMappingWorkflow(UpdateIdMappingWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdMappingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdMappingWorkflow.</param>
        /// 
        /// <returns>Returns a  UpdateIdMappingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdMappingWorkflow">REST API Reference for UpdateIdMappingWorkflow Operation</seealso>
        UpdateIdMappingWorkflowResponse EndUpdateIdMappingWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIdNamespace


        /// <summary>
        /// Updates an existing ID namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdNamespace service method.</param>
        /// 
        /// <returns>The response from the UpdateIdNamespace service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdNamespace">REST API Reference for UpdateIdNamespace Operation</seealso>
        UpdateIdNamespaceResponse UpdateIdNamespace(UpdateIdNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdNamespace operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIdNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdNamespace">REST API Reference for UpdateIdNamespace Operation</seealso>
        IAsyncResult BeginUpdateIdNamespace(UpdateIdNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIdNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIdNamespace.</param>
        /// 
        /// <returns>Returns a  UpdateIdNamespaceResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateIdNamespace">REST API Reference for UpdateIdNamespace Operation</seealso>
        UpdateIdNamespaceResponse EndUpdateIdNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMatchingWorkflow


        /// <summary>
        /// Updates an existing matching workflow. The workflow must already exist for this operation
        /// to succeed.
        /// 
        ///  <important> 
        /// <para>
        /// For workflows where <c>resolutionType</c> is <c>ML_MATCHING</c> or <c>PROVIDER</c>,
        /// incremental processing is not supported. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the UpdateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateMatchingWorkflow">REST API Reference for UpdateMatchingWorkflow Operation</seealso>
        UpdateMatchingWorkflowResponse UpdateMatchingWorkflow(UpdateMatchingWorkflowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchingWorkflow operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMatchingWorkflow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateMatchingWorkflow">REST API Reference for UpdateMatchingWorkflow Operation</seealso>
        IAsyncResult BeginUpdateMatchingWorkflow(UpdateMatchingWorkflowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMatchingWorkflow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMatchingWorkflow.</param>
        /// 
        /// <returns>Returns a  UpdateMatchingWorkflowResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateMatchingWorkflow">REST API Reference for UpdateMatchingWorkflow Operation</seealso>
        UpdateMatchingWorkflowResponse EndUpdateMatchingWorkflow(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSchemaMapping


        /// <summary>
        /// Updates a schema mapping.
        /// 
        ///  <note> 
        /// <para>
        /// A schema is immutable if it is being used by a workflow. Therefore, you can't update
        /// a schema mapping if it's associated with a workflow. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the UpdateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request couldn't be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateSchemaMapping">REST API Reference for UpdateSchemaMapping Operation</seealso>
        UpdateSchemaMappingResponse UpdateSchemaMapping(UpdateSchemaMappingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchemaMapping operation on AmazonEntityResolutionClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSchemaMapping
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateSchemaMapping">REST API Reference for UpdateSchemaMapping Operation</seealso>
        IAsyncResult BeginUpdateSchemaMapping(UpdateSchemaMappingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchemaMapping operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchemaMapping.</param>
        /// 
        /// <returns>Returns a  UpdateSchemaMappingResult from EntityResolution.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/entityresolution-2018-05-10/UpdateSchemaMapping">REST API Reference for UpdateSchemaMapping Operation</seealso>
        UpdateSchemaMappingResponse EndUpdateSchemaMapping(IAsyncResult asyncResult);

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