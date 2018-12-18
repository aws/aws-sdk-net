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
 * Do not modify this file. This file is generated from the apigatewaymanagementapi-2018-11-29.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ApiGatewayManagementApi.Model;

namespace Amazon.ApiGatewayManagementApi
{
    /// <summary>
    /// Interface for accessing ApiGatewayManagementApi
    ///
    /// The Amazon API Gateway Management API allows you to directly manage runtime aspects
    /// of your deployed APIs. To use it, you must explicitly set the SDK's endpoint to point
    /// to the endpoint of your deployed API. The endpoint will be of the form https://{api-id}.execute-api.{region}.amazonaws.com/{stage},
    /// or will be the endpoint corresponding to your API's custom domain and base path, if
    /// applicable.
    /// </summary>
    public partial interface IAmazonApiGatewayManagementApi : IAmazonService, IDisposable
    {

        
        #region  PostToConnection


        /// <summary>
        /// Sends the provided data to the specified connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostToConnection service method.</param>
        /// 
        /// <returns>The response from the PostToConnection service method, as returned by ApiGatewayManagementApi.</returns>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.ForbiddenException">
        /// The caller is not authorized to invoke this operation.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.GoneException">
        /// The connection with the provided id no longer exists.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.LimitExceededException">
        /// The client is sending more than the allowed number of requests per unit of time.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.PayloadTooLargeException">
        /// The data has exceeded the maximum size allowed.
        /// </exception>
        PostToConnectionResponse PostToConnection(PostToConnectionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PostToConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostToConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PostToConnectionResponse> PostToConnectionAsync(PostToConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}