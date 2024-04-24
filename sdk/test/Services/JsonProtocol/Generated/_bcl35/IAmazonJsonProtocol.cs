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
 * Do not modify this file. This file is generated from the json-protocol-2018-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.JsonProtocol.Model;

#pragma warning disable CS1570
namespace Amazon.JsonProtocol
{
    /// <summary>
    /// <para>Interface for accessing JsonProtocol</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonJsonProtocol : IAmazonService, IDisposable
    {




        
        #region  DatetimeOffsets


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// 
        /// <returns>The response from the DatetimeOffsets service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        DatetimeOffsetsResponse DatetimeOffsets(DatetimeOffsetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DatetimeOffsets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDatetimeOffsets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        IAsyncResult BeginDatetimeOffsets(DatetimeOffsetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DatetimeOffsets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDatetimeOffsets.</param>
        /// 
        /// <returns>Returns a  DatetimeOffsetsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        DatetimeOffsetsResponse EndDatetimeOffsets(IAsyncResult asyncResult);

        #endregion
        
        #region  EmptyOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyOperation service method.</param>
        /// 
        /// <returns>The response from the EmptyOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EmptyOperation">REST API Reference for EmptyOperation Operation</seealso>
        EmptyOperationResponse EmptyOperation(EmptyOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EmptyOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EmptyOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EmptyOperation">REST API Reference for EmptyOperation Operation</seealso>
        IAsyncResult BeginEmptyOperation(EmptyOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EmptyOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEmptyOperation.</param>
        /// 
        /// <returns>Returns a  EmptyOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EmptyOperation">REST API Reference for EmptyOperation Operation</seealso>
        EmptyOperationResponse EndEmptyOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  EndpointOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        EndpointOperationResponse EndpointOperation(EndpointOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        IAsyncResult BeginEndpointOperation(EndpointOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointOperation.</param>
        /// 
        /// <returns>Returns a  EndpointOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        EndpointOperationResponse EndEndpointOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  EndpointWithHostLabelOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        EndpointWithHostLabelOperationResponse EndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        IAsyncResult BeginEndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointWithHostLabelOperation.</param>
        /// 
        /// <returns>Returns a  EndpointWithHostLabelOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        EndpointWithHostLabelOperationResponse EndEndpointWithHostLabelOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  FractionalSeconds


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        FractionalSecondsResponse FractionalSeconds(FractionalSecondsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FractionalSeconds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFractionalSeconds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        IAsyncResult BeginFractionalSeconds(FractionalSecondsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FractionalSeconds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFractionalSeconds.</param>
        /// 
        /// <returns>Returns a  FractionalSecondsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        FractionalSecondsResponse EndFractionalSeconds(IAsyncResult asyncResult);

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
        /// <returns>The response from the GreetingWithErrors service method, as returned by JsonProtocol.</returns>
        /// <exception cref="Amazon.JsonProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.JsonProtocol.Model.FooErrorException">
        /// This error has test cases that test some of the dark corners of Amazon service framework
        /// history. It should only be implemented by clients.
        /// </exception>
        /// <exception cref="Amazon.JsonProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGreetingWithErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        IAsyncResult BeginGreetingWithErrors(GreetingWithErrorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGreetingWithErrors.</param>
        /// 
        /// <returns>Returns a  GreetingWithErrorsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        GreetingWithErrorsResponse EndGreetingWithErrors(IAsyncResult asyncResult);

        #endregion
        
        #region  HostWithPathOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// 
        /// <returns>The response from the HostWithPathOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        HostWithPathOperationResponse HostWithPathOperation(HostWithPathOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHostWithPathOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        IAsyncResult BeginHostWithPathOperation(HostWithPathOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHostWithPathOperation.</param>
        /// 
        /// <returns>Returns a  HostWithPathOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        HostWithPathOperationResponse EndHostWithPathOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  JsonEnums


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonEnums service method.</param>
        /// 
        /// <returns>The response from the JsonEnums service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        JsonEnumsResponse JsonEnums(JsonEnumsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the JsonEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonEnums operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        IAsyncResult BeginJsonEnums(JsonEnumsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  JsonEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginJsonEnums.</param>
        /// 
        /// <returns>Returns a  JsonEnumsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        JsonEnumsResponse EndJsonEnums(IAsyncResult asyncResult);

        #endregion
        
        #region  JsonUnions


        /// <summary>
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions service method.</param>
        /// 
        /// <returns>The response from the JsonUnions service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        JsonUnionsResponse JsonUnions(JsonUnionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the JsonUnions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndJsonUnions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        IAsyncResult BeginJsonUnions(JsonUnionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  JsonUnions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginJsonUnions.</param>
        /// 
        /// <returns>Returns a  JsonUnionsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        JsonUnionsResponse EndJsonUnions(IAsyncResult asyncResult);

        #endregion
        
        #region  KitchenSinkOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the KitchenSinkOperation service method.</param>
        /// 
        /// <returns>The response from the KitchenSinkOperation service method, as returned by JsonProtocol.</returns>
        /// <exception cref="Amazon.JsonProtocol.Model.ErrorWithMembersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.JsonProtocol.Model.ErrorWithoutMembersException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/KitchenSinkOperation">REST API Reference for KitchenSinkOperation Operation</seealso>
        KitchenSinkOperationResponse KitchenSinkOperation(KitchenSinkOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the KitchenSinkOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the KitchenSinkOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndKitchenSinkOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/KitchenSinkOperation">REST API Reference for KitchenSinkOperation Operation</seealso>
        IAsyncResult BeginKitchenSinkOperation(KitchenSinkOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  KitchenSinkOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginKitchenSinkOperation.</param>
        /// 
        /// <returns>Returns a  KitchenSinkOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/KitchenSinkOperation">REST API Reference for KitchenSinkOperation Operation</seealso>
        KitchenSinkOperationResponse EndKitchenSinkOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  NullOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullOperation service method.</param>
        /// 
        /// <returns>The response from the NullOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/NullOperation">REST API Reference for NullOperation Operation</seealso>
        NullOperationResponse NullOperation(NullOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NullOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NullOperation operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNullOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/NullOperation">REST API Reference for NullOperation Operation</seealso>
        IAsyncResult BeginNullOperation(NullOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NullOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNullOperation.</param>
        /// 
        /// <returns>Returns a  NullOperationResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/NullOperation">REST API Reference for NullOperation Operation</seealso>
        NullOperationResponse EndNullOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  OperationWithOptionalInputOutput


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OperationWithOptionalInputOutput service method.</param>
        /// 
        /// <returns>The response from the OperationWithOptionalInputOutput service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/OperationWithOptionalInputOutput">REST API Reference for OperationWithOptionalInputOutput Operation</seealso>
        OperationWithOptionalInputOutputResponse OperationWithOptionalInputOutput(OperationWithOptionalInputOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the OperationWithOptionalInputOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OperationWithOptionalInputOutput operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOperationWithOptionalInputOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/OperationWithOptionalInputOutput">REST API Reference for OperationWithOptionalInputOutput Operation</seealso>
        IAsyncResult BeginOperationWithOptionalInputOutput(OperationWithOptionalInputOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  OperationWithOptionalInputOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOperationWithOptionalInputOutput.</param>
        /// 
        /// <returns>Returns a  OperationWithOptionalInputOutputResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/OperationWithOptionalInputOutput">REST API Reference for OperationWithOptionalInputOutput Operation</seealso>
        OperationWithOptionalInputOutputResponse EndOperationWithOptionalInputOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAndGetInlineDocuments


        /// <summary>
        /// This example serializes an inline document as part of the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAndGetInlineDocuments service method.</param>
        /// 
        /// <returns>The response from the PutAndGetInlineDocuments service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutAndGetInlineDocuments">REST API Reference for PutAndGetInlineDocuments Operation</seealso>
        PutAndGetInlineDocumentsResponse PutAndGetInlineDocuments(PutAndGetInlineDocumentsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAndGetInlineDocuments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAndGetInlineDocuments operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAndGetInlineDocuments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutAndGetInlineDocuments">REST API Reference for PutAndGetInlineDocuments Operation</seealso>
        IAsyncResult BeginPutAndGetInlineDocuments(PutAndGetInlineDocumentsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAndGetInlineDocuments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAndGetInlineDocuments.</param>
        /// 
        /// <returns>Returns a  PutAndGetInlineDocumentsResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutAndGetInlineDocuments">REST API Reference for PutAndGetInlineDocuments Operation</seealso>
        PutAndGetInlineDocumentsResponse EndPutAndGetInlineDocuments(IAsyncResult asyncResult);

        #endregion
        
        #region  PutWithContentEncoding


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        PutWithContentEncodingResponse PutWithContentEncoding(PutWithContentEncodingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWithContentEncoding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        IAsyncResult BeginPutWithContentEncoding(PutWithContentEncodingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutWithContentEncoding.</param>
        /// 
        /// <returns>Returns a  PutWithContentEncodingResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        PutWithContentEncodingResponse EndPutWithContentEncoding(IAsyncResult asyncResult);

        #endregion
        
        #region  SimpleScalarProperties


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties operation on AmazonJsonProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleScalarProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        IAsyncResult BeginSimpleScalarProperties(SimpleScalarPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimpleScalarProperties.</param>
        /// 
        /// <returns>Returns a  SimpleScalarPropertiesResult from JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse EndSimpleScalarProperties(IAsyncResult asyncResult);

        #endregion
        
    }
}