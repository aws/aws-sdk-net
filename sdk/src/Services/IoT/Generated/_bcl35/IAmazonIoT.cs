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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoT.Model;

namespace Amazon.IoT
{
    /// <summary>
    /// Interface for accessing IoT
    ///
    /// IoT 
    /// <para>
    /// IoT provides secure, bi-directional communication between Internet-connected devices
    /// (such as sensors, actuators, embedded devices, or smart appliances) and the Amazon
    /// Web Services cloud. You can discover your custom IoT-Data endpoint to communicate
    /// with, configure rules for data processing and integration with other services, organize
    /// resources associated with each device (Registry), configure logging, and create and
    /// manage policies and credentials to authenticate devices.
    /// </para>
    ///  
    /// <para>
    /// The service endpoints that expose this API are listed in <a href="https://docs.aws.amazon.com/general/latest/gr/iot-core.html">Amazon
    /// Web Services IoT Core Endpoints and Quotas</a>. You must use the endpoint for the
    /// region that has the resources you want to access.
    /// </para>
    ///  
    /// <para>
    /// The service name used by <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Amazon
    /// Web Services Signature Version 4</a> to sign the request is: <i>execute-api</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about how IoT works, see the <a href="https://docs.aws.amazon.com/iot/latest/developerguide/aws-iot-how-it-works.html">Developer
    /// Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about how to use the credentials provider for IoT, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/authorizing-direct-aws.html">Authorizing
    /// Direct Calls to Amazon Web Services Services</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonIoT : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTPaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptCertificateTransfer


        /// <summary>
        /// Accepts a pending certificate transfer. The default state of the certificate is INACTIVE.
        /// 
        ///  
        /// <para>
        /// To check for pending certificate transfers, call <a>ListCertificates</a> to enumerate
        /// your certificates.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AcceptCertificateTransfer</a>
        /// action.
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
        /// <param name="request">Container for the necessary parameters to execute the AcceptCertificateTransfer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptCertificateTransfer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AcceptCertificateTransfer">REST API Reference for AcceptCertificateTransfer Operation</seealso>
        IAsyncResult BeginAcceptCertificateTransfer(AcceptCertificateTransferRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptCertificateTransfer.</param>
        /// 
        /// <returns>Returns a  AcceptCertificateTransferResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AcceptCertificateTransfer">REST API Reference for AcceptCertificateTransfer Operation</seealso>
        AcceptCertificateTransferResponse EndAcceptCertificateTransfer(IAsyncResult asyncResult);

        #endregion
        
        #region  AddThingToBillingGroup


        /// <summary>
        /// Adds a thing to a billing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AddThingToBillingGroup</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddThingToBillingGroup service method.</param>
        /// 
        /// <returns>The response from the AddThingToBillingGroup service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToBillingGroup">REST API Reference for AddThingToBillingGroup Operation</seealso>
        AddThingToBillingGroupResponse AddThingToBillingGroup(AddThingToBillingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddThingToBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddThingToBillingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddThingToBillingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToBillingGroup">REST API Reference for AddThingToBillingGroup Operation</seealso>
        IAsyncResult BeginAddThingToBillingGroup(AddThingToBillingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddThingToBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddThingToBillingGroup.</param>
        /// 
        /// <returns>Returns a  AddThingToBillingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToBillingGroup">REST API Reference for AddThingToBillingGroup Operation</seealso>
        AddThingToBillingGroupResponse EndAddThingToBillingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  AddThingToThingGroup


        /// <summary>
        /// Adds a thing to a thing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AddThingToThingGroup</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the AddThingToThingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddThingToThingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToThingGroup">REST API Reference for AddThingToThingGroup Operation</seealso>
        IAsyncResult BeginAddThingToThingGroup(AddThingToThingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddThingToThingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddThingToThingGroup.</param>
        /// 
        /// <returns>Returns a  AddThingToThingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AddThingToThingGroup">REST API Reference for AddThingToThingGroup Operation</seealso>
        AddThingToThingGroupResponse EndAddThingToThingGroup(IAsyncResult asyncResult);

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
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AssociateTargetsWithJob</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the AssociateTargetsWithJob operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTargetsWithJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AssociateTargetsWithJob">REST API Reference for AssociateTargetsWithJob Operation</seealso>
        IAsyncResult BeginAssociateTargetsWithJob(AssociateTargetsWithJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTargetsWithJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTargetsWithJob.</param>
        /// 
        /// <returns>Returns a  AssociateTargetsWithJobResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AssociateTargetsWithJob">REST API Reference for AssociateTargetsWithJob Operation</seealso>
        AssociateTargetsWithJobResponse EndAssociateTargetsWithJob(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachPolicy


        /// <summary>
        /// Attaches the specified policy to the specified principal (certificate or other credential).
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AttachPolicy</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        IAsyncResult BeginAttachPolicy(AttachPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachPolicy.</param>
        /// 
        /// <returns>Returns a  AttachPolicyResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        AttachPolicyResponse EndAttachPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachPrincipalPolicy


        /// <summary>
        /// Attaches the specified policy to the specified principal (certificate or other credential).
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This action is deprecated and works as expected for backward compatibility,
        /// but we won't add enhancements. Use <a>AttachPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AttachPrincipalPolicy</a>
        /// action.
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
        ///  <b>Note:</b> This action is deprecated and works as expected for backward compatibility,
        /// but we won't add enhancements. Use <a>AttachPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AttachPrincipalPolicy</a>
        /// action.
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
        /// Initiates the asynchronous execution of the AttachPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPrincipalPolicy operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachPrincipalPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPrincipalPolicy">REST API Reference for AttachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of AttachPolicy.")]
        IAsyncResult BeginAttachPrincipalPolicy(AttachPrincipalPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachPrincipalPolicy.</param>
        /// 
        /// <returns>Returns a  AttachPrincipalPolicyResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachPrincipalPolicy">REST API Reference for AttachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of AttachPolicy.")]
        AttachPrincipalPolicyResponse EndAttachPrincipalPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachSecurityProfile


        /// <summary>
        /// Associates a Device Defender security profile with a thing group or this account.
        /// Each thing group or account can have up to five security profiles associated with
        /// it.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AttachSecurityProfile</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the AttachSecurityProfile service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachSecurityProfile">REST API Reference for AttachSecurityProfile Operation</seealso>
        AttachSecurityProfileResponse AttachSecurityProfile(AttachSecurityProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachSecurityProfile operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachSecurityProfile">REST API Reference for AttachSecurityProfile Operation</seealso>
        IAsyncResult BeginAttachSecurityProfile(AttachSecurityProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachSecurityProfile.</param>
        /// 
        /// <returns>Returns a  AttachSecurityProfileResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachSecurityProfile">REST API Reference for AttachSecurityProfile Operation</seealso>
        AttachSecurityProfileResponse EndAttachSecurityProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachThingPrincipal


        /// <summary>
        /// Attaches the specified principal to the specified thing. A principal can be X.509
        /// certificates, Amazon Cognito identities or federated identities.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AttachThingPrincipal</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="thingName">The name of the thing.</param>
        /// <param name="principal">The principal, which can be a certificate ARN (as returned from the CreateCertificate operation) or an Amazon Cognito ID.</param>
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
        /// Attaches the specified principal to the specified thing. A principal can be X.509
        /// certificates, Amazon Cognito identities or federated identities.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">AttachThingPrincipal</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the AttachThingPrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachThingPrincipal operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachThingPrincipal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachThingPrincipal">REST API Reference for AttachThingPrincipal Operation</seealso>
        IAsyncResult BeginAttachThingPrincipal(AttachThingPrincipalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachThingPrincipal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachThingPrincipal.</param>
        /// 
        /// <returns>Returns a  AttachThingPrincipalResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/AttachThingPrincipal">REST API Reference for AttachThingPrincipal Operation</seealso>
        AttachThingPrincipalResponse EndAttachThingPrincipal(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelAuditMitigationActionsTask


        /// <summary>
        /// Cancels a mitigation action task that is in progress. If the task is not in progress,
        /// an InvalidRequestException occurs.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CancelAuditMitigationActionsTask</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAuditMitigationActionsTask service method.</param>
        /// 
        /// <returns>The response from the CancelAuditMitigationActionsTask service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelAuditMitigationActionsTask">REST API Reference for CancelAuditMitigationActionsTask Operation</seealso>
        CancelAuditMitigationActionsTaskResponse CancelAuditMitigationActionsTask(CancelAuditMitigationActionsTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelAuditMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelAuditMitigationActionsTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelAuditMitigationActionsTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelAuditMitigationActionsTask">REST API Reference for CancelAuditMitigationActionsTask Operation</seealso>
        IAsyncResult BeginCancelAuditMitigationActionsTask(CancelAuditMitigationActionsTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelAuditMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelAuditMitigationActionsTask.</param>
        /// 
        /// <returns>Returns a  CancelAuditMitigationActionsTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelAuditMitigationActionsTask">REST API Reference for CancelAuditMitigationActionsTask Operation</seealso>
        CancelAuditMitigationActionsTaskResponse EndCancelAuditMitigationActionsTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelAuditTask


        /// <summary>
        /// Cancels an audit that is in progress. The audit can be either scheduled or on demand.
        /// If the audit isn't in progress, an "InvalidRequestException" occurs.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CancelAuditTask</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelAuditTask service method.</param>
        /// 
        /// <returns>The response from the CancelAuditTask service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelAuditTask">REST API Reference for CancelAuditTask Operation</seealso>
        CancelAuditTaskResponse CancelAuditTask(CancelAuditTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelAuditTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelAuditTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelAuditTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelAuditTask">REST API Reference for CancelAuditTask Operation</seealso>
        IAsyncResult BeginCancelAuditTask(CancelAuditTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelAuditTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelAuditTask.</param>
        /// 
        /// <returns>Returns a  CancelAuditTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelAuditTask">REST API Reference for CancelAuditTask Operation</seealso>
        CancelAuditTaskResponse EndCancelAuditTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelCertificateTransfer


        /// <summary>
        /// Cancels a pending transfer for the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> Only the transfer source account can use this operation to cancel a transfer.
        /// (Transfer destinations can use <a>RejectCertificateTransfer</a> instead.) After transfer,
        /// IoT returns the certificate to the source account in the INACTIVE state. After the
        /// destination account has accepted the transfer, the transfer cannot be cancelled.
        /// </para>
        ///  
        /// <para>
        /// After a certificate transfer is cancelled, the status of the certificate changes from
        /// PENDING_TRANSFER to INACTIVE.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CancelCertificateTransfer</a>
        /// action.
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
        /// IoT returns the certificate to the source account in the INACTIVE state. After the
        /// destination account has accepted the transfer, the transfer cannot be cancelled.
        /// </para>
        ///  
        /// <para>
        /// After a certificate transfer is cancelled, the status of the certificate changes from
        /// PENDING_TRANSFER to INACTIVE.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CancelCertificateTransfer</a>
        /// action.
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
        /// Initiates the asynchronous execution of the CancelCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelCertificateTransfer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelCertificateTransfer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelCertificateTransfer">REST API Reference for CancelCertificateTransfer Operation</seealso>
        IAsyncResult BeginCancelCertificateTransfer(CancelCertificateTransferRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelCertificateTransfer.</param>
        /// 
        /// <returns>Returns a  CancelCertificateTransferResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelCertificateTransfer">REST API Reference for CancelCertificateTransfer Operation</seealso>
        CancelCertificateTransferResponse EndCancelCertificateTransfer(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelDetectMitigationActionsTask


        /// <summary>
        /// Cancels a Device Defender ML Detect mitigation action. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CancelDetectMitigationActionsTask</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDetectMitigationActionsTask service method.</param>
        /// 
        /// <returns>The response from the CancelDetectMitigationActionsTask service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelDetectMitigationActionsTask">REST API Reference for CancelDetectMitigationActionsTask Operation</seealso>
        CancelDetectMitigationActionsTaskResponse CancelDetectMitigationActionsTask(CancelDetectMitigationActionsTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelDetectMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelDetectMitigationActionsTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelDetectMitigationActionsTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelDetectMitigationActionsTask">REST API Reference for CancelDetectMitigationActionsTask Operation</seealso>
        IAsyncResult BeginCancelDetectMitigationActionsTask(CancelDetectMitigationActionsTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelDetectMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelDetectMitigationActionsTask.</param>
        /// 
        /// <returns>Returns a  CancelDetectMitigationActionsTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelDetectMitigationActionsTask">REST API Reference for CancelDetectMitigationActionsTask Operation</seealso>
        CancelDetectMitigationActionsTaskResponse EndCancelDetectMitigationActionsTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelJob


        /// <summary>
        /// Cancels a job.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CancelJob</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelJob service method.</param>
        /// 
        /// <returns>The response from the CancelJob service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJob">REST API Reference for CancelJob Operation</seealso>
        CancelJobResponse CancelJob(CancelJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelJob operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJob">REST API Reference for CancelJob Operation</seealso>
        IAsyncResult BeginCancelJob(CancelJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJob.</param>
        /// 
        /// <returns>Returns a  CancelJobResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJob">REST API Reference for CancelJob Operation</seealso>
        CancelJobResponse EndCancelJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelJobExecution


        /// <summary>
        /// Cancels the execution of a job for a given thing.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CancelJobExecution</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the CancelJobExecution operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelJobExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJobExecution">REST API Reference for CancelJobExecution Operation</seealso>
        IAsyncResult BeginCancelJobExecution(CancelJobExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelJobExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelJobExecution.</param>
        /// 
        /// <returns>Returns a  CancelJobExecutionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CancelJobExecution">REST API Reference for CancelJobExecution Operation</seealso>
        CancelJobExecutionResponse EndCancelJobExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  ClearDefaultAuthorizer


        /// <summary>
        /// Clears the default authorizer.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ClearDefaultAuthorizer</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ClearDefaultAuthorizer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndClearDefaultAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ClearDefaultAuthorizer">REST API Reference for ClearDefaultAuthorizer Operation</seealso>
        IAsyncResult BeginClearDefaultAuthorizer(ClearDefaultAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ClearDefaultAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginClearDefaultAuthorizer.</param>
        /// 
        /// <returns>Returns a  ClearDefaultAuthorizerResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ClearDefaultAuthorizer">REST API Reference for ClearDefaultAuthorizer Operation</seealso>
        ClearDefaultAuthorizerResponse EndClearDefaultAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmTopicRuleDestination


        /// <summary>
        /// Confirms a topic rule destination. When you create a rule requiring a destination,
        /// IoT sends a confirmation message to the endpoint or base address you specify. The
        /// message includes a token which you pass back when calling <code>ConfirmTopicRuleDestination</code>
        /// to confirm that you own or have access to the endpoint.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ConfirmTopicRuleDestination</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmTopicRuleDestination service method.</param>
        /// 
        /// <returns>The response from the ConfirmTopicRuleDestination service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ConfirmTopicRuleDestination">REST API Reference for ConfirmTopicRuleDestination Operation</seealso>
        ConfirmTopicRuleDestinationResponse ConfirmTopicRuleDestination(ConfirmTopicRuleDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmTopicRuleDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmTopicRuleDestination operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmTopicRuleDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ConfirmTopicRuleDestination">REST API Reference for ConfirmTopicRuleDestination Operation</seealso>
        IAsyncResult BeginConfirmTopicRuleDestination(ConfirmTopicRuleDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmTopicRuleDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmTopicRuleDestination.</param>
        /// 
        /// <returns>Returns a  ConfirmTopicRuleDestinationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ConfirmTopicRuleDestination">REST API Reference for ConfirmTopicRuleDestination Operation</seealso>
        ConfirmTopicRuleDestinationResponse EndConfirmTopicRuleDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAuditSuppression


        /// <summary>
        /// Creates a Device Defender audit suppression. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateAuditSuppression</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAuditSuppression service method.</param>
        /// 
        /// <returns>The response from the CreateAuditSuppression service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateAuditSuppression">REST API Reference for CreateAuditSuppression Operation</seealso>
        CreateAuditSuppressionResponse CreateAuditSuppression(CreateAuditSuppressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuditSuppression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuditSuppression operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAuditSuppression
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateAuditSuppression">REST API Reference for CreateAuditSuppression Operation</seealso>
        IAsyncResult BeginCreateAuditSuppression(CreateAuditSuppressionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAuditSuppression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAuditSuppression.</param>
        /// 
        /// <returns>Returns a  CreateAuditSuppressionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateAuditSuppression">REST API Reference for CreateAuditSuppression Operation</seealso>
        CreateAuditSuppressionResponse EndCreateAuditSuppression(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAuthorizer


        /// <summary>
        /// Creates an authorizer.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateAuthorizer</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        IAsyncResult BeginCreateAuthorizer(CreateAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAuthorizer.</param>
        /// 
        /// <returns>Returns a  CreateAuthorizerResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateAuthorizer">REST API Reference for CreateAuthorizer Operation</seealso>
        CreateAuthorizerResponse EndCreateAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBillingGroup


        /// <summary>
        /// Creates a billing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateBillingGroup</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateBillingGroup service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        CreateBillingGroupResponse CreateBillingGroup(CreateBillingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBillingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBillingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        IAsyncResult BeginCreateBillingGroup(CreateBillingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBillingGroup.</param>
        /// 
        /// <returns>Returns a  CreateBillingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateBillingGroup">REST API Reference for CreateBillingGroup Operation</seealso>
        CreateBillingGroupResponse EndCreateBillingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCertificateFromCsr


        /// <summary>
        /// Creates an X.509 certificate using the specified certificate signing request.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> The CSR must include a public key that is either an RSA key with a length
        /// of at least 2048 bits or an ECC key from NIST P-256, NIST P-384, or NIST P-512 curves.
        /// For supported certificates, consult <a href="https://docs.aws.amazon.com/iot/latest/developerguide/x509-client-certs.html#x509-cert-algorithms">
        /// Certificate signing algorithms supported by IoT</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateCertificateFromCsr</a>
        /// action.
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
        /// to the aws iot create-certificate-from-csr Amazon Web Services CLI command to create
        /// a certificate for the corresponding CSR.
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
        /// of at least 2048 bits or an ECC key from NIST P-256, NIST P-384, or NIST P-512 curves.
        /// For supported certificates, consult <a href="https://docs.aws.amazon.com/iot/latest/developerguide/x509-client-certs.html#x509-cert-algorithms">
        /// Certificate signing algorithms supported by IoT</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateCertificateFromCsr</a>
        /// action.
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
        /// to the aws iot create-certificate-from-csr Amazon Web Services CLI command to create
        /// a certificate for the corresponding CSR.
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
        /// of at least 2048 bits or an ECC key from NIST P-256, NIST P-384, or NIST P-512 curves.
        /// For supported certificates, consult <a href="https://docs.aws.amazon.com/iot/latest/developerguide/x509-client-certs.html#x509-cert-algorithms">
        /// Certificate signing algorithms supported by IoT</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> Reusing the same certificate signing request (CSR) results in a distinct
        /// certificate.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateCertificateFromCsr</a>
        /// action.
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
        /// to the aws iot create-certificate-from-csr Amazon Web Services CLI command to create
        /// a certificate for the corresponding CSR.
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
        /// Initiates the asynchronous execution of the CreateCertificateFromCsr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCertificateFromCsr operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCertificateFromCsr
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        IAsyncResult BeginCreateCertificateFromCsr(CreateCertificateFromCsrRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCertificateFromCsr operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCertificateFromCsr.</param>
        /// 
        /// <returns>Returns a  CreateCertificateFromCsrResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCertificateFromCsr">REST API Reference for CreateCertificateFromCsr Operation</seealso>
        CreateCertificateFromCsrResponse EndCreateCertificateFromCsr(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCustomMetric


        /// <summary>
        /// Use this API to define a Custom Metric published by your devices to Device Defender.
        /// 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateCustomMetric</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomMetric service method.</param>
        /// 
        /// <returns>The response from the CreateCustomMetric service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCustomMetric">REST API Reference for CreateCustomMetric Operation</seealso>
        CreateCustomMetricResponse CreateCustomMetric(CreateCustomMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomMetric operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomMetric
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCustomMetric">REST API Reference for CreateCustomMetric Operation</seealso>
        IAsyncResult BeginCreateCustomMetric(CreateCustomMetricRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomMetric operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomMetric.</param>
        /// 
        /// <returns>Returns a  CreateCustomMetricResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateCustomMetric">REST API Reference for CreateCustomMetric Operation</seealso>
        CreateCustomMetricResponse EndCreateCustomMetric(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDimension


        /// <summary>
        /// Create a dimension that you can use to limit the scope of a metric used in a security
        /// profile for IoT Device Defender. For example, using a <code>TOPIC_FILTER</code> dimension,
        /// you can narrow down the scope of the metric only to MQTT topics whose name match the
        /// pattern specified in the dimension.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateDimension</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDimension service method.</param>
        /// 
        /// <returns>The response from the CreateDimension service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDimension">REST API Reference for CreateDimension Operation</seealso>
        CreateDimensionResponse CreateDimension(CreateDimensionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDimension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDimension operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDimension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDimension">REST API Reference for CreateDimension Operation</seealso>
        IAsyncResult BeginCreateDimension(CreateDimensionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDimension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDimension.</param>
        /// 
        /// <returns>Returns a  CreateDimensionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDimension">REST API Reference for CreateDimension Operation</seealso>
        CreateDimensionResponse EndCreateDimension(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDomainConfiguration


        /// <summary>
        /// Creates a domain configuration.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateDomainConfiguration</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateDomainConfiguration service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDomainConfiguration">REST API Reference for CreateDomainConfiguration Operation</seealso>
        CreateDomainConfigurationResponse CreateDomainConfiguration(CreateDomainConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainConfiguration operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDomainConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDomainConfiguration">REST API Reference for CreateDomainConfiguration Operation</seealso>
        IAsyncResult BeginCreateDomainConfiguration(CreateDomainConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDomainConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDomainConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateDomainConfigurationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDomainConfiguration">REST API Reference for CreateDomainConfiguration Operation</seealso>
        CreateDomainConfigurationResponse EndCreateDomainConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDynamicThingGroup


        /// <summary>
        /// Creates a dynamic thing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateDynamicThingGroup</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDynamicThingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateDynamicThingGroup service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidQueryException">
        /// The query is invalid.
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
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDynamicThingGroup">REST API Reference for CreateDynamicThingGroup Operation</seealso>
        CreateDynamicThingGroupResponse CreateDynamicThingGroup(CreateDynamicThingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDynamicThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDynamicThingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDynamicThingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDynamicThingGroup">REST API Reference for CreateDynamicThingGroup Operation</seealso>
        IAsyncResult BeginCreateDynamicThingGroup(CreateDynamicThingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDynamicThingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDynamicThingGroup.</param>
        /// 
        /// <returns>Returns a  CreateDynamicThingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateDynamicThingGroup">REST API Reference for CreateDynamicThingGroup Operation</seealso>
        CreateDynamicThingGroupResponse EndCreateDynamicThingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFleetMetric


        /// <summary>
        /// Creates a fleet metric.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateFleetMetric</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleetMetric service method.</param>
        /// 
        /// <returns>The response from the CreateFleetMetric service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidAggregationException">
        /// The aggregation is invalid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidQueryException">
        /// The query is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateFleetMetric">REST API Reference for CreateFleetMetric Operation</seealso>
        CreateFleetMetricResponse CreateFleetMetric(CreateFleetMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleetMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleetMetric operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleetMetric
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateFleetMetric">REST API Reference for CreateFleetMetric Operation</seealso>
        IAsyncResult BeginCreateFleetMetric(CreateFleetMetricRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleetMetric operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleetMetric.</param>
        /// 
        /// <returns>Returns a  CreateFleetMetricResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateFleetMetric">REST API Reference for CreateFleetMetric Operation</seealso>
        CreateFleetMetricResponse EndCreateFleetMetric(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Creates a job.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateJob</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateJob">REST API Reference for CreateJob Operation</seealso>
        IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateJob">REST API Reference for CreateJob Operation</seealso>
        CreateJobResponse EndCreateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateJobTemplate


        /// <summary>
        /// Creates a job template.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateJobTemplate</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJobTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateJobTemplate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictException">
        /// A resource with the same name already exists.
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
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        CreateJobTemplateResponse CreateJobTemplate(CreateJobTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJobTemplate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        IAsyncResult BeginCreateJobTemplate(CreateJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJobTemplate.</param>
        /// 
        /// <returns>Returns a  CreateJobTemplateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateJobTemplate">REST API Reference for CreateJobTemplate Operation</seealso>
        CreateJobTemplateResponse EndCreateJobTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKeysAndCertificate


        /// <summary>
        /// Creates a 2048-bit RSA key pair and issues an X.509 certificate using the issued public
        /// key. You can also call <code>CreateKeysAndCertificate</code> over MQTT from a device,
        /// for more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/provision-wo-cert.html#provision-mqtt-api">Provisioning
        /// MQTT API</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateKeysAndCertificate</a>
        /// action.
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
        /// key. You can also call <code>CreateKeysAndCertificate</code> over MQTT from a device,
        /// for more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/provision-wo-cert.html#provision-mqtt-api">Provisioning
        /// MQTT API</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateKeysAndCertificate</a>
        /// action.
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
        /// key. You can also call <code>CreateKeysAndCertificate</code> over MQTT from a device,
        /// for more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/provision-wo-cert.html#provision-mqtt-api">Provisioning
        /// MQTT API</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note</b> This is the only time IoT issues the private key for this certificate,
        /// so it is important to keep it in a secure location.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateKeysAndCertificate</a>
        /// action.
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
        /// Initiates the asynchronous execution of the CreateKeysAndCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeysAndCertificate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKeysAndCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        IAsyncResult BeginCreateKeysAndCertificate(CreateKeysAndCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKeysAndCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeysAndCertificate.</param>
        /// 
        /// <returns>Returns a  CreateKeysAndCertificateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateKeysAndCertificate">REST API Reference for CreateKeysAndCertificate Operation</seealso>
        CreateKeysAndCertificateResponse EndCreateKeysAndCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMitigationAction


        /// <summary>
        /// Defines an action that can be applied to audit findings by using StartAuditMitigationActionsTask.
        /// Only certain types of mitigation actions can be applied to specific check names. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/device-defender-mitigation-actions.html">Mitigation
        /// actions</a>. Each mitigation action can apply only one type of change.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateMitigationAction</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMitigationAction service method.</param>
        /// 
        /// <returns>The response from the CreateMitigationAction service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateMitigationAction">REST API Reference for CreateMitigationAction Operation</seealso>
        CreateMitigationActionResponse CreateMitigationAction(CreateMitigationActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMitigationAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMitigationAction operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMitigationAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateMitigationAction">REST API Reference for CreateMitigationAction Operation</seealso>
        IAsyncResult BeginCreateMitigationAction(CreateMitigationActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMitigationAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMitigationAction.</param>
        /// 
        /// <returns>Returns a  CreateMitigationActionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateMitigationAction">REST API Reference for CreateMitigationAction Operation</seealso>
        CreateMitigationActionResponse EndCreateMitigationAction(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateOTAUpdate


        /// <summary>
        /// Creates an IoT OTA update on a target group of things or groups.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateOTAUpdate</a>
        /// action.
        /// </para>
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
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateOTAUpdate">REST API Reference for CreateOTAUpdate Operation</seealso>
        CreateOTAUpdateResponse CreateOTAUpdate(CreateOTAUpdateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOTAUpdate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateOTAUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateOTAUpdate">REST API Reference for CreateOTAUpdate Operation</seealso>
        IAsyncResult BeginCreateOTAUpdate(CreateOTAUpdateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateOTAUpdate.</param>
        /// 
        /// <returns>Returns a  CreateOTAUpdateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateOTAUpdate">REST API Reference for CreateOTAUpdate Operation</seealso>
        CreateOTAUpdateResponse EndCreateOTAUpdate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePolicy


        /// <summary>
        /// Creates an IoT policy.
        /// 
        ///  
        /// <para>
        /// The created policy is the default version for the policy. This operation creates a
        /// policy version with a version identifier of <b>1</b> and sets <b>1</b> as the policy's
        /// default version.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreatePolicy</a>
        /// action.
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
        /// Creates an IoT policy.
        /// 
        ///  
        /// <para>
        /// The created policy is the default version for the policy. This operation creates a
        /// policy version with a version identifier of <b>1</b> and sets <b>1</b> as the policy's
        /// default version.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreatePolicy</a>
        /// action.
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
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        IAsyncResult BeginCreatePolicy(CreatePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicy.</param>
        /// 
        /// <returns>Returns a  CreatePolicyResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        CreatePolicyResponse EndCreatePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePolicyVersion


        /// <summary>
        /// Creates a new version of the specified IoT policy. To update a policy, create a new
        /// policy version. A managed policy can have up to five versions. If the policy has five
        /// versions, you must use <a>DeletePolicyVersion</a> to delete an existing version before
        /// you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreatePolicyVersion</a>
        /// action.
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
        /// Creates a new version of the specified IoT policy. To update a policy, create a new
        /// policy version. A managed policy can have up to five versions. If the policy has five
        /// versions, you must use <a>DeletePolicyVersion</a> to delete an existing version before
        /// you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreatePolicyVersion</a>
        /// action.
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
        /// Creates a new version of the specified IoT policy. To update a policy, create a new
        /// policy version. A managed policy can have up to five versions. If the policy has five
        /// versions, you must use <a>DeletePolicyVersion</a> to delete an existing version before
        /// you create a new one.
        /// 
        ///  
        /// <para>
        /// Optionally, you can set the new version as the policy's default version. The default
        /// version is the operative version (that is, the version that is in effect for the certificates
        /// to which the policy is attached).
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreatePolicyVersion</a>
        /// action.
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
        /// Initiates the asynchronous execution of the CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        IAsyncResult BeginCreatePolicyVersion(CreatePolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePolicyVersion.</param>
        /// 
        /// <returns>Returns a  CreatePolicyVersionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        CreatePolicyVersionResponse EndCreatePolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProvisioningClaim


        /// <summary>
        /// Creates a provisioning claim.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateProvisioningClaim</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningClaim service method.</param>
        /// 
        /// <returns>The response from the CreateProvisioningClaim service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningClaim">REST API Reference for CreateProvisioningClaim Operation</seealso>
        CreateProvisioningClaimResponse CreateProvisioningClaim(CreateProvisioningClaimRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisioningClaim operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningClaim operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProvisioningClaim
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningClaim">REST API Reference for CreateProvisioningClaim Operation</seealso>
        IAsyncResult BeginCreateProvisioningClaim(CreateProvisioningClaimRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisioningClaim operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisioningClaim.</param>
        /// 
        /// <returns>Returns a  CreateProvisioningClaimResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningClaim">REST API Reference for CreateProvisioningClaim Operation</seealso>
        CreateProvisioningClaimResponse EndCreateProvisioningClaim(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProvisioningTemplate


        /// <summary>
        /// Creates a provisioning template.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateProvisioningTemplate</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateProvisioningTemplate service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningTemplate">REST API Reference for CreateProvisioningTemplate Operation</seealso>
        CreateProvisioningTemplateResponse CreateProvisioningTemplate(CreateProvisioningTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisioningTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningTemplate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProvisioningTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningTemplate">REST API Reference for CreateProvisioningTemplate Operation</seealso>
        IAsyncResult BeginCreateProvisioningTemplate(CreateProvisioningTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisioningTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisioningTemplate.</param>
        /// 
        /// <returns>Returns a  CreateProvisioningTemplateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningTemplate">REST API Reference for CreateProvisioningTemplate Operation</seealso>
        CreateProvisioningTemplateResponse EndCreateProvisioningTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateProvisioningTemplateVersion


        /// <summary>
        /// Creates a new version of a provisioning template.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateProvisioningTemplateVersion</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the CreateProvisioningTemplateVersion service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningTemplateVersion">REST API Reference for CreateProvisioningTemplateVersion Operation</seealso>
        CreateProvisioningTemplateVersionResponse CreateProvisioningTemplateVersion(CreateProvisioningTemplateVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProvisioningTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProvisioningTemplateVersion operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProvisioningTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningTemplateVersion">REST API Reference for CreateProvisioningTemplateVersion Operation</seealso>
        IAsyncResult BeginCreateProvisioningTemplateVersion(CreateProvisioningTemplateVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProvisioningTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProvisioningTemplateVersion.</param>
        /// 
        /// <returns>Returns a  CreateProvisioningTemplateVersionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateProvisioningTemplateVersion">REST API Reference for CreateProvisioningTemplateVersion Operation</seealso>
        CreateProvisioningTemplateVersionResponse EndCreateProvisioningTemplateVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoleAlias


        /// <summary>
        /// Creates a role alias.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateRoleAlias</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateRoleAlias operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoleAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateRoleAlias">REST API Reference for CreateRoleAlias Operation</seealso>
        IAsyncResult BeginCreateRoleAlias(CreateRoleAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoleAlias.</param>
        /// 
        /// <returns>Returns a  CreateRoleAliasResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateRoleAlias">REST API Reference for CreateRoleAlias Operation</seealso>
        CreateRoleAliasResponse EndCreateRoleAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateScheduledAudit


        /// <summary>
        /// Creates a scheduled audit that is run at a specified time interval.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateScheduledAudit</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAudit service method.</param>
        /// 
        /// <returns>The response from the CreateScheduledAudit service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateScheduledAudit">REST API Reference for CreateScheduledAudit Operation</seealso>
        CreateScheduledAuditResponse CreateScheduledAudit(CreateScheduledAuditRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAudit operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScheduledAudit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateScheduledAudit">REST API Reference for CreateScheduledAudit Operation</seealso>
        IAsyncResult BeginCreateScheduledAudit(CreateScheduledAuditRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScheduledAudit.</param>
        /// 
        /// <returns>Returns a  CreateScheduledAuditResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateScheduledAudit">REST API Reference for CreateScheduledAudit Operation</seealso>
        CreateScheduledAuditResponse EndCreateScheduledAudit(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSecurityProfile


        /// <summary>
        /// Creates a Device Defender security profile.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateSecurityProfile</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityProfile service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateSecurityProfile">REST API Reference for CreateSecurityProfile Operation</seealso>
        CreateSecurityProfileResponse CreateSecurityProfile(CreateSecurityProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityProfile operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateSecurityProfile">REST API Reference for CreateSecurityProfile Operation</seealso>
        IAsyncResult BeginCreateSecurityProfile(CreateSecurityProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityProfile.</param>
        /// 
        /// <returns>Returns a  CreateSecurityProfileResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateSecurityProfile">REST API Reference for CreateSecurityProfile Operation</seealso>
        CreateSecurityProfileResponse EndCreateSecurityProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStream


        /// <summary>
        /// Creates a stream for delivering one or more large files in chunks over MQTT. A stream
        /// transports data bytes in chunks or blocks packaged as MQTT messages from a source
        /// like S3. You can have one or more files associated with a stream.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateStream</a>
        /// action.
        /// </para>
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
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateStream">REST API Reference for CreateStream Operation</seealso>
        CreateStreamResponse CreateStream(CreateStreamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStream operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateStream">REST API Reference for CreateStream Operation</seealso>
        IAsyncResult BeginCreateStream(CreateStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStream.</param>
        /// 
        /// <returns>Returns a  CreateStreamResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateStream">REST API Reference for CreateStream Operation</seealso>
        CreateStreamResponse EndCreateStream(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateThing


        /// <summary>
        /// Creates a thing record in the registry. If this call is made multiple times using
        /// the same thing name and configuration, the call will succeed. If this call is made
        /// with the same thing name but different configuration a <code>ResourceAlreadyExistsException</code>
        /// is thrown.
        /// 
        ///  <note> 
        /// <para>
        /// This is a control plane operation. See <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-authorization.html">Authorization</a>
        /// for information about authorizing control plane actions.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateThing</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateThing operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThing">REST API Reference for CreateThing Operation</seealso>
        IAsyncResult BeginCreateThing(CreateThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateThing.</param>
        /// 
        /// <returns>Returns a  CreateThingResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThing">REST API Reference for CreateThing Operation</seealso>
        CreateThingResponse EndCreateThing(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateThingGroup


        /// <summary>
        /// Create a thing group.
        /// 
        ///  <note> 
        /// <para>
        /// This is a control plane operation. See <a href="https://docs.aws.amazon.com/iot/latest/developerguide/iot-authorization.html">Authorization</a>
        /// for information about authorizing control plane actions.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateThingGroup</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateThingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateThingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingGroup">REST API Reference for CreateThingGroup Operation</seealso>
        IAsyncResult BeginCreateThingGroup(CreateThingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateThingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateThingGroup.</param>
        /// 
        /// <returns>Returns a  CreateThingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingGroup">REST API Reference for CreateThingGroup Operation</seealso>
        CreateThingGroupResponse EndCreateThingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateThingType


        /// <summary>
        /// Creates a new thing type.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateThingType</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateThingType operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateThingType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingType">REST API Reference for CreateThingType Operation</seealso>
        IAsyncResult BeginCreateThingType(CreateThingTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateThingType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateThingType.</param>
        /// 
        /// <returns>Returns a  CreateThingTypeResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateThingType">REST API Reference for CreateThingType Operation</seealso>
        CreateThingTypeResponse EndCreateThingType(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTopicRule


        /// <summary>
        /// Creates a rule. Creating rules is an administrator-level action. Any user who has
        /// permission to create rules will be able to access data processed by the rule.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateTopicRule</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRule service method.</param>
        /// 
        /// <returns>The response from the CreateTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
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
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRule operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTopicRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateTopicRule">REST API Reference for CreateTopicRule Operation</seealso>
        IAsyncResult BeginCreateTopicRule(CreateTopicRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTopicRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTopicRule.</param>
        /// 
        /// <returns>Returns a  CreateTopicRuleResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateTopicRule">REST API Reference for CreateTopicRule Operation</seealso>
        CreateTopicRuleResponse EndCreateTopicRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTopicRuleDestination


        /// <summary>
        /// Creates a topic rule destination. The destination must be confirmed prior to use.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateTopicRuleDestination</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRuleDestination service method.</param>
        /// 
        /// <returns>The response from the CreateTopicRuleDestination service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateTopicRuleDestination">REST API Reference for CreateTopicRuleDestination Operation</seealso>
        CreateTopicRuleDestinationResponse CreateTopicRuleDestination(CreateTopicRuleDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTopicRuleDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTopicRuleDestination operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTopicRuleDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateTopicRuleDestination">REST API Reference for CreateTopicRuleDestination Operation</seealso>
        IAsyncResult BeginCreateTopicRuleDestination(CreateTopicRuleDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTopicRuleDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTopicRuleDestination.</param>
        /// 
        /// <returns>Returns a  CreateTopicRuleDestinationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/CreateTopicRuleDestination">REST API Reference for CreateTopicRuleDestination Operation</seealso>
        CreateTopicRuleDestinationResponse EndCreateTopicRuleDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccountAuditConfiguration


        /// <summary>
        /// Restores the default settings for Device Defender audits for this account. Any configuration
        /// data you entered is deleted and all audit checks are reset to disabled. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteAccountAuditConfiguration</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAuditConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountAuditConfiguration service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAccountAuditConfiguration">REST API Reference for DeleteAccountAuditConfiguration Operation</seealso>
        DeleteAccountAuditConfigurationResponse DeleteAccountAuditConfiguration(DeleteAccountAuditConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAuditConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAuditConfiguration operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountAuditConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAccountAuditConfiguration">REST API Reference for DeleteAccountAuditConfiguration Operation</seealso>
        IAsyncResult BeginDeleteAccountAuditConfiguration(DeleteAccountAuditConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountAuditConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountAuditConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteAccountAuditConfigurationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAccountAuditConfiguration">REST API Reference for DeleteAccountAuditConfiguration Operation</seealso>
        DeleteAccountAuditConfigurationResponse EndDeleteAccountAuditConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAuditSuppression


        /// <summary>
        /// Deletes a Device Defender audit suppression. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteAuditSuppression</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuditSuppression service method.</param>
        /// 
        /// <returns>The response from the DeleteAuditSuppression service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAuditSuppression">REST API Reference for DeleteAuditSuppression Operation</seealso>
        DeleteAuditSuppressionResponse DeleteAuditSuppression(DeleteAuditSuppressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuditSuppression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuditSuppression operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAuditSuppression
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAuditSuppression">REST API Reference for DeleteAuditSuppression Operation</seealso>
        IAsyncResult BeginDeleteAuditSuppression(DeleteAuditSuppressionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuditSuppression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuditSuppression.</param>
        /// 
        /// <returns>Returns a  DeleteAuditSuppressionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAuditSuppression">REST API Reference for DeleteAuditSuppression Operation</seealso>
        DeleteAuditSuppressionResponse EndDeleteAuditSuppression(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAuthorizer


        /// <summary>
        /// Deletes an authorizer.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteAuthorizer</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        IAsyncResult BeginDeleteAuthorizer(DeleteAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAuthorizer.</param>
        /// 
        /// <returns>Returns a  DeleteAuthorizerResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteAuthorizer">REST API Reference for DeleteAuthorizer Operation</seealso>
        DeleteAuthorizerResponse EndDeleteAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteBillingGroup


        /// <summary>
        /// Deletes the billing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteBillingGroup</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteBillingGroup service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        DeleteBillingGroupResponse DeleteBillingGroup(DeleteBillingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBillingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBillingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        IAsyncResult BeginDeleteBillingGroup(DeleteBillingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBillingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteBillingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteBillingGroup">REST API Reference for DeleteBillingGroup Operation</seealso>
        DeleteBillingGroupResponse EndDeleteBillingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCACertificate


        /// <summary>
        /// Deletes a registered CA certificate.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteCACertificate</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteCACertificate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCACertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCACertificate">REST API Reference for DeleteCACertificate Operation</seealso>
        IAsyncResult BeginDeleteCACertificate(DeleteCACertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCACertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCACertificate.</param>
        /// 
        /// <returns>Returns a  DeleteCACertificateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCACertificate">REST API Reference for DeleteCACertificate Operation</seealso>
        DeleteCACertificateResponse EndDeleteCACertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCertificate


        /// <summary>
        /// Deletes the specified certificate.
        /// 
        ///  
        /// <para>
        /// A certificate cannot be deleted if it has a policy or IoT thing attached to it or
        /// if its status is set to ACTIVE. To delete a certificate, first use the <a>DetachPolicy</a>
        /// action to detach all policies. Next, use the <a>UpdateCertificate</a> action to set
        /// the certificate to the INACTIVE status.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteCertificate</a>
        /// action.
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
        /// A certificate cannot be deleted if it has a policy or IoT thing attached to it or
        /// if its status is set to ACTIVE. To delete a certificate, first use the <a>DetachPolicy</a>
        /// action to detach all policies. Next, use the <a>UpdateCertificate</a> action to set
        /// the certificate to the INACTIVE status.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteCertificate</a>
        /// action.
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
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        IAsyncResult BeginDeleteCertificate(DeleteCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteCertificateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        DeleteCertificateResponse EndDeleteCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCustomMetric


        /// <summary>
        /// Deletes a Device Defender detect custom metric. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteCustomMetric</a>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        /// Before you can delete a custom metric, you must first remove the custom metric from
        /// all security profiles it's a part of. The security profile associated with the custom
        /// metric can be found using the <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_ListSecurityProfiles.html">ListSecurityProfiles</a>
        /// API with <code>metricName</code> set to your custom metric name.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomMetric service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomMetric service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCustomMetric">REST API Reference for DeleteCustomMetric Operation</seealso>
        DeleteCustomMetricResponse DeleteCustomMetric(DeleteCustomMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomMetric operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomMetric
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCustomMetric">REST API Reference for DeleteCustomMetric Operation</seealso>
        IAsyncResult BeginDeleteCustomMetric(DeleteCustomMetricRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomMetric operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomMetric.</param>
        /// 
        /// <returns>Returns a  DeleteCustomMetricResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteCustomMetric">REST API Reference for DeleteCustomMetric Operation</seealso>
        DeleteCustomMetricResponse EndDeleteCustomMetric(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDimension


        /// <summary>
        /// Removes the specified dimension from your Amazon Web Services accounts.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteDimension</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDimension service method.</param>
        /// 
        /// <returns>The response from the DeleteDimension service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDimension">REST API Reference for DeleteDimension Operation</seealso>
        DeleteDimensionResponse DeleteDimension(DeleteDimensionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDimension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDimension operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDimension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDimension">REST API Reference for DeleteDimension Operation</seealso>
        IAsyncResult BeginDeleteDimension(DeleteDimensionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDimension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDimension.</param>
        /// 
        /// <returns>Returns a  DeleteDimensionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDimension">REST API Reference for DeleteDimension Operation</seealso>
        DeleteDimensionResponse EndDeleteDimension(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDomainConfiguration


        /// <summary>
        /// Deletes the specified domain configuration.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteDomainConfiguration</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteDomainConfiguration service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDomainConfiguration">REST API Reference for DeleteDomainConfiguration Operation</seealso>
        DeleteDomainConfigurationResponse DeleteDomainConfiguration(DeleteDomainConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainConfiguration operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDomainConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDomainConfiguration">REST API Reference for DeleteDomainConfiguration Operation</seealso>
        IAsyncResult BeginDeleteDomainConfiguration(DeleteDomainConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDomainConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDomainConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteDomainConfigurationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDomainConfiguration">REST API Reference for DeleteDomainConfiguration Operation</seealso>
        DeleteDomainConfigurationResponse EndDeleteDomainConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDynamicThingGroup


        /// <summary>
        /// Deletes a dynamic thing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteDynamicThingGroup</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDynamicThingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteDynamicThingGroup service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDynamicThingGroup">REST API Reference for DeleteDynamicThingGroup Operation</seealso>
        DeleteDynamicThingGroupResponse DeleteDynamicThingGroup(DeleteDynamicThingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDynamicThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDynamicThingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDynamicThingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDynamicThingGroup">REST API Reference for DeleteDynamicThingGroup Operation</seealso>
        IAsyncResult BeginDeleteDynamicThingGroup(DeleteDynamicThingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDynamicThingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDynamicThingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteDynamicThingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteDynamicThingGroup">REST API Reference for DeleteDynamicThingGroup Operation</seealso>
        DeleteDynamicThingGroupResponse EndDeleteDynamicThingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFleetMetric


        /// <summary>
        /// Deletes the specified fleet metric. Returns successfully with no error if the deletion
        /// is successful or you specify a fleet metric that doesn't exist.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteFleetMetric</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleetMetric service method.</param>
        /// 
        /// <returns>The response from the DeleteFleetMetric service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteFleetMetric">REST API Reference for DeleteFleetMetric Operation</seealso>
        DeleteFleetMetricResponse DeleteFleetMetric(DeleteFleetMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleetMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleetMetric operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleetMetric
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteFleetMetric">REST API Reference for DeleteFleetMetric Operation</seealso>
        IAsyncResult BeginDeleteFleetMetric(DeleteFleetMetricRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleetMetric operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleetMetric.</param>
        /// 
        /// <returns>Returns a  DeleteFleetMetricResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteFleetMetric">REST API Reference for DeleteFleetMetric Operation</seealso>
        DeleteFleetMetricResponse EndDeleteFleetMetric(IAsyncResult asyncResult);

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
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteJob</a>
        /// action.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteJob operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        IAsyncResult BeginDeleteJob(DeleteJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJob.</param>
        /// 
        /// <returns>Returns a  DeleteJobResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJob">REST API Reference for DeleteJob Operation</seealso>
        DeleteJobResponse EndDeleteJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteJobExecution


        /// <summary>
        /// Deletes a job execution.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteJobExecution</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobExecution operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJobExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJobExecution">REST API Reference for DeleteJobExecution Operation</seealso>
        IAsyncResult BeginDeleteJobExecution(DeleteJobExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJobExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJobExecution.</param>
        /// 
        /// <returns>Returns a  DeleteJobExecutionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJobExecution">REST API Reference for DeleteJobExecution Operation</seealso>
        DeleteJobExecutionResponse EndDeleteJobExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteJobTemplate


        /// <summary>
        /// Deletes the specified job template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteJobTemplate service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        DeleteJobTemplateResponse DeleteJobTemplate(DeleteJobTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTemplate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        IAsyncResult BeginDeleteJobTemplate(DeleteJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJobTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteJobTemplateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteJobTemplate">REST API Reference for DeleteJobTemplate Operation</seealso>
        DeleteJobTemplateResponse EndDeleteJobTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMitigationAction


        /// <summary>
        /// Deletes a defined mitigation action from your Amazon Web Services accounts.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteMitigationAction</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMitigationAction service method.</param>
        /// 
        /// <returns>The response from the DeleteMitigationAction service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteMitigationAction">REST API Reference for DeleteMitigationAction Operation</seealso>
        DeleteMitigationActionResponse DeleteMitigationAction(DeleteMitigationActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMitigationAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMitigationAction operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMitigationAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteMitigationAction">REST API Reference for DeleteMitigationAction Operation</seealso>
        IAsyncResult BeginDeleteMitigationAction(DeleteMitigationActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMitigationAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMitigationAction.</param>
        /// 
        /// <returns>Returns a  DeleteMitigationActionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteMitigationAction">REST API Reference for DeleteMitigationAction Operation</seealso>
        DeleteMitigationActionResponse EndDeleteMitigationAction(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteOTAUpdate


        /// <summary>
        /// Delete an OTA update.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteOTAUpdate</a>
        /// action.
        /// </para>
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
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteOTAUpdate">REST API Reference for DeleteOTAUpdate Operation</seealso>
        DeleteOTAUpdateResponse DeleteOTAUpdate(DeleteOTAUpdateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOTAUpdate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOTAUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteOTAUpdate">REST API Reference for DeleteOTAUpdate Operation</seealso>
        IAsyncResult BeginDeleteOTAUpdate(DeleteOTAUpdateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOTAUpdate.</param>
        /// 
        /// <returns>Returns a  DeleteOTAUpdateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteOTAUpdate">REST API Reference for DeleteOTAUpdate Operation</seealso>
        DeleteOTAUpdateResponse EndDeleteOTAUpdate(IAsyncResult asyncResult);

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
        /// To delete a policy, use the <a>DeletePolicyVersion</a> action to delete all non-default
        /// versions of the policy; use the <a>DetachPolicy</a> action to detach the policy from
        /// any certificate; and then use the DeletePolicy action to delete the policy.
        /// </para>
        ///  
        /// <para>
        /// When a policy is deleted using DeletePolicy, its default version is deleted with it.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because of the distributed nature of Amazon Web Services, it can take up to five minutes
        /// after a policy is detached before it's ready to be deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeletePolicy</a>
        /// action.
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
        /// To delete a policy, use the <a>DeletePolicyVersion</a> action to delete all non-default
        /// versions of the policy; use the <a>DetachPolicy</a> action to detach the policy from
        /// any certificate; and then use the DeletePolicy action to delete the policy.
        /// </para>
        ///  
        /// <para>
        /// When a policy is deleted using DeletePolicy, its default version is deleted with it.
        /// </para>
        ///  <note> 
        /// <para>
        /// Because of the distributed nature of Amazon Web Services, it can take up to five minutes
        /// after a policy is detached before it's ready to be deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeletePolicy</a>
        /// action.
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
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        IAsyncResult BeginDeletePolicy(DeletePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicy.</param>
        /// 
        /// <returns>Returns a  DeletePolicyResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        DeletePolicyResponse EndDeletePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePolicyVersion


        /// <summary>
        /// Deletes the specified version of the specified policy. You cannot delete the default
        /// version of a policy using this action. To delete the default version of a policy,
        /// use <a>DeletePolicy</a>. To find out which version of a policy is marked as the default
        /// version, use ListPolicyVersions.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeletePolicyVersion</a>
        /// action.
        /// </para>
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
        /// version of a policy using this action. To delete the default version of a policy,
        /// use <a>DeletePolicy</a>. To find out which version of a policy is marked as the default
        /// version, use ListPolicyVersions.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeletePolicyVersion</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        IAsyncResult BeginDeletePolicyVersion(DeletePolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePolicyVersion.</param>
        /// 
        /// <returns>Returns a  DeletePolicyVersionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        DeletePolicyVersionResponse EndDeletePolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProvisioningTemplate


        /// <summary>
        /// Deletes a provisioning template.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteProvisioningTemplate</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisioningTemplate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteProvisioningTemplate">REST API Reference for DeleteProvisioningTemplate Operation</seealso>
        DeleteProvisioningTemplateResponse DeleteProvisioningTemplate(DeleteProvisioningTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisioningTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningTemplate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProvisioningTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteProvisioningTemplate">REST API Reference for DeleteProvisioningTemplate Operation</seealso>
        IAsyncResult BeginDeleteProvisioningTemplate(DeleteProvisioningTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisioningTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisioningTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteProvisioningTemplateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteProvisioningTemplate">REST API Reference for DeleteProvisioningTemplate Operation</seealso>
        DeleteProvisioningTemplateResponse EndDeleteProvisioningTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteProvisioningTemplateVersion


        /// <summary>
        /// Deletes a provisioning template version.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteProvisioningTemplateVersion</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteProvisioningTemplateVersion service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteProvisioningTemplateVersion">REST API Reference for DeleteProvisioningTemplateVersion Operation</seealso>
        DeleteProvisioningTemplateVersionResponse DeleteProvisioningTemplateVersion(DeleteProvisioningTemplateVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProvisioningTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProvisioningTemplateVersion operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProvisioningTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteProvisioningTemplateVersion">REST API Reference for DeleteProvisioningTemplateVersion Operation</seealso>
        IAsyncResult BeginDeleteProvisioningTemplateVersion(DeleteProvisioningTemplateVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProvisioningTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProvisioningTemplateVersion.</param>
        /// 
        /// <returns>Returns a  DeleteProvisioningTemplateVersionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteProvisioningTemplateVersion">REST API Reference for DeleteProvisioningTemplateVersion Operation</seealso>
        DeleteProvisioningTemplateVersionResponse EndDeleteProvisioningTemplateVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRegistrationCode


        /// <summary>
        /// Deletes a CA certificate registration code.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteRegistrationCode</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistrationCode operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRegistrationCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRegistrationCode">REST API Reference for DeleteRegistrationCode Operation</seealso>
        IAsyncResult BeginDeleteRegistrationCode(DeleteRegistrationCodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRegistrationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRegistrationCode.</param>
        /// 
        /// <returns>Returns a  DeleteRegistrationCodeResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRegistrationCode">REST API Reference for DeleteRegistrationCode Operation</seealso>
        DeleteRegistrationCodeResponse EndDeleteRegistrationCode(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoleAlias


        /// <summary>
        /// Deletes a role alias
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteRoleAlias</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoleAlias operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoleAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRoleAlias">REST API Reference for DeleteRoleAlias Operation</seealso>
        IAsyncResult BeginDeleteRoleAlias(DeleteRoleAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoleAlias.</param>
        /// 
        /// <returns>Returns a  DeleteRoleAliasResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteRoleAlias">REST API Reference for DeleteRoleAlias Operation</seealso>
        DeleteRoleAliasResponse EndDeleteRoleAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteScheduledAudit


        /// <summary>
        /// Deletes a scheduled audit.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteScheduledAudit</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAudit service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledAudit service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteScheduledAudit">REST API Reference for DeleteScheduledAudit Operation</seealso>
        DeleteScheduledAuditResponse DeleteScheduledAudit(DeleteScheduledAuditRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAudit operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScheduledAudit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteScheduledAudit">REST API Reference for DeleteScheduledAudit Operation</seealso>
        IAsyncResult BeginDeleteScheduledAudit(DeleteScheduledAuditRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduledAudit.</param>
        /// 
        /// <returns>Returns a  DeleteScheduledAuditResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteScheduledAudit">REST API Reference for DeleteScheduledAudit Operation</seealso>
        DeleteScheduledAuditResponse EndDeleteScheduledAudit(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSecurityProfile


        /// <summary>
        /// Deletes a Device Defender security profile.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteSecurityProfile</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityProfile service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteSecurityProfile">REST API Reference for DeleteSecurityProfile Operation</seealso>
        DeleteSecurityProfileResponse DeleteSecurityProfile(DeleteSecurityProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityProfile operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteSecurityProfile">REST API Reference for DeleteSecurityProfile Operation</seealso>
        IAsyncResult BeginDeleteSecurityProfile(DeleteSecurityProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityProfile.</param>
        /// 
        /// <returns>Returns a  DeleteSecurityProfileResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteSecurityProfile">REST API Reference for DeleteSecurityProfile Operation</seealso>
        DeleteSecurityProfileResponse EndDeleteSecurityProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStream


        /// <summary>
        /// Deletes a stream.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteStream</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteStream operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        IAsyncResult BeginDeleteStream(DeleteStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStream.</param>
        /// 
        /// <returns>Returns a  DeleteStreamResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteStream">REST API Reference for DeleteStream Operation</seealso>
        DeleteStreamResponse EndDeleteStream(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteThing


        /// <summary>
        /// Deletes the specified thing. Returns successfully with no error if the deletion is
        /// successful or you specify a thing that doesn't exist.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteThing</a>
        /// action.
        /// </para>
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
        /// Deletes the specified thing. Returns successfully with no error if the deletion is
        /// successful or you specify a thing that doesn't exist.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteThing</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the DeleteThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThing operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThing">REST API Reference for DeleteThing Operation</seealso>
        IAsyncResult BeginDeleteThing(DeleteThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteThing.</param>
        /// 
        /// <returns>Returns a  DeleteThingResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThing">REST API Reference for DeleteThing Operation</seealso>
        DeleteThingResponse EndDeleteThing(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteThingGroup


        /// <summary>
        /// Deletes a thing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteThingGroup</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteThingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingGroup">REST API Reference for DeleteThingGroup Operation</seealso>
        IAsyncResult BeginDeleteThingGroup(DeleteThingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteThingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteThingGroup.</param>
        /// 
        /// <returns>Returns a  DeleteThingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingGroup">REST API Reference for DeleteThingGroup Operation</seealso>
        DeleteThingGroupResponse EndDeleteThingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteThingType


        /// <summary>
        /// Deletes the specified thing type. You cannot delete a thing type if it has things
        /// associated with it. To delete a thing type, first mark it as deprecated by calling
        /// <a>DeprecateThingType</a>, then remove any associated things by calling <a>UpdateThing</a>
        /// to change the thing type on any associated thing, and finally use <a>DeleteThingType</a>
        /// to delete the thing type.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteThingType</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingType operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteThingType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingType">REST API Reference for DeleteThingType Operation</seealso>
        IAsyncResult BeginDeleteThingType(DeleteThingTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteThingType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteThingType.</param>
        /// 
        /// <returns>Returns a  DeleteThingTypeResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteThingType">REST API Reference for DeleteThingType Operation</seealso>
        DeleteThingTypeResponse EndDeleteThingType(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTopicRule


        /// <summary>
        /// Deletes the rule.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteTopicRule</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="ruleName">The name of the rule.</param>
        /// 
        /// <returns>The response from the DeleteTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
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
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteTopicRule</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRule service method.</param>
        /// 
        /// <returns>The response from the DeleteTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
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
        /// Initiates the asynchronous execution of the DeleteTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRule operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTopicRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRule">REST API Reference for DeleteTopicRule Operation</seealso>
        IAsyncResult BeginDeleteTopicRule(DeleteTopicRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTopicRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTopicRule.</param>
        /// 
        /// <returns>Returns a  DeleteTopicRuleResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRule">REST API Reference for DeleteTopicRule Operation</seealso>
        DeleteTopicRuleResponse EndDeleteTopicRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTopicRuleDestination


        /// <summary>
        /// Deletes a topic rule destination.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteTopicRuleDestination</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRuleDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteTopicRuleDestination service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRuleDestination">REST API Reference for DeleteTopicRuleDestination Operation</seealso>
        DeleteTopicRuleDestinationResponse DeleteTopicRuleDestination(DeleteTopicRuleDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTopicRuleDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTopicRuleDestination operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTopicRuleDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRuleDestination">REST API Reference for DeleteTopicRuleDestination Operation</seealso>
        IAsyncResult BeginDeleteTopicRuleDestination(DeleteTopicRuleDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTopicRuleDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTopicRuleDestination.</param>
        /// 
        /// <returns>Returns a  DeleteTopicRuleDestinationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteTopicRuleDestination">REST API Reference for DeleteTopicRuleDestination Operation</seealso>
        DeleteTopicRuleDestinationResponse EndDeleteTopicRuleDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteV2LoggingLevel


        /// <summary>
        /// Deletes a logging level.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteV2LoggingLevel</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteV2LoggingLevel operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteV2LoggingLevel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteV2LoggingLevel">REST API Reference for DeleteV2LoggingLevel Operation</seealso>
        IAsyncResult BeginDeleteV2LoggingLevel(DeleteV2LoggingLevelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteV2LoggingLevel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteV2LoggingLevel.</param>
        /// 
        /// <returns>Returns a  DeleteV2LoggingLevelResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeleteV2LoggingLevel">REST API Reference for DeleteV2LoggingLevel Operation</seealso>
        DeleteV2LoggingLevelResponse EndDeleteV2LoggingLevel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeprecateThingType


        /// <summary>
        /// Deprecates a thing type. You can not associate new things with deprecated thing type.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeprecateThingType</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DeprecateThingType operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprecateThingType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeprecateThingType">REST API Reference for DeprecateThingType Operation</seealso>
        IAsyncResult BeginDeprecateThingType(DeprecateThingTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeprecateThingType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprecateThingType.</param>
        /// 
        /// <returns>Returns a  DeprecateThingTypeResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DeprecateThingType">REST API Reference for DeprecateThingType Operation</seealso>
        DeprecateThingTypeResponse EndDeprecateThingType(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountAuditConfiguration


        /// <summary>
        /// Gets information about the Device Defender audit settings for this account. Settings
        /// include how audit notifications are sent and which audit checks are enabled or disabled.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeAccountAuditConfiguration</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAuditConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAuditConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAccountAuditConfiguration">REST API Reference for DescribeAccountAuditConfiguration Operation</seealso>
        DescribeAccountAuditConfigurationResponse DescribeAccountAuditConfiguration(DescribeAccountAuditConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAuditConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAuditConfiguration operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAuditConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAccountAuditConfiguration">REST API Reference for DescribeAccountAuditConfiguration Operation</seealso>
        IAsyncResult BeginDescribeAccountAuditConfiguration(DescribeAccountAuditConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAuditConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAuditConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAuditConfigurationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAccountAuditConfiguration">REST API Reference for DescribeAccountAuditConfiguration Operation</seealso>
        DescribeAccountAuditConfigurationResponse EndDescribeAccountAuditConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAuditFinding


        /// <summary>
        /// Gets information about a single audit finding. Properties include the reason for noncompliance,
        /// the severity of the issue, and the start time when the audit that returned the finding.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeAuditFinding</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditFinding service method.</param>
        /// 
        /// <returns>The response from the DescribeAuditFinding service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditFinding">REST API Reference for DescribeAuditFinding Operation</seealso>
        DescribeAuditFindingResponse DescribeAuditFinding(DescribeAuditFindingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuditFinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditFinding operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAuditFinding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditFinding">REST API Reference for DescribeAuditFinding Operation</seealso>
        IAsyncResult BeginDescribeAuditFinding(DescribeAuditFindingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAuditFinding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAuditFinding.</param>
        /// 
        /// <returns>Returns a  DescribeAuditFindingResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditFinding">REST API Reference for DescribeAuditFinding Operation</seealso>
        DescribeAuditFindingResponse EndDescribeAuditFinding(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAuditMitigationActionsTask


        /// <summary>
        /// Gets information about an audit mitigation task that is used to apply mitigation actions
        /// to a set of audit findings. Properties include the actions being applied, the audit
        /// checks to which they're being applied, the task status, and aggregated task statistics.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditMitigationActionsTask service method.</param>
        /// 
        /// <returns>The response from the DescribeAuditMitigationActionsTask service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditMitigationActionsTask">REST API Reference for DescribeAuditMitigationActionsTask Operation</seealso>
        DescribeAuditMitigationActionsTaskResponse DescribeAuditMitigationActionsTask(DescribeAuditMitigationActionsTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuditMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditMitigationActionsTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAuditMitigationActionsTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditMitigationActionsTask">REST API Reference for DescribeAuditMitigationActionsTask Operation</seealso>
        IAsyncResult BeginDescribeAuditMitigationActionsTask(DescribeAuditMitigationActionsTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAuditMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAuditMitigationActionsTask.</param>
        /// 
        /// <returns>Returns a  DescribeAuditMitigationActionsTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditMitigationActionsTask">REST API Reference for DescribeAuditMitigationActionsTask Operation</seealso>
        DescribeAuditMitigationActionsTaskResponse EndDescribeAuditMitigationActionsTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAuditSuppression


        /// <summary>
        /// Gets information about a Device Defender audit suppression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditSuppression service method.</param>
        /// 
        /// <returns>The response from the DescribeAuditSuppression service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditSuppression">REST API Reference for DescribeAuditSuppression Operation</seealso>
        DescribeAuditSuppressionResponse DescribeAuditSuppression(DescribeAuditSuppressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuditSuppression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditSuppression operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAuditSuppression
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditSuppression">REST API Reference for DescribeAuditSuppression Operation</seealso>
        IAsyncResult BeginDescribeAuditSuppression(DescribeAuditSuppressionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAuditSuppression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAuditSuppression.</param>
        /// 
        /// <returns>Returns a  DescribeAuditSuppressionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditSuppression">REST API Reference for DescribeAuditSuppression Operation</seealso>
        DescribeAuditSuppressionResponse EndDescribeAuditSuppression(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAuditTask


        /// <summary>
        /// Gets information about a Device Defender audit.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeAuditTask</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditTask service method.</param>
        /// 
        /// <returns>The response from the DescribeAuditTask service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditTask">REST API Reference for DescribeAuditTask Operation</seealso>
        DescribeAuditTaskResponse DescribeAuditTask(DescribeAuditTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuditTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAuditTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditTask">REST API Reference for DescribeAuditTask Operation</seealso>
        IAsyncResult BeginDescribeAuditTask(DescribeAuditTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAuditTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAuditTask.</param>
        /// 
        /// <returns>Returns a  DescribeAuditTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuditTask">REST API Reference for DescribeAuditTask Operation</seealso>
        DescribeAuditTaskResponse EndDescribeAuditTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAuthorizer


        /// <summary>
        /// Describes an authorizer.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeAuthorizer</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuthorizer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuthorizer">REST API Reference for DescribeAuthorizer Operation</seealso>
        IAsyncResult BeginDescribeAuthorizer(DescribeAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAuthorizer.</param>
        /// 
        /// <returns>Returns a  DescribeAuthorizerResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeAuthorizer">REST API Reference for DescribeAuthorizer Operation</seealso>
        DescribeAuthorizerResponse EndDescribeAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBillingGroup


        /// <summary>
        /// Returns information about a billing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeBillingGroup</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBillingGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeBillingGroup service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeBillingGroup">REST API Reference for DescribeBillingGroup Operation</seealso>
        DescribeBillingGroupResponse DescribeBillingGroup(DescribeBillingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBillingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBillingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeBillingGroup">REST API Reference for DescribeBillingGroup Operation</seealso>
        IAsyncResult BeginDescribeBillingGroup(DescribeBillingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBillingGroup.</param>
        /// 
        /// <returns>Returns a  DescribeBillingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeBillingGroup">REST API Reference for DescribeBillingGroup Operation</seealso>
        DescribeBillingGroupResponse EndDescribeBillingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCACertificate


        /// <summary>
        /// Describes a registered CA certificate.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeCACertificate</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeCACertificate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCACertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCACertificate">REST API Reference for DescribeCACertificate Operation</seealso>
        IAsyncResult BeginDescribeCACertificate(DescribeCACertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCACertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCACertificate.</param>
        /// 
        /// <returns>Returns a  DescribeCACertificateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCACertificate">REST API Reference for DescribeCACertificate Operation</seealso>
        DescribeCACertificateResponse EndDescribeCACertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCertificate


        /// <summary>
        /// Gets information about the specified certificate.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeCertificate</a>
        /// action.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeCertificate</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        IAsyncResult BeginDescribeCertificate(DescribeCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificate.</param>
        /// 
        /// <returns>Returns a  DescribeCertificateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCertificate">REST API Reference for DescribeCertificate Operation</seealso>
        DescribeCertificateResponse EndDescribeCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCustomMetric


        /// <summary>
        /// Gets information about a Device Defender detect custom metric. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeCustomMetric</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomMetric service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomMetric service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCustomMetric">REST API Reference for DescribeCustomMetric Operation</seealso>
        DescribeCustomMetricResponse DescribeCustomMetric(DescribeCustomMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomMetric operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomMetric
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCustomMetric">REST API Reference for DescribeCustomMetric Operation</seealso>
        IAsyncResult BeginDescribeCustomMetric(DescribeCustomMetricRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomMetric operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomMetric.</param>
        /// 
        /// <returns>Returns a  DescribeCustomMetricResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeCustomMetric">REST API Reference for DescribeCustomMetric Operation</seealso>
        DescribeCustomMetricResponse EndDescribeCustomMetric(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDefaultAuthorizer


        /// <summary>
        /// Describes the default authorizer.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeDefaultAuthorizer</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultAuthorizer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDefaultAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDefaultAuthorizer">REST API Reference for DescribeDefaultAuthorizer Operation</seealso>
        IAsyncResult BeginDescribeDefaultAuthorizer(DescribeDefaultAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDefaultAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDefaultAuthorizer.</param>
        /// 
        /// <returns>Returns a  DescribeDefaultAuthorizerResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDefaultAuthorizer">REST API Reference for DescribeDefaultAuthorizer Operation</seealso>
        DescribeDefaultAuthorizerResponse EndDescribeDefaultAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDetectMitigationActionsTask


        /// <summary>
        /// Gets information about a Device Defender ML Detect mitigation action. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeDetectMitigationActionsTask</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetectMitigationActionsTask service method.</param>
        /// 
        /// <returns>The response from the DescribeDetectMitigationActionsTask service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDetectMitigationActionsTask">REST API Reference for DescribeDetectMitigationActionsTask Operation</seealso>
        DescribeDetectMitigationActionsTaskResponse DescribeDetectMitigationActionsTask(DescribeDetectMitigationActionsTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDetectMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDetectMitigationActionsTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDetectMitigationActionsTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDetectMitigationActionsTask">REST API Reference for DescribeDetectMitigationActionsTask Operation</seealso>
        IAsyncResult BeginDescribeDetectMitigationActionsTask(DescribeDetectMitigationActionsTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDetectMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDetectMitigationActionsTask.</param>
        /// 
        /// <returns>Returns a  DescribeDetectMitigationActionsTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDetectMitigationActionsTask">REST API Reference for DescribeDetectMitigationActionsTask Operation</seealso>
        DescribeDetectMitigationActionsTaskResponse EndDescribeDetectMitigationActionsTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDimension


        /// <summary>
        /// Provides details about a dimension that is defined in your Amazon Web Services accounts.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeDimension</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDimension service method.</param>
        /// 
        /// <returns>The response from the DescribeDimension service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDimension">REST API Reference for DescribeDimension Operation</seealso>
        DescribeDimensionResponse DescribeDimension(DescribeDimensionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDimension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDimension operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDimension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDimension">REST API Reference for DescribeDimension Operation</seealso>
        IAsyncResult BeginDescribeDimension(DescribeDimensionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDimension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDimension.</param>
        /// 
        /// <returns>Returns a  DescribeDimensionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDimension">REST API Reference for DescribeDimension Operation</seealso>
        DescribeDimensionResponse EndDescribeDimension(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDomainConfiguration


        /// <summary>
        /// Gets summary information about a domain configuration.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeDomainConfiguration</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeDomainConfiguration service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDomainConfiguration">REST API Reference for DescribeDomainConfiguration Operation</seealso>
        DescribeDomainConfigurationResponse DescribeDomainConfiguration(DescribeDomainConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDomainConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainConfiguration operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDomainConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDomainConfiguration">REST API Reference for DescribeDomainConfiguration Operation</seealso>
        IAsyncResult BeginDescribeDomainConfiguration(DescribeDomainConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDomainConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDomainConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeDomainConfigurationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeDomainConfiguration">REST API Reference for DescribeDomainConfiguration Operation</seealso>
        DescribeDomainConfigurationResponse EndDescribeDomainConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEndpoint


        /// <summary>
        /// Returns a unique endpoint specific to the Amazon Web Services account making the call.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeEndpoint</a>
        /// action.
        /// </para>
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
        /// Returns a unique endpoint specific to the Amazon Web Services account making the call.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeEndpoint</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        IAsyncResult BeginDescribeEndpoint(DescribeEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse EndDescribeEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEventConfigurations


        /// <summary>
        /// Describes event configurations.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeEventConfigurations</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventConfigurations operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEventConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEventConfigurations">REST API Reference for DescribeEventConfigurations Operation</seealso>
        IAsyncResult BeginDescribeEventConfigurations(DescribeEventConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEventConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEventConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeEventConfigurationsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeEventConfigurations">REST API Reference for DescribeEventConfigurations Operation</seealso>
        DescribeEventConfigurationsResponse EndDescribeEventConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetMetric


        /// <summary>
        /// Gets information about the specified fleet metric.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeFleetMetric</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetMetric service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetMetric service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeFleetMetric">REST API Reference for DescribeFleetMetric Operation</seealso>
        DescribeFleetMetricResponse DescribeFleetMetric(DescribeFleetMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetMetric operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetMetric
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeFleetMetric">REST API Reference for DescribeFleetMetric Operation</seealso>
        IAsyncResult BeginDescribeFleetMetric(DescribeFleetMetricRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetMetric operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetMetric.</param>
        /// 
        /// <returns>Returns a  DescribeFleetMetricResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeFleetMetric">REST API Reference for DescribeFleetMetric Operation</seealso>
        DescribeFleetMetricResponse EndDescribeFleetMetric(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIndex


        /// <summary>
        /// Describes a search index.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeIndex</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndex operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        IAsyncResult BeginDescribeIndex(DescribeIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIndex.</param>
        /// 
        /// <returns>Returns a  DescribeIndexResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeIndex">REST API Reference for DescribeIndex Operation</seealso>
        DescribeIndexResponse EndDescribeIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeJob


        /// <summary>
        /// Describes a job.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeJob</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        IAsyncResult BeginDescribeJob(DescribeJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJob.</param>
        /// 
        /// <returns>Returns a  DescribeJobResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJob">REST API Reference for DescribeJob Operation</seealso>
        DescribeJobResponse EndDescribeJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeJobExecution


        /// <summary>
        /// Describes a job execution.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeJobExecution</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobExecution operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJobExecution">REST API Reference for DescribeJobExecution Operation</seealso>
        IAsyncResult BeginDescribeJobExecution(DescribeJobExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobExecution.</param>
        /// 
        /// <returns>Returns a  DescribeJobExecutionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJobExecution">REST API Reference for DescribeJobExecution Operation</seealso>
        DescribeJobExecutionResponse EndDescribeJobExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeJobTemplate


        /// <summary>
        /// Returns information about a job template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeJobTemplate service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJobTemplate">REST API Reference for DescribeJobTemplate Operation</seealso>
        DescribeJobTemplateResponse DescribeJobTemplate(DescribeJobTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobTemplate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJobTemplate">REST API Reference for DescribeJobTemplate Operation</seealso>
        IAsyncResult BeginDescribeJobTemplate(DescribeJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJobTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeJobTemplateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeJobTemplate">REST API Reference for DescribeJobTemplate Operation</seealso>
        DescribeJobTemplateResponse EndDescribeJobTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeManagedJobTemplate


        /// <summary>
        /// View details of a managed job template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedJobTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeManagedJobTemplate service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeManagedJobTemplate">REST API Reference for DescribeManagedJobTemplate Operation</seealso>
        DescribeManagedJobTemplateResponse DescribeManagedJobTemplate(DescribeManagedJobTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeManagedJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeManagedJobTemplate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeManagedJobTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeManagedJobTemplate">REST API Reference for DescribeManagedJobTemplate Operation</seealso>
        IAsyncResult BeginDescribeManagedJobTemplate(DescribeManagedJobTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeManagedJobTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeManagedJobTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeManagedJobTemplateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeManagedJobTemplate">REST API Reference for DescribeManagedJobTemplate Operation</seealso>
        DescribeManagedJobTemplateResponse EndDescribeManagedJobTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMitigationAction


        /// <summary>
        /// Gets information about a mitigation action.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeMitigationAction</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMitigationAction service method.</param>
        /// 
        /// <returns>The response from the DescribeMitigationAction service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeMitigationAction">REST API Reference for DescribeMitigationAction Operation</seealso>
        DescribeMitigationActionResponse DescribeMitigationAction(DescribeMitigationActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMitigationAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMitigationAction operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMitigationAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeMitigationAction">REST API Reference for DescribeMitigationAction Operation</seealso>
        IAsyncResult BeginDescribeMitigationAction(DescribeMitigationActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMitigationAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMitigationAction.</param>
        /// 
        /// <returns>Returns a  DescribeMitigationActionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeMitigationAction">REST API Reference for DescribeMitigationAction Operation</seealso>
        DescribeMitigationActionResponse EndDescribeMitigationAction(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProvisioningTemplate


        /// <summary>
        /// Returns information about a provisioning template.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeProvisioningTemplate</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningTemplate service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningTemplate service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeProvisioningTemplate">REST API Reference for DescribeProvisioningTemplate Operation</seealso>
        DescribeProvisioningTemplateResponse DescribeProvisioningTemplate(DescribeProvisioningTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisioningTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningTemplate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProvisioningTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeProvisioningTemplate">REST API Reference for DescribeProvisioningTemplate Operation</seealso>
        IAsyncResult BeginDescribeProvisioningTemplate(DescribeProvisioningTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisioningTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisioningTemplate.</param>
        /// 
        /// <returns>Returns a  DescribeProvisioningTemplateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeProvisioningTemplate">REST API Reference for DescribeProvisioningTemplate Operation</seealso>
        DescribeProvisioningTemplateResponse EndDescribeProvisioningTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProvisioningTemplateVersion


        /// <summary>
        /// Returns information about a provisioning template version.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeProvisioningTemplateVersion</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the DescribeProvisioningTemplateVersion service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeProvisioningTemplateVersion">REST API Reference for DescribeProvisioningTemplateVersion Operation</seealso>
        DescribeProvisioningTemplateVersionResponse DescribeProvisioningTemplateVersion(DescribeProvisioningTemplateVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProvisioningTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProvisioningTemplateVersion operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProvisioningTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeProvisioningTemplateVersion">REST API Reference for DescribeProvisioningTemplateVersion Operation</seealso>
        IAsyncResult BeginDescribeProvisioningTemplateVersion(DescribeProvisioningTemplateVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProvisioningTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProvisioningTemplateVersion.</param>
        /// 
        /// <returns>Returns a  DescribeProvisioningTemplateVersionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeProvisioningTemplateVersion">REST API Reference for DescribeProvisioningTemplateVersion Operation</seealso>
        DescribeProvisioningTemplateVersionResponse EndDescribeProvisioningTemplateVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRoleAlias


        /// <summary>
        /// Describes a role alias.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeRoleAlias</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoleAlias operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRoleAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeRoleAlias">REST API Reference for DescribeRoleAlias Operation</seealso>
        IAsyncResult BeginDescribeRoleAlias(DescribeRoleAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRoleAlias.</param>
        /// 
        /// <returns>Returns a  DescribeRoleAliasResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeRoleAlias">REST API Reference for DescribeRoleAlias Operation</seealso>
        DescribeRoleAliasResponse EndDescribeRoleAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeScheduledAudit


        /// <summary>
        /// Gets information about a scheduled audit.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeScheduledAudit</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledAudit service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledAudit service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeScheduledAudit">REST API Reference for DescribeScheduledAudit Operation</seealso>
        DescribeScheduledAuditResponse DescribeScheduledAudit(DescribeScheduledAuditRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledAudit operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScheduledAudit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeScheduledAudit">REST API Reference for DescribeScheduledAudit Operation</seealso>
        IAsyncResult BeginDescribeScheduledAudit(DescribeScheduledAuditRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledAudit.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledAuditResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeScheduledAudit">REST API Reference for DescribeScheduledAudit Operation</seealso>
        DescribeScheduledAuditResponse EndDescribeScheduledAudit(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSecurityProfile


        /// <summary>
        /// Gets information about a Device Defender security profile.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeSecurityProfile</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityProfile service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeSecurityProfile">REST API Reference for DescribeSecurityProfile Operation</seealso>
        DescribeSecurityProfileResponse DescribeSecurityProfile(DescribeSecurityProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityProfile operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeSecurityProfile">REST API Reference for DescribeSecurityProfile Operation</seealso>
        IAsyncResult BeginDescribeSecurityProfile(DescribeSecurityProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityProfile.</param>
        /// 
        /// <returns>Returns a  DescribeSecurityProfileResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeSecurityProfile">REST API Reference for DescribeSecurityProfile Operation</seealso>
        DescribeSecurityProfileResponse EndDescribeSecurityProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStream


        /// <summary>
        /// Gets information about a stream.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeStream</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeStream operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        IAsyncResult BeginDescribeStream(DescribeStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStream.</param>
        /// 
        /// <returns>Returns a  DescribeStreamResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeStream">REST API Reference for DescribeStream Operation</seealso>
        DescribeStreamResponse EndDescribeStream(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeThing


        /// <summary>
        /// Gets information about the specified thing.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeThing</a>
        /// action.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeThing</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the DescribeThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThing operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThing">REST API Reference for DescribeThing Operation</seealso>
        IAsyncResult BeginDescribeThing(DescribeThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeThing.</param>
        /// 
        /// <returns>Returns a  DescribeThingResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThing">REST API Reference for DescribeThing Operation</seealso>
        DescribeThingResponse EndDescribeThing(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeThingGroup


        /// <summary>
        /// Describe a thing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeThingGroup</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeThingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingGroup">REST API Reference for DescribeThingGroup Operation</seealso>
        IAsyncResult BeginDescribeThingGroup(DescribeThingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeThingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeThingGroup.</param>
        /// 
        /// <returns>Returns a  DescribeThingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingGroup">REST API Reference for DescribeThingGroup Operation</seealso>
        DescribeThingGroupResponse EndDescribeThingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeThingRegistrationTask


        /// <summary>
        /// Describes a bulk thing provisioning task.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeThingRegistrationTask</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingRegistrationTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeThingRegistrationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingRegistrationTask">REST API Reference for DescribeThingRegistrationTask Operation</seealso>
        IAsyncResult BeginDescribeThingRegistrationTask(DescribeThingRegistrationTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeThingRegistrationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeThingRegistrationTask.</param>
        /// 
        /// <returns>Returns a  DescribeThingRegistrationTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingRegistrationTask">REST API Reference for DescribeThingRegistrationTask Operation</seealso>
        DescribeThingRegistrationTaskResponse EndDescribeThingRegistrationTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeThingType


        /// <summary>
        /// Gets information about the specified thing type.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DescribeThingType</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeThingType operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeThingType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingType">REST API Reference for DescribeThingType Operation</seealso>
        IAsyncResult BeginDescribeThingType(DescribeThingTypeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeThingType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeThingType.</param>
        /// 
        /// <returns>Returns a  DescribeThingTypeResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DescribeThingType">REST API Reference for DescribeThingType Operation</seealso>
        DescribeThingTypeResponse EndDescribeThingType(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachPolicy


        /// <summary>
        /// Detaches a policy from the specified target.
        /// 
        ///  <note> 
        /// <para>
        /// Because of the distributed nature of Amazon Web Services, it can take up to five minutes
        /// after a policy is detached before it's ready to be deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DetachPolicy</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        IAsyncResult BeginDetachPolicy(DetachPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachPolicy.</param>
        /// 
        /// <returns>Returns a  DetachPolicyResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        DetachPolicyResponse EndDetachPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachPrincipalPolicy


        /// <summary>
        /// Removes the specified policy from the specified certificate.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This action is deprecated and works as expected for backward compatibility,
        /// but we won't add enhancements. Use <a>DetachPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DetachPrincipalPolicy</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="policyName">The name of the policy to detach.</param>
        /// <param name="principal">The principal. Valid principals are CertificateArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:cert/<i>certificateId</i>), thingGroupArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:thinggroup/<i>groupName</i>) and CognitoId (<i>region</i>:<i>id</i>).</param>
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
        ///  <b>Note:</b> This action is deprecated and works as expected for backward compatibility,
        /// but we won't add enhancements. Use <a>DetachPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DetachPrincipalPolicy</a>
        /// action.
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
        /// Initiates the asynchronous execution of the DetachPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPrincipalPolicy operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachPrincipalPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPrincipalPolicy">REST API Reference for DetachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of DetachPolicy.")]
        IAsyncResult BeginDetachPrincipalPolicy(DetachPrincipalPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachPrincipalPolicy.</param>
        /// 
        /// <returns>Returns a  DetachPrincipalPolicyResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachPrincipalPolicy">REST API Reference for DetachPrincipalPolicy Operation</seealso>
        [Obsolete("Deprecated in favor of DetachPolicy.")]
        DetachPrincipalPolicyResponse EndDetachPrincipalPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachSecurityProfile


        /// <summary>
        /// Disassociates a Device Defender security profile from a thing group or from this account.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DetachSecurityProfile</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the DetachSecurityProfile service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachSecurityProfile">REST API Reference for DetachSecurityProfile Operation</seealso>
        DetachSecurityProfileResponse DetachSecurityProfile(DetachSecurityProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachSecurityProfile operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachSecurityProfile">REST API Reference for DetachSecurityProfile Operation</seealso>
        IAsyncResult BeginDetachSecurityProfile(DetachSecurityProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachSecurityProfile.</param>
        /// 
        /// <returns>Returns a  DetachSecurityProfileResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachSecurityProfile">REST API Reference for DetachSecurityProfile Operation</seealso>
        DetachSecurityProfileResponse EndDetachSecurityProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachThingPrincipal


        /// <summary>
        /// Detaches the specified principal from the specified thing. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
        /// 
        ///  <note> 
        /// <para>
        /// This call is asynchronous. It might take several seconds for the detachment to propagate.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DetachThingPrincipal</a>
        /// action.
        /// </para>
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
        /// Detaches the specified principal from the specified thing. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
        /// 
        ///  <note> 
        /// <para>
        /// This call is asynchronous. It might take several seconds for the detachment to propagate.
        /// </para>
        ///  </note> 
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DetachThingPrincipal</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the DetachThingPrincipal operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachThingPrincipal operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachThingPrincipal
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachThingPrincipal">REST API Reference for DetachThingPrincipal Operation</seealso>
        IAsyncResult BeginDetachThingPrincipal(DetachThingPrincipalRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachThingPrincipal operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachThingPrincipal.</param>
        /// 
        /// <returns>Returns a  DetachThingPrincipalResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DetachThingPrincipal">REST API Reference for DetachThingPrincipal Operation</seealso>
        DetachThingPrincipalResponse EndDetachThingPrincipal(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableTopicRule


        /// <summary>
        /// Disables the rule.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DisableTopicRule</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTopicRule service method.</param>
        /// 
        /// <returns>The response from the DisableTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
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
        /// <param name="request">Container for the necessary parameters to execute the DisableTopicRule operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableTopicRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DisableTopicRule">REST API Reference for DisableTopicRule Operation</seealso>
        IAsyncResult BeginDisableTopicRule(DisableTopicRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableTopicRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableTopicRule.</param>
        /// 
        /// <returns>Returns a  DisableTopicRuleResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/DisableTopicRule">REST API Reference for DisableTopicRule Operation</seealso>
        DisableTopicRuleResponse EndDisableTopicRule(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableTopicRule


        /// <summary>
        /// Enables the rule.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">EnableTopicRule</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTopicRule service method.</param>
        /// 
        /// <returns>The response from the EnableTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
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
        /// <param name="request">Container for the necessary parameters to execute the EnableTopicRule operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableTopicRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/EnableTopicRule">REST API Reference for EnableTopicRule Operation</seealso>
        IAsyncResult BeginEnableTopicRule(EnableTopicRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableTopicRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableTopicRule.</param>
        /// 
        /// <returns>Returns a  EnableTopicRuleResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/EnableTopicRule">REST API Reference for EnableTopicRule Operation</seealso>
        EnableTopicRuleResponse EndEnableTopicRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBehaviorModelTrainingSummaries


        /// <summary>
        /// Returns a Device Defender's ML Detect Security Profile training model's status. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetBehaviorModelTrainingSummaries</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBehaviorModelTrainingSummaries service method.</param>
        /// 
        /// <returns>The response from the GetBehaviorModelTrainingSummaries service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetBehaviorModelTrainingSummaries">REST API Reference for GetBehaviorModelTrainingSummaries Operation</seealso>
        GetBehaviorModelTrainingSummariesResponse GetBehaviorModelTrainingSummaries(GetBehaviorModelTrainingSummariesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBehaviorModelTrainingSummaries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBehaviorModelTrainingSummaries operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBehaviorModelTrainingSummaries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetBehaviorModelTrainingSummaries">REST API Reference for GetBehaviorModelTrainingSummaries Operation</seealso>
        IAsyncResult BeginGetBehaviorModelTrainingSummaries(GetBehaviorModelTrainingSummariesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBehaviorModelTrainingSummaries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBehaviorModelTrainingSummaries.</param>
        /// 
        /// <returns>Returns a  GetBehaviorModelTrainingSummariesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetBehaviorModelTrainingSummaries">REST API Reference for GetBehaviorModelTrainingSummaries Operation</seealso>
        GetBehaviorModelTrainingSummariesResponse EndGetBehaviorModelTrainingSummaries(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBucketsAggregation


        /// <summary>
        /// Aggregates on indexed data with search queries pertaining to particular fields. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetBucketsAggregation</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBucketsAggregation service method.</param>
        /// 
        /// <returns>The response from the GetBucketsAggregation service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidAggregationException">
        /// The aggregation is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetBucketsAggregation">REST API Reference for GetBucketsAggregation Operation</seealso>
        GetBucketsAggregationResponse GetBucketsAggregation(GetBucketsAggregationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketsAggregation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketsAggregation operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketsAggregation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetBucketsAggregation">REST API Reference for GetBucketsAggregation Operation</seealso>
        IAsyncResult BeginGetBucketsAggregation(GetBucketsAggregationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBucketsAggregation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketsAggregation.</param>
        /// 
        /// <returns>Returns a  GetBucketsAggregationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetBucketsAggregation">REST API Reference for GetBucketsAggregation Operation</seealso>
        GetBucketsAggregationResponse EndGetBucketsAggregation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCardinality


        /// <summary>
        /// Returns the approximate count of unique values that match the query.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetCardinality</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCardinality service method.</param>
        /// 
        /// <returns>The response from the GetCardinality service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidAggregationException">
        /// The aggregation is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetCardinality">REST API Reference for GetCardinality Operation</seealso>
        GetCardinalityResponse GetCardinality(GetCardinalityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCardinality operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCardinality operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCardinality
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetCardinality">REST API Reference for GetCardinality Operation</seealso>
        IAsyncResult BeginGetCardinality(GetCardinalityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCardinality operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCardinality.</param>
        /// 
        /// <returns>Returns a  GetCardinalityResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetCardinality">REST API Reference for GetCardinality Operation</seealso>
        GetCardinalityResponse EndGetCardinality(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEffectivePolicies


        /// <summary>
        /// Gets a list of the policies that have an effect on the authorization behavior of the
        /// specified device when it connects to the IoT device gateway.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetEffectivePolicies</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the GetEffectivePolicies operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEffectivePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetEffectivePolicies">REST API Reference for GetEffectivePolicies Operation</seealso>
        IAsyncResult BeginGetEffectivePolicies(GetEffectivePoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEffectivePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEffectivePolicies.</param>
        /// 
        /// <returns>Returns a  GetEffectivePoliciesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetEffectivePolicies">REST API Reference for GetEffectivePolicies Operation</seealso>
        GetEffectivePoliciesResponse EndGetEffectivePolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  GetIndexingConfiguration


        /// <summary>
        /// Gets the indexing configuration.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetIndexingConfiguration</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the GetIndexingConfiguration operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIndexingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetIndexingConfiguration">REST API Reference for GetIndexingConfiguration Operation</seealso>
        IAsyncResult BeginGetIndexingConfiguration(GetIndexingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetIndexingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIndexingConfiguration.</param>
        /// 
        /// <returns>Returns a  GetIndexingConfigurationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetIndexingConfiguration">REST API Reference for GetIndexingConfiguration Operation</seealso>
        GetIndexingConfigurationResponse EndGetIndexingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJobDocument


        /// <summary>
        /// Gets a job document.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetJobDocument</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the GetJobDocument operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobDocument
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetJobDocument">REST API Reference for GetJobDocument Operation</seealso>
        IAsyncResult BeginGetJobDocument(GetJobDocumentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobDocument operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobDocument.</param>
        /// 
        /// <returns>Returns a  GetJobDocumentResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetJobDocument">REST API Reference for GetJobDocument Operation</seealso>
        GetJobDocumentResponse EndGetJobDocument(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLoggingOptions


        /// <summary>
        /// Gets the logging options.
        /// 
        ///  
        /// <para>
        /// NOTE: use of this command is not recommended. Use <code>GetV2LoggingOptions</code>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetLoggingOptions</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the GetLoggingOptions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        IAsyncResult BeginGetLoggingOptions(GetLoggingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLoggingOptions.</param>
        /// 
        /// <returns>Returns a  GetLoggingOptionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetLoggingOptions">REST API Reference for GetLoggingOptions Operation</seealso>
        GetLoggingOptionsResponse EndGetLoggingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  GetOTAUpdate


        /// <summary>
        /// Gets an OTA update.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetOTAUpdate</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the GetOTAUpdate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOTAUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetOTAUpdate">REST API Reference for GetOTAUpdate Operation</seealso>
        IAsyncResult BeginGetOTAUpdate(GetOTAUpdateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetOTAUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOTAUpdate.</param>
        /// 
        /// <returns>Returns a  GetOTAUpdateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetOTAUpdate">REST API Reference for GetOTAUpdate Operation</seealso>
        GetOTAUpdateResponse EndGetOTAUpdate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPercentiles


        /// <summary>
        /// Groups the aggregated values that match the query into percentile groupings. The default
        /// percentile groupings are: 1,5,25,50,75,95,99, although you can specify your own when
        /// you call <code>GetPercentiles</code>. This function returns a value for each percentile
        /// group specified (or the default percentile groupings). The percentile group "1" contains
        /// the aggregated field value that occurs in approximately one percent of the values
        /// that match the query. The percentile group "5" contains the aggregated field value
        /// that occurs in approximately five percent of the values that match the query, and
        /// so on. The result is an approximation, the more values that match the query, the more
        /// accurate the percentile values.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetPercentiles</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPercentiles service method.</param>
        /// 
        /// <returns>The response from the GetPercentiles service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidAggregationException">
        /// The aggregation is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPercentiles">REST API Reference for GetPercentiles Operation</seealso>
        GetPercentilesResponse GetPercentiles(GetPercentilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPercentiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPercentiles operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPercentiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPercentiles">REST API Reference for GetPercentiles Operation</seealso>
        IAsyncResult BeginGetPercentiles(GetPercentilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPercentiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPercentiles.</param>
        /// 
        /// <returns>Returns a  GetPercentilesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPercentiles">REST API Reference for GetPercentiles Operation</seealso>
        GetPercentilesResponse EndGetPercentiles(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPolicy


        /// <summary>
        /// Gets information about the specified policy with the policy document of the default
        /// version.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetPolicy</a>
        /// action.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetPolicy</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        IAsyncResult BeginGetPolicy(GetPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicy.</param>
        /// 
        /// <returns>Returns a  GetPolicyResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        GetPolicyResponse EndGetPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPolicyVersion


        /// <summary>
        /// Gets information about the specified policy version.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetPolicyVersion</a>
        /// action.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetPolicyVersion</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        IAsyncResult BeginGetPolicyVersion(GetPolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicyVersion.</param>
        /// 
        /// <returns>Returns a  GetPolicyVersionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        GetPolicyVersionResponse EndGetPolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRegistrationCode


        /// <summary>
        /// Gets a registration code used to register a CA certificate with IoT.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetRegistrationCode</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the GetRegistrationCode operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRegistrationCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetRegistrationCode">REST API Reference for GetRegistrationCode Operation</seealso>
        IAsyncResult BeginGetRegistrationCode(GetRegistrationCodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRegistrationCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRegistrationCode.</param>
        /// 
        /// <returns>Returns a  GetRegistrationCodeResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetRegistrationCode">REST API Reference for GetRegistrationCode Operation</seealso>
        GetRegistrationCodeResponse EndGetRegistrationCode(IAsyncResult asyncResult);

        #endregion
        
        #region  GetStatistics


        /// <summary>
        /// Returns the count, average, sum, minimum, maximum, sum of squares, variance, and standard
        /// deviation for the specified aggregated field. If the aggregation field is of type
        /// <code>String</code>, only the count statistic is returned.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetStatistics</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStatistics service method.</param>
        /// 
        /// <returns>The response from the GetStatistics service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidAggregationException">
        /// The aggregation is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetStatistics">REST API Reference for GetStatistics Operation</seealso>
        GetStatisticsResponse GetStatistics(GetStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStatistics operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetStatistics">REST API Reference for GetStatistics Operation</seealso>
        IAsyncResult BeginGetStatistics(GetStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetStatistics.</param>
        /// 
        /// <returns>Returns a  GetStatisticsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetStatistics">REST API Reference for GetStatistics Operation</seealso>
        GetStatisticsResponse EndGetStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTopicRule


        /// <summary>
        /// Gets information about the rule.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetTopicRule</a>
        /// action.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetTopicRule</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the GetTopicRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTopicRule operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTopicRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRule">REST API Reference for GetTopicRule Operation</seealso>
        IAsyncResult BeginGetTopicRule(GetTopicRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTopicRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTopicRule.</param>
        /// 
        /// <returns>Returns a  GetTopicRuleResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRule">REST API Reference for GetTopicRule Operation</seealso>
        GetTopicRuleResponse EndGetTopicRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetTopicRuleDestination


        /// <summary>
        /// Gets information about a topic rule destination.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetTopicRuleDestination</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTopicRuleDestination service method.</param>
        /// 
        /// <returns>The response from the GetTopicRuleDestination service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRuleDestination">REST API Reference for GetTopicRuleDestination Operation</seealso>
        GetTopicRuleDestinationResponse GetTopicRuleDestination(GetTopicRuleDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetTopicRuleDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTopicRuleDestination operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTopicRuleDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRuleDestination">REST API Reference for GetTopicRuleDestination Operation</seealso>
        IAsyncResult BeginGetTopicRuleDestination(GetTopicRuleDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetTopicRuleDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTopicRuleDestination.</param>
        /// 
        /// <returns>Returns a  GetTopicRuleDestinationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetTopicRuleDestination">REST API Reference for GetTopicRuleDestination Operation</seealso>
        GetTopicRuleDestinationResponse EndGetTopicRuleDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  GetV2LoggingOptions


        /// <summary>
        /// Gets the fine grained logging options.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetV2LoggingOptions</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetV2LoggingOptions service method.</param>
        /// 
        /// <returns>The response from the GetV2LoggingOptions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.NotConfiguredException">
        /// The resource is not configured.
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
        /// <param name="request">Container for the necessary parameters to execute the GetV2LoggingOptions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetV2LoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetV2LoggingOptions">REST API Reference for GetV2LoggingOptions Operation</seealso>
        IAsyncResult BeginGetV2LoggingOptions(GetV2LoggingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetV2LoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetV2LoggingOptions.</param>
        /// 
        /// <returns>Returns a  GetV2LoggingOptionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/GetV2LoggingOptions">REST API Reference for GetV2LoggingOptions Operation</seealso>
        GetV2LoggingOptionsResponse EndGetV2LoggingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListActiveViolations


        /// <summary>
        /// Lists the active violations for a given Device Defender security profile.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListActiveViolations</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActiveViolations service method.</param>
        /// 
        /// <returns>The response from the ListActiveViolations service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListActiveViolations">REST API Reference for ListActiveViolations Operation</seealso>
        ListActiveViolationsResponse ListActiveViolations(ListActiveViolationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListActiveViolations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActiveViolations operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActiveViolations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListActiveViolations">REST API Reference for ListActiveViolations Operation</seealso>
        IAsyncResult BeginListActiveViolations(ListActiveViolationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListActiveViolations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActiveViolations.</param>
        /// 
        /// <returns>Returns a  ListActiveViolationsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListActiveViolations">REST API Reference for ListActiveViolations Operation</seealso>
        ListActiveViolationsResponse EndListActiveViolations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAttachedPolicies


        /// <summary>
        /// Lists the policies attached to the specified thing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAttachedPolicies</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedPolicies operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachedPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAttachedPolicies">REST API Reference for ListAttachedPolicies Operation</seealso>
        IAsyncResult BeginListAttachedPolicies(ListAttachedPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachedPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachedPolicies.</param>
        /// 
        /// <returns>Returns a  ListAttachedPoliciesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAttachedPolicies">REST API Reference for ListAttachedPolicies Operation</seealso>
        ListAttachedPoliciesResponse EndListAttachedPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAuditFindings


        /// <summary>
        /// Lists the findings (results) of a Device Defender audit or of the audits performed
        /// during a specified time period. (Findings are retained for 90 days.)
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditFindings</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditFindings service method.</param>
        /// 
        /// <returns>The response from the ListAuditFindings service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditFindings">REST API Reference for ListAuditFindings Operation</seealso>
        ListAuditFindingsResponse ListAuditFindings(ListAuditFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAuditFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAuditFindings operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAuditFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditFindings">REST API Reference for ListAuditFindings Operation</seealso>
        IAsyncResult BeginListAuditFindings(ListAuditFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAuditFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAuditFindings.</param>
        /// 
        /// <returns>Returns a  ListAuditFindingsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditFindings">REST API Reference for ListAuditFindings Operation</seealso>
        ListAuditFindingsResponse EndListAuditFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAuditMitigationActionsExecutions


        /// <summary>
        /// Gets the status of audit mitigation action tasks that were executed.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditMitigationActionsExecutions</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditMitigationActionsExecutions service method.</param>
        /// 
        /// <returns>The response from the ListAuditMitigationActionsExecutions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditMitigationActionsExecutions">REST API Reference for ListAuditMitigationActionsExecutions Operation</seealso>
        ListAuditMitigationActionsExecutionsResponse ListAuditMitigationActionsExecutions(ListAuditMitigationActionsExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAuditMitigationActionsExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAuditMitigationActionsExecutions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAuditMitigationActionsExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditMitigationActionsExecutions">REST API Reference for ListAuditMitigationActionsExecutions Operation</seealso>
        IAsyncResult BeginListAuditMitigationActionsExecutions(ListAuditMitigationActionsExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAuditMitigationActionsExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAuditMitigationActionsExecutions.</param>
        /// 
        /// <returns>Returns a  ListAuditMitigationActionsExecutionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditMitigationActionsExecutions">REST API Reference for ListAuditMitigationActionsExecutions Operation</seealso>
        ListAuditMitigationActionsExecutionsResponse EndListAuditMitigationActionsExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAuditMitigationActionsTasks


        /// <summary>
        /// Gets a list of audit mitigation action tasks that match the specified filters.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditMitigationActionsTasks</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditMitigationActionsTasks service method.</param>
        /// 
        /// <returns>The response from the ListAuditMitigationActionsTasks service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditMitigationActionsTasks">REST API Reference for ListAuditMitigationActionsTasks Operation</seealso>
        ListAuditMitigationActionsTasksResponse ListAuditMitigationActionsTasks(ListAuditMitigationActionsTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAuditMitigationActionsTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAuditMitigationActionsTasks operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAuditMitigationActionsTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditMitigationActionsTasks">REST API Reference for ListAuditMitigationActionsTasks Operation</seealso>
        IAsyncResult BeginListAuditMitigationActionsTasks(ListAuditMitigationActionsTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAuditMitigationActionsTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAuditMitigationActionsTasks.</param>
        /// 
        /// <returns>Returns a  ListAuditMitigationActionsTasksResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditMitigationActionsTasks">REST API Reference for ListAuditMitigationActionsTasks Operation</seealso>
        ListAuditMitigationActionsTasksResponse EndListAuditMitigationActionsTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAuditSuppressions


        /// <summary>
        /// Lists your Device Defender audit listings. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditSuppressions</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditSuppressions service method.</param>
        /// 
        /// <returns>The response from the ListAuditSuppressions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditSuppressions">REST API Reference for ListAuditSuppressions Operation</seealso>
        ListAuditSuppressionsResponse ListAuditSuppressions(ListAuditSuppressionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAuditSuppressions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAuditSuppressions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAuditSuppressions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditSuppressions">REST API Reference for ListAuditSuppressions Operation</seealso>
        IAsyncResult BeginListAuditSuppressions(ListAuditSuppressionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAuditSuppressions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAuditSuppressions.</param>
        /// 
        /// <returns>Returns a  ListAuditSuppressionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditSuppressions">REST API Reference for ListAuditSuppressions Operation</seealso>
        ListAuditSuppressionsResponse EndListAuditSuppressions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAuditTasks


        /// <summary>
        /// Lists the Device Defender audits that have been performed during a given time period.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditTasks</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAuditTasks service method.</param>
        /// 
        /// <returns>The response from the ListAuditTasks service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditTasks">REST API Reference for ListAuditTasks Operation</seealso>
        ListAuditTasksResponse ListAuditTasks(ListAuditTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAuditTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAuditTasks operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAuditTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditTasks">REST API Reference for ListAuditTasks Operation</seealso>
        IAsyncResult BeginListAuditTasks(ListAuditTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAuditTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAuditTasks.</param>
        /// 
        /// <returns>Returns a  ListAuditTasksResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuditTasks">REST API Reference for ListAuditTasks Operation</seealso>
        ListAuditTasksResponse EndListAuditTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAuthorizers


        /// <summary>
        /// Lists the authorizers registered in your account.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuthorizers</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListAuthorizers operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAuthorizers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuthorizers">REST API Reference for ListAuthorizers Operation</seealso>
        IAsyncResult BeginListAuthorizers(ListAuthorizersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAuthorizers.</param>
        /// 
        /// <returns>Returns a  ListAuthorizersResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListAuthorizers">REST API Reference for ListAuthorizers Operation</seealso>
        ListAuthorizersResponse EndListAuthorizers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListBillingGroups


        /// <summary>
        /// Lists the billing groups you have created.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListBillingGroups</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroups service method.</param>
        /// 
        /// <returns>The response from the ListBillingGroups service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        ListBillingGroupsResponse ListBillingGroups(ListBillingGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBillingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBillingGroups operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBillingGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        IAsyncResult BeginListBillingGroups(ListBillingGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBillingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBillingGroups.</param>
        /// 
        /// <returns>Returns a  ListBillingGroupsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListBillingGroups">REST API Reference for ListBillingGroups Operation</seealso>
        ListBillingGroupsResponse EndListBillingGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCACertificates


        /// <summary>
        /// Lists the CA certificates registered for your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListCACertificates</a>
        /// action.
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
        /// <param name="request">Container for the necessary parameters to execute the ListCACertificates operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCACertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCACertificates">REST API Reference for ListCACertificates Operation</seealso>
        IAsyncResult BeginListCACertificates(ListCACertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCACertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCACertificates.</param>
        /// 
        /// <returns>Returns a  ListCACertificatesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCACertificates">REST API Reference for ListCACertificates Operation</seealso>
        ListCACertificatesResponse EndListCACertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCertificates


        /// <summary>
        /// Lists the certificates registered in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListCertificates</a>
        /// action.
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
        /// Lists the certificates registered in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The results are paginated with a default page size of 25. You can use the returned
        /// marker to retrieve additional results.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListCertificates</a>
        /// action.
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
        /// Initiates the asynchronous execution of the ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        IAsyncResult BeginListCertificates(ListCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCertificates.</param>
        /// 
        /// <returns>Returns a  ListCertificatesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificates">REST API Reference for ListCertificates Operation</seealso>
        ListCertificatesResponse EndListCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCertificatesByCA


        /// <summary>
        /// List the device certificates signed by the specified CA certificate.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListCertificatesByCA</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListCertificatesByCA operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCertificatesByCA
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificatesByCA">REST API Reference for ListCertificatesByCA Operation</seealso>
        IAsyncResult BeginListCertificatesByCA(ListCertificatesByCARequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCertificatesByCA operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCertificatesByCA.</param>
        /// 
        /// <returns>Returns a  ListCertificatesByCAResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCertificatesByCA">REST API Reference for ListCertificatesByCA Operation</seealso>
        ListCertificatesByCAResponse EndListCertificatesByCA(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCustomMetrics


        /// <summary>
        /// Lists your Device Defender detect custom metrics. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListCustomMetrics</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomMetrics service method.</param>
        /// 
        /// <returns>The response from the ListCustomMetrics service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCustomMetrics">REST API Reference for ListCustomMetrics Operation</seealso>
        ListCustomMetricsResponse ListCustomMetrics(ListCustomMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCustomMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCustomMetrics operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCustomMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCustomMetrics">REST API Reference for ListCustomMetrics Operation</seealso>
        IAsyncResult BeginListCustomMetrics(ListCustomMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCustomMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCustomMetrics.</param>
        /// 
        /// <returns>Returns a  ListCustomMetricsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListCustomMetrics">REST API Reference for ListCustomMetrics Operation</seealso>
        ListCustomMetricsResponse EndListCustomMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDetectMitigationActionsExecutions


        /// <summary>
        /// Lists mitigation actions executions for a Device Defender ML Detect Security Profile.
        /// 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListDetectMitigationActionsExecutions</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectMitigationActionsExecutions service method.</param>
        /// 
        /// <returns>The response from the ListDetectMitigationActionsExecutions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDetectMitigationActionsExecutions">REST API Reference for ListDetectMitigationActionsExecutions Operation</seealso>
        ListDetectMitigationActionsExecutionsResponse ListDetectMitigationActionsExecutions(ListDetectMitigationActionsExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectMitigationActionsExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectMitigationActionsExecutions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDetectMitigationActionsExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDetectMitigationActionsExecutions">REST API Reference for ListDetectMitigationActionsExecutions Operation</seealso>
        IAsyncResult BeginListDetectMitigationActionsExecutions(ListDetectMitigationActionsExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDetectMitigationActionsExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDetectMitigationActionsExecutions.</param>
        /// 
        /// <returns>Returns a  ListDetectMitigationActionsExecutionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDetectMitigationActionsExecutions">REST API Reference for ListDetectMitigationActionsExecutions Operation</seealso>
        ListDetectMitigationActionsExecutionsResponse EndListDetectMitigationActionsExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDetectMitigationActionsTasks


        /// <summary>
        /// List of Device Defender ML Detect mitigation actions tasks. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListDetectMitigationActionsTasks</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDetectMitigationActionsTasks service method.</param>
        /// 
        /// <returns>The response from the ListDetectMitigationActionsTasks service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDetectMitigationActionsTasks">REST API Reference for ListDetectMitigationActionsTasks Operation</seealso>
        ListDetectMitigationActionsTasksResponse ListDetectMitigationActionsTasks(ListDetectMitigationActionsTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDetectMitigationActionsTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDetectMitigationActionsTasks operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDetectMitigationActionsTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDetectMitigationActionsTasks">REST API Reference for ListDetectMitigationActionsTasks Operation</seealso>
        IAsyncResult BeginListDetectMitigationActionsTasks(ListDetectMitigationActionsTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDetectMitigationActionsTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDetectMitigationActionsTasks.</param>
        /// 
        /// <returns>Returns a  ListDetectMitigationActionsTasksResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDetectMitigationActionsTasks">REST API Reference for ListDetectMitigationActionsTasks Operation</seealso>
        ListDetectMitigationActionsTasksResponse EndListDetectMitigationActionsTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDimensions


        /// <summary>
        /// List the set of dimensions that are defined for your Amazon Web Services accounts.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListDimensions</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDimensions service method.</param>
        /// 
        /// <returns>The response from the ListDimensions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDimensions">REST API Reference for ListDimensions Operation</seealso>
        ListDimensionsResponse ListDimensions(ListDimensionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDimensions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDimensions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDimensions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDimensions">REST API Reference for ListDimensions Operation</seealso>
        IAsyncResult BeginListDimensions(ListDimensionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDimensions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDimensions.</param>
        /// 
        /// <returns>Returns a  ListDimensionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDimensions">REST API Reference for ListDimensions Operation</seealso>
        ListDimensionsResponse EndListDimensions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDomainConfigurations


        /// <summary>
        /// Gets a list of domain configurations for the user. This list is sorted alphabetically
        /// by domain configuration name.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListDomainConfigurations</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListDomainConfigurations service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDomainConfigurations">REST API Reference for ListDomainConfigurations Operation</seealso>
        ListDomainConfigurationsResponse ListDomainConfigurations(ListDomainConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainConfigurations operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDomainConfigurations">REST API Reference for ListDomainConfigurations Operation</seealso>
        IAsyncResult BeginListDomainConfigurations(ListDomainConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainConfigurations.</param>
        /// 
        /// <returns>Returns a  ListDomainConfigurationsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListDomainConfigurations">REST API Reference for ListDomainConfigurations Operation</seealso>
        ListDomainConfigurationsResponse EndListDomainConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFleetMetrics


        /// <summary>
        /// Lists all your fleet metrics. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListFleetMetrics</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFleetMetrics service method.</param>
        /// 
        /// <returns>The response from the ListFleetMetrics service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListFleetMetrics">REST API Reference for ListFleetMetrics Operation</seealso>
        ListFleetMetricsResponse ListFleetMetrics(ListFleetMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFleetMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleetMetrics operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFleetMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListFleetMetrics">REST API Reference for ListFleetMetrics Operation</seealso>
        IAsyncResult BeginListFleetMetrics(ListFleetMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFleetMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFleetMetrics.</param>
        /// 
        /// <returns>Returns a  ListFleetMetricsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListFleetMetrics">REST API Reference for ListFleetMetrics Operation</seealso>
        ListFleetMetricsResponse EndListFleetMetrics(IAsyncResult asyncResult);

        #endregion
        
        #region  ListIndices


        /// <summary>
        /// Lists the search indices.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListIndices</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListIndices operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIndices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListIndices">REST API Reference for ListIndices Operation</seealso>
        IAsyncResult BeginListIndices(ListIndicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListIndices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIndices.</param>
        /// 
        /// <returns>Returns a  ListIndicesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListIndices">REST API Reference for ListIndices Operation</seealso>
        ListIndicesResponse EndListIndices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobExecutionsForJob


        /// <summary>
        /// Lists the job executions for a job.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListJobExecutionsForJob</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForJob operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobExecutionsForJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForJob">REST API Reference for ListJobExecutionsForJob Operation</seealso>
        IAsyncResult BeginListJobExecutionsForJob(ListJobExecutionsForJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobExecutionsForJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobExecutionsForJob.</param>
        /// 
        /// <returns>Returns a  ListJobExecutionsForJobResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForJob">REST API Reference for ListJobExecutionsForJob Operation</seealso>
        ListJobExecutionsForJobResponse EndListJobExecutionsForJob(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobExecutionsForThing


        /// <summary>
        /// Lists the job executions for the specified thing.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListJobExecutionsForThing</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListJobExecutionsForThing operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobExecutionsForThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForThing">REST API Reference for ListJobExecutionsForThing Operation</seealso>
        IAsyncResult BeginListJobExecutionsForThing(ListJobExecutionsForThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobExecutionsForThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobExecutionsForThing.</param>
        /// 
        /// <returns>Returns a  ListJobExecutionsForThingResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobExecutionsForThing">REST API Reference for ListJobExecutionsForThing Operation</seealso>
        ListJobExecutionsForThingResponse EndListJobExecutionsForThing(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Lists jobs.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListJobs</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobs">REST API Reference for ListJobs Operation</seealso>
        IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobs">REST API Reference for ListJobs Operation</seealso>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobTemplates


        /// <summary>
        /// Returns a list of job templates.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListJobTemplates</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobTemplates service method.</param>
        /// 
        /// <returns>The response from the ListJobTemplates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        ListJobTemplatesResponse ListJobTemplates(ListJobTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobTemplates operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        IAsyncResult BeginListJobTemplates(ListJobTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobTemplates.</param>
        /// 
        /// <returns>Returns a  ListJobTemplatesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListJobTemplates">REST API Reference for ListJobTemplates Operation</seealso>
        ListJobTemplatesResponse EndListJobTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListManagedJobTemplates


        /// <summary>
        /// Returns a list of managed job templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListManagedJobTemplates service method.</param>
        /// 
        /// <returns>The response from the ListManagedJobTemplates service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalServerException">
        /// Internal error from the service that indicates an unexpected error or that the service
        /// is unavailable.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListManagedJobTemplates">REST API Reference for ListManagedJobTemplates Operation</seealso>
        ListManagedJobTemplatesResponse ListManagedJobTemplates(ListManagedJobTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListManagedJobTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListManagedJobTemplates operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListManagedJobTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListManagedJobTemplates">REST API Reference for ListManagedJobTemplates Operation</seealso>
        IAsyncResult BeginListManagedJobTemplates(ListManagedJobTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListManagedJobTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListManagedJobTemplates.</param>
        /// 
        /// <returns>Returns a  ListManagedJobTemplatesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListManagedJobTemplates">REST API Reference for ListManagedJobTemplates Operation</seealso>
        ListManagedJobTemplatesResponse EndListManagedJobTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMetricValues


        /// <summary>
        /// Lists the values reported for an IoT Device Defender metric (device-side metric, cloud-side
        /// metric, or custom metric) by the given thing during the specified time period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMetricValues service method.</param>
        /// 
        /// <returns>The response from the ListMetricValues service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListMetricValues">REST API Reference for ListMetricValues Operation</seealso>
        ListMetricValuesResponse ListMetricValues(ListMetricValuesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMetricValues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMetricValues operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMetricValues
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListMetricValues">REST API Reference for ListMetricValues Operation</seealso>
        IAsyncResult BeginListMetricValues(ListMetricValuesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMetricValues operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMetricValues.</param>
        /// 
        /// <returns>Returns a  ListMetricValuesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListMetricValues">REST API Reference for ListMetricValues Operation</seealso>
        ListMetricValuesResponse EndListMetricValues(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMitigationActions


        /// <summary>
        /// Gets a list of all mitigation actions that match the specified filter criteria.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListMitigationActions</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMitigationActions service method.</param>
        /// 
        /// <returns>The response from the ListMitigationActions service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListMitigationActions">REST API Reference for ListMitigationActions Operation</seealso>
        ListMitigationActionsResponse ListMitigationActions(ListMitigationActionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMitigationActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMitigationActions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMitigationActions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListMitigationActions">REST API Reference for ListMitigationActions Operation</seealso>
        IAsyncResult BeginListMitigationActions(ListMitigationActionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMitigationActions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMitigationActions.</param>
        /// 
        /// <returns>Returns a  ListMitigationActionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListMitigationActions">REST API Reference for ListMitigationActions Operation</seealso>
        ListMitigationActionsResponse EndListMitigationActions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOTAUpdates


        /// <summary>
        /// Lists OTA updates.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListOTAUpdates</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListOTAUpdates operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOTAUpdates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOTAUpdates">REST API Reference for ListOTAUpdates Operation</seealso>
        IAsyncResult BeginListOTAUpdates(ListOTAUpdatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOTAUpdates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOTAUpdates.</param>
        /// 
        /// <returns>Returns a  ListOTAUpdatesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOTAUpdates">REST API Reference for ListOTAUpdates Operation</seealso>
        ListOTAUpdatesResponse EndListOTAUpdates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOutgoingCertificates


        /// <summary>
        /// Lists certificates that are being transferred but not yet accepted.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListOutgoingCertificates</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListOutgoingCertificates operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOutgoingCertificates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOutgoingCertificates">REST API Reference for ListOutgoingCertificates Operation</seealso>
        IAsyncResult BeginListOutgoingCertificates(ListOutgoingCertificatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOutgoingCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOutgoingCertificates.</param>
        /// 
        /// <returns>Returns a  ListOutgoingCertificatesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListOutgoingCertificates">REST API Reference for ListOutgoingCertificates Operation</seealso>
        ListOutgoingCertificatesResponse EndListOutgoingCertificates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicies


        /// <summary>
        /// Lists your policies.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPolicies</a>
        /// action.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPolicies</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        IAsyncResult BeginListPolicies(ListPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicies.</param>
        /// 
        /// <returns>Returns a  ListPoliciesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        ListPoliciesResponse EndListPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicyPrincipals


        /// <summary>
        /// Lists the principals associated with the specified policy.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This action is deprecated and works as expected for backward compatibility,
        /// but we won't add enhancements. Use <a>ListTargetsForPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPolicyPrincipals</a>
        /// action.
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
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyPrincipals operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyPrincipals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyPrincipals">REST API Reference for ListPolicyPrincipals Operation</seealso>
        [Obsolete("Deprecated in favor of ListTargetsForPolicy.")]
        IAsyncResult BeginListPolicyPrincipals(ListPolicyPrincipalsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyPrincipals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyPrincipals.</param>
        /// 
        /// <returns>Returns a  ListPolicyPrincipalsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyPrincipals">REST API Reference for ListPolicyPrincipals Operation</seealso>
        [Obsolete("Deprecated in favor of ListTargetsForPolicy.")]
        ListPolicyPrincipalsResponse EndListPolicyPrincipals(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPolicyVersions


        /// <summary>
        /// Lists the versions of the specified policy and identifies the default version.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPolicyVersions</a>
        /// action.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPolicyVersions</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        IAsyncResult BeginListPolicyVersions(ListPolicyVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyVersions.</param>
        /// 
        /// <returns>Returns a  ListPolicyVersionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        ListPolicyVersionsResponse EndListPolicyVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPrincipalPolicies


        /// <summary>
        /// Lists the policies attached to the specified principal. If you use an Cognito identity,
        /// the ID must be in <a href="https://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetCredentialsForIdentity.html#API_GetCredentialsForIdentity_RequestSyntax">AmazonCognito
        /// Identity format</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This action is deprecated and works as expected for backward compatibility,
        /// but we won't add enhancements. Use <a>ListAttachedPolicies</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPrincipalPolicies</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="principal">The principal. Valid principals are CertificateArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:cert/<i>certificateId</i>), thingGroupArn (arn:aws:iot:<i>region</i>:<i>accountId</i>:thinggroup/<i>groupName</i>) and CognitoId (<i>region</i>:<i>id</i>).</param>
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
        /// the ID must be in <a href="https://docs.aws.amazon.com/cognitoidentity/latest/APIReference/API_GetCredentialsForIdentity.html#API_GetCredentialsForIdentity_RequestSyntax">AmazonCognito
        /// Identity format</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> This action is deprecated and works as expected for backward compatibility,
        /// but we won't add enhancements. Use <a>ListAttachedPolicies</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPrincipalPolicies</a>
        /// action.
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
        /// Initiates the asynchronous execution of the ListPrincipalPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalPolicies operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrincipalPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalPolicies">REST API Reference for ListPrincipalPolicies Operation</seealso>
        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        IAsyncResult BeginListPrincipalPolicies(ListPrincipalPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrincipalPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrincipalPolicies.</param>
        /// 
        /// <returns>Returns a  ListPrincipalPoliciesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalPolicies">REST API Reference for ListPrincipalPolicies Operation</seealso>
        [Obsolete("Deprecated in favor of ListAttachedPolicies.")]
        ListPrincipalPoliciesResponse EndListPrincipalPolicies(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPrincipalThings


        /// <summary>
        /// Lists the things associated with the specified principal. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPrincipalThings</a>
        /// action.
        /// </para>
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
        /// Lists the things associated with the specified principal. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPrincipalThings</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the ListPrincipalThings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPrincipalThings operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPrincipalThings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalThings">REST API Reference for ListPrincipalThings Operation</seealso>
        IAsyncResult BeginListPrincipalThings(ListPrincipalThingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPrincipalThings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPrincipalThings.</param>
        /// 
        /// <returns>Returns a  ListPrincipalThingsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListPrincipalThings">REST API Reference for ListPrincipalThings Operation</seealso>
        ListPrincipalThingsResponse EndListPrincipalThings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProvisioningTemplates


        /// <summary>
        /// Lists the provisioning templates in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListProvisioningTemplates</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningTemplates service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningTemplates service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListProvisioningTemplates">REST API Reference for ListProvisioningTemplates Operation</seealso>
        ListProvisioningTemplatesResponse ListProvisioningTemplates(ListProvisioningTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisioningTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningTemplates operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProvisioningTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListProvisioningTemplates">REST API Reference for ListProvisioningTemplates Operation</seealso>
        IAsyncResult BeginListProvisioningTemplates(ListProvisioningTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisioningTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisioningTemplates.</param>
        /// 
        /// <returns>Returns a  ListProvisioningTemplatesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListProvisioningTemplates">REST API Reference for ListProvisioningTemplates Operation</seealso>
        ListProvisioningTemplatesResponse EndListProvisioningTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListProvisioningTemplateVersions


        /// <summary>
        /// A list of provisioning template versions.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListProvisioningTemplateVersions</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the ListProvisioningTemplateVersions service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListProvisioningTemplateVersions">REST API Reference for ListProvisioningTemplateVersions Operation</seealso>
        ListProvisioningTemplateVersionsResponse ListProvisioningTemplateVersions(ListProvisioningTemplateVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListProvisioningTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProvisioningTemplateVersions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProvisioningTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListProvisioningTemplateVersions">REST API Reference for ListProvisioningTemplateVersions Operation</seealso>
        IAsyncResult BeginListProvisioningTemplateVersions(ListProvisioningTemplateVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListProvisioningTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProvisioningTemplateVersions.</param>
        /// 
        /// <returns>Returns a  ListProvisioningTemplateVersionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListProvisioningTemplateVersions">REST API Reference for ListProvisioningTemplateVersions Operation</seealso>
        ListProvisioningTemplateVersionsResponse EndListProvisioningTemplateVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRelatedResourcesForAuditFinding


        /// <summary>
        /// The related resources of an Audit finding. The following resources can be returned
        /// from calling this API:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// DEVICE_CERTIFICATE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CA_CERTIFICATE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IOT_POLICY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COGNITO_IDENTITY_POOL
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLIENT_ID
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACCOUNT_SETTINGS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ROLE_ALIAS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IAM_ROLE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ISSUER_CERTIFICATE
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// This API is similar to DescribeAuditFinding's <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_DescribeAuditFinding.html">RelatedResources</a>
        /// but provides pagination and is not limited to 10 resources. When calling <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_DescribeAuditFinding.html">DescribeAuditFinding</a>
        /// for the intermediate CA revoked for active device certificates check, RelatedResources
        /// will not be populated. You must use this API, ListRelatedResourcesForAuditFinding,
        /// to list the certificates.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRelatedResourcesForAuditFinding service method.</param>
        /// 
        /// <returns>The response from the ListRelatedResourcesForAuditFinding service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListRelatedResourcesForAuditFinding">REST API Reference for ListRelatedResourcesForAuditFinding Operation</seealso>
        ListRelatedResourcesForAuditFindingResponse ListRelatedResourcesForAuditFinding(ListRelatedResourcesForAuditFindingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRelatedResourcesForAuditFinding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRelatedResourcesForAuditFinding operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRelatedResourcesForAuditFinding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListRelatedResourcesForAuditFinding">REST API Reference for ListRelatedResourcesForAuditFinding Operation</seealso>
        IAsyncResult BeginListRelatedResourcesForAuditFinding(ListRelatedResourcesForAuditFindingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRelatedResourcesForAuditFinding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRelatedResourcesForAuditFinding.</param>
        /// 
        /// <returns>Returns a  ListRelatedResourcesForAuditFindingResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListRelatedResourcesForAuditFinding">REST API Reference for ListRelatedResourcesForAuditFinding Operation</seealso>
        ListRelatedResourcesForAuditFindingResponse EndListRelatedResourcesForAuditFinding(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRoleAliases


        /// <summary>
        /// Lists the role aliases registered in your account.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListRoleAliases</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListRoleAliases operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoleAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListRoleAliases">REST API Reference for ListRoleAliases Operation</seealso>
        IAsyncResult BeginListRoleAliases(ListRoleAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoleAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoleAliases.</param>
        /// 
        /// <returns>Returns a  ListRoleAliasesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListRoleAliases">REST API Reference for ListRoleAliases Operation</seealso>
        ListRoleAliasesResponse EndListRoleAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListScheduledAudits


        /// <summary>
        /// Lists all of your scheduled audits.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListScheduledAudits</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledAudits service method.</param>
        /// 
        /// <returns>The response from the ListScheduledAudits service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListScheduledAudits">REST API Reference for ListScheduledAudits Operation</seealso>
        ListScheduledAuditsResponse ListScheduledAudits(ListScheduledAuditsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListScheduledAudits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledAudits operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScheduledAudits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListScheduledAudits">REST API Reference for ListScheduledAudits Operation</seealso>
        IAsyncResult BeginListScheduledAudits(ListScheduledAuditsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListScheduledAudits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScheduledAudits.</param>
        /// 
        /// <returns>Returns a  ListScheduledAuditsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListScheduledAudits">REST API Reference for ListScheduledAudits Operation</seealso>
        ListScheduledAuditsResponse EndListScheduledAudits(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSecurityProfiles


        /// <summary>
        /// Lists the Device Defender security profiles you've created. You can filter security
        /// profiles by dimension or custom metric.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListSecurityProfiles</a>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>dimensionName</code> and <code>metricName</code> cannot be used in the same
        /// request.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfiles service method.</param>
        /// 
        /// <returns>The response from the ListSecurityProfiles service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        ListSecurityProfilesResponse ListSecurityProfiles(ListSecurityProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfiles operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        IAsyncResult BeginListSecurityProfiles(ListSecurityProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityProfiles.</param>
        /// 
        /// <returns>Returns a  ListSecurityProfilesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListSecurityProfiles">REST API Reference for ListSecurityProfiles Operation</seealso>
        ListSecurityProfilesResponse EndListSecurityProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSecurityProfilesForTarget


        /// <summary>
        /// Lists the Device Defender security profiles attached to a target (thing group).
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListSecurityProfilesForTarget</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfilesForTarget service method.</param>
        /// 
        /// <returns>The response from the ListSecurityProfilesForTarget service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListSecurityProfilesForTarget">REST API Reference for ListSecurityProfilesForTarget Operation</seealso>
        ListSecurityProfilesForTargetResponse ListSecurityProfilesForTarget(ListSecurityProfilesForTargetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSecurityProfilesForTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityProfilesForTarget operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSecurityProfilesForTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListSecurityProfilesForTarget">REST API Reference for ListSecurityProfilesForTarget Operation</seealso>
        IAsyncResult BeginListSecurityProfilesForTarget(ListSecurityProfilesForTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSecurityProfilesForTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSecurityProfilesForTarget.</param>
        /// 
        /// <returns>Returns a  ListSecurityProfilesForTargetResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListSecurityProfilesForTarget">REST API Reference for ListSecurityProfilesForTarget Operation</seealso>
        ListSecurityProfilesForTargetResponse EndListSecurityProfilesForTarget(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStreams


        /// <summary>
        /// Lists all of the streams in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListStreams</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListStreams operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListStreams">REST API Reference for ListStreams Operation</seealso>
        IAsyncResult BeginListStreams(ListStreamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStreams.</param>
        /// 
        /// <returns>Returns a  ListStreamsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListStreams">REST API Reference for ListStreams Operation</seealso>
        ListStreamsResponse EndListStreams(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTagsForResource</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTargetsForPolicy


        /// <summary>
        /// List targets for the specified policy.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTargetsForPolicy</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargetsForPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        IAsyncResult BeginListTargetsForPolicy(ListTargetsForPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetsForPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetsForPolicy.</param>
        /// 
        /// <returns>Returns a  ListTargetsForPolicyResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        ListTargetsForPolicyResponse EndListTargetsForPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTargetsForSecurityProfile


        /// <summary>
        /// Lists the targets (thing groups) associated with a given Device Defender security
        /// profile.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTargetsForSecurityProfile</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the ListTargetsForSecurityProfile service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForSecurityProfile">REST API Reference for ListTargetsForSecurityProfile Operation</seealso>
        ListTargetsForSecurityProfileResponse ListTargetsForSecurityProfile(ListTargetsForSecurityProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetsForSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForSecurityProfile operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTargetsForSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForSecurityProfile">REST API Reference for ListTargetsForSecurityProfile Operation</seealso>
        IAsyncResult BeginListTargetsForSecurityProfile(ListTargetsForSecurityProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTargetsForSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTargetsForSecurityProfile.</param>
        /// 
        /// <returns>Returns a  ListTargetsForSecurityProfileResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTargetsForSecurityProfile">REST API Reference for ListTargetsForSecurityProfile Operation</seealso>
        ListTargetsForSecurityProfileResponse EndListTargetsForSecurityProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThingGroups


        /// <summary>
        /// List the thing groups in your account.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThingGroups</a>
        /// action.
        /// </para>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroups">REST API Reference for ListThingGroups Operation</seealso>
        ListThingGroupsResponse ListThingGroups(ListThingGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroups operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThingGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroups">REST API Reference for ListThingGroups Operation</seealso>
        IAsyncResult BeginListThingGroups(ListThingGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThingGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThingGroups.</param>
        /// 
        /// <returns>Returns a  ListThingGroupsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroups">REST API Reference for ListThingGroups Operation</seealso>
        ListThingGroupsResponse EndListThingGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThingGroupsForThing


        /// <summary>
        /// List the thing groups to which the specified thing belongs.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThingGroupsForThing</a>
        /// action.
        /// </para>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroupsForThing">REST API Reference for ListThingGroupsForThing Operation</seealso>
        ListThingGroupsForThingResponse ListThingGroupsForThing(ListThingGroupsForThingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingGroupsForThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingGroupsForThing operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThingGroupsForThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroupsForThing">REST API Reference for ListThingGroupsForThing Operation</seealso>
        IAsyncResult BeginListThingGroupsForThing(ListThingGroupsForThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThingGroupsForThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThingGroupsForThing.</param>
        /// 
        /// <returns>Returns a  ListThingGroupsForThingResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingGroupsForThing">REST API Reference for ListThingGroupsForThing Operation</seealso>
        ListThingGroupsForThingResponse EndListThingGroupsForThing(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThingPrincipals


        /// <summary>
        /// Lists the principals associated with the specified thing. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThingPrincipals</a>
        /// action.
        /// </para>
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
        /// Lists the principals associated with the specified thing. A principal can be X.509
        /// certificates, IAM users, groups, and roles, Amazon Cognito identities or federated
        /// identities.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThingPrincipals</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the ListThingPrincipals operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingPrincipals operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThingPrincipals
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingPrincipals">REST API Reference for ListThingPrincipals Operation</seealso>
        IAsyncResult BeginListThingPrincipals(ListThingPrincipalsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThingPrincipals operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThingPrincipals.</param>
        /// 
        /// <returns>Returns a  ListThingPrincipalsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingPrincipals">REST API Reference for ListThingPrincipals Operation</seealso>
        ListThingPrincipalsResponse EndListThingPrincipals(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTaskReports operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThingRegistrationTaskReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTaskReports">REST API Reference for ListThingRegistrationTaskReports Operation</seealso>
        IAsyncResult BeginListThingRegistrationTaskReports(ListThingRegistrationTaskReportsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThingRegistrationTaskReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThingRegistrationTaskReports.</param>
        /// 
        /// <returns>Returns a  ListThingRegistrationTaskReportsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTaskReports">REST API Reference for ListThingRegistrationTaskReports Operation</seealso>
        ListThingRegistrationTaskReportsResponse EndListThingRegistrationTaskReports(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThingRegistrationTasks


        /// <summary>
        /// List bulk thing provisioning tasks.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThingRegistrationTasks</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListThingRegistrationTasks operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThingRegistrationTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTasks">REST API Reference for ListThingRegistrationTasks Operation</seealso>
        IAsyncResult BeginListThingRegistrationTasks(ListThingRegistrationTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThingRegistrationTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThingRegistrationTasks.</param>
        /// 
        /// <returns>Returns a  ListThingRegistrationTasksResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingRegistrationTasks">REST API Reference for ListThingRegistrationTasks Operation</seealso>
        ListThingRegistrationTasksResponse EndListThingRegistrationTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThings


        /// <summary>
        /// Lists your things. Use the <b>attributeName</b> and <b>attributeValue</b> parameters
        /// to filter your things. For example, calling <code>ListThings</code> with attributeName=Color
        /// and attributeValue=Red retrieves all things in the registry that contain an attribute
        /// <b>Color</b> with the value <b>Red</b>. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/thing-registry.html#list-things">List
        /// Things</a> from the <i>Amazon Web Services IoT Core Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThings</a>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        /// You will not be charged for calling this API if an <code>Access denied</code> error
        /// is returned. You will also not be charged if no attributes or pagination token was
        /// provided in request and no pagination token and no results were returned.
        /// </para>
        ///  </note>
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
        /// <b>Color</b> with the value <b>Red</b>. For more information, see <a href="https://docs.aws.amazon.com/iot/latest/developerguide/thing-registry.html#list-things">List
        /// Things</a> from the <i>Amazon Web Services IoT Core Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThings</a>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        /// You will not be charged for calling this API if an <code>Access denied</code> error
        /// is returned. You will also not be charged if no attributes or pagination token was
        /// provided in request and no pagination token and no results were returned.
        /// </para>
        ///  </note>
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
        /// Initiates the asynchronous execution of the ListThings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThings operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThings">REST API Reference for ListThings Operation</seealso>
        IAsyncResult BeginListThings(ListThingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThings.</param>
        /// 
        /// <returns>Returns a  ListThingsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThings">REST API Reference for ListThings Operation</seealso>
        ListThingsResponse EndListThings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThingsInBillingGroup


        /// <summary>
        /// Lists the things you have added to the given billing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThingsInBillingGroup</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInBillingGroup service method.</param>
        /// 
        /// <returns>The response from the ListThingsInBillingGroup service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInBillingGroup">REST API Reference for ListThingsInBillingGroup Operation</seealso>
        ListThingsInBillingGroupResponse ListThingsInBillingGroup(ListThingsInBillingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingsInBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInBillingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThingsInBillingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInBillingGroup">REST API Reference for ListThingsInBillingGroup Operation</seealso>
        IAsyncResult BeginListThingsInBillingGroup(ListThingsInBillingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThingsInBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThingsInBillingGroup.</param>
        /// 
        /// <returns>Returns a  ListThingsInBillingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInBillingGroup">REST API Reference for ListThingsInBillingGroup Operation</seealso>
        ListThingsInBillingGroupResponse EndListThingsInBillingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThingsInThingGroup


        /// <summary>
        /// Lists the things in the specified group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThingsInThingGroup</a>
        /// action.
        /// </para>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInThingGroup">REST API Reference for ListThingsInThingGroup Operation</seealso>
        ListThingsInThingGroupResponse ListThingsInThingGroup(ListThingsInThingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListThingsInThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListThingsInThingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThingsInThingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInThingGroup">REST API Reference for ListThingsInThingGroup Operation</seealso>
        IAsyncResult BeginListThingsInThingGroup(ListThingsInThingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThingsInThingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThingsInThingGroup.</param>
        /// 
        /// <returns>Returns a  ListThingsInThingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingsInThingGroup">REST API Reference for ListThingsInThingGroup Operation</seealso>
        ListThingsInThingGroupResponse EndListThingsInThingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ListThingTypes


        /// <summary>
        /// Lists the existing thing types.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListThingTypes</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListThingTypes operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListThingTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingTypes">REST API Reference for ListThingTypes Operation</seealso>
        IAsyncResult BeginListThingTypes(ListThingTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListThingTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListThingTypes.</param>
        /// 
        /// <returns>Returns a  ListThingTypesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListThingTypes">REST API Reference for ListThingTypes Operation</seealso>
        ListThingTypesResponse EndListThingTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTopicRuleDestinations


        /// <summary>
        /// Lists all the topic rule destinations in your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTopicRuleDestinations</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRuleDestinations service method.</param>
        /// 
        /// <returns>The response from the ListTopicRuleDestinations service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRuleDestinations">REST API Reference for ListTopicRuleDestinations Operation</seealso>
        ListTopicRuleDestinationsResponse ListTopicRuleDestinations(ListTopicRuleDestinationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTopicRuleDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRuleDestinations operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopicRuleDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRuleDestinations">REST API Reference for ListTopicRuleDestinations Operation</seealso>
        IAsyncResult BeginListTopicRuleDestinations(ListTopicRuleDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopicRuleDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopicRuleDestinations.</param>
        /// 
        /// <returns>Returns a  ListTopicRuleDestinationsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRuleDestinations">REST API Reference for ListTopicRuleDestinations Operation</seealso>
        ListTopicRuleDestinationsResponse EndListTopicRuleDestinations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTopicRules


        /// <summary>
        /// Lists the rules for the specific topic.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTopicRules</a>
        /// action.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListTopicRules</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the ListTopicRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTopicRules operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTopicRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRules">REST API Reference for ListTopicRules Operation</seealso>
        IAsyncResult BeginListTopicRules(ListTopicRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTopicRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTopicRules.</param>
        /// 
        /// <returns>Returns a  ListTopicRulesResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListTopicRules">REST API Reference for ListTopicRules Operation</seealso>
        ListTopicRulesResponse EndListTopicRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListV2LoggingLevels


        /// <summary>
        /// Lists logging levels.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListV2LoggingLevels</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the ListV2LoggingLevels operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListV2LoggingLevels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListV2LoggingLevels">REST API Reference for ListV2LoggingLevels Operation</seealso>
        IAsyncResult BeginListV2LoggingLevels(ListV2LoggingLevelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListV2LoggingLevels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListV2LoggingLevels.</param>
        /// 
        /// <returns>Returns a  ListV2LoggingLevelsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListV2LoggingLevels">REST API Reference for ListV2LoggingLevels Operation</seealso>
        ListV2LoggingLevelsResponse EndListV2LoggingLevels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListViolationEvents


        /// <summary>
        /// Lists the Device Defender security profile violations discovered during the given
        /// time period. You can use filters to limit the results to those alerts issued for a
        /// particular security profile, behavior, or thing (device).
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListViolationEvents</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListViolationEvents service method.</param>
        /// 
        /// <returns>The response from the ListViolationEvents service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListViolationEvents">REST API Reference for ListViolationEvents Operation</seealso>
        ListViolationEventsResponse ListViolationEvents(ListViolationEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListViolationEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListViolationEvents operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListViolationEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListViolationEvents">REST API Reference for ListViolationEvents Operation</seealso>
        IAsyncResult BeginListViolationEvents(ListViolationEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListViolationEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListViolationEvents.</param>
        /// 
        /// <returns>Returns a  ListViolationEventsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ListViolationEvents">REST API Reference for ListViolationEvents Operation</seealso>
        ListViolationEventsResponse EndListViolationEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  PutVerificationStateOnViolation


        /// <summary>
        /// Set a verification state and provide a description of that verification state on a
        /// violation (detect alarm).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutVerificationStateOnViolation service method.</param>
        /// 
        /// <returns>The response from the PutVerificationStateOnViolation service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/PutVerificationStateOnViolation">REST API Reference for PutVerificationStateOnViolation Operation</seealso>
        PutVerificationStateOnViolationResponse PutVerificationStateOnViolation(PutVerificationStateOnViolationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutVerificationStateOnViolation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutVerificationStateOnViolation operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutVerificationStateOnViolation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/PutVerificationStateOnViolation">REST API Reference for PutVerificationStateOnViolation Operation</seealso>
        IAsyncResult BeginPutVerificationStateOnViolation(PutVerificationStateOnViolationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutVerificationStateOnViolation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutVerificationStateOnViolation.</param>
        /// 
        /// <returns>Returns a  PutVerificationStateOnViolationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/PutVerificationStateOnViolation">REST API Reference for PutVerificationStateOnViolation Operation</seealso>
        PutVerificationStateOnViolationResponse EndPutVerificationStateOnViolation(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterCACertificate


        /// <summary>
        /// Registers a CA certificate with Amazon Web Services IoT Core. There is no limit to
        /// the number of CA certificates you can register in your Amazon Web Services account.
        /// You can register up to 10 CA certificates with the same <code>CA subject field</code>
        /// per Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RegisterCACertificate</a>
        /// action.
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCACertificate">REST API Reference for RegisterCACertificate Operation</seealso>
        RegisterCACertificateResponse RegisterCACertificate(RegisterCACertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCACertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCACertificate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterCACertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCACertificate">REST API Reference for RegisterCACertificate Operation</seealso>
        IAsyncResult BeginRegisterCACertificate(RegisterCACertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterCACertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterCACertificate.</param>
        /// 
        /// <returns>Returns a  RegisterCACertificateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCACertificate">REST API Reference for RegisterCACertificate Operation</seealso>
        RegisterCACertificateResponse EndRegisterCACertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterCertificate


        /// <summary>
        /// Registers a device certificate with IoT in the same <a href="https://docs.aws.amazon.com/iot/latest/apireference/API_CertificateDescription.html#iot-Type-CertificateDescription-certificateMode">certificate
        /// mode</a> as the signing CA. If you have more than one CA certificate that has the
        /// same subject field, you must specify the CA certificate that was used to sign the
        /// device certificate being registered.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RegisterCertificate</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCertificate">REST API Reference for RegisterCertificate Operation</seealso>
        IAsyncResult BeginRegisterCertificate(RegisterCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterCertificate.</param>
        /// 
        /// <returns>Returns a  RegisterCertificateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCertificate">REST API Reference for RegisterCertificate Operation</seealso>
        RegisterCertificateResponse EndRegisterCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterCertificateWithoutCA


        /// <summary>
        /// Register a certificate that does not have a certificate authority (CA). For supported
        /// certificates, consult <a href="https://docs.aws.amazon.com/iot/latest/developerguide/x509-client-certs.html#x509-cert-algorithms">
        /// Certificate signing algorithms supported by IoT</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificateWithoutCA service method.</param>
        /// 
        /// <returns>The response from the RegisterCertificateWithoutCA service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCertificateWithoutCA">REST API Reference for RegisterCertificateWithoutCA Operation</seealso>
        RegisterCertificateWithoutCAResponse RegisterCertificateWithoutCA(RegisterCertificateWithoutCARequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterCertificateWithoutCA operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterCertificateWithoutCA operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterCertificateWithoutCA
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCertificateWithoutCA">REST API Reference for RegisterCertificateWithoutCA Operation</seealso>
        IAsyncResult BeginRegisterCertificateWithoutCA(RegisterCertificateWithoutCARequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterCertificateWithoutCA operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterCertificateWithoutCA.</param>
        /// 
        /// <returns>Returns a  RegisterCertificateWithoutCAResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterCertificateWithoutCA">REST API Reference for RegisterCertificateWithoutCA Operation</seealso>
        RegisterCertificateWithoutCAResponse EndRegisterCertificateWithoutCA(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterThing


        /// <summary>
        /// Provisions a thing in the device registry. RegisterThing calls other IoT control plane
        /// APIs. These calls might exceed your account level <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_iot">
        /// IoT Throttling Limits</a> and cause throttle errors. Please contact <a href="https://console.aws.amazon.com/support/home">Amazon
        /// Web Services Customer Support</a> to raise your throttling limits if necessary.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RegisterThing</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterThing operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterThing">REST API Reference for RegisterThing Operation</seealso>
        IAsyncResult BeginRegisterThing(RegisterThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterThing.</param>
        /// 
        /// <returns>Returns a  RegisterThingResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RegisterThing">REST API Reference for RegisterThing Operation</seealso>
        RegisterThingResponse EndRegisterThing(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectCertificateTransfer


        /// <summary>
        /// Rejects a pending certificate transfer. After IoT rejects a certificate transfer,
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
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RejectCertificateTransfer</a>
        /// action.
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
        /// Rejects a pending certificate transfer. After IoT rejects a certificate transfer,
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
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RejectCertificateTransfer</a>
        /// action.
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
        /// Initiates the asynchronous execution of the RejectCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectCertificateTransfer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectCertificateTransfer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RejectCertificateTransfer">REST API Reference for RejectCertificateTransfer Operation</seealso>
        IAsyncResult BeginRejectCertificateTransfer(RejectCertificateTransferRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectCertificateTransfer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectCertificateTransfer.</param>
        /// 
        /// <returns>Returns a  RejectCertificateTransferResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RejectCertificateTransfer">REST API Reference for RejectCertificateTransfer Operation</seealso>
        RejectCertificateTransferResponse EndRejectCertificateTransfer(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveThingFromBillingGroup


        /// <summary>
        /// Removes the given thing from the billing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RemoveThingFromBillingGroup</a>
        /// action.
        /// </para>
        ///  <note> 
        /// <para>
        /// This call is asynchronous. It might take several seconds for the detachment to propagate.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromBillingGroup service method.</param>
        /// 
        /// <returns>The response from the RemoveThingFromBillingGroup service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromBillingGroup">REST API Reference for RemoveThingFromBillingGroup Operation</seealso>
        RemoveThingFromBillingGroupResponse RemoveThingFromBillingGroup(RemoveThingFromBillingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveThingFromBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromBillingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveThingFromBillingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromBillingGroup">REST API Reference for RemoveThingFromBillingGroup Operation</seealso>
        IAsyncResult BeginRemoveThingFromBillingGroup(RemoveThingFromBillingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveThingFromBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveThingFromBillingGroup.</param>
        /// 
        /// <returns>Returns a  RemoveThingFromBillingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromBillingGroup">REST API Reference for RemoveThingFromBillingGroup Operation</seealso>
        RemoveThingFromBillingGroupResponse EndRemoveThingFromBillingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  RemoveThingFromThingGroup


        /// <summary>
        /// Remove the specified thing from the specified group.
        /// 
        ///  
        /// <para>
        /// You must specify either a <code>thingGroupArn</code> or a <code>thingGroupName</code>
        /// to identify the thing group and either a <code>thingArn</code> or a <code>thingName</code>
        /// to identify the thing to remove from the thing group. 
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">RemoveThingFromThingGroup</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the RemoveThingFromThingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveThingFromThingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromThingGroup">REST API Reference for RemoveThingFromThingGroup Operation</seealso>
        IAsyncResult BeginRemoveThingFromThingGroup(RemoveThingFromThingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveThingFromThingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveThingFromThingGroup.</param>
        /// 
        /// <returns>Returns a  RemoveThingFromThingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/RemoveThingFromThingGroup">REST API Reference for RemoveThingFromThingGroup Operation</seealso>
        RemoveThingFromThingGroupResponse EndRemoveThingFromThingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  ReplaceTopicRule


        /// <summary>
        /// Replaces the rule. You must specify all parameters for the new rule. Creating rules
        /// is an administrator-level action. Any user who has permission to create rules will
        /// be able to access data processed by the rule.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ReplaceTopicRule</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceTopicRule service method.</param>
        /// 
        /// <returns>The response from the ReplaceTopicRule service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
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
        /// <param name="request">Container for the necessary parameters to execute the ReplaceTopicRule operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceTopicRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ReplaceTopicRule">REST API Reference for ReplaceTopicRule Operation</seealso>
        IAsyncResult BeginReplaceTopicRule(ReplaceTopicRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceTopicRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceTopicRule.</param>
        /// 
        /// <returns>Returns a  ReplaceTopicRuleResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ReplaceTopicRule">REST API Reference for ReplaceTopicRule Operation</seealso>
        ReplaceTopicRuleResponse EndReplaceTopicRule(IAsyncResult asyncResult);

        #endregion
        
        #region  SearchIndex


        /// <summary>
        /// The query search index.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SearchIndex</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the SearchIndex operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearchIndex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SearchIndex">REST API Reference for SearchIndex Operation</seealso>
        IAsyncResult BeginSearchIndex(SearchIndexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SearchIndex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearchIndex.</param>
        /// 
        /// <returns>Returns a  SearchIndexResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SearchIndex">REST API Reference for SearchIndex Operation</seealso>
        SearchIndexResponse EndSearchIndex(IAsyncResult asyncResult);

        #endregion
        
        #region  SetDefaultAuthorizer


        /// <summary>
        /// Sets the default authorizer. This will be used if a websocket connection is made without
        /// specifying an authorizer.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SetDefaultAuthorizer</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultAuthorizer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetDefaultAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultAuthorizer">REST API Reference for SetDefaultAuthorizer Operation</seealso>
        IAsyncResult BeginSetDefaultAuthorizer(SetDefaultAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetDefaultAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDefaultAuthorizer.</param>
        /// 
        /// <returns>Returns a  SetDefaultAuthorizerResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultAuthorizer">REST API Reference for SetDefaultAuthorizer Operation</seealso>
        SetDefaultAuthorizerResponse EndSetDefaultAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  SetDefaultPolicyVersion


        /// <summary>
        /// Sets the specified version of the specified policy as the policy's default (operative)
        /// version. This action affects all certificates to which the policy is attached. To
        /// list the principals the policy is attached to, use the <a>ListPrincipalPolicies</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SetDefaultPolicyVersion</a>
        /// action.
        /// </para>
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
        /// list the principals the policy is attached to, use the <a>ListPrincipalPolicies</a>
        /// action.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SetDefaultPolicyVersion</a>
        /// action.
        /// </para>
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
        /// Initiates the asynchronous execution of the SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetDefaultPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        IAsyncResult BeginSetDefaultPolicyVersion(SetDefaultPolicyVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetDefaultPolicyVersion.</param>
        /// 
        /// <returns>Returns a  SetDefaultPolicyVersionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        SetDefaultPolicyVersionResponse EndSetDefaultPolicyVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  SetLoggingOptions


        /// <summary>
        /// Sets the logging options.
        /// 
        ///  
        /// <para>
        /// NOTE: use of this command is not recommended. Use <code>SetV2LoggingOptions</code>
        /// instead.
        /// </para>
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SetLoggingOptions</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the SetLoggingOptions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetLoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetLoggingOptions">REST API Reference for SetLoggingOptions Operation</seealso>
        IAsyncResult BeginSetLoggingOptions(SetLoggingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetLoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetLoggingOptions.</param>
        /// 
        /// <returns>Returns a  SetLoggingOptionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetLoggingOptions">REST API Reference for SetLoggingOptions Operation</seealso>
        SetLoggingOptionsResponse EndSetLoggingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  SetV2LoggingLevel


        /// <summary>
        /// Sets the logging level.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SetV2LoggingLevel</a>
        /// action.
        /// </para>
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
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
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
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingLevel operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetV2LoggingLevel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingLevel">REST API Reference for SetV2LoggingLevel Operation</seealso>
        IAsyncResult BeginSetV2LoggingLevel(SetV2LoggingLevelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetV2LoggingLevel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetV2LoggingLevel.</param>
        /// 
        /// <returns>Returns a  SetV2LoggingLevelResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingLevel">REST API Reference for SetV2LoggingLevel Operation</seealso>
        SetV2LoggingLevelResponse EndSetV2LoggingLevel(IAsyncResult asyncResult);

        #endregion
        
        #region  SetV2LoggingOptions


        /// <summary>
        /// Sets the logging options for the V2 logging service.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SetV2LoggingOptions</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the SetV2LoggingOptions operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSetV2LoggingOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingOptions">REST API Reference for SetV2LoggingOptions Operation</seealso>
        IAsyncResult BeginSetV2LoggingOptions(SetV2LoggingOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SetV2LoggingOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetV2LoggingOptions.</param>
        /// 
        /// <returns>Returns a  SetV2LoggingOptionsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/SetV2LoggingOptions">REST API Reference for SetV2LoggingOptions Operation</seealso>
        SetV2LoggingOptionsResponse EndSetV2LoggingOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  StartAuditMitigationActionsTask


        /// <summary>
        /// Starts a task that applies a set of mitigation actions to the specified target.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartAuditMitigationActionsTask</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAuditMitigationActionsTask service method.</param>
        /// 
        /// <returns>The response from the StartAuditMitigationActionsTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TaskAlreadyExistsException">
        /// This exception occurs if you attempt to start a task with the same task-id as an
        /// existing task but with a different clientRequestToken.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartAuditMitigationActionsTask">REST API Reference for StartAuditMitigationActionsTask Operation</seealso>
        StartAuditMitigationActionsTaskResponse StartAuditMitigationActionsTask(StartAuditMitigationActionsTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartAuditMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAuditMitigationActionsTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAuditMitigationActionsTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartAuditMitigationActionsTask">REST API Reference for StartAuditMitigationActionsTask Operation</seealso>
        IAsyncResult BeginStartAuditMitigationActionsTask(StartAuditMitigationActionsTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartAuditMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAuditMitigationActionsTask.</param>
        /// 
        /// <returns>Returns a  StartAuditMitigationActionsTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartAuditMitigationActionsTask">REST API Reference for StartAuditMitigationActionsTask Operation</seealso>
        StartAuditMitigationActionsTaskResponse EndStartAuditMitigationActionsTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDetectMitigationActionsTask


        /// <summary>
        /// Starts a Device Defender ML Detect mitigation actions task. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartDetectMitigationActionsTask</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDetectMitigationActionsTask service method.</param>
        /// 
        /// <returns>The response from the StartDetectMitigationActionsTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.TaskAlreadyExistsException">
        /// This exception occurs if you attempt to start a task with the same task-id as an
        /// existing task but with a different clientRequestToken.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartDetectMitigationActionsTask">REST API Reference for StartDetectMitigationActionsTask Operation</seealso>
        StartDetectMitigationActionsTaskResponse StartDetectMitigationActionsTask(StartDetectMitigationActionsTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDetectMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDetectMitigationActionsTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDetectMitigationActionsTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartDetectMitigationActionsTask">REST API Reference for StartDetectMitigationActionsTask Operation</seealso>
        IAsyncResult BeginStartDetectMitigationActionsTask(StartDetectMitigationActionsTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDetectMitigationActionsTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDetectMitigationActionsTask.</param>
        /// 
        /// <returns>Returns a  StartDetectMitigationActionsTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartDetectMitigationActionsTask">REST API Reference for StartDetectMitigationActionsTask Operation</seealso>
        StartDetectMitigationActionsTaskResponse EndStartDetectMitigationActionsTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StartOnDemandAuditTask


        /// <summary>
        /// Starts an on-demand Device Defender audit.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartOnDemandAuditTask</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandAuditTask service method.</param>
        /// 
        /// <returns>The response from the StartOnDemandAuditTask service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.LimitExceededException">
        /// A limit has been exceeded.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartOnDemandAuditTask">REST API Reference for StartOnDemandAuditTask Operation</seealso>
        StartOnDemandAuditTaskResponse StartOnDemandAuditTask(StartOnDemandAuditTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartOnDemandAuditTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartOnDemandAuditTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartOnDemandAuditTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartOnDemandAuditTask">REST API Reference for StartOnDemandAuditTask Operation</seealso>
        IAsyncResult BeginStartOnDemandAuditTask(StartOnDemandAuditTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartOnDemandAuditTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartOnDemandAuditTask.</param>
        /// 
        /// <returns>Returns a  StartOnDemandAuditTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartOnDemandAuditTask">REST API Reference for StartOnDemandAuditTask Operation</seealso>
        StartOnDemandAuditTaskResponse EndStartOnDemandAuditTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StartThingRegistrationTask


        /// <summary>
        /// Creates a bulk thing provisioning task.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StartThingRegistrationTask</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the StartThingRegistrationTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartThingRegistrationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartThingRegistrationTask">REST API Reference for StartThingRegistrationTask Operation</seealso>
        IAsyncResult BeginStartThingRegistrationTask(StartThingRegistrationTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartThingRegistrationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartThingRegistrationTask.</param>
        /// 
        /// <returns>Returns a  StartThingRegistrationTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StartThingRegistrationTask">REST API Reference for StartThingRegistrationTask Operation</seealso>
        StartThingRegistrationTaskResponse EndStartThingRegistrationTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StopThingRegistrationTask


        /// <summary>
        /// Cancels a bulk thing provisioning task.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">StopThingRegistrationTask</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the StopThingRegistrationTask operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopThingRegistrationTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StopThingRegistrationTask">REST API Reference for StopThingRegistrationTask Operation</seealso>
        IAsyncResult BeginStopThingRegistrationTask(StopThingRegistrationTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopThingRegistrationTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopThingRegistrationTask.</param>
        /// 
        /// <returns>Returns a  StopThingRegistrationTaskResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/StopThingRegistrationTask">REST API Reference for StopThingRegistrationTask Operation</seealso>
        StopThingRegistrationTaskResponse EndStopThingRegistrationTask(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds to or modifies the tags of the given resource. Tags are metadata which can be
        /// used to manage a resource.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TagResource</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestAuthorization


        /// <summary>
        /// Tests if a specified principal is authorized to perform an IoT action on a specified
        /// resource. Use this to test and debug the authorization behavior of devices that connect
        /// to the IoT device gateway.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TestAuthorization</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the TestAuthorization operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestAuthorization">REST API Reference for TestAuthorization Operation</seealso>
        IAsyncResult BeginTestAuthorization(TestAuthorizationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestAuthorization.</param>
        /// 
        /// <returns>Returns a  TestAuthorizationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestAuthorization">REST API Reference for TestAuthorization Operation</seealso>
        TestAuthorizationResponse EndTestAuthorization(IAsyncResult asyncResult);

        #endregion
        
        #region  TestInvokeAuthorizer


        /// <summary>
        /// Tests a custom authorization behavior by invoking a specified custom authorizer. Use
        /// this to test and debug the custom authorization behavior of devices that connect to
        /// the IoT device gateway.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TestInvokeAuthorizer</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestInvokeAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        IAsyncResult BeginTestInvokeAuthorizer(TestInvokeAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestInvokeAuthorizer.</param>
        /// 
        /// <returns>Returns a  TestInvokeAuthorizerResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TestInvokeAuthorizer">REST API Reference for TestInvokeAuthorizer Operation</seealso>
        TestInvokeAuthorizerResponse EndTestInvokeAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  TransferCertificate


        /// <summary>
        /// Transfers the specified certificate to the specified Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TransferCertificate</a>
        /// action.
        /// </para>
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
        /// <a>UpdateCertificate</a> action to deactivate it.
        /// </para>
        ///  
        /// <para>
        /// The certificate must not have any policies attached to it. You can use the <a>DetachPolicy</a>
        /// action to detach them.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="targetAwsAccount">The Amazon Web Services account.</param>
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
        /// Transfers the specified certificate to the specified Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">TransferCertificate</a>
        /// action.
        /// </para>
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
        /// <a>UpdateCertificate</a> action to deactivate it.
        /// </para>
        ///  
        /// <para>
        /// The certificate must not have any policies attached to it. You can use the <a>DetachPolicy</a>
        /// action to detach them.
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
        /// Initiates the asynchronous execution of the TransferCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferCertificate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTransferCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TransferCertificate">REST API Reference for TransferCertificate Operation</seealso>
        IAsyncResult BeginTransferCertificate(TransferCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TransferCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTransferCertificate.</param>
        /// 
        /// <returns>Returns a  TransferCertificateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/TransferCertificate">REST API Reference for TransferCertificate Operation</seealso>
        TransferCertificateResponse EndTransferCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the given tags (metadata) from the resource.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UntagResource</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccountAuditConfiguration


        /// <summary>
        /// Configures or reconfigures the Device Defender audit settings for this account. Settings
        /// include how audit notifications are sent and which audit checks are enabled or disabled.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateAccountAuditConfiguration</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountAuditConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountAuditConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAccountAuditConfiguration">REST API Reference for UpdateAccountAuditConfiguration Operation</seealso>
        UpdateAccountAuditConfigurationResponse UpdateAccountAuditConfiguration(UpdateAccountAuditConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountAuditConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountAuditConfiguration operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountAuditConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAccountAuditConfiguration">REST API Reference for UpdateAccountAuditConfiguration Operation</seealso>
        IAsyncResult BeginUpdateAccountAuditConfiguration(UpdateAccountAuditConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountAuditConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountAuditConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateAccountAuditConfigurationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAccountAuditConfiguration">REST API Reference for UpdateAccountAuditConfiguration Operation</seealso>
        UpdateAccountAuditConfigurationResponse EndUpdateAccountAuditConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAuditSuppression


        /// <summary>
        /// Updates a Device Defender audit suppression.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuditSuppression service method.</param>
        /// 
        /// <returns>The response from the UpdateAuditSuppression service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAuditSuppression">REST API Reference for UpdateAuditSuppression Operation</seealso>
        UpdateAuditSuppressionResponse UpdateAuditSuppression(UpdateAuditSuppressionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuditSuppression operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuditSuppression operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAuditSuppression
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAuditSuppression">REST API Reference for UpdateAuditSuppression Operation</seealso>
        IAsyncResult BeginUpdateAuditSuppression(UpdateAuditSuppressionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuditSuppression operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuditSuppression.</param>
        /// 
        /// <returns>Returns a  UpdateAuditSuppressionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAuditSuppression">REST API Reference for UpdateAuditSuppression Operation</seealso>
        UpdateAuditSuppressionResponse EndUpdateAuditSuppression(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAuthorizer


        /// <summary>
        /// Updates an authorizer.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateAuthorizer</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAuthorizer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        IAsyncResult BeginUpdateAuthorizer(UpdateAuthorizerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAuthorizer.</param>
        /// 
        /// <returns>Returns a  UpdateAuthorizerResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateAuthorizer">REST API Reference for UpdateAuthorizer Operation</seealso>
        UpdateAuthorizerResponse EndUpdateAuthorizer(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateBillingGroup


        /// <summary>
        /// Updates information about the billing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateBillingGroup</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateBillingGroup service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        UpdateBillingGroupResponse UpdateBillingGroup(UpdateBillingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBillingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateBillingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        IAsyncResult BeginUpdateBillingGroup(UpdateBillingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateBillingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateBillingGroup.</param>
        /// 
        /// <returns>Returns a  UpdateBillingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateBillingGroup">REST API Reference for UpdateBillingGroup Operation</seealso>
        UpdateBillingGroupResponse EndUpdateBillingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCACertificate


        /// <summary>
        /// Updates a registered CA certificate.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateCACertificate</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateCACertificate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCACertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCACertificate">REST API Reference for UpdateCACertificate Operation</seealso>
        IAsyncResult BeginUpdateCACertificate(UpdateCACertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCACertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCACertificate.</param>
        /// 
        /// <returns>Returns a  UpdateCACertificateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCACertificate">REST API Reference for UpdateCACertificate Operation</seealso>
        UpdateCACertificateResponse EndUpdateCACertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCertificate


        /// <summary>
        /// Updates the status of the specified certificate. This operation is idempotent.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateCertificate</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// Certificates must be in the ACTIVE state to authenticate devices that use a certificate
        /// to connect to IoT.
        /// </para>
        ///  
        /// <para>
        /// Within a few minutes of updating a certificate from the ACTIVE state to any other
        /// state, IoT disconnects all devices that used that certificate to connect. Devices
        /// cannot use a certificate that is not in the ACTIVE state to reconnect.
        /// </para>
        /// </summary>
        /// <param name="certificateId">The ID of the certificate. (The last part of the certificate ARN contains the certificate ID.)</param>
        /// <param name="newStatus">The new status.  <b>Note:</b> Setting the status to PENDING_TRANSFER or PENDING_ACTIVATION will result in an exception being thrown. PENDING_TRANSFER and PENDING_ACTIVATION are statuses used internally by IoT. They are not intended for developer use.  <b>Note:</b> The status value REGISTER_INACTIVE is deprecated and should not be used.</param>
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
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateCertificate</a>
        /// action.
        /// </para>
        ///  
        /// <para>
        /// Certificates must be in the ACTIVE state to authenticate devices that use a certificate
        /// to connect to IoT.
        /// </para>
        ///  
        /// <para>
        /// Within a few minutes of updating a certificate from the ACTIVE state to any other
        /// state, IoT disconnects all devices that used that certificate to connect. Devices
        /// cannot use a certificate that is not in the ACTIVE state to reconnect.
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
        /// Initiates the asynchronous execution of the UpdateCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCertificate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        IAsyncResult BeginUpdateCertificate(UpdateCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCertificate.</param>
        /// 
        /// <returns>Returns a  UpdateCertificateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCertificate">REST API Reference for UpdateCertificate Operation</seealso>
        UpdateCertificateResponse EndUpdateCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCustomMetric


        /// <summary>
        /// Updates a Device Defender detect custom metric. 
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateCustomMetric</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomMetric service method.</param>
        /// 
        /// <returns>The response from the UpdateCustomMetric service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCustomMetric">REST API Reference for UpdateCustomMetric Operation</seealso>
        UpdateCustomMetricResponse UpdateCustomMetric(UpdateCustomMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCustomMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomMetric operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCustomMetric
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCustomMetric">REST API Reference for UpdateCustomMetric Operation</seealso>
        IAsyncResult BeginUpdateCustomMetric(UpdateCustomMetricRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCustomMetric operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCustomMetric.</param>
        /// 
        /// <returns>Returns a  UpdateCustomMetricResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateCustomMetric">REST API Reference for UpdateCustomMetric Operation</seealso>
        UpdateCustomMetricResponse EndUpdateCustomMetric(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDimension


        /// <summary>
        /// Updates the definition for a dimension. You cannot change the type of a dimension
        /// after it is created (you can delete it and recreate it).
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateDimension</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDimension service method.</param>
        /// 
        /// <returns>The response from the UpdateDimension service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDimension">REST API Reference for UpdateDimension Operation</seealso>
        UpdateDimensionResponse UpdateDimension(UpdateDimensionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDimension operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDimension operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDimension
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDimension">REST API Reference for UpdateDimension Operation</seealso>
        IAsyncResult BeginUpdateDimension(UpdateDimensionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDimension operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDimension.</param>
        /// 
        /// <returns>Returns a  UpdateDimensionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDimension">REST API Reference for UpdateDimension Operation</seealso>
        UpdateDimensionResponse EndUpdateDimension(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDomainConfiguration


        /// <summary>
        /// Updates values stored in the domain configuration. Domain configurations for default
        /// endpoints can't be updated.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateDomainConfiguration</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateDomainConfiguration service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.CertificateValidationException">
        /// The certificate is invalid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDomainConfiguration">REST API Reference for UpdateDomainConfiguration Operation</seealso>
        UpdateDomainConfigurationResponse UpdateDomainConfiguration(UpdateDomainConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainConfiguration operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDomainConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDomainConfiguration">REST API Reference for UpdateDomainConfiguration Operation</seealso>
        IAsyncResult BeginUpdateDomainConfiguration(UpdateDomainConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDomainConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDomainConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateDomainConfigurationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDomainConfiguration">REST API Reference for UpdateDomainConfiguration Operation</seealso>
        UpdateDomainConfigurationResponse EndUpdateDomainConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDynamicThingGroup


        /// <summary>
        /// Updates a dynamic thing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateDynamicThingGroup</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDynamicThingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateDynamicThingGroup service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDynamicThingGroup">REST API Reference for UpdateDynamicThingGroup Operation</seealso>
        UpdateDynamicThingGroupResponse UpdateDynamicThingGroup(UpdateDynamicThingGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDynamicThingGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDynamicThingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDynamicThingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDynamicThingGroup">REST API Reference for UpdateDynamicThingGroup Operation</seealso>
        IAsyncResult BeginUpdateDynamicThingGroup(UpdateDynamicThingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDynamicThingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDynamicThingGroup.</param>
        /// 
        /// <returns>Returns a  UpdateDynamicThingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateDynamicThingGroup">REST API Reference for UpdateDynamicThingGroup Operation</seealso>
        UpdateDynamicThingGroupResponse EndUpdateDynamicThingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEventConfigurations


        /// <summary>
        /// Updates the event configurations.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateEventConfigurations</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurations operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateEventConfigurations">REST API Reference for UpdateEventConfigurations Operation</seealso>
        IAsyncResult BeginUpdateEventConfigurations(UpdateEventConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventConfigurations.</param>
        /// 
        /// <returns>Returns a  UpdateEventConfigurationsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateEventConfigurations">REST API Reference for UpdateEventConfigurations Operation</seealso>
        UpdateEventConfigurationsResponse EndUpdateEventConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFleetMetric


        /// <summary>
        /// Updates the data for a fleet metric.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateFleetMetric</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetMetric service method.</param>
        /// 
        /// <returns>The response from the UpdateFleetMetric service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.IndexNotReadyException">
        /// The index is not ready.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidAggregationException">
        /// The aggregation is invalid.
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
        /// <exception cref="Amazon.IoT.Model.VersionConflictException">
        /// An exception thrown when the version of an entity specified with the <code>expectedVersion</code>
        /// parameter does not match the latest version in the system.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateFleetMetric">REST API Reference for UpdateFleetMetric Operation</seealso>
        UpdateFleetMetricResponse UpdateFleetMetric(UpdateFleetMetricRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetMetric operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetMetric operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFleetMetric
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateFleetMetric">REST API Reference for UpdateFleetMetric Operation</seealso>
        IAsyncResult BeginUpdateFleetMetric(UpdateFleetMetricRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFleetMetric operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFleetMetric.</param>
        /// 
        /// <returns>Returns a  UpdateFleetMetricResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateFleetMetric">REST API Reference for UpdateFleetMetric Operation</seealso>
        UpdateFleetMetricResponse EndUpdateFleetMetric(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateIndexingConfiguration


        /// <summary>
        /// Updates the search configuration.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateIndexingConfiguration</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateIndexingConfiguration operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateIndexingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateIndexingConfiguration">REST API Reference for UpdateIndexingConfiguration Operation</seealso>
        IAsyncResult BeginUpdateIndexingConfiguration(UpdateIndexingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateIndexingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateIndexingConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateIndexingConfigurationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateIndexingConfiguration">REST API Reference for UpdateIndexingConfiguration Operation</seealso>
        UpdateIndexingConfigurationResponse EndUpdateIndexingConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateJob


        /// <summary>
        /// Updates supported fields of the specified job.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateJob</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob service method.</param>
        /// 
        /// <returns>The response from the UpdateJob service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        UpdateJobResponse UpdateJob(UpdateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJob operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        IAsyncResult BeginUpdateJob(UpdateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJob.</param>
        /// 
        /// <returns>Returns a  UpdateJobResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateJob">REST API Reference for UpdateJob Operation</seealso>
        UpdateJobResponse EndUpdateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMitigationAction


        /// <summary>
        /// Updates the definition for the specified mitigation action.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateMitigationAction</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMitigationAction service method.</param>
        /// 
        /// <returns>The response from the UpdateMitigationAction service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateMitigationAction">REST API Reference for UpdateMitigationAction Operation</seealso>
        UpdateMitigationActionResponse UpdateMitigationAction(UpdateMitigationActionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMitigationAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMitigationAction operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMitigationAction
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateMitigationAction">REST API Reference for UpdateMitigationAction Operation</seealso>
        IAsyncResult BeginUpdateMitigationAction(UpdateMitigationActionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMitigationAction operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMitigationAction.</param>
        /// 
        /// <returns>Returns a  UpdateMitigationActionResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateMitigationAction">REST API Reference for UpdateMitigationAction Operation</seealso>
        UpdateMitigationActionResponse EndUpdateMitigationAction(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateProvisioningTemplate


        /// <summary>
        /// Updates a provisioning template.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateProvisioningTemplate</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateProvisioningTemplate service method, as returned by IoT.</returns>
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
        /// <exception cref="Amazon.IoT.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateProvisioningTemplate">REST API Reference for UpdateProvisioningTemplate Operation</seealso>
        UpdateProvisioningTemplateResponse UpdateProvisioningTemplate(UpdateProvisioningTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProvisioningTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProvisioningTemplate operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProvisioningTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateProvisioningTemplate">REST API Reference for UpdateProvisioningTemplate Operation</seealso>
        IAsyncResult BeginUpdateProvisioningTemplate(UpdateProvisioningTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProvisioningTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProvisioningTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateProvisioningTemplateResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateProvisioningTemplate">REST API Reference for UpdateProvisioningTemplate Operation</seealso>
        UpdateProvisioningTemplateResponse EndUpdateProvisioningTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRoleAlias


        /// <summary>
        /// Updates a role alias.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateRoleAlias</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleAlias operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoleAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateRoleAlias">REST API Reference for UpdateRoleAlias Operation</seealso>
        IAsyncResult BeginUpdateRoleAlias(UpdateRoleAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoleAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoleAlias.</param>
        /// 
        /// <returns>Returns a  UpdateRoleAliasResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateRoleAlias">REST API Reference for UpdateRoleAlias Operation</seealso>
        UpdateRoleAliasResponse EndUpdateRoleAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateScheduledAudit


        /// <summary>
        /// Updates a scheduled audit, including which checks are performed and how often the
        /// audit takes place.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateScheduledAudit</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledAudit service method.</param>
        /// 
        /// <returns>The response from the UpdateScheduledAudit service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateScheduledAudit">REST API Reference for UpdateScheduledAudit Operation</seealso>
        UpdateScheduledAuditResponse UpdateScheduledAudit(UpdateScheduledAuditRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledAudit operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateScheduledAudit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateScheduledAudit">REST API Reference for UpdateScheduledAudit Operation</seealso>
        IAsyncResult BeginUpdateScheduledAudit(UpdateScheduledAuditRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateScheduledAudit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateScheduledAudit.</param>
        /// 
        /// <returns>Returns a  UpdateScheduledAuditResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateScheduledAudit">REST API Reference for UpdateScheduledAudit Operation</seealso>
        UpdateScheduledAuditResponse EndUpdateScheduledAudit(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSecurityProfile


        /// <summary>
        /// Updates a Device Defender security profile.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateSecurityProfile</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityProfile service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurityProfile service method, as returned by IoT.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateSecurityProfile">REST API Reference for UpdateSecurityProfile Operation</seealso>
        UpdateSecurityProfileResponse UpdateSecurityProfile(UpdateSecurityProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityProfile operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurityProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateSecurityProfile">REST API Reference for UpdateSecurityProfile Operation</seealso>
        IAsyncResult BeginUpdateSecurityProfile(UpdateSecurityProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurityProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurityProfile.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityProfileResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateSecurityProfile">REST API Reference for UpdateSecurityProfile Operation</seealso>
        UpdateSecurityProfileResponse EndUpdateSecurityProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStream


        /// <summary>
        /// Updates an existing stream. The stream version will be incremented by one.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateStream</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateStream operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateStream">REST API Reference for UpdateStream Operation</seealso>
        IAsyncResult BeginUpdateStream(UpdateStreamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStream.</param>
        /// 
        /// <returns>Returns a  UpdateStreamResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateStream">REST API Reference for UpdateStream Operation</seealso>
        UpdateStreamResponse EndUpdateStream(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateThing


        /// <summary>
        /// Updates the data for a thing.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateThing</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateThing operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThing">REST API Reference for UpdateThing Operation</seealso>
        IAsyncResult BeginUpdateThing(UpdateThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateThing.</param>
        /// 
        /// <returns>Returns a  UpdateThingResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThing">REST API Reference for UpdateThing Operation</seealso>
        UpdateThingResponse EndUpdateThing(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateThingGroup


        /// <summary>
        /// Update a thing group.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateThingGroup</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroup operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateThingGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroup">REST API Reference for UpdateThingGroup Operation</seealso>
        IAsyncResult BeginUpdateThingGroup(UpdateThingGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateThingGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateThingGroup.</param>
        /// 
        /// <returns>Returns a  UpdateThingGroupResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroup">REST API Reference for UpdateThingGroup Operation</seealso>
        UpdateThingGroupResponse EndUpdateThingGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateThingGroupsForThing


        /// <summary>
        /// Updates the groups to which the thing belongs.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateThingGroupsForThing</a>
        /// action.
        /// </para>
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingGroupsForThing operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateThingGroupsForThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroupsForThing">REST API Reference for UpdateThingGroupsForThing Operation</seealso>
        IAsyncResult BeginUpdateThingGroupsForThing(UpdateThingGroupsForThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateThingGroupsForThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateThingGroupsForThing.</param>
        /// 
        /// <returns>Returns a  UpdateThingGroupsForThingResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateThingGroupsForThing">REST API Reference for UpdateThingGroupsForThing Operation</seealso>
        UpdateThingGroupsForThingResponse EndUpdateThingGroupsForThing(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTopicRuleDestination


        /// <summary>
        /// Updates a topic rule destination. You use this to change the status, endpoint URL,
        /// or confirmation URL of the destination.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateTopicRuleDestination</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicRuleDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateTopicRuleDestination service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.ConflictingResourceUpdateException">
        /// A conflicting resource update exception. This exception is thrown when two pending
        /// updates cause a conflict.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateTopicRuleDestination">REST API Reference for UpdateTopicRuleDestination Operation</seealso>
        UpdateTopicRuleDestinationResponse UpdateTopicRuleDestination(UpdateTopicRuleDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTopicRuleDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTopicRuleDestination operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTopicRuleDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateTopicRuleDestination">REST API Reference for UpdateTopicRuleDestination Operation</seealso>
        IAsyncResult BeginUpdateTopicRuleDestination(UpdateTopicRuleDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTopicRuleDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTopicRuleDestination.</param>
        /// 
        /// <returns>Returns a  UpdateTopicRuleDestinationResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/UpdateTopicRuleDestination">REST API Reference for UpdateTopicRuleDestination Operation</seealso>
        UpdateTopicRuleDestinationResponse EndUpdateTopicRuleDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  ValidateSecurityProfileBehaviors


        /// <summary>
        /// Validates a Device Defender security profile behaviors specification.
        /// 
        ///  
        /// <para>
        /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ValidateSecurityProfileBehaviors</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateSecurityProfileBehaviors service method.</param>
        /// 
        /// <returns>The response from the ValidateSecurityProfileBehaviors service method, as returned by IoT.</returns>
        /// <exception cref="Amazon.IoT.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IoT.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ValidateSecurityProfileBehaviors">REST API Reference for ValidateSecurityProfileBehaviors Operation</seealso>
        ValidateSecurityProfileBehaviorsResponse ValidateSecurityProfileBehaviors(ValidateSecurityProfileBehaviorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ValidateSecurityProfileBehaviors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateSecurityProfileBehaviors operation on AmazonIoTClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndValidateSecurityProfileBehaviors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ValidateSecurityProfileBehaviors">REST API Reference for ValidateSecurityProfileBehaviors Operation</seealso>
        IAsyncResult BeginValidateSecurityProfileBehaviors(ValidateSecurityProfileBehaviorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ValidateSecurityProfileBehaviors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginValidateSecurityProfileBehaviors.</param>
        /// 
        /// <returns>Returns a  ValidateSecurityProfileBehaviorsResult from IoT.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iot-2015-05-28/ValidateSecurityProfileBehaviors">REST API Reference for ValidateSecurityProfileBehaviors Operation</seealso>
        ValidateSecurityProfileBehaviorsResponse EndValidateSecurityProfileBehaviors(IAsyncResult asyncResult);

        #endregion
        
    }
}