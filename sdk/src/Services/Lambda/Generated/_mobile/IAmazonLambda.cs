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
 * Do not modify this file. This file is generated from the lambda-2014-11-11.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Lambda.Model;

namespace Amazon.Lambda
{
    /// <summary>
    /// Interface for accessing Lambda
    ///
    /// AWS Lambda 
    /// <para>
    /// <b>Overview</b>
    /// </para>
    ///  
    /// <para>
    /// This is the AWS Lambda API Reference. The AWS Lambda Developer Guide provides additional
    /// information. For the service overview, go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/welcome.html">What
    /// is AWS Lambda</a>, and for information about how the service works, go to <a href="http://docs.aws.amazon.com/lambda/latest/dg/lambda-introduction.html">AWS
    /// LambdaL How it Works</a> in the AWS Lambda Developer Guide.
    /// </para>
    /// </summary>
    public partial interface IAmazonLambda : IDisposable
    {
                
        #region  AddEventSource

        /// <summary>
        /// Initiates the asynchronous execution of the AddEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddEventSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddEventSourceResponse> AddEventSourceAsync(AddEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFunction

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteFunctionResponse> DeleteFunctionAsync(DeleteFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetEventSource

        /// <summary>
        /// Initiates the asynchronous execution of the GetEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEventSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetEventSourceResponse> GetEventSourceAsync(GetEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFunction

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetFunctionResponse> GetFunctionAsync(GetFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetFunctionConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFunctionConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetFunctionConfigurationResponse> GetFunctionConfigurationAsync(GetFunctionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InvokeAsync

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeAsync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeAsync operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListEventSources

        /// <summary>
        /// Initiates the asynchronous execution of the ListEventSources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEventSources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListEventSourcesResponse> ListEventSourcesAsync(ListEventSourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListFunctions

        /// <summary>
        /// Initiates the asynchronous execution of the ListFunctions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFunctions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListFunctionsResponse> ListFunctionsAsync(ListFunctionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveEventSource

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveEventSource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveEventSource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveEventSourceResponse> RemoveEventSourceAsync(RemoveEventSourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFunctionConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFunctionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFunctionConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateFunctionConfigurationResponse> UpdateFunctionConfigurationAsync(UpdateFunctionConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UploadFunction

        /// <summary>
        /// Initiates the asynchronous execution of the UploadFunction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadFunction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UploadFunctionResponse> UploadFunctionAsync(UploadFunctionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}