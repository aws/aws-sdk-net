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
#if NETSTANDARD13
    [Obsolete("Support for .NET Standard 1.3 is in maintenance mode and will only receive critical bug fixes and security patches. Visit https://docs.aws.amazon.com/sdk-for-net/v3/developer-guide/migration-from-net-standard-1-3.html for further details.")]
#endif
    public partial interface IAmazonApiGatewayManagementApi : IAmazonService, IDisposable
    {
                
        #region  DeleteConnection



        /// <summary>
        /// Delete the connection with the provided id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by ApiGatewayManagementApi.</returns>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.ForbiddenException">
        /// The caller is not authorized to invoke this operation.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.GoneException">
        /// The connection with the provided id no longer exists.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.LimitExceededException">
        /// The client is sending more than the allowed number of requests per unit of time or
        /// the WebSocket client side buffer is full.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetConnection



        /// <summary>
        /// Get information about the connection with the provided id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnection service method, as returned by ApiGatewayManagementApi.</returns>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.ForbiddenException">
        /// The caller is not authorized to invoke this operation.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.GoneException">
        /// The connection with the provided id no longer exists.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.LimitExceededException">
        /// The client is sending more than the allowed number of requests per unit of time or
        /// the WebSocket client side buffer is full.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/GetConnection">REST API Reference for GetConnection Operation</seealso>
        Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PostToConnection



        /// <summary>
        /// Sends the provided data to the specified connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostToConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostToConnection service method, as returned by ApiGatewayManagementApi.</returns>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.ForbiddenException">
        /// The caller is not authorized to invoke this operation.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.GoneException">
        /// The connection with the provided id no longer exists.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.LimitExceededException">
        /// The client is sending more than the allowed number of requests per unit of time or
        /// the WebSocket client side buffer is full.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.PayloadTooLargeException">
        /// The data has exceeded the maximum size allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/PostToConnection">REST API Reference for PostToConnection Operation</seealso>
        Task<PostToConnectionResponse> PostToConnectionAsync(PostToConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}