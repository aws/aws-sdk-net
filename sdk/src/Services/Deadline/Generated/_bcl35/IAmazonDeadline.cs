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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Deadline.Model;

#pragma warning disable CS1570
namespace Amazon.Deadline
{
    /// <summary>
    /// <para>Interface for accessing Deadline</para>
    ///
    /// The Amazon Web Services Deadline Cloud API provides infrastructure and centralized
    /// management for your projects. Use the Deadline Cloud API to onboard users, assign
    /// projects, and attach permissions specific to their job function.
    /// 
    ///  
    /// <para>
    /// With Deadline Cloud, content production teams can deploy resources for their workforce
    /// securely in the cloud, reducing the costs of added physical infrastructure. Keep your
    /// content production operations secure, while allowing your contributors to access the
    /// tools they need, such as scalable high-speed storage, licenses, and cost management
    /// services.
    /// </para>
    /// </summary>
    public partial interface IAmazonDeadline : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDeadlinePaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateMemberToFarm


        /// <summary>
        /// Assigns a farm membership level to a member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFarm service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFarm">REST API Reference for AssociateMemberToFarm Operation</seealso>
        AssociateMemberToFarmResponse AssociateMemberToFarm(AssociateMemberToFarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberToFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberToFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFarm">REST API Reference for AssociateMemberToFarm Operation</seealso>
        IAsyncResult BeginAssociateMemberToFarm(AssociateMemberToFarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberToFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberToFarm.</param>
        /// 
        /// <returns>Returns a  AssociateMemberToFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFarm">REST API Reference for AssociateMemberToFarm Operation</seealso>
        AssociateMemberToFarmResponse EndAssociateMemberToFarm(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateMemberToFleet


        /// <summary>
        /// Assigns a fleet membership level to a member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFleet service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFleet">REST API Reference for AssociateMemberToFleet Operation</seealso>
        AssociateMemberToFleetResponse AssociateMemberToFleet(AssociateMemberToFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberToFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberToFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFleet">REST API Reference for AssociateMemberToFleet Operation</seealso>
        IAsyncResult BeginAssociateMemberToFleet(AssociateMemberToFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberToFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberToFleet.</param>
        /// 
        /// <returns>Returns a  AssociateMemberToFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToFleet">REST API Reference for AssociateMemberToFleet Operation</seealso>
        AssociateMemberToFleetResponse EndAssociateMemberToFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateMemberToJob


        /// <summary>
        /// Assigns a job membership level to a member
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToJob service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToJob">REST API Reference for AssociateMemberToJob Operation</seealso>
        AssociateMemberToJobResponse AssociateMemberToJob(AssociateMemberToJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberToJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToJob operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberToJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToJob">REST API Reference for AssociateMemberToJob Operation</seealso>
        IAsyncResult BeginAssociateMemberToJob(AssociateMemberToJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberToJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberToJob.</param>
        /// 
        /// <returns>Returns a  AssociateMemberToJobResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToJob">REST API Reference for AssociateMemberToJob Operation</seealso>
        AssociateMemberToJobResponse EndAssociateMemberToJob(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateMemberToQueue


        /// <summary>
        /// Assigns a queue membership level to a member
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToQueue service method.</param>
        /// 
        /// <returns>The response from the AssociateMemberToQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToQueue">REST API Reference for AssociateMemberToQueue Operation</seealso>
        AssociateMemberToQueueResponse AssociateMemberToQueue(AssociateMemberToQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMemberToQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMemberToQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToQueue">REST API Reference for AssociateMemberToQueue Operation</seealso>
        IAsyncResult BeginAssociateMemberToQueue(AssociateMemberToQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMemberToQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMemberToQueue.</param>
        /// 
        /// <returns>Returns a  AssociateMemberToQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssociateMemberToQueue">REST API Reference for AssociateMemberToQueue Operation</seealso>
        AssociateMemberToQueueResponse EndAssociateMemberToQueue(IAsyncResult asyncResult);

        #endregion
        
        #region  AssumeFleetRoleForRead


        /// <summary>
        /// Get Amazon Web Services credentials from the fleet role. The IAM permissions of the
        /// credentials are scoped down to have read-only access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForRead service method.</param>
        /// 
        /// <returns>The response from the AssumeFleetRoleForRead service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForRead">REST API Reference for AssumeFleetRoleForRead Operation</seealso>
        AssumeFleetRoleForReadResponse AssumeFleetRoleForRead(AssumeFleetRoleForReadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeFleetRoleForRead operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForRead operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeFleetRoleForRead
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForRead">REST API Reference for AssumeFleetRoleForRead Operation</seealso>
        IAsyncResult BeginAssumeFleetRoleForRead(AssumeFleetRoleForReadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeFleetRoleForRead operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeFleetRoleForRead.</param>
        /// 
        /// <returns>Returns a  AssumeFleetRoleForReadResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForRead">REST API Reference for AssumeFleetRoleForRead Operation</seealso>
        AssumeFleetRoleForReadResponse EndAssumeFleetRoleForRead(IAsyncResult asyncResult);

        #endregion
        
        #region  AssumeFleetRoleForWorker


        /// <summary>
        /// Get credentials from the fleet role for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForWorker service method.</param>
        /// 
        /// <returns>The response from the AssumeFleetRoleForWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForWorker">REST API Reference for AssumeFleetRoleForWorker Operation</seealso>
        AssumeFleetRoleForWorkerResponse AssumeFleetRoleForWorker(AssumeFleetRoleForWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeFleetRoleForWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeFleetRoleForWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForWorker">REST API Reference for AssumeFleetRoleForWorker Operation</seealso>
        IAsyncResult BeginAssumeFleetRoleForWorker(AssumeFleetRoleForWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeFleetRoleForWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeFleetRoleForWorker.</param>
        /// 
        /// <returns>Returns a  AssumeFleetRoleForWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeFleetRoleForWorker">REST API Reference for AssumeFleetRoleForWorker Operation</seealso>
        AssumeFleetRoleForWorkerResponse EndAssumeFleetRoleForWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  AssumeQueueRoleForRead


        /// <summary>
        /// Gets Amazon Web Services credentials from the queue role. The IAM permissions of the
        /// credentials are scoped down to have read-only access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForRead service method.</param>
        /// 
        /// <returns>The response from the AssumeQueueRoleForRead service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForRead">REST API Reference for AssumeQueueRoleForRead Operation</seealso>
        AssumeQueueRoleForReadResponse AssumeQueueRoleForRead(AssumeQueueRoleForReadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeQueueRoleForRead operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForRead operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeQueueRoleForRead
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForRead">REST API Reference for AssumeQueueRoleForRead Operation</seealso>
        IAsyncResult BeginAssumeQueueRoleForRead(AssumeQueueRoleForReadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeQueueRoleForRead operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeQueueRoleForRead.</param>
        /// 
        /// <returns>Returns a  AssumeQueueRoleForReadResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForRead">REST API Reference for AssumeQueueRoleForRead Operation</seealso>
        AssumeQueueRoleForReadResponse EndAssumeQueueRoleForRead(IAsyncResult asyncResult);

        #endregion
        
        #region  AssumeQueueRoleForUser


        /// <summary>
        /// Allows a user to assume a role for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForUser service method.</param>
        /// 
        /// <returns>The response from the AssumeQueueRoleForUser service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForUser">REST API Reference for AssumeQueueRoleForUser Operation</seealso>
        AssumeQueueRoleForUserResponse AssumeQueueRoleForUser(AssumeQueueRoleForUserRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeQueueRoleForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForUser operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeQueueRoleForUser
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForUser">REST API Reference for AssumeQueueRoleForUser Operation</seealso>
        IAsyncResult BeginAssumeQueueRoleForUser(AssumeQueueRoleForUserRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeQueueRoleForUser operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeQueueRoleForUser.</param>
        /// 
        /// <returns>Returns a  AssumeQueueRoleForUserResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForUser">REST API Reference for AssumeQueueRoleForUser Operation</seealso>
        AssumeQueueRoleForUserResponse EndAssumeQueueRoleForUser(IAsyncResult asyncResult);

        #endregion
        
        #region  AssumeQueueRoleForWorker


        /// <summary>
        /// Allows a worker to assume a queue role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForWorker service method.</param>
        /// 
        /// <returns>The response from the AssumeQueueRoleForWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForWorker">REST API Reference for AssumeQueueRoleForWorker Operation</seealso>
        AssumeQueueRoleForWorkerResponse AssumeQueueRoleForWorker(AssumeQueueRoleForWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssumeQueueRoleForWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssumeQueueRoleForWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForWorker">REST API Reference for AssumeQueueRoleForWorker Operation</seealso>
        IAsyncResult BeginAssumeQueueRoleForWorker(AssumeQueueRoleForWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssumeQueueRoleForWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssumeQueueRoleForWorker.</param>
        /// 
        /// <returns>Returns a  AssumeQueueRoleForWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/AssumeQueueRoleForWorker">REST API Reference for AssumeQueueRoleForWorker Operation</seealso>
        AssumeQueueRoleForWorkerResponse EndAssumeQueueRoleForWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetJobEntity


        /// <summary>
        /// Get batched job details for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetJobEntity service method.</param>
        /// 
        /// <returns>The response from the BatchGetJobEntity service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/BatchGetJobEntity">REST API Reference for BatchGetJobEntity Operation</seealso>
        BatchGetJobEntityResponse BatchGetJobEntity(BatchGetJobEntityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetJobEntity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetJobEntity operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetJobEntity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/BatchGetJobEntity">REST API Reference for BatchGetJobEntity Operation</seealso>
        IAsyncResult BeginBatchGetJobEntity(BatchGetJobEntityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetJobEntity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetJobEntity.</param>
        /// 
        /// <returns>Returns a  BatchGetJobEntityResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/BatchGetJobEntity">REST API Reference for BatchGetJobEntity Operation</seealso>
        BatchGetJobEntityResponse EndBatchGetJobEntity(IAsyncResult asyncResult);

        #endregion
        
        #region  CopyJobTemplate


        /// <summary>
        /// Copies a job template to an Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyJobTemplate service method.</param>
        /// 
        /// <returns>The response from the CopyJobTemplate service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CopyJobTemplate">REST API Reference for CopyJobTemplate Operation</seealso>
        CopyJobTemplateResponse CopyJobTemplate(CopyJobTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyJobTemplate operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CopyJobTemplate">REST API Reference for CopyJobTemplate Operation</seealso>
        IAsyncResult BeginCopyJobTemplate(CopyJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyJobTemplate.</param>
        /// 
        /// <returns>Returns a  CopyJobTemplateResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CopyJobTemplate">REST API Reference for CopyJobTemplate Operation</seealso>
        CopyJobTemplateResponse EndCopyJobTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBudget


        /// <summary>
        /// Creates a budget to set spending thresholds for your rendering activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget service method.</param>
        /// 
        /// <returns>The response from the CreateBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        CreateBudgetResponse CreateBudget(CreateBudgetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        IAsyncResult BeginCreateBudget(CreateBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBudget.</param>
        /// 
        /// <returns>Returns a  CreateBudgetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateBudget">REST API Reference for CreateBudget Operation</seealso>
        CreateBudgetResponse EndCreateBudget(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFarm


        /// <summary>
        /// Creates a farm to allow space for queues and fleets. Farms are the space where the
        /// components of your renders gather and are pieced together in the cloud. Farms contain
        /// budgets and allow you to enforce permissions. Deadline Cloud farms are a useful container
        /// for large projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFarm service method.</param>
        /// 
        /// <returns>The response from the CreateFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFarm">REST API Reference for CreateFarm Operation</seealso>
        CreateFarmResponse CreateFarm(CreateFarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFarm">REST API Reference for CreateFarm Operation</seealso>
        IAsyncResult BeginCreateFarm(CreateFarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFarm.</param>
        /// 
        /// <returns>Returns a  CreateFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFarm">REST API Reference for CreateFarm Operation</seealso>
        CreateFarmResponse EndCreateFarm(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Creates a fleet. Fleets gather information relating to compute, or capacity, for renders
        /// within your farms. You can choose to manage your own capacity or opt to have fleets
        /// fully managed by Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse CreateFleet(CreateFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Creates a job. A job is a set of instructions that AWS Deadline Cloud uses to schedule
        /// and run work on available workers. For more information, see <a href="https://docs.aws.amazon.com/deadline-cloud/latest/userguide/deadline-cloud-jobs.html">Deadline
        /// Cloud jobs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse CreateJob(CreateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateJob">REST API Reference for CreateJob Operation</seealso>
        IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse EndCreateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLicenseEndpoint


        /// <summary>
        /// Creates a license endpoint to integrate your various licensed software used for rendering
        /// on Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseEndpoint service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLicenseEndpoint">REST API Reference for CreateLicenseEndpoint Operation</seealso>
        CreateLicenseEndpointResponse CreateLicenseEndpoint(CreateLicenseEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseEndpoint operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLicenseEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLicenseEndpoint">REST API Reference for CreateLicenseEndpoint Operation</seealso>
        IAsyncResult BeginCreateLicenseEndpoint(CreateLicenseEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLicenseEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateLicenseEndpointResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLicenseEndpoint">REST API Reference for CreateLicenseEndpoint Operation</seealso>
        CreateLicenseEndpointResponse EndCreateLicenseEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMonitor


        /// <summary>
        /// Creates an Amazon Web Services Deadline Cloud monitor that you can use to view your
        /// farms, queues, and fleets. After you submit a job, you can track the progress of the
        /// tasks and steps that make up the job, and then download the job's results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// 
        /// <returns>The response from the CreateMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        CreateMonitorResponse CreateMonitor(CreateMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        IAsyncResult BeginCreateMonitor(CreateMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMonitor.</param>
        /// 
        /// <returns>Returns a  CreateMonitorResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateMonitor">REST API Reference for CreateMonitor Operation</seealso>
        CreateMonitorResponse EndCreateMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateQueue


        /// <summary>
        /// Creates a queue to coordinate the order in which jobs run on a farm. A queue can also
        /// specify where to pull resources and indicate where to output completed jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        CreateQueueResponse CreateQueue(CreateQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        IAsyncResult BeginCreateQueue(CreateQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueue.</param>
        /// 
        /// <returns>Returns a  CreateQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        CreateQueueResponse EndCreateQueue(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateQueueEnvironment


        /// <summary>
        /// Creates an environment for a queue that defines how jobs in the queue run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueEnvironment">REST API Reference for CreateQueueEnvironment Operation</seealso>
        CreateQueueEnvironmentResponse CreateQueueEnvironment(CreateQueueEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueEnvironment operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueueEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueEnvironment">REST API Reference for CreateQueueEnvironment Operation</seealso>
        IAsyncResult BeginCreateQueueEnvironment(CreateQueueEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueueEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateQueueEnvironmentResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueEnvironment">REST API Reference for CreateQueueEnvironment Operation</seealso>
        CreateQueueEnvironmentResponse EndCreateQueueEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateQueueFleetAssociation


        /// <summary>
        /// Creates an association between a queue and a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueFleetAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueFleetAssociation">REST API Reference for CreateQueueFleetAssociation Operation</seealso>
        CreateQueueFleetAssociationResponse CreateQueueFleetAssociation(CreateQueueFleetAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueFleetAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueueFleetAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueFleetAssociation">REST API Reference for CreateQueueFleetAssociation Operation</seealso>
        IAsyncResult BeginCreateQueueFleetAssociation(CreateQueueFleetAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueueFleetAssociation.</param>
        /// 
        /// <returns>Returns a  CreateQueueFleetAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueFleetAssociation">REST API Reference for CreateQueueFleetAssociation Operation</seealso>
        CreateQueueFleetAssociationResponse EndCreateQueueFleetAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStorageProfile


        /// <summary>
        /// Creates a storage profile that specifies the operating system, file type, and file
        /// location of resources used on a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageProfile service method.</param>
        /// 
        /// <returns>The response from the CreateStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateStorageProfile">REST API Reference for CreateStorageProfile Operation</seealso>
        CreateStorageProfileResponse CreateStorageProfile(CreateStorageProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageProfile operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStorageProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateStorageProfile">REST API Reference for CreateStorageProfile Operation</seealso>
        IAsyncResult BeginCreateStorageProfile(CreateStorageProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStorageProfile.</param>
        /// 
        /// <returns>Returns a  CreateStorageProfileResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateStorageProfile">REST API Reference for CreateStorageProfile Operation</seealso>
        CreateStorageProfileResponse EndCreateStorageProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorker


        /// <summary>
        /// Creates a worker. A worker tells your instance how much processing power (vCPU), and
        /// memory (GiB) you’ll need to assemble the digital assets held within a particular instance.
        /// You can specify certain instance types to use, or let the worker know which instances
        /// types to exclude.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker service method.</param>
        /// 
        /// <returns>The response from the CreateWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        CreateWorkerResponse CreateWorker(CreateWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        IAsyncResult BeginCreateWorker(CreateWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorker.</param>
        /// 
        /// <returns>Returns a  CreateWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateWorker">REST API Reference for CreateWorker Operation</seealso>
        CreateWorkerResponse EndCreateWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBudget


        /// <summary>
        /// Deletes a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget service method.</param>
        /// 
        /// <returns>The response from the DeleteBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        DeleteBudgetResponse DeleteBudget(DeleteBudgetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        IAsyncResult BeginDeleteBudget(DeleteBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBudget.</param>
        /// 
        /// <returns>Returns a  DeleteBudgetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteBudget">REST API Reference for DeleteBudget Operation</seealso>
        DeleteBudgetResponse EndDeleteBudget(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFarm


        /// <summary>
        /// Deletes a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFarm service method.</param>
        /// 
        /// <returns>The response from the DeleteFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFarm">REST API Reference for DeleteFarm Operation</seealso>
        DeleteFarmResponse DeleteFarm(DeleteFarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFarm">REST API Reference for DeleteFarm Operation</seealso>
        IAsyncResult BeginDeleteFarm(DeleteFarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFarm.</param>
        /// 
        /// <returns>Returns a  DeleteFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFarm">REST API Reference for DeleteFarm Operation</seealso>
        DeleteFarmResponse EndDeleteFarm(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFleet


        /// <summary>
        /// Deletes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse DeleteFleet(DeleteFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        IAsyncResult BeginDeleteFleet(DeleteFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleet.</param>
        /// 
        /// <returns>Returns a  DeleteFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        DeleteFleetResponse EndDeleteFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLicenseEndpoint


        /// <summary>
        /// Deletes a license endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteLicenseEndpoint service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLicenseEndpoint">REST API Reference for DeleteLicenseEndpoint Operation</seealso>
        DeleteLicenseEndpointResponse DeleteLicenseEndpoint(DeleteLicenseEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseEndpoint operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLicenseEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLicenseEndpoint">REST API Reference for DeleteLicenseEndpoint Operation</seealso>
        IAsyncResult BeginDeleteLicenseEndpoint(DeleteLicenseEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLicenseEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteLicenseEndpointResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLicenseEndpoint">REST API Reference for DeleteLicenseEndpoint Operation</seealso>
        DeleteLicenseEndpointResponse EndDeleteLicenseEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMeteredProduct


        /// <summary>
        /// Deletes a metered product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeteredProduct service method.</param>
        /// 
        /// <returns>The response from the DeleteMeteredProduct service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMeteredProduct">REST API Reference for DeleteMeteredProduct Operation</seealso>
        DeleteMeteredProductResponse DeleteMeteredProduct(DeleteMeteredProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMeteredProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeteredProduct operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMeteredProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMeteredProduct">REST API Reference for DeleteMeteredProduct Operation</seealso>
        IAsyncResult BeginDeleteMeteredProduct(DeleteMeteredProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMeteredProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMeteredProduct.</param>
        /// 
        /// <returns>Returns a  DeleteMeteredProductResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMeteredProduct">REST API Reference for DeleteMeteredProduct Operation</seealso>
        DeleteMeteredProductResponse EndDeleteMeteredProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMonitor


        /// <summary>
        /// Removes a Deadline Cloud monitor. After you delete a monitor, you can create a new
        /// one and attach farms to the monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// 
        /// <returns>The response from the DeleteMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        DeleteMonitorResponse DeleteMonitor(DeleteMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        IAsyncResult BeginDeleteMonitor(DeleteMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMonitor.</param>
        /// 
        /// <returns>Returns a  DeleteMonitorResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteMonitor">REST API Reference for DeleteMonitor Operation</seealso>
        DeleteMonitorResponse EndDeleteMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteQueue


        /// <summary>
        /// Deletes a queue.
        /// 
        ///  <important> 
        /// <para>
        /// You can't recover the jobs in a queue if you delete the queue. Deleting the queue
        /// also deletes the jobs in that queue.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        DeleteQueueResponse DeleteQueue(DeleteQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        IAsyncResult BeginDeleteQueue(DeleteQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueue.</param>
        /// 
        /// <returns>Returns a  DeleteQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        DeleteQueueResponse EndDeleteQueue(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteQueueEnvironment


        /// <summary>
        /// Deletes a queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueEnvironment">REST API Reference for DeleteQueueEnvironment Operation</seealso>
        DeleteQueueEnvironmentResponse DeleteQueueEnvironment(DeleteQueueEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueEnvironment operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueueEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueEnvironment">REST API Reference for DeleteQueueEnvironment Operation</seealso>
        IAsyncResult BeginDeleteQueueEnvironment(DeleteQueueEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueueEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteQueueEnvironmentResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueEnvironment">REST API Reference for DeleteQueueEnvironment Operation</seealso>
        DeleteQueueEnvironmentResponse EndDeleteQueueEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteQueueFleetAssociation


        /// <summary>
        /// Deletes a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueFleetAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueFleetAssociation">REST API Reference for DeleteQueueFleetAssociation Operation</seealso>
        DeleteQueueFleetAssociationResponse DeleteQueueFleetAssociation(DeleteQueueFleetAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueFleetAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueueFleetAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueFleetAssociation">REST API Reference for DeleteQueueFleetAssociation Operation</seealso>
        IAsyncResult BeginDeleteQueueFleetAssociation(DeleteQueueFleetAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueueFleetAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteQueueFleetAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueFleetAssociation">REST API Reference for DeleteQueueFleetAssociation Operation</seealso>
        DeleteQueueFleetAssociationResponse EndDeleteQueueFleetAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStorageProfile


        /// <summary>
        /// Deletes a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteStorageProfile">REST API Reference for DeleteStorageProfile Operation</seealso>
        DeleteStorageProfileResponse DeleteStorageProfile(DeleteStorageProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageProfile operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStorageProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteStorageProfile">REST API Reference for DeleteStorageProfile Operation</seealso>
        IAsyncResult BeginDeleteStorageProfile(DeleteStorageProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStorageProfile.</param>
        /// 
        /// <returns>Returns a  DeleteStorageProfileResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteStorageProfile">REST API Reference for DeleteStorageProfile Operation</seealso>
        DeleteStorageProfileResponse EndDeleteStorageProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorker


        /// <summary>
        /// Deletes a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker service method.</param>
        /// 
        /// <returns>The response from the DeleteWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        DeleteWorkerResponse DeleteWorker(DeleteWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        IAsyncResult BeginDeleteWorker(DeleteWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorker.</param>
        /// 
        /// <returns>Returns a  DeleteWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteWorker">REST API Reference for DeleteWorker Operation</seealso>
        DeleteWorkerResponse EndDeleteWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMemberFromFarm


        /// <summary>
        /// Disassociates a member from a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFarm service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberFromFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFarm">REST API Reference for DisassociateMemberFromFarm Operation</seealso>
        DisassociateMemberFromFarmResponse DisassociateMemberFromFarm(DisassociateMemberFromFarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberFromFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberFromFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFarm">REST API Reference for DisassociateMemberFromFarm Operation</seealso>
        IAsyncResult BeginDisassociateMemberFromFarm(DisassociateMemberFromFarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberFromFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberFromFarm.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberFromFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFarm">REST API Reference for DisassociateMemberFromFarm Operation</seealso>
        DisassociateMemberFromFarmResponse EndDisassociateMemberFromFarm(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMemberFromFleet


        /// <summary>
        /// Disassociates a member from a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFleet service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberFromFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFleet">REST API Reference for DisassociateMemberFromFleet Operation</seealso>
        DisassociateMemberFromFleetResponse DisassociateMemberFromFleet(DisassociateMemberFromFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberFromFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberFromFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFleet">REST API Reference for DisassociateMemberFromFleet Operation</seealso>
        IAsyncResult BeginDisassociateMemberFromFleet(DisassociateMemberFromFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberFromFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberFromFleet.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberFromFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromFleet">REST API Reference for DisassociateMemberFromFleet Operation</seealso>
        DisassociateMemberFromFleetResponse EndDisassociateMemberFromFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMemberFromJob


        /// <summary>
        /// Disassociates a member from a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromJob service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberFromJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromJob">REST API Reference for DisassociateMemberFromJob Operation</seealso>
        DisassociateMemberFromJobResponse DisassociateMemberFromJob(DisassociateMemberFromJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberFromJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromJob operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberFromJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromJob">REST API Reference for DisassociateMemberFromJob Operation</seealso>
        IAsyncResult BeginDisassociateMemberFromJob(DisassociateMemberFromJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberFromJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberFromJob.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberFromJobResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromJob">REST API Reference for DisassociateMemberFromJob Operation</seealso>
        DisassociateMemberFromJobResponse EndDisassociateMemberFromJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMemberFromQueue


        /// <summary>
        /// Disassociates a member from a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromQueue service method.</param>
        /// 
        /// <returns>The response from the DisassociateMemberFromQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromQueue">REST API Reference for DisassociateMemberFromQueue Operation</seealso>
        DisassociateMemberFromQueueResponse DisassociateMemberFromQueue(DisassociateMemberFromQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMemberFromQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMemberFromQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromQueue">REST API Reference for DisassociateMemberFromQueue Operation</seealso>
        IAsyncResult BeginDisassociateMemberFromQueue(DisassociateMemberFromQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMemberFromQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMemberFromQueue.</param>
        /// 
        /// <returns>Returns a  DisassociateMemberFromQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DisassociateMemberFromQueue">REST API Reference for DisassociateMemberFromQueue Operation</seealso>
        DisassociateMemberFromQueueResponse EndDisassociateMemberFromQueue(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBudget


        /// <summary>
        /// Get a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBudget service method.</param>
        /// 
        /// <returns>The response from the GetBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetBudget">REST API Reference for GetBudget Operation</seealso>
        GetBudgetResponse GetBudget(GetBudgetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBudget operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetBudget">REST API Reference for GetBudget Operation</seealso>
        IAsyncResult BeginGetBudget(GetBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBudget.</param>
        /// 
        /// <returns>Returns a  GetBudgetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetBudget">REST API Reference for GetBudget Operation</seealso>
        GetBudgetResponse EndGetBudget(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFarm


        /// <summary>
        /// Get a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFarm service method.</param>
        /// 
        /// <returns>The response from the GetFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFarm">REST API Reference for GetFarm Operation</seealso>
        GetFarmResponse GetFarm(GetFarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFarm">REST API Reference for GetFarm Operation</seealso>
        IAsyncResult BeginGetFarm(GetFarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFarm.</param>
        /// 
        /// <returns>Returns a  GetFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFarm">REST API Reference for GetFarm Operation</seealso>
        GetFarmResponse EndGetFarm(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFleet


        /// <summary>
        /// Get a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFleet service method.</param>
        /// 
        /// <returns>The response from the GetFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFleet">REST API Reference for GetFleet Operation</seealso>
        GetFleetResponse GetFleet(GetFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFleet">REST API Reference for GetFleet Operation</seealso>
        IAsyncResult BeginGetFleet(GetFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFleet.</param>
        /// 
        /// <returns>Returns a  GetFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetFleet">REST API Reference for GetFleet Operation</seealso>
        GetFleetResponse EndGetFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJob


        /// <summary>
        /// Gets a Deadline Cloud job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetJob">REST API Reference for GetJob Operation</seealso>
        GetJobResponse GetJob(GetJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJob operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetJob">REST API Reference for GetJob Operation</seealso>
        IAsyncResult BeginGetJob(GetJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJob.</param>
        /// 
        /// <returns>Returns a  GetJobResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetJob">REST API Reference for GetJob Operation</seealso>
        GetJobResponse EndGetJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLicenseEndpoint


        /// <summary>
        /// Gets a licence endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetLicenseEndpoint service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLicenseEndpoint">REST API Reference for GetLicenseEndpoint Operation</seealso>
        GetLicenseEndpointResponse GetLicenseEndpoint(GetLicenseEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseEndpoint operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLicenseEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLicenseEndpoint">REST API Reference for GetLicenseEndpoint Operation</seealso>
        IAsyncResult BeginGetLicenseEndpoint(GetLicenseEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLicenseEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLicenseEndpoint.</param>
        /// 
        /// <returns>Returns a  GetLicenseEndpointResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLicenseEndpoint">REST API Reference for GetLicenseEndpoint Operation</seealso>
        GetLicenseEndpointResponse EndGetLicenseEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMonitor


        /// <summary>
        /// Gets information about the specified monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// 
        /// <returns>The response from the GetMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        GetMonitorResponse GetMonitor(GetMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        IAsyncResult BeginGetMonitor(GetMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMonitor.</param>
        /// 
        /// <returns>Returns a  GetMonitorResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetMonitor">REST API Reference for GetMonitor Operation</seealso>
        GetMonitorResponse EndGetMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQueue


        /// <summary>
        /// Gets a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueue service method.</param>
        /// 
        /// <returns>The response from the GetQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueue">REST API Reference for GetQueue Operation</seealso>
        GetQueueResponse GetQueue(GetQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueue">REST API Reference for GetQueue Operation</seealso>
        IAsyncResult BeginGetQueue(GetQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueue.</param>
        /// 
        /// <returns>Returns a  GetQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueue">REST API Reference for GetQueue Operation</seealso>
        GetQueueResponse EndGetQueue(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQueueEnvironment


        /// <summary>
        /// Gets a queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueEnvironment">REST API Reference for GetQueueEnvironment Operation</seealso>
        GetQueueEnvironmentResponse GetQueueEnvironment(GetQueueEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueEnvironment operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueueEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueEnvironment">REST API Reference for GetQueueEnvironment Operation</seealso>
        IAsyncResult BeginGetQueueEnvironment(GetQueueEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueueEnvironment.</param>
        /// 
        /// <returns>Returns a  GetQueueEnvironmentResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueEnvironment">REST API Reference for GetQueueEnvironment Operation</seealso>
        GetQueueEnvironmentResponse EndGetQueueEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  GetQueueFleetAssociation


        /// <summary>
        /// Gets a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueFleetAssociation service method.</param>
        /// 
        /// <returns>The response from the GetQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueFleetAssociation">REST API Reference for GetQueueFleetAssociation Operation</seealso>
        GetQueueFleetAssociationResponse GetQueueFleetAssociation(GetQueueFleetAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueFleetAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueueFleetAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueFleetAssociation">REST API Reference for GetQueueFleetAssociation Operation</seealso>
        IAsyncResult BeginGetQueueFleetAssociation(GetQueueFleetAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueueFleetAssociation.</param>
        /// 
        /// <returns>Returns a  GetQueueFleetAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueFleetAssociation">REST API Reference for GetQueueFleetAssociation Operation</seealso>
        GetQueueFleetAssociationResponse EndGetQueueFleetAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSession


        /// <summary>
        /// Gets a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse GetSession(GetSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSession">REST API Reference for GetSession Operation</seealso>
        IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSession">REST API Reference for GetSession Operation</seealso>
        GetSessionResponse EndGetSession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSessionAction


        /// <summary>
        /// Gets a session action for the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionAction service method.</param>
        /// 
        /// <returns>The response from the GetSessionAction service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionAction">REST API Reference for GetSessionAction Operation</seealso>
        GetSessionActionResponse GetSessionAction(GetSessionActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionAction operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionAction">REST API Reference for GetSessionAction Operation</seealso>
        IAsyncResult BeginGetSessionAction(GetSessionActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSessionAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionAction.</param>
        /// 
        /// <returns>Returns a  GetSessionActionResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionAction">REST API Reference for GetSessionAction Operation</seealso>
        GetSessionActionResponse EndGetSessionAction(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSessionsStatisticsAggregation


        /// <summary>
        /// Gets a set of statistics for queues or farms. Before you can call the <c>GetSessionStatisticsAggregation</c>
        /// operation, you must first call the <c>StartSessionsStatisticsAggregation</c> operation.
        /// Statistics are available for 1 hour after you call the <c>StartSessionsStatisticsAggregation</c>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionsStatisticsAggregation service method.</param>
        /// 
        /// <returns>The response from the GetSessionsStatisticsAggregation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionsStatisticsAggregation">REST API Reference for GetSessionsStatisticsAggregation Operation</seealso>
        GetSessionsStatisticsAggregationResponse GetSessionsStatisticsAggregation(GetSessionsStatisticsAggregationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSessionsStatisticsAggregation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSessionsStatisticsAggregation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSessionsStatisticsAggregation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionsStatisticsAggregation">REST API Reference for GetSessionsStatisticsAggregation Operation</seealso>
        IAsyncResult BeginGetSessionsStatisticsAggregation(GetSessionsStatisticsAggregationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSessionsStatisticsAggregation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSessionsStatisticsAggregation.</param>
        /// 
        /// <returns>Returns a  GetSessionsStatisticsAggregationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetSessionsStatisticsAggregation">REST API Reference for GetSessionsStatisticsAggregation Operation</seealso>
        GetSessionsStatisticsAggregationResponse EndGetSessionsStatisticsAggregation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStep


        /// <summary>
        /// Gets a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStep service method.</param>
        /// 
        /// <returns>The response from the GetStep service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStep">REST API Reference for GetStep Operation</seealso>
        GetStepResponse GetStep(GetStepRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStep operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStep">REST API Reference for GetStep Operation</seealso>
        IAsyncResult BeginGetStep(GetStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStep.</param>
        /// 
        /// <returns>Returns a  GetStepResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStep">REST API Reference for GetStep Operation</seealso>
        GetStepResponse EndGetStep(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStorageProfile


        /// <summary>
        /// Gets a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfile service method.</param>
        /// 
        /// <returns>The response from the GetStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfile">REST API Reference for GetStorageProfile Operation</seealso>
        GetStorageProfileResponse GetStorageProfile(GetStorageProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfile operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStorageProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfile">REST API Reference for GetStorageProfile Operation</seealso>
        IAsyncResult BeginGetStorageProfile(GetStorageProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStorageProfile.</param>
        /// 
        /// <returns>Returns a  GetStorageProfileResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfile">REST API Reference for GetStorageProfile Operation</seealso>
        GetStorageProfileResponse EndGetStorageProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStorageProfileForQueue


        /// <summary>
        /// Gets a storage profile for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfileForQueue service method.</param>
        /// 
        /// <returns>The response from the GetStorageProfileForQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfileForQueue">REST API Reference for GetStorageProfileForQueue Operation</seealso>
        GetStorageProfileForQueueResponse GetStorageProfileForQueue(GetStorageProfileForQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStorageProfileForQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfileForQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStorageProfileForQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfileForQueue">REST API Reference for GetStorageProfileForQueue Operation</seealso>
        IAsyncResult BeginGetStorageProfileForQueue(GetStorageProfileForQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStorageProfileForQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStorageProfileForQueue.</param>
        /// 
        /// <returns>Returns a  GetStorageProfileForQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetStorageProfileForQueue">REST API Reference for GetStorageProfileForQueue Operation</seealso>
        GetStorageProfileForQueueResponse EndGetStorageProfileForQueue(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTask


        /// <summary>
        /// Gets a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTask service method.</param>
        /// 
        /// <returns>The response from the GetTask service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetTask">REST API Reference for GetTask Operation</seealso>
        GetTaskResponse GetTask(GetTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTask operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetTask">REST API Reference for GetTask Operation</seealso>
        IAsyncResult BeginGetTask(GetTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTask.</param>
        /// 
        /// <returns>Returns a  GetTaskResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetTask">REST API Reference for GetTask Operation</seealso>
        GetTaskResponse EndGetTask(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWorker


        /// <summary>
        /// Gets a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorker service method.</param>
        /// 
        /// <returns>The response from the GetWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetWorker">REST API Reference for GetWorker Operation</seealso>
        GetWorkerResponse GetWorker(GetWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetWorker">REST API Reference for GetWorker Operation</seealso>
        IAsyncResult BeginGetWorker(GetWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWorker.</param>
        /// 
        /// <returns>Returns a  GetWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetWorker">REST API Reference for GetWorker Operation</seealso>
        GetWorkerResponse EndGetWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAvailableMeteredProducts


        /// <summary>
        /// A list of the available metered products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableMeteredProducts service method.</param>
        /// 
        /// <returns>The response from the ListAvailableMeteredProducts service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListAvailableMeteredProducts">REST API Reference for ListAvailableMeteredProducts Operation</seealso>
        ListAvailableMeteredProductsResponse ListAvailableMeteredProducts(ListAvailableMeteredProductsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableMeteredProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableMeteredProducts operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAvailableMeteredProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListAvailableMeteredProducts">REST API Reference for ListAvailableMeteredProducts Operation</seealso>
        IAsyncResult BeginListAvailableMeteredProducts(ListAvailableMeteredProductsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAvailableMeteredProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAvailableMeteredProducts.</param>
        /// 
        /// <returns>Returns a  ListAvailableMeteredProductsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListAvailableMeteredProducts">REST API Reference for ListAvailableMeteredProducts Operation</seealso>
        ListAvailableMeteredProductsResponse EndListAvailableMeteredProducts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBudgets


        /// <summary>
        /// A list of budgets in a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBudgets service method.</param>
        /// 
        /// <returns>The response from the ListBudgets service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListBudgets">REST API Reference for ListBudgets Operation</seealso>
        ListBudgetsResponse ListBudgets(ListBudgetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBudgets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBudgets operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBudgets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListBudgets">REST API Reference for ListBudgets Operation</seealso>
        IAsyncResult BeginListBudgets(ListBudgetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBudgets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBudgets.</param>
        /// 
        /// <returns>Returns a  ListBudgetsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListBudgets">REST API Reference for ListBudgets Operation</seealso>
        ListBudgetsResponse EndListBudgets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFarmMembers


        /// <summary>
        /// Lists the members of a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFarmMembers service method.</param>
        /// 
        /// <returns>The response from the ListFarmMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarmMembers">REST API Reference for ListFarmMembers Operation</seealso>
        ListFarmMembersResponse ListFarmMembers(ListFarmMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFarmMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFarmMembers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFarmMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarmMembers">REST API Reference for ListFarmMembers Operation</seealso>
        IAsyncResult BeginListFarmMembers(ListFarmMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFarmMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFarmMembers.</param>
        /// 
        /// <returns>Returns a  ListFarmMembersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarmMembers">REST API Reference for ListFarmMembers Operation</seealso>
        ListFarmMembersResponse EndListFarmMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFarms


        /// <summary>
        /// Lists farms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFarms service method.</param>
        /// 
        /// <returns>The response from the ListFarms service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarms">REST API Reference for ListFarms Operation</seealso>
        ListFarmsResponse ListFarms(ListFarmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFarms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFarms operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFarms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarms">REST API Reference for ListFarms Operation</seealso>
        IAsyncResult BeginListFarms(ListFarmsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFarms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFarms.</param>
        /// 
        /// <returns>Returns a  ListFarmsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFarms">REST API Reference for ListFarms Operation</seealso>
        ListFarmsResponse EndListFarms(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFleetMembers


        /// <summary>
        /// Lists fleet members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleetMembers service method.</param>
        /// 
        /// <returns>The response from the ListFleetMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleetMembers">REST API Reference for ListFleetMembers Operation</seealso>
        ListFleetMembersResponse ListFleetMembers(ListFleetMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFleetMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleetMembers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleetMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleetMembers">REST API Reference for ListFleetMembers Operation</seealso>
        IAsyncResult BeginListFleetMembers(ListFleetMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleetMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleetMembers.</param>
        /// 
        /// <returns>Returns a  ListFleetMembersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleetMembers">REST API Reference for ListFleetMembers Operation</seealso>
        ListFleetMembersResponse EndListFleetMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFleets


        /// <summary>
        /// Lists fleets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// 
        /// <returns>The response from the ListFleets service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleets">REST API Reference for ListFleets Operation</seealso>
        ListFleetsResponse ListFleets(ListFleetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleets">REST API Reference for ListFleets Operation</seealso>
        IAsyncResult BeginListFleets(ListFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleets.</param>
        /// 
        /// <returns>Returns a  ListFleetsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListFleets">REST API Reference for ListFleets Operation</seealso>
        ListFleetsResponse EndListFleets(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobMembers


        /// <summary>
        /// Lists members on a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobMembers service method.</param>
        /// 
        /// <returns>The response from the ListJobMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobMembers">REST API Reference for ListJobMembers Operation</seealso>
        ListJobMembersResponse ListJobMembers(ListJobMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobMembers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobMembers">REST API Reference for ListJobMembers Operation</seealso>
        IAsyncResult BeginListJobMembers(ListJobMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobMembers.</param>
        /// 
        /// <returns>Returns a  ListJobMembersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobMembers">REST API Reference for ListJobMembers Operation</seealso>
        ListJobMembersResponse EndListJobMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobParameterDefinitions


        /// <summary>
        /// Lists parameter definitions of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobParameterDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListJobParameterDefinitions service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobParameterDefinitions">REST API Reference for ListJobParameterDefinitions Operation</seealso>
        ListJobParameterDefinitionsResponse ListJobParameterDefinitions(ListJobParameterDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobParameterDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobParameterDefinitions operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobParameterDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobParameterDefinitions">REST API Reference for ListJobParameterDefinitions Operation</seealso>
        IAsyncResult BeginListJobParameterDefinitions(ListJobParameterDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobParameterDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobParameterDefinitions.</param>
        /// 
        /// <returns>Returns a  ListJobParameterDefinitionsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobParameterDefinitions">REST API Reference for ListJobParameterDefinitions Operation</seealso>
        ListJobParameterDefinitionsResponse EndListJobParameterDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse ListJobs(ListJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobs">REST API Reference for ListJobs Operation</seealso>
        IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLicenseEndpoints


        /// <summary>
        /// Lists license endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListLicenseEndpoints service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLicenseEndpoints">REST API Reference for ListLicenseEndpoints Operation</seealso>
        ListLicenseEndpointsResponse ListLicenseEndpoints(ListLicenseEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLicenseEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseEndpoints operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLicenseEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLicenseEndpoints">REST API Reference for ListLicenseEndpoints Operation</seealso>
        IAsyncResult BeginListLicenseEndpoints(ListLicenseEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLicenseEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLicenseEndpoints.</param>
        /// 
        /// <returns>Returns a  ListLicenseEndpointsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLicenseEndpoints">REST API Reference for ListLicenseEndpoints Operation</seealso>
        ListLicenseEndpointsResponse EndListLicenseEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMeteredProducts


        /// <summary>
        /// Lists metered products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeteredProducts service method.</param>
        /// 
        /// <returns>The response from the ListMeteredProducts service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMeteredProducts">REST API Reference for ListMeteredProducts Operation</seealso>
        ListMeteredProductsResponse ListMeteredProducts(ListMeteredProductsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMeteredProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMeteredProducts operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMeteredProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMeteredProducts">REST API Reference for ListMeteredProducts Operation</seealso>
        IAsyncResult BeginListMeteredProducts(ListMeteredProductsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMeteredProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMeteredProducts.</param>
        /// 
        /// <returns>Returns a  ListMeteredProductsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMeteredProducts">REST API Reference for ListMeteredProducts Operation</seealso>
        ListMeteredProductsResponse EndListMeteredProducts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMonitors


        /// <summary>
        /// Gets a list of your monitors in Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// 
        /// <returns>The response from the ListMonitors service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        ListMonitorsResponse ListMonitors(ListMonitorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMonitors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        IAsyncResult BeginListMonitors(ListMonitorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMonitors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMonitors.</param>
        /// 
        /// <returns>Returns a  ListMonitorsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListMonitors">REST API Reference for ListMonitors Operation</seealso>
        ListMonitorsResponse EndListMonitors(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQueueEnvironments


        /// <summary>
        /// Lists queue environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListQueueEnvironments service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueEnvironments">REST API Reference for ListQueueEnvironments Operation</seealso>
        ListQueueEnvironmentsResponse ListQueueEnvironments(ListQueueEnvironmentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueueEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueueEnvironments operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueueEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueEnvironments">REST API Reference for ListQueueEnvironments Operation</seealso>
        IAsyncResult BeginListQueueEnvironments(ListQueueEnvironmentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueueEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueueEnvironments.</param>
        /// 
        /// <returns>Returns a  ListQueueEnvironmentsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueEnvironments">REST API Reference for ListQueueEnvironments Operation</seealso>
        ListQueueEnvironmentsResponse EndListQueueEnvironments(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQueueFleetAssociations


        /// <summary>
        /// Lists queue-fleet associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueFleetAssociations service method.</param>
        /// 
        /// <returns>The response from the ListQueueFleetAssociations service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueFleetAssociations">REST API Reference for ListQueueFleetAssociations Operation</seealso>
        ListQueueFleetAssociationsResponse ListQueueFleetAssociations(ListQueueFleetAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueueFleetAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueueFleetAssociations operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueueFleetAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueFleetAssociations">REST API Reference for ListQueueFleetAssociations Operation</seealso>
        IAsyncResult BeginListQueueFleetAssociations(ListQueueFleetAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueueFleetAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueueFleetAssociations.</param>
        /// 
        /// <returns>Returns a  ListQueueFleetAssociationsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueFleetAssociations">REST API Reference for ListQueueFleetAssociations Operation</seealso>
        ListQueueFleetAssociationsResponse EndListQueueFleetAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQueueMembers


        /// <summary>
        /// Lists the members in a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueMembers service method.</param>
        /// 
        /// <returns>The response from the ListQueueMembers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueMembers">REST API Reference for ListQueueMembers Operation</seealso>
        ListQueueMembersResponse ListQueueMembers(ListQueueMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueueMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueueMembers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueueMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueMembers">REST API Reference for ListQueueMembers Operation</seealso>
        IAsyncResult BeginListQueueMembers(ListQueueMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueueMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueueMembers.</param>
        /// 
        /// <returns>Returns a  ListQueueMembersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueMembers">REST API Reference for ListQueueMembers Operation</seealso>
        ListQueueMembersResponse EndListQueueMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQueues


        /// <summary>
        /// Lists queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueues">REST API Reference for ListQueues Operation</seealso>
        ListQueuesResponse ListQueues(ListQueuesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueues operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueues">REST API Reference for ListQueues Operation</seealso>
        IAsyncResult BeginListQueues(ListQueuesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueues.</param>
        /// 
        /// <returns>Returns a  ListQueuesResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueues">REST API Reference for ListQueues Operation</seealso>
        ListQueuesResponse EndListQueues(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSessionActions


        /// <summary>
        /// Lists session actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionActions service method.</param>
        /// 
        /// <returns>The response from the ListSessionActions service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionActions">REST API Reference for ListSessionActions Operation</seealso>
        ListSessionActionsResponse ListSessionActions(ListSessionActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessionActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessionActions operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessionActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionActions">REST API Reference for ListSessionActions Operation</seealso>
        IAsyncResult BeginListSessionActions(ListSessionActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessionActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessionActions.</param>
        /// 
        /// <returns>Returns a  ListSessionActionsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionActions">REST API Reference for ListSessionActions Operation</seealso>
        ListSessionActionsResponse EndListSessionActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSessions


        /// <summary>
        /// Lists sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessions">REST API Reference for ListSessions Operation</seealso>
        ListSessionsResponse ListSessions(ListSessionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessions">REST API Reference for ListSessions Operation</seealso>
        IAsyncResult BeginListSessions(ListSessionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessions.</param>
        /// 
        /// <returns>Returns a  ListSessionsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessions">REST API Reference for ListSessions Operation</seealso>
        ListSessionsResponse EndListSessions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSessionsForWorker


        /// <summary>
        /// Lists sessions for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionsForWorker service method.</param>
        /// 
        /// <returns>The response from the ListSessionsForWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionsForWorker">REST API Reference for ListSessionsForWorker Operation</seealso>
        ListSessionsForWorkerResponse ListSessionsForWorker(ListSessionsForWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessionsForWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessionsForWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessionsForWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionsForWorker">REST API Reference for ListSessionsForWorker Operation</seealso>
        IAsyncResult BeginListSessionsForWorker(ListSessionsForWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessionsForWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessionsForWorker.</param>
        /// 
        /// <returns>Returns a  ListSessionsForWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSessionsForWorker">REST API Reference for ListSessionsForWorker Operation</seealso>
        ListSessionsForWorkerResponse EndListSessionsForWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStepConsumers


        /// <summary>
        /// Lists step consumers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStepConsumers service method.</param>
        /// 
        /// <returns>The response from the ListStepConsumers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepConsumers">REST API Reference for ListStepConsumers Operation</seealso>
        ListStepConsumersResponse ListStepConsumers(ListStepConsumersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStepConsumers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStepConsumers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStepConsumers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepConsumers">REST API Reference for ListStepConsumers Operation</seealso>
        IAsyncResult BeginListStepConsumers(ListStepConsumersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStepConsumers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStepConsumers.</param>
        /// 
        /// <returns>Returns a  ListStepConsumersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepConsumers">REST API Reference for ListStepConsumers Operation</seealso>
        ListStepConsumersResponse EndListStepConsumers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStepDependencies


        /// <summary>
        /// Lists the dependencies for a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStepDependencies service method.</param>
        /// 
        /// <returns>The response from the ListStepDependencies service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepDependencies">REST API Reference for ListStepDependencies Operation</seealso>
        ListStepDependenciesResponse ListStepDependencies(ListStepDependenciesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStepDependencies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStepDependencies operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStepDependencies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepDependencies">REST API Reference for ListStepDependencies Operation</seealso>
        IAsyncResult BeginListStepDependencies(ListStepDependenciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStepDependencies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStepDependencies.</param>
        /// 
        /// <returns>Returns a  ListStepDependenciesResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStepDependencies">REST API Reference for ListStepDependencies Operation</seealso>
        ListStepDependenciesResponse EndListStepDependencies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSteps


        /// <summary>
        /// Lists steps for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method.</param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSteps">REST API Reference for ListSteps Operation</seealso>
        ListStepsResponse ListSteps(ListStepsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSteps operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSteps">REST API Reference for ListSteps Operation</seealso>
        IAsyncResult BeginListSteps(ListStepsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSteps.</param>
        /// 
        /// <returns>Returns a  ListStepsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListSteps">REST API Reference for ListSteps Operation</seealso>
        ListStepsResponse EndListSteps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStorageProfiles


        /// <summary>
        /// Lists storage profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfiles service method.</param>
        /// 
        /// <returns>The response from the ListStorageProfiles service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfiles">REST API Reference for ListStorageProfiles Operation</seealso>
        ListStorageProfilesResponse ListStorageProfiles(ListStorageProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStorageProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfiles operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStorageProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfiles">REST API Reference for ListStorageProfiles Operation</seealso>
        IAsyncResult BeginListStorageProfiles(ListStorageProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStorageProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStorageProfiles.</param>
        /// 
        /// <returns>Returns a  ListStorageProfilesResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfiles">REST API Reference for ListStorageProfiles Operation</seealso>
        ListStorageProfilesResponse EndListStorageProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStorageProfilesForQueue


        /// <summary>
        /// Lists storage profiles for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfilesForQueue service method.</param>
        /// 
        /// <returns>The response from the ListStorageProfilesForQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfilesForQueue">REST API Reference for ListStorageProfilesForQueue Operation</seealso>
        ListStorageProfilesForQueueResponse ListStorageProfilesForQueue(ListStorageProfilesForQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStorageProfilesForQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfilesForQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStorageProfilesForQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfilesForQueue">REST API Reference for ListStorageProfilesForQueue Operation</seealso>
        IAsyncResult BeginListStorageProfilesForQueue(ListStorageProfilesForQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStorageProfilesForQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStorageProfilesForQueue.</param>
        /// 
        /// <returns>Returns a  ListStorageProfilesForQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListStorageProfilesForQueue">REST API Reference for ListStorageProfilesForQueue Operation</seealso>
        ListStorageProfilesForQueueResponse EndListStorageProfilesForQueue(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTasks


        /// <summary>
        /// Lists tasks for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTasks">REST API Reference for ListTasks Operation</seealso>
        ListTasksResponse ListTasks(ListTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTasks">REST API Reference for ListTasks Operation</seealso>
        IAsyncResult BeginListTasks(ListTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTasks.</param>
        /// 
        /// <returns>Returns a  ListTasksResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListTasks">REST API Reference for ListTasks Operation</seealso>
        ListTasksResponse EndListTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkers


        /// <summary>
        /// Lists workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers service method.</param>
        /// 
        /// <returns>The response from the ListWorkers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        ListWorkersResponse ListWorkers(ListWorkersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        IAsyncResult BeginListWorkers(ListWorkersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkers.</param>
        /// 
        /// <returns>Returns a  ListWorkersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListWorkers">REST API Reference for ListWorkers Operation</seealso>
        ListWorkersResponse EndListWorkers(IAsyncResult asyncResult);

        #endregion
        
        #region  PutMeteredProduct


        /// <summary>
        /// Adds a metered product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMeteredProduct service method.</param>
        /// 
        /// <returns>The response from the PutMeteredProduct service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/PutMeteredProduct">REST API Reference for PutMeteredProduct Operation</seealso>
        PutMeteredProductResponse PutMeteredProduct(PutMeteredProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutMeteredProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMeteredProduct operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMeteredProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/PutMeteredProduct">REST API Reference for PutMeteredProduct Operation</seealso>
        IAsyncResult BeginPutMeteredProduct(PutMeteredProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutMeteredProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMeteredProduct.</param>
        /// 
        /// <returns>Returns a  PutMeteredProductResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/PutMeteredProduct">REST API Reference for PutMeteredProduct Operation</seealso>
        PutMeteredProductResponse EndPutMeteredProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchJobs


        /// <summary>
        /// Searches for jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs service method.</param>
        /// 
        /// <returns>The response from the SearchJobs service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        SearchJobsResponse SearchJobs(SearchJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        IAsyncResult BeginSearchJobs(SearchJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchJobs.</param>
        /// 
        /// <returns>Returns a  SearchJobsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchJobs">REST API Reference for SearchJobs Operation</seealso>
        SearchJobsResponse EndSearchJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchSteps


        /// <summary>
        /// Searches for steps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSteps service method.</param>
        /// 
        /// <returns>The response from the SearchSteps service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchSteps">REST API Reference for SearchSteps Operation</seealso>
        SearchStepsResponse SearchSteps(SearchStepsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchSteps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchSteps operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchSteps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchSteps">REST API Reference for SearchSteps Operation</seealso>
        IAsyncResult BeginSearchSteps(SearchStepsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchSteps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchSteps.</param>
        /// 
        /// <returns>Returns a  SearchStepsResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchSteps">REST API Reference for SearchSteps Operation</seealso>
        SearchStepsResponse EndSearchSteps(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchTasks


        /// <summary>
        /// Searches for tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTasks service method.</param>
        /// 
        /// <returns>The response from the SearchTasks service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchTasks">REST API Reference for SearchTasks Operation</seealso>
        SearchTasksResponse SearchTasks(SearchTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchTasks operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchTasks">REST API Reference for SearchTasks Operation</seealso>
        IAsyncResult BeginSearchTasks(SearchTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchTasks.</param>
        /// 
        /// <returns>Returns a  SearchTasksResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchTasks">REST API Reference for SearchTasks Operation</seealso>
        SearchTasksResponse EndSearchTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchWorkers


        /// <summary>
        /// Searches for workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchWorkers service method.</param>
        /// 
        /// <returns>The response from the SearchWorkers service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchWorkers">REST API Reference for SearchWorkers Operation</seealso>
        SearchWorkersResponse SearchWorkers(SearchWorkersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SearchWorkers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchWorkers operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchWorkers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchWorkers">REST API Reference for SearchWorkers Operation</seealso>
        IAsyncResult BeginSearchWorkers(SearchWorkersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchWorkers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchWorkers.</param>
        /// 
        /// <returns>Returns a  SearchWorkersResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/SearchWorkers">REST API Reference for SearchWorkers Operation</seealso>
        SearchWorkersResponse EndSearchWorkers(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSessionsStatisticsAggregation


        /// <summary>
        /// Starts an asynchronous request for getting aggregated statistics about queues and
        /// farms. Get the statistics using the <c>GetSessionsStatisticsAggregation</c> operation.
        /// You can only have one running aggregation for your Deadline Cloud farm. Call the <c>GetSessionsStatisticsAggregation</c>
        /// operation and check the <c>status</c> field to see if an aggregation is running. Statistics
        /// are available for 1 hour after you call the <c>StartSessionsStatisticsAggregation</c>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSessionsStatisticsAggregation service method.</param>
        /// 
        /// <returns>The response from the StartSessionsStatisticsAggregation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/StartSessionsStatisticsAggregation">REST API Reference for StartSessionsStatisticsAggregation Operation</seealso>
        StartSessionsStatisticsAggregationResponse StartSessionsStatisticsAggregation(StartSessionsStatisticsAggregationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSessionsStatisticsAggregation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSessionsStatisticsAggregation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSessionsStatisticsAggregation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/StartSessionsStatisticsAggregation">REST API Reference for StartSessionsStatisticsAggregation Operation</seealso>
        IAsyncResult BeginStartSessionsStatisticsAggregation(StartSessionsStatisticsAggregationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSessionsStatisticsAggregation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSessionsStatisticsAggregation.</param>
        /// 
        /// <returns>Returns a  StartSessionsStatisticsAggregationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/StartSessionsStatisticsAggregation">REST API Reference for StartSessionsStatisticsAggregation Operation</seealso>
        StartSessionsStatisticsAggregationResponse EndStartSessionsStatisticsAggregation(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Tags a resource using the resource's ARN and desired tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a resource using the resource's ARN and tag to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBudget


        /// <summary>
        /// Updates a budget that sets spending thresholds for rendering activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget service method.</param>
        /// 
        /// <returns>The response from the UpdateBudget service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        UpdateBudgetResponse UpdateBudget(UpdateBudgetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBudget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        IAsyncResult BeginUpdateBudget(UpdateBudgetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBudget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBudget.</param>
        /// 
        /// <returns>Returns a  UpdateBudgetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateBudget">REST API Reference for UpdateBudget Operation</seealso>
        UpdateBudgetResponse EndUpdateBudget(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFarm


        /// <summary>
        /// Updates a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFarm service method.</param>
        /// 
        /// <returns>The response from the UpdateFarm service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFarm">REST API Reference for UpdateFarm Operation</seealso>
        UpdateFarmResponse UpdateFarm(UpdateFarmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFarm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFarm operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFarm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFarm">REST API Reference for UpdateFarm Operation</seealso>
        IAsyncResult BeginUpdateFarm(UpdateFarmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFarm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFarm.</param>
        /// 
        /// <returns>Returns a  UpdateFarmResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFarm">REST API Reference for UpdateFarm Operation</seealso>
        UpdateFarmResponse EndUpdateFarm(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFleet


        /// <summary>
        /// Updates a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// 
        /// <returns>The response from the UpdateFleet service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ServiceQuotaExceededException">
        /// You exceeded your service quota. Service quotas, also referred to as limits, are the
        /// maximum number of service resources or operations for your Amazon Web Services account.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        UpdateFleetResponse UpdateFleet(UpdateFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        IAsyncResult BeginUpdateFleet(UpdateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleet.</param>
        /// 
        /// <returns>Returns a  UpdateFleetResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateFleet">REST API Reference for UpdateFleet Operation</seealso>
        UpdateFleetResponse EndUpdateFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateJob


        /// <summary>
        /// Updates a job. 
        /// 
        ///  
        /// <para>
        /// When you change the status of the job to <c>ARCHIVED</c>, the job can't be scheduled
        /// or archived.
        /// </para>
        ///  <important> 
        /// <para>
        /// An archived jobs and its steps and tasks are deleted after 120 days. The job can't
        /// be recovered.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        UpdateJobResponse UpdateJob(UpdateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        IAsyncResult BeginUpdateJob(UpdateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJob.</param>
        /// 
        /// <returns>Returns a  UpdateJobResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        UpdateJobResponse EndUpdateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMonitor


        /// <summary>
        /// Modifies the settings for a Deadline Cloud monitor. You can modify one or all of the
        /// settings when you call <c>UpdateMonitor</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// 
        /// <returns>The response from the UpdateMonitor service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMonitor operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMonitor
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        IAsyncResult BeginUpdateMonitor(UpdateMonitorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMonitor operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMonitor.</param>
        /// 
        /// <returns>Returns a  UpdateMonitorResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateMonitor">REST API Reference for UpdateMonitor Operation</seealso>
        UpdateMonitorResponse EndUpdateMonitor(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQueue


        /// <summary>
        /// Updates a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue service method.</param>
        /// 
        /// <returns>The response from the UpdateQueue service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        UpdateQueueResponse UpdateQueue(UpdateQueueRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueue
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        IAsyncResult BeginUpdateQueue(UpdateQueueRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueue operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueue.</param>
        /// 
        /// <returns>Returns a  UpdateQueueResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueue">REST API Reference for UpdateQueue Operation</seealso>
        UpdateQueueResponse EndUpdateQueue(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQueueEnvironment


        /// <summary>
        /// Updates the queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueEnvironment service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueEnvironment">REST API Reference for UpdateQueueEnvironment Operation</seealso>
        UpdateQueueEnvironmentResponse UpdateQueueEnvironment(UpdateQueueEnvironmentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueEnvironment operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueueEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueEnvironment">REST API Reference for UpdateQueueEnvironment Operation</seealso>
        IAsyncResult BeginUpdateQueueEnvironment(UpdateQueueEnvironmentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueueEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueueEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateQueueEnvironmentResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueEnvironment">REST API Reference for UpdateQueueEnvironment Operation</seealso>
        UpdateQueueEnvironmentResponse EndUpdateQueueEnvironment(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateQueueFleetAssociation


        /// <summary>
        /// Updates a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueFleetAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueFleetAssociation service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueFleetAssociation">REST API Reference for UpdateQueueFleetAssociation Operation</seealso>
        UpdateQueueFleetAssociationResponse UpdateQueueFleetAssociation(UpdateQueueFleetAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueFleetAssociation operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateQueueFleetAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueFleetAssociation">REST API Reference for UpdateQueueFleetAssociation Operation</seealso>
        IAsyncResult BeginUpdateQueueFleetAssociation(UpdateQueueFleetAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateQueueFleetAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateQueueFleetAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateQueueFleetAssociationResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueFleetAssociation">REST API Reference for UpdateQueueFleetAssociation Operation</seealso>
        UpdateQueueFleetAssociationResponse EndUpdateQueueFleetAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSession


        /// <summary>
        /// Updates a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession service method.</param>
        /// 
        /// <returns>The response from the UpdateSession service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        UpdateSessionResponse UpdateSession(UpdateSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        IAsyncResult BeginUpdateSession(UpdateSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSession.</param>
        /// 
        /// <returns>Returns a  UpdateSessionResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateSession">REST API Reference for UpdateSession Operation</seealso>
        UpdateSessionResponse EndUpdateSession(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStep


        /// <summary>
        /// Updates a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStep service method.</param>
        /// 
        /// <returns>The response from the UpdateStep service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStep">REST API Reference for UpdateStep Operation</seealso>
        UpdateStepResponse UpdateStep(UpdateStepRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStep operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStep operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStep
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStep">REST API Reference for UpdateStep Operation</seealso>
        IAsyncResult BeginUpdateStep(UpdateStepRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStep operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStep.</param>
        /// 
        /// <returns>Returns a  UpdateStepResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStep">REST API Reference for UpdateStep Operation</seealso>
        UpdateStepResponse EndUpdateStep(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStorageProfile


        /// <summary>
        /// Updates a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateStorageProfile service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStorageProfile">REST API Reference for UpdateStorageProfile Operation</seealso>
        UpdateStorageProfileResponse UpdateStorageProfile(UpdateStorageProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageProfile operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStorageProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStorageProfile">REST API Reference for UpdateStorageProfile Operation</seealso>
        IAsyncResult BeginUpdateStorageProfile(UpdateStorageProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStorageProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStorageProfile.</param>
        /// 
        /// <returns>Returns a  UpdateStorageProfileResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateStorageProfile">REST API Reference for UpdateStorageProfile Operation</seealso>
        UpdateStorageProfileResponse EndUpdateStorageProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTask


        /// <summary>
        /// Updates a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// 
        /// <returns>The response from the UpdateTask service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        UpdateTaskResponse UpdateTask(UpdateTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        IAsyncResult BeginUpdateTask(UpdateTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTask.</param>
        /// 
        /// <returns>Returns a  UpdateTaskResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateTask">REST API Reference for UpdateTask Operation</seealso>
        UpdateTaskResponse EndUpdateTask(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorker


        /// <summary>
        /// Updates a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker service method.</param>
        /// 
        /// <returns>The response from the UpdateWorker service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        UpdateWorkerResponse UpdateWorker(UpdateWorkerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorker operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorker
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        IAsyncResult BeginUpdateWorker(UpdateWorkerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorker operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorker.</param>
        /// 
        /// <returns>Returns a  UpdateWorkerResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorker">REST API Reference for UpdateWorker Operation</seealso>
        UpdateWorkerResponse EndUpdateWorker(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkerSchedule


        /// <summary>
        /// Updates the schedule for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkerSchedule service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.AccessDeniedException">
        /// You don't have permission to perform the action.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ResourceNotFoundException">
        /// The requested resource can't be found.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ValidationException">
        /// The request isn't valid. This can occur if your request contains malformed JSON or
        /// unsupported characters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorkerSchedule">REST API Reference for UpdateWorkerSchedule Operation</seealso>
        UpdateWorkerScheduleResponse UpdateWorkerSchedule(UpdateWorkerScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkerSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerSchedule operation on AmazonDeadlineClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkerSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorkerSchedule">REST API Reference for UpdateWorkerSchedule Operation</seealso>
        IAsyncResult BeginUpdateWorkerSchedule(UpdateWorkerScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkerSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkerSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateWorkerScheduleResult from Deadline.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateWorkerSchedule">REST API Reference for UpdateWorkerSchedule Operation</seealso>
        UpdateWorkerScheduleResponse EndUpdateWorkerSchedule(IAsyncResult asyncResult);

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