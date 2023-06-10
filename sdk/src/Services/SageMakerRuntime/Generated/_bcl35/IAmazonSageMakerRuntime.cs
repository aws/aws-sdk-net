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
 * Do not modify this file. This file is generated from the runtime.sagemaker-2017-05-13.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMakerRuntime.Model;

namespace Amazon.SageMakerRuntime
{
    /// <summary>
    /// Interface for accessing SageMakerRuntime
    ///
    /// The Amazon SageMaker runtime API.
    /// </summary>
    public partial interface IAmazonSageMakerRuntime : IAmazonService, IDisposable
    {




        
        #region  InvokeEndpoint


        /// <summary>
        /// After you deploy a model into production using Amazon SageMaker hosting services,
        /// your client applications use this API to get inferences from the model hosted at the
        /// specified endpoint. 
        /// 
        ///  
        /// <para>
        /// For an overview of Amazon SageMaker, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker strips all POST headers except those supported by the API. Amazon
        /// SageMaker might add additional headers. You should not rely on the behavior of headers
        /// outside those enumerated in the request syntax. 
        /// </para>
        ///  
        /// <para>
        /// Calls to <code>InvokeEndpoint</code> are authenticated by using Amazon Web Services
        /// Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// A customer's model containers must respond to requests within 60 seconds. The model
        /// itself can have a maximum processing time of 60 seconds before responding to invocations.
        /// If your model is going to take 50-60 seconds of processing time, the SDK socket timeout
        /// should be set to be 70 seconds.
        /// </para>
        ///  <note> 
        /// <para>
        /// Endpoints are scoped to an individual account, and are not public. The URL does not
        /// contain the account ID, but Amazon SageMaker determines the account ID from the authentication
        /// token that is supplied by the caller.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpoint service method.</param>
        /// 
        /// <returns>The response from the InvokeEndpoint service method, as returned by SageMakerRuntime.</returns>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalDependencyException">
        /// Your request caused an exception with an internal dependency. Contact customer support.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ModelErrorException">
        /// Model (owned by the customer in the container) returned 4xx or 5xx error code.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ModelNotReadyException">
        /// Either a serverless endpoint variant's resources are still being provisioned, or a
        /// multi-model endpoint is still downloading or loading the target model. Wait and try
        /// your request again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ServiceUnavailableException">
        /// The service is unavailable. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ValidationErrorException">
        /// Inspect your request and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpoint">REST API Reference for InvokeEndpoint Operation</seealso>
        InvokeEndpointResponse InvokeEndpoint(InvokeEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpoint operation on AmazonSageMakerRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpoint">REST API Reference for InvokeEndpoint Operation</seealso>
        IAsyncResult BeginInvokeEndpoint(InvokeEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeEndpoint.</param>
        /// 
        /// <returns>Returns a  InvokeEndpointResult from SageMakerRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpoint">REST API Reference for InvokeEndpoint Operation</seealso>
        InvokeEndpointResponse EndInvokeEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeEndpointAsync


        /// <summary>
        /// After you deploy a model into production using Amazon SageMaker hosting services,
        /// your client applications use this API to get inferences from the model hosted at the
        /// specified endpoint in an asynchronous manner.
        /// 
        ///  
        /// <para>
        /// Inference requests sent to this API are enqueued for asynchronous processing. The
        /// processing of the inference request may or may not complete before you receive a response
        /// from this API. The response from this API will not contain the result of the inference
        /// request but contain information about where you can locate it.
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker strips all <code>POST</code> headers except those supported by the
        /// API. Amazon SageMaker might add additional headers. You should not rely on the behavior
        /// of headers outside those enumerated in the request syntax.
        /// </para>
        ///  
        /// <para>
        /// Calls to <code>InvokeEndpointAsync</code> are authenticated by using Amazon Web Services
        /// Signature Version 4. For information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 API Reference</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpointAsync service method.</param>
        /// 
        /// <returns>The response from the InvokeEndpointAsync service method, as returned by SageMakerRuntime.</returns>
        /// <exception cref="Amazon.SageMakerRuntime.Model.InternalFailureException">
        /// An internal failure occurred.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ServiceUnavailableException">
        /// The service is unavailable. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.SageMakerRuntime.Model.ValidationErrorException">
        /// Inspect your request and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpointAsync">REST API Reference for InvokeEndpointAsync Operation</seealso>
        InvokeEndpointAsyncResponse InvokeEndpointAsync(InvokeEndpointAsyncRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeEndpointAsync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeEndpointAsync operation on AmazonSageMakerRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeEndpointAsync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpointAsync">REST API Reference for InvokeEndpointAsync Operation</seealso>
        IAsyncResult BeginInvokeEndpointAsync(InvokeEndpointAsyncRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeEndpointAsync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeEndpointAsync.</param>
        /// 
        /// <returns>Returns a  InvokeEndpointAsyncResult from SageMakerRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/runtime.sagemaker-2017-05-13/InvokeEndpointAsync">REST API Reference for InvokeEndpointAsync Operation</seealso>
        InvokeEndpointAsyncResponse EndInvokeEndpointAsync(IAsyncResult asyncResult);

        #endregion
        
    }
}