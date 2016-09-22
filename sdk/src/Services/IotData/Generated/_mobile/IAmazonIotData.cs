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

using Amazon.Runtime;
using Amazon.IotData.Model;

namespace Amazon.IotData
{
    /// <summary>
    /// Interface for accessing IotData
    ///
    /// AWS IoT 
    /// <para>
    /// AWS IoT-Data enables secure, bi-directional communication between Internet-connected
    /// things (such as sensors, actuators, embedded devices, or smart appliances) and the
    /// AWS cloud. It implements a broker for applications and things to publish messages
    /// over HTTP (Publish) and retrieve, update, and delete thing shadows. A thing shadow
    /// is a persistent representation of your things and their state in the AWS cloud.
    /// </para>
    /// </summary>
    public partial interface IAmazonIotData : IAmazonService, IDisposable
    {
                
        #region  DeleteThingShadow


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteThingShadow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteThingShadowResponse> DeleteThingShadowAsync(DeleteThingShadowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetThingShadow


        /// <summary>
        /// Initiates the asynchronous execution of the GetThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetThingShadow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetThingShadowResponse> GetThingShadowAsync(GetThingShadowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Publish


        /// <summary>
        /// Initiates the asynchronous execution of the Publish operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Publish operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PublishResponse> PublishAsync(PublishRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateThingShadow


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateThingShadow operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateThingShadow operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateThingShadowResponse> UpdateThingShadowAsync(UpdateThingShadowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}