/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoT.Model;

namespace Amazon.IoT
{
    /// <summary>
    /// Interface for accessing IoT
    ///
    /// AWS IoT 
    /// <para>
    /// AWS IoT provides secure, bi-directional communication between Internet-connected devices
    /// (such as sensors, actuators, embedded devices, or smart appliances) and the AWS cloud.
    /// You can discover your custom IoT-Data endpoint to communicate with, configure rules
    /// for data processing and integration with other services, organize resources associated
    /// with each device (Registry), configure logging, and create and manage policies and
    /// credentials to authenticate devices.
    /// </para>
    ///  
    /// <para>
    /// For more information about how AWS IoT works, see the <a href="http://docs.aws.amazon.com/iot/latest/developerguide/aws-iot-how-it-works.html">Developer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIoT : IAmazonService, IDisposable
    {

        
        #region  AcceptCertificateTransfer


        /// <summary>
        /// Accepts a pending certificate transfer. The default state of the certificate is INACTIVE.
        /// 
        ///  
        /// <para>
        /// To check for pending certificate transfers, call <a>ListCertificates</a> to enumerate
        /// your certificates.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptCertificateTransfer service method.</param>
        /// 
        /// <returns>The response from the AcceptCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AcceptCertificateTransfer">REST API Reference for AcceptCertificateTransfer Operation</seealso>
        AcceptCertificateTransferResponse AcceptCertificateTransfer(AcceptCertificateTransferRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptCertificateTransfer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AcceptCertificateTransfer">REST API Reference for AcceptCertificateTransfer Operation</seealso>
        Task<AcceptCertificateTransferResponse> AcceptCertificateTransferAsync(AcceptCertificateTransferRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AddThingToThingGroup


        /// <summary>
        /// Adds a thing to a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddThingToThingGroup service method.</param>
        /// 
        /// <returns>The response from the AddThingToThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToThingGroup">REST API Reference for AddThingToThingGroup Operation</seealso>
        AddThingToThingGroupResponse AddThingToThingGroup(AddThingToThingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddThingToThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddThingToThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToThingGroup">REST API Reference for AddThingToThingGroup Operation</seealso>
        Task<AddThingToThingGroupResponse> AddThingToThingGroupAsync(AddThingToThingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateTargetsWithJob


        /// <summary>
        /// Associates a group with a continuous job. The following criteria must be met: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The job must have been created with the <code>targetSelection</code> field set to
        /// "CONTINUOUS".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The job status must currently be "IN_PROGRESS".
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total number of targets associated with a job must not exceed 100.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTargetsWithJob service method.</param>
        /// 
        /// <returns>The response from the AssociateTargetsWithJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AssociateTargetsWithJob">REST API Reference for AssociateTargetsWithJob Operation</seealso>
        AssociateTargetsWithJobResponse AssociateTargetsWithJob(AssociateTargetsWithJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTargetsWithJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTargetsWithJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AssociateTargetsWithJob">REST API Reference for AssociateTargetsWithJob Operation</seealso>
        Task<AssociateTargetsWithJobResponse> AssociateTargetsWithJobAsync(AssociateTargetsWithJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachPolicy


        /// <summary>
        /// Attaches a policy to the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        AttachPolicyResponse AttachPolicy(AttachPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachPrincipalPolicy


        /// <summary>
        /// Attaches the specified policy to the specified principal (certificate or other credential).
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>AttachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="principal">The principal, which can be a certificate ARN (as returned from the CreateCertificate operation) or an Amazon Cognito ID.</param>
        /// 
        /// <returns>The response from the AttachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPrincipalPolicy">REST API Reference for AttachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of AttachPolicy.")]
        AttachPrincipalPolicyResponse AttachPrincipalPolicy(string policyName, string principal);

        /// <summary>
        /// Attaches the specified policy to the specified principal (certificate or other credential).
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>AttachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachPrincipalPolicy service method.</param>
        /// 
        /// <returns>The response from the AttachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPrincipalPolicy">REST API Reference for AttachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of AttachPolicy.")]
        AttachPrincipalPolicyResponse AttachPrincipalPolicy(AttachPrincipalPolicyRequest request);


        /// <summary>
        /// Attaches the specified policy to the specified principal (certificate or other credential).
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>AttachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="principal">The principal, which can be a certificate ARN (as returned from the CreateCertificate operation) or an Amazon Cognito ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPrincipalPolicy">REST API Reference for AttachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of AttachPolicy.")]
        Task<AttachPrincipalPolicyResponse> AttachPrincipalPolicyAsync(string policyName, string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the AttachPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPrincipalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPrincipalPolicy">REST API Reference for AttachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of AttachPolicy.")]
        Task<AttachPrincipalPolicyResponse> AttachPrincipalPolicyAsync(AttachPrincipalPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AttachThingPrincipal


        /// <summary>
        /// Attaches the specified principal to the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="principal">The principal, such as a certificate or other credential.</param>
        /// 
        /// <returns>The response from the AttachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachThingPrincipal">REST API Reference for AttachThingPrincipal Operation</seealso>
        AttachThingPrincipalResponse AttachThingPrincipal(string thingName, string principal);

        /// <summary>
        /// Attaches the specified principal to the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachThingPrincipal service method.</param>
        /// 
        /// <returns>The response from the AttachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachThingPrincipal">REST API Reference for AttachThingPrincipal Operation</seealso>
        AttachThingPrincipalResponse AttachThingPrincipal(AttachThingPrincipalRequest request);


        /// <summary>
        /// Attaches the specified principal to the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="principal">The principal, such as a certificate or other credential.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AttachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachThingPrincipal">REST API Reference for AttachThingPrincipal Operation</seealso>
        Task<AttachThingPrincipalResponse> AttachThingPrincipalAsync(string thingName, string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the AttachThingPrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachThingPrincipal operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachThingPrincipal">REST API Reference for AttachThingPrincipal Operation</seealso>
        Task<AttachThingPrincipalResponse> AttachThingPrincipalAsync(AttachThingPrincipalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelCertificateTransfer


        /// <summary>
        /// Cancels a pending transfer for the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> Only the transfer source account can use this operation to cancel a transfer.
        /// (Transfer destinations can use <a>RejectCertificateTransfer</a> instead.) After transfer,
        /// AWS IoT returns the certificate to the source account in the INACTIVE state. After
        /// the destination account has accepted the transfer, the transfer cannot be cancelled.
        /// </para>
        ///  
        /// <para>
        /// After a certificate transfer is cancelled, the status of the certificate changes from
        /// PENDING_TRANSFER to INACTIVE.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// 
        /// <returns>The response from the CancelCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelCertificateTransfer">REST API Reference for CancelCertificateTransfer Operation</seealso>
        CancelCertificateTransferResponse CancelCertificateTransfer(string certificateId);

        /// <summary>
        /// Cancels a pending transfer for the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> Only the transfer source account can use this operation to cancel a transfer.
        /// (Transfer destinations can use <a>RejectCertificateTransfer</a> instead.) After transfer,
        /// AWS IoT returns the certificate to the source account in the INACTIVE state. After
        /// the destination account has accepted the transfer, the transfer cannot be cancelled.
        /// </para>
        ///  
        /// <para>
        /// After a certificate transfer is cancelled, the status of the certificate changes from
        /// PENDING_TRANSFER to INACTIVE.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelCertificateTransfer service method.</param>
        /// 
        /// <returns>The response from the CancelCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelCertificateTransfer">REST API Reference for CancelCertificateTransfer Operation</seealso>
        CancelCertificateTransferResponse CancelCertificateTransfer(CancelCertificateTransferRequest request);


        /// <summary>
        /// Cancels a pending transfer for the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> Only the transfer source account can use this operation to cancel a transfer.
        /// (Transfer destinations can use <a>RejectCertificateTransfer</a> instead.) After transfer,
        /// AWS IoT returns the certificate to the source account in the INACTIVE state. After
        /// the destination account has accepted the transfer, the transfer cannot be cancelled.
        /// </para>
        ///  
        /// <para>
        /// After a certificate transfer is cancelled, the status of the certificate changes from
        /// PENDING_TRANSFER to INACTIVE.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelCertificateTransfer">REST API Reference for CancelCertificateTransfer Operation</seealso>
        Task<CancelCertificateTransferResponse> CancelCertificateTransferAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CancelCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelCertificateTransfer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelCertificateTransfer">REST API Reference for CancelCertificateTransfer Operation</seealso>
        Task<CancelCertificateTransferResponse> CancelCertificateTransferAsync(CancelCertificateTransferRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelJob


        /// <summary>
        /// Cancels a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJob">REST API Reference for CancelJob Operation</seealso>
        CancelJobResponse CancelJob(CancelJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJob">REST API Reference for CancelJob Operation</seealso>
        Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelJobExecution


        /// <summary>
        /// Cancels the execution of a job for a given thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJobExecution service method.</param>
        /// 
        /// <returns>The response from the CancelJobExecution service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidStateTransitionException">
        /// An attempt was made to change to an invalid state, for example by deleting a job or
        /// a job execution which is "IN_PROGRESS" without setting the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJobExecution">REST API Reference for CancelJobExecution Operation</seealso>
        CancelJobExecutionResponse CancelJobExecution(CancelJobExecutionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CancelJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJobExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJobExecution">REST API Reference for CancelJobExecution Operation</seealso>
        Task<CancelJobExecutionResponse> CancelJobExecutionAsync(CancelJobExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ClearDefaultAuthorizer


        /// <summary>
        /// Clears the default authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClearDefaultAuthorizer service method.</param>
        /// 
        /// <returns>The response from the ClearDefaultAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ClearDefaultAuthorizer">REST API Reference for ClearDefaultAuthorizer Operation</seealso>
        ClearDefaultAuthorizerResponse ClearDefaultAuthorizer(ClearDefaultAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ClearDefaultAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ClearDefaultAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ClearDefaultAuthorizer">REST API Reference for ClearDefaultAuthorizer Operation</seealso>
        Task<ClearDefaultAuthorizerResponse> ClearDefaultAuthorizerAsync(ClearDefaultAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateAuthorizer


        /// <summary>
        /// Creates an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the CreateAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        Task<CreateAuthorizerResponse> CreateAuthorizerAsync(CreateAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCertificateFromCsr


        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256 or NIST P-384 curves. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// You can create multiple certificates in a batch by creating a directory, copying multiple
        /// .csr files into that directory, and then specifying that directory on the command
        /// line. The following commands show how to create a batch of certificates given a batch
        /// of CSRs.
        /// </para>
        ///  
        /// <para>
        /// Assuming a set of CSRs are located inside of the directory my-csr-directory:
        /// </para>
        ///  
        /// <para>
        /// On Linux and OS X, the command is:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
        /// to the aws iot create-certificate-from-csr AWS CLI command to create a certificate
        /// for the corresponding CSR.
        /// </para>
        ///  
        /// <para>
        /// The aws iot create-certificate-from-csr part of the command can also be run in parallel
        /// to speed up the certificate creation process:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/$_}
        /// </para>
        ///  
        /// <para>
        /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr --certificate-signing-request
        /// file://@path"
        /// </para>
        /// </summary>
        /// <param name="certificateSigningRequest">The certificate signing request (CSR).</param>
        /// 
        /// <returns>The response from the CreateCertificateFromCsr service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        CreateCertificateFromCsrResponse CreateCertificateFromCsr(string certificateSigningRequest);

        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256 or NIST P-384 curves. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// You can create multiple certificates in a batch by creating a directory, copying multiple
        /// .csr files into that directory, and then specifying that directory on the command
        /// line. The following commands show how to create a batch of certificates given a batch
        /// of CSRs.
        /// </para>
        ///  
        /// <para>
        /// Assuming a set of CSRs are located inside of the directory my-csr-directory:
        /// </para>
        ///  
        /// <para>
        /// On Linux and OS X, the command is:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
        /// to the aws iot create-certificate-from-csr AWS CLI command to create a certificate
        /// for the corresponding CSR.
        /// </para>
        ///  
        /// <para>
        /// The aws iot create-certificate-from-csr part of the command can also be run in parallel
        /// to speed up the certificate creation process:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/$_}
        /// </para>
        ///  
        /// <para>
        /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr --certificate-signing-request
        /// file://@path"
        /// </para>
        /// </summary>
        /// <param name="certificateSigningRequest">The certificate signing request (CSR).</param>
        /// <param name="setAsActive">Specifies whether the certificate is active.</param>
        /// 
        /// <returns>The response from the CreateCertificateFromCsr service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        CreateCertificateFromCsrResponse CreateCertificateFromCsr(string certificateSigningRequest, bool setAsActive);

        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256 or NIST P-384 curves. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// You can create multiple certificates in a batch by creating a directory, copying multiple
        /// .csr files into that directory, and then specifying that directory on the command
        /// line. The following commands show how to create a batch of certificates given a batch
        /// of CSRs.
        /// </para>
        ///  
        /// <para>
        /// Assuming a set of CSRs are located inside of the directory my-csr-directory:
        /// </para>
        ///  
        /// <para>
        /// On Linux and OS X, the command is:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
        /// to the aws iot create-certificate-from-csr AWS CLI command to create a certificate
        /// for the corresponding CSR.
        /// </para>
        ///  
        /// <para>
        /// The aws iot create-certificate-from-csr part of the command can also be run in parallel
        /// to speed up the certificate creation process:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/$_}
        /// </para>
        ///  
        /// <para>
        /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr --certificate-signing-request
        /// file://@path"
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateFromCsr service method.</param>
        /// 
        /// <returns>The response from the CreateCertificateFromCsr service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        CreateCertificateFromCsrResponse CreateCertificateFromCsr(CreateCertificateFromCsrRequest request);


        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256 or NIST P-384 curves. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// You can create multiple certificates in a batch by creating a directory, copying multiple
        /// .csr files into that directory, and then specifying that directory on the command
        /// line. The following commands show how to create a batch of certificates given a batch
        /// of CSRs.
        /// </para>
        ///  
        /// <para>
        /// Assuming a set of CSRs are located inside of the directory my-csr-directory:
        /// </para>
        ///  
        /// <para>
        /// On Linux and OS X, the command is:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
        /// to the aws iot create-certificate-from-csr AWS CLI command to create a certificate
        /// for the corresponding CSR.
        /// </para>
        ///  
        /// <para>
        /// The aws iot create-certificate-from-csr part of the command can also be run in parallel
        /// to speed up the certificate creation process:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/$_}
        /// </para>
        ///  
        /// <para>
        /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr --certificate-signing-request
        /// file://@path"
        /// </para>
        /// </summary>
        /// <param name="certificateSigningRequest">The certificate signing request (CSR).</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCertificateFromCsr service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        Task<CreateCertificateFromCsrResponse> CreateCertificateFromCsrAsync(string certificateSigningRequest, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256 or NIST P-384 curves. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// You can create multiple certificates in a batch by creating a directory, copying multiple
        /// .csr files into that directory, and then specifying that directory on the command
        /// line. The following commands show how to create a batch of certificates given a batch
        /// of CSRs.
        /// </para>
        ///  
        /// <para>
        /// Assuming a set of CSRs are located inside of the directory my-csr-directory:
        /// </para>
        ///  
        /// <para>
        /// On Linux and OS X, the command is:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
        /// to the aws iot create-certificate-from-csr AWS CLI command to create a certificate
        /// for the corresponding CSR.
        /// </para>
        ///  
        /// <para>
        /// The aws iot create-certificate-from-csr part of the command can also be run in parallel
        /// to speed up the certificate creation process:
        /// </para>
        ///  
        /// <para>
        /// $ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/{}
        /// </para>
        ///  
        /// <para>
        /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
        /// file://my-csr-directory/$_}
        /// </para>
        ///  
        /// <para>
        /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
        /// is:
        /// </para>
        ///  
        /// <para>
        /// &gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr --certificate-signing-request
        /// file://@path"
        /// </para>
        /// </summary>
        /// <param name="certificateSigningRequest">The certificate signing request (CSR).</param>
        /// <param name="setAsActive">Specifies whether the certificate is active.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCertificateFromCsr service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        Task<CreateCertificateFromCsrResponse> CreateCertificateFromCsrAsync(string certificateSigningRequest, bool setAsActive, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCertificateFromCsr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateFromCsr operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        Task<CreateCertificateFromCsrResponse> CreateCertificateFromCsrAsync(CreateCertificateFromCsrRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Creates a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse CreateJob(CreateJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateJob">REST API Reference for CreateJob Operation</seealso>
        Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateKeysAndCertificate


        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateKeysAndCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        CreateKeysAndCertificateResponse CreateKeysAndCertificate();

        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// <param name="setAsActive">Specifies whether the certificate is active.</param>
        /// 
        /// <returns>The response from the CreateKeysAndCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        CreateKeysAndCertificateResponse CreateKeysAndCertificate(bool setAsActive);

        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeysAndCertificate service method.</param>
        /// 
        /// <returns>The response from the CreateKeysAndCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        CreateKeysAndCertificateResponse CreateKeysAndCertificate(CreateKeysAndCertificateRequest request);


        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeysAndCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        Task<CreateKeysAndCertificateResponse> CreateKeysAndCertificateAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time AWS IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        /// </summary>
        /// <param name="setAsActive">Specifies whether the certificate is active.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateKeysAndCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        Task<CreateKeysAndCertificateResponse> CreateKeysAndCertificateAsync(bool setAsActive, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeysAndCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeysAndCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        Task<CreateKeysAndCertificateResponse> CreateKeysAndCertificateAsync(CreateKeysAndCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateOTAUpdate


        /// <summary>
        /// Creates an AWS IoT OTAUpdate on a target group of things or groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOTAUpdate service method.</param>
        /// 
        /// <returns>The response from the CreateOTAUpdate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateOTAUpdate">REST API Reference for CreateOTAUpdate Operation</seealso>
        CreateOTAUpdateResponse CreateOTAUpdate(CreateOTAUpdateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOTAUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateOTAUpdate">REST API Reference for CreateOTAUpdate Operation</seealso>
        Task<CreateOTAUpdateResponse> CreateOTAUpdateAsync(CreateOTAUpdateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Creates an AWS IoT policy.
        /// 
        ///  
        /// <para>
        /// The created policy is the default version for the policy. This operation creates a
        /// policy version with a version identifier of <b>1</b> and sets <b>1</b> as the policy's
        /// default version.
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. <b>policyDocument</b> must have a minimum length of 1, with a maximum length of 2048, excluding whitespace.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        CreatePolicyResponse CreatePolicy(string policyName, string policyDocument);

        /// <summary>
        /// Creates an AWS IoT policy.
        /// 
        ///  
        /// <para>
        /// The created policy is the default version for the policy. This operation creates a
        /// policy version with a version identifier of <b>1</b> and sets <b>1</b> as the policy's
        /// default version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy service method.</param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        CreatePolicyResponse CreatePolicy(CreatePolicyRequest request);


        /// <summary>
        /// Creates an AWS IoT policy.
        /// 
        ///  
        /// <para>
        /// The created policy is the default version for the policy. This operation creates a
        /// policy version with a version identifier of <b>1</b> and sets <b>1</b> as the policy's
        /// default version.
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. <b>policyDocument</b> must have a minimum length of 1, with a maximum length of 2048, excluding whitespace.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        Task<CreatePolicyResponse> CreatePolicyAsync(string policyName, string policyDocument, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePolicyVersion


        /// <summary>
        /// Creates a new version of the specified AWS IoT policy. To update a policy, create
        /// a new policy version. A managed policy can have up to five versions. If the policy
        /// has five versions, you must use <a>DeletePolicyVersion</a> to delete an existing version
        /// before you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. Minimum length of 1. Maximum length of 2048, excluding whitespace.</param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionsLimitExceededException">
        /// The number of policy versions exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        CreatePolicyVersionResponse CreatePolicyVersion(string policyName, string policyDocument);

        /// <summary>
        /// Creates a new version of the specified AWS IoT policy. To update a policy, create
        /// a new policy version. A managed policy can have up to five versions. If the policy
        /// has five versions, you must use <a>DeletePolicyVersion</a> to delete an existing version
        /// before you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. Minimum length of 1. Maximum length of 2048, excluding whitespace.</param>
        /// <param name="setAsDefault">Specifies whether the policy version is set as the default. When this parameter is true, the new policy version becomes the operative version (that is, the version that is in effect for the certificates to which the policy is attached).</param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionsLimitExceededException">
        /// The number of policy versions exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        CreatePolicyVersionResponse CreatePolicyVersion(string policyName, string policyDocument, bool setAsDefault);

        /// <summary>
        /// Creates a new version of the specified AWS IoT policy. To update a policy, create
        /// a new policy version. A managed policy can have up to five versions. If the policy
        /// has five versions, you must use <a>DeletePolicyVersion</a> to delete an existing version
        /// before you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion service method.</param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionsLimitExceededException">
        /// The number of policy versions exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        CreatePolicyVersionResponse CreatePolicyVersion(CreatePolicyVersionRequest request);


        /// <summary>
        /// Creates a new version of the specified AWS IoT policy. To update a policy, create
        /// a new policy version. A managed policy can have up to five versions. If the policy
        /// has five versions, you must use <a>DeletePolicyVersion</a> to delete an existing version
        /// before you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. Minimum length of 1. Maximum length of 2048, excluding whitespace.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionsLimitExceededException">
        /// The number of policy versions exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(string policyName, string policyDocument, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a new version of the specified AWS IoT policy. To update a policy, create
        /// a new policy version. A managed policy can have up to five versions. If the policy
        /// has five versions, you must use <a>DeletePolicyVersion</a> to delete an existing version
        /// before you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyDocument">The JSON document that describes the policy. Minimum length of 1. Maximum length of 2048, excluding whitespace.</param>
        /// <param name="setAsDefault">Specifies whether the policy version is set as the default. When this parameter is true, the new policy version becomes the operative version (that is, the version that is in effect for the certificates to which the policy is attached).</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.MalformedPolicyException">
        /// The policy documentation is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionsLimitExceededException">
        /// The number of policy versions exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(string policyName, string policyDocument, bool setAsDefault, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        Task<CreatePolicyVersionResponse> CreatePolicyVersionAsync(CreatePolicyVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRoleAlias


        /// <summary>
        /// Creates a role alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoleAlias service method.</param>
        /// 
        /// <returns>The response from the CreateRoleAlias service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateRoleAlias">REST API Reference for CreateRoleAlias Operation</seealso>
        CreateRoleAliasResponse CreateRoleAlias(CreateRoleAliasRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoleAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateRoleAlias">REST API Reference for CreateRoleAlias Operation</seealso>
        Task<CreateRoleAliasResponse> CreateRoleAliasAsync(CreateRoleAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateStream


        /// <summary>
        /// Creates a stream for delivering one or more large files in chunks over MQTT. A stream
        /// transports data bytes in chunks or blocks packaged as MQTT messages from a source
        /// like S3. You can have one or more files associated with a stream. The total size of
        /// a file associated with the stream cannot exceed more than 2 MB. The stream will be
        /// created with version 0. If a stream is created with the same streamID as a stream
        /// that existed and was deleted within last 90 days, we will resurrect that old stream
        /// by incrementing the version by 1.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStream service method.</param>
        /// 
        /// <returns>The response from the CreateStream service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateStream">REST API Reference for CreateStream Operation</seealso>
        CreateStreamResponse CreateStream(CreateStreamRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateStream">REST API Reference for CreateStream Operation</seealso>
        Task<CreateStreamResponse> CreateStreamAsync(CreateStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateThing


        /// <summary>
        /// Creates a thing record in the registry.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThing service method.</param>
        /// 
        /// <returns>The response from the CreateThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThing">REST API Reference for CreateThing Operation</seealso>
        CreateThingResponse CreateThing(CreateThingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThing">REST API Reference for CreateThing Operation</seealso>
        Task<CreateThingResponse> CreateThingAsync(CreateThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateThingGroup


        /// <summary>
        /// Create a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingGroup">REST API Reference for CreateThingGroup Operation</seealso>
        CreateThingGroupResponse CreateThingGroup(CreateThingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingGroup">REST API Reference for CreateThingGroup Operation</seealso>
        Task<CreateThingGroupResponse> CreateThingGroupAsync(CreateThingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateThingType


        /// <summary>
        /// Creates a new thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateThingType service method.</param>
        /// 
        /// <returns>The response from the CreateThingType service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingType">REST API Reference for CreateThingType Operation</seealso>
        CreateThingTypeResponse CreateThingType(CreateThingTypeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateThingType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateThingType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingType">REST API Reference for CreateThingType Operation</seealso>
        Task<CreateThingTypeResponse> CreateThingTypeAsync(CreateThingTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTopicRule


        /// <summary>
        /// Creates a rule. Creating rules is an administrator-level action. Any user who has
        /// permission to create rules will be able to access data processed by the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRule service method.</param>
        /// 
        /// <returns>The response from the CreateTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.SqlParseException">
        /// The Rule-SQL expression can't be parsed correctly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateTopicRule">REST API Reference for CreateTopicRule Operation</seealso>
        CreateTopicRuleResponse CreateTopicRule(CreateTopicRuleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateTopicRule">REST API Reference for CreateTopicRule Operation</seealso>
        Task<CreateTopicRuleResponse> CreateTopicRuleAsync(CreateTopicRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteAuthorizer


        /// <summary>
        /// Deletes an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DeleteAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        Task<DeleteAuthorizerResponse> DeleteAuthorizerAsync(DeleteAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCACertificate


        /// <summary>
        /// Deletes a registered CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCACertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCACertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCACertificate">REST API Reference for DeleteCACertificate Operation</seealso>
        DeleteCACertificateResponse DeleteCACertificate(DeleteCACertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCACertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCACertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCACertificate">REST API Reference for DeleteCACertificate Operation</seealso>
        Task<DeleteCACertificateResponse> DeleteCACertificateAsync(DeleteCACertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCertificate


        /// <summary>
        /// Deletes the specified certificate.
        /// 
        ///  
        /// <para>
        /// A certificate cannot be deleted if it has a policy attached to it or if its status
        /// is set to ACTIVE. To delete a certificate, first use the <a>DetachPrincipalPolicy</a>
        /// API to detach all policies. Next, use the <a>UpdateCertificate</a> API to set the
        /// certificate to the INACTIVE status.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        DeleteCertificateResponse DeleteCertificate(string certificateId);

        /// <summary>
        /// Deletes the specified certificate.
        /// 
        ///  
        /// <para>
        /// A certificate cannot be deleted if it has a policy attached to it or if its status
        /// is set to ACTIVE. To delete a certificate, first use the <a>DetachPrincipalPolicy</a>
        /// API to detach all policies. Next, use the <a>UpdateCertificate</a> API to set the
        /// certificate to the INACTIVE status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request);


        /// <summary>
        /// Deletes the specified certificate.
        /// 
        ///  
        /// <para>
        /// A certificate cannot be deleted if it has a policy attached to it or if its status
        /// is set to ACTIVE. To delete a certificate, first use the <a>DetachPrincipalPolicy</a>
        /// API to detach all policies. Next, use the <a>UpdateCertificate</a> API to set the
        /// certificate to the INACTIVE status.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        Task<DeleteCertificateResponse> DeleteCertificateAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteJob


        /// <summary>
        /// Deletes a job and its related job executions.
        /// 
        ///  
        /// <para>
        /// Deleting a job may take time, depending on the number of job executions created for
        /// the job and various other factors. While the job is being deleted, the status of the
        /// job will be shown as "DELETION_IN_PROGRESS". Attempting to delete or cancel a job
        /// whose status is already "DELETION_IN_PROGRESS" will result in an error.
        /// </para>
        ///  
        /// <para>
        /// Only 10 jobs may have status "DELETION_IN_PROGRESS" at the same time, or a LimitExceededException
        /// will occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob service method.</param>
        /// 
        /// <returns>The response from the DeleteJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidStateTransitionException">
        /// An attempt was made to change to an invalid state, for example by deleting a job or
        /// a job execution which is "IN_PROGRESS" without setting the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        DeleteJobResponse DeleteJob(DeleteJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteJobExecution


        /// <summary>
        /// Deletes a job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobExecution service method.</param>
        /// 
        /// <returns>The response from the DeleteJobExecution service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidStateTransitionException">
        /// An attempt was made to change to an invalid state, for example by deleting a job or
        /// a job execution which is "IN_PROGRESS" without setting the <code>force</code> parameter.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJobExecution">REST API Reference for DeleteJobExecution Operation</seealso>
        DeleteJobExecutionResponse DeleteJobExecution(DeleteJobExecutionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJobExecution">REST API Reference for DeleteJobExecution Operation</seealso>
        Task<DeleteJobExecutionResponse> DeleteJobExecutionAsync(DeleteJobExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteOTAUpdate


        /// <summary>
        /// Delete an OTA update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOTAUpdate service method.</param>
        /// 
        /// <returns>The response from the DeleteOTAUpdate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteOTAUpdate">REST API Reference for DeleteOTAUpdate Operation</seealso>
        DeleteOTAUpdateResponse DeleteOTAUpdate(DeleteOTAUpdateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOTAUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteOTAUpdate">REST API Reference for DeleteOTAUpdate Operation</seealso>
        Task<DeleteOTAUpdateResponse> DeleteOTAUpdateAsync(DeleteOTAUpdateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePolicy


        /// <summary>
        /// Deletes the specified policy.
        /// 
        ///  
        /// <para>
        /// A policy cannot be deleted if it has non-default versions or it is attached to any
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// To delete a policy, use the DeletePolicyVersion API to delete all non-default versions
        /// of the policy; use the DetachPrincipalPolicy API to detach the policy from any certificate;
        /// and then use the DeletePolicy API to delete the policy.
        /// </para>
        ///  
        /// <para>
        /// When a policy is deleted using DeletePolicy, its default version is deleted with it.
        /// </para>
        /// </summary>
        /// <param name="policyName">The name of the policy to delete.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse DeletePolicy(string policyName);

        /// <summary>
        /// Deletes the specified policy.
        /// 
        ///  
        /// <para>
        /// A policy cannot be deleted if it has non-default versions or it is attached to any
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// To delete a policy, use the DeletePolicyVersion API to delete all non-default versions
        /// of the policy; use the DetachPrincipalPolicy API to detach the policy from any certificate;
        /// and then use the DeletePolicy API to delete the policy.
        /// </para>
        ///  
        /// <para>
        /// When a policy is deleted using DeletePolicy, its default version is deleted with it.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy service method.</param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse DeletePolicy(DeletePolicyRequest request);


        /// <summary>
        /// Deletes the specified policy.
        /// 
        ///  
        /// <para>
        /// A policy cannot be deleted if it has non-default versions or it is attached to any
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// To delete a policy, use the DeletePolicyVersion API to delete all non-default versions
        /// of the policy; use the DetachPrincipalPolicy API to detach the policy from any certificate;
        /// and then use the DeletePolicy API to delete the policy.
        /// </para>
        ///  
        /// <para>
        /// When a policy is deleted using DeletePolicy, its default version is deleted with it.
        /// </para>
        /// </summary>
        /// <param name="policyName">The name of the policy to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        Task<DeletePolicyResponse> DeletePolicyAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeletePolicyVersion


        /// <summary>
        /// Deletes the specified version of the specified policy. You cannot delete the default
        /// version of a policy using this API. To delete the default version of a policy, use
        /// <a>DeletePolicy</a>. To find out which version of a policy is marked as the default
        /// version, use ListPolicyVersions.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// 
        /// <returns>The response from the DeletePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        DeletePolicyVersionResponse DeletePolicyVersion(string policyName, string policyVersionId);

        /// <summary>
        /// Deletes the specified version of the specified policy. You cannot delete the default
        /// version of a policy using this API. To delete the default version of a policy, use
        /// <a>DeletePolicy</a>. To find out which version of a policy is marked as the default
        /// version, use ListPolicyVersions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion service method.</param>
        /// 
        /// <returns>The response from the DeletePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        DeletePolicyVersionResponse DeletePolicyVersion(DeletePolicyVersionRequest request);


        /// <summary>
        /// Deletes the specified version of the specified policy. You cannot delete the default
        /// version of a policy using this API. To delete the default version of a policy, use
        /// <a>DeletePolicy</a>. To find out which version of a policy is marked as the default
        /// version, use ListPolicyVersions.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(string policyName, string policyVersionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        Task<DeletePolicyVersionResponse> DeletePolicyVersionAsync(DeletePolicyVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRegistrationCode


        /// <summary>
        /// Deletes a CA certificate registration code.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistrationCode service method.</param>
        /// 
        /// <returns>The response from the DeleteRegistrationCode service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRegistrationCode">REST API Reference for DeleteRegistrationCode Operation</seealso>
        DeleteRegistrationCodeResponse DeleteRegistrationCode(DeleteRegistrationCodeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRegistrationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistrationCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRegistrationCode">REST API Reference for DeleteRegistrationCode Operation</seealso>
        Task<DeleteRegistrationCodeResponse> DeleteRegistrationCodeAsync(DeleteRegistrationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRoleAlias


        /// <summary>
        /// Deletes a role alias
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteRoleAlias service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRoleAlias">REST API Reference for DeleteRoleAlias Operation</seealso>
        DeleteRoleAliasResponse DeleteRoleAlias(DeleteRoleAliasRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRoleAlias">REST API Reference for DeleteRoleAlias Operation</seealso>
        Task<DeleteRoleAliasResponse> DeleteRoleAliasAsync(DeleteRoleAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteStream


        /// <summary>
        /// Deletes a stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream service method.</param>
        /// 
        /// <returns>The response from the DeleteStream service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.DeleteConflictException">
        /// You can't delete the resource because it is attached to one or more resources.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        DeleteStreamResponse DeleteStream(DeleteStreamRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        Task<DeleteStreamResponse> DeleteStreamAsync(DeleteStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteThing


        /// <summary>
        /// Deletes the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing to delete.</param>
        /// 
        /// <returns>The response from the DeleteThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThing">REST API Reference for DeleteThing Operation</seealso>
        DeleteThingResponse DeleteThing(string thingName);

        /// <summary>
        /// Deletes the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThing service method.</param>
        /// 
        /// <returns>The response from the DeleteThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThing">REST API Reference for DeleteThing Operation</seealso>
        DeleteThingResponse DeleteThing(DeleteThingRequest request);


        /// <summary>
        /// Deletes the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThing">REST API Reference for DeleteThing Operation</seealso>
        Task<DeleteThingResponse> DeleteThingAsync(string thingName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThing">REST API Reference for DeleteThing Operation</seealso>
        Task<DeleteThingResponse> DeleteThingAsync(DeleteThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteThingGroup


        /// <summary>
        /// Deletes a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingGroup">REST API Reference for DeleteThingGroup Operation</seealso>
        DeleteThingGroupResponse DeleteThingGroup(DeleteThingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingGroup">REST API Reference for DeleteThingGroup Operation</seealso>
        Task<DeleteThingGroupResponse> DeleteThingGroupAsync(DeleteThingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteThingType


        /// <summary>
        /// Deletes the specified thing type . You cannot delete a thing type if it has things
        /// associated with it. To delete a thing type, first mark it as deprecated by calling
        /// <a>DeprecateThingType</a>, then remove any associated things by calling <a>UpdateThing</a>
        /// to change the thing type on any associated thing, and finally use <a>DeleteThingType</a>
        /// to delete the thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingType service method.</param>
        /// 
        /// <returns>The response from the DeleteThingType service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingType">REST API Reference for DeleteThingType Operation</seealso>
        DeleteThingTypeResponse DeleteThingType(DeleteThingTypeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThingType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingType">REST API Reference for DeleteThingType Operation</seealso>
        Task<DeleteThingTypeResponse> DeleteThingTypeAsync(DeleteThingTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTopicRule


        /// <summary>
        /// Deletes the rule.
        /// </summary>
        /// <param name="ruleName">The name of the rule.</param>
        /// 
        /// <returns>The response from the DeleteTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRule">REST API Reference for DeleteTopicRule Operation</seealso>
        DeleteTopicRuleResponse DeleteTopicRule(string ruleName);

        /// <summary>
        /// Deletes the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRule service method.</param>
        /// 
        /// <returns>The response from the DeleteTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRule">REST API Reference for DeleteTopicRule Operation</seealso>
        DeleteTopicRuleResponse DeleteTopicRule(DeleteTopicRuleRequest request);


        /// <summary>
        /// Deletes the rule.
        /// </summary>
        /// <param name="ruleName">The name of the rule.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRule">REST API Reference for DeleteTopicRule Operation</seealso>
        Task<DeleteTopicRuleResponse> DeleteTopicRuleAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRule">REST API Reference for DeleteTopicRule Operation</seealso>
        Task<DeleteTopicRuleResponse> DeleteTopicRuleAsync(DeleteTopicRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteV2LoggingLevel


        /// <summary>
        /// Deletes a logging level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteV2LoggingLevel service method.</param>
        /// 
        /// <returns>The response from the DeleteV2LoggingLevel service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteV2LoggingLevel">REST API Reference for DeleteV2LoggingLevel Operation</seealso>
        DeleteV2LoggingLevelResponse DeleteV2LoggingLevel(DeleteV2LoggingLevelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteV2LoggingLevel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteV2LoggingLevel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteV2LoggingLevel">REST API Reference for DeleteV2LoggingLevel Operation</seealso>
        Task<DeleteV2LoggingLevelResponse> DeleteV2LoggingLevelAsync(DeleteV2LoggingLevelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeprecateThingType


        /// <summary>
        /// Deprecates a thing type. You can not associate new things with deprecated thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateThingType service method.</param>
        /// 
        /// <returns>The response from the DeprecateThingType service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeprecateThingType">REST API Reference for DeprecateThingType Operation</seealso>
        DeprecateThingTypeResponse DeprecateThingType(DeprecateThingTypeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeprecateThingType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprecateThingType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeprecateThingType">REST API Reference for DeprecateThingType Operation</seealso>
        Task<DeprecateThingTypeResponse> DeprecateThingTypeAsync(DeprecateThingTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAuthorizer


        /// <summary>
        /// Describes an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DescribeAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuthorizer">REST API Reference for DescribeAuthorizer Operation</seealso>
        DescribeAuthorizerResponse DescribeAuthorizer(DescribeAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuthorizer">REST API Reference for DescribeAuthorizer Operation</seealso>
        Task<DescribeAuthorizerResponse> DescribeAuthorizerAsync(DescribeAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCACertificate


        /// <summary>
        /// Describes a registered CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCACertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCACertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCACertificate">REST API Reference for DescribeCACertificate Operation</seealso>
        DescribeCACertificateResponse DescribeCACertificate(DescribeCACertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCACertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCACertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCACertificate">REST API Reference for DescribeCACertificate Operation</seealso>
        Task<DescribeCACertificateResponse> DescribeCACertificateAsync(DescribeCACertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeCertificate


        /// <summary>
        /// Gets information about the specified certificate.
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        DescribeCertificateResponse DescribeCertificate(string certificateId);

        /// <summary>
        /// Gets information about the specified certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request);


        /// <summary>
        /// Gets information about the specified certificate.
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        Task<DescribeCertificateResponse> DescribeCertificateAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        Task<DescribeCertificateResponse> DescribeCertificateAsync(DescribeCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDefaultAuthorizer


        /// <summary>
        /// Describes the default authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultAuthorizer service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDefaultAuthorizer">REST API Reference for DescribeDefaultAuthorizer Operation</seealso>
        DescribeDefaultAuthorizerResponse DescribeDefaultAuthorizer(DescribeDefaultAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDefaultAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDefaultAuthorizer">REST API Reference for DescribeDefaultAuthorizer Operation</seealso>
        Task<DescribeDefaultAuthorizerResponse> DescribeDefaultAuthorizerAsync(DescribeDefaultAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEndpoint


        /// <summary>
        /// Returns a unique endpoint specific to the AWS account making the call.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse DescribeEndpoint();

        /// <summary>
        /// Returns a unique endpoint specific to the AWS account making the call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request);


        /// <summary>
        /// Returns a unique endpoint specific to the AWS account making the call.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        Task<DescribeEndpointResponse> DescribeEndpointAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        Task<DescribeEndpointResponse> DescribeEndpointAsync(DescribeEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventConfigurations


        /// <summary>
        /// Describes event configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeEventConfigurations service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEventConfigurations">REST API Reference for DescribeEventConfigurations Operation</seealso>
        DescribeEventConfigurationsResponse DescribeEventConfigurations(DescribeEventConfigurationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEventConfigurations">REST API Reference for DescribeEventConfigurations Operation</seealso>
        Task<DescribeEventConfigurationsResponse> DescribeEventConfigurationsAsync(DescribeEventConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeIndex


        /// <summary>
        /// Describes a search index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex service method.</param>
        /// 
        /// <returns>The response from the DescribeIndex service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        DescribeIndexResponse DescribeIndex(DescribeIndexRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        Task<DescribeIndexResponse> DescribeIndexAsync(DescribeIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJob


        /// <summary>
        /// Describes a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        DescribeJobResponse DescribeJob(DescribeJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        Task<DescribeJobResponse> DescribeJobAsync(DescribeJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeJobExecution


        /// <summary>
        /// Describes a job execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeJobExecution service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJobExecution">REST API Reference for DescribeJobExecution Operation</seealso>
        DescribeJobExecutionResponse DescribeJobExecution(DescribeJobExecutionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobExecution operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJobExecution">REST API Reference for DescribeJobExecution Operation</seealso>
        Task<DescribeJobExecutionResponse> DescribeJobExecutionAsync(DescribeJobExecutionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeRoleAlias


        /// <summary>
        /// Describes a role alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoleAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeRoleAlias service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeRoleAlias">REST API Reference for DescribeRoleAlias Operation</seealso>
        DescribeRoleAliasResponse DescribeRoleAlias(DescribeRoleAliasRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoleAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeRoleAlias">REST API Reference for DescribeRoleAlias Operation</seealso>
        Task<DescribeRoleAliasResponse> DescribeRoleAliasAsync(DescribeRoleAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStream


        /// <summary>
        /// Gets information about a stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream service method.</param>
        /// 
        /// <returns>The response from the DescribeStream service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        DescribeStreamResponse DescribeStream(DescribeStreamRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        Task<DescribeStreamResponse> DescribeStreamAsync(DescribeStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeThing


        /// <summary>
        /// Gets information about the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// 
        /// <returns>The response from the DescribeThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThing">REST API Reference for DescribeThing Operation</seealso>
        DescribeThingResponse DescribeThing(string thingName);

        /// <summary>
        /// Gets information about the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThing service method.</param>
        /// 
        /// <returns>The response from the DescribeThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThing">REST API Reference for DescribeThing Operation</seealso>
        DescribeThingResponse DescribeThing(DescribeThingRequest request);


        /// <summary>
        /// Gets information about the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThing">REST API Reference for DescribeThing Operation</seealso>
        Task<DescribeThingResponse> DescribeThingAsync(string thingName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThing">REST API Reference for DescribeThing Operation</seealso>
        Task<DescribeThingResponse> DescribeThingAsync(DescribeThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeThingGroup


        /// <summary>
        /// Describe a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingGroup">REST API Reference for DescribeThingGroup Operation</seealso>
        DescribeThingGroupResponse DescribeThingGroup(DescribeThingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingGroup">REST API Reference for DescribeThingGroup Operation</seealso>
        Task<DescribeThingGroupResponse> DescribeThingGroupAsync(DescribeThingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeThingRegistrationTask


        /// <summary>
        /// Describes a bulk thing provisioning task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingRegistrationTask service method.</param>
        /// 
        /// <returns>The response from the DescribeThingRegistrationTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingRegistrationTask">REST API Reference for DescribeThingRegistrationTask Operation</seealso>
        DescribeThingRegistrationTaskResponse DescribeThingRegistrationTask(DescribeThingRegistrationTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThingRegistrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingRegistrationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingRegistrationTask">REST API Reference for DescribeThingRegistrationTask Operation</seealso>
        Task<DescribeThingRegistrationTaskResponse> DescribeThingRegistrationTaskAsync(DescribeThingRegistrationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeThingType


        /// <summary>
        /// Gets information about the specified thing type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingType service method.</param>
        /// 
        /// <returns>The response from the DescribeThingType service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingType">REST API Reference for DescribeThingType Operation</seealso>
        DescribeThingTypeResponse DescribeThingType(DescribeThingTypeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThingType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingType">REST API Reference for DescribeThingType Operation</seealso>
        Task<DescribeThingTypeResponse> DescribeThingTypeAsync(DescribeThingTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachPolicy


        /// <summary>
        /// Detaches a policy from the specified target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        DetachPolicyResponse DetachPolicy(DetachPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachPrincipalPolicy


        /// <summary>
        /// Removes the specified policy from the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>DetachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="policyName">The name of the policy to detach.</param>
        /// <param name="principal">The principal. If the principal is a certificate, specify the certificate ARN. If the principal is an Amazon Cognito identity, specify the identity ID.</param>
        /// 
        /// <returns>The response from the DetachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPrincipalPolicy">REST API Reference for DetachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of DetachPolicy.")]
        DetachPrincipalPolicyResponse DetachPrincipalPolicy(string policyName, string principal);

        /// <summary>
        /// Removes the specified policy from the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>DetachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachPrincipalPolicy service method.</param>
        /// 
        /// <returns>The response from the DetachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPrincipalPolicy">REST API Reference for DetachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of DetachPolicy.")]
        DetachPrincipalPolicyResponse DetachPrincipalPolicy(DetachPrincipalPolicyRequest request);


        /// <summary>
        /// Removes the specified policy from the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>DetachPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="policyName">The name of the policy to detach.</param>
        /// <param name="principal">The principal. If the principal is a certificate, specify the certificate ARN. If the principal is an Amazon Cognito identity, specify the identity ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachPrincipalPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPrincipalPolicy">REST API Reference for DetachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of DetachPolicy.")]
        Task<DetachPrincipalPolicyResponse> DetachPrincipalPolicyAsync(string policyName, string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DetachPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPrincipalPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPrincipalPolicy">REST API Reference for DetachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of DetachPolicy.")]
        Task<DetachPrincipalPolicyResponse> DetachPrincipalPolicyAsync(DetachPrincipalPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DetachThingPrincipal


        /// <summary>
        /// Detaches the specified principal from the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="principal">If the principal is a certificate, this value must be ARN of the certificate. If the principal is an Amazon Cognito identity, this value must be the ID of the Amazon Cognito identity.</param>
        /// 
        /// <returns>The response from the DetachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachThingPrincipal">REST API Reference for DetachThingPrincipal Operation</seealso>
        DetachThingPrincipalResponse DetachThingPrincipal(string thingName, string principal);

        /// <summary>
        /// Detaches the specified principal from the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachThingPrincipal service method.</param>
        /// 
        /// <returns>The response from the DetachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachThingPrincipal">REST API Reference for DetachThingPrincipal Operation</seealso>
        DetachThingPrincipalResponse DetachThingPrincipal(DetachThingPrincipalRequest request);


        /// <summary>
        /// Detaches the specified principal from the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="principal">If the principal is a certificate, this value must be ARN of the certificate. If the principal is an Amazon Cognito identity, this value must be the ID of the Amazon Cognito identity.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DetachThingPrincipal service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachThingPrincipal">REST API Reference for DetachThingPrincipal Operation</seealso>
        Task<DetachThingPrincipalResponse> DetachThingPrincipalAsync(string thingName, string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the DetachThingPrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachThingPrincipal operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachThingPrincipal">REST API Reference for DetachThingPrincipal Operation</seealso>
        Task<DetachThingPrincipalResponse> DetachThingPrincipalAsync(DetachThingPrincipalRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableTopicRule


        /// <summary>
        /// Disables the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTopicRule service method.</param>
        /// 
        /// <returns>The response from the DisableTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DisableTopicRule">REST API Reference for DisableTopicRule Operation</seealso>
        DisableTopicRuleResponse DisableTopicRule(DisableTopicRuleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DisableTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DisableTopicRule">REST API Reference for DisableTopicRule Operation</seealso>
        Task<DisableTopicRuleResponse> DisableTopicRuleAsync(DisableTopicRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableTopicRule


        /// <summary>
        /// Enables the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTopicRule service method.</param>
        /// 
        /// <returns>The response from the EnableTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/EnableTopicRule">REST API Reference for EnableTopicRule Operation</seealso>
        EnableTopicRuleResponse EnableTopicRule(EnableTopicRuleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the EnableTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/EnableTopicRule">REST API Reference for EnableTopicRule Operation</seealso>
        Task<EnableTopicRuleResponse> EnableTopicRuleAsync(EnableTopicRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetEffectivePolicies


        /// <summary>
        /// Gets a list of the policies that have an effect on the authorization behavior of the
        /// specified device when it connects to the AWS IoT device gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePolicies service method.</param>
        /// 
        /// <returns>The response from the GetEffectivePolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetEffectivePolicies">REST API Reference for GetEffectivePolicies Operation</seealso>
        GetEffectivePoliciesResponse GetEffectivePolicies(GetEffectivePoliciesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetEffectivePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetEffectivePolicies">REST API Reference for GetEffectivePolicies Operation</seealso>
        Task<GetEffectivePoliciesResponse> GetEffectivePoliciesAsync(GetEffectivePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIndexingConfiguration


        /// <summary>
        /// Gets the search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIndexingConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetIndexingConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetIndexingConfiguration">REST API Reference for GetIndexingConfiguration Operation</seealso>
        GetIndexingConfigurationResponse GetIndexingConfiguration(GetIndexingConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetIndexingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIndexingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetIndexingConfiguration">REST API Reference for GetIndexingConfiguration Operation</seealso>
        Task<GetIndexingConfigurationResponse> GetIndexingConfigurationAsync(GetIndexingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetJobDocument


        /// <summary>
        /// Gets a job document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobDocument service method.</param>
        /// 
        /// <returns>The response from the GetJobDocument service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetJobDocument">REST API Reference for GetJobDocument Operation</seealso>
        GetJobDocumentResponse GetJobDocument(GetJobDocumentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetJobDocument operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobDocument operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetJobDocument">REST API Reference for GetJobDocument Operation</seealso>
        Task<GetJobDocumentResponse> GetJobDocumentAsync(GetJobDocumentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLoggingOptions


        /// <summary>
        /// Gets the logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the GetLoggingOptions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        GetLoggingOptionsResponse GetLoggingOptions(GetLoggingOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        Task<GetLoggingOptionsResponse> GetLoggingOptionsAsync(GetLoggingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetOTAUpdate


        /// <summary>
        /// Gets an OTA update.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOTAUpdate service method.</param>
        /// 
        /// <returns>The response from the GetOTAUpdate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetOTAUpdate">REST API Reference for GetOTAUpdate Operation</seealso>
        GetOTAUpdateResponse GetOTAUpdate(GetOTAUpdateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOTAUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetOTAUpdate">REST API Reference for GetOTAUpdate Operation</seealso>
        Task<GetOTAUpdateResponse> GetOTAUpdateAsync(GetOTAUpdateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Gets information about the specified policy with the policy document of the default
        /// version.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(string policyName);

        /// <summary>
        /// Gets information about the specified policy with the policy document of the default
        /// version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy service method.</param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse GetPolicy(GetPolicyRequest request);


        /// <summary>
        /// Gets information about the specified policy with the policy document of the default
        /// version.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        Task<GetPolicyResponse> GetPolicyAsync(GetPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPolicyVersion


        /// <summary>
        /// Gets information about the specified policy version.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        GetPolicyVersionResponse GetPolicyVersion(string policyName, string policyVersionId);

        /// <summary>
        /// Gets information about the specified policy version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request);


        /// <summary>
        /// Gets information about the specified policy version.
        /// </summary>
        /// <param name="policyName">The name of the policy.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        Task<GetPolicyVersionResponse> GetPolicyVersionAsync(string policyName, string policyVersionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRegistrationCode


        /// <summary>
        /// Gets a registration code used to register a CA certificate with AWS IoT.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRegistrationCode service method.</param>
        /// 
        /// <returns>The response from the GetRegistrationCode service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetRegistrationCode">REST API Reference for GetRegistrationCode Operation</seealso>
        GetRegistrationCodeResponse GetRegistrationCode(GetRegistrationCodeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetRegistrationCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRegistrationCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetRegistrationCode">REST API Reference for GetRegistrationCode Operation</seealso>
        Task<GetRegistrationCodeResponse> GetRegistrationCodeAsync(GetRegistrationCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetTopicRule


        /// <summary>
        /// Gets information about the rule.
        /// </summary>
        /// <param name="ruleName">The name of the rule.</param>
        /// 
        /// <returns>The response from the GetTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRule">REST API Reference for GetTopicRule Operation</seealso>
        GetTopicRuleResponse GetTopicRule(string ruleName);

        /// <summary>
        /// Gets information about the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTopicRule service method.</param>
        /// 
        /// <returns>The response from the GetTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRule">REST API Reference for GetTopicRule Operation</seealso>
        GetTopicRuleResponse GetTopicRule(GetTopicRuleRequest request);


        /// <summary>
        /// Gets information about the rule.
        /// </summary>
        /// <param name="ruleName">The name of the rule.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRule">REST API Reference for GetTopicRule Operation</seealso>
        Task<GetTopicRuleResponse> GetTopicRuleAsync(string ruleName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the GetTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRule">REST API Reference for GetTopicRule Operation</seealso>
        Task<GetTopicRuleResponse> GetTopicRuleAsync(GetTopicRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetV2LoggingOptions


        /// <summary>
        /// Gets the fine grained logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetV2LoggingOptions service method.</param>
        /// 
        /// <returns>The response from the GetV2LoggingOptions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetV2LoggingOptions">REST API Reference for GetV2LoggingOptions Operation</seealso>
        GetV2LoggingOptionsResponse GetV2LoggingOptions(GetV2LoggingOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetV2LoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetV2LoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetV2LoggingOptions">REST API Reference for GetV2LoggingOptions Operation</seealso>
        Task<GetV2LoggingOptionsResponse> GetV2LoggingOptionsAsync(GetV2LoggingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAttachedPolicies


        /// <summary>
        /// Lists the policies attached to the specified thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedPolicies service method.</param>
        /// 
        /// <returns>The response from the ListAttachedPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAttachedPolicies">REST API Reference for ListAttachedPolicies Operation</seealso>
        ListAttachedPoliciesResponse ListAttachedPolicies(ListAttachedPoliciesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAttachedPolicies">REST API Reference for ListAttachedPolicies Operation</seealso>
        Task<ListAttachedPoliciesResponse> ListAttachedPoliciesAsync(ListAttachedPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAuthorizers


        /// <summary>
        /// Lists the authorizers registered in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuthorizers service method.</param>
        /// 
        /// <returns>The response from the ListAuthorizers service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuthorizers">REST API Reference for ListAuthorizers Operation</seealso>
        ListAuthorizersResponse ListAuthorizers(ListAuthorizersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAuthorizers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuthorizers">REST API Reference for ListAuthorizers Operation</seealso>
        Task<ListAuthorizersResponse> ListAuthorizersAsync(ListAuthorizersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCACertificates


        /// <summary>
        /// Lists the CA certificates registered for your AWS account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCACertificates service method.</param>
        /// 
        /// <returns>The response from the ListCACertificates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCACertificates">REST API Reference for ListCACertificates Operation</seealso>
        ListCACertificatesResponse ListCACertificates(ListCACertificatesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListCACertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCACertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCACertificates">REST API Reference for ListCACertificates Operation</seealso>
        Task<ListCACertificatesResponse> ListCACertificatesAsync(ListCACertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCertificates


        /// <summary>
        /// Lists the certificates registered in your AWS account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        ListCertificatesResponse ListCertificates();

        /// <summary>
        /// Lists the certificates registered in your AWS account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        ListCertificatesResponse ListCertificates(ListCertificatesRequest request);


        /// <summary>
        /// Lists the certificates registered in your AWS account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        Task<ListCertificatesResponse> ListCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListCertificatesByCA


        /// <summary>
        /// List the device certificates signed by the specified CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificatesByCA service method.</param>
        /// 
        /// <returns>The response from the ListCertificatesByCA service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificatesByCA">REST API Reference for ListCertificatesByCA Operation</seealso>
        ListCertificatesByCAResponse ListCertificatesByCA(ListCertificatesByCARequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificatesByCA operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificatesByCA operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificatesByCA">REST API Reference for ListCertificatesByCA Operation</seealso>
        Task<ListCertificatesByCAResponse> ListCertificatesByCAAsync(ListCertificatesByCARequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIndices


        /// <summary>
        /// Lists the search indices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIndices service method.</param>
        /// 
        /// <returns>The response from the ListIndices service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListIndices">REST API Reference for ListIndices Operation</seealso>
        ListIndicesResponse ListIndices(ListIndicesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListIndices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIndices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListIndices">REST API Reference for ListIndices Operation</seealso>
        Task<ListIndicesResponse> ListIndicesAsync(ListIndicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobExecutionsForJob


        /// <summary>
        /// Lists the job executions for a job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForJob service method.</param>
        /// 
        /// <returns>The response from the ListJobExecutionsForJob service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForJob">REST API Reference for ListJobExecutionsForJob Operation</seealso>
        ListJobExecutionsForJobResponse ListJobExecutionsForJob(ListJobExecutionsForJobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobExecutionsForJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForJob">REST API Reference for ListJobExecutionsForJob Operation</seealso>
        Task<ListJobExecutionsForJobResponse> ListJobExecutionsForJobAsync(ListJobExecutionsForJobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobExecutionsForThing


        /// <summary>
        /// Lists the job executions for the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForThing service method.</param>
        /// 
        /// <returns>The response from the ListJobExecutionsForThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForThing">REST API Reference for ListJobExecutionsForThing Operation</seealso>
        ListJobExecutionsForThingResponse ListJobExecutionsForThing(ListJobExecutionsForThingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobExecutionsForThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForThing">REST API Reference for ListJobExecutionsForThing Operation</seealso>
        Task<ListJobExecutionsForThingResponse> ListJobExecutionsForThingAsync(ListJobExecutionsForThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Lists jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse ListJobs(ListJobsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobs">REST API Reference for ListJobs Operation</seealso>
        Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOTAUpdates


        /// <summary>
        /// Lists OTA updates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOTAUpdates service method.</param>
        /// 
        /// <returns>The response from the ListOTAUpdates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOTAUpdates">REST API Reference for ListOTAUpdates Operation</seealso>
        ListOTAUpdatesResponse ListOTAUpdates(ListOTAUpdatesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListOTAUpdates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOTAUpdates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOTAUpdates">REST API Reference for ListOTAUpdates Operation</seealso>
        Task<ListOTAUpdatesResponse> ListOTAUpdatesAsync(ListOTAUpdatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListOutgoingCertificates


        /// <summary>
        /// Lists certificates that are being transferred but not yet accepted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingCertificates service method.</param>
        /// 
        /// <returns>The response from the ListOutgoingCertificates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOutgoingCertificates">REST API Reference for ListOutgoingCertificates Operation</seealso>
        ListOutgoingCertificatesResponse ListOutgoingCertificates(ListOutgoingCertificatesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListOutgoingCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOutgoingCertificates">REST API Reference for ListOutgoingCertificates Operation</seealso>
        Task<ListOutgoingCertificatesResponse> ListOutgoingCertificatesAsync(ListOutgoingCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Lists your policies.
        /// </summary>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse ListPolicies();

        /// <summary>
        /// Lists your policies.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse ListPolicies(ListPoliciesRequest request);


        /// <summary>
        /// Lists your policies.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPolicyPrincipals


        /// <summary>
        /// Lists the principals associated with the specified policy.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListTargetsForPolicy</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyPrincipals service method.</param>
        /// 
        /// <returns>The response from the ListPolicyPrincipals service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyPrincipals">REST API Reference for ListPolicyPrincipals Operation</seealso>
        [Obsolete("Deprecated in favor of ListTargetsForPolicy.")]
        ListPolicyPrincipalsResponse ListPolicyPrincipals(ListPolicyPrincipalsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyPrincipals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyPrincipals operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyPrincipals">REST API Reference for ListPolicyPrincipals Operation</seealso>
        [Obsolete("Deprecated in favor of ListTargetsForPolicy.")]
        Task<ListPolicyPrincipalsResponse> ListPolicyPrincipalsAsync(ListPolicyPrincipalsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPolicyVersions


        /// <summary>
        /// Lists the versions of the specified policy and identifies the default version.
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        ListPolicyVersionsResponse ListPolicyVersions(string policyName);

        /// <summary>
        /// Lists the versions of the specified policy and identifies the default version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions service method.</param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request);


        /// <summary>
        /// Lists the versions of the specified policy and identifies the default version.
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(string policyName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPrincipalPolicies


        /// <summary>
        /// Lists the policies attached to the specified principal. If you use an Cognito identity,
        /// the ID must be in <a href="http://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetCredentialsForIdentity.html#API_GetCredentialsForIdentity_RequestSyntax">AmazonCognito
        /// Identity format</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListAttachedPolicies</a> instead.
        /// </para>
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// 
        /// <returns>The response from the ListPrincipalPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalPolicies">REST API Reference for ListPrincipalPolicies Operation</seealso>
        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        ListPrincipalPoliciesResponse ListPrincipalPolicies(string principal);

        /// <summary>
        /// Lists the policies attached to the specified principal. If you use an Cognito identity,
        /// the ID must be in <a href="http://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetCredentialsForIdentity.html#API_GetCredentialsForIdentity_RequestSyntax">AmazonCognito
        /// Identity format</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListAttachedPolicies</a> instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalPolicies service method.</param>
        /// 
        /// <returns>The response from the ListPrincipalPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalPolicies">REST API Reference for ListPrincipalPolicies Operation</seealso>
        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        ListPrincipalPoliciesResponse ListPrincipalPolicies(ListPrincipalPoliciesRequest request);


        /// <summary>
        /// Lists the policies attached to the specified principal. If you use an Cognito identity,
        /// the ID must be in <a href="http://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetCredentialsForIdentity.html#API_GetCredentialsForIdentity_RequestSyntax">AmazonCognito
        /// Identity format</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This API is deprecated. Please use <a>ListAttachedPolicies</a> instead.
        /// </para>
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrincipalPolicies service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalPolicies">REST API Reference for ListPrincipalPolicies Operation</seealso>
        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        Task<ListPrincipalPoliciesResponse> ListPrincipalPoliciesAsync(string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipalPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalPolicies">REST API Reference for ListPrincipalPolicies Operation</seealso>
        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        Task<ListPrincipalPoliciesResponse> ListPrincipalPoliciesAsync(ListPrincipalPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPrincipalThings


        /// <summary>
        /// Lists the things associated with the specified principal.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// 
        /// <returns>The response from the ListPrincipalThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalThings">REST API Reference for ListPrincipalThings Operation</seealso>
        ListPrincipalThingsResponse ListPrincipalThings(string principal);

        /// <summary>
        /// Lists the things associated with the specified principal.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalThings service method.</param>
        /// 
        /// <returns>The response from the ListPrincipalThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalThings">REST API Reference for ListPrincipalThings Operation</seealso>
        ListPrincipalThingsResponse ListPrincipalThings(ListPrincipalThingsRequest request);


        /// <summary>
        /// Lists the things associated with the specified principal.
        /// </summary>
        /// <param name="principal">The principal.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPrincipalThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalThings">REST API Reference for ListPrincipalThings Operation</seealso>
        Task<ListPrincipalThingsResponse> ListPrincipalThingsAsync(string principal, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListPrincipalThings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalThings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalThings">REST API Reference for ListPrincipalThings Operation</seealso>
        Task<ListPrincipalThingsResponse> ListPrincipalThingsAsync(ListPrincipalThingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRoleAliases


        /// <summary>
        /// Lists the role aliases registered in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoleAliases service method.</param>
        /// 
        /// <returns>The response from the ListRoleAliases service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListRoleAliases">REST API Reference for ListRoleAliases Operation</seealso>
        ListRoleAliasesResponse ListRoleAliases(ListRoleAliasesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListRoleAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoleAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListRoleAliases">REST API Reference for ListRoleAliases Operation</seealso>
        Task<ListRoleAliasesResponse> ListRoleAliasesAsync(ListRoleAliasesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListStreams


        /// <summary>
        /// Lists all of the streams in your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStreams service method.</param>
        /// 
        /// <returns>The response from the ListStreams service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListStreams">REST API Reference for ListStreams Operation</seealso>
        ListStreamsResponse ListStreams(ListStreamsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListStreams">REST API Reference for ListStreams Operation</seealso>
        Task<ListStreamsResponse> ListStreamsAsync(ListStreamsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTargetsForPolicy


        /// <summary>
        /// List targets for the specified policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy service method.</param>
        /// 
        /// <returns>The response from the ListTargetsForPolicy service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        ListTargetsForPolicyResponse ListTargetsForPolicy(ListTargetsForPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetsForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        Task<ListTargetsForPolicyResponse> ListTargetsForPolicyAsync(ListTargetsForPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThingGroups


        /// <summary>
        /// List the thing groups in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroups service method.</param>
        /// 
        /// <returns>The response from the ListThingGroups service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroups">REST API Reference for ListThingGroups Operation</seealso>
        ListThingGroupsResponse ListThingGroups(ListThingGroupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListThingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroups">REST API Reference for ListThingGroups Operation</seealso>
        Task<ListThingGroupsResponse> ListThingGroupsAsync(ListThingGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThingGroupsForThing


        /// <summary>
        /// List the thing groups to which the specified thing belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroupsForThing service method.</param>
        /// 
        /// <returns>The response from the ListThingGroupsForThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroupsForThing">REST API Reference for ListThingGroupsForThing Operation</seealso>
        ListThingGroupsForThingResponse ListThingGroupsForThing(ListThingGroupsForThingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListThingGroupsForThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroupsForThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroupsForThing">REST API Reference for ListThingGroupsForThing Operation</seealso>
        Task<ListThingGroupsForThingResponse> ListThingGroupsForThingAsync(ListThingGroupsForThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThingPrincipals


        /// <summary>
        /// Lists the principals associated with the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// 
        /// <returns>The response from the ListThingPrincipals service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingPrincipals">REST API Reference for ListThingPrincipals Operation</seealso>
        ListThingPrincipalsResponse ListThingPrincipals(string thingName);

        /// <summary>
        /// Lists the principals associated with the specified thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingPrincipals service method.</param>
        /// 
        /// <returns>The response from the ListThingPrincipals service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingPrincipals">REST API Reference for ListThingPrincipals Operation</seealso>
        ListThingPrincipalsResponse ListThingPrincipals(ListThingPrincipalsRequest request);


        /// <summary>
        /// Lists the principals associated with the specified thing.
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThingPrincipals service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingPrincipals">REST API Reference for ListThingPrincipals Operation</seealso>
        Task<ListThingPrincipalsResponse> ListThingPrincipalsAsync(string thingName, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingPrincipals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingPrincipals operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingPrincipals">REST API Reference for ListThingPrincipals Operation</seealso>
        Task<ListThingPrincipalsResponse> ListThingPrincipalsAsync(ListThingPrincipalsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThingRegistrationTaskReports


        /// <summary>
        /// Information about the thing registration tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTaskReports service method.</param>
        /// 
        /// <returns>The response from the ListThingRegistrationTaskReports service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTaskReports">REST API Reference for ListThingRegistrationTaskReports Operation</seealso>
        ListThingRegistrationTaskReportsResponse ListThingRegistrationTaskReports(ListThingRegistrationTaskReportsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListThingRegistrationTaskReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTaskReports operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTaskReports">REST API Reference for ListThingRegistrationTaskReports Operation</seealso>
        Task<ListThingRegistrationTaskReportsResponse> ListThingRegistrationTaskReportsAsync(ListThingRegistrationTaskReportsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThingRegistrationTasks


        /// <summary>
        /// List bulk thing provisioning tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTasks service method.</param>
        /// 
        /// <returns>The response from the ListThingRegistrationTasks service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTasks">REST API Reference for ListThingRegistrationTasks Operation</seealso>
        ListThingRegistrationTasksResponse ListThingRegistrationTasks(ListThingRegistrationTasksRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListThingRegistrationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTasks">REST API Reference for ListThingRegistrationTasks Operation</seealso>
        Task<ListThingRegistrationTasksResponse> ListThingRegistrationTasksAsync(ListThingRegistrationTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThings


        /// <summary>
        /// Lists your things. Use the <b>attributeName</b> and <b>attributeValue</b> parameters
        /// to filter your things. For example, calling <code>ListThings</code> with attributeName=Color
        /// and attributeValue=Red retrieves all things in the registry that contain an attribute
        /// <b>Color</b> with the value <b>Red</b>.
        /// </summary>
        /// 
        /// <returns>The response from the ListThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThings">REST API Reference for ListThings Operation</seealso>
        ListThingsResponse ListThings();

        /// <summary>
        /// Lists your things. Use the <b>attributeName</b> and <b>attributeValue</b> parameters
        /// to filter your things. For example, calling <code>ListThings</code> with attributeName=Color
        /// and attributeValue=Red retrieves all things in the registry that contain an attribute
        /// <b>Color</b> with the value <b>Red</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThings service method.</param>
        /// 
        /// <returns>The response from the ListThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThings">REST API Reference for ListThings Operation</seealso>
        ListThingsResponse ListThings(ListThingsRequest request);


        /// <summary>
        /// Lists your things. Use the <b>attributeName</b> and <b>attributeValue</b> parameters
        /// to filter your things. For example, calling <code>ListThings</code> with attributeName=Color
        /// and attributeValue=Red retrieves all things in the registry that contain an attribute
        /// <b>Color</b> with the value <b>Red</b>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListThings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThings">REST API Reference for ListThings Operation</seealso>
        Task<ListThingsResponse> ListThingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListThings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThings">REST API Reference for ListThings Operation</seealso>
        Task<ListThingsResponse> ListThingsAsync(ListThingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThingsInThingGroup


        /// <summary>
        /// Lists the things in the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInThingGroup service method.</param>
        /// 
        /// <returns>The response from the ListThingsInThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInThingGroup">REST API Reference for ListThingsInThingGroup Operation</seealso>
        ListThingsInThingGroupResponse ListThingsInThingGroup(ListThingsInThingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListThingsInThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInThingGroup">REST API Reference for ListThingsInThingGroup Operation</seealso>
        Task<ListThingsInThingGroupResponse> ListThingsInThingGroupAsync(ListThingsInThingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListThingTypes


        /// <summary>
        /// Lists the existing thing types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingTypes service method.</param>
        /// 
        /// <returns>The response from the ListThingTypes service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingTypes">REST API Reference for ListThingTypes Operation</seealso>
        ListThingTypesResponse ListThingTypes(ListThingTypesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListThingTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingTypes">REST API Reference for ListThingTypes Operation</seealso>
        Task<ListThingTypesResponse> ListThingTypesAsync(ListThingTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTopicRules


        /// <summary>
        /// Lists the rules for the specific topic.
        /// </summary>
        /// <param name="topic">The topic.</param>
        /// 
        /// <returns>The response from the ListTopicRules service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRules">REST API Reference for ListTopicRules Operation</seealso>
        ListTopicRulesResponse ListTopicRules(string topic);

        /// <summary>
        /// Lists the rules for the specific topic.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRules service method.</param>
        /// 
        /// <returns>The response from the ListTopicRules service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRules">REST API Reference for ListTopicRules Operation</seealso>
        ListTopicRulesResponse ListTopicRules(ListTopicRulesRequest request);


        /// <summary>
        /// Lists the rules for the specific topic.
        /// </summary>
        /// <param name="topic">The topic.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTopicRules service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRules">REST API Reference for ListTopicRules Operation</seealso>
        Task<ListTopicRulesResponse> ListTopicRulesAsync(string topic, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopicRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRules">REST API Reference for ListTopicRules Operation</seealso>
        Task<ListTopicRulesResponse> ListTopicRulesAsync(ListTopicRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListV2LoggingLevels


        /// <summary>
        /// Lists logging levels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListV2LoggingLevels service method.</param>
        /// 
        /// <returns>The response from the ListV2LoggingLevels service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.NotConfiguredException">
        /// The resource is not configured.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListV2LoggingLevels">REST API Reference for ListV2LoggingLevels Operation</seealso>
        ListV2LoggingLevelsResponse ListV2LoggingLevels(ListV2LoggingLevelsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListV2LoggingLevels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListV2LoggingLevels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListV2LoggingLevels">REST API Reference for ListV2LoggingLevels Operation</seealso>
        Task<ListV2LoggingLevelsResponse> ListV2LoggingLevelsAsync(ListV2LoggingLevelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterCACertificate


        /// <summary>
        /// Registers a CA certificate with AWS IoT. This CA certificate can then be used to sign
        /// device certificates, which can be then registered with AWS IoT. You can register up
        /// to 10 CA certificates per AWS account that have the same subject field. This enables
        /// you to have up to 10 certificate authorities sign your device certificates. If you
        /// have more than one CA certificate registered, make sure you pass the CA certificate
        /// when you register your device certificates with the RegisterCertificate API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCACertificate service method.</param>
        /// 
        /// <returns>The response from the RegisterCACertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateValidationException">
        /// The certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.RegistrationCodeValidationException">
        /// The registration code is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCACertificate">REST API Reference for RegisterCACertificate Operation</seealso>
        RegisterCACertificateResponse RegisterCACertificate(RegisterCACertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCACertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCACertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCACertificate">REST API Reference for RegisterCACertificate Operation</seealso>
        Task<RegisterCACertificateResponse> RegisterCACertificateAsync(RegisterCACertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterCertificate


        /// <summary>
        /// Registers a device certificate with AWS IoT. If you have more than one CA certificate
        /// that has the same subject field, you must specify the CA certificate that was used
        /// to sign the device certificate being registered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificate service method.</param>
        /// 
        /// <returns>The response from the RegisterCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateConflictException">
        /// Unable to verify the CA certificate used to sign the device certificate you are attempting
        /// to register. This is happens when you have registered more than one CA certificate
        /// that has the same subject field and public key.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.CertificateValidationException">
        /// The certificate is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCertificate">REST API Reference for RegisterCertificate Operation</seealso>
        RegisterCertificateResponse RegisterCertificate(RegisterCertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCertificate">REST API Reference for RegisterCertificate Operation</seealso>
        Task<RegisterCertificateResponse> RegisterCertificateAsync(RegisterCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterThing


        /// <summary>
        /// Provisions a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterThing service method.</param>
        /// 
        /// <returns>The response from the RegisterThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceRegistrationFailureException">
        /// The resource registration failed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterThing">REST API Reference for RegisterThing Operation</seealso>
        RegisterThingResponse RegisterThing(RegisterThingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterThing">REST API Reference for RegisterThing Operation</seealso>
        Task<RegisterThingResponse> RegisterThingAsync(RegisterThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RejectCertificateTransfer


        /// <summary>
        /// Rejects a pending certificate transfer. After AWS IoT rejects a certificate transfer,
        /// the certificate status changes from <b>PENDING_TRANSFER</b> to <b>INACTIVE</b>.
        /// 
        ///  
        /// <para>
        /// To check for pending certificate transfers, call <a>ListCertificates</a> to enumerate
        /// your certificates.
        /// </para>
        ///  
        /// <para>
        /// This operation can only be called by the transfer destination. After it is called,
        /// the certificate will be returned to the source's account in the INACTIVE state.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// 
        /// <returns>The response from the RejectCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RejectCertificateTransfer">REST API Reference for RejectCertificateTransfer Operation</seealso>
        RejectCertificateTransferResponse RejectCertificateTransfer(string certificateId);

        /// <summary>
        /// Rejects a pending certificate transfer. After AWS IoT rejects a certificate transfer,
        /// the certificate status changes from <b>PENDING_TRANSFER</b> to <b>INACTIVE</b>.
        /// 
        ///  
        /// <para>
        /// To check for pending certificate transfers, call <a>ListCertificates</a> to enumerate
        /// your certificates.
        /// </para>
        ///  
        /// <para>
        /// This operation can only be called by the transfer destination. After it is called,
        /// the certificate will be returned to the source's account in the INACTIVE state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectCertificateTransfer service method.</param>
        /// 
        /// <returns>The response from the RejectCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RejectCertificateTransfer">REST API Reference for RejectCertificateTransfer Operation</seealso>
        RejectCertificateTransferResponse RejectCertificateTransfer(RejectCertificateTransferRequest request);


        /// <summary>
        /// Rejects a pending certificate transfer. After AWS IoT rejects a certificate transfer,
        /// the certificate status changes from <b>PENDING_TRANSFER</b> to <b>INACTIVE</b>.
        /// 
        ///  
        /// <para>
        /// To check for pending certificate transfers, call <a>ListCertificates</a> to enumerate
        /// your certificates.
        /// </para>
        ///  
        /// <para>
        /// This operation can only be called by the transfer destination. After it is called,
        /// the certificate will be returned to the source's account in the INACTIVE state.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectCertificateTransfer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferAlreadyCompletedException">
        /// You can't revert the certificate transfer because the transfer is already complete.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RejectCertificateTransfer">REST API Reference for RejectCertificateTransfer Operation</seealso>
        Task<RejectCertificateTransferResponse> RejectCertificateTransferAsync(string certificateId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the RejectCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectCertificateTransfer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RejectCertificateTransfer">REST API Reference for RejectCertificateTransfer Operation</seealso>
        Task<RejectCertificateTransferResponse> RejectCertificateTransferAsync(RejectCertificateTransferRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RemoveThingFromThingGroup


        /// <summary>
        /// Remove the specified thing from the specified group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromThingGroup service method.</param>
        /// 
        /// <returns>The response from the RemoveThingFromThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromThingGroup">REST API Reference for RemoveThingFromThingGroup Operation</seealso>
        RemoveThingFromThingGroupResponse RemoveThingFromThingGroup(RemoveThingFromThingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveThingFromThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromThingGroup">REST API Reference for RemoveThingFromThingGroup Operation</seealso>
        Task<RemoveThingFromThingGroupResponse> RemoveThingFromThingGroupAsync(RemoveThingFromThingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ReplaceTopicRule


        /// <summary>
        /// Replaces the rule. You must specify all parameters for the new rule. Creating rules
        /// is an administrator-level action. Any user who has permission to create rules will
        /// be able to access data processed by the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceTopicRule service method.</param>
        /// 
        /// <returns>The response from the ReplaceTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.SqlParseException">
        /// The Rule-SQL expression can't be parsed correctly.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ReplaceTopicRule">REST API Reference for ReplaceTopicRule Operation</seealso>
        ReplaceTopicRuleResponse ReplaceTopicRule(ReplaceTopicRuleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceTopicRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ReplaceTopicRule">REST API Reference for ReplaceTopicRule Operation</seealso>
        Task<ReplaceTopicRuleResponse> ReplaceTopicRuleAsync(ReplaceTopicRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SearchIndex


        /// <summary>
        /// The query search index.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SearchIndex service method.</param>
        /// 
        /// <returns>The response from the SearchIndex service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidQueryException">
        /// The query is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SearchIndex">REST API Reference for SearchIndex Operation</seealso>
        SearchIndexResponse SearchIndex(SearchIndexRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SearchIndex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchIndex operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SearchIndex">REST API Reference for SearchIndex Operation</seealso>
        Task<SearchIndexResponse> SearchIndexAsync(SearchIndexRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetDefaultAuthorizer


        /// <summary>
        /// Sets the default authorizer. This will be used if a websocket connection is made without
        /// specifying an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultAuthorizer service method.</param>
        /// 
        /// <returns>The response from the SetDefaultAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceAlreadyExistsException">
        /// The resource already exists.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultAuthorizer">REST API Reference for SetDefaultAuthorizer Operation</seealso>
        SetDefaultAuthorizerResponse SetDefaultAuthorizer(SetDefaultAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultAuthorizer">REST API Reference for SetDefaultAuthorizer Operation</seealso>
        Task<SetDefaultAuthorizerResponse> SetDefaultAuthorizerAsync(SetDefaultAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetDefaultPolicyVersion


        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version. This action affects all certificates to which the policy is attached. To
        /// list the principals the policy is attached to, use the ListPrincipalPolicy API.
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// 
        /// <returns>The response from the SetDefaultPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(string policyName, string policyVersionId);

        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version. This action affects all certificates to which the policy is attached. To
        /// list the principals the policy is attached to, use the ListPrincipalPolicy API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion service method.</param>
        /// 
        /// <returns>The response from the SetDefaultPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        SetDefaultPolicyVersionResponse SetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request);


        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version. This action affects all certificates to which the policy is attached. To
        /// list the principals the policy is attached to, use the ListPrincipalPolicy API.
        /// </summary>
        /// <param name="policyName">The policy name.</param>
        /// <param name="policyVersionId">The policy version ID.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDefaultPolicyVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(string policyName, string policyVersionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        Task<SetDefaultPolicyVersionResponse> SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetLoggingOptions


        /// <summary>
        /// Sets the logging options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoggingOptions service method.</param>
        /// 
        /// <returns>The response from the SetLoggingOptions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetLoggingOptions">REST API Reference for SetLoggingOptions Operation</seealso>
        SetLoggingOptionsResponse SetLoggingOptions(SetLoggingOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetLoggingOptions">REST API Reference for SetLoggingOptions Operation</seealso>
        Task<SetLoggingOptionsResponse> SetLoggingOptionsAsync(SetLoggingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetV2LoggingLevel


        /// <summary>
        /// Sets the logging level.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingLevel service method.</param>
        /// 
        /// <returns>The response from the SetV2LoggingLevel service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.NotConfiguredException">
        /// The resource is not configured.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingLevel">REST API Reference for SetV2LoggingLevel Operation</seealso>
        SetV2LoggingLevelResponse SetV2LoggingLevel(SetV2LoggingLevelRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetV2LoggingLevel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingLevel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingLevel">REST API Reference for SetV2LoggingLevel Operation</seealso>
        Task<SetV2LoggingLevelResponse> SetV2LoggingLevelAsync(SetV2LoggingLevelRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SetV2LoggingOptions


        /// <summary>
        /// Sets the logging options for the V2 logging service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingOptions service method.</param>
        /// 
        /// <returns>The response from the SetV2LoggingOptions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingOptions">REST API Reference for SetV2LoggingOptions Operation</seealso>
        SetV2LoggingOptionsResponse SetV2LoggingOptions(SetV2LoggingOptionsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetV2LoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingOptions">REST API Reference for SetV2LoggingOptions Operation</seealso>
        Task<SetV2LoggingOptionsResponse> SetV2LoggingOptionsAsync(SetV2LoggingOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartThingRegistrationTask


        /// <summary>
        /// Creates a bulk thing provisioning task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartThingRegistrationTask service method.</param>
        /// 
        /// <returns>The response from the StartThingRegistrationTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartThingRegistrationTask">REST API Reference for StartThingRegistrationTask Operation</seealso>
        StartThingRegistrationTaskResponse StartThingRegistrationTask(StartThingRegistrationTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StartThingRegistrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartThingRegistrationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartThingRegistrationTask">REST API Reference for StartThingRegistrationTask Operation</seealso>
        Task<StartThingRegistrationTaskResponse> StartThingRegistrationTaskAsync(StartThingRegistrationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopThingRegistrationTask


        /// <summary>
        /// Cancels a bulk thing provisioning task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopThingRegistrationTask service method.</param>
        /// 
        /// <returns>The response from the StopThingRegistrationTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StopThingRegistrationTask">REST API Reference for StopThingRegistrationTask Operation</seealso>
        StopThingRegistrationTaskResponse StopThingRegistrationTask(StopThingRegistrationTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the StopThingRegistrationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopThingRegistrationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StopThingRegistrationTask">REST API Reference for StopThingRegistrationTask Operation</seealso>
        Task<StopThingRegistrationTaskResponse> StopThingRegistrationTaskAsync(StopThingRegistrationTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestAuthorization


        /// <summary>
        /// Tests if a specified principal is authorized to perform an AWS IoT action on a specified
        /// resource. Use this to test and debug the authorization behavior of devices that connect
        /// to the AWS IoT device gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestAuthorization service method.</param>
        /// 
        /// <returns>The response from the TestAuthorization service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestAuthorization">REST API Reference for TestAuthorization Operation</seealso>
        TestAuthorizationResponse TestAuthorization(TestAuthorizationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TestAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestAuthorization">REST API Reference for TestAuthorization Operation</seealso>
        Task<TestAuthorizationResponse> TestAuthorizationAsync(TestAuthorizationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestInvokeAuthorizer


        /// <summary>
        /// Tests a custom authorization behavior by invoking a specified custom authorizer. Use
        /// this to test and debug the custom authorization behavior of devices that connect to
        /// the AWS IoT device gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer service method.</param>
        /// 
        /// <returns>The response from the TestInvokeAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidResponseException">
        /// The response is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        TestInvokeAuthorizerResponse TestInvokeAuthorizer(TestInvokeAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        Task<TestInvokeAuthorizerResponse> TestInvokeAuthorizerAsync(TestInvokeAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TransferCertificate


        /// <summary>
        /// Transfers the specified certificate to the specified AWS account.
        /// 
        ///  
        /// <para>
        /// You can cancel the transfer until it is acknowledged by the recipient.
        /// </para>
        ///  
        /// <para>
        /// No notification is sent to the transfer destination's account. It is up to the caller
        /// to notify the transfer target.
        /// </para>
        ///  
        /// <para>
        /// The certificate being transferred must not be in the ACTIVE state. You can use the
        /// UpdateCertificate API to deactivate it.
        /// </para>
        ///  
        /// <para>
        /// The certificate must not have any policies attached to it. You can use the DetachPrincipalPolicy
        /// API to detach them.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="targetAwsAccount">The AWS account.</param>
        /// 
        /// <returns>The response from the TransferCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferConflictException">
        /// You can't transfer the certificate because authorization policies are still attached.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TransferCertificate">REST API Reference for TransferCertificate Operation</seealso>
        TransferCertificateResponse TransferCertificate(string certificateId, string targetAwsAccount);

        /// <summary>
        /// Transfers the specified certificate to the specified AWS account.
        /// 
        ///  
        /// <para>
        /// You can cancel the transfer until it is acknowledged by the recipient.
        /// </para>
        ///  
        /// <para>
        /// No notification is sent to the transfer destination's account. It is up to the caller
        /// to notify the transfer target.
        /// </para>
        ///  
        /// <para>
        /// The certificate being transferred must not be in the ACTIVE state. You can use the
        /// UpdateCertificate API to deactivate it.
        /// </para>
        ///  
        /// <para>
        /// The certificate must not have any policies attached to it. You can use the DetachPrincipalPolicy
        /// API to detach them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferCertificate service method.</param>
        /// 
        /// <returns>The response from the TransferCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferConflictException">
        /// You can't transfer the certificate because authorization policies are still attached.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TransferCertificate">REST API Reference for TransferCertificate Operation</seealso>
        TransferCertificateResponse TransferCertificate(TransferCertificateRequest request);


        /// <summary>
        /// Transfers the specified certificate to the specified AWS account.
        /// 
        ///  
        /// <para>
        /// You can cancel the transfer until it is acknowledged by the recipient.
        /// </para>
        ///  
        /// <para>
        /// No notification is sent to the transfer destination's account. It is up to the caller
        /// to notify the transfer target.
        /// </para>
        ///  
        /// <para>
        /// The certificate being transferred must not be in the ACTIVE state. You can use the
        /// UpdateCertificate API to deactivate it.
        /// </para>
        ///  
        /// <para>
        /// The certificate must not have any policies attached to it. You can use the DetachPrincipalPolicy
        /// API to detach them.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="targetAwsAccount">The AWS account.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TransferCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TransferConflictException">
        /// You can't transfer the certificate because authorization policies are still attached.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TransferCertificate">REST API Reference for TransferCertificate Operation</seealso>
        Task<TransferCertificateResponse> TransferCertificateAsync(string certificateId, string targetAwsAccount, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the TransferCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TransferCertificate">REST API Reference for TransferCertificate Operation</seealso>
        Task<TransferCertificateResponse> TransferCertificateAsync(TransferCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateAuthorizer


        /// <summary>
        /// Updates an authorizer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer service method.</param>
        /// 
        /// <returns>The response from the UpdateAuthorizer service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        Task<UpdateAuthorizerResponse> UpdateAuthorizerAsync(UpdateAuthorizerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCACertificate


        /// <summary>
        /// Updates a registered CA certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCACertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateCACertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCACertificate">REST API Reference for UpdateCACertificate Operation</seealso>
        UpdateCACertificateResponse UpdateCACertificate(UpdateCACertificateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCACertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCACertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCACertificate">REST API Reference for UpdateCACertificate Operation</seealso>
        Task<UpdateCACertificateResponse> UpdateCACertificateAsync(UpdateCACertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateCertificate


        /// <summary>
        /// Updates the status of the specified certificate. This operation is idempotent.
        /// 
        ///  
        /// <para>
        /// Moving a certificate from the ACTIVE state (including REVOKED) will not disconnect
        /// currently connected devices, but these devices will be unable to reconnect.
        /// </para>
        ///  
        /// <para>
        /// The ACTIVE state is required to authenticate devices connecting to AWS IoT using a
        /// certificate.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="newStatus">The new status.  <b>Note:</b> Setting the status to PENDING_TRANSFER will result in an exception being thrown. PENDING_TRANSFER is a status used internally by AWS IoT. It is not intended for developer use.  <b>Note:</b> The status value REGISTER_INACTIVE is deprecated and should not be used.</param>
        /// 
        /// <returns>The response from the UpdateCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        UpdateCertificateResponse UpdateCertificate(string certificateId, CertificateStatus newStatus);

        /// <summary>
        /// Updates the status of the specified certificate. This operation is idempotent.
        /// 
        ///  
        /// <para>
        /// Moving a certificate from the ACTIVE state (including REVOKED) will not disconnect
        /// currently connected devices, but these devices will be unable to reconnect.
        /// </para>
        ///  
        /// <para>
        /// The ACTIVE state is required to authenticate devices connecting to AWS IoT using a
        /// certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificate service method.</param>
        /// 
        /// <returns>The response from the UpdateCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest request);


        /// <summary>
        /// Updates the status of the specified certificate. This operation is idempotent.
        /// 
        ///  
        /// <para>
        /// Moving a certificate from the ACTIVE state (including REVOKED) will not disconnect
        /// currently connected devices, but these devices will be unable to reconnect.
        /// </para>
        ///  
        /// <para>
        /// The ACTIVE state is required to authenticate devices connecting to AWS IoT using a
        /// certificate.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="newStatus">The new status.  <b>Note:</b> Setting the status to PENDING_TRANSFER will result in an exception being thrown. PENDING_TRANSFER is a status used internally by AWS IoT. It is not intended for developer use.  <b>Note:</b> The status value REGISTER_INACTIVE is deprecated and should not be used.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCertificate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateStateException">
        /// The certificate operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        Task<UpdateCertificateResponse> UpdateCertificateAsync(string certificateId, CertificateStatus newStatus, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        Task<UpdateCertificateResponse> UpdateCertificateAsync(UpdateCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateEventConfigurations


        /// <summary>
        /// Updates the event configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurations service method.</param>
        /// 
        /// <returns>The response from the UpdateEventConfigurations service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateEventConfigurations">REST API Reference for UpdateEventConfigurations Operation</seealso>
        UpdateEventConfigurationsResponse UpdateEventConfigurations(UpdateEventConfigurationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateEventConfigurations">REST API Reference for UpdateEventConfigurations Operation</seealso>
        Task<UpdateEventConfigurationsResponse> UpdateEventConfigurationsAsync(UpdateEventConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateIndexingConfiguration


        /// <summary>
        /// Updates the search configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateIndexingConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateIndexingConfiguration">REST API Reference for UpdateIndexingConfiguration Operation</seealso>
        UpdateIndexingConfigurationResponse UpdateIndexingConfiguration(UpdateIndexingConfigurationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIndexingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateIndexingConfiguration">REST API Reference for UpdateIndexingConfiguration Operation</seealso>
        Task<UpdateIndexingConfigurationResponse> UpdateIndexingConfigurationAsync(UpdateIndexingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRoleAlias


        /// <summary>
        /// Updates a role alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateRoleAlias service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateRoleAlias">REST API Reference for UpdateRoleAlias Operation</seealso>
        UpdateRoleAliasResponse UpdateRoleAlias(UpdateRoleAliasRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateRoleAlias">REST API Reference for UpdateRoleAlias Operation</seealso>
        Task<UpdateRoleAliasResponse> UpdateRoleAliasAsync(UpdateRoleAliasRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateStream


        /// <summary>
        /// Updates an existing stream. The stream version will be incremented by one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStream service method.</param>
        /// 
        /// <returns>The response from the UpdateStream service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateStream">REST API Reference for UpdateStream Operation</seealso>
        UpdateStreamResponse UpdateStream(UpdateStreamRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateStream">REST API Reference for UpdateStream Operation</seealso>
        Task<UpdateStreamResponse> UpdateStreamAsync(UpdateStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateThing


        /// <summary>
        /// Updates the data for a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThing service method.</param>
        /// 
        /// <returns>The response from the UpdateThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThing">REST API Reference for UpdateThing Operation</seealso>
        UpdateThingResponse UpdateThing(UpdateThingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThing">REST API Reference for UpdateThing Operation</seealso>
        Task<UpdateThingResponse> UpdateThingAsync(UpdateThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateThingGroup


        /// <summary>
        /// Update a thing group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroup">REST API Reference for UpdateThingGroup Operation</seealso>
        UpdateThingGroupResponse UpdateThingGroup(UpdateThingGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroup">REST API Reference for UpdateThingGroup Operation</seealso>
        Task<UpdateThingGroupResponse> UpdateThingGroupAsync(UpdateThingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateThingGroupsForThing


        /// <summary>
        /// Updates the groups to which the thing belongs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroupsForThing service method.</param>
        /// 
        /// <returns>The response from the UpdateThingGroupsForThing service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroupsForThing">REST API Reference for UpdateThingGroupsForThing Operation</seealso>
        UpdateThingGroupsForThingResponse UpdateThingGroupsForThing(UpdateThingGroupsForThingRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThingGroupsForThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroupsForThing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroupsForThing">REST API Reference for UpdateThingGroupsForThing Operation</seealso>
        Task<UpdateThingGroupsForThingResponse> UpdateThingGroupsForThingAsync(UpdateThingGroupsForThingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}