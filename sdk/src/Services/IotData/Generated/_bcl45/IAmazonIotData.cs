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
 * Do not modify this file. This file is generated from the iot-data-2015-05-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.IotData.Model;

namespace Amazon.IotData
{
    /// <summary>
    /// Interface for accessing IotData
    ///
    /// AWS IoT (Beta) 
    /// <para>
    /// <b>AWS IoT is considered a beta service as defined in the Service Terms</b>
    /// </para>
    ///  
    /// <para>
    /// AWS IoT-Data enables secure, bi-directional communication between Internet-connected
    /// things (such as sensors, actuators, embedded devices, or smart appliances) and the
    /// AWS cloud. It implements a broker for applications and things to publish messages
    /// over HTTP (Publish) and retrieve, update, and delete thing shadows. A thing shadow
    /// is a persistent representation of your things and their state in the AWS cloud.
    /// </para>
    /// </summary>
    public partial interface IAmazonIotData : IDisposable
    {

        
        #region  DeleteThingShadow


        /// <summary>
        /// Deletes the thing shadow for the specified thing.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_DeleteThingShadow.html">DeleteThingShadow</a>
        /// in the <i>AWS IoT Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingShadow service method.</param>
        /// 
        /// <returns>The response from the DeleteThingShadow service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnsupportedDocumentEncodingException">
        /// The document encoding is not supported.
        /// </exception>
        DeleteThingShadowResponse DeleteThingShadow(DeleteThingShadowRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingShadow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteThingShadowResponse> DeleteThingShadowAsync(DeleteThingShadowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetThingShadow


        /// <summary>
        /// Gets the thing shadow for the specified thing.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_GetThingShadow.html">GetThingShadow</a>
        /// in the <i>AWS IoT Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetThingShadow service method.</param>
        /// 
        /// <returns>The response from the GetThingShadow service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnsupportedDocumentEncodingException">
        /// The document encoding is not supported.
        /// </exception>
        GetThingShadowResponse GetThingShadow(GetThingShadowRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThingShadow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetThingShadowResponse> GetThingShadowAsync(GetThingShadowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Publish


        /// <summary>
        /// Publishes state information.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/protocols.html#http">HTTP
        /// Protocol</a> in the <i>AWS IoT Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Publish service method.</param>
        /// 
        /// <returns>The response from the Publish service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        PublishResponse Publish(PublishRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the Publish operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Publish operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PublishResponse> PublishAsync(PublishRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateThingShadow


        /// <summary>
        /// Updates the thing shadow for the specified thing.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/iot/latest/developerguide/API_UpdateThingShadow.html">UpdateThingShadow</a>
        /// in the <i>AWS IoT Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingShadow service method.</param>
        /// 
        /// <returns>The response from the UpdateThingShadow service method, as returned by IotData.</returns>
        /// <exception cref="Amazon.IotData.Model.ConflictException">
        /// The specified version does not match the version of the document.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InternalFailureException">
        /// An unexpected error has occurred.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.InvalidRequestException">
        /// The request is not valid.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.MethodNotAllowedException">
        /// The specified combination of HTTP verb and URI is not supported.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.RequestEntityTooLargeException">
        /// The payload exceeds the maximum size allowed.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ServiceUnavailableException">
        /// The service is temporarily unavailable.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.ThrottlingException">
        /// The rate exceeds the limit.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnauthorizedException">
        /// You are not authorized to perform this operation.
        /// </exception>
        /// <exception cref="Amazon.IotData.Model.UnsupportedDocumentEncodingException">
        /// The document encoding is not supported.
        /// </exception>
        UpdateThingShadowResponse UpdateThingShadow(UpdateThingShadowRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingShadow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateThingShadowResponse> UpdateThingShadowAsync(UpdateThingShadowRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}