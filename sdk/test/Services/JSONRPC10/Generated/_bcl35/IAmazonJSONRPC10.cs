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
 * Do not modify this file. This file is generated from the json-rpc-10-2020-07-14.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.JSONRPC10.Model;

#pragma warning disable CS1570
namespace Amazon.JSONRPC10
{
    /// <summary>
    /// <para>Interface for accessing JSONRPC10</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonJSONRPC10 : IAmazonService, IDisposable
    {




        
        #region  EmptyInputAndEmptyOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has an empty input and empty output structure
        /// that reuses the same shape. While this should be rare, code generators must support
        /// this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput service method.</param>
        /// 
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        EmptyInputAndEmptyOutputResponse EmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EmptyInputAndEmptyOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyInputAndEmptyOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        IAsyncResult BeginEmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EmptyInputAndEmptyOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEmptyInputAndEmptyOutput.</param>
        /// 
        /// <returns>Returns a  EmptyInputAndEmptyOutputResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        EmptyInputAndEmptyOutputResponse EndEmptyInputAndEmptyOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  EndpointOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        EndpointOperationResponse EndpointOperation(EndpointOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        IAsyncResult BeginEndpointOperation(EndpointOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointOperation.</param>
        /// 
        /// <returns>Returns a  EndpointOperationResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        EndpointOperationResponse EndEndpointOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  EndpointWithHostLabelOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        EndpointWithHostLabelOperationResponse EndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        IAsyncResult BeginEndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointWithHostLabelOperation.</param>
        /// 
        /// <returns>Returns a  EndpointWithHostLabelOperationResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        EndpointWithHostLabelOperationResponse EndEndpointWithHostLabelOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  GreetingWithErrors


        /// <summary>
        /// This operation has three possible return values:
        /// 
        ///  <ol> <li>A successful response in the form of GreetingWithErrorsOutput</li> <li>An
        /// InvalidGreeting error.</li> <li>A ComplexError error.</li> </ol> 
        /// <para>
        /// Implementations must be able to successfully take a response and properly deserialize
        /// successful and error responses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by JSONRPC10.</returns>
        /// <exception cref="Amazon.JSONRPC10.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.JSONRPC10.Model.FooErrorException">
        /// This error has test cases that test some of the dark corners of Amazon service framework
        /// history. It should only be implemented by clients.
        /// </exception>
        /// <exception cref="Amazon.JSONRPC10.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGreetingWithErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        IAsyncResult BeginGreetingWithErrors(GreetingWithErrorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGreetingWithErrors.</param>
        /// 
        /// <returns>Returns a  GreetingWithErrorsResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        GreetingWithErrorsResponse EndGreetingWithErrors(IAsyncResult asyncResult);

        #endregion
        
        #region  HostWithPathOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// 
        /// <returns>The response from the HostWithPathOperation service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        HostWithPathOperationResponse HostWithPathOperation(HostWithPathOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHostWithPathOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        IAsyncResult BeginHostWithPathOperation(HostWithPathOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHostWithPathOperation.</param>
        /// 
        /// <returns>Returns a  HostWithPathOperationResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        HostWithPathOperationResponse EndHostWithPathOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  JsonUnions


        /// <summary>
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions service method.</param>
        /// 
        /// <returns>The response from the JsonUnions service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        JsonUnionsResponse JsonUnions(JsonUnionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the JsonUnions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonUnions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        IAsyncResult BeginJsonUnions(JsonUnionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  JsonUnions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginJsonUnions.</param>
        /// 
        /// <returns>Returns a  JsonUnionsResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        JsonUnionsResponse EndJsonUnions(IAsyncResult asyncResult);

        #endregion
        
        #region  NoInputAndNoOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output. While this should
        /// be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        NoInputAndNoOutputResponse NoInputAndNoOutput(NoInputAndNoOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NoInputAndNoOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndNoOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        IAsyncResult BeginNoInputAndNoOutput(NoInputAndNoOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NoInputAndNoOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoInputAndNoOutput.</param>
        /// 
        /// <returns>Returns a  NoInputAndNoOutputResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        NoInputAndNoOutputResponse EndNoInputAndNoOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  NoInputAndOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input and the output is empty. While
        /// this should be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndOutput service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        NoInputAndOutputResponse NoInputAndOutput(NoInputAndOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NoInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        IAsyncResult BeginNoInputAndOutput(NoInputAndOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NoInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoInputAndOutput.</param>
        /// 
        /// <returns>Returns a  NoInputAndOutputResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        NoInputAndOutputResponse EndNoInputAndOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  PutWithContentEncoding


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        PutWithContentEncodingResponse PutWithContentEncoding(PutWithContentEncodingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWithContentEncoding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        IAsyncResult BeginPutWithContentEncoding(PutWithContentEncodingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutWithContentEncoding.</param>
        /// 
        /// <returns>Returns a  PutWithContentEncodingResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        PutWithContentEncodingResponse EndPutWithContentEncoding(IAsyncResult asyncResult);

        #endregion
        
        #region  SimpleScalarProperties


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties operation on AmazonJSONRPC10Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleScalarProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        IAsyncResult BeginSimpleScalarProperties(SimpleScalarPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimpleScalarProperties.</param>
        /// 
        /// <returns>Returns a  SimpleScalarPropertiesResult from JSONRPC10.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-rpc-10-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse EndSimpleScalarProperties(IAsyncResult asyncResult);

        #endregion
        
    }
}