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
 * Do not modify this file. This file is generated from the iot1click-devices-2018-05-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.IoT1ClickDevicesService.Model;

namespace Amazon.IoT1ClickDevicesService
{
    /// <summary>
    /// Interface for accessing IoT1ClickDevicesService
    ///
    /// Stub description
    /// </summary>
    public partial interface IAmazonIoT1ClickDevicesService : IAmazonService, IDisposable
    {

        
        #region  ClaimDevicesByClaimCode


        /// <summary>
        /// Adds device(s) to your account (i.e., claim one or more devices) if and only if you
        /// received a claim code with the device(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClaimDevicesByClaimCode service method.</param>
        /// 
        /// <returns>The response from the ClaimDevicesByClaimCode service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ClaimDevicesByClaimCode">REST API Reference for ClaimDevicesByClaimCode Operation</seealso>
        ClaimDevicesByClaimCodeResponse ClaimDevicesByClaimCode(ClaimDevicesByClaimCodeRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ClaimDevicesByClaimCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ClaimDevicesByClaimCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ClaimDevicesByClaimCode">REST API Reference for ClaimDevicesByClaimCode Operation</seealso>
        Task<ClaimDevicesByClaimCodeResponse> ClaimDevicesByClaimCodeAsync(ClaimDevicesByClaimCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDevice


        /// <summary>
        /// Given a device ID, returns a DescribeDeviceResponse object describing the details
        /// of the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  FinalizeDeviceClaim


        /// <summary>
        /// Given a device ID, finalizes the claim request for the associated device.
        /// 
        /// <note> 
        /// <para>
        /// Claiming a device consists of initiating a claim, then publishing a device event,
        /// and finalizing the claim. For a device of type button, a device event can be published
        /// by simply clicking the device.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FinalizeDeviceClaim service method.</param>
        /// 
        /// <returns>The response from the FinalizeDeviceClaim service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/FinalizeDeviceClaim">REST API Reference for FinalizeDeviceClaim Operation</seealso>
        FinalizeDeviceClaimResponse FinalizeDeviceClaim(FinalizeDeviceClaimRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the FinalizeDeviceClaim operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FinalizeDeviceClaim operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/FinalizeDeviceClaim">REST API Reference for FinalizeDeviceClaim Operation</seealso>
        Task<FinalizeDeviceClaimResponse> FinalizeDeviceClaimAsync(FinalizeDeviceClaimRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeviceMethods


        /// <summary>
        /// Given a device ID, returns the invokable methods associated with the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceMethods service method.</param>
        /// 
        /// <returns>The response from the GetDeviceMethods service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/GetDeviceMethods">REST API Reference for GetDeviceMethods Operation</seealso>
        GetDeviceMethodsResponse GetDeviceMethods(GetDeviceMethodsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceMethods operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceMethods operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/GetDeviceMethods">REST API Reference for GetDeviceMethods Operation</seealso>
        Task<GetDeviceMethodsResponse> GetDeviceMethodsAsync(GetDeviceMethodsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InitiateDeviceClaim


        /// <summary>
        /// Given a device ID, initiates a claim request for the associated device.
        /// 
        /// <note> 
        /// <para>
        /// Claiming a device consists of initiating a claim, then publishing a device event,
        /// and finalizing the claim. For a device of type button, a device event can be published
        /// by simply clicking the device.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateDeviceClaim service method.</param>
        /// 
        /// <returns>The response from the InitiateDeviceClaim service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/InitiateDeviceClaim">REST API Reference for InitiateDeviceClaim Operation</seealso>
        InitiateDeviceClaimResponse InitiateDeviceClaim(InitiateDeviceClaimRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateDeviceClaim operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateDeviceClaim operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/InitiateDeviceClaim">REST API Reference for InitiateDeviceClaim Operation</seealso>
        Task<InitiateDeviceClaimResponse> InitiateDeviceClaimAsync(InitiateDeviceClaimRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  InvokeDeviceMethod


        /// <summary>
        /// Given a device ID, issues a request to invoke a named device method (with possible
        /// parameters). See the "Example POST" code snippet below.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeDeviceMethod service method.</param>
        /// 
        /// <returns>The response from the InvokeDeviceMethod service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.RangeNotSatisfiableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/InvokeDeviceMethod">REST API Reference for InvokeDeviceMethod Operation</seealso>
        InvokeDeviceMethodResponse InvokeDeviceMethod(InvokeDeviceMethodRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the InvokeDeviceMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeDeviceMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/InvokeDeviceMethod">REST API Reference for InvokeDeviceMethod Operation</seealso>
        Task<InvokeDeviceMethodResponse> InvokeDeviceMethodAsync(InvokeDeviceMethodRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDeviceEvents


        /// <summary>
        /// Using a device ID, returns a DeviceEventsResponse object containing an array of events
        /// for the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceEvents service method.</param>
        /// 
        /// <returns>The response from the ListDeviceEvents service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.RangeNotSatisfiableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ListDeviceEvents">REST API Reference for ListDeviceEvents Operation</seealso>
        ListDeviceEventsResponse ListDeviceEvents(ListDeviceEventsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ListDeviceEvents">REST API Reference for ListDeviceEvents Operation</seealso>
        Task<ListDeviceEventsResponse> ListDeviceEventsAsync(ListDeviceEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListDevices


        /// <summary>
        /// Lists the 1-Click compatible devices associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.RangeNotSatisfiableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse ListDevices(ListDevicesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ListDevices">REST API Reference for ListDevices Operation</seealso>
        Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UnclaimDevice


        /// <summary>
        /// Disassociates a device from your AWS account using its device ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnclaimDevice service method.</param>
        /// 
        /// <returns>The response from the UnclaimDevice service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/UnclaimDevice">REST API Reference for UnclaimDevice Operation</seealso>
        UnclaimDeviceResponse UnclaimDevice(UnclaimDeviceRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UnclaimDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnclaimDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/UnclaimDevice">REST API Reference for UnclaimDevice Operation</seealso>
        Task<UnclaimDeviceResponse> UnclaimDeviceAsync(UnclaimDeviceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDeviceState


        /// <summary>
        /// Using a Boolean value (true or false), this operation enables or disables the device
        /// given a device ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceState service method.</param>
        /// 
        /// <returns>The response from the UpdateDeviceState service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/UpdateDeviceState">REST API Reference for UpdateDeviceState Operation</seealso>
        UpdateDeviceStateResponse UpdateDeviceState(UpdateDeviceStateRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/UpdateDeviceState">REST API Reference for UpdateDeviceState Operation</seealso>
        Task<UpdateDeviceStateResponse> UpdateDeviceStateAsync(UpdateDeviceStateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}