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




        
        #region  DeleteConnection


        /// <summary>
        /// Delete the connection with the provided id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
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
        DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonApiGatewayManagementApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from ApiGatewayManagementApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConnection


        /// <summary>
        /// Get information about the connection with the provided id.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnection service method.</param>
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
        GetConnectionResponse GetConnection(GetConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnection operation on AmazonApiGatewayManagementApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/GetConnection">REST API Reference for GetConnection Operation</seealso>
        IAsyncResult BeginGetConnection(GetConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnection.</param>
        /// 
        /// <returns>Returns a  GetConnectionResult from ApiGatewayManagementApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/GetConnection">REST API Reference for GetConnection Operation</seealso>
        GetConnectionResponse EndGetConnection(IAsyncResult asyncResult);

        #endregion
        
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
        /// The client is sending more than the allowed number of requests per unit of time or
        /// the WebSocket client side buffer is full.
        /// </exception>
        /// <exception cref="Amazon.ApiGatewayManagementApi.Model.PayloadTooLargeException">
        /// The data has exceeded the maximum size allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/PostToConnection">REST API Reference for PostToConnection Operation</seealso>
        PostToConnectionResponse PostToConnection(PostToConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PostToConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostToConnection operation on AmazonApiGatewayManagementApiClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostToConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/PostToConnection">REST API Reference for PostToConnection Operation</seealso>
        IAsyncResult BeginPostToConnection(PostToConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PostToConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostToConnection.</param>
        /// 
        /// <returns>Returns a  PostToConnectionResult from ApiGatewayManagementApi.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/apigatewaymanagementapi-2018-11-29/PostToConnection">REST API Reference for PostToConnection Operation</seealso>
        PostToConnectionResponse EndPostToConnection(IAsyncResult asyncResult);

        #endregion
        
    }
}