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

namespace Amazon.EntityResolution
{
    /// <summary>
    /// Interface for accessing EntityResolution
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


        
        #region  CreateMatchingWorkflow


        /// <summary>
        /// Creates a <code>MatchingWorkflow</code> object which stores the configuration of the
        /// data processing job to be run. It is important to note that there should not be a
        /// pre-existing <code>MatchingWorkflow</code> with the same name. To modify an existing
        /// workflow, utilize the <code>UpdateMatchingWorkflow</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the CreateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// <code>HTTP Status Code: 402</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        /// The <code>SchemaMapping</code> also provides Entity Resolution with some metadata
        /// about the table, such as the attribute types of the columns and which columns to match
        /// on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the CreateSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// <code>HTTP Status Code: 402</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        
        #region  DeleteMatchingWorkflow


        /// <summary>
        /// Deletes the <code>MatchingWorkflow</code> with a given name. This operation will succeed
        /// even if a workflow with the given name does not exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the DeleteMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        
        #region  DeleteSchemaMapping


        /// <summary>
        /// Deletes the <code>SchemaMapping</code> with a given name. This operation will succeed
        /// even if a schema with the given name does not exist. This operation will fail if there
        /// is a <code>DataIntegrationWorkflow</code> object that references the <code>SchemaMapping</code>
        /// in the workflow's <code>InputSourceConfig</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the DeleteSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        
        #region  GetMatchId


        /// <summary>
        /// Returns the corresponding Match ID of a customer record if the record has been processed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchId service method.</param>
        /// 
        /// <returns>The response from the GetMatchId service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        /// Gets the status, metrics, and errors (if there are any) that are associated with a
        /// job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingJob service method.</param>
        /// 
        /// <returns>The response from the GetMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        /// Returns the <code>MatchingWorkflow</code> with a given name, if it exists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the GetMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        
        #region  GetSchemaMapping


        /// <summary>
        /// Returns the SchemaMapping of a given name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchemaMapping service method.</param>
        /// 
        /// <returns>The response from the GetSchemaMapping service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        
        #region  ListMatchingJobs


        /// <summary>
        /// Lists all jobs for a given workflow.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingJobs service method.</param>
        /// 
        /// <returns>The response from the ListMatchingJobs service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        /// Returns a list of all the <code>MatchingWorkflows</code> that have been created for
        /// an Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMatchingWorkflows service method.</param>
        /// 
        /// <returns>The response from the ListMatchingWorkflows service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        
        #region  ListSchemaMappings


        /// <summary>
        /// Returns a list of all the <code>SchemaMappings</code> that have been created for an
        /// Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchemaMappings service method.</param>
        /// 
        /// <returns>The response from the ListSchemaMappings service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        /// <code>SchemaMapping</code>, and <code>MatchingWorkflow</code> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        
        #region  StartMatchingJob


        /// <summary>
        /// Starts the <code>MatchingJob</code> of a workflow. The workflow must have previously
        /// been created using the <code>CreateMatchingWorkflow</code> endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMatchingJob service method.</param>
        /// 
        /// <returns>The response from the StartMatchingJob service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ConflictException">
        /// The request could not be processed because of conflict in the current state of the
        /// resource. Example: Workflow already exists, Schema already exists, Workflow is currently
        /// running, etc. <code>HTTP Status Code: 400</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ExceedsLimitException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// Entity Resolution account limits. The error message describes the limit exceeded.
        /// <code>HTTP Status Code: 402</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        /// with certain tag values. In Entity Resolution, <code>SchemaMapping</code> and <code>MatchingWorkflow</code>
        /// can be tagged. Tags don't have any semantic meaning to Amazon Web Services and are
        /// interpreted strictly as strings of characters. You can use the <code>TagResource</code>
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
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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
        /// Resolution, <code>SchemaMapping</code>, and <code>MatchingWorkflow</code> can be tagged.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
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
        
        #region  UpdateMatchingWorkflow


        /// <summary>
        /// Updates an existing <code>MatchingWorkflow</code>. This method is identical to <code>CreateMatchingWorkflow</code>,
        /// except it uses an HTTP <code>PUT</code> request instead of a <code>POST</code> request,
        /// and the <code>MatchingWorkflow</code> must already exist for the method to succeed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchingWorkflow service method.</param>
        /// 
        /// <returns>The response from the UpdateMatchingWorkflow service method, as returned by EntityResolution.</returns>
        /// <exception cref="Amazon.EntityResolution.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. <code>HTTP Status Code:
        /// 403</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Entity Resolution service.
        /// <code>HTTP Status Code: 500</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ResourceNotFoundException">
        /// The resource could not be found. <code>HTTP Status Code: 404</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ThrottlingException">
        /// The request was denied due to request throttling. <code>HTTP Status Code: 429</code>
        /// </exception>
        /// <exception cref="Amazon.EntityResolution.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by Entity Resolution. <code>HTTP
        /// Status Code: 400</code>
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