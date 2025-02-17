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
 * Do not modify this file. This file is generated from the bedrock-data-automation-runtime-2024-06-13.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BedrockDataAutomationRuntime.Model;

#pragma warning disable CS1570
namespace Amazon.BedrockDataAutomationRuntime
{
    /// <summary>
    /// <para>Interface for accessing BedrockDataAutomationRuntime</para>
    ///
    /// Amazon Bedrock Data Automation Runtime
    /// </summary>
    public partial interface IAmazonBedrockDataAutomationRuntime : IAmazonService, IDisposable
    {




        
        #region  GetDataAutomationStatus


        /// <summary>
        /// API used to get data automation status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationStatus service method.</param>
        /// 
        /// <returns>The response from the GetDataAutomationStatus service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ResourceNotFoundException">
        /// This exception will be thrown when resource provided from customer not found.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/GetDataAutomationStatus">REST API Reference for GetDataAutomationStatus Operation</seealso>
        GetDataAutomationStatusResponse GetDataAutomationStatus(GetDataAutomationStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataAutomationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataAutomationStatus operation on AmazonBedrockDataAutomationRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataAutomationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/GetDataAutomationStatus">REST API Reference for GetDataAutomationStatus Operation</seealso>
        IAsyncResult BeginGetDataAutomationStatus(GetDataAutomationStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataAutomationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataAutomationStatus.</param>
        /// 
        /// <returns>Returns a  GetDataAutomationStatusResult from BedrockDataAutomationRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/GetDataAutomationStatus">REST API Reference for GetDataAutomationStatus Operation</seealso>
        GetDataAutomationStatusResponse EndGetDataAutomationStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  InvokeDataAutomationAsync


        /// <summary>
        /// Async API: Invoke data automation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeDataAutomationAsync service method.</param>
        /// 
        /// <returns>The response from the InvokeDataAutomationAsync service method, as returned by BedrockDataAutomationRuntime.</returns>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.AccessDeniedException">
        /// This exception will be thrown when customer does not have access to API.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.InternalServerException">
        /// This exception is for any internal un-expected service errors.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ServiceQuotaExceededException">
        /// This exception will be thrown when service quota is exceeded.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ThrottlingException">
        /// This exception will be thrown when customer reached API TPS limit.
        /// </exception>
        /// <exception cref="Amazon.BedrockDataAutomationRuntime.Model.ValidationException">
        /// This exception will be thrown when customer provided invalid parameters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/InvokeDataAutomationAsync">REST API Reference for InvokeDataAutomationAsync Operation</seealso>
        InvokeDataAutomationAsyncResponse InvokeDataAutomationAsync(InvokeDataAutomationAsyncRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeDataAutomationAsync operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeDataAutomationAsync operation on AmazonBedrockDataAutomationRuntimeClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInvokeDataAutomationAsync
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/InvokeDataAutomationAsync">REST API Reference for InvokeDataAutomationAsync Operation</seealso>
        IAsyncResult BeginInvokeDataAutomationAsync(InvokeDataAutomationAsyncRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InvokeDataAutomationAsync operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInvokeDataAutomationAsync.</param>
        /// 
        /// <returns>Returns a  InvokeDataAutomationAsyncResult from BedrockDataAutomationRuntime.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/bedrock-data-automation-runtime-2024-06-13/InvokeDataAutomationAsync">REST API Reference for InvokeDataAutomationAsync Operation</seealso>
        InvokeDataAutomationAsyncResponse EndInvokeDataAutomationAsync(IAsyncResult asyncResult);

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