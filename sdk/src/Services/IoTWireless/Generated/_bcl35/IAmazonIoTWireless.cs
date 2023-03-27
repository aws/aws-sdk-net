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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoTWireless.Model;

namespace Amazon.IoTWireless
{
    /// <summary>
    /// Interface for accessing IoTWireless
    ///
    /// AWS IoT Wireless provides bi-directional communication between internet-connected
    /// wireless devices and the AWS Cloud. To onboard both LoRaWAN and Sidewalk devices to
    /// AWS IoT, use the IoT Wireless API. These wireless devices use the Low Power Wide Area
    /// Networking (LPWAN) communication protocol to communicate with AWS IoT.
    /// 
    ///  
    /// <para>
    /// Using the API, you can perform create, read, update, and delete operations for your
    /// wireless devices, gateways, destinations, and profiles. After onboarding your devices,
    /// you can use the API operations to set log levels and monitor your devices with CloudWatch.
    /// </para>
    ///  
    /// <para>
    /// You can also use the API operations to create multicast groups and schedule a multicast
    /// session for sending a downlink message to devices in the group. By using Firmware
    /// Updates Over-The-Air (FUOTA) API operations, you can create a FUOTA task and schedule
    /// a session to update the firmware of individual devices or an entire group of devices
    /// in a multicast group.
    /// </para>
    /// </summary>
    public partial interface IAmazonIoTWireless : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IIoTWirelessPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateAwsAccountWithPartnerAccount


        /// <summary>
        /// Associates a partner account with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsAccountWithPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the AssociateAwsAccountWithPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        AssociateAwsAccountWithPartnerAccountResponse AssociateAwsAccountWithPartnerAccount(AssociateAwsAccountWithPartnerAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAwsAccountWithPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAwsAccountWithPartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAwsAccountWithPartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        IAsyncResult BeginAssociateAwsAccountWithPartnerAccount(AssociateAwsAccountWithPartnerAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAwsAccountWithPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAwsAccountWithPartnerAccount.</param>
        /// 
        /// <returns>Returns a  AssociateAwsAccountWithPartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateAwsAccountWithPartnerAccount">REST API Reference for AssociateAwsAccountWithPartnerAccount Operation</seealso>
        AssociateAwsAccountWithPartnerAccountResponse EndAssociateAwsAccountWithPartnerAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateMulticastGroupWithFuotaTask


        /// <summary>
        /// Associate a multicast group with a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMulticastGroupWithFuotaTask service method.</param>
        /// 
        /// <returns>The response from the AssociateMulticastGroupWithFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateMulticastGroupWithFuotaTask">REST API Reference for AssociateMulticastGroupWithFuotaTask Operation</seealso>
        AssociateMulticastGroupWithFuotaTaskResponse AssociateMulticastGroupWithFuotaTask(AssociateMulticastGroupWithFuotaTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateMulticastGroupWithFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateMulticastGroupWithFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateMulticastGroupWithFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateMulticastGroupWithFuotaTask">REST API Reference for AssociateMulticastGroupWithFuotaTask Operation</seealso>
        IAsyncResult BeginAssociateMulticastGroupWithFuotaTask(AssociateMulticastGroupWithFuotaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateMulticastGroupWithFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateMulticastGroupWithFuotaTask.</param>
        /// 
        /// <returns>Returns a  AssociateMulticastGroupWithFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateMulticastGroupWithFuotaTask">REST API Reference for AssociateMulticastGroupWithFuotaTask Operation</seealso>
        AssociateMulticastGroupWithFuotaTaskResponse EndAssociateMulticastGroupWithFuotaTask(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateWirelessDeviceWithFuotaTask


        /// <summary>
        /// Associate a wireless device with a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithFuotaTask service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithFuotaTask">REST API Reference for AssociateWirelessDeviceWithFuotaTask Operation</seealso>
        AssociateWirelessDeviceWithFuotaTaskResponse AssociateWirelessDeviceWithFuotaTask(AssociateWirelessDeviceWithFuotaTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessDeviceWithFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessDeviceWithFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithFuotaTask">REST API Reference for AssociateWirelessDeviceWithFuotaTask Operation</seealso>
        IAsyncResult BeginAssociateWirelessDeviceWithFuotaTask(AssociateWirelessDeviceWithFuotaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessDeviceWithFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessDeviceWithFuotaTask.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessDeviceWithFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithFuotaTask">REST API Reference for AssociateWirelessDeviceWithFuotaTask Operation</seealso>
        AssociateWirelessDeviceWithFuotaTaskResponse EndAssociateWirelessDeviceWithFuotaTask(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateWirelessDeviceWithMulticastGroup


        /// <summary>
        /// Associates a wireless device with a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithMulticastGroup">REST API Reference for AssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        AssociateWirelessDeviceWithMulticastGroupResponse AssociateWirelessDeviceWithMulticastGroup(AssociateWirelessDeviceWithMulticastGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessDeviceWithMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessDeviceWithMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithMulticastGroup">REST API Reference for AssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        IAsyncResult BeginAssociateWirelessDeviceWithMulticastGroup(AssociateWirelessDeviceWithMulticastGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessDeviceWithMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessDeviceWithMulticastGroup.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessDeviceWithMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithMulticastGroup">REST API Reference for AssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        AssociateWirelessDeviceWithMulticastGroupResponse EndAssociateWirelessDeviceWithMulticastGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateWirelessDeviceWithThing


        /// <summary>
        /// Associates a wireless device with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithThing service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessDeviceWithThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        AssociateWirelessDeviceWithThingResponse AssociateWirelessDeviceWithThing(AssociateWirelessDeviceWithThingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessDeviceWithThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessDeviceWithThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessDeviceWithThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        IAsyncResult BeginAssociateWirelessDeviceWithThing(AssociateWirelessDeviceWithThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessDeviceWithThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessDeviceWithThing.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessDeviceWithThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessDeviceWithThing">REST API Reference for AssociateWirelessDeviceWithThing Operation</seealso>
        AssociateWirelessDeviceWithThingResponse EndAssociateWirelessDeviceWithThing(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateWirelessGatewayWithCertificate


        /// <summary>
        /// Associates a wireless gateway with a certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithCertificate service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessGatewayWithCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        AssociateWirelessGatewayWithCertificateResponse AssociateWirelessGatewayWithCertificate(AssociateWirelessGatewayWithCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessGatewayWithCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithCertificate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessGatewayWithCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        IAsyncResult BeginAssociateWirelessGatewayWithCertificate(AssociateWirelessGatewayWithCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessGatewayWithCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessGatewayWithCertificate.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessGatewayWithCertificateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithCertificate">REST API Reference for AssociateWirelessGatewayWithCertificate Operation</seealso>
        AssociateWirelessGatewayWithCertificateResponse EndAssociateWirelessGatewayWithCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateWirelessGatewayWithThing


        /// <summary>
        /// Associates a wireless gateway with a thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithThing service method.</param>
        /// 
        /// <returns>The response from the AssociateWirelessGatewayWithThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        AssociateWirelessGatewayWithThingResponse AssociateWirelessGatewayWithThing(AssociateWirelessGatewayWithThingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWirelessGatewayWithThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWirelessGatewayWithThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateWirelessGatewayWithThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        IAsyncResult BeginAssociateWirelessGatewayWithThing(AssociateWirelessGatewayWithThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateWirelessGatewayWithThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateWirelessGatewayWithThing.</param>
        /// 
        /// <returns>Returns a  AssociateWirelessGatewayWithThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/AssociateWirelessGatewayWithThing">REST API Reference for AssociateWirelessGatewayWithThing Operation</seealso>
        AssociateWirelessGatewayWithThingResponse EndAssociateWirelessGatewayWithThing(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelMulticastGroupSession


        /// <summary>
        /// Cancels an existing multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMulticastGroupSession service method.</param>
        /// 
        /// <returns>The response from the CancelMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CancelMulticastGroupSession">REST API Reference for CancelMulticastGroupSession Operation</seealso>
        CancelMulticastGroupSessionResponse CancelMulticastGroupSession(CancelMulticastGroupSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelMulticastGroupSession operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelMulticastGroupSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CancelMulticastGroupSession">REST API Reference for CancelMulticastGroupSession Operation</seealso>
        IAsyncResult BeginCancelMulticastGroupSession(CancelMulticastGroupSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelMulticastGroupSession.</param>
        /// 
        /// <returns>Returns a  CancelMulticastGroupSessionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CancelMulticastGroupSession">REST API Reference for CancelMulticastGroupSession Operation</seealso>
        CancelMulticastGroupSessionResponse EndCancelMulticastGroupSession(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDestination


        /// <summary>
        /// Creates a new destination that maps a device message to an AWS IoT rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination service method.</param>
        /// 
        /// <returns>The response from the CreateDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        CreateDestinationResponse CreateDestination(CreateDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        IAsyncResult BeginCreateDestination(CreateDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDestination.</param>
        /// 
        /// <returns>Returns a  CreateDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDestination">REST API Reference for CreateDestination Operation</seealso>
        CreateDestinationResponse EndCreateDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDeviceProfile


        /// <summary>
        /// Creates a new device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        CreateDeviceProfileResponse CreateDeviceProfile(CreateDeviceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeviceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDeviceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        IAsyncResult BeginCreateDeviceProfile(CreateDeviceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDeviceProfile.</param>
        /// 
        /// <returns>Returns a  CreateDeviceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateDeviceProfile">REST API Reference for CreateDeviceProfile Operation</seealso>
        CreateDeviceProfileResponse EndCreateDeviceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFuotaTask


        /// <summary>
        /// Creates a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFuotaTask service method.</param>
        /// 
        /// <returns>The response from the CreateFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateFuotaTask">REST API Reference for CreateFuotaTask Operation</seealso>
        CreateFuotaTaskResponse CreateFuotaTask(CreateFuotaTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateFuotaTask">REST API Reference for CreateFuotaTask Operation</seealso>
        IAsyncResult BeginCreateFuotaTask(CreateFuotaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFuotaTask.</param>
        /// 
        /// <returns>Returns a  CreateFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateFuotaTask">REST API Reference for CreateFuotaTask Operation</seealso>
        CreateFuotaTaskResponse EndCreateFuotaTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMulticastGroup


        /// <summary>
        /// Creates a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the CreateMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateMulticastGroup">REST API Reference for CreateMulticastGroup Operation</seealso>
        CreateMulticastGroupResponse CreateMulticastGroup(CreateMulticastGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateMulticastGroup">REST API Reference for CreateMulticastGroup Operation</seealso>
        IAsyncResult BeginCreateMulticastGroup(CreateMulticastGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMulticastGroup.</param>
        /// 
        /// <returns>Returns a  CreateMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateMulticastGroup">REST API Reference for CreateMulticastGroup Operation</seealso>
        CreateMulticastGroupResponse EndCreateMulticastGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNetworkAnalyzerConfiguration


        /// <summary>
        /// Creates a new network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAnalyzerConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateNetworkAnalyzerConfiguration">REST API Reference for CreateNetworkAnalyzerConfiguration Operation</seealso>
        CreateNetworkAnalyzerConfigurationResponse CreateNetworkAnalyzerConfiguration(CreateNetworkAnalyzerConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAnalyzerConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkAnalyzerConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateNetworkAnalyzerConfiguration">REST API Reference for CreateNetworkAnalyzerConfiguration Operation</seealso>
        IAsyncResult BeginCreateNetworkAnalyzerConfiguration(CreateNetworkAnalyzerConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAnalyzerConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateNetworkAnalyzerConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateNetworkAnalyzerConfiguration">REST API Reference for CreateNetworkAnalyzerConfiguration Operation</seealso>
        CreateNetworkAnalyzerConfigurationResponse EndCreateNetworkAnalyzerConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateServiceProfile


        /// <summary>
        /// Creates a new service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceProfile service method.</param>
        /// 
        /// <returns>The response from the CreateServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        CreateServiceProfileResponse CreateServiceProfile(CreateServiceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        IAsyncResult BeginCreateServiceProfile(CreateServiceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceProfile.</param>
        /// 
        /// <returns>Returns a  CreateServiceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateServiceProfile">REST API Reference for CreateServiceProfile Operation</seealso>
        CreateServiceProfileResponse EndCreateServiceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWirelessDevice


        /// <summary>
        /// Provisions a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        CreateWirelessDeviceResponse CreateWirelessDevice(CreateWirelessDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        IAsyncResult BeginCreateWirelessDevice(CreateWirelessDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessDevice.</param>
        /// 
        /// <returns>Returns a  CreateWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessDevice">REST API Reference for CreateWirelessDevice Operation</seealso>
        CreateWirelessDeviceResponse EndCreateWirelessDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWirelessGateway


        /// <summary>
        /// Provisions a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        CreateWirelessGatewayResponse CreateWirelessGateway(CreateWirelessGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        IAsyncResult BeginCreateWirelessGateway(CreateWirelessGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessGateway.</param>
        /// 
        /// <returns>Returns a  CreateWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGateway">REST API Reference for CreateWirelessGateway Operation</seealso>
        CreateWirelessGatewayResponse EndCreateWirelessGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWirelessGatewayTask


        /// <summary>
        /// Creates a task for a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        CreateWirelessGatewayTaskResponse CreateWirelessGatewayTask(CreateWirelessGatewayTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessGatewayTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        IAsyncResult BeginCreateWirelessGatewayTask(CreateWirelessGatewayTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessGatewayTask.</param>
        /// 
        /// <returns>Returns a  CreateWirelessGatewayTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTask">REST API Reference for CreateWirelessGatewayTask Operation</seealso>
        CreateWirelessGatewayTaskResponse EndCreateWirelessGatewayTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWirelessGatewayTaskDefinition


        /// <summary>
        /// Creates a gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the CreateWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        CreateWirelessGatewayTaskDefinitionResponse CreateWirelessGatewayTaskDefinition(CreateWirelessGatewayTaskDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWirelessGatewayTaskDefinition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWirelessGatewayTaskDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        IAsyncResult BeginCreateWirelessGatewayTaskDefinition(CreateWirelessGatewayTaskDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWirelessGatewayTaskDefinition.</param>
        /// 
        /// <returns>Returns a  CreateWirelessGatewayTaskDefinitionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/CreateWirelessGatewayTaskDefinition">REST API Reference for CreateWirelessGatewayTaskDefinition Operation</seealso>
        CreateWirelessGatewayTaskDefinitionResponse EndCreateWirelessGatewayTaskDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDestination


        /// <summary>
        /// Deletes a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        IAsyncResult BeginDeleteDestination(DeleteDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDestination.</param>
        /// 
        /// <returns>Returns a  DeleteDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        DeleteDestinationResponse EndDeleteDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDeviceProfile


        /// <summary>
        /// Deletes a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        DeleteDeviceProfileResponse DeleteDeviceProfile(DeleteDeviceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeviceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeviceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        IAsyncResult BeginDeleteDeviceProfile(DeleteDeviceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeviceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteDeviceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteDeviceProfile">REST API Reference for DeleteDeviceProfile Operation</seealso>
        DeleteDeviceProfileResponse EndDeleteDeviceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFuotaTask


        /// <summary>
        /// Deletes a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFuotaTask service method.</param>
        /// 
        /// <returns>The response from the DeleteFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteFuotaTask">REST API Reference for DeleteFuotaTask Operation</seealso>
        DeleteFuotaTaskResponse DeleteFuotaTask(DeleteFuotaTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteFuotaTask">REST API Reference for DeleteFuotaTask Operation</seealso>
        IAsyncResult BeginDeleteFuotaTask(DeleteFuotaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFuotaTask.</param>
        /// 
        /// <returns>Returns a  DeleteFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteFuotaTask">REST API Reference for DeleteFuotaTask Operation</seealso>
        DeleteFuotaTaskResponse EndDeleteFuotaTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMulticastGroup


        /// <summary>
        /// Deletes a multicast group if it is not in use by a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteMulticastGroup">REST API Reference for DeleteMulticastGroup Operation</seealso>
        DeleteMulticastGroupResponse DeleteMulticastGroup(DeleteMulticastGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteMulticastGroup">REST API Reference for DeleteMulticastGroup Operation</seealso>
        IAsyncResult BeginDeleteMulticastGroup(DeleteMulticastGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMulticastGroup.</param>
        /// 
        /// <returns>Returns a  DeleteMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteMulticastGroup">REST API Reference for DeleteMulticastGroup Operation</seealso>
        DeleteMulticastGroupResponse EndDeleteMulticastGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetworkAnalyzerConfiguration


        /// <summary>
        /// Deletes a network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAnalyzerConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteNetworkAnalyzerConfiguration">REST API Reference for DeleteNetworkAnalyzerConfiguration Operation</seealso>
        DeleteNetworkAnalyzerConfigurationResponse DeleteNetworkAnalyzerConfiguration(DeleteNetworkAnalyzerConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAnalyzerConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkAnalyzerConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteNetworkAnalyzerConfiguration">REST API Reference for DeleteNetworkAnalyzerConfiguration Operation</seealso>
        IAsyncResult BeginDeleteNetworkAnalyzerConfiguration(DeleteNetworkAnalyzerConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAnalyzerConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkAnalyzerConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteNetworkAnalyzerConfiguration">REST API Reference for DeleteNetworkAnalyzerConfiguration Operation</seealso>
        DeleteNetworkAnalyzerConfigurationResponse EndDeleteNetworkAnalyzerConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteQueuedMessages


        /// <summary>
        /// Remove queued messages from the downlink queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedMessages service method.</param>
        /// 
        /// <returns>The response from the DeleteQueuedMessages service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteQueuedMessages">REST API Reference for DeleteQueuedMessages Operation</seealso>
        DeleteQueuedMessagesResponse DeleteQueuedMessages(DeleteQueuedMessagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueuedMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueuedMessages operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueuedMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteQueuedMessages">REST API Reference for DeleteQueuedMessages Operation</seealso>
        IAsyncResult BeginDeleteQueuedMessages(DeleteQueuedMessagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueuedMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueuedMessages.</param>
        /// 
        /// <returns>Returns a  DeleteQueuedMessagesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteQueuedMessages">REST API Reference for DeleteQueuedMessages Operation</seealso>
        DeleteQueuedMessagesResponse EndDeleteQueuedMessages(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteServiceProfile


        /// <summary>
        /// Deletes a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceProfile service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        DeleteServiceProfileResponse DeleteServiceProfile(DeleteServiceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        IAsyncResult BeginDeleteServiceProfile(DeleteServiceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceProfile.</param>
        /// 
        /// <returns>Returns a  DeleteServiceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteServiceProfile">REST API Reference for DeleteServiceProfile Operation</seealso>
        DeleteServiceProfileResponse EndDeleteServiceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWirelessDevice


        /// <summary>
        /// Deletes a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        DeleteWirelessDeviceResponse DeleteWirelessDevice(DeleteWirelessDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        IAsyncResult BeginDeleteWirelessDevice(DeleteWirelessDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessDevice.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDevice">REST API Reference for DeleteWirelessDevice Operation</seealso>
        DeleteWirelessDeviceResponse EndDeleteWirelessDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWirelessDeviceImportTask


        /// <summary>
        /// Delete an import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDeviceImportTask">REST API Reference for DeleteWirelessDeviceImportTask Operation</seealso>
        DeleteWirelessDeviceImportTaskResponse DeleteWirelessDeviceImportTask(DeleteWirelessDeviceImportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDeviceImportTask">REST API Reference for DeleteWirelessDeviceImportTask Operation</seealso>
        IAsyncResult BeginDeleteWirelessDeviceImportTask(DeleteWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessDeviceImportTask">REST API Reference for DeleteWirelessDeviceImportTask Operation</seealso>
        DeleteWirelessDeviceImportTaskResponse EndDeleteWirelessDeviceImportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWirelessGateway


        /// <summary>
        /// Deletes a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        DeleteWirelessGatewayResponse DeleteWirelessGateway(DeleteWirelessGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        IAsyncResult BeginDeleteWirelessGateway(DeleteWirelessGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessGateway.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGateway">REST API Reference for DeleteWirelessGateway Operation</seealso>
        DeleteWirelessGatewayResponse EndDeleteWirelessGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWirelessGatewayTask


        /// <summary>
        /// Deletes a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        DeleteWirelessGatewayTaskResponse DeleteWirelessGatewayTask(DeleteWirelessGatewayTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessGatewayTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        IAsyncResult BeginDeleteWirelessGatewayTask(DeleteWirelessGatewayTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessGatewayTask.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessGatewayTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTask">REST API Reference for DeleteWirelessGatewayTask Operation</seealso>
        DeleteWirelessGatewayTaskResponse EndDeleteWirelessGatewayTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWirelessGatewayTaskDefinition


        /// <summary>
        /// Deletes a wireless gateway task definition. Deleting this task definition does not
        /// affect tasks that are currently in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        DeleteWirelessGatewayTaskDefinitionResponse DeleteWirelessGatewayTaskDefinition(DeleteWirelessGatewayTaskDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWirelessGatewayTaskDefinition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWirelessGatewayTaskDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        IAsyncResult BeginDeleteWirelessGatewayTaskDefinition(DeleteWirelessGatewayTaskDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWirelessGatewayTaskDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteWirelessGatewayTaskDefinitionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeleteWirelessGatewayTaskDefinition">REST API Reference for DeleteWirelessGatewayTaskDefinition Operation</seealso>
        DeleteWirelessGatewayTaskDefinitionResponse EndDeleteWirelessGatewayTaskDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterWirelessDevice


        /// <summary>
        /// Deregister a wireless device from AWS IoT Wireless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the DeregisterWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeregisterWirelessDevice">REST API Reference for DeregisterWirelessDevice Operation</seealso>
        DeregisterWirelessDeviceResponse DeregisterWirelessDevice(DeregisterWirelessDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeregisterWirelessDevice">REST API Reference for DeregisterWirelessDevice Operation</seealso>
        IAsyncResult BeginDeregisterWirelessDevice(DeregisterWirelessDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterWirelessDevice.</param>
        /// 
        /// <returns>Returns a  DeregisterWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DeregisterWirelessDevice">REST API Reference for DeregisterWirelessDevice Operation</seealso>
        DeregisterWirelessDeviceResponse EndDeregisterWirelessDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateAwsAccountFromPartnerAccount


        /// <summary>
        /// Disassociates your AWS account from a partner account. If <code>PartnerAccountId</code>
        /// and <code>PartnerType</code> are <code>null</code>, disassociates your AWS account
        /// from all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsAccountFromPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateAwsAccountFromPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        DisassociateAwsAccountFromPartnerAccountResponse DisassociateAwsAccountFromPartnerAccount(DisassociateAwsAccountFromPartnerAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAwsAccountFromPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAwsAccountFromPartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAwsAccountFromPartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        IAsyncResult BeginDisassociateAwsAccountFromPartnerAccount(DisassociateAwsAccountFromPartnerAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAwsAccountFromPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAwsAccountFromPartnerAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateAwsAccountFromPartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateAwsAccountFromPartnerAccount">REST API Reference for DisassociateAwsAccountFromPartnerAccount Operation</seealso>
        DisassociateAwsAccountFromPartnerAccountResponse EndDisassociateAwsAccountFromPartnerAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMulticastGroupFromFuotaTask


        /// <summary>
        /// Disassociates a multicast group from a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMulticastGroupFromFuotaTask service method.</param>
        /// 
        /// <returns>The response from the DisassociateMulticastGroupFromFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateMulticastGroupFromFuotaTask">REST API Reference for DisassociateMulticastGroupFromFuotaTask Operation</seealso>
        DisassociateMulticastGroupFromFuotaTaskResponse DisassociateMulticastGroupFromFuotaTask(DisassociateMulticastGroupFromFuotaTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMulticastGroupFromFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMulticastGroupFromFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMulticastGroupFromFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateMulticastGroupFromFuotaTask">REST API Reference for DisassociateMulticastGroupFromFuotaTask Operation</seealso>
        IAsyncResult BeginDisassociateMulticastGroupFromFuotaTask(DisassociateMulticastGroupFromFuotaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMulticastGroupFromFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMulticastGroupFromFuotaTask.</param>
        /// 
        /// <returns>Returns a  DisassociateMulticastGroupFromFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateMulticastGroupFromFuotaTask">REST API Reference for DisassociateMulticastGroupFromFuotaTask Operation</seealso>
        DisassociateMulticastGroupFromFuotaTaskResponse EndDisassociateMulticastGroupFromFuotaTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateWirelessDeviceFromFuotaTask


        /// <summary>
        /// Disassociates a wireless device from a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromFuotaTask service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromFuotaTask">REST API Reference for DisassociateWirelessDeviceFromFuotaTask Operation</seealso>
        DisassociateWirelessDeviceFromFuotaTaskResponse DisassociateWirelessDeviceFromFuotaTask(DisassociateWirelessDeviceFromFuotaTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessDeviceFromFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessDeviceFromFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromFuotaTask">REST API Reference for DisassociateWirelessDeviceFromFuotaTask Operation</seealso>
        IAsyncResult BeginDisassociateWirelessDeviceFromFuotaTask(DisassociateWirelessDeviceFromFuotaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessDeviceFromFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessDeviceFromFuotaTask.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessDeviceFromFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromFuotaTask">REST API Reference for DisassociateWirelessDeviceFromFuotaTask Operation</seealso>
        DisassociateWirelessDeviceFromFuotaTaskResponse EndDisassociateWirelessDeviceFromFuotaTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateWirelessDeviceFromMulticastGroup


        /// <summary>
        /// Disassociates a wireless device from a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromMulticastGroup">REST API Reference for DisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        DisassociateWirelessDeviceFromMulticastGroupResponse DisassociateWirelessDeviceFromMulticastGroup(DisassociateWirelessDeviceFromMulticastGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessDeviceFromMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessDeviceFromMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromMulticastGroup">REST API Reference for DisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        IAsyncResult BeginDisassociateWirelessDeviceFromMulticastGroup(DisassociateWirelessDeviceFromMulticastGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessDeviceFromMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessDeviceFromMulticastGroup.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessDeviceFromMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromMulticastGroup">REST API Reference for DisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        DisassociateWirelessDeviceFromMulticastGroupResponse EndDisassociateWirelessDeviceFromMulticastGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateWirelessDeviceFromThing


        /// <summary>
        /// Disassociates a wireless device from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromThing service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessDeviceFromThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        DisassociateWirelessDeviceFromThingResponse DisassociateWirelessDeviceFromThing(DisassociateWirelessDeviceFromThingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessDeviceFromThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessDeviceFromThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessDeviceFromThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        IAsyncResult BeginDisassociateWirelessDeviceFromThing(DisassociateWirelessDeviceFromThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessDeviceFromThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessDeviceFromThing.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessDeviceFromThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessDeviceFromThing">REST API Reference for DisassociateWirelessDeviceFromThing Operation</seealso>
        DisassociateWirelessDeviceFromThingResponse EndDisassociateWirelessDeviceFromThing(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateWirelessGatewayFromCertificate


        /// <summary>
        /// Disassociates a wireless gateway from its currently associated certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromCertificate service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessGatewayFromCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        DisassociateWirelessGatewayFromCertificateResponse DisassociateWirelessGatewayFromCertificate(DisassociateWirelessGatewayFromCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessGatewayFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromCertificate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessGatewayFromCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        IAsyncResult BeginDisassociateWirelessGatewayFromCertificate(DisassociateWirelessGatewayFromCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessGatewayFromCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessGatewayFromCertificate.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessGatewayFromCertificateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromCertificate">REST API Reference for DisassociateWirelessGatewayFromCertificate Operation</seealso>
        DisassociateWirelessGatewayFromCertificateResponse EndDisassociateWirelessGatewayFromCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateWirelessGatewayFromThing


        /// <summary>
        /// Disassociates a wireless gateway from its currently associated thing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromThing service method.</param>
        /// 
        /// <returns>The response from the DisassociateWirelessGatewayFromThing service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        DisassociateWirelessGatewayFromThingResponse DisassociateWirelessGatewayFromThing(DisassociateWirelessGatewayFromThingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWirelessGatewayFromThing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWirelessGatewayFromThing operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateWirelessGatewayFromThing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        IAsyncResult BeginDisassociateWirelessGatewayFromThing(DisassociateWirelessGatewayFromThingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateWirelessGatewayFromThing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateWirelessGatewayFromThing.</param>
        /// 
        /// <returns>Returns a  DisassociateWirelessGatewayFromThingResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/DisassociateWirelessGatewayFromThing">REST API Reference for DisassociateWirelessGatewayFromThing Operation</seealso>
        DisassociateWirelessGatewayFromThingResponse EndDisassociateWirelessGatewayFromThing(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDestination


        /// <summary>
        /// Gets information about a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDestination service method.</param>
        /// 
        /// <returns>The response from the GetDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        GetDestinationResponse GetDestination(GetDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        IAsyncResult BeginGetDestination(GetDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDestination.</param>
        /// 
        /// <returns>Returns a  GetDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDestination">REST API Reference for GetDestination Operation</seealso>
        GetDestinationResponse EndGetDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDeviceProfile


        /// <summary>
        /// Gets information about a device profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceProfile service method.</param>
        /// 
        /// <returns>The response from the GetDeviceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        GetDeviceProfileResponse GetDeviceProfile(GetDeviceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeviceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        IAsyncResult BeginGetDeviceProfile(GetDeviceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeviceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeviceProfile.</param>
        /// 
        /// <returns>Returns a  GetDeviceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetDeviceProfile">REST API Reference for GetDeviceProfile Operation</seealso>
        GetDeviceProfileResponse EndGetDeviceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventConfigurationByResourceTypes


        /// <summary>
        /// Get the event configuration based on resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventConfigurationByResourceTypes service method.</param>
        /// 
        /// <returns>The response from the GetEventConfigurationByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetEventConfigurationByResourceTypes">REST API Reference for GetEventConfigurationByResourceTypes Operation</seealso>
        GetEventConfigurationByResourceTypesResponse GetEventConfigurationByResourceTypes(GetEventConfigurationByResourceTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventConfigurationByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventConfigurationByResourceTypes operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventConfigurationByResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetEventConfigurationByResourceTypes">REST API Reference for GetEventConfigurationByResourceTypes Operation</seealso>
        IAsyncResult BeginGetEventConfigurationByResourceTypes(GetEventConfigurationByResourceTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventConfigurationByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventConfigurationByResourceTypes.</param>
        /// 
        /// <returns>Returns a  GetEventConfigurationByResourceTypesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetEventConfigurationByResourceTypes">REST API Reference for GetEventConfigurationByResourceTypes Operation</seealso>
        GetEventConfigurationByResourceTypesResponse EndGetEventConfigurationByResourceTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFuotaTask


        /// <summary>
        /// Gets information about a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFuotaTask service method.</param>
        /// 
        /// <returns>The response from the GetFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetFuotaTask">REST API Reference for GetFuotaTask Operation</seealso>
        GetFuotaTaskResponse GetFuotaTask(GetFuotaTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetFuotaTask">REST API Reference for GetFuotaTask Operation</seealso>
        IAsyncResult BeginGetFuotaTask(GetFuotaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFuotaTask.</param>
        /// 
        /// <returns>Returns a  GetFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetFuotaTask">REST API Reference for GetFuotaTask Operation</seealso>
        GetFuotaTaskResponse EndGetFuotaTask(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLogLevelsByResourceTypes


        /// <summary>
        /// Returns current default log levels or log levels by resource types. Based on resource
        /// types, log levels can be for wireless device log options or wireless gateway log options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogLevelsByResourceTypes service method.</param>
        /// 
        /// <returns>The response from the GetLogLevelsByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetLogLevelsByResourceTypes">REST API Reference for GetLogLevelsByResourceTypes Operation</seealso>
        GetLogLevelsByResourceTypesResponse GetLogLevelsByResourceTypes(GetLogLevelsByResourceTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLogLevelsByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLogLevelsByResourceTypes operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLogLevelsByResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetLogLevelsByResourceTypes">REST API Reference for GetLogLevelsByResourceTypes Operation</seealso>
        IAsyncResult BeginGetLogLevelsByResourceTypes(GetLogLevelsByResourceTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLogLevelsByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLogLevelsByResourceTypes.</param>
        /// 
        /// <returns>Returns a  GetLogLevelsByResourceTypesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetLogLevelsByResourceTypes">REST API Reference for GetLogLevelsByResourceTypes Operation</seealso>
        GetLogLevelsByResourceTypesResponse EndGetLogLevelsByResourceTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMulticastGroup


        /// <summary>
        /// Gets information about a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the GetMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroup">REST API Reference for GetMulticastGroup Operation</seealso>
        GetMulticastGroupResponse GetMulticastGroup(GetMulticastGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroup">REST API Reference for GetMulticastGroup Operation</seealso>
        IAsyncResult BeginGetMulticastGroup(GetMulticastGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMulticastGroup.</param>
        /// 
        /// <returns>Returns a  GetMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroup">REST API Reference for GetMulticastGroup Operation</seealso>
        GetMulticastGroupResponse EndGetMulticastGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMulticastGroupSession


        /// <summary>
        /// Gets information about a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroupSession service method.</param>
        /// 
        /// <returns>The response from the GetMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroupSession">REST API Reference for GetMulticastGroupSession Operation</seealso>
        GetMulticastGroupSessionResponse GetMulticastGroupSession(GetMulticastGroupSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMulticastGroupSession operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMulticastGroupSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroupSession">REST API Reference for GetMulticastGroupSession Operation</seealso>
        IAsyncResult BeginGetMulticastGroupSession(GetMulticastGroupSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMulticastGroupSession.</param>
        /// 
        /// <returns>Returns a  GetMulticastGroupSessionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetMulticastGroupSession">REST API Reference for GetMulticastGroupSession Operation</seealso>
        GetMulticastGroupSessionResponse EndGetMulticastGroupSession(IAsyncResult asyncResult);

        #endregion
        
        #region  GetNetworkAnalyzerConfiguration


        /// <summary>
        /// Get network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkAnalyzerConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetNetworkAnalyzerConfiguration">REST API Reference for GetNetworkAnalyzerConfiguration Operation</seealso>
        GetNetworkAnalyzerConfigurationResponse GetNetworkAnalyzerConfiguration(GetNetworkAnalyzerConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkAnalyzerConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkAnalyzerConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetNetworkAnalyzerConfiguration">REST API Reference for GetNetworkAnalyzerConfiguration Operation</seealso>
        IAsyncResult BeginGetNetworkAnalyzerConfiguration(GetNetworkAnalyzerConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkAnalyzerConfiguration.</param>
        /// 
        /// <returns>Returns a  GetNetworkAnalyzerConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetNetworkAnalyzerConfiguration">REST API Reference for GetNetworkAnalyzerConfiguration Operation</seealso>
        GetNetworkAnalyzerConfigurationResponse EndGetNetworkAnalyzerConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPartnerAccount


        /// <summary>
        /// Gets information about a partner account. If <code>PartnerAccountId</code> and <code>PartnerType</code>
        /// are <code>null</code>, returns all partner accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPartnerAccount service method.</param>
        /// 
        /// <returns>The response from the GetPartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        GetPartnerAccountResponse GetPartnerAccount(GetPartnerAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        IAsyncResult BeginGetPartnerAccount(GetPartnerAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPartnerAccount.</param>
        /// 
        /// <returns>Returns a  GetPartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPartnerAccount">REST API Reference for GetPartnerAccount Operation</seealso>
        GetPartnerAccountResponse EndGetPartnerAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPosition


        /// <summary>
        /// Get the position information for a given resource.
        /// 
        ///  <important> 
        /// <para>
        /// This action is no longer supported. Calls to retrieve the position information should
        /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_GetResourcePosition.html">GetResourcePosition</a>
        /// API operation instead.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPosition service method.</param>
        /// 
        /// <returns>The response from the GetPosition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPosition">REST API Reference for GetPosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        GetPositionResponse GetPosition(GetPositionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPosition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPosition">REST API Reference for GetPosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        IAsyncResult BeginGetPosition(GetPositionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPosition.</param>
        /// 
        /// <returns>Returns a  GetPositionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPosition">REST API Reference for GetPosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        GetPositionResponse EndGetPosition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPositionConfiguration


        /// <summary>
        /// Get position configuration for a given resource.
        /// 
        ///  <important> 
        /// <para>
        /// This action is no longer supported. Calls to retrieve the position configuration should
        /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_GetResourcePosition.html">GetResourcePosition</a>
        /// API operation instead.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPositionConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetPositionConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionConfiguration">REST API Reference for GetPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        GetPositionConfigurationResponse GetPositionConfiguration(GetPositionConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPositionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPositionConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPositionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionConfiguration">REST API Reference for GetPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        IAsyncResult BeginGetPositionConfiguration(GetPositionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPositionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPositionConfiguration.</param>
        /// 
        /// <returns>Returns a  GetPositionConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionConfiguration">REST API Reference for GetPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        GetPositionConfigurationResponse EndGetPositionConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPositionEstimate


        /// <summary>
        /// Get estimated position information as a payload in GeoJSON format. The payload measurement
        /// data is resolved using solvers that are provided by third-party vendors.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPositionEstimate service method.</param>
        /// 
        /// <returns>The response from the GetPositionEstimate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionEstimate">REST API Reference for GetPositionEstimate Operation</seealso>
        GetPositionEstimateResponse GetPositionEstimate(GetPositionEstimateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPositionEstimate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPositionEstimate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPositionEstimate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionEstimate">REST API Reference for GetPositionEstimate Operation</seealso>
        IAsyncResult BeginGetPositionEstimate(GetPositionEstimateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPositionEstimate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPositionEstimate.</param>
        /// 
        /// <returns>Returns a  GetPositionEstimateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetPositionEstimate">REST API Reference for GetPositionEstimate Operation</seealso>
        GetPositionEstimateResponse EndGetPositionEstimate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceEventConfiguration


        /// <summary>
        /// Get the event configuration for a particular resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetResourceEventConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceEventConfiguration">REST API Reference for GetResourceEventConfiguration Operation</seealso>
        GetResourceEventConfigurationResponse GetResourceEventConfiguration(GetResourceEventConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceEventConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceEventConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceEventConfiguration">REST API Reference for GetResourceEventConfiguration Operation</seealso>
        IAsyncResult BeginGetResourceEventConfiguration(GetResourceEventConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceEventConfiguration.</param>
        /// 
        /// <returns>Returns a  GetResourceEventConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceEventConfiguration">REST API Reference for GetResourceEventConfiguration Operation</seealso>
        GetResourceEventConfigurationResponse EndGetResourceEventConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourceLogLevel


        /// <summary>
        /// Fetches the log-level override, if any, for a given resource-ID and resource-type.
        /// It can be used for a wireless device or a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLogLevel service method.</param>
        /// 
        /// <returns>The response from the GetResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceLogLevel">REST API Reference for GetResourceLogLevel Operation</seealso>
        GetResourceLogLevelResponse GetResourceLogLevel(GetResourceLogLevelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceLogLevel operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceLogLevel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceLogLevel">REST API Reference for GetResourceLogLevel Operation</seealso>
        IAsyncResult BeginGetResourceLogLevel(GetResourceLogLevelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceLogLevel.</param>
        /// 
        /// <returns>Returns a  GetResourceLogLevelResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourceLogLevel">REST API Reference for GetResourceLogLevel Operation</seealso>
        GetResourceLogLevelResponse EndGetResourceLogLevel(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResourcePosition


        /// <summary>
        /// Get the position information for a given wireless device or a wireless gateway resource.
        /// The position information uses the <a href="https://gisgeography.com/wgs84-world-geodetic-system/">
        /// World Geodetic System (WGS84)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePosition service method.</param>
        /// 
        /// <returns>The response from the GetResourcePosition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourcePosition">REST API Reference for GetResourcePosition Operation</seealso>
        GetResourcePositionResponse GetResourcePosition(GetResourcePositionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePosition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourcePosition">REST API Reference for GetResourcePosition Operation</seealso>
        IAsyncResult BeginGetResourcePosition(GetResourcePositionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePosition.</param>
        /// 
        /// <returns>Returns a  GetResourcePositionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetResourcePosition">REST API Reference for GetResourcePosition Operation</seealso>
        GetResourcePositionResponse EndGetResourcePosition(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceEndpoint


        /// <summary>
        /// Gets the account-specific endpoint for Configuration and Update Server (CUPS) protocol
        /// or LoRaWAN Network Server (LNS) connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceEndpoint service method.</param>
        /// 
        /// <returns>The response from the GetServiceEndpoint service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        GetServiceEndpointResponse GetServiceEndpoint(GetServiceEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceEndpoint operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        IAsyncResult BeginGetServiceEndpoint(GetServiceEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceEndpoint.</param>
        /// 
        /// <returns>Returns a  GetServiceEndpointResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceEndpoint">REST API Reference for GetServiceEndpoint Operation</seealso>
        GetServiceEndpointResponse EndGetServiceEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetServiceProfile


        /// <summary>
        /// Gets information about a service profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceProfile service method.</param>
        /// 
        /// <returns>The response from the GetServiceProfile service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        GetServiceProfileResponse GetServiceProfile(GetServiceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceProfile operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        IAsyncResult BeginGetServiceProfile(GetServiceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceProfile.</param>
        /// 
        /// <returns>Returns a  GetServiceProfileResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetServiceProfile">REST API Reference for GetServiceProfile Operation</seealso>
        GetServiceProfileResponse EndGetServiceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWirelessDevice


        /// <summary>
        /// Gets information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the GetWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        GetWirelessDeviceResponse GetWirelessDevice(GetWirelessDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        IAsyncResult BeginGetWirelessDevice(GetWirelessDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessDevice.</param>
        /// 
        /// <returns>Returns a  GetWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDevice">REST API Reference for GetWirelessDevice Operation</seealso>
        GetWirelessDeviceResponse EndGetWirelessDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWirelessDeviceImportTask


        /// <summary>
        /// Get information about an import task and count of device onboarding summary information
        /// for the import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the GetWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceImportTask">REST API Reference for GetWirelessDeviceImportTask Operation</seealso>
        GetWirelessDeviceImportTaskResponse GetWirelessDeviceImportTask(GetWirelessDeviceImportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceImportTask">REST API Reference for GetWirelessDeviceImportTask Operation</seealso>
        IAsyncResult BeginGetWirelessDeviceImportTask(GetWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  GetWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceImportTask">REST API Reference for GetWirelessDeviceImportTask Operation</seealso>
        GetWirelessDeviceImportTaskResponse EndGetWirelessDeviceImportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWirelessDeviceStatistics


        /// <summary>
        /// Gets operating information about a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceStatistics service method.</param>
        /// 
        /// <returns>The response from the GetWirelessDeviceStatistics service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        GetWirelessDeviceStatisticsResponse GetWirelessDeviceStatistics(GetWirelessDeviceStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessDeviceStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessDeviceStatistics operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessDeviceStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        IAsyncResult BeginGetWirelessDeviceStatistics(GetWirelessDeviceStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessDeviceStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessDeviceStatistics.</param>
        /// 
        /// <returns>Returns a  GetWirelessDeviceStatisticsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessDeviceStatistics">REST API Reference for GetWirelessDeviceStatistics Operation</seealso>
        GetWirelessDeviceStatisticsResponse EndGetWirelessDeviceStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWirelessGateway


        /// <summary>
        /// Gets information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        GetWirelessGatewayResponse GetWirelessGateway(GetWirelessGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        IAsyncResult BeginGetWirelessGateway(GetWirelessGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGateway.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGateway">REST API Reference for GetWirelessGateway Operation</seealso>
        GetWirelessGatewayResponse EndGetWirelessGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWirelessGatewayCertificate


        /// <summary>
        /// Gets the ID of the certificate that is currently associated with a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayCertificate service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayCertificate service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        GetWirelessGatewayCertificateResponse GetWirelessGatewayCertificate(GetWirelessGatewayCertificateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayCertificate operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayCertificate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        IAsyncResult BeginGetWirelessGatewayCertificate(GetWirelessGatewayCertificateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayCertificate.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayCertificateResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayCertificate">REST API Reference for GetWirelessGatewayCertificate Operation</seealso>
        GetWirelessGatewayCertificateResponse EndGetWirelessGatewayCertificate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWirelessGatewayFirmwareInformation


        /// <summary>
        /// Gets the firmware version and other information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayFirmwareInformation service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayFirmwareInformation service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        GetWirelessGatewayFirmwareInformationResponse GetWirelessGatewayFirmwareInformation(GetWirelessGatewayFirmwareInformationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayFirmwareInformation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayFirmwareInformation operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayFirmwareInformation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        IAsyncResult BeginGetWirelessGatewayFirmwareInformation(GetWirelessGatewayFirmwareInformationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayFirmwareInformation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayFirmwareInformation.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayFirmwareInformationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayFirmwareInformation">REST API Reference for GetWirelessGatewayFirmwareInformation Operation</seealso>
        GetWirelessGatewayFirmwareInformationResponse EndGetWirelessGatewayFirmwareInformation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWirelessGatewayStatistics


        /// <summary>
        /// Gets operating information about a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayStatistics service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayStatistics service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        GetWirelessGatewayStatisticsResponse GetWirelessGatewayStatistics(GetWirelessGatewayStatisticsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayStatistics operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayStatistics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        IAsyncResult BeginGetWirelessGatewayStatistics(GetWirelessGatewayStatisticsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayStatistics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayStatistics.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayStatisticsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayStatistics">REST API Reference for GetWirelessGatewayStatistics Operation</seealso>
        GetWirelessGatewayStatisticsResponse EndGetWirelessGatewayStatistics(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWirelessGatewayTask


        /// <summary>
        /// Gets information about a wireless gateway task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTask service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        GetWirelessGatewayTaskResponse GetWirelessGatewayTask(GetWirelessGatewayTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        IAsyncResult BeginGetWirelessGatewayTask(GetWirelessGatewayTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayTask.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTask">REST API Reference for GetWirelessGatewayTask Operation</seealso>
        GetWirelessGatewayTaskResponse EndGetWirelessGatewayTask(IAsyncResult asyncResult);

        #endregion
        
        #region  GetWirelessGatewayTaskDefinition


        /// <summary>
        /// Gets information about a wireless gateway task definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTaskDefinition service method.</param>
        /// 
        /// <returns>The response from the GetWirelessGatewayTaskDefinition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        GetWirelessGatewayTaskDefinitionResponse GetWirelessGatewayTaskDefinition(GetWirelessGatewayTaskDefinitionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetWirelessGatewayTaskDefinition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetWirelessGatewayTaskDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        IAsyncResult BeginGetWirelessGatewayTaskDefinition(GetWirelessGatewayTaskDefinitionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetWirelessGatewayTaskDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetWirelessGatewayTaskDefinition.</param>
        /// 
        /// <returns>Returns a  GetWirelessGatewayTaskDefinitionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/GetWirelessGatewayTaskDefinition">REST API Reference for GetWirelessGatewayTaskDefinition Operation</seealso>
        GetWirelessGatewayTaskDefinitionResponse EndGetWirelessGatewayTaskDefinition(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDestinations


        /// <summary>
        /// Lists the destinations registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations service method.</param>
        /// 
        /// <returns>The response from the ListDestinations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        ListDestinationsResponse ListDestinations(ListDestinationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDestinations operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        IAsyncResult BeginListDestinations(ListDestinationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDestinations.</param>
        /// 
        /// <returns>Returns a  ListDestinationsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDestinations">REST API Reference for ListDestinations Operation</seealso>
        ListDestinationsResponse EndListDestinations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeviceProfiles


        /// <summary>
        /// Lists the device profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListDeviceProfiles service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        ListDeviceProfilesResponse ListDeviceProfiles(ListDeviceProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceProfiles operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        IAsyncResult BeginListDeviceProfiles(ListDeviceProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceProfiles.</param>
        /// 
        /// <returns>Returns a  ListDeviceProfilesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDeviceProfiles">REST API Reference for ListDeviceProfiles Operation</seealso>
        ListDeviceProfilesResponse EndListDeviceProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDevicesForWirelessDeviceImportTask


        /// <summary>
        /// List the Sidewalk devices in an import task and their onboarding status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesForWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the ListDevicesForWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDevicesForWirelessDeviceImportTask">REST API Reference for ListDevicesForWirelessDeviceImportTask Operation</seealso>
        ListDevicesForWirelessDeviceImportTaskResponse ListDevicesForWirelessDeviceImportTask(ListDevicesForWirelessDeviceImportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevicesForWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevicesForWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevicesForWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDevicesForWirelessDeviceImportTask">REST API Reference for ListDevicesForWirelessDeviceImportTask Operation</seealso>
        IAsyncResult BeginListDevicesForWirelessDeviceImportTask(ListDevicesForWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevicesForWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevicesForWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  ListDevicesForWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListDevicesForWirelessDeviceImportTask">REST API Reference for ListDevicesForWirelessDeviceImportTask Operation</seealso>
        ListDevicesForWirelessDeviceImportTaskResponse EndListDevicesForWirelessDeviceImportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventConfigurations


        /// <summary>
        /// List event configurations where at least one event topic has been enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListEventConfigurations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListEventConfigurations">REST API Reference for ListEventConfigurations Operation</seealso>
        ListEventConfigurationsResponse ListEventConfigurations(ListEventConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventConfigurations operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListEventConfigurations">REST API Reference for ListEventConfigurations Operation</seealso>
        IAsyncResult BeginListEventConfigurations(ListEventConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventConfigurations.</param>
        /// 
        /// <returns>Returns a  ListEventConfigurationsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListEventConfigurations">REST API Reference for ListEventConfigurations Operation</seealso>
        ListEventConfigurationsResponse EndListEventConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFuotaTasks


        /// <summary>
        /// Lists the FUOTA tasks registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFuotaTasks service method.</param>
        /// 
        /// <returns>The response from the ListFuotaTasks service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListFuotaTasks">REST API Reference for ListFuotaTasks Operation</seealso>
        ListFuotaTasksResponse ListFuotaTasks(ListFuotaTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFuotaTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFuotaTasks operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFuotaTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListFuotaTasks">REST API Reference for ListFuotaTasks Operation</seealso>
        IAsyncResult BeginListFuotaTasks(ListFuotaTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFuotaTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFuotaTasks.</param>
        /// 
        /// <returns>Returns a  ListFuotaTasksResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListFuotaTasks">REST API Reference for ListFuotaTasks Operation</seealso>
        ListFuotaTasksResponse EndListFuotaTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMulticastGroups


        /// <summary>
        /// Lists the multicast groups registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroups service method.</param>
        /// 
        /// <returns>The response from the ListMulticastGroups service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroups">REST API Reference for ListMulticastGroups Operation</seealso>
        ListMulticastGroupsResponse ListMulticastGroups(ListMulticastGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMulticastGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroups operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMulticastGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroups">REST API Reference for ListMulticastGroups Operation</seealso>
        IAsyncResult BeginListMulticastGroups(ListMulticastGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMulticastGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMulticastGroups.</param>
        /// 
        /// <returns>Returns a  ListMulticastGroupsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroups">REST API Reference for ListMulticastGroups Operation</seealso>
        ListMulticastGroupsResponse EndListMulticastGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMulticastGroupsByFuotaTask


        /// <summary>
        /// List all multicast groups associated with a fuota task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroupsByFuotaTask service method.</param>
        /// 
        /// <returns>The response from the ListMulticastGroupsByFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroupsByFuotaTask">REST API Reference for ListMulticastGroupsByFuotaTask Operation</seealso>
        ListMulticastGroupsByFuotaTaskResponse ListMulticastGroupsByFuotaTask(ListMulticastGroupsByFuotaTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMulticastGroupsByFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMulticastGroupsByFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMulticastGroupsByFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroupsByFuotaTask">REST API Reference for ListMulticastGroupsByFuotaTask Operation</seealso>
        IAsyncResult BeginListMulticastGroupsByFuotaTask(ListMulticastGroupsByFuotaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMulticastGroupsByFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMulticastGroupsByFuotaTask.</param>
        /// 
        /// <returns>Returns a  ListMulticastGroupsByFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListMulticastGroupsByFuotaTask">REST API Reference for ListMulticastGroupsByFuotaTask Operation</seealso>
        ListMulticastGroupsByFuotaTaskResponse EndListMulticastGroupsByFuotaTask(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNetworkAnalyzerConfigurations


        /// <summary>
        /// Lists the network analyzer configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkAnalyzerConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListNetworkAnalyzerConfigurations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListNetworkAnalyzerConfigurations">REST API Reference for ListNetworkAnalyzerConfigurations Operation</seealso>
        ListNetworkAnalyzerConfigurationsResponse ListNetworkAnalyzerConfigurations(ListNetworkAnalyzerConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworkAnalyzerConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworkAnalyzerConfigurations operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworkAnalyzerConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListNetworkAnalyzerConfigurations">REST API Reference for ListNetworkAnalyzerConfigurations Operation</seealso>
        IAsyncResult BeginListNetworkAnalyzerConfigurations(ListNetworkAnalyzerConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworkAnalyzerConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworkAnalyzerConfigurations.</param>
        /// 
        /// <returns>Returns a  ListNetworkAnalyzerConfigurationsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListNetworkAnalyzerConfigurations">REST API Reference for ListNetworkAnalyzerConfigurations Operation</seealso>
        ListNetworkAnalyzerConfigurationsResponse EndListNetworkAnalyzerConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPartnerAccounts


        /// <summary>
        /// Lists the partner accounts associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerAccounts service method.</param>
        /// 
        /// <returns>The response from the ListPartnerAccounts service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        ListPartnerAccountsResponse ListPartnerAccounts(ListPartnerAccountsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPartnerAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPartnerAccounts operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPartnerAccounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        IAsyncResult BeginListPartnerAccounts(ListPartnerAccountsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPartnerAccounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPartnerAccounts.</param>
        /// 
        /// <returns>Returns a  ListPartnerAccountsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPartnerAccounts">REST API Reference for ListPartnerAccounts Operation</seealso>
        ListPartnerAccountsResponse EndListPartnerAccounts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListPositionConfigurations


        /// <summary>
        /// List position configurations for a given resource, such as positioning solvers.
        /// 
        ///  <important> 
        /// <para>
        /// This action is no longer supported. Calls to retrieve position information should
        /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_GetResourcePosition.html">GetResourcePosition</a>
        /// API operation instead.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPositionConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListPositionConfigurations service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPositionConfigurations">REST API Reference for ListPositionConfigurations Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        ListPositionConfigurationsResponse ListPositionConfigurations(ListPositionConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPositionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPositionConfigurations operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPositionConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPositionConfigurations">REST API Reference for ListPositionConfigurations Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        IAsyncResult BeginListPositionConfigurations(ListPositionConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPositionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPositionConfigurations.</param>
        /// 
        /// <returns>Returns a  ListPositionConfigurationsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListPositionConfigurations">REST API Reference for ListPositionConfigurations Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        ListPositionConfigurationsResponse EndListPositionConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListQueuedMessages


        /// <summary>
        /// List queued messages in the downlink queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueuedMessages service method.</param>
        /// 
        /// <returns>The response from the ListQueuedMessages service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListQueuedMessages">REST API Reference for ListQueuedMessages Operation</seealso>
        ListQueuedMessagesResponse ListQueuedMessages(ListQueuedMessagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueuedMessages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueuedMessages operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueuedMessages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListQueuedMessages">REST API Reference for ListQueuedMessages Operation</seealso>
        IAsyncResult BeginListQueuedMessages(ListQueuedMessagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListQueuedMessages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueuedMessages.</param>
        /// 
        /// <returns>Returns a  ListQueuedMessagesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListQueuedMessages">REST API Reference for ListQueuedMessages Operation</seealso>
        ListQueuedMessagesResponse EndListQueuedMessages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListServiceProfiles


        /// <summary>
        /// Lists the service profiles registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceProfiles service method.</param>
        /// 
        /// <returns>The response from the ListServiceProfiles service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        ListServiceProfilesResponse ListServiceProfiles(ListServiceProfilesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceProfiles operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceProfiles
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        IAsyncResult BeginListServiceProfiles(ListServiceProfilesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceProfiles operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceProfiles.</param>
        /// 
        /// <returns>Returns a  ListServiceProfilesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListServiceProfiles">REST API Reference for ListServiceProfiles Operation</seealso>
        ListServiceProfilesResponse EndListServiceProfiles(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags (metadata) you have assigned to the resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWirelessDeviceImportTasks


        /// <summary>
        /// List wireless devices that have been added to an import task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDeviceImportTasks service method.</param>
        /// 
        /// <returns>The response from the ListWirelessDeviceImportTasks service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDeviceImportTasks">REST API Reference for ListWirelessDeviceImportTasks Operation</seealso>
        ListWirelessDeviceImportTasksResponse ListWirelessDeviceImportTasks(ListWirelessDeviceImportTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessDeviceImportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDeviceImportTasks operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessDeviceImportTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDeviceImportTasks">REST API Reference for ListWirelessDeviceImportTasks Operation</seealso>
        IAsyncResult BeginListWirelessDeviceImportTasks(ListWirelessDeviceImportTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessDeviceImportTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessDeviceImportTasks.</param>
        /// 
        /// <returns>Returns a  ListWirelessDeviceImportTasksResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDeviceImportTasks">REST API Reference for ListWirelessDeviceImportTasks Operation</seealso>
        ListWirelessDeviceImportTasksResponse EndListWirelessDeviceImportTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWirelessDevices


        /// <summary>
        /// Lists the wireless devices registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDevices service method.</param>
        /// 
        /// <returns>The response from the ListWirelessDevices service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        ListWirelessDevicesResponse ListWirelessDevices(ListWirelessDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessDevices operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        IAsyncResult BeginListWirelessDevices(ListWirelessDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessDevices.</param>
        /// 
        /// <returns>Returns a  ListWirelessDevicesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessDevices">REST API Reference for ListWirelessDevices Operation</seealso>
        ListWirelessDevicesResponse EndListWirelessDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWirelessGateways


        /// <summary>
        /// Lists the wireless gateways registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGateways service method.</param>
        /// 
        /// <returns>The response from the ListWirelessGateways service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        ListWirelessGatewaysResponse ListWirelessGateways(ListWirelessGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGateways operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        IAsyncResult BeginListWirelessGateways(ListWirelessGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessGateways.</param>
        /// 
        /// <returns>Returns a  ListWirelessGatewaysResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGateways">REST API Reference for ListWirelessGateways Operation</seealso>
        ListWirelessGatewaysResponse EndListWirelessGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWirelessGatewayTaskDefinitions


        /// <summary>
        /// List the wireless gateway tasks definitions registered to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGatewayTaskDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListWirelessGatewayTaskDefinitions service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        ListWirelessGatewayTaskDefinitionsResponse ListWirelessGatewayTaskDefinitions(ListWirelessGatewayTaskDefinitionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWirelessGatewayTaskDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWirelessGatewayTaskDefinitions operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWirelessGatewayTaskDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        IAsyncResult BeginListWirelessGatewayTaskDefinitions(ListWirelessGatewayTaskDefinitionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWirelessGatewayTaskDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWirelessGatewayTaskDefinitions.</param>
        /// 
        /// <returns>Returns a  ListWirelessGatewayTaskDefinitionsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ListWirelessGatewayTaskDefinitions">REST API Reference for ListWirelessGatewayTaskDefinitions Operation</seealso>
        ListWirelessGatewayTaskDefinitionsResponse EndListWirelessGatewayTaskDefinitions(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPositionConfiguration


        /// <summary>
        /// Put position configuration for a given resource.
        /// 
        ///  <important> 
        /// <para>
        /// This action is no longer supported. Calls to update the position configuration should
        /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_UpdateResourcePosition.html">UpdateResourcePosition</a>
        /// API operation instead.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPositionConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutPositionConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutPositionConfiguration">REST API Reference for PutPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        PutPositionConfigurationResponse PutPositionConfiguration(PutPositionConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPositionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPositionConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPositionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutPositionConfiguration">REST API Reference for PutPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        IAsyncResult BeginPutPositionConfiguration(PutPositionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPositionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPositionConfiguration.</param>
        /// 
        /// <returns>Returns a  PutPositionConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutPositionConfiguration">REST API Reference for PutPositionConfiguration Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        PutPositionConfigurationResponse EndPutPositionConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourceLogLevel


        /// <summary>
        /// Sets the log-level override for a resource-ID and resource-type. This option can be
        /// specified for a wireless gateway or a wireless device. A limit of 200 log level override
        /// can be set per account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourceLogLevel service method.</param>
        /// 
        /// <returns>The response from the PutResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutResourceLogLevel">REST API Reference for PutResourceLogLevel Operation</seealso>
        PutResourceLogLevelResponse PutResourceLogLevel(PutResourceLogLevelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourceLogLevel operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourceLogLevel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutResourceLogLevel">REST API Reference for PutResourceLogLevel Operation</seealso>
        IAsyncResult BeginPutResourceLogLevel(PutResourceLogLevelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourceLogLevel.</param>
        /// 
        /// <returns>Returns a  PutResourceLogLevelResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/PutResourceLogLevel">REST API Reference for PutResourceLogLevel Operation</seealso>
        PutResourceLogLevelResponse EndPutResourceLogLevel(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetAllResourceLogLevels


        /// <summary>
        /// Removes the log-level overrides for all resources; both wireless devices and wireless
        /// gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetAllResourceLogLevels service method.</param>
        /// 
        /// <returns>The response from the ResetAllResourceLogLevels service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetAllResourceLogLevels">REST API Reference for ResetAllResourceLogLevels Operation</seealso>
        ResetAllResourceLogLevelsResponse ResetAllResourceLogLevels(ResetAllResourceLogLevelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetAllResourceLogLevels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetAllResourceLogLevels operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetAllResourceLogLevels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetAllResourceLogLevels">REST API Reference for ResetAllResourceLogLevels Operation</seealso>
        IAsyncResult BeginResetAllResourceLogLevels(ResetAllResourceLogLevelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetAllResourceLogLevels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetAllResourceLogLevels.</param>
        /// 
        /// <returns>Returns a  ResetAllResourceLogLevelsResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetAllResourceLogLevels">REST API Reference for ResetAllResourceLogLevels Operation</seealso>
        ResetAllResourceLogLevelsResponse EndResetAllResourceLogLevels(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetResourceLogLevel


        /// <summary>
        /// Removes the log-level override, if any, for a specific resource-ID and resource-type.
        /// It can be used for a wireless device or a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetResourceLogLevel service method.</param>
        /// 
        /// <returns>The response from the ResetResourceLogLevel service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetResourceLogLevel">REST API Reference for ResetResourceLogLevel Operation</seealso>
        ResetResourceLogLevelResponse ResetResourceLogLevel(ResetResourceLogLevelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetResourceLogLevel operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetResourceLogLevel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetResourceLogLevel">REST API Reference for ResetResourceLogLevel Operation</seealso>
        IAsyncResult BeginResetResourceLogLevel(ResetResourceLogLevelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetResourceLogLevel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetResourceLogLevel.</param>
        /// 
        /// <returns>Returns a  ResetResourceLogLevelResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/ResetResourceLogLevel">REST API Reference for ResetResourceLogLevel Operation</seealso>
        ResetResourceLogLevelResponse EndResetResourceLogLevel(IAsyncResult asyncResult);

        #endregion
        
        #region  SendDataToMulticastGroup


        /// <summary>
        /// Sends the specified data to a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the SendDataToMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToMulticastGroup">REST API Reference for SendDataToMulticastGroup Operation</seealso>
        SendDataToMulticastGroupResponse SendDataToMulticastGroup(SendDataToMulticastGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendDataToMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendDataToMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendDataToMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToMulticastGroup">REST API Reference for SendDataToMulticastGroup Operation</seealso>
        IAsyncResult BeginSendDataToMulticastGroup(SendDataToMulticastGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendDataToMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendDataToMulticastGroup.</param>
        /// 
        /// <returns>Returns a  SendDataToMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToMulticastGroup">REST API Reference for SendDataToMulticastGroup Operation</seealso>
        SendDataToMulticastGroupResponse EndSendDataToMulticastGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  SendDataToWirelessDevice


        /// <summary>
        /// Sends a decrypted application data frame to a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDataToWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the SendDataToWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        SendDataToWirelessDeviceResponse SendDataToWirelessDevice(SendDataToWirelessDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendDataToWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendDataToWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendDataToWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        IAsyncResult BeginSendDataToWirelessDevice(SendDataToWirelessDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendDataToWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendDataToWirelessDevice.</param>
        /// 
        /// <returns>Returns a  SendDataToWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/SendDataToWirelessDevice">REST API Reference for SendDataToWirelessDevice Operation</seealso>
        SendDataToWirelessDeviceResponse EndSendDataToWirelessDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  StartBulkAssociateWirelessDeviceWithMulticastGroup


        /// <summary>
        /// Starts a bulk association of all qualifying wireless devices with a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkAssociateWirelessDeviceWithMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the StartBulkAssociateWirelessDeviceWithMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkAssociateWirelessDeviceWithMulticastGroup">REST API Reference for StartBulkAssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        StartBulkAssociateWirelessDeviceWithMulticastGroupResponse StartBulkAssociateWirelessDeviceWithMulticastGroup(StartBulkAssociateWirelessDeviceWithMulticastGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartBulkAssociateWirelessDeviceWithMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBulkAssociateWirelessDeviceWithMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBulkAssociateWirelessDeviceWithMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkAssociateWirelessDeviceWithMulticastGroup">REST API Reference for StartBulkAssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        IAsyncResult BeginStartBulkAssociateWirelessDeviceWithMulticastGroup(StartBulkAssociateWirelessDeviceWithMulticastGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartBulkAssociateWirelessDeviceWithMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBulkAssociateWirelessDeviceWithMulticastGroup.</param>
        /// 
        /// <returns>Returns a  StartBulkAssociateWirelessDeviceWithMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkAssociateWirelessDeviceWithMulticastGroup">REST API Reference for StartBulkAssociateWirelessDeviceWithMulticastGroup Operation</seealso>
        StartBulkAssociateWirelessDeviceWithMulticastGroupResponse EndStartBulkAssociateWirelessDeviceWithMulticastGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  StartBulkDisassociateWirelessDeviceFromMulticastGroup


        /// <summary>
        /// Starts a bulk disassociatin of all qualifying wireless devices from a multicast group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBulkDisassociateWirelessDeviceFromMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the StartBulkDisassociateWirelessDeviceFromMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkDisassociateWirelessDeviceFromMulticastGroup">REST API Reference for StartBulkDisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse StartBulkDisassociateWirelessDeviceFromMulticastGroup(StartBulkDisassociateWirelessDeviceFromMulticastGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartBulkDisassociateWirelessDeviceFromMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartBulkDisassociateWirelessDeviceFromMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartBulkDisassociateWirelessDeviceFromMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkDisassociateWirelessDeviceFromMulticastGroup">REST API Reference for StartBulkDisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        IAsyncResult BeginStartBulkDisassociateWirelessDeviceFromMulticastGroup(StartBulkDisassociateWirelessDeviceFromMulticastGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartBulkDisassociateWirelessDeviceFromMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartBulkDisassociateWirelessDeviceFromMulticastGroup.</param>
        /// 
        /// <returns>Returns a  StartBulkDisassociateWirelessDeviceFromMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartBulkDisassociateWirelessDeviceFromMulticastGroup">REST API Reference for StartBulkDisassociateWirelessDeviceFromMulticastGroup Operation</seealso>
        StartBulkDisassociateWirelessDeviceFromMulticastGroupResponse EndStartBulkDisassociateWirelessDeviceFromMulticastGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  StartFuotaTask


        /// <summary>
        /// Starts a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFuotaTask service method.</param>
        /// 
        /// <returns>The response from the StartFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartFuotaTask">REST API Reference for StartFuotaTask Operation</seealso>
        StartFuotaTaskResponse StartFuotaTask(StartFuotaTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartFuotaTask">REST API Reference for StartFuotaTask Operation</seealso>
        IAsyncResult BeginStartFuotaTask(StartFuotaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFuotaTask.</param>
        /// 
        /// <returns>Returns a  StartFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartFuotaTask">REST API Reference for StartFuotaTask Operation</seealso>
        StartFuotaTaskResponse EndStartFuotaTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMulticastGroupSession


        /// <summary>
        /// Starts a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMulticastGroupSession service method.</param>
        /// 
        /// <returns>The response from the StartMulticastGroupSession service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartMulticastGroupSession">REST API Reference for StartMulticastGroupSession Operation</seealso>
        StartMulticastGroupSessionResponse StartMulticastGroupSession(StartMulticastGroupSessionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMulticastGroupSession operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMulticastGroupSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartMulticastGroupSession">REST API Reference for StartMulticastGroupSession Operation</seealso>
        IAsyncResult BeginStartMulticastGroupSession(StartMulticastGroupSessionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMulticastGroupSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMulticastGroupSession.</param>
        /// 
        /// <returns>Returns a  StartMulticastGroupSessionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartMulticastGroupSession">REST API Reference for StartMulticastGroupSession Operation</seealso>
        StartMulticastGroupSessionResponse EndStartMulticastGroupSession(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSingleWirelessDeviceImportTask


        /// <summary>
        /// Start import task for a single wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSingleWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the StartSingleWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartSingleWirelessDeviceImportTask">REST API Reference for StartSingleWirelessDeviceImportTask Operation</seealso>
        StartSingleWirelessDeviceImportTaskResponse StartSingleWirelessDeviceImportTask(StartSingleWirelessDeviceImportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSingleWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSingleWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSingleWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartSingleWirelessDeviceImportTask">REST API Reference for StartSingleWirelessDeviceImportTask Operation</seealso>
        IAsyncResult BeginStartSingleWirelessDeviceImportTask(StartSingleWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSingleWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSingleWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  StartSingleWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartSingleWirelessDeviceImportTask">REST API Reference for StartSingleWirelessDeviceImportTask Operation</seealso>
        StartSingleWirelessDeviceImportTaskResponse EndStartSingleWirelessDeviceImportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  StartWirelessDeviceImportTask


        /// <summary>
        /// Start import task for provisioning Sidewalk devices in bulk using an S3 CSV file.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the StartWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartWirelessDeviceImportTask">REST API Reference for StartWirelessDeviceImportTask Operation</seealso>
        StartWirelessDeviceImportTaskResponse StartWirelessDeviceImportTask(StartWirelessDeviceImportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartWirelessDeviceImportTask">REST API Reference for StartWirelessDeviceImportTask Operation</seealso>
        IAsyncResult BeginStartWirelessDeviceImportTask(StartWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  StartWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/StartWirelessDeviceImportTask">REST API Reference for StartWirelessDeviceImportTask Operation</seealso>
        StartWirelessDeviceImportTaskResponse EndStartWirelessDeviceImportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.TooManyTagsException">
        /// The request was denied because the resource can't have any more tags.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestWirelessDevice


        /// <summary>
        /// Simulates a provisioned device by sending an uplink data payload of <code>Hello</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the TestWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        TestWirelessDeviceResponse TestWirelessDevice(TestWirelessDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        IAsyncResult BeginTestWirelessDevice(TestWirelessDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestWirelessDevice.</param>
        /// 
        /// <returns>Returns a  TestWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/TestWirelessDevice">REST API Reference for TestWirelessDevice Operation</seealso>
        TestWirelessDeviceResponse EndTestWirelessDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateDestination


        /// <summary>
        /// Updates properties of a destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination service method.</param>
        /// 
        /// <returns>The response from the UpdateDestination service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        UpdateDestinationResponse UpdateDestination(UpdateDestinationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDestination operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        IAsyncResult BeginUpdateDestination(UpdateDestinationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDestination.</param>
        /// 
        /// <returns>Returns a  UpdateDestinationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateDestination">REST API Reference for UpdateDestination Operation</seealso>
        UpdateDestinationResponse EndUpdateDestination(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEventConfigurationByResourceTypes


        /// <summary>
        /// Update the event configuration based on resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurationByResourceTypes service method.</param>
        /// 
        /// <returns>The response from the UpdateEventConfigurationByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateEventConfigurationByResourceTypes">REST API Reference for UpdateEventConfigurationByResourceTypes Operation</seealso>
        UpdateEventConfigurationByResourceTypesResponse UpdateEventConfigurationByResourceTypes(UpdateEventConfigurationByResourceTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventConfigurationByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventConfigurationByResourceTypes operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventConfigurationByResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateEventConfigurationByResourceTypes">REST API Reference for UpdateEventConfigurationByResourceTypes Operation</seealso>
        IAsyncResult BeginUpdateEventConfigurationByResourceTypes(UpdateEventConfigurationByResourceTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventConfigurationByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventConfigurationByResourceTypes.</param>
        /// 
        /// <returns>Returns a  UpdateEventConfigurationByResourceTypesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateEventConfigurationByResourceTypes">REST API Reference for UpdateEventConfigurationByResourceTypes Operation</seealso>
        UpdateEventConfigurationByResourceTypesResponse EndUpdateEventConfigurationByResourceTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFuotaTask


        /// <summary>
        /// Updates properties of a FUOTA task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFuotaTask service method.</param>
        /// 
        /// <returns>The response from the UpdateFuotaTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateFuotaTask">REST API Reference for UpdateFuotaTask Operation</seealso>
        UpdateFuotaTaskResponse UpdateFuotaTask(UpdateFuotaTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFuotaTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFuotaTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateFuotaTask">REST API Reference for UpdateFuotaTask Operation</seealso>
        IAsyncResult BeginUpdateFuotaTask(UpdateFuotaTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFuotaTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFuotaTask.</param>
        /// 
        /// <returns>Returns a  UpdateFuotaTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateFuotaTask">REST API Reference for UpdateFuotaTask Operation</seealso>
        UpdateFuotaTaskResponse EndUpdateFuotaTask(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateLogLevelsByResourceTypes


        /// <summary>
        /// Set default log level, or log levels by resource types. This can be for wireless device
        /// log options or wireless gateways log options and is used to control the log messages
        /// that'll be displayed in CloudWatch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogLevelsByResourceTypes service method.</param>
        /// 
        /// <returns>The response from the UpdateLogLevelsByResourceTypes service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateLogLevelsByResourceTypes">REST API Reference for UpdateLogLevelsByResourceTypes Operation</seealso>
        UpdateLogLevelsByResourceTypesResponse UpdateLogLevelsByResourceTypes(UpdateLogLevelsByResourceTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLogLevelsByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogLevelsByResourceTypes operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLogLevelsByResourceTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateLogLevelsByResourceTypes">REST API Reference for UpdateLogLevelsByResourceTypes Operation</seealso>
        IAsyncResult BeginUpdateLogLevelsByResourceTypes(UpdateLogLevelsByResourceTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLogLevelsByResourceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLogLevelsByResourceTypes.</param>
        /// 
        /// <returns>Returns a  UpdateLogLevelsByResourceTypesResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateLogLevelsByResourceTypes">REST API Reference for UpdateLogLevelsByResourceTypes Operation</seealso>
        UpdateLogLevelsByResourceTypesResponse EndUpdateLogLevelsByResourceTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMulticastGroup


        /// <summary>
        /// Updates properties of a multicast group session.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMulticastGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateMulticastGroup service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateMulticastGroup">REST API Reference for UpdateMulticastGroup Operation</seealso>
        UpdateMulticastGroupResponse UpdateMulticastGroup(UpdateMulticastGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMulticastGroup operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMulticastGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateMulticastGroup">REST API Reference for UpdateMulticastGroup Operation</seealso>
        IAsyncResult BeginUpdateMulticastGroup(UpdateMulticastGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMulticastGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMulticastGroup.</param>
        /// 
        /// <returns>Returns a  UpdateMulticastGroupResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateMulticastGroup">REST API Reference for UpdateMulticastGroup Operation</seealso>
        UpdateMulticastGroupResponse EndUpdateMulticastGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNetworkAnalyzerConfiguration


        /// <summary>
        /// Update network analyzer configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkAnalyzerConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateNetworkAnalyzerConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateNetworkAnalyzerConfiguration">REST API Reference for UpdateNetworkAnalyzerConfiguration Operation</seealso>
        UpdateNetworkAnalyzerConfigurationResponse UpdateNetworkAnalyzerConfiguration(UpdateNetworkAnalyzerConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkAnalyzerConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkAnalyzerConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateNetworkAnalyzerConfiguration">REST API Reference for UpdateNetworkAnalyzerConfiguration Operation</seealso>
        IAsyncResult BeginUpdateNetworkAnalyzerConfiguration(UpdateNetworkAnalyzerConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkAnalyzerConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkAnalyzerConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkAnalyzerConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateNetworkAnalyzerConfiguration">REST API Reference for UpdateNetworkAnalyzerConfiguration Operation</seealso>
        UpdateNetworkAnalyzerConfigurationResponse EndUpdateNetworkAnalyzerConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePartnerAccount


        /// <summary>
        /// Updates properties of a partner account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerAccount service method.</param>
        /// 
        /// <returns>The response from the UpdatePartnerAccount service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        UpdatePartnerAccountResponse UpdatePartnerAccount(UpdatePartnerAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePartnerAccount operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePartnerAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        IAsyncResult BeginUpdatePartnerAccount(UpdatePartnerAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePartnerAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePartnerAccount.</param>
        /// 
        /// <returns>Returns a  UpdatePartnerAccountResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePartnerAccount">REST API Reference for UpdatePartnerAccount Operation</seealso>
        UpdatePartnerAccountResponse EndUpdatePartnerAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePosition


        /// <summary>
        /// Update the position information of a resource.
        /// 
        ///  <important> 
        /// <para>
        /// This action is no longer supported. Calls to update the position information should
        /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_UpdateResourcePosition.html">UpdateResourcePosition</a>
        /// API operation instead.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePosition service method.</param>
        /// 
        /// <returns>The response from the UpdatePosition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePosition">REST API Reference for UpdatePosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        UpdatePositionResponse UpdatePosition(UpdatePositionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePosition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePosition">REST API Reference for UpdatePosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        IAsyncResult BeginUpdatePosition(UpdatePositionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePosition.</param>
        /// 
        /// <returns>Returns a  UpdatePositionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdatePosition">REST API Reference for UpdatePosition Operation</seealso>
        [Obsolete("This operation is no longer supported.")]
        UpdatePositionResponse EndUpdatePosition(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResourceEventConfiguration


        /// <summary>
        /// Update the event configuration for a particular resource identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceEventConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateResourceEventConfiguration service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourceEventConfiguration">REST API Reference for UpdateResourceEventConfiguration Operation</seealso>
        UpdateResourceEventConfigurationResponse UpdateResourceEventConfiguration(UpdateResourceEventConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourceEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourceEventConfiguration operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourceEventConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourceEventConfiguration">REST API Reference for UpdateResourceEventConfiguration Operation</seealso>
        IAsyncResult BeginUpdateResourceEventConfiguration(UpdateResourceEventConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourceEventConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourceEventConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateResourceEventConfigurationResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourceEventConfiguration">REST API Reference for UpdateResourceEventConfiguration Operation</seealso>
        UpdateResourceEventConfigurationResponse EndUpdateResourceEventConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResourcePosition


        /// <summary>
        /// Update the position information of a given wireless device or a wireless gateway resource.
        /// The position coordinates are based on the <a href="https://gisgeography.com/wgs84-world-geodetic-system/">
        /// World Geodetic System (WGS84)</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourcePosition service method.</param>
        /// 
        /// <returns>The response from the UpdateResourcePosition service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourcePosition">REST API Reference for UpdateResourcePosition Operation</seealso>
        UpdateResourcePositionResponse UpdateResourcePosition(UpdateResourcePositionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResourcePosition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResourcePosition operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResourcePosition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourcePosition">REST API Reference for UpdateResourcePosition Operation</seealso>
        IAsyncResult BeginUpdateResourcePosition(UpdateResourcePositionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResourcePosition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResourcePosition.</param>
        /// 
        /// <returns>Returns a  UpdateResourcePositionResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateResourcePosition">REST API Reference for UpdateResourcePosition Operation</seealso>
        UpdateResourcePositionResponse EndUpdateResourcePosition(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWirelessDevice


        /// <summary>
        /// Updates properties of a wireless device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDevice service method.</param>
        /// 
        /// <returns>The response from the UpdateWirelessDevice service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        UpdateWirelessDeviceResponse UpdateWirelessDevice(UpdateWirelessDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDevice operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWirelessDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        IAsyncResult BeginUpdateWirelessDevice(UpdateWirelessDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWirelessDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWirelessDevice.</param>
        /// 
        /// <returns>Returns a  UpdateWirelessDeviceResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDevice">REST API Reference for UpdateWirelessDevice Operation</seealso>
        UpdateWirelessDeviceResponse EndUpdateWirelessDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWirelessDeviceImportTask


        /// <summary>
        /// Update an import task to add more devices to the task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDeviceImportTask service method.</param>
        /// 
        /// <returns>The response from the UpdateWirelessDeviceImportTask service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ConflictException">
        /// Adding, updating, or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDeviceImportTask">REST API Reference for UpdateWirelessDeviceImportTask Operation</seealso>
        UpdateWirelessDeviceImportTaskResponse UpdateWirelessDeviceImportTask(UpdateWirelessDeviceImportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessDeviceImportTask operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWirelessDeviceImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDeviceImportTask">REST API Reference for UpdateWirelessDeviceImportTask Operation</seealso>
        IAsyncResult BeginUpdateWirelessDeviceImportTask(UpdateWirelessDeviceImportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWirelessDeviceImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWirelessDeviceImportTask.</param>
        /// 
        /// <returns>Returns a  UpdateWirelessDeviceImportTaskResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessDeviceImportTask">REST API Reference for UpdateWirelessDeviceImportTask Operation</seealso>
        UpdateWirelessDeviceImportTaskResponse EndUpdateWirelessDeviceImportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWirelessGateway


        /// <summary>
        /// Updates properties of a wireless gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessGateway service method.</param>
        /// 
        /// <returns>The response from the UpdateWirelessGateway service method, as returned by IoTWireless.</returns>
        /// <exception cref="Amazon.IoTWireless.Model.AccessDeniedException">
        /// User does not have permission to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.InternalServerException">
        /// An unexpected error occurred while processing a request.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ResourceNotFoundException">
        /// Resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed API request rate.
        /// </exception>
        /// <exception cref="Amazon.IoTWireless.Model.ValidationException">
        /// The input did not meet the specified constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        UpdateWirelessGatewayResponse UpdateWirelessGateway(UpdateWirelessGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWirelessGateway operation on AmazonIoTWirelessClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWirelessGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        IAsyncResult BeginUpdateWirelessGateway(UpdateWirelessGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWirelessGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWirelessGateway.</param>
        /// 
        /// <returns>Returns a  UpdateWirelessGatewayResult from IoTWireless.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iotwireless-2020-11-22/UpdateWirelessGateway">REST API Reference for UpdateWirelessGateway Operation</seealso>
        UpdateWirelessGatewayResponse EndUpdateWirelessGateway(IAsyncResult asyncResult);

        #endregion
        
    }
}