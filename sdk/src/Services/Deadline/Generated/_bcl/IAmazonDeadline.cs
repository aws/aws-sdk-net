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
using System.Threading;
using System.Threading.Tasks;
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

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IDeadlinePaginatorFactory Paginators { get; }

        
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
        /// Assigns a farm membership level to a member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateMemberToFarmResponse> AssociateMemberToFarmAsync(AssociateMemberToFarmRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Assigns a fleet membership level to a member.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateMemberToFleetResponse> AssociateMemberToFleetAsync(AssociateMemberToFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Assigns a job membership level to a member
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateMemberToJobResponse> AssociateMemberToJobAsync(AssociateMemberToJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Assigns a queue membership level to a member
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMemberToQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssociateMemberToQueueResponse> AssociateMemberToQueueAsync(AssociateMemberToQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get Amazon Web Services credentials from the fleet role. The IAM permissions of the
        /// credentials are scoped down to have read-only access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForRead service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssumeFleetRoleForReadResponse> AssumeFleetRoleForReadAsync(AssumeFleetRoleForReadRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get credentials from the fleet role for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeFleetRoleForWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssumeFleetRoleForWorkerResponse> AssumeFleetRoleForWorkerAsync(AssumeFleetRoleForWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets Amazon Web Services credentials from the queue role. The IAM permissions of the
        /// credentials are scoped down to have read-only access.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForRead service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssumeQueueRoleForReadResponse> AssumeQueueRoleForReadAsync(AssumeQueueRoleForReadRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Allows a user to assume a role for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssumeQueueRoleForUserResponse> AssumeQueueRoleForUserAsync(AssumeQueueRoleForUserRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Allows a worker to assume a queue role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssumeQueueRoleForWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<AssumeQueueRoleForWorkerResponse> AssumeQueueRoleForWorkerAsync(AssumeQueueRoleForWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get batched job details for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetJobEntity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<BatchGetJobEntityResponse> BatchGetJobEntityAsync(BatchGetJobEntityRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Copies a job template to an Amazon S3 bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyJobTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CopyJobTemplateResponse> CopyJobTemplateAsync(CopyJobTemplateRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a budget to set spending thresholds for your rendering activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBudget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateBudgetResponse> CreateBudgetAsync(CreateBudgetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a farm to allow space for queues and fleets. Farms are the space where the
        /// components of your renders gather and are pieced together in the cloud. Farms contain
        /// budgets and allow you to enforce permissions. Deadline Cloud farms are a useful container
        /// for large projects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateFarmResponse> CreateFarmAsync(CreateFarmRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a fleet. Fleets gather information relating to compute, or capacity, for renders
        /// within your farms. You can choose to manage your own capacity or opt to have fleets
        /// fully managed by Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Creates a job. A job is a set of instructions that Deadline Cloud uses to schedule
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
        /// Creates a job. A job is a set of instructions that Deadline Cloud uses to schedule
        /// and run work on available workers. For more information, see <a href="https://docs.aws.amazon.com/deadline-cloud/latest/userguide/deadline-cloud-jobs.html">Deadline
        /// Cloud jobs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a license endpoint to integrate your various licensed software used for rendering
        /// on Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateLicenseEndpointResponse> CreateLicenseEndpointAsync(CreateLicenseEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLimit


        /// <summary>
        /// Creates a limit that manages the distribution of shared resources, such as floating
        /// licenses. A limit can throttle work assignments, help manage workloads, and track
        /// current usage. Before you use a limit, you must associate the limit with one or more
        /// queues. 
        /// 
        ///  
        /// <para>
        /// You must add the <c>amountRequirementName</c> to a step in a job template to declare
        /// the limit requirement.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLimit service method.</param>
        /// 
        /// <returns>The response from the CreateLimit service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLimit">REST API Reference for CreateLimit Operation</seealso>
        CreateLimitResponse CreateLimit(CreateLimitRequest request);



        /// <summary>
        /// Creates a limit that manages the distribution of shared resources, such as floating
        /// licenses. A limit can throttle work assignments, help manage workloads, and track
        /// current usage. Before you use a limit, you must associate the limit with one or more
        /// queues. 
        /// 
        ///  
        /// <para>
        /// You must add the <c>amountRequirementName</c> to a step in a job template to declare
        /// the limit requirement.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLimit service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateLimit">REST API Reference for CreateLimit Operation</seealso>
        Task<CreateLimitResponse> CreateLimitAsync(CreateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an Amazon Web Services Deadline Cloud monitor that you can use to view your
        /// farms, queues, and fleets. After you submit a job, you can track the progress of the
        /// tasks and steps that make up the job, and then download the job's results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateMonitorResponse> CreateMonitorAsync(CreateMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a queue to coordinate the order in which jobs run on a farm. A queue can also
        /// specify where to pull resources and indicate where to output completed jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an environment for a queue that defines how jobs in the queue run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateQueueEnvironmentResponse> CreateQueueEnvironmentAsync(CreateQueueEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates an association between a queue and a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueFleetAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateQueueFleetAssociationResponse> CreateQueueFleetAssociationAsync(CreateQueueFleetAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateQueueLimitAssociation


        /// <summary>
        /// Associates a limit with a particular queue. After the limit is associated, all workers
        /// for jobs that specify the limit associated with the queue are subject to the limit.
        /// You can't associate two limits with the same <c>amountRequirementName</c> to the same
        /// queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueLimitAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateQueueLimitAssociation service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueLimitAssociation">REST API Reference for CreateQueueLimitAssociation Operation</seealso>
        CreateQueueLimitAssociationResponse CreateQueueLimitAssociation(CreateQueueLimitAssociationRequest request);



        /// <summary>
        /// Associates a limit with a particular queue. After the limit is associated, all workers
        /// for jobs that specify the limit associated with the queue are subject to the limit.
        /// You can't associate two limits with the same <c>amountRequirementName</c> to the same
        /// queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueueLimitAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueueLimitAssociation service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/CreateQueueLimitAssociation">REST API Reference for CreateQueueLimitAssociation Operation</seealso>
        Task<CreateQueueLimitAssociationResponse> CreateQueueLimitAssociationAsync(CreateQueueLimitAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Creates a storage profile that specifies the operating system, file type, and file
        /// location of resources used on a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateStorageProfileResponse> CreateStorageProfileAsync(CreateStorageProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateWorker


        /// <summary>
        /// Creates a worker. A worker tells your instance how much processing power (vCPU), and
        /// memory (GiB) you’ll need to assemble the digital assets held within a particular instance.
        /// You can specify certain instance types to use, or let the worker know which instances
        /// types to exclude.
        /// 
        ///  
        /// <para>
        /// Deadline Cloud limits the number of workers to less than or equal to the fleet's maximum
        /// worker count. The service maintains eventual consistency for the worker count. If
        /// you make multiple rapid calls to <c>CreateWorker</c> before the field updates, you
        /// might exceed your fleet's maximum worker count. For example, if your <c>maxWorkerCount</c>
        /// is 10 and you currently have 9 workers, making two quick <c>CreateWorker</c> calls
        /// might successfully create 2 workers instead of 1, resulting in 11 total workers.
        /// </para>
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
        /// Creates a worker. A worker tells your instance how much processing power (vCPU), and
        /// memory (GiB) you’ll need to assemble the digital assets held within a particular instance.
        /// You can specify certain instance types to use, or let the worker know which instances
        /// types to exclude.
        /// 
        ///  
        /// <para>
        /// Deadline Cloud limits the number of workers to less than or equal to the fleet's maximum
        /// worker count. The service maintains eventual consistency for the worker count. If
        /// you make multiple rapid calls to <c>CreateWorker</c> before the field updates, you
        /// might exceed your fleet's maximum worker count. For example, if your <c>maxWorkerCount</c>
        /// is 10 and you currently have 9 workers, making two quick <c>CreateWorker</c> calls
        /// might successfully create 2 workers instead of 1, resulting in 11 total workers.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateWorkerResponse> CreateWorkerAsync(CreateWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBudget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteBudgetResponse> DeleteBudgetAsync(DeleteBudgetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteFarmResponse> DeleteFarmAsync(DeleteFarmRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a license endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteLicenseEndpointResponse> DeleteLicenseEndpointAsync(DeleteLicenseEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLimit


        /// <summary>
        /// Removes a limit from the specified farm. Before you delete a limit you must use the
        /// <c>DeleteQueueLimitAssociation</c> operation to remove the association with any queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLimit service method.</param>
        /// 
        /// <returns>The response from the DeleteLimit service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLimit">REST API Reference for DeleteLimit Operation</seealso>
        DeleteLimitResponse DeleteLimit(DeleteLimitRequest request);



        /// <summary>
        /// Removes a limit from the specified farm. Before you delete a limit you must use the
        /// <c>DeleteQueueLimitAssociation</c> operation to remove the association with any queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLimit service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteLimit">REST API Reference for DeleteLimit Operation</seealso>
        Task<DeleteLimitResponse> DeleteLimitAsync(DeleteLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a metered product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMeteredProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMeteredProductResponse> DeleteMeteredProductAsync(DeleteMeteredProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a Deadline Cloud monitor. After you delete a monitor, you can create a new
        /// one and attach farms to the monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteMonitorResponse> DeleteMonitorAsync(DeleteMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteQueueEnvironmentResponse> DeleteQueueEnvironmentAsync(DeleteQueueEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueFleetAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteQueueFleetAssociationResponse> DeleteQueueFleetAssociationAsync(DeleteQueueFleetAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteQueueLimitAssociation


        /// <summary>
        /// Removes the association between a queue and a limit. You must use the <c>UpdateQueueLimitAssociation</c>
        /// operation to set the status to <c>STOP_LIMIT_USAGE_AND_COMPLETE_TASKS</c> or <c>STOP_LIMIT_USAGE_AND_CANCEL_TASKS</c>.
        /// The status does not change immediately. Use the <c>GetQueueLimitAssociation</c> operation
        /// to see if the status changed to <c>STOPPED</c> before deleting the association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueLimitAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteQueueLimitAssociation service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueLimitAssociation">REST API Reference for DeleteQueueLimitAssociation Operation</seealso>
        DeleteQueueLimitAssociationResponse DeleteQueueLimitAssociation(DeleteQueueLimitAssociationRequest request);



        /// <summary>
        /// Removes the association between a queue and a limit. You must use the <c>UpdateQueueLimitAssociation</c>
        /// operation to set the status to <c>STOP_LIMIT_USAGE_AND_COMPLETE_TASKS</c> or <c>STOP_LIMIT_USAGE_AND_CANCEL_TASKS</c>.
        /// The status does not change immediately. Use the <c>GetQueueLimitAssociation</c> operation
        /// to see if the status changed to <c>STOPPED</c> before deleting the association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueueLimitAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueueLimitAssociation service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/DeleteQueueLimitAssociation">REST API Reference for DeleteQueueLimitAssociation Operation</seealso>
        Task<DeleteQueueLimitAssociationResponse> DeleteQueueLimitAssociationAsync(DeleteQueueLimitAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStorageProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteStorageProfileResponse> DeleteStorageProfileAsync(DeleteStorageProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DeleteWorkerResponse> DeleteWorkerAsync(DeleteWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disassociates a member from a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateMemberFromFarmResponse> DisassociateMemberFromFarmAsync(DisassociateMemberFromFarmRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disassociates a member from a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateMemberFromFleetResponse> DisassociateMemberFromFleetAsync(DisassociateMemberFromFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disassociates a member from a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateMemberFromJobResponse> DisassociateMemberFromJobAsync(DisassociateMemberFromJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Disassociates a member from a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMemberFromQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DisassociateMemberFromQueueResponse> DisassociateMemberFromQueueAsync(DisassociateMemberFromQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get a budget.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBudget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetBudgetResponse> GetBudgetAsync(GetBudgetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetFarmResponse> GetFarmAsync(GetFarmRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Get a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetFleetResponse> GetFleetAsync(GetFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a Deadline Cloud job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetJobResponse> GetJobAsync(GetJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a licence endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetLicenseEndpointResponse> GetLicenseEndpointAsync(GetLicenseEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLimit


        /// <summary>
        /// Gets information about a specific limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLimit service method.</param>
        /// 
        /// <returns>The response from the GetLimit service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLimit">REST API Reference for GetLimit Operation</seealso>
        GetLimitResponse GetLimit(GetLimitRequest request);



        /// <summary>
        /// Gets information about a specific limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLimit service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetLimit">REST API Reference for GetLimit Operation</seealso>
        Task<GetLimitResponse> GetLimitAsync(GetLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets information about the specified monitor.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetMonitorResponse> GetMonitorAsync(GetMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetQueueResponse> GetQueueAsync(GetQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetQueueEnvironmentResponse> GetQueueEnvironmentAsync(GetQueueEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueFleetAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetQueueFleetAssociationResponse> GetQueueFleetAssociationAsync(GetQueueFleetAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetQueueLimitAssociation


        /// <summary>
        /// Gets information about a specific association between a queue and a limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueLimitAssociation service method.</param>
        /// 
        /// <returns>The response from the GetQueueLimitAssociation service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueLimitAssociation">REST API Reference for GetQueueLimitAssociation Operation</seealso>
        GetQueueLimitAssociationResponse GetQueueLimitAssociation(GetQueueLimitAssociationRequest request);



        /// <summary>
        /// Gets information about a specific association between a queue and a limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueLimitAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueLimitAssociation service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/GetQueueLimitAssociation">REST API Reference for GetQueueLimitAssociation Operation</seealso>
        Task<GetQueueLimitAssociationResponse> GetQueueLimitAssociationAsync(GetQueueLimitAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a session action for the job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSessionActionResponse> GetSessionActionAsync(GetSessionActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a set of statistics for queues or farms. Before you can call the <c>GetSessionStatisticsAggregation</c>
        /// operation, you must first call the <c>StartSessionsStatisticsAggregation</c> operation.
        /// Statistics are available for 1 hour after you call the <c>StartSessionsStatisticsAggregation</c>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSessionsStatisticsAggregation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetSessionsStatisticsAggregationResponse> GetSessionsStatisticsAggregationAsync(GetSessionsStatisticsAggregationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetStepResponse> GetStepAsync(GetStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetStorageProfileResponse> GetStorageProfileAsync(GetStorageProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a storage profile for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStorageProfileForQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetStorageProfileForQueueResponse> GetStorageProfileForQueueAsync(GetStorageProfileForQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetTaskResponse> GetTaskAsync(GetTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetWorkerResponse> GetWorkerAsync(GetWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// A list of the available metered products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableMeteredProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableMeteredProducts service method, as returned by Deadline.</returns>
        /// <exception cref="Amazon.Deadline.Model.InternalServerErrorException">
        /// Deadline Cloud can't process your request right now. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Deadline.Model.ThrottlingException">
        /// Your request exceeded a request rate quota.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListAvailableMeteredProducts">REST API Reference for ListAvailableMeteredProducts Operation</seealso>
        Task<ListAvailableMeteredProductsResponse> ListAvailableMeteredProductsAsync(ListAvailableMeteredProductsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// A list of budgets in a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBudgets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListBudgetsResponse> ListBudgetsAsync(ListBudgetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the members of a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFarmMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListFarmMembersResponse> ListFarmMembersAsync(ListFarmMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists farms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFarms service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListFarmsResponse> ListFarmsAsync(ListFarmsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists fleet members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleetMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListFleetMembersResponse> ListFleetMembersAsync(ListFleetMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists fleets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists members on a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListJobMembersResponse> ListJobMembersAsync(ListJobMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists parameter definitions of a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobParameterDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListJobParameterDefinitionsResponse> ListJobParameterDefinitionsAsync(ListJobParameterDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists license endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListLicenseEndpointsResponse> ListLicenseEndpointsAsync(ListLicenseEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLimits


        /// <summary>
        /// Gets a list of limits defined in the specified farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLimits service method.</param>
        /// 
        /// <returns>The response from the ListLimits service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLimits">REST API Reference for ListLimits Operation</seealso>
        ListLimitsResponse ListLimits(ListLimitsRequest request);



        /// <summary>
        /// Gets a list of limits defined in the specified farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLimits service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListLimits">REST API Reference for ListLimits Operation</seealso>
        Task<ListLimitsResponse> ListLimitsAsync(ListLimitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists metered products.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeteredProducts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMeteredProductsResponse> ListMeteredProductsAsync(ListMeteredProductsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Gets a list of your monitors in Deadline Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMonitors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListMonitorsResponse> ListMonitorsAsync(ListMonitorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists queue environments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListQueueEnvironmentsResponse> ListQueueEnvironmentsAsync(ListQueueEnvironmentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists queue-fleet associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueFleetAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListQueueFleetAssociationsResponse> ListQueueFleetAssociationsAsync(ListQueueFleetAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListQueueLimitAssociations


        /// <summary>
        /// Gets a list of the associations between queues and limits defined in a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueLimitAssociations service method.</param>
        /// 
        /// <returns>The response from the ListQueueLimitAssociations service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueLimitAssociations">REST API Reference for ListQueueLimitAssociations Operation</seealso>
        ListQueueLimitAssociationsResponse ListQueueLimitAssociations(ListQueueLimitAssociationsRequest request);



        /// <summary>
        /// Gets a list of the associations between queues and limits defined in a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueLimitAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueueLimitAssociations service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/ListQueueLimitAssociations">REST API Reference for ListQueueLimitAssociations Operation</seealso>
        Task<ListQueueLimitAssociationsResponse> ListQueueLimitAssociationsAsync(ListQueueLimitAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the members in a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueMembers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListQueueMembersResponse> ListQueueMembersAsync(ListQueueMembersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists queues.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists session actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSessionActionsResponse> ListSessionActionsAsync(ListSessionActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists sessions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists sessions for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessionsForWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListSessionsForWorkerResponse> ListSessionsForWorkerAsync(ListSessionsForWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists step consumers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStepConsumers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListStepConsumersResponse> ListStepConsumersAsync(ListStepConsumersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the dependencies for a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStepDependencies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListStepDependenciesResponse> ListStepDependenciesAsync(ListStepDependenciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists steps for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListStepsResponse> ListStepsAsync(ListStepsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists storage profiles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListStorageProfilesResponse> ListStorageProfilesAsync(ListStorageProfilesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists storage profiles for a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStorageProfilesForQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListStorageProfilesForQueueResponse> ListStorageProfilesForQueueAsync(ListStorageProfilesForQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists tasks for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListTasksResponse> ListTasksAsync(ListTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<ListWorkersResponse> ListWorkersAsync(ListWorkersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Adds a metered product.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMeteredProduct service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutMeteredProductResponse> PutMeteredProductAsync(PutMeteredProductRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Searches for jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SearchJobsResponse> SearchJobsAsync(SearchJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Searches for steps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SearchStepsResponse> SearchStepsAsync(SearchStepsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Searches for tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SearchTasksResponse> SearchTasksAsync(SearchTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Searches for workers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchWorkers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<SearchWorkersResponse> SearchWorkersAsync(SearchWorkersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Starts an asynchronous request for getting aggregated statistics about queues and
        /// farms. Get the statistics using the <c>GetSessionsStatisticsAggregation</c> operation.
        /// You can only have one running aggregation for your Deadline Cloud farm. Call the <c>GetSessionsStatisticsAggregation</c>
        /// operation and check the <c>status</c> field to see if an aggregation is running. Statistics
        /// are available for 1 hour after you call the <c>StartSessionsStatisticsAggregation</c>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSessionsStatisticsAggregation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<StartSessionsStatisticsAggregationResponse> StartSessionsStatisticsAggregationAsync(StartSessionsStatisticsAggregationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Tags a resource using the resource's ARN and desired tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Removes a tag from a resource using the resource's ARN and tag to remove.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a budget that sets spending thresholds for rendering activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBudget service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateBudgetResponse> UpdateBudgetAsync(UpdateBudgetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a farm.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFarm service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateFarmResponse> UpdateFarmAsync(UpdateFarmRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateFleetResponse> UpdateFleetAsync(UpdateFleetRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLimit


        /// <summary>
        /// Updates the properties of the specified limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLimit service method.</param>
        /// 
        /// <returns>The response from the UpdateLimit service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateLimit">REST API Reference for UpdateLimit Operation</seealso>
        UpdateLimitResponse UpdateLimit(UpdateLimitRequest request);



        /// <summary>
        /// Updates the properties of the specified limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLimit service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateLimit">REST API Reference for UpdateLimit Operation</seealso>
        Task<UpdateLimitResponse> UpdateLimitAsync(UpdateLimitRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Modifies the settings for a Deadline Cloud monitor. You can modify one or all of the
        /// settings when you call <c>UpdateMonitor</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMonitor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateMonitorResponse> UpdateMonitorAsync(UpdateMonitorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateQueueResponse> UpdateQueueAsync(UpdateQueueRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the queue environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateQueueEnvironmentResponse> UpdateQueueEnvironmentAsync(UpdateQueueEnvironmentRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a queue-fleet association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueFleetAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateQueueFleetAssociationResponse> UpdateQueueFleetAssociationAsync(UpdateQueueFleetAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateQueueLimitAssociation


        /// <summary>
        /// Updates the status of the queue. If you set the status to one of the <c>STOP_LIMIT_USAGE*</c>
        /// values, there will be a delay before the status transitions to the <c>STOPPED</c>
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueLimitAssociation service method.</param>
        /// 
        /// <returns>The response from the UpdateQueueLimitAssociation service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueLimitAssociation">REST API Reference for UpdateQueueLimitAssociation Operation</seealso>
        UpdateQueueLimitAssociationResponse UpdateQueueLimitAssociation(UpdateQueueLimitAssociationRequest request);



        /// <summary>
        /// Updates the status of the queue. If you set the status to one of the <c>STOP_LIMIT_USAGE*</c>
        /// values, there will be a delay before the status transitions to the <c>STOPPED</c>
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueueLimitAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueueLimitAssociation service method, as returned by Deadline.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/deadline-2023-10-12/UpdateQueueLimitAssociation">REST API Reference for UpdateQueueLimitAssociation Operation</seealso>
        Task<UpdateQueueLimitAssociationResponse> UpdateQueueLimitAssociationAsync(UpdateQueueLimitAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateSessionResponse> UpdateSessionAsync(UpdateSessionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateStepResponse> UpdateStepAsync(UpdateStepRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a storage profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStorageProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateStorageProfileResponse> UpdateStorageProfileAsync(UpdateStorageProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateTaskResponse> UpdateTaskAsync(UpdateTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorker service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateWorkerResponse> UpdateWorkerAsync(UpdateWorkerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Updates the schedule for a worker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkerSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<UpdateWorkerScheduleResponse> UpdateWorkerScheduleAsync(UpdateWorkerScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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