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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockAgentCore.Model;

#pragma warning disable CS1570
namespace Amazon.BedrockAgentCore
{
    /// <summary>
    /// <para>Interface for accessing BedrockAgentCore</para>
    ///
    /// <note> 
    /// <para>
    /// Amazon Bedrock AgentCore is in preview release and is subject to change.
    /// 
    ///  </note> 
    /// <para>
    /// Welcome to the Amazon Bedrock AgentCore Data Plane API reference. Data Plane actions
    /// process and handle data or workloads within Amazon Web Services services. 
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial interface IAmazonBedrockAgentCore : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBedrockAgentCorePaginatorFactory Paginators { get; }
#endif


        
        #region  BatchCreateMemoryRecords


        /// <summary>
        /// Creates multiple memory records in a single batch operation for the specified memory
        /// with custom content.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateMemoryRecords service method.</param>
        /// 
        /// <returns>The response from the BatchCreateMemoryRecords service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/BatchCreateMemoryRecords">REST API Reference for BatchCreateMemoryRecords Operation</seealso>
        BatchCreateMemoryRecordsResponse BatchCreateMemoryRecords(BatchCreateMemoryRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchCreateMemoryRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchCreateMemoryRecords operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchCreateMemoryRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/BatchCreateMemoryRecords">REST API Reference for BatchCreateMemoryRecords Operation</seealso>
        IAsyncResult BeginBatchCreateMemoryRecords(BatchCreateMemoryRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchCreateMemoryRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchCreateMemoryRecords.</param>
        /// 
        /// <returns>Returns a  BatchCreateMemoryRecordsResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/BatchCreateMemoryRecords">REST API Reference for BatchCreateMemoryRecords Operation</seealso>
        BatchCreateMemoryRecordsResponse EndBatchCreateMemoryRecords(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDeleteMemoryRecords


        /// <summary>
        /// Deletes multiple memory records in a single batch operation from the specified memory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteMemoryRecords service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteMemoryRecords service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/BatchDeleteMemoryRecords">REST API Reference for BatchDeleteMemoryRecords Operation</seealso>
        BatchDeleteMemoryRecordsResponse BatchDeleteMemoryRecords(BatchDeleteMemoryRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDeleteMemoryRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteMemoryRecords operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDeleteMemoryRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/BatchDeleteMemoryRecords">REST API Reference for BatchDeleteMemoryRecords Operation</seealso>
        IAsyncResult BeginBatchDeleteMemoryRecords(BatchDeleteMemoryRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDeleteMemoryRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDeleteMemoryRecords.</param>
        /// 
        /// <returns>Returns a  BatchDeleteMemoryRecordsResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/BatchDeleteMemoryRecords">REST API Reference for BatchDeleteMemoryRecords Operation</seealso>
        BatchDeleteMemoryRecordsResponse EndBatchDeleteMemoryRecords(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateMemoryRecords


        /// <summary>
        /// Updates multiple memory records with custom content in a single batch operation within
        /// the specified memory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateMemoryRecords service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateMemoryRecords service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/BatchUpdateMemoryRecords">REST API Reference for BatchUpdateMemoryRecords Operation</seealso>
        BatchUpdateMemoryRecordsResponse BatchUpdateMemoryRecords(BatchUpdateMemoryRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateMemoryRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateMemoryRecords operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateMemoryRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/BatchUpdateMemoryRecords">REST API Reference for BatchUpdateMemoryRecords Operation</seealso>
        IAsyncResult BeginBatchUpdateMemoryRecords(BatchUpdateMemoryRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateMemoryRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateMemoryRecords.</param>
        /// 
        /// <returns>Returns a  BatchUpdateMemoryRecordsResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/BatchUpdateMemoryRecords">REST API Reference for BatchUpdateMemoryRecords Operation</seealso>
        BatchUpdateMemoryRecordsResponse EndBatchUpdateMemoryRecords(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEvent


        /// <summary>
        /// Creates an event in an AgentCore Memory resource. Events represent interactions or
        /// activities that occur within a session and are associated with specific actors.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:CreateEvent</c> permission.
        /// </para>
        ///  
        /// <para>
        /// This operation is subject to request rate limiting.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEvent service method.</param>
        /// 
        /// <returns>The response from the CreateEvent service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/CreateEvent">REST API Reference for CreateEvent Operation</seealso>
        CreateEventResponse CreateEvent(CreateEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEvent operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/CreateEvent">REST API Reference for CreateEvent Operation</seealso>
        IAsyncResult BeginCreateEvent(CreateEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEvent.</param>
        /// 
        /// <returns>Returns a  CreateEventResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/CreateEvent">REST API Reference for CreateEvent Operation</seealso>
        CreateEventResponse EndCreateEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEvent


        /// <summary>
        /// Deletes an event from an AgentCore Memory resource. When you delete an event, it is
        /// permanently removed.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:DeleteEvent</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent service method.</param>
        /// 
        /// <returns>The response from the DeleteEvent service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        DeleteEventResponse DeleteEvent(DeleteEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvent operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        IAsyncResult BeginDeleteEvent(DeleteEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEvent.</param>
        /// 
        /// <returns>Returns a  DeleteEventResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/DeleteEvent">REST API Reference for DeleteEvent Operation</seealso>
        DeleteEventResponse EndDeleteEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMemoryRecord


        /// <summary>
        /// Deletes a memory record from an AgentCore Memory resource. When you delete a memory
        /// record, it is permanently removed.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:DeleteMemoryRecord</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemoryRecord service method.</param>
        /// 
        /// <returns>The response from the DeleteMemoryRecord service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/DeleteMemoryRecord">REST API Reference for DeleteMemoryRecord Operation</seealso>
        DeleteMemoryRecordResponse DeleteMemoryRecord(DeleteMemoryRecordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMemoryRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMemoryRecord operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMemoryRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/DeleteMemoryRecord">REST API Reference for DeleteMemoryRecord Operation</seealso>
        IAsyncResult BeginDeleteMemoryRecord(DeleteMemoryRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMemoryRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMemoryRecord.</param>
        /// 
        /// <returns>Returns a  DeleteMemoryRecordResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/DeleteMemoryRecord">REST API Reference for DeleteMemoryRecord Operation</seealso>
        DeleteMemoryRecordResponse EndDeleteMemoryRecord(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAgentCard


        /// <summary>
        /// Retrieves the A2A agent card associated with an AgentCore Runtime agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAgentCard service method.</param>
        /// 
        /// <returns>The response from the GetAgentCard service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.RuntimeClientErrorException">
        /// The exception that occurs when there is an error in the runtime client. This can happen
        /// due to network issues, invalid configuration, or other client-side problems. Check
        /// the error message for specific details about the error.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetAgentCard">REST API Reference for GetAgentCard Operation</seealso>
        GetAgentCardResponse GetAgentCard(GetAgentCardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAgentCard operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAgentCard operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAgentCard
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetAgentCard">REST API Reference for GetAgentCard Operation</seealso>
        IAsyncResult BeginGetAgentCard(GetAgentCardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAgentCard operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAgentCard.</param>
        /// 
        /// <returns>Returns a  GetAgentCardResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetAgentCard">REST API Reference for GetAgentCard Operation</seealso>
        GetAgentCardResponse EndGetAgentCard(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBrowserSession


        /// <summary>
        /// Retrieves detailed information about a specific browser session in Amazon Bedrock.
        /// This operation returns the session's configuration, current status, associated streams,
        /// and metadata.
        /// 
        ///  
        /// <para>
        /// To get a browser session, you must specify both the browser identifier and the session
        /// ID. The response includes information about the session's viewport configuration,
        /// timeout settings, and stream endpoints.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>GetBrowserSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartBrowserSession.html">StartBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_ListBrowserSessions.html">ListBrowserSessions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopBrowserSession.html">StopBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSession service method.</param>
        /// 
        /// <returns>The response from the GetBrowserSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetBrowserSession">REST API Reference for GetBrowserSession Operation</seealso>
        GetBrowserSessionResponse GetBrowserSession(GetBrowserSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBrowserSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBrowserSession operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBrowserSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetBrowserSession">REST API Reference for GetBrowserSession Operation</seealso>
        IAsyncResult BeginGetBrowserSession(GetBrowserSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBrowserSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBrowserSession.</param>
        /// 
        /// <returns>Returns a  GetBrowserSessionResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetBrowserSession">REST API Reference for GetBrowserSession Operation</seealso>
        GetBrowserSessionResponse EndGetBrowserSession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCodeInterpreterSession


        /// <summary>
        /// Retrieves detailed information about a specific code interpreter session in Amazon
        /// Bedrock. This operation returns the session's configuration, current status, and metadata.
        /// 
        ///  
        /// <para>
        /// To get a code interpreter session, you must specify both the code interpreter identifier
        /// and the session ID. The response includes information about the session's timeout
        /// settings and current status.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>GetCodeInterpreterSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_ListCodeInterpreterSessions.html">ListCodeInterpreterSessions</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopCodeInterpreterSession.html">StopCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCodeInterpreterSession service method.</param>
        /// 
        /// <returns>The response from the GetCodeInterpreterSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetCodeInterpreterSession">REST API Reference for GetCodeInterpreterSession Operation</seealso>
        GetCodeInterpreterSessionResponse GetCodeInterpreterSession(GetCodeInterpreterSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCodeInterpreterSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCodeInterpreterSession operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCodeInterpreterSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetCodeInterpreterSession">REST API Reference for GetCodeInterpreterSession Operation</seealso>
        IAsyncResult BeginGetCodeInterpreterSession(GetCodeInterpreterSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCodeInterpreterSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCodeInterpreterSession.</param>
        /// 
        /// <returns>Returns a  GetCodeInterpreterSessionResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetCodeInterpreterSession">REST API Reference for GetCodeInterpreterSession Operation</seealso>
        GetCodeInterpreterSessionResponse EndGetCodeInterpreterSession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEvent


        /// <summary>
        /// Retrieves information about a specific event in an AgentCore Memory resource.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:GetEvent</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEvent service method.</param>
        /// 
        /// <returns>The response from the GetEvent service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetEvent">REST API Reference for GetEvent Operation</seealso>
        GetEventResponse GetEvent(GetEventRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEvent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEvent operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEvent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetEvent">REST API Reference for GetEvent Operation</seealso>
        IAsyncResult BeginGetEvent(GetEventRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEvent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEvent.</param>
        /// 
        /// <returns>Returns a  GetEventResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetEvent">REST API Reference for GetEvent Operation</seealso>
        GetEventResponse EndGetEvent(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMemoryRecord


        /// <summary>
        /// Retrieves a specific memory record from an AgentCore Memory resource.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:GetMemoryRecord</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMemoryRecord service method.</param>
        /// 
        /// <returns>The response from the GetMemoryRecord service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetMemoryRecord">REST API Reference for GetMemoryRecord Operation</seealso>
        GetMemoryRecordResponse GetMemoryRecord(GetMemoryRecordRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMemoryRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMemoryRecord operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMemoryRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetMemoryRecord">REST API Reference for GetMemoryRecord Operation</seealso>
        IAsyncResult BeginGetMemoryRecord(GetMemoryRecordRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMemoryRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMemoryRecord.</param>
        /// 
        /// <returns>Returns a  GetMemoryRecordResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetMemoryRecord">REST API Reference for GetMemoryRecord Operation</seealso>
        GetMemoryRecordResponse EndGetMemoryRecord(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceApiKey


        /// <summary>
        /// Retrieves the API key associated with an API key credential provider.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceApiKey service method.</param>
        /// 
        /// <returns>The response from the GetResourceApiKey service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetResourceApiKey">REST API Reference for GetResourceApiKey Operation</seealso>
        GetResourceApiKeyResponse GetResourceApiKey(GetResourceApiKeyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceApiKey operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceApiKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetResourceApiKey">REST API Reference for GetResourceApiKey Operation</seealso>
        IAsyncResult BeginGetResourceApiKey(GetResourceApiKeyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceApiKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceApiKey.</param>
        /// 
        /// <returns>Returns a  GetResourceApiKeyResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetResourceApiKey">REST API Reference for GetResourceApiKey Operation</seealso>
        GetResourceApiKeyResponse EndGetResourceApiKey(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceOauth2Token


        /// <summary>
        /// Returns the OAuth 2.0 token of the provided resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceOauth2Token service method.</param>
        /// 
        /// <returns>The response from the GetResourceOauth2Token service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetResourceOauth2Token">REST API Reference for GetResourceOauth2Token Operation</seealso>
        GetResourceOauth2TokenResponse GetResourceOauth2Token(GetResourceOauth2TokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceOauth2Token operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceOauth2Token operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceOauth2Token
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetResourceOauth2Token">REST API Reference for GetResourceOauth2Token Operation</seealso>
        IAsyncResult BeginGetResourceOauth2Token(GetResourceOauth2TokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceOauth2Token operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceOauth2Token.</param>
        /// 
        /// <returns>Returns a  GetResourceOauth2TokenResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetResourceOauth2Token">REST API Reference for GetResourceOauth2Token Operation</seealso>
        GetResourceOauth2TokenResponse EndGetResourceOauth2Token(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkloadAccessToken


        /// <summary>
        /// Obtains a workload access token for agentic workloads not acting on behalf of a user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessToken service method.</param>
        /// 
        /// <returns>The response from the GetWorkloadAccessToken service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessToken">REST API Reference for GetWorkloadAccessToken Operation</seealso>
        GetWorkloadAccessTokenResponse GetWorkloadAccessToken(GetWorkloadAccessTokenRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkloadAccessToken operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessToken operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkloadAccessToken
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessToken">REST API Reference for GetWorkloadAccessToken Operation</seealso>
        IAsyncResult BeginGetWorkloadAccessToken(GetWorkloadAccessTokenRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkloadAccessToken operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkloadAccessToken.</param>
        /// 
        /// <returns>Returns a  GetWorkloadAccessTokenResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessToken">REST API Reference for GetWorkloadAccessToken Operation</seealso>
        GetWorkloadAccessTokenResponse EndGetWorkloadAccessToken(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkloadAccessTokenForJWT


        /// <summary>
        /// Obtains a workload access token for agentic workloads acting on behalf of a user,
        /// using a JWT token.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessTokenForJWT service method.</param>
        /// 
        /// <returns>The response from the GetWorkloadAccessTokenForJWT service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessTokenForJWT">REST API Reference for GetWorkloadAccessTokenForJWT Operation</seealso>
        GetWorkloadAccessTokenForJWTResponse GetWorkloadAccessTokenForJWT(GetWorkloadAccessTokenForJWTRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkloadAccessTokenForJWT operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessTokenForJWT operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkloadAccessTokenForJWT
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessTokenForJWT">REST API Reference for GetWorkloadAccessTokenForJWT Operation</seealso>
        IAsyncResult BeginGetWorkloadAccessTokenForJWT(GetWorkloadAccessTokenForJWTRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkloadAccessTokenForJWT operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkloadAccessTokenForJWT.</param>
        /// 
        /// <returns>Returns a  GetWorkloadAccessTokenForJWTResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessTokenForJWT">REST API Reference for GetWorkloadAccessTokenForJWT Operation</seealso>
        GetWorkloadAccessTokenForJWTResponse EndGetWorkloadAccessTokenForJWT(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorkloadAccessTokenForUserId


        /// <summary>
        /// Obtains a workload access token for agentic workloads acting on behalf of a user,
        /// using the user's ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessTokenForUserId service method.</param>
        /// 
        /// <returns>The response from the GetWorkloadAccessTokenForUserId service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessTokenForUserId">REST API Reference for GetWorkloadAccessTokenForUserId Operation</seealso>
        GetWorkloadAccessTokenForUserIdResponse GetWorkloadAccessTokenForUserId(GetWorkloadAccessTokenForUserIdRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorkloadAccessTokenForUserId operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorkloadAccessTokenForUserId operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorkloadAccessTokenForUserId
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessTokenForUserId">REST API Reference for GetWorkloadAccessTokenForUserId Operation</seealso>
        IAsyncResult BeginGetWorkloadAccessTokenForUserId(GetWorkloadAccessTokenForUserIdRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorkloadAccessTokenForUserId operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorkloadAccessTokenForUserId.</param>
        /// 
        /// <returns>Returns a  GetWorkloadAccessTokenForUserIdResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/GetWorkloadAccessTokenForUserId">REST API Reference for GetWorkloadAccessTokenForUserId Operation</seealso>
        GetWorkloadAccessTokenForUserIdResponse EndGetWorkloadAccessTokenForUserId(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeAgentRuntime


        /// <summary>
        /// Sends a request to an agent or tool hosted in an Amazon Bedrock AgentCore Runtime
        /// and receives responses in real-time. 
        /// 
        ///  
        /// <para>
        /// To invoke an agent you must specify the AgentCore Runtime ARN and provide a payload
        /// containing your request. You can optionally specify a qualifier to target a specific
        /// version or endpoint of the agent.
        /// </para>
        ///  
        /// <para>
        /// This operation supports streaming responses, allowing you to receive partial responses
        /// as they become available. We recommend using pagination to ensure that the operation
        /// returns quickly and successfully when processing large responses.
        /// </para>
        ///  
        /// <para>
        /// For example code, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-invoke-agent.html">Invoke
        /// an AgentCore Runtime agent</a>. 
        /// </para>
        ///  
        /// <para>
        /// If you're integrating your agent with OAuth, you can't use the Amazon Web Services
        /// SDK to call <c>InvokeAgentRuntime</c>. Instead, make a HTTPS request to <c>InvokeAgentRuntime</c>.
        /// For an example, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/runtime-oauth.html">Authenticate
        /// and authorize with Inbound Auth and Outbound Auth</a>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:InvokeAgentRuntime</c>
        /// permission. If you are making a call to <c>InvokeAgentRuntime</c> on behalf of a user
        /// ID with the <c>X-Amzn-Bedrock-AgentCore-Runtime-User-Id</c> header, You require permissions
        /// to both actions (<c>bedrock-agentcore:InvokeAgentRuntime</c> and <c>bedrock-agentcore:InvokeAgentRuntimeForUser</c>).
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeAgentRuntime service method.</param>
        /// 
        /// <returns>The response from the InvokeAgentRuntime service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.RuntimeClientErrorException">
        /// The exception that occurs when there is an error in the runtime client. This can happen
        /// due to network issues, invalid configuration, or other client-side problems. Check
        /// the error message for specific details about the error.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/InvokeAgentRuntime">REST API Reference for InvokeAgentRuntime Operation</seealso>
        InvokeAgentRuntimeResponse InvokeAgentRuntime(InvokeAgentRuntimeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeAgentRuntime operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeAgentRuntime
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/InvokeAgentRuntime">REST API Reference for InvokeAgentRuntime Operation</seealso>
        IAsyncResult BeginInvokeAgentRuntime(InvokeAgentRuntimeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeAgentRuntime operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeAgentRuntime.</param>
        /// 
        /// <returns>Returns a  InvokeAgentRuntimeResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/InvokeAgentRuntime">REST API Reference for InvokeAgentRuntime Operation</seealso>
        InvokeAgentRuntimeResponse EndInvokeAgentRuntime(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeCodeInterpreter


        /// <summary>
        /// Executes code within an active code interpreter session in Amazon Bedrock. This operation
        /// processes the provided code, runs it in a secure environment, and returns the execution
        /// results including output, errors, and generated visualizations.
        /// 
        ///  
        /// <para>
        /// To execute code, you must specify the code interpreter identifier, session ID, and
        /// the code to run in the arguments parameter. The operation returns a stream containing
        /// the execution results, which can include text output, error messages, and data visualizations.
        /// </para>
        ///  
        /// <para>
        /// This operation is subject to request rate limiting based on your account's service
        /// quotas.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>InvokeCodeInterpreter</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeCodeInterpreter service method.</param>
        /// 
        /// <returns>The response from the InvokeCodeInterpreter service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/InvokeCodeInterpreter">REST API Reference for InvokeCodeInterpreter Operation</seealso>
        InvokeCodeInterpreterResponse InvokeCodeInterpreter(InvokeCodeInterpreterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeCodeInterpreter operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeCodeInterpreter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/InvokeCodeInterpreter">REST API Reference for InvokeCodeInterpreter Operation</seealso>
        IAsyncResult BeginInvokeCodeInterpreter(InvokeCodeInterpreterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeCodeInterpreter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeCodeInterpreter.</param>
        /// 
        /// <returns>Returns a  InvokeCodeInterpreterResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/InvokeCodeInterpreter">REST API Reference for InvokeCodeInterpreter Operation</seealso>
        InvokeCodeInterpreterResponse EndInvokeCodeInterpreter(IAsyncResult asyncResult);

        #endregion
        
        #region  ListActors


        /// <summary>
        /// Lists all actors in an AgentCore Memory resource. We recommend using pagination to
        /// ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListActors</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActors service method.</param>
        /// 
        /// <returns>The response from the ListActors service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListActors">REST API Reference for ListActors Operation</seealso>
        ListActorsResponse ListActors(ListActorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListActors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActors operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListActors">REST API Reference for ListActors Operation</seealso>
        IAsyncResult BeginListActors(ListActorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListActors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActors.</param>
        /// 
        /// <returns>Returns a  ListActorsResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListActors">REST API Reference for ListActors Operation</seealso>
        ListActorsResponse EndListActors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBrowserSessions


        /// <summary>
        /// Retrieves a list of browser sessions in Amazon Bedrock that match the specified criteria.
        /// This operation returns summary information about each session, including identifiers,
        /// status, and timestamps.
        /// 
        ///  
        /// <para>
        /// You can filter the results by browser identifier and session status. The operation
        /// supports pagination to handle large result sets efficiently.
        /// </para>
        ///  
        /// <para>
        /// We recommend using pagination to ensure that the operation returns quickly and successfully
        /// when retrieving large numbers of sessions.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>ListBrowserSessions</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartBrowserSession.html">StartBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetBrowserSession.html">GetBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSessions service method.</param>
        /// 
        /// <returns>The response from the ListBrowserSessions service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListBrowserSessions">REST API Reference for ListBrowserSessions Operation</seealso>
        ListBrowserSessionsResponse ListBrowserSessions(ListBrowserSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBrowserSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBrowserSessions operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBrowserSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListBrowserSessions">REST API Reference for ListBrowserSessions Operation</seealso>
        IAsyncResult BeginListBrowserSessions(ListBrowserSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBrowserSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBrowserSessions.</param>
        /// 
        /// <returns>Returns a  ListBrowserSessionsResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListBrowserSessions">REST API Reference for ListBrowserSessions Operation</seealso>
        ListBrowserSessionsResponse EndListBrowserSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCodeInterpreterSessions


        /// <summary>
        /// Retrieves a list of code interpreter sessions in Amazon Bedrock that match the specified
        /// criteria. This operation returns summary information about each session, including
        /// identifiers, status, and timestamps.
        /// 
        ///  
        /// <para>
        /// You can filter the results by code interpreter identifier and session status. The
        /// operation supports pagination to handle large result sets efficiently.
        /// </para>
        ///  
        /// <para>
        /// We recommend using pagination to ensure that the operation returns quickly and successfully
        /// when retrieving large numbers of sessions.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>ListCodeInterpreterSessions</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeInterpreterSessions service method.</param>
        /// 
        /// <returns>The response from the ListCodeInterpreterSessions service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListCodeInterpreterSessions">REST API Reference for ListCodeInterpreterSessions Operation</seealso>
        ListCodeInterpreterSessionsResponse ListCodeInterpreterSessions(ListCodeInterpreterSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeInterpreterSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeInterpreterSessions operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeInterpreterSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListCodeInterpreterSessions">REST API Reference for ListCodeInterpreterSessions Operation</seealso>
        IAsyncResult BeginListCodeInterpreterSessions(ListCodeInterpreterSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeInterpreterSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeInterpreterSessions.</param>
        /// 
        /// <returns>Returns a  ListCodeInterpreterSessionsResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListCodeInterpreterSessions">REST API Reference for ListCodeInterpreterSessions Operation</seealso>
        ListCodeInterpreterSessionsResponse EndListCodeInterpreterSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEvents


        /// <summary>
        /// Lists events in an AgentCore Memory resource based on specified criteria. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListEvents</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEvents service method.</param>
        /// 
        /// <returns>The response from the ListEvents service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListEvents">REST API Reference for ListEvents Operation</seealso>
        ListEventsResponse ListEvents(ListEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEvents operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListEvents">REST API Reference for ListEvents Operation</seealso>
        IAsyncResult BeginListEvents(ListEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEvents.</param>
        /// 
        /// <returns>Returns a  ListEventsResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListEvents">REST API Reference for ListEvents Operation</seealso>
        ListEventsResponse EndListEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMemoryRecords


        /// <summary>
        /// Lists memory records in an AgentCore Memory resource based on specified criteria.
        /// We recommend using pagination to ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListMemoryRecords</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMemoryRecords service method.</param>
        /// 
        /// <returns>The response from the ListMemoryRecords service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListMemoryRecords">REST API Reference for ListMemoryRecords Operation</seealso>
        ListMemoryRecordsResponse ListMemoryRecords(ListMemoryRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMemoryRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMemoryRecords operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMemoryRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListMemoryRecords">REST API Reference for ListMemoryRecords Operation</seealso>
        IAsyncResult BeginListMemoryRecords(ListMemoryRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMemoryRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMemoryRecords.</param>
        /// 
        /// <returns>Returns a  ListMemoryRecordsResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListMemoryRecords">REST API Reference for ListMemoryRecords Operation</seealso>
        ListMemoryRecordsResponse EndListMemoryRecords(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSessions


        /// <summary>
        /// Lists sessions in an AgentCore Memory resource based on specified criteria. We recommend
        /// using pagination to ensure that the operation returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:ListSessions</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListSessions">REST API Reference for ListSessions Operation</seealso>
        ListSessionsResponse ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListSessions">REST API Reference for ListSessions Operation</seealso>
        IAsyncResult BeginListSessions(ListSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessions.</param>
        /// 
        /// <returns>Returns a  ListSessionsResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/ListSessions">REST API Reference for ListSessions Operation</seealso>
        ListSessionsResponse EndListSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  RetrieveMemoryRecords


        /// <summary>
        /// Searches for and retrieves memory records from an AgentCore Memory resource based
        /// on specified search criteria. We recommend using pagination to ensure that the operation
        /// returns quickly and successfully.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have the <c>bedrock-agentcore:RetrieveMemoryRecords</c>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RetrieveMemoryRecords service method.</param>
        /// 
        /// <returns>The response from the RetrieveMemoryRecords service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InvalidInputException">
        /// The input fails to satisfy the constraints specified by AgentCore. Check your input
        /// values and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceException">
        /// The service encountered an internal error. Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottledException">
        /// The request was denied due to request throttling. Reduce the frequency of requests
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/RetrieveMemoryRecords">REST API Reference for RetrieveMemoryRecords Operation</seealso>
        RetrieveMemoryRecordsResponse RetrieveMemoryRecords(RetrieveMemoryRecordsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveMemoryRecords operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveMemoryRecords operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRetrieveMemoryRecords
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/RetrieveMemoryRecords">REST API Reference for RetrieveMemoryRecords Operation</seealso>
        IAsyncResult BeginRetrieveMemoryRecords(RetrieveMemoryRecordsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RetrieveMemoryRecords operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRetrieveMemoryRecords.</param>
        /// 
        /// <returns>Returns a  RetrieveMemoryRecordsResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/RetrieveMemoryRecords">REST API Reference for RetrieveMemoryRecords Operation</seealso>
        RetrieveMemoryRecordsResponse EndRetrieveMemoryRecords(IAsyncResult asyncResult);

        #endregion
        
        #region  StartBrowserSession


        /// <summary>
        /// Creates and initializes a browser session in Amazon Bedrock. The session enables agents
        /// to navigate and interact with web content, extract information from websites, and
        /// perform web-based tasks as part of their response generation.
        /// 
        ///  
        /// <para>
        /// To create a session, you must specify a browser identifier and a name. You can also
        /// configure the viewport dimensions to control the visible area of web content. The
        /// session remains active until it times out or you explicitly stop it using the <c>StopBrowserSession</c>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StartBrowserSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetBrowserSession.html">GetBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_UpdateBrowserStream.html">UpdateBrowserStream</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopBrowserSession.html">StopBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBrowserSession service method.</param>
        /// 
        /// <returns>The response from the StartBrowserSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StartBrowserSession">REST API Reference for StartBrowserSession Operation</seealso>
        StartBrowserSessionResponse StartBrowserSession(StartBrowserSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartBrowserSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBrowserSession operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBrowserSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StartBrowserSession">REST API Reference for StartBrowserSession Operation</seealso>
        IAsyncResult BeginStartBrowserSession(StartBrowserSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartBrowserSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBrowserSession.</param>
        /// 
        /// <returns>Returns a  StartBrowserSessionResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StartBrowserSession">REST API Reference for StartBrowserSession Operation</seealso>
        StartBrowserSessionResponse EndStartBrowserSession(IAsyncResult asyncResult);

        #endregion
        
        #region  StartCodeInterpreterSession


        /// <summary>
        /// Creates and initializes a code interpreter session in Amazon Bedrock. The session
        /// enables agents to execute code as part of their response generation, supporting programming
        /// languages such as Python for data analysis, visualization, and computation tasks.
        /// 
        ///  
        /// <para>
        /// To create a session, you must specify a code interpreter identifier and a name. The
        /// session remains active until it times out or you explicitly stop it using the <c>StopCodeInterpreterSession</c>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StartCodeInterpreterSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_InvokeCodeInterpreter.html">InvokeCodeInterpreter</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StopCodeInterpreterSession.html">StopCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartCodeInterpreterSession service method.</param>
        /// 
        /// <returns>The response from the StartCodeInterpreterSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StartCodeInterpreterSession">REST API Reference for StartCodeInterpreterSession Operation</seealso>
        StartCodeInterpreterSessionResponse StartCodeInterpreterSession(StartCodeInterpreterSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartCodeInterpreterSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartCodeInterpreterSession operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartCodeInterpreterSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StartCodeInterpreterSession">REST API Reference for StartCodeInterpreterSession Operation</seealso>
        IAsyncResult BeginStartCodeInterpreterSession(StartCodeInterpreterSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartCodeInterpreterSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartCodeInterpreterSession.</param>
        /// 
        /// <returns>Returns a  StartCodeInterpreterSessionResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StartCodeInterpreterSession">REST API Reference for StartCodeInterpreterSession Operation</seealso>
        StartCodeInterpreterSessionResponse EndStartCodeInterpreterSession(IAsyncResult asyncResult);

        #endregion
        
        #region  StopBrowserSession


        /// <summary>
        /// Terminates an active browser session in Amazon Bedrock. This operation stops the session,
        /// releases associated resources, and makes the session unavailable for further use.
        /// 
        ///  
        /// <para>
        /// To stop a browser session, you must specify both the browser identifier and the session
        /// ID. Once stopped, a session cannot be restarted; you must create a new session using
        /// <c>StartBrowserSession</c>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StopBrowserSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartBrowserSession.html">StartBrowserSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetBrowserSession.html">GetBrowserSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBrowserSession service method.</param>
        /// 
        /// <returns>The response from the StopBrowserSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopBrowserSession">REST API Reference for StopBrowserSession Operation</seealso>
        StopBrowserSessionResponse StopBrowserSession(StopBrowserSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopBrowserSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopBrowserSession operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopBrowserSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopBrowserSession">REST API Reference for StopBrowserSession Operation</seealso>
        IAsyncResult BeginStopBrowserSession(StopBrowserSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopBrowserSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopBrowserSession.</param>
        /// 
        /// <returns>Returns a  StopBrowserSessionResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopBrowserSession">REST API Reference for StopBrowserSession Operation</seealso>
        StopBrowserSessionResponse EndStopBrowserSession(IAsyncResult asyncResult);

        #endregion
        
        #region  StopCodeInterpreterSession


        /// <summary>
        /// Terminates an active code interpreter session in Amazon Bedrock. This operation stops
        /// the session, releases associated resources, and makes the session unavailable for
        /// further use.
        /// 
        ///  
        /// <para>
        /// To stop a code interpreter session, you must specify both the code interpreter identifier
        /// and the session ID. Once stopped, a session cannot be restarted; you must create a
        /// new session using <c>StartCodeInterpreterSession</c>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <c>StopCodeInterpreterSession</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_StartCodeInterpreterSession.html">StartCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/API_GetCodeInterpreterSession.html">GetCodeInterpreterSession</a>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCodeInterpreterSession service method.</param>
        /// 
        /// <returns>The response from the StopCodeInterpreterSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopCodeInterpreterSession">REST API Reference for StopCodeInterpreterSession Operation</seealso>
        StopCodeInterpreterSessionResponse StopCodeInterpreterSession(StopCodeInterpreterSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopCodeInterpreterSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCodeInterpreterSession operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCodeInterpreterSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopCodeInterpreterSession">REST API Reference for StopCodeInterpreterSession Operation</seealso>
        IAsyncResult BeginStopCodeInterpreterSession(StopCodeInterpreterSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopCodeInterpreterSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCodeInterpreterSession.</param>
        /// 
        /// <returns>Returns a  StopCodeInterpreterSessionResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopCodeInterpreterSession">REST API Reference for StopCodeInterpreterSession Operation</seealso>
        StopCodeInterpreterSessionResponse EndStopCodeInterpreterSession(IAsyncResult asyncResult);

        #endregion
        
        #region  StopRuntimeSession


        /// <summary>
        /// Stops a session that is running in an running AgentCore Runtime agent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopRuntimeSession service method.</param>
        /// 
        /// <returns>The response from the StopRuntimeSession service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.RuntimeClientErrorException">
        /// The exception that occurs when there is an error in the runtime client. This can happen
        /// due to network issues, invalid configuration, or other client-side problems. Check
        /// the error message for specific details about the error.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.UnauthorizedException">
        /// This exception is thrown when the JWT bearer token is invalid or not found for OAuth
        /// bearer token based access
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopRuntimeSession">REST API Reference for StopRuntimeSession Operation</seealso>
        StopRuntimeSessionResponse StopRuntimeSession(StopRuntimeSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopRuntimeSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopRuntimeSession operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopRuntimeSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopRuntimeSession">REST API Reference for StopRuntimeSession Operation</seealso>
        IAsyncResult BeginStopRuntimeSession(StopRuntimeSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopRuntimeSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopRuntimeSession.</param>
        /// 
        /// <returns>Returns a  StopRuntimeSessionResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/StopRuntimeSession">REST API Reference for StopRuntimeSession Operation</seealso>
        StopRuntimeSessionResponse EndStopRuntimeSession(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBrowserStream


        /// <summary>
        /// Updates a browser stream. To use this operation, you must have permissions to perform
        /// the bedrock:UpdateBrowserStream action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserStream service method.</param>
        /// 
        /// <returns>The response from the UpdateBrowserStream service method, as returned by BedrockAgentCore.</returns>
        /// <exception cref="Amazon.BedrockAgentCore.Model.AccessDeniedException">
        /// The exception that occurs when you do not have sufficient permissions to perform an
        /// action. Verify that your IAM policy includes the necessary permissions for the operation
        /// you are trying to perform.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ConflictException">
        /// The exception that occurs when the request conflicts with the current state of the
        /// resource. This can happen when trying to modify a resource that is currently being
        /// modified by another request, or when trying to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.InternalServerException">
        /// The exception that occurs when the service encounters an unexpected internal error.
        /// This is a temporary condition that will resolve itself with retries. We recommend
        /// implementing exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ResourceNotFoundException">
        /// The exception that occurs when the specified resource does not exist. This can happen
        /// when using an invalid identifier or when trying to access a resource that has been
        /// deleted.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ServiceQuotaExceededException">
        /// The exception that occurs when the request would cause a service quota to be exceeded.
        /// Review your service quotas and either reduce your request rate or request a quota
        /// increase.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ThrottlingException">
        /// The exception that occurs when the request was denied due to request throttling. This
        /// happens when you exceed the allowed request rate for an operation. Reduce the frequency
        /// of requests or implement exponential backoff retry logic in your application.
        /// </exception>
        /// <exception cref="Amazon.BedrockAgentCore.Model.ValidationException">
        /// The exception that occurs when the input fails to satisfy the constraints specified
        /// by the service. Check the error message for details about which input parameter is
        /// invalid and correct your request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/UpdateBrowserStream">REST API Reference for UpdateBrowserStream Operation</seealso>
        UpdateBrowserStreamResponse UpdateBrowserStream(UpdateBrowserStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBrowserStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrowserStream operation on AmazonBedrockAgentCoreClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBrowserStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/UpdateBrowserStream">REST API Reference for UpdateBrowserStream Operation</seealso>
        IAsyncResult BeginUpdateBrowserStream(UpdateBrowserStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBrowserStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBrowserStream.</param>
        /// 
        /// <returns>Returns a  UpdateBrowserStreamResult from BedrockAgentCore.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-agentcore-2024-02-28/UpdateBrowserStream">REST API Reference for UpdateBrowserStream Operation</seealso>
        UpdateBrowserStreamResponse EndUpdateBrowserStream(IAsyncResult asyncResult);

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