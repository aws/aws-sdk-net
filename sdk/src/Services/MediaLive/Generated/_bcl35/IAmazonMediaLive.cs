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

namespace Amazon.MediaLive
{
    /// <summary>
    /// Interface for accessing MediaLive
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
        
    }
}