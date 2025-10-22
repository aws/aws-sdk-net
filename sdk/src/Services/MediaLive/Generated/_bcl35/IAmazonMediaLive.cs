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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.MediaLive.Model;

#pragma warning disable CS1570
namespace Amazon.MediaLive
{
    /// <summary>
    /// <para>Interface for accessing MediaLive</para>
    ///
    /// API for AWS Elemental MediaLive
    /// </summary>
    public partial interface IAmazonMediaLive : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IMediaLivePaginatorFactory Paginators { get; }
#endif


        
        #region  AcceptInputDeviceTransfer


        /// <summary>
        /// Accept an incoming input device transfer. The ownership of the device will transfer
        /// to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInputDeviceTransfer service method.</param>
        /// 
        /// <returns>The response from the AcceptInputDeviceTransfer service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/AcceptInputDeviceTransfer">REST API Reference for AcceptInputDeviceTransfer Operation</seealso>
        AcceptInputDeviceTransferResponse AcceptInputDeviceTransfer(AcceptInputDeviceTransferRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptInputDeviceTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInputDeviceTransfer operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptInputDeviceTransfer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/AcceptInputDeviceTransfer">REST API Reference for AcceptInputDeviceTransfer Operation</seealso>
        IAsyncResult BeginAcceptInputDeviceTransfer(AcceptInputDeviceTransferRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptInputDeviceTransfer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptInputDeviceTransfer.</param>
        /// 
        /// <returns>Returns a  AcceptInputDeviceTransferResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/AcceptInputDeviceTransfer">REST API Reference for AcceptInputDeviceTransfer Operation</seealso>
        AcceptInputDeviceTransferResponse EndAcceptInputDeviceTransfer(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDelete


        /// <summary>
        /// Starts delete of resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDelete service method.</param>
        /// 
        /// <returns>The response from the BatchDelete service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchDelete">REST API Reference for BatchDelete Operation</seealso>
        BatchDeleteResponse BatchDelete(BatchDeleteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDelete operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDelete operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDelete
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchDelete">REST API Reference for BatchDelete Operation</seealso>
        IAsyncResult BeginBatchDelete(BatchDeleteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDelete operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDelete.</param>
        /// 
        /// <returns>Returns a  BatchDeleteResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchDelete">REST API Reference for BatchDelete Operation</seealso>
        BatchDeleteResponse EndBatchDelete(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchStart


        /// <summary>
        /// Starts existing resources
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStart service method.</param>
        /// 
        /// <returns>The response from the BatchStart service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchStart">REST API Reference for BatchStart Operation</seealso>
        BatchStartResponse BatchStart(BatchStartRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchStart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchStart operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchStart
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchStart">REST API Reference for BatchStart Operation</seealso>
        IAsyncResult BeginBatchStart(BatchStartRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchStart operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchStart.</param>
        /// 
        /// <returns>Returns a  BatchStartResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchStart">REST API Reference for BatchStart Operation</seealso>
        BatchStartResponse EndBatchStart(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchStop


        /// <summary>
        /// Stops running resources
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchStop service method.</param>
        /// 
        /// <returns>The response from the BatchStop service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchStop">REST API Reference for BatchStop Operation</seealso>
        BatchStopResponse BatchStop(BatchStopRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchStop operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchStop operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchStop
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchStop">REST API Reference for BatchStop Operation</seealso>
        IAsyncResult BeginBatchStop(BatchStopRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchStop operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchStop.</param>
        /// 
        /// <returns>Returns a  BatchStopResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchStop">REST API Reference for BatchStop Operation</seealso>
        BatchStopResponse EndBatchStop(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchUpdateSchedule


        /// <summary>
        /// Update a channel schedule
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateSchedule service method.</param>
        /// 
        /// <returns>The response from the BatchUpdateSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchUpdateSchedule">REST API Reference for BatchUpdateSchedule Operation</seealso>
        BatchUpdateScheduleResponse BatchUpdateSchedule(BatchUpdateScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchUpdateSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchUpdateSchedule operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchUpdateSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchUpdateSchedule">REST API Reference for BatchUpdateSchedule Operation</seealso>
        IAsyncResult BeginBatchUpdateSchedule(BatchUpdateScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchUpdateSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchUpdateSchedule.</param>
        /// 
        /// <returns>Returns a  BatchUpdateScheduleResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/BatchUpdateSchedule">REST API Reference for BatchUpdateSchedule Operation</seealso>
        BatchUpdateScheduleResponse EndBatchUpdateSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelInputDeviceTransfer


        /// <summary>
        /// Cancel an input device transfer that you have requested.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelInputDeviceTransfer service method.</param>
        /// 
        /// <returns>The response from the CancelInputDeviceTransfer service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CancelInputDeviceTransfer">REST API Reference for CancelInputDeviceTransfer Operation</seealso>
        CancelInputDeviceTransferResponse CancelInputDeviceTransfer(CancelInputDeviceTransferRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelInputDeviceTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelInputDeviceTransfer operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelInputDeviceTransfer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CancelInputDeviceTransfer">REST API Reference for CancelInputDeviceTransfer Operation</seealso>
        IAsyncResult BeginCancelInputDeviceTransfer(CancelInputDeviceTransferRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelInputDeviceTransfer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelInputDeviceTransfer.</param>
        /// 
        /// <returns>Returns a  CancelInputDeviceTransferResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CancelInputDeviceTransfer">REST API Reference for CancelInputDeviceTransfer Operation</seealso>
        CancelInputDeviceTransferResponse EndCancelInputDeviceTransfer(IAsyncResult asyncResult);

        #endregion
        
        #region  ClaimDevice


        /// <summary>
        /// Send a request to claim an AWS Elemental device that you have purchased from a third-party
        /// vendor. After the request succeeds, you will own the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClaimDevice service method.</param>
        /// 
        /// <returns>The response from the ClaimDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ClaimDevice">REST API Reference for ClaimDevice Operation</seealso>
        ClaimDeviceResponse ClaimDevice(ClaimDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ClaimDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ClaimDevice operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndClaimDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ClaimDevice">REST API Reference for ClaimDevice Operation</seealso>
        IAsyncResult BeginClaimDevice(ClaimDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ClaimDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginClaimDevice.</param>
        /// 
        /// <returns>Returns a  ClaimDeviceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ClaimDevice">REST API Reference for ClaimDevice Operation</seealso>
        ClaimDeviceResponse EndClaimDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChannel


        /// <summary>
        /// Creates a new channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel service method.</param>
        /// 
        /// <returns>The response from the CreateChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse CreateChannel(CreateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        IAsyncResult BeginCreateChannel(CreateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannel.</param>
        /// 
        /// <returns>Returns a  CreateChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannel">REST API Reference for CreateChannel Operation</seealso>
        CreateChannelResponse EndCreateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateChannelPlacementGroup


        /// <summary>
        /// Create a ChannelPlacementGroup in the specified Cluster. As part of the create operation,
        /// you specify the Nodes to attach the group to.After you create a ChannelPlacementGroup,
        /// you add Channels to the group (you do this by modifying the Channels to add them to
        /// a specific group). You now have an association of Channels to ChannelPlacementGroup,
        /// and ChannelPlacementGroup to Nodes. This association means that all the Channels in
        /// the group are able to run on any of the Nodes associated with the group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelPlacementGroup service method.</param>
        /// 
        /// <returns>The response from the CreateChannelPlacementGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannelPlacementGroup">REST API Reference for CreateChannelPlacementGroup Operation</seealso>
        CreateChannelPlacementGroupResponse CreateChannelPlacementGroup(CreateChannelPlacementGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateChannelPlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateChannelPlacementGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateChannelPlacementGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannelPlacementGroup">REST API Reference for CreateChannelPlacementGroup Operation</seealso>
        IAsyncResult BeginCreateChannelPlacementGroup(CreateChannelPlacementGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateChannelPlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateChannelPlacementGroup.</param>
        /// 
        /// <returns>Returns a  CreateChannelPlacementGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateChannelPlacementGroup">REST API Reference for CreateChannelPlacementGroup Operation</seealso>
        CreateChannelPlacementGroupResponse EndCreateChannelPlacementGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCloudWatchAlarmTemplate


        /// <summary>
        /// Creates a cloudwatch alarm template to dynamically generate cloudwatch metric alarms
        /// on targeted resource types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudWatchAlarmTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateCloudWatchAlarmTemplate service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateCloudWatchAlarmTemplate">REST API Reference for CreateCloudWatchAlarmTemplate Operation</seealso>
        CreateCloudWatchAlarmTemplateResponse CreateCloudWatchAlarmTemplate(CreateCloudWatchAlarmTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudWatchAlarmTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudWatchAlarmTemplate operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudWatchAlarmTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateCloudWatchAlarmTemplate">REST API Reference for CreateCloudWatchAlarmTemplate Operation</seealso>
        IAsyncResult BeginCreateCloudWatchAlarmTemplate(CreateCloudWatchAlarmTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudWatchAlarmTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudWatchAlarmTemplate.</param>
        /// 
        /// <returns>Returns a  CreateCloudWatchAlarmTemplateResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateCloudWatchAlarmTemplate">REST API Reference for CreateCloudWatchAlarmTemplate Operation</seealso>
        CreateCloudWatchAlarmTemplateResponse EndCreateCloudWatchAlarmTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCloudWatchAlarmTemplateGroup


        /// <summary>
        /// Creates a cloudwatch alarm template group to group your cloudwatch alarm templates
        /// and to attach to signal maps for dynamically creating alarms.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudWatchAlarmTemplateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateCloudWatchAlarmTemplateGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateCloudWatchAlarmTemplateGroup">REST API Reference for CreateCloudWatchAlarmTemplateGroup Operation</seealso>
        CreateCloudWatchAlarmTemplateGroupResponse CreateCloudWatchAlarmTemplateGroup(CreateCloudWatchAlarmTemplateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCloudWatchAlarmTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCloudWatchAlarmTemplateGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCloudWatchAlarmTemplateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateCloudWatchAlarmTemplateGroup">REST API Reference for CreateCloudWatchAlarmTemplateGroup Operation</seealso>
        IAsyncResult BeginCreateCloudWatchAlarmTemplateGroup(CreateCloudWatchAlarmTemplateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCloudWatchAlarmTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCloudWatchAlarmTemplateGroup.</param>
        /// 
        /// <returns>Returns a  CreateCloudWatchAlarmTemplateGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateCloudWatchAlarmTemplateGroup">REST API Reference for CreateCloudWatchAlarmTemplateGroup Operation</seealso>
        CreateCloudWatchAlarmTemplateGroupResponse EndCreateCloudWatchAlarmTemplateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCluster


        /// <summary>
        /// Create a new Cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEventBridgeRuleTemplate


        /// <summary>
        /// Creates an eventbridge rule template to monitor events and send notifications to your
        /// targeted resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventBridgeRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateEventBridgeRuleTemplate service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateEventBridgeRuleTemplate">REST API Reference for CreateEventBridgeRuleTemplate Operation</seealso>
        CreateEventBridgeRuleTemplateResponse CreateEventBridgeRuleTemplate(CreateEventBridgeRuleTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventBridgeRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventBridgeRuleTemplate operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventBridgeRuleTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateEventBridgeRuleTemplate">REST API Reference for CreateEventBridgeRuleTemplate Operation</seealso>
        IAsyncResult BeginCreateEventBridgeRuleTemplate(CreateEventBridgeRuleTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventBridgeRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventBridgeRuleTemplate.</param>
        /// 
        /// <returns>Returns a  CreateEventBridgeRuleTemplateResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateEventBridgeRuleTemplate">REST API Reference for CreateEventBridgeRuleTemplate Operation</seealso>
        CreateEventBridgeRuleTemplateResponse EndCreateEventBridgeRuleTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEventBridgeRuleTemplateGroup


        /// <summary>
        /// Creates an eventbridge rule template group to group your eventbridge rule templates
        /// and to attach to signal maps for dynamically creating notification rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventBridgeRuleTemplateGroup service method.</param>
        /// 
        /// <returns>The response from the CreateEventBridgeRuleTemplateGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateEventBridgeRuleTemplateGroup">REST API Reference for CreateEventBridgeRuleTemplateGroup Operation</seealso>
        CreateEventBridgeRuleTemplateGroupResponse CreateEventBridgeRuleTemplateGroup(CreateEventBridgeRuleTemplateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventBridgeRuleTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventBridgeRuleTemplateGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEventBridgeRuleTemplateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateEventBridgeRuleTemplateGroup">REST API Reference for CreateEventBridgeRuleTemplateGroup Operation</seealso>
        IAsyncResult BeginCreateEventBridgeRuleTemplateGroup(CreateEventBridgeRuleTemplateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEventBridgeRuleTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEventBridgeRuleTemplateGroup.</param>
        /// 
        /// <returns>Returns a  CreateEventBridgeRuleTemplateGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateEventBridgeRuleTemplateGroup">REST API Reference for CreateEventBridgeRuleTemplateGroup Operation</seealso>
        CreateEventBridgeRuleTemplateGroupResponse EndCreateEventBridgeRuleTemplateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInput


        /// <summary>
        /// Create an input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInput service method.</param>
        /// 
        /// <returns>The response from the CreateInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInput">REST API Reference for CreateInput Operation</seealso>
        CreateInputResponse CreateInput(CreateInputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInput operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInput">REST API Reference for CreateInput Operation</seealso>
        IAsyncResult BeginCreateInput(CreateInputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInput.</param>
        /// 
        /// <returns>Returns a  CreateInputResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInput">REST API Reference for CreateInput Operation</seealso>
        CreateInputResponse EndCreateInput(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInputSecurityGroup


        /// <summary>
        /// Creates a Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInputSecurityGroup">REST API Reference for CreateInputSecurityGroup Operation</seealso>
        CreateInputSecurityGroupResponse CreateInputSecurityGroup(CreateInputSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInputSecurityGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInputSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInputSecurityGroup">REST API Reference for CreateInputSecurityGroup Operation</seealso>
        IAsyncResult BeginCreateInputSecurityGroup(CreateInputSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInputSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateInputSecurityGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateInputSecurityGroup">REST API Reference for CreateInputSecurityGroup Operation</seealso>
        CreateInputSecurityGroupResponse EndCreateInputSecurityGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMultiplex


        /// <summary>
        /// Create a new multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiplex service method.</param>
        /// 
        /// <returns>The response from the CreateMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateMultiplex">REST API Reference for CreateMultiplex Operation</seealso>
        CreateMultiplexResponse CreateMultiplex(CreateMultiplexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMultiplex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiplex operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMultiplex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateMultiplex">REST API Reference for CreateMultiplex Operation</seealso>
        IAsyncResult BeginCreateMultiplex(CreateMultiplexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMultiplex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMultiplex.</param>
        /// 
        /// <returns>Returns a  CreateMultiplexResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateMultiplex">REST API Reference for CreateMultiplex Operation</seealso>
        CreateMultiplexResponse EndCreateMultiplex(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMultiplexProgram


        /// <summary>
        /// Create a new program in the multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiplexProgram service method.</param>
        /// 
        /// <returns>The response from the CreateMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateMultiplexProgram">REST API Reference for CreateMultiplexProgram Operation</seealso>
        CreateMultiplexProgramResponse CreateMultiplexProgram(CreateMultiplexProgramRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMultiplexProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMultiplexProgram operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMultiplexProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateMultiplexProgram">REST API Reference for CreateMultiplexProgram Operation</seealso>
        IAsyncResult BeginCreateMultiplexProgram(CreateMultiplexProgramRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMultiplexProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMultiplexProgram.</param>
        /// 
        /// <returns>Returns a  CreateMultiplexProgramResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateMultiplexProgram">REST API Reference for CreateMultiplexProgram Operation</seealso>
        CreateMultiplexProgramResponse EndCreateMultiplexProgram(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNetwork


        /// <summary>
        /// Create as many Networks as you need. You will associate one or more Clusters with
        /// each Network.Each Network provides MediaLive Anywhere with required information about
        /// the network in your organization that you are using for video encoding using MediaLive.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork service method.</param>
        /// 
        /// <returns>The response from the CreateNetwork service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        CreateNetworkResponse CreateNetwork(CreateNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetwork operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        IAsyncResult BeginCreateNetwork(CreateNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetwork.</param>
        /// 
        /// <returns>Returns a  CreateNetworkResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateNetwork">REST API Reference for CreateNetwork Operation</seealso>
        CreateNetworkResponse EndCreateNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNode


        /// <summary>
        /// Create a Node in the specified Cluster. You can also create Nodes using the CreateNodeRegistrationScript.
        /// Note that you can't move a Node to another Cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNode service method.</param>
        /// 
        /// <returns>The response from the CreateNode service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateNode">REST API Reference for CreateNode Operation</seealso>
        CreateNodeResponse CreateNode(CreateNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNode operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateNode">REST API Reference for CreateNode Operation</seealso>
        IAsyncResult BeginCreateNode(CreateNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNode.</param>
        /// 
        /// <returns>Returns a  CreateNodeResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateNode">REST API Reference for CreateNode Operation</seealso>
        CreateNodeResponse EndCreateNode(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNodeRegistrationScript


        /// <summary>
        /// Create the Register Node script for all the nodes intended for a specific Cluster.
        /// You will then run the script on each hardware unit that is intended for that Cluster.
        /// The script creates a Node in the specified Cluster. It then binds the Node to this
        /// hardware unit, and activates the node hardware for use with MediaLive Anywhere.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNodeRegistrationScript service method.</param>
        /// 
        /// <returns>The response from the CreateNodeRegistrationScript service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateNodeRegistrationScript">REST API Reference for CreateNodeRegistrationScript Operation</seealso>
        CreateNodeRegistrationScriptResponse CreateNodeRegistrationScript(CreateNodeRegistrationScriptRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNodeRegistrationScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNodeRegistrationScript operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNodeRegistrationScript
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateNodeRegistrationScript">REST API Reference for CreateNodeRegistrationScript Operation</seealso>
        IAsyncResult BeginCreateNodeRegistrationScript(CreateNodeRegistrationScriptRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNodeRegistrationScript operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNodeRegistrationScript.</param>
        /// 
        /// <returns>Returns a  CreateNodeRegistrationScriptResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateNodeRegistrationScript">REST API Reference for CreateNodeRegistrationScript Operation</seealso>
        CreateNodeRegistrationScriptResponse EndCreateNodeRegistrationScript(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePartnerInput


        /// <summary>
        /// Create a partner input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnerInput service method.</param>
        /// 
        /// <returns>The response from the CreatePartnerInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreatePartnerInput">REST API Reference for CreatePartnerInput Operation</seealso>
        CreatePartnerInputResponse CreatePartnerInput(CreatePartnerInputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePartnerInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePartnerInput operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePartnerInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreatePartnerInput">REST API Reference for CreatePartnerInput Operation</seealso>
        IAsyncResult BeginCreatePartnerInput(CreatePartnerInputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePartnerInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePartnerInput.</param>
        /// 
        /// <returns>Returns a  CreatePartnerInputResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreatePartnerInput">REST API Reference for CreatePartnerInput Operation</seealso>
        CreatePartnerInputResponse EndCreatePartnerInput(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSdiSource


        /// <summary>
        /// Create an SdiSource for each video source that uses the SDI protocol. You will reference
        /// the SdiSource when you create an SDI input in MediaLive. You will also reference it
        /// in an SdiSourceMapping, in order to create a connection between the logical SdiSource
        /// and the physical SDI card and port that the physical SDI source uses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSdiSource service method.</param>
        /// 
        /// <returns>The response from the CreateSdiSource service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateSdiSource">REST API Reference for CreateSdiSource Operation</seealso>
        CreateSdiSourceResponse CreateSdiSource(CreateSdiSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSdiSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSdiSource operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSdiSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateSdiSource">REST API Reference for CreateSdiSource Operation</seealso>
        IAsyncResult BeginCreateSdiSource(CreateSdiSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSdiSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSdiSource.</param>
        /// 
        /// <returns>Returns a  CreateSdiSourceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateSdiSource">REST API Reference for CreateSdiSource Operation</seealso>
        CreateSdiSourceResponse EndCreateSdiSource(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSignalMap


        /// <summary>
        /// Initiates the creation of a new signal map. Will discover a new mediaResourceMap based
        /// on the provided discoveryEntryPointArn.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalMap service method.</param>
        /// 
        /// <returns>The response from the CreateSignalMap service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateSignalMap">REST API Reference for CreateSignalMap Operation</seealso>
        CreateSignalMapResponse CreateSignalMap(CreateSignalMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSignalMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSignalMap operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSignalMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateSignalMap">REST API Reference for CreateSignalMap Operation</seealso>
        IAsyncResult BeginCreateSignalMap(CreateSignalMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSignalMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSignalMap.</param>
        /// 
        /// <returns>Returns a  CreateSignalMapResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateSignalMap">REST API Reference for CreateSignalMap Operation</seealso>
        CreateSignalMapResponse EndCreateSignalMap(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Create tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateTags">REST API Reference for CreateTags Operation</seealso>
        CreateTagsResponse CreateTags(CreateTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateTags">REST API Reference for CreateTags Operation</seealso>
        IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/CreateTags">REST API Reference for CreateTags Operation</seealso>
        CreateTagsResponse EndCreateTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChannel


        /// <summary>
        /// Starts deletion of channel. The associated outputs are also deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse DeleteChannel(DeleteChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        IAsyncResult BeginDeleteChannel(DeleteChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannel.</param>
        /// 
        /// <returns>Returns a  DeleteChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannel">REST API Reference for DeleteChannel Operation</seealso>
        DeleteChannelResponse EndDeleteChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteChannelPlacementGroup


        /// <summary>
        /// Delete the specified ChannelPlacementGroup that exists in the specified Cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPlacementGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteChannelPlacementGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannelPlacementGroup">REST API Reference for DeleteChannelPlacementGroup Operation</seealso>
        DeleteChannelPlacementGroupResponse DeleteChannelPlacementGroup(DeleteChannelPlacementGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteChannelPlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteChannelPlacementGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteChannelPlacementGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannelPlacementGroup">REST API Reference for DeleteChannelPlacementGroup Operation</seealso>
        IAsyncResult BeginDeleteChannelPlacementGroup(DeleteChannelPlacementGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteChannelPlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteChannelPlacementGroup.</param>
        /// 
        /// <returns>Returns a  DeleteChannelPlacementGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteChannelPlacementGroup">REST API Reference for DeleteChannelPlacementGroup Operation</seealso>
        DeleteChannelPlacementGroupResponse EndDeleteChannelPlacementGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCloudWatchAlarmTemplate


        /// <summary>
        /// Deletes a cloudwatch alarm template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudWatchAlarmTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudWatchAlarmTemplate service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteCloudWatchAlarmTemplate">REST API Reference for DeleteCloudWatchAlarmTemplate Operation</seealso>
        DeleteCloudWatchAlarmTemplateResponse DeleteCloudWatchAlarmTemplate(DeleteCloudWatchAlarmTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudWatchAlarmTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudWatchAlarmTemplate operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudWatchAlarmTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteCloudWatchAlarmTemplate">REST API Reference for DeleteCloudWatchAlarmTemplate Operation</seealso>
        IAsyncResult BeginDeleteCloudWatchAlarmTemplate(DeleteCloudWatchAlarmTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudWatchAlarmTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudWatchAlarmTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteCloudWatchAlarmTemplateResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteCloudWatchAlarmTemplate">REST API Reference for DeleteCloudWatchAlarmTemplate Operation</seealso>
        DeleteCloudWatchAlarmTemplateResponse EndDeleteCloudWatchAlarmTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCloudWatchAlarmTemplateGroup


        /// <summary>
        /// Deletes a cloudwatch alarm template group. You must detach this group from all signal
        /// maps and ensure its existing templates are moved to another group or deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudWatchAlarmTemplateGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteCloudWatchAlarmTemplateGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteCloudWatchAlarmTemplateGroup">REST API Reference for DeleteCloudWatchAlarmTemplateGroup Operation</seealso>
        DeleteCloudWatchAlarmTemplateGroupResponse DeleteCloudWatchAlarmTemplateGroup(DeleteCloudWatchAlarmTemplateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCloudWatchAlarmTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCloudWatchAlarmTemplateGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCloudWatchAlarmTemplateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteCloudWatchAlarmTemplateGroup">REST API Reference for DeleteCloudWatchAlarmTemplateGroup Operation</seealso>
        IAsyncResult BeginDeleteCloudWatchAlarmTemplateGroup(DeleteCloudWatchAlarmTemplateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCloudWatchAlarmTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCloudWatchAlarmTemplateGroup.</param>
        /// 
        /// <returns>Returns a  DeleteCloudWatchAlarmTemplateGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteCloudWatchAlarmTemplateGroup">REST API Reference for DeleteCloudWatchAlarmTemplateGroup Operation</seealso>
        DeleteCloudWatchAlarmTemplateGroupResponse EndDeleteCloudWatchAlarmTemplateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Delete a Cluster. The Cluster must be idle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventBridgeRuleTemplate


        /// <summary>
        /// Deletes an eventbridge rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventBridgeRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteEventBridgeRuleTemplate service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteEventBridgeRuleTemplate">REST API Reference for DeleteEventBridgeRuleTemplate Operation</seealso>
        DeleteEventBridgeRuleTemplateResponse DeleteEventBridgeRuleTemplate(DeleteEventBridgeRuleTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventBridgeRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventBridgeRuleTemplate operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventBridgeRuleTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteEventBridgeRuleTemplate">REST API Reference for DeleteEventBridgeRuleTemplate Operation</seealso>
        IAsyncResult BeginDeleteEventBridgeRuleTemplate(DeleteEventBridgeRuleTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventBridgeRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventBridgeRuleTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteEventBridgeRuleTemplateResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteEventBridgeRuleTemplate">REST API Reference for DeleteEventBridgeRuleTemplate Operation</seealso>
        DeleteEventBridgeRuleTemplateResponse EndDeleteEventBridgeRuleTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEventBridgeRuleTemplateGroup


        /// <summary>
        /// Deletes an eventbridge rule template group. You must detach this group from all signal
        /// maps and ensure its existing templates are moved to another group or deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventBridgeRuleTemplateGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteEventBridgeRuleTemplateGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteEventBridgeRuleTemplateGroup">REST API Reference for DeleteEventBridgeRuleTemplateGroup Operation</seealso>
        DeleteEventBridgeRuleTemplateGroupResponse DeleteEventBridgeRuleTemplateGroup(DeleteEventBridgeRuleTemplateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventBridgeRuleTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventBridgeRuleTemplateGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEventBridgeRuleTemplateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteEventBridgeRuleTemplateGroup">REST API Reference for DeleteEventBridgeRuleTemplateGroup Operation</seealso>
        IAsyncResult BeginDeleteEventBridgeRuleTemplateGroup(DeleteEventBridgeRuleTemplateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEventBridgeRuleTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEventBridgeRuleTemplateGroup.</param>
        /// 
        /// <returns>Returns a  DeleteEventBridgeRuleTemplateGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteEventBridgeRuleTemplateGroup">REST API Reference for DeleteEventBridgeRuleTemplateGroup Operation</seealso>
        DeleteEventBridgeRuleTemplateGroupResponse EndDeleteEventBridgeRuleTemplateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInput


        /// <summary>
        /// Deletes the input end point
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput service method.</param>
        /// 
        /// <returns>The response from the DeleteInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        DeleteInputResponse DeleteInput(DeleteInputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInput operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        IAsyncResult BeginDeleteInput(DeleteInputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInput.</param>
        /// 
        /// <returns>Returns a  DeleteInputResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInput">REST API Reference for DeleteInput Operation</seealso>
        DeleteInputResponse EndDeleteInput(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInputSecurityGroup


        /// <summary>
        /// Deletes an Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInputSecurityGroup">REST API Reference for DeleteInputSecurityGroup Operation</seealso>
        DeleteInputSecurityGroupResponse DeleteInputSecurityGroup(DeleteInputSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInputSecurityGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInputSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInputSecurityGroup">REST API Reference for DeleteInputSecurityGroup Operation</seealso>
        IAsyncResult BeginDeleteInputSecurityGroup(DeleteInputSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInputSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteInputSecurityGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteInputSecurityGroup">REST API Reference for DeleteInputSecurityGroup Operation</seealso>
        DeleteInputSecurityGroupResponse EndDeleteInputSecurityGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMultiplex


        /// <summary>
        /// Delete a multiplex. The multiplex must be idle.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiplex service method.</param>
        /// 
        /// <returns>The response from the DeleteMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteMultiplex">REST API Reference for DeleteMultiplex Operation</seealso>
        DeleteMultiplexResponse DeleteMultiplex(DeleteMultiplexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMultiplex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiplex operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMultiplex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteMultiplex">REST API Reference for DeleteMultiplex Operation</seealso>
        IAsyncResult BeginDeleteMultiplex(DeleteMultiplexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMultiplex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMultiplex.</param>
        /// 
        /// <returns>Returns a  DeleteMultiplexResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteMultiplex">REST API Reference for DeleteMultiplex Operation</seealso>
        DeleteMultiplexResponse EndDeleteMultiplex(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMultiplexProgram


        /// <summary>
        /// Delete a program from a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiplexProgram service method.</param>
        /// 
        /// <returns>The response from the DeleteMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteMultiplexProgram">REST API Reference for DeleteMultiplexProgram Operation</seealso>
        DeleteMultiplexProgramResponse DeleteMultiplexProgram(DeleteMultiplexProgramRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMultiplexProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMultiplexProgram operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMultiplexProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteMultiplexProgram">REST API Reference for DeleteMultiplexProgram Operation</seealso>
        IAsyncResult BeginDeleteMultiplexProgram(DeleteMultiplexProgramRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMultiplexProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMultiplexProgram.</param>
        /// 
        /// <returns>Returns a  DeleteMultiplexProgramResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteMultiplexProgram">REST API Reference for DeleteMultiplexProgram Operation</seealso>
        DeleteMultiplexProgramResponse EndDeleteMultiplexProgram(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetwork


        /// <summary>
        /// Delete a Network. The Network must have no resources associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork service method.</param>
        /// 
        /// <returns>The response from the DeleteNetwork service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        DeleteNetworkResponse DeleteNetwork(DeleteNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetwork operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        IAsyncResult BeginDeleteNetwork(DeleteNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetwork.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteNetwork">REST API Reference for DeleteNetwork Operation</seealso>
        DeleteNetworkResponse EndDeleteNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNode


        /// <summary>
        /// Delete a Node. The Node must be IDLE.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNode service method.</param>
        /// 
        /// <returns>The response from the DeleteNode service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteNode">REST API Reference for DeleteNode Operation</seealso>
        DeleteNodeResponse DeleteNode(DeleteNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNode operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteNode">REST API Reference for DeleteNode Operation</seealso>
        IAsyncResult BeginDeleteNode(DeleteNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNode.</param>
        /// 
        /// <returns>Returns a  DeleteNodeResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteNode">REST API Reference for DeleteNode Operation</seealso>
        DeleteNodeResponse EndDeleteNode(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteReservation


        /// <summary>
        /// Delete an expired reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteReservation service method.</param>
        /// 
        /// <returns>The response from the DeleteReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteReservation">REST API Reference for DeleteReservation Operation</seealso>
        DeleteReservationResponse DeleteReservation(DeleteReservationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReservation operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteReservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteReservation">REST API Reference for DeleteReservation Operation</seealso>
        IAsyncResult BeginDeleteReservation(DeleteReservationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteReservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteReservation.</param>
        /// 
        /// <returns>Returns a  DeleteReservationResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteReservation">REST API Reference for DeleteReservation Operation</seealso>
        DeleteReservationResponse EndDeleteReservation(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSchedule


        /// <summary>
        /// Delete all schedule actions on a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        DeleteScheduleResponse DeleteSchedule(DeleteScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        IAsyncResult BeginDeleteSchedule(DeleteScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchedule.</param>
        /// 
        /// <returns>Returns a  DeleteScheduleResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        DeleteScheduleResponse EndDeleteSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSdiSource


        /// <summary>
        /// Delete an SdiSource. The SdiSource must not be part of any SidSourceMapping and must
        /// not be attached to any input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSdiSource service method.</param>
        /// 
        /// <returns>The response from the DeleteSdiSource service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSdiSource">REST API Reference for DeleteSdiSource Operation</seealso>
        DeleteSdiSourceResponse DeleteSdiSource(DeleteSdiSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSdiSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSdiSource operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSdiSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSdiSource">REST API Reference for DeleteSdiSource Operation</seealso>
        IAsyncResult BeginDeleteSdiSource(DeleteSdiSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSdiSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSdiSource.</param>
        /// 
        /// <returns>Returns a  DeleteSdiSourceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSdiSource">REST API Reference for DeleteSdiSource Operation</seealso>
        DeleteSdiSourceResponse EndDeleteSdiSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSignalMap


        /// <summary>
        /// Deletes the specified signal map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalMap service method.</param>
        /// 
        /// <returns>The response from the DeleteSignalMap service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSignalMap">REST API Reference for DeleteSignalMap Operation</seealso>
        DeleteSignalMapResponse DeleteSignalMap(DeleteSignalMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSignalMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSignalMap operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSignalMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSignalMap">REST API Reference for DeleteSignalMap Operation</seealso>
        IAsyncResult BeginDeleteSignalMap(DeleteSignalMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSignalMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSignalMap.</param>
        /// 
        /// <returns>Returns a  DeleteSignalMapResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteSignalMap">REST API Reference for DeleteSignalMap Operation</seealso>
        DeleteSignalMapResponse EndDeleteSignalMap(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Removes tags for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountConfiguration


        /// <summary>
        /// Describe account configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountConfiguration service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeAccountConfiguration">REST API Reference for DescribeAccountConfiguration Operation</seealso>
        DescribeAccountConfigurationResponse DescribeAccountConfiguration(DescribeAccountConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountConfiguration operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeAccountConfiguration">REST API Reference for DescribeAccountConfiguration Operation</seealso>
        IAsyncResult BeginDescribeAccountConfiguration(DescribeAccountConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeAccountConfigurationResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeAccountConfiguration">REST API Reference for DescribeAccountConfiguration Operation</seealso>
        DescribeAccountConfigurationResponse EndDescribeAccountConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeChannel


        /// <summary>
        /// Gets details about a channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel service method.</param>
        /// 
        /// <returns>The response from the DescribeChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        DescribeChannelResponse DescribeChannel(DescribeChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        IAsyncResult BeginDescribeChannel(DescribeChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannel.</param>
        /// 
        /// <returns>Returns a  DescribeChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannel">REST API Reference for DescribeChannel Operation</seealso>
        DescribeChannelResponse EndDescribeChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeChannelPlacementGroup


        /// <summary>
        /// Get details about a ChannelPlacementGroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelPlacementGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeChannelPlacementGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannelPlacementGroup">REST API Reference for DescribeChannelPlacementGroup Operation</seealso>
        DescribeChannelPlacementGroupResponse DescribeChannelPlacementGroup(DescribeChannelPlacementGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeChannelPlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeChannelPlacementGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeChannelPlacementGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannelPlacementGroup">REST API Reference for DescribeChannelPlacementGroup Operation</seealso>
        IAsyncResult BeginDescribeChannelPlacementGroup(DescribeChannelPlacementGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeChannelPlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeChannelPlacementGroup.</param>
        /// 
        /// <returns>Returns a  DescribeChannelPlacementGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeChannelPlacementGroup">REST API Reference for DescribeChannelPlacementGroup Operation</seealso>
        DescribeChannelPlacementGroupResponse EndDescribeChannelPlacementGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCluster


        /// <summary>
        /// Get details about a Cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        DescribeClusterResponse DescribeCluster(DescribeClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        IAsyncResult BeginDescribeCluster(DescribeClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCluster.</param>
        /// 
        /// <returns>Returns a  DescribeClusterResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        DescribeClusterResponse EndDescribeCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInput


        /// <summary>
        /// Produces details about an input
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput service method.</param>
        /// 
        /// <returns>The response from the DescribeInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        DescribeInputResponse DescribeInput(DescribeInputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInput operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        IAsyncResult BeginDescribeInput(DescribeInputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInput.</param>
        /// 
        /// <returns>Returns a  DescribeInputResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInput">REST API Reference for DescribeInput Operation</seealso>
        DescribeInputResponse EndDescribeInput(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInputDevice


        /// <summary>
        /// Gets the details for the input device
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputDevice service method.</param>
        /// 
        /// <returns>The response from the DescribeInputDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputDevice">REST API Reference for DescribeInputDevice Operation</seealso>
        DescribeInputDeviceResponse DescribeInputDevice(DescribeInputDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInputDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputDevice operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInputDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputDevice">REST API Reference for DescribeInputDevice Operation</seealso>
        IAsyncResult BeginDescribeInputDevice(DescribeInputDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInputDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInputDevice.</param>
        /// 
        /// <returns>Returns a  DescribeInputDeviceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputDevice">REST API Reference for DescribeInputDevice Operation</seealso>
        DescribeInputDeviceResponse EndDescribeInputDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInputDeviceThumbnail


        /// <summary>
        /// Get the latest thumbnail data for the input device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputDeviceThumbnail service method.</param>
        /// 
        /// <returns>The response from the DescribeInputDeviceThumbnail service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputDeviceThumbnail">REST API Reference for DescribeInputDeviceThumbnail Operation</seealso>
        DescribeInputDeviceThumbnailResponse DescribeInputDeviceThumbnail(DescribeInputDeviceThumbnailRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInputDeviceThumbnail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputDeviceThumbnail operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInputDeviceThumbnail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputDeviceThumbnail">REST API Reference for DescribeInputDeviceThumbnail Operation</seealso>
        IAsyncResult BeginDescribeInputDeviceThumbnail(DescribeInputDeviceThumbnailRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInputDeviceThumbnail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInputDeviceThumbnail.</param>
        /// 
        /// <returns>Returns a  DescribeInputDeviceThumbnailResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputDeviceThumbnail">REST API Reference for DescribeInputDeviceThumbnail Operation</seealso>
        DescribeInputDeviceThumbnailResponse EndDescribeInputDeviceThumbnail(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInputSecurityGroup


        /// <summary>
        /// Produces a summary of an Input Security Group
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputSecurityGroup">REST API Reference for DescribeInputSecurityGroup Operation</seealso>
        DescribeInputSecurityGroupResponse DescribeInputSecurityGroup(DescribeInputSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInputSecurityGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInputSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputSecurityGroup">REST API Reference for DescribeInputSecurityGroup Operation</seealso>
        IAsyncResult BeginDescribeInputSecurityGroup(DescribeInputSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInputSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DescribeInputSecurityGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeInputSecurityGroup">REST API Reference for DescribeInputSecurityGroup Operation</seealso>
        DescribeInputSecurityGroupResponse EndDescribeInputSecurityGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMultiplex


        /// <summary>
        /// Gets details about a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiplex service method.</param>
        /// 
        /// <returns>The response from the DescribeMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeMultiplex">REST API Reference for DescribeMultiplex Operation</seealso>
        DescribeMultiplexResponse DescribeMultiplex(DescribeMultiplexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMultiplex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiplex operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMultiplex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeMultiplex">REST API Reference for DescribeMultiplex Operation</seealso>
        IAsyncResult BeginDescribeMultiplex(DescribeMultiplexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMultiplex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMultiplex.</param>
        /// 
        /// <returns>Returns a  DescribeMultiplexResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeMultiplex">REST API Reference for DescribeMultiplex Operation</seealso>
        DescribeMultiplexResponse EndDescribeMultiplex(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMultiplexProgram


        /// <summary>
        /// Get the details for a program in a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiplexProgram service method.</param>
        /// 
        /// <returns>The response from the DescribeMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeMultiplexProgram">REST API Reference for DescribeMultiplexProgram Operation</seealso>
        DescribeMultiplexProgramResponse DescribeMultiplexProgram(DescribeMultiplexProgramRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMultiplexProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMultiplexProgram operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMultiplexProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeMultiplexProgram">REST API Reference for DescribeMultiplexProgram Operation</seealso>
        IAsyncResult BeginDescribeMultiplexProgram(DescribeMultiplexProgramRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMultiplexProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMultiplexProgram.</param>
        /// 
        /// <returns>Returns a  DescribeMultiplexProgramResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeMultiplexProgram">REST API Reference for DescribeMultiplexProgram Operation</seealso>
        DescribeMultiplexProgramResponse EndDescribeMultiplexProgram(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNetwork


        /// <summary>
        /// Get details about a Network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetwork service method.</param>
        /// 
        /// <returns>The response from the DescribeNetwork service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeNetwork">REST API Reference for DescribeNetwork Operation</seealso>
        DescribeNetworkResponse DescribeNetwork(DescribeNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetwork operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeNetwork">REST API Reference for DescribeNetwork Operation</seealso>
        IAsyncResult BeginDescribeNetwork(DescribeNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetwork.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeNetwork">REST API Reference for DescribeNetwork Operation</seealso>
        DescribeNetworkResponse EndDescribeNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNode


        /// <summary>
        /// Get details about a Node in the specified Cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNode service method.</param>
        /// 
        /// <returns>The response from the DescribeNode service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeNode">REST API Reference for DescribeNode Operation</seealso>
        DescribeNodeResponse DescribeNode(DescribeNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNode operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeNode">REST API Reference for DescribeNode Operation</seealso>
        IAsyncResult BeginDescribeNode(DescribeNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNode.</param>
        /// 
        /// <returns>Returns a  DescribeNodeResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeNode">REST API Reference for DescribeNode Operation</seealso>
        DescribeNodeResponse EndDescribeNode(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeOffering


        /// <summary>
        /// Get details for an offering.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering service method.</param>
        /// 
        /// <returns>The response from the DescribeOffering service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        DescribeOfferingResponse DescribeOffering(DescribeOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOffering operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        IAsyncResult BeginDescribeOffering(DescribeOfferingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOffering.</param>
        /// 
        /// <returns>Returns a  DescribeOfferingResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeOffering">REST API Reference for DescribeOffering Operation</seealso>
        DescribeOfferingResponse EndDescribeOffering(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservation


        /// <summary>
        /// Get details for a reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation service method.</param>
        /// 
        /// <returns>The response from the DescribeReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        DescribeReservationResponse DescribeReservation(DescribeReservationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservation operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        IAsyncResult BeginDescribeReservation(DescribeReservationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservation.</param>
        /// 
        /// <returns>Returns a  DescribeReservationResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeReservation">REST API Reference for DescribeReservation Operation</seealso>
        DescribeReservationResponse EndDescribeReservation(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSchedule


        /// <summary>
        /// Get a channel schedule
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedule service method.</param>
        /// 
        /// <returns>The response from the DescribeSchedule service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        DescribeScheduleResponse DescribeSchedule(DescribeScheduleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchedule operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        IAsyncResult BeginDescribeSchedule(DescribeScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSchedule.</param>
        /// 
        /// <returns>Returns a  DescribeScheduleResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSchedule">REST API Reference for DescribeSchedule Operation</seealso>
        DescribeScheduleResponse EndDescribeSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSdiSource


        /// <summary>
        /// Gets details about a SdiSource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSdiSource service method.</param>
        /// 
        /// <returns>The response from the DescribeSdiSource service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSdiSource">REST API Reference for DescribeSdiSource Operation</seealso>
        DescribeSdiSourceResponse DescribeSdiSource(DescribeSdiSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSdiSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSdiSource operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSdiSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSdiSource">REST API Reference for DescribeSdiSource Operation</seealso>
        IAsyncResult BeginDescribeSdiSource(DescribeSdiSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSdiSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSdiSource.</param>
        /// 
        /// <returns>Returns a  DescribeSdiSourceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeSdiSource">REST API Reference for DescribeSdiSource Operation</seealso>
        DescribeSdiSourceResponse EndDescribeSdiSource(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeThumbnails


        /// <summary>
        /// Describe the latest thumbnails data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeThumbnails service method.</param>
        /// 
        /// <returns>The response from the DescribeThumbnails service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeThumbnails">REST API Reference for DescribeThumbnails Operation</seealso>
        DescribeThumbnailsResponse DescribeThumbnails(DescribeThumbnailsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeThumbnails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeThumbnails operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeThumbnails
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeThumbnails">REST API Reference for DescribeThumbnails Operation</seealso>
        IAsyncResult BeginDescribeThumbnails(DescribeThumbnailsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeThumbnails operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeThumbnails.</param>
        /// 
        /// <returns>Returns a  DescribeThumbnailsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/DescribeThumbnails">REST API Reference for DescribeThumbnails Operation</seealso>
        DescribeThumbnailsResponse EndDescribeThumbnails(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCloudWatchAlarmTemplate


        /// <summary>
        /// Retrieves the specified cloudwatch alarm template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudWatchAlarmTemplate service method.</param>
        /// 
        /// <returns>The response from the GetCloudWatchAlarmTemplate service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetCloudWatchAlarmTemplate">REST API Reference for GetCloudWatchAlarmTemplate Operation</seealso>
        GetCloudWatchAlarmTemplateResponse GetCloudWatchAlarmTemplate(GetCloudWatchAlarmTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudWatchAlarmTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudWatchAlarmTemplate operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudWatchAlarmTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetCloudWatchAlarmTemplate">REST API Reference for GetCloudWatchAlarmTemplate Operation</seealso>
        IAsyncResult BeginGetCloudWatchAlarmTemplate(GetCloudWatchAlarmTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudWatchAlarmTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudWatchAlarmTemplate.</param>
        /// 
        /// <returns>Returns a  GetCloudWatchAlarmTemplateResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetCloudWatchAlarmTemplate">REST API Reference for GetCloudWatchAlarmTemplate Operation</seealso>
        GetCloudWatchAlarmTemplateResponse EndGetCloudWatchAlarmTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetCloudWatchAlarmTemplateGroup


        /// <summary>
        /// Retrieves the specified cloudwatch alarm template group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCloudWatchAlarmTemplateGroup service method.</param>
        /// 
        /// <returns>The response from the GetCloudWatchAlarmTemplateGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetCloudWatchAlarmTemplateGroup">REST API Reference for GetCloudWatchAlarmTemplateGroup Operation</seealso>
        GetCloudWatchAlarmTemplateGroupResponse GetCloudWatchAlarmTemplateGroup(GetCloudWatchAlarmTemplateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCloudWatchAlarmTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCloudWatchAlarmTemplateGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCloudWatchAlarmTemplateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetCloudWatchAlarmTemplateGroup">REST API Reference for GetCloudWatchAlarmTemplateGroup Operation</seealso>
        IAsyncResult BeginGetCloudWatchAlarmTemplateGroup(GetCloudWatchAlarmTemplateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCloudWatchAlarmTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCloudWatchAlarmTemplateGroup.</param>
        /// 
        /// <returns>Returns a  GetCloudWatchAlarmTemplateGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetCloudWatchAlarmTemplateGroup">REST API Reference for GetCloudWatchAlarmTemplateGroup Operation</seealso>
        GetCloudWatchAlarmTemplateGroupResponse EndGetCloudWatchAlarmTemplateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventBridgeRuleTemplate


        /// <summary>
        /// Retrieves the specified eventbridge rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventBridgeRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the GetEventBridgeRuleTemplate service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetEventBridgeRuleTemplate">REST API Reference for GetEventBridgeRuleTemplate Operation</seealso>
        GetEventBridgeRuleTemplateResponse GetEventBridgeRuleTemplate(GetEventBridgeRuleTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventBridgeRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventBridgeRuleTemplate operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventBridgeRuleTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetEventBridgeRuleTemplate">REST API Reference for GetEventBridgeRuleTemplate Operation</seealso>
        IAsyncResult BeginGetEventBridgeRuleTemplate(GetEventBridgeRuleTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventBridgeRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventBridgeRuleTemplate.</param>
        /// 
        /// <returns>Returns a  GetEventBridgeRuleTemplateResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetEventBridgeRuleTemplate">REST API Reference for GetEventBridgeRuleTemplate Operation</seealso>
        GetEventBridgeRuleTemplateResponse EndGetEventBridgeRuleTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEventBridgeRuleTemplateGroup


        /// <summary>
        /// Retrieves the specified eventbridge rule template group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEventBridgeRuleTemplateGroup service method.</param>
        /// 
        /// <returns>The response from the GetEventBridgeRuleTemplateGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetEventBridgeRuleTemplateGroup">REST API Reference for GetEventBridgeRuleTemplateGroup Operation</seealso>
        GetEventBridgeRuleTemplateGroupResponse GetEventBridgeRuleTemplateGroup(GetEventBridgeRuleTemplateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventBridgeRuleTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventBridgeRuleTemplateGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEventBridgeRuleTemplateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetEventBridgeRuleTemplateGroup">REST API Reference for GetEventBridgeRuleTemplateGroup Operation</seealso>
        IAsyncResult BeginGetEventBridgeRuleTemplateGroup(GetEventBridgeRuleTemplateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEventBridgeRuleTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEventBridgeRuleTemplateGroup.</param>
        /// 
        /// <returns>Returns a  GetEventBridgeRuleTemplateGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetEventBridgeRuleTemplateGroup">REST API Reference for GetEventBridgeRuleTemplateGroup Operation</seealso>
        GetEventBridgeRuleTemplateGroupResponse EndGetEventBridgeRuleTemplateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSignalMap


        /// <summary>
        /// Retrieves the specified signal map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSignalMap service method.</param>
        /// 
        /// <returns>The response from the GetSignalMap service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetSignalMap">REST API Reference for GetSignalMap Operation</seealso>
        GetSignalMapResponse GetSignalMap(GetSignalMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSignalMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSignalMap operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSignalMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetSignalMap">REST API Reference for GetSignalMap Operation</seealso>
        IAsyncResult BeginGetSignalMap(GetSignalMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSignalMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSignalMap.</param>
        /// 
        /// <returns>Returns a  GetSignalMapResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/GetSignalMap">REST API Reference for GetSignalMap Operation</seealso>
        GetSignalMapResponse EndGetSignalMap(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAlerts


        /// <summary>
        /// List the alerts for a channel with optional filtering based on alert state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts service method.</param>
        /// 
        /// <returns>The response from the ListAlerts service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        ListAlertsResponse ListAlerts(ListAlertsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlerts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlerts operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlerts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        IAsyncResult BeginListAlerts(ListAlertsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlerts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlerts.</param>
        /// 
        /// <returns>Returns a  ListAlertsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListAlerts">REST API Reference for ListAlerts Operation</seealso>
        ListAlertsResponse EndListAlerts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChannelPlacementGroups


        /// <summary>
        /// Retrieve the list of ChannelPlacementGroups in the specified Cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannelPlacementGroups service method.</param>
        /// 
        /// <returns>The response from the ListChannelPlacementGroups service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannelPlacementGroups">REST API Reference for ListChannelPlacementGroups Operation</seealso>
        ListChannelPlacementGroupsResponse ListChannelPlacementGroups(ListChannelPlacementGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannelPlacementGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannelPlacementGroups operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannelPlacementGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannelPlacementGroups">REST API Reference for ListChannelPlacementGroups Operation</seealso>
        IAsyncResult BeginListChannelPlacementGroups(ListChannelPlacementGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannelPlacementGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannelPlacementGroups.</param>
        /// 
        /// <returns>Returns a  ListChannelPlacementGroupsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannelPlacementGroups">REST API Reference for ListChannelPlacementGroups Operation</seealso>
        ListChannelPlacementGroupsResponse EndListChannelPlacementGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListChannels


        /// <summary>
        /// Produces list of channels that have been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChannels service method.</param>
        /// 
        /// <returns>The response from the ListChannels service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse ListChannels(ListChannelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChannels operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        IAsyncResult BeginListChannels(ListChannelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListChannels.</param>
        /// 
        /// <returns>Returns a  ListChannelsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListChannels">REST API Reference for ListChannels Operation</seealso>
        ListChannelsResponse EndListChannels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCloudWatchAlarmTemplateGroups


        /// <summary>
        /// Lists cloudwatch alarm template groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudWatchAlarmTemplateGroups service method.</param>
        /// 
        /// <returns>The response from the ListCloudWatchAlarmTemplateGroups service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListCloudWatchAlarmTemplateGroups">REST API Reference for ListCloudWatchAlarmTemplateGroups Operation</seealso>
        ListCloudWatchAlarmTemplateGroupsResponse ListCloudWatchAlarmTemplateGroups(ListCloudWatchAlarmTemplateGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudWatchAlarmTemplateGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudWatchAlarmTemplateGroups operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudWatchAlarmTemplateGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListCloudWatchAlarmTemplateGroups">REST API Reference for ListCloudWatchAlarmTemplateGroups Operation</seealso>
        IAsyncResult BeginListCloudWatchAlarmTemplateGroups(ListCloudWatchAlarmTemplateGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudWatchAlarmTemplateGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudWatchAlarmTemplateGroups.</param>
        /// 
        /// <returns>Returns a  ListCloudWatchAlarmTemplateGroupsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListCloudWatchAlarmTemplateGroups">REST API Reference for ListCloudWatchAlarmTemplateGroups Operation</seealso>
        ListCloudWatchAlarmTemplateGroupsResponse EndListCloudWatchAlarmTemplateGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCloudWatchAlarmTemplates


        /// <summary>
        /// Lists cloudwatch alarm templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCloudWatchAlarmTemplates service method.</param>
        /// 
        /// <returns>The response from the ListCloudWatchAlarmTemplates service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListCloudWatchAlarmTemplates">REST API Reference for ListCloudWatchAlarmTemplates Operation</seealso>
        ListCloudWatchAlarmTemplatesResponse ListCloudWatchAlarmTemplates(ListCloudWatchAlarmTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCloudWatchAlarmTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCloudWatchAlarmTemplates operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCloudWatchAlarmTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListCloudWatchAlarmTemplates">REST API Reference for ListCloudWatchAlarmTemplates Operation</seealso>
        IAsyncResult BeginListCloudWatchAlarmTemplates(ListCloudWatchAlarmTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCloudWatchAlarmTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCloudWatchAlarmTemplates.</param>
        /// 
        /// <returns>Returns a  ListCloudWatchAlarmTemplatesResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListCloudWatchAlarmTemplates">REST API Reference for ListCloudWatchAlarmTemplates Operation</seealso>
        ListCloudWatchAlarmTemplatesResponse EndListCloudWatchAlarmTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClusterAlerts


        /// <summary>
        /// List the alerts for a cluster with optional filtering based on alert state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusterAlerts service method.</param>
        /// 
        /// <returns>The response from the ListClusterAlerts service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListClusterAlerts">REST API Reference for ListClusterAlerts Operation</seealso>
        ListClusterAlertsResponse ListClusterAlerts(ListClusterAlertsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusterAlerts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusterAlerts operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusterAlerts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListClusterAlerts">REST API Reference for ListClusterAlerts Operation</seealso>
        IAsyncResult BeginListClusterAlerts(ListClusterAlertsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusterAlerts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusterAlerts.</param>
        /// 
        /// <returns>Returns a  ListClusterAlertsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListClusterAlerts">REST API Reference for ListClusterAlerts Operation</seealso>
        ListClusterAlertsResponse EndListClusterAlerts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListClusters


        /// <summary>
        /// Retrieve the list of Clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse ListClusters(ListClustersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListClusters">REST API Reference for ListClusters Operation</seealso>
        IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListClusters">REST API Reference for ListClusters Operation</seealso>
        ListClustersResponse EndListClusters(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventBridgeRuleTemplateGroups


        /// <summary>
        /// Lists eventbridge rule template groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventBridgeRuleTemplateGroups service method.</param>
        /// 
        /// <returns>The response from the ListEventBridgeRuleTemplateGroups service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListEventBridgeRuleTemplateGroups">REST API Reference for ListEventBridgeRuleTemplateGroups Operation</seealso>
        ListEventBridgeRuleTemplateGroupsResponse ListEventBridgeRuleTemplateGroups(ListEventBridgeRuleTemplateGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventBridgeRuleTemplateGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventBridgeRuleTemplateGroups operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventBridgeRuleTemplateGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListEventBridgeRuleTemplateGroups">REST API Reference for ListEventBridgeRuleTemplateGroups Operation</seealso>
        IAsyncResult BeginListEventBridgeRuleTemplateGroups(ListEventBridgeRuleTemplateGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventBridgeRuleTemplateGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventBridgeRuleTemplateGroups.</param>
        /// 
        /// <returns>Returns a  ListEventBridgeRuleTemplateGroupsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListEventBridgeRuleTemplateGroups">REST API Reference for ListEventBridgeRuleTemplateGroups Operation</seealso>
        ListEventBridgeRuleTemplateGroupsResponse EndListEventBridgeRuleTemplateGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEventBridgeRuleTemplates


        /// <summary>
        /// Lists eventbridge rule templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEventBridgeRuleTemplates service method.</param>
        /// 
        /// <returns>The response from the ListEventBridgeRuleTemplates service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListEventBridgeRuleTemplates">REST API Reference for ListEventBridgeRuleTemplates Operation</seealso>
        ListEventBridgeRuleTemplatesResponse ListEventBridgeRuleTemplates(ListEventBridgeRuleTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventBridgeRuleTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventBridgeRuleTemplates operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEventBridgeRuleTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListEventBridgeRuleTemplates">REST API Reference for ListEventBridgeRuleTemplates Operation</seealso>
        IAsyncResult BeginListEventBridgeRuleTemplates(ListEventBridgeRuleTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEventBridgeRuleTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEventBridgeRuleTemplates.</param>
        /// 
        /// <returns>Returns a  ListEventBridgeRuleTemplatesResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListEventBridgeRuleTemplates">REST API Reference for ListEventBridgeRuleTemplates Operation</seealso>
        ListEventBridgeRuleTemplatesResponse EndListEventBridgeRuleTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInputDevices


        /// <summary>
        /// List input devices
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputDevices service method.</param>
        /// 
        /// <returns>The response from the ListInputDevices service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputDevices">REST API Reference for ListInputDevices Operation</seealso>
        ListInputDevicesResponse ListInputDevices(ListInputDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInputDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputDevices operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInputDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputDevices">REST API Reference for ListInputDevices Operation</seealso>
        IAsyncResult BeginListInputDevices(ListInputDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInputDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInputDevices.</param>
        /// 
        /// <returns>Returns a  ListInputDevicesResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputDevices">REST API Reference for ListInputDevices Operation</seealso>
        ListInputDevicesResponse EndListInputDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInputDeviceTransfers


        /// <summary>
        /// List input devices that are currently being transferred. List input devices that you
        /// are transferring from your AWS account or input devices that another AWS account is
        /// transferring to you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputDeviceTransfers service method.</param>
        /// 
        /// <returns>The response from the ListInputDeviceTransfers service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputDeviceTransfers">REST API Reference for ListInputDeviceTransfers Operation</seealso>
        ListInputDeviceTransfersResponse ListInputDeviceTransfers(ListInputDeviceTransfersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInputDeviceTransfers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputDeviceTransfers operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInputDeviceTransfers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputDeviceTransfers">REST API Reference for ListInputDeviceTransfers Operation</seealso>
        IAsyncResult BeginListInputDeviceTransfers(ListInputDeviceTransfersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInputDeviceTransfers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInputDeviceTransfers.</param>
        /// 
        /// <returns>Returns a  ListInputDeviceTransfersResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputDeviceTransfers">REST API Reference for ListInputDeviceTransfers Operation</seealso>
        ListInputDeviceTransfersResponse EndListInputDeviceTransfers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInputs


        /// <summary>
        /// Produces list of inputs that have been created
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputs service method.</param>
        /// 
        /// <returns>The response from the ListInputs service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputs">REST API Reference for ListInputs Operation</seealso>
        ListInputsResponse ListInputs(ListInputsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputs operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputs">REST API Reference for ListInputs Operation</seealso>
        IAsyncResult BeginListInputs(ListInputsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInputs.</param>
        /// 
        /// <returns>Returns a  ListInputsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputs">REST API Reference for ListInputs Operation</seealso>
        ListInputsResponse EndListInputs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInputSecurityGroups


        /// <summary>
        /// Produces a list of Input Security Groups for an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInputSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the ListInputSecurityGroups service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputSecurityGroups">REST API Reference for ListInputSecurityGroups Operation</seealso>
        ListInputSecurityGroupsResponse ListInputSecurityGroups(ListInputSecurityGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInputSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInputSecurityGroups operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInputSecurityGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputSecurityGroups">REST API Reference for ListInputSecurityGroups Operation</seealso>
        IAsyncResult BeginListInputSecurityGroups(ListInputSecurityGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInputSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInputSecurityGroups.</param>
        /// 
        /// <returns>Returns a  ListInputSecurityGroupsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListInputSecurityGroups">REST API Reference for ListInputSecurityGroups Operation</seealso>
        ListInputSecurityGroupsResponse EndListInputSecurityGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMultiplexAlerts


        /// <summary>
        /// List the alerts for a multiplex with optional filtering based on alert state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiplexAlerts service method.</param>
        /// 
        /// <returns>The response from the ListMultiplexAlerts service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexAlerts">REST API Reference for ListMultiplexAlerts Operation</seealso>
        ListMultiplexAlertsResponse ListMultiplexAlerts(ListMultiplexAlertsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultiplexAlerts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultiplexAlerts operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMultiplexAlerts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexAlerts">REST API Reference for ListMultiplexAlerts Operation</seealso>
        IAsyncResult BeginListMultiplexAlerts(ListMultiplexAlertsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMultiplexAlerts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultiplexAlerts.</param>
        /// 
        /// <returns>Returns a  ListMultiplexAlertsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexAlerts">REST API Reference for ListMultiplexAlerts Operation</seealso>
        ListMultiplexAlertsResponse EndListMultiplexAlerts(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMultiplexes


        /// <summary>
        /// Retrieve a list of the existing multiplexes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiplexes service method.</param>
        /// 
        /// <returns>The response from the ListMultiplexes service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexes">REST API Reference for ListMultiplexes Operation</seealso>
        ListMultiplexesResponse ListMultiplexes(ListMultiplexesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultiplexes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultiplexes operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMultiplexes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexes">REST API Reference for ListMultiplexes Operation</seealso>
        IAsyncResult BeginListMultiplexes(ListMultiplexesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMultiplexes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultiplexes.</param>
        /// 
        /// <returns>Returns a  ListMultiplexesResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexes">REST API Reference for ListMultiplexes Operation</seealso>
        ListMultiplexesResponse EndListMultiplexes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMultiplexPrograms


        /// <summary>
        /// List the programs that currently exist for a specific multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMultiplexPrograms service method.</param>
        /// 
        /// <returns>The response from the ListMultiplexPrograms service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexPrograms">REST API Reference for ListMultiplexPrograms Operation</seealso>
        ListMultiplexProgramsResponse ListMultiplexPrograms(ListMultiplexProgramsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultiplexPrograms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultiplexPrograms operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMultiplexPrograms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexPrograms">REST API Reference for ListMultiplexPrograms Operation</seealso>
        IAsyncResult BeginListMultiplexPrograms(ListMultiplexProgramsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMultiplexPrograms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultiplexPrograms.</param>
        /// 
        /// <returns>Returns a  ListMultiplexProgramsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListMultiplexPrograms">REST API Reference for ListMultiplexPrograms Operation</seealso>
        ListMultiplexProgramsResponse EndListMultiplexPrograms(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNetworks


        /// <summary>
        /// Retrieve the list of Networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks service method.</param>
        /// 
        /// <returns>The response from the ListNetworks service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        ListNetworksResponse ListNetworks(ListNetworksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNetworks operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        IAsyncResult BeginListNetworks(ListNetworksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNetworks.</param>
        /// 
        /// <returns>Returns a  ListNetworksResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListNetworks">REST API Reference for ListNetworks Operation</seealso>
        ListNetworksResponse EndListNetworks(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNodes


        /// <summary>
        /// Retrieve the list of Nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNodes service method.</param>
        /// 
        /// <returns>The response from the ListNodes service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListNodes">REST API Reference for ListNodes Operation</seealso>
        ListNodesResponse ListNodes(ListNodesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNodes operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNodes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListNodes">REST API Reference for ListNodes Operation</seealso>
        IAsyncResult BeginListNodes(ListNodesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNodes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNodes.</param>
        /// 
        /// <returns>Returns a  ListNodesResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListNodes">REST API Reference for ListNodes Operation</seealso>
        ListNodesResponse EndListNodes(IAsyncResult asyncResult);

        #endregion
        
        #region  ListOfferings


        /// <summary>
        /// List offerings available for purchase.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings service method.</param>
        /// 
        /// <returns>The response from the ListOfferings service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        ListOfferingsResponse ListOfferings(ListOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOfferings operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        IAsyncResult BeginListOfferings(ListOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOfferings.</param>
        /// 
        /// <returns>Returns a  ListOfferingsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListOfferings">REST API Reference for ListOfferings Operation</seealso>
        ListOfferingsResponse EndListOfferings(IAsyncResult asyncResult);

        #endregion
        
        #region  ListReservations


        /// <summary>
        /// List purchased reservations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReservations service method.</param>
        /// 
        /// <returns>The response from the ListReservations service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        ListReservationsResponse ListReservations(ListReservationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListReservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListReservations operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListReservations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        IAsyncResult BeginListReservations(ListReservationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListReservations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListReservations.</param>
        /// 
        /// <returns>Returns a  ListReservationsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListReservations">REST API Reference for ListReservations Operation</seealso>
        ListReservationsResponse EndListReservations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSdiSources


        /// <summary>
        /// List all the SdiSources in the AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSdiSources service method.</param>
        /// 
        /// <returns>The response from the ListSdiSources service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListSdiSources">REST API Reference for ListSdiSources Operation</seealso>
        ListSdiSourcesResponse ListSdiSources(ListSdiSourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSdiSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSdiSources operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSdiSources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListSdiSources">REST API Reference for ListSdiSources Operation</seealso>
        IAsyncResult BeginListSdiSources(ListSdiSourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSdiSources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSdiSources.</param>
        /// 
        /// <returns>Returns a  ListSdiSourcesResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListSdiSources">REST API Reference for ListSdiSources Operation</seealso>
        ListSdiSourcesResponse EndListSdiSources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSignalMaps


        /// <summary>
        /// Lists signal maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSignalMaps service method.</param>
        /// 
        /// <returns>The response from the ListSignalMaps service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListSignalMaps">REST API Reference for ListSignalMaps Operation</seealso>
        ListSignalMapsResponse ListSignalMaps(ListSignalMapsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSignalMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSignalMaps operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSignalMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListSignalMaps">REST API Reference for ListSignalMaps Operation</seealso>
        IAsyncResult BeginListSignalMaps(ListSignalMapsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSignalMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSignalMaps.</param>
        /// 
        /// <returns>Returns a  ListSignalMapsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListSignalMaps">REST API Reference for ListSignalMaps Operation</seealso>
        ListSignalMapsResponse EndListSignalMaps(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Produces list of tags that have been created for a resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListVersions


        /// <summary>
        /// Retrieves an array of all the encoder engine versions that are available in this AWS
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListVersions">REST API Reference for ListVersions Operation</seealso>
        ListVersionsResponse ListVersions(ListVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListVersions">REST API Reference for ListVersions Operation</seealso>
        IAsyncResult BeginListVersions(ListVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// 
        /// <returns>Returns a  ListVersionsResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/ListVersions">REST API Reference for ListVersions Operation</seealso>
        ListVersionsResponse EndListVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  PurchaseOffering


        /// <summary>
        /// Purchase an offering and create a reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseOffering service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        PurchaseOfferingResponse PurchaseOffering(PurchaseOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseOffering operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        IAsyncResult BeginPurchaseOffering(PurchaseOfferingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseOfferingResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/PurchaseOffering">REST API Reference for PurchaseOffering Operation</seealso>
        PurchaseOfferingResponse EndPurchaseOffering(IAsyncResult asyncResult);

        #endregion
        
        #region  RebootInputDevice


        /// <summary>
        /// Send a reboot command to the specified input device. The device will begin rebooting
        /// within a few seconds of sending the command. When the reboot is complete, the device’s
        /// connection status will change to connected.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInputDevice service method.</param>
        /// 
        /// <returns>The response from the RebootInputDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/RebootInputDevice">REST API Reference for RebootInputDevice Operation</seealso>
        RebootInputDeviceResponse RebootInputDevice(RebootInputDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInputDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInputDevice operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootInputDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/RebootInputDevice">REST API Reference for RebootInputDevice Operation</seealso>
        IAsyncResult BeginRebootInputDevice(RebootInputDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootInputDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInputDevice.</param>
        /// 
        /// <returns>Returns a  RebootInputDeviceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/RebootInputDevice">REST API Reference for RebootInputDevice Operation</seealso>
        RebootInputDeviceResponse EndRebootInputDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectInputDeviceTransfer


        /// <summary>
        /// Reject the transfer of the specified input device to your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInputDeviceTransfer service method.</param>
        /// 
        /// <returns>The response from the RejectInputDeviceTransfer service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/RejectInputDeviceTransfer">REST API Reference for RejectInputDeviceTransfer Operation</seealso>
        RejectInputDeviceTransferResponse RejectInputDeviceTransfer(RejectInputDeviceTransferRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectInputDeviceTransfer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectInputDeviceTransfer operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectInputDeviceTransfer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/RejectInputDeviceTransfer">REST API Reference for RejectInputDeviceTransfer Operation</seealso>
        IAsyncResult BeginRejectInputDeviceTransfer(RejectInputDeviceTransferRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectInputDeviceTransfer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectInputDeviceTransfer.</param>
        /// 
        /// <returns>Returns a  RejectInputDeviceTransferResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/RejectInputDeviceTransfer">REST API Reference for RejectInputDeviceTransfer Operation</seealso>
        RejectInputDeviceTransferResponse EndRejectInputDeviceTransfer(IAsyncResult asyncResult);

        #endregion
        
        #region  RestartChannelPipelines


        /// <summary>
        /// Restart pipelines in one channel that is currently running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestartChannelPipelines service method.</param>
        /// 
        /// <returns>The response from the RestartChannelPipelines service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/RestartChannelPipelines">REST API Reference for RestartChannelPipelines Operation</seealso>
        RestartChannelPipelinesResponse RestartChannelPipelines(RestartChannelPipelinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestartChannelPipelines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartChannelPipelines operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestartChannelPipelines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/RestartChannelPipelines">REST API Reference for RestartChannelPipelines Operation</seealso>
        IAsyncResult BeginRestartChannelPipelines(RestartChannelPipelinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestartChannelPipelines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestartChannelPipelines.</param>
        /// 
        /// <returns>Returns a  RestartChannelPipelinesResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/RestartChannelPipelines">REST API Reference for RestartChannelPipelines Operation</seealso>
        RestartChannelPipelinesResponse EndRestartChannelPipelines(IAsyncResult asyncResult);

        #endregion
        
        #region  StartChannel


        /// <summary>
        /// Starts an existing channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartChannel service method.</param>
        /// 
        /// <returns>The response from the StartChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartChannel">REST API Reference for StartChannel Operation</seealso>
        StartChannelResponse StartChannel(StartChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartChannel">REST API Reference for StartChannel Operation</seealso>
        IAsyncResult BeginStartChannel(StartChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartChannel.</param>
        /// 
        /// <returns>Returns a  StartChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartChannel">REST API Reference for StartChannel Operation</seealso>
        StartChannelResponse EndStartChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  StartDeleteMonitorDeployment


        /// <summary>
        /// Initiates a deployment to delete the monitor of the specified signal map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDeleteMonitorDeployment service method.</param>
        /// 
        /// <returns>The response from the StartDeleteMonitorDeployment service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartDeleteMonitorDeployment">REST API Reference for StartDeleteMonitorDeployment Operation</seealso>
        StartDeleteMonitorDeploymentResponse StartDeleteMonitorDeployment(StartDeleteMonitorDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartDeleteMonitorDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartDeleteMonitorDeployment operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartDeleteMonitorDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartDeleteMonitorDeployment">REST API Reference for StartDeleteMonitorDeployment Operation</seealso>
        IAsyncResult BeginStartDeleteMonitorDeployment(StartDeleteMonitorDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartDeleteMonitorDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartDeleteMonitorDeployment.</param>
        /// 
        /// <returns>Returns a  StartDeleteMonitorDeploymentResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartDeleteMonitorDeployment">REST API Reference for StartDeleteMonitorDeployment Operation</seealso>
        StartDeleteMonitorDeploymentResponse EndStartDeleteMonitorDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  StartInputDevice


        /// <summary>
        /// Start an input device that is attached to a MediaConnect flow. (There is no need to
        /// start a device that is attached to a MediaLive input; MediaLive starts the device
        /// when the channel starts.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInputDevice service method.</param>
        /// 
        /// <returns>The response from the StartInputDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartInputDevice">REST API Reference for StartInputDevice Operation</seealso>
        StartInputDeviceResponse StartInputDevice(StartInputDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartInputDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInputDevice operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInputDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartInputDevice">REST API Reference for StartInputDevice Operation</seealso>
        IAsyncResult BeginStartInputDevice(StartInputDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInputDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInputDevice.</param>
        /// 
        /// <returns>Returns a  StartInputDeviceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartInputDevice">REST API Reference for StartInputDevice Operation</seealso>
        StartInputDeviceResponse EndStartInputDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  StartInputDeviceMaintenanceWindow


        /// <summary>
        /// Start a maintenance window for the specified input device. Starting a maintenance
        /// window will give the device up to two hours to install software. If the device was
        /// streaming prior to the maintenance, it will resume streaming when the software is
        /// fully installed. Devices automatically install updates while they are powered on and
        /// their MediaLive channels are stopped. A maintenance window allows you to update a
        /// device without having to stop MediaLive channels that use the device. The device must
        /// remain powered on and connected to the internet for the duration of the maintenance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInputDeviceMaintenanceWindow service method.</param>
        /// 
        /// <returns>The response from the StartInputDeviceMaintenanceWindow service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartInputDeviceMaintenanceWindow">REST API Reference for StartInputDeviceMaintenanceWindow Operation</seealso>
        StartInputDeviceMaintenanceWindowResponse StartInputDeviceMaintenanceWindow(StartInputDeviceMaintenanceWindowRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartInputDeviceMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInputDeviceMaintenanceWindow operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInputDeviceMaintenanceWindow
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartInputDeviceMaintenanceWindow">REST API Reference for StartInputDeviceMaintenanceWindow Operation</seealso>
        IAsyncResult BeginStartInputDeviceMaintenanceWindow(StartInputDeviceMaintenanceWindowRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInputDeviceMaintenanceWindow operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInputDeviceMaintenanceWindow.</param>
        /// 
        /// <returns>Returns a  StartInputDeviceMaintenanceWindowResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartInputDeviceMaintenanceWindow">REST API Reference for StartInputDeviceMaintenanceWindow Operation</seealso>
        StartInputDeviceMaintenanceWindowResponse EndStartInputDeviceMaintenanceWindow(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMonitorDeployment


        /// <summary>
        /// Initiates a deployment to deploy the latest monitor of the specified signal map.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMonitorDeployment service method.</param>
        /// 
        /// <returns>The response from the StartMonitorDeployment service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartMonitorDeployment">REST API Reference for StartMonitorDeployment Operation</seealso>
        StartMonitorDeploymentResponse StartMonitorDeployment(StartMonitorDeploymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMonitorDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMonitorDeployment operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMonitorDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartMonitorDeployment">REST API Reference for StartMonitorDeployment Operation</seealso>
        IAsyncResult BeginStartMonitorDeployment(StartMonitorDeploymentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMonitorDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMonitorDeployment.</param>
        /// 
        /// <returns>Returns a  StartMonitorDeploymentResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartMonitorDeployment">REST API Reference for StartMonitorDeployment Operation</seealso>
        StartMonitorDeploymentResponse EndStartMonitorDeployment(IAsyncResult asyncResult);

        #endregion
        
        #region  StartMultiplex


        /// <summary>
        /// Start (run) the multiplex. Starting the multiplex does not start the channels. You
        /// must explicitly start each channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMultiplex service method.</param>
        /// 
        /// <returns>The response from the StartMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartMultiplex">REST API Reference for StartMultiplex Operation</seealso>
        StartMultiplexResponse StartMultiplex(StartMultiplexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartMultiplex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMultiplex operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartMultiplex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartMultiplex">REST API Reference for StartMultiplex Operation</seealso>
        IAsyncResult BeginStartMultiplex(StartMultiplexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartMultiplex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartMultiplex.</param>
        /// 
        /// <returns>Returns a  StartMultiplexResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartMultiplex">REST API Reference for StartMultiplex Operation</seealso>
        StartMultiplexResponse EndStartMultiplex(IAsyncResult asyncResult);

        #endregion
        
        #region  StartUpdateSignalMap


        /// <summary>
        /// Initiates an update for the specified signal map. Will discover a new signal map if
        /// a changed discoveryEntryPointArn is provided.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartUpdateSignalMap service method.</param>
        /// 
        /// <returns>The response from the StartUpdateSignalMap service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartUpdateSignalMap">REST API Reference for StartUpdateSignalMap Operation</seealso>
        StartUpdateSignalMapResponse StartUpdateSignalMap(StartUpdateSignalMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartUpdateSignalMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartUpdateSignalMap operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartUpdateSignalMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartUpdateSignalMap">REST API Reference for StartUpdateSignalMap Operation</seealso>
        IAsyncResult BeginStartUpdateSignalMap(StartUpdateSignalMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartUpdateSignalMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartUpdateSignalMap.</param>
        /// 
        /// <returns>Returns a  StartUpdateSignalMapResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StartUpdateSignalMap">REST API Reference for StartUpdateSignalMap Operation</seealso>
        StartUpdateSignalMapResponse EndStartUpdateSignalMap(IAsyncResult asyncResult);

        #endregion
        
        #region  StopChannel


        /// <summary>
        /// Stops a running channel
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopChannel service method.</param>
        /// 
        /// <returns>The response from the StopChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopChannel">REST API Reference for StopChannel Operation</seealso>
        StopChannelResponse StopChannel(StopChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopChannel">REST API Reference for StopChannel Operation</seealso>
        IAsyncResult BeginStopChannel(StopChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopChannel.</param>
        /// 
        /// <returns>Returns a  StopChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopChannel">REST API Reference for StopChannel Operation</seealso>
        StopChannelResponse EndStopChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  StopInputDevice


        /// <summary>
        /// Stop an input device that is attached to a MediaConnect flow. (There is no need to
        /// stop a device that is attached to a MediaLive input; MediaLive automatically stops
        /// the device when the channel stops.)
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInputDevice service method.</param>
        /// 
        /// <returns>The response from the StopInputDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopInputDevice">REST API Reference for StopInputDevice Operation</seealso>
        StopInputDeviceResponse StopInputDevice(StopInputDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopInputDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInputDevice operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInputDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopInputDevice">REST API Reference for StopInputDevice Operation</seealso>
        IAsyncResult BeginStopInputDevice(StopInputDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopInputDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInputDevice.</param>
        /// 
        /// <returns>Returns a  StopInputDeviceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopInputDevice">REST API Reference for StopInputDevice Operation</seealso>
        StopInputDeviceResponse EndStopInputDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  StopMultiplex


        /// <summary>
        /// Stops a running multiplex. If the multiplex isn't running, this action has no effect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopMultiplex service method.</param>
        /// 
        /// <returns>The response from the StopMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopMultiplex">REST API Reference for StopMultiplex Operation</seealso>
        StopMultiplexResponse StopMultiplex(StopMultiplexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopMultiplex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMultiplex operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopMultiplex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopMultiplex">REST API Reference for StopMultiplex Operation</seealso>
        IAsyncResult BeginStopMultiplex(StopMultiplexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopMultiplex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopMultiplex.</param>
        /// 
        /// <returns>Returns a  StopMultiplexResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/StopMultiplex">REST API Reference for StopMultiplex Operation</seealso>
        StopMultiplexResponse EndStopMultiplex(IAsyncResult asyncResult);

        #endregion
        
        #region  TransferInputDevice


        /// <summary>
        /// Start an input device transfer to another AWS account. After you make the request,
        /// the other account must accept or reject the transfer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TransferInputDevice service method.</param>
        /// 
        /// <returns>The response from the TransferInputDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/TransferInputDevice">REST API Reference for TransferInputDevice Operation</seealso>
        TransferInputDeviceResponse TransferInputDevice(TransferInputDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TransferInputDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TransferInputDevice operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTransferInputDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/TransferInputDevice">REST API Reference for TransferInputDevice Operation</seealso>
        IAsyncResult BeginTransferInputDevice(TransferInputDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TransferInputDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTransferInputDevice.</param>
        /// 
        /// <returns>Returns a  TransferInputDeviceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/TransferInputDevice">REST API Reference for TransferInputDevice Operation</seealso>
        TransferInputDeviceResponse EndTransferInputDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccountConfiguration


        /// <summary>
        /// Update account configuration
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountConfiguration service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateAccountConfiguration">REST API Reference for UpdateAccountConfiguration Operation</seealso>
        UpdateAccountConfigurationResponse UpdateAccountConfiguration(UpdateAccountConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountConfiguration operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateAccountConfiguration">REST API Reference for UpdateAccountConfiguration Operation</seealso>
        IAsyncResult BeginUpdateAccountConfiguration(UpdateAccountConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateAccountConfigurationResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateAccountConfiguration">REST API Reference for UpdateAccountConfiguration Operation</seealso>
        UpdateAccountConfigurationResponse EndUpdateAccountConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChannel


        /// <summary>
        /// Updates a channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel service method.</param>
        /// 
        /// <returns>The response from the UpdateChannel service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse UpdateChannel(UpdateChannelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannel operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        IAsyncResult BeginUpdateChannel(UpdateChannelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannel.</param>
        /// 
        /// <returns>Returns a  UpdateChannelResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannel">REST API Reference for UpdateChannel Operation</seealso>
        UpdateChannelResponse EndUpdateChannel(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChannelClass


        /// <summary>
        /// Changes the class of the channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelClass service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelClass service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannelClass">REST API Reference for UpdateChannelClass Operation</seealso>
        UpdateChannelClassResponse UpdateChannelClass(UpdateChannelClassRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelClass operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelClass operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelClass
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannelClass">REST API Reference for UpdateChannelClass Operation</seealso>
        IAsyncResult BeginUpdateChannelClass(UpdateChannelClassRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelClass operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelClass.</param>
        /// 
        /// <returns>Returns a  UpdateChannelClassResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannelClass">REST API Reference for UpdateChannelClass Operation</seealso>
        UpdateChannelClassResponse EndUpdateChannelClass(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateChannelPlacementGroup


        /// <summary>
        /// Change the settings for a ChannelPlacementGroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelPlacementGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateChannelPlacementGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannelPlacementGroup">REST API Reference for UpdateChannelPlacementGroup Operation</seealso>
        UpdateChannelPlacementGroupResponse UpdateChannelPlacementGroup(UpdateChannelPlacementGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateChannelPlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateChannelPlacementGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateChannelPlacementGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannelPlacementGroup">REST API Reference for UpdateChannelPlacementGroup Operation</seealso>
        IAsyncResult BeginUpdateChannelPlacementGroup(UpdateChannelPlacementGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateChannelPlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateChannelPlacementGroup.</param>
        /// 
        /// <returns>Returns a  UpdateChannelPlacementGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateChannelPlacementGroup">REST API Reference for UpdateChannelPlacementGroup Operation</seealso>
        UpdateChannelPlacementGroupResponse EndUpdateChannelPlacementGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCloudWatchAlarmTemplate


        /// <summary>
        /// Updates the specified cloudwatch alarm template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudWatchAlarmTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateCloudWatchAlarmTemplate service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateCloudWatchAlarmTemplate">REST API Reference for UpdateCloudWatchAlarmTemplate Operation</seealso>
        UpdateCloudWatchAlarmTemplateResponse UpdateCloudWatchAlarmTemplate(UpdateCloudWatchAlarmTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudWatchAlarmTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudWatchAlarmTemplate operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCloudWatchAlarmTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateCloudWatchAlarmTemplate">REST API Reference for UpdateCloudWatchAlarmTemplate Operation</seealso>
        IAsyncResult BeginUpdateCloudWatchAlarmTemplate(UpdateCloudWatchAlarmTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCloudWatchAlarmTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudWatchAlarmTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateCloudWatchAlarmTemplateResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateCloudWatchAlarmTemplate">REST API Reference for UpdateCloudWatchAlarmTemplate Operation</seealso>
        UpdateCloudWatchAlarmTemplateResponse EndUpdateCloudWatchAlarmTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCloudWatchAlarmTemplateGroup


        /// <summary>
        /// Updates the specified cloudwatch alarm template group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudWatchAlarmTemplateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateCloudWatchAlarmTemplateGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateCloudWatchAlarmTemplateGroup">REST API Reference for UpdateCloudWatchAlarmTemplateGroup Operation</seealso>
        UpdateCloudWatchAlarmTemplateGroupResponse UpdateCloudWatchAlarmTemplateGroup(UpdateCloudWatchAlarmTemplateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCloudWatchAlarmTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCloudWatchAlarmTemplateGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCloudWatchAlarmTemplateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateCloudWatchAlarmTemplateGroup">REST API Reference for UpdateCloudWatchAlarmTemplateGroup Operation</seealso>
        IAsyncResult BeginUpdateCloudWatchAlarmTemplateGroup(UpdateCloudWatchAlarmTemplateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCloudWatchAlarmTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCloudWatchAlarmTemplateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateCloudWatchAlarmTemplateGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateCloudWatchAlarmTemplateGroup">REST API Reference for UpdateCloudWatchAlarmTemplateGroup Operation</seealso>
        UpdateCloudWatchAlarmTemplateGroupResponse EndUpdateCloudWatchAlarmTemplateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCluster


        /// <summary>
        /// Change the settings for a Cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster service method.</param>
        /// 
        /// <returns>The response from the UpdateCluster service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        UpdateClusterResponse UpdateCluster(UpdateClusterRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCluster operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        IAsyncResult BeginUpdateCluster(UpdateClusterRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCluster.</param>
        /// 
        /// <returns>Returns a  UpdateClusterResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateCluster">REST API Reference for UpdateCluster Operation</seealso>
        UpdateClusterResponse EndUpdateCluster(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEventBridgeRuleTemplate


        /// <summary>
        /// Updates the specified eventbridge rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventBridgeRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateEventBridgeRuleTemplate service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateEventBridgeRuleTemplate">REST API Reference for UpdateEventBridgeRuleTemplate Operation</seealso>
        UpdateEventBridgeRuleTemplateResponse UpdateEventBridgeRuleTemplate(UpdateEventBridgeRuleTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventBridgeRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventBridgeRuleTemplate operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventBridgeRuleTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateEventBridgeRuleTemplate">REST API Reference for UpdateEventBridgeRuleTemplate Operation</seealso>
        IAsyncResult BeginUpdateEventBridgeRuleTemplate(UpdateEventBridgeRuleTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventBridgeRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventBridgeRuleTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateEventBridgeRuleTemplateResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateEventBridgeRuleTemplate">REST API Reference for UpdateEventBridgeRuleTemplate Operation</seealso>
        UpdateEventBridgeRuleTemplateResponse EndUpdateEventBridgeRuleTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEventBridgeRuleTemplateGroup


        /// <summary>
        /// Updates the specified eventbridge rule template group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventBridgeRuleTemplateGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateEventBridgeRuleTemplateGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateEventBridgeRuleTemplateGroup">REST API Reference for UpdateEventBridgeRuleTemplateGroup Operation</seealso>
        UpdateEventBridgeRuleTemplateGroupResponse UpdateEventBridgeRuleTemplateGroup(UpdateEventBridgeRuleTemplateGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEventBridgeRuleTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventBridgeRuleTemplateGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEventBridgeRuleTemplateGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateEventBridgeRuleTemplateGroup">REST API Reference for UpdateEventBridgeRuleTemplateGroup Operation</seealso>
        IAsyncResult BeginUpdateEventBridgeRuleTemplateGroup(UpdateEventBridgeRuleTemplateGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEventBridgeRuleTemplateGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEventBridgeRuleTemplateGroup.</param>
        /// 
        /// <returns>Returns a  UpdateEventBridgeRuleTemplateGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateEventBridgeRuleTemplateGroup">REST API Reference for UpdateEventBridgeRuleTemplateGroup Operation</seealso>
        UpdateEventBridgeRuleTemplateGroupResponse EndUpdateEventBridgeRuleTemplateGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInput


        /// <summary>
        /// Updates an input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput service method.</param>
        /// 
        /// <returns>The response from the UpdateInput service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        UpdateInputResponse UpdateInput(UpdateInputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInput operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        IAsyncResult BeginUpdateInput(UpdateInputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInput.</param>
        /// 
        /// <returns>Returns a  UpdateInputResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInput">REST API Reference for UpdateInput Operation</seealso>
        UpdateInputResponse EndUpdateInput(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInputDevice


        /// <summary>
        /// Updates the parameters for the input device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInputDevice service method.</param>
        /// 
        /// <returns>The response from the UpdateInputDevice service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputDevice">REST API Reference for UpdateInputDevice Operation</seealso>
        UpdateInputDeviceResponse UpdateInputDevice(UpdateInputDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInputDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInputDevice operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInputDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputDevice">REST API Reference for UpdateInputDevice Operation</seealso>
        IAsyncResult BeginUpdateInputDevice(UpdateInputDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInputDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInputDevice.</param>
        /// 
        /// <returns>Returns a  UpdateInputDeviceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputDevice">REST API Reference for UpdateInputDevice Operation</seealso>
        UpdateInputDeviceResponse EndUpdateInputDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInputSecurityGroup


        /// <summary>
        /// Update an Input Security Group's Whilelists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInputSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateInputSecurityGroup service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputSecurityGroup">REST API Reference for UpdateInputSecurityGroup Operation</seealso>
        UpdateInputSecurityGroupResponse UpdateInputSecurityGroup(UpdateInputSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInputSecurityGroup operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInputSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputSecurityGroup">REST API Reference for UpdateInputSecurityGroup Operation</seealso>
        IAsyncResult BeginUpdateInputSecurityGroup(UpdateInputSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInputSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInputSecurityGroup.</param>
        /// 
        /// <returns>Returns a  UpdateInputSecurityGroupResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateInputSecurityGroup">REST API Reference for UpdateInputSecurityGroup Operation</seealso>
        UpdateInputSecurityGroupResponse EndUpdateInputSecurityGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMultiplex


        /// <summary>
        /// Updates a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMultiplex service method.</param>
        /// 
        /// <returns>The response from the UpdateMultiplex service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateMultiplex">REST API Reference for UpdateMultiplex Operation</seealso>
        UpdateMultiplexResponse UpdateMultiplex(UpdateMultiplexRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMultiplex operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMultiplex operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMultiplex
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateMultiplex">REST API Reference for UpdateMultiplex Operation</seealso>
        IAsyncResult BeginUpdateMultiplex(UpdateMultiplexRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMultiplex operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMultiplex.</param>
        /// 
        /// <returns>Returns a  UpdateMultiplexResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateMultiplex">REST API Reference for UpdateMultiplex Operation</seealso>
        UpdateMultiplexResponse EndUpdateMultiplex(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMultiplexProgram


        /// <summary>
        /// Update a program in a multiplex.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMultiplexProgram service method.</param>
        /// 
        /// <returns>The response from the UpdateMultiplexProgram service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateMultiplexProgram">REST API Reference for UpdateMultiplexProgram Operation</seealso>
        UpdateMultiplexProgramResponse UpdateMultiplexProgram(UpdateMultiplexProgramRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMultiplexProgram operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMultiplexProgram operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMultiplexProgram
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateMultiplexProgram">REST API Reference for UpdateMultiplexProgram Operation</seealso>
        IAsyncResult BeginUpdateMultiplexProgram(UpdateMultiplexProgramRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMultiplexProgram operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMultiplexProgram.</param>
        /// 
        /// <returns>Returns a  UpdateMultiplexProgramResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateMultiplexProgram">REST API Reference for UpdateMultiplexProgram Operation</seealso>
        UpdateMultiplexProgramResponse EndUpdateMultiplexProgram(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNetwork


        /// <summary>
        /// Change the settings for a Network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetwork service method.</param>
        /// 
        /// <returns>The response from the UpdateNetwork service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateNetwork">REST API Reference for UpdateNetwork Operation</seealso>
        UpdateNetworkResponse UpdateNetwork(UpdateNetworkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetwork operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateNetwork">REST API Reference for UpdateNetwork Operation</seealso>
        IAsyncResult BeginUpdateNetwork(UpdateNetworkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateNetwork">REST API Reference for UpdateNetwork Operation</seealso>
        UpdateNetworkResponse EndUpdateNetwork(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNode


        /// <summary>
        /// Change the settings for a Node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNode service method.</param>
        /// 
        /// <returns>The response from the UpdateNode service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateNode">REST API Reference for UpdateNode Operation</seealso>
        UpdateNodeResponse UpdateNode(UpdateNodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNode operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateNode">REST API Reference for UpdateNode Operation</seealso>
        IAsyncResult BeginUpdateNode(UpdateNodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNode.</param>
        /// 
        /// <returns>Returns a  UpdateNodeResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateNode">REST API Reference for UpdateNode Operation</seealso>
        UpdateNodeResponse EndUpdateNode(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNodeState


        /// <summary>
        /// Update the state of a node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNodeState service method.</param>
        /// 
        /// <returns>The response from the UpdateNodeState service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.UnprocessableEntityException">
        /// Placeholder documentation for UnprocessableEntityException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateNodeState">REST API Reference for UpdateNodeState Operation</seealso>
        UpdateNodeStateResponse UpdateNodeState(UpdateNodeStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNodeState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNodeState operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNodeState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateNodeState">REST API Reference for UpdateNodeState Operation</seealso>
        IAsyncResult BeginUpdateNodeState(UpdateNodeStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNodeState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNodeState.</param>
        /// 
        /// <returns>Returns a  UpdateNodeStateResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateNodeState">REST API Reference for UpdateNodeState Operation</seealso>
        UpdateNodeStateResponse EndUpdateNodeState(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateReservation


        /// <summary>
        /// Update reservation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateReservation service method.</param>
        /// 
        /// <returns>The response from the UpdateReservation service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.NotFoundException">
        /// Placeholder documentation for NotFoundException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateReservation">REST API Reference for UpdateReservation Operation</seealso>
        UpdateReservationResponse UpdateReservation(UpdateReservationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateReservation operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateReservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateReservation">REST API Reference for UpdateReservation Operation</seealso>
        IAsyncResult BeginUpdateReservation(UpdateReservationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateReservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateReservation.</param>
        /// 
        /// <returns>Returns a  UpdateReservationResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateReservation">REST API Reference for UpdateReservation Operation</seealso>
        UpdateReservationResponse EndUpdateReservation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSdiSource


        /// <summary>
        /// Change some of the settings in an SdiSource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSdiSource service method.</param>
        /// 
        /// <returns>The response from the UpdateSdiSource service method, as returned by MediaLive.</returns>
        /// <exception cref="Amazon.MediaLive.Model.BadGatewayException">
        /// Placeholder documentation for BadGatewayException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.BadRequestException">
        /// Placeholder documentation for BadRequestException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ConflictException">
        /// Placeholder documentation for ConflictException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.ForbiddenException">
        /// Placeholder documentation for ForbiddenException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.GatewayTimeoutException">
        /// Placeholder documentation for GatewayTimeoutException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.InternalServerErrorException">
        /// Placeholder documentation for InternalServerErrorException
        /// </exception>
        /// <exception cref="Amazon.MediaLive.Model.TooManyRequestsException">
        /// Placeholder documentation for TooManyRequestsException
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateSdiSource">REST API Reference for UpdateSdiSource Operation</seealso>
        UpdateSdiSourceResponse UpdateSdiSource(UpdateSdiSourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSdiSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSdiSource operation on AmazonMediaLiveClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSdiSource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateSdiSource">REST API Reference for UpdateSdiSource Operation</seealso>
        IAsyncResult BeginUpdateSdiSource(UpdateSdiSourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSdiSource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSdiSource.</param>
        /// 
        /// <returns>Returns a  UpdateSdiSourceResult from MediaLive.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/medialive-2017-10-14/UpdateSdiSource">REST API Reference for UpdateSdiSource Operation</seealso>
        UpdateSdiSourceResponse EndUpdateSdiSource(IAsyncResult asyncResult);

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