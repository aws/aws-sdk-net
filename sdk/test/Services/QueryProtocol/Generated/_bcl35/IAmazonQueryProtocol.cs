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
 * Do not modify this file. This file is generated from the query-protocol-2020-01-08.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.QueryProtocol.Model;

#pragma warning disable CS1570
namespace Amazon.QueryProtocol
{
    /// <summary>
    /// <para>Interface for accessing QueryProtocol</para>
    ///
    /// A query service that sends query requests and XML responses.
    /// </summary>
    public partial interface IAmazonQueryProtocol : IAmazonService, IDisposable
    {




        
        #region  DatetimeOffsets


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// 
        /// <returns>The response from the DatetimeOffsets service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        DatetimeOffsetsResponse DatetimeOffsets(DatetimeOffsetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DatetimeOffsets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDatetimeOffsets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        IAsyncResult BeginDatetimeOffsets(DatetimeOffsetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DatetimeOffsets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDatetimeOffsets.</param>
        /// 
        /// <returns>Returns a  DatetimeOffsetsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        DatetimeOffsetsResponse EndDatetimeOffsets(IAsyncResult asyncResult);

        #endregion
        
        #region  EmptyInputAndEmptyOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response members.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput service method.</param>
        /// 
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        EmptyInputAndEmptyOutputResponse EmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EmptyInputAndEmptyOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyInputAndEmptyOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        IAsyncResult BeginEmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EmptyInputAndEmptyOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEmptyInputAndEmptyOutput.</param>
        /// 
        /// <returns>Returns a  EmptyInputAndEmptyOutputResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        EmptyInputAndEmptyOutputResponse EndEmptyInputAndEmptyOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  EndpointOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        EndpointOperationResponse EndpointOperation(EndpointOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        IAsyncResult BeginEndpointOperation(EndpointOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointOperation.</param>
        /// 
        /// <returns>Returns a  EndpointOperationResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        EndpointOperationResponse EndEndpointOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  EndpointWithHostLabelOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        EndpointWithHostLabelOperationResponse EndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        IAsyncResult BeginEndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointWithHostLabelOperation.</param>
        /// 
        /// <returns>Returns a  EndpointWithHostLabelOperationResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        EndpointWithHostLabelOperationResponse EndEndpointWithHostLabelOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  FlattenedXmlMap


        /// <summary>
        /// Flattened maps
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMap service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        FlattenedXmlMapResponse FlattenedXmlMap(FlattenedXmlMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        IAsyncResult BeginFlattenedXmlMap(FlattenedXmlMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMap.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        FlattenedXmlMapResponse EndFlattenedXmlMap(IAsyncResult asyncResult);

        #endregion
        
        #region  FlattenedXmlMapWithXmlName


        /// <summary>
        /// Flattened maps with @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        FlattenedXmlMapWithXmlNameResponse FlattenedXmlMapWithXmlName(FlattenedXmlMapWithXmlNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMapWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMapWithXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        IAsyncResult BeginFlattenedXmlMapWithXmlName(FlattenedXmlMapWithXmlNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMapWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMapWithXmlName.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapWithXmlNameResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        FlattenedXmlMapWithXmlNameResponse EndFlattenedXmlMapWithXmlName(IAsyncResult asyncResult);

        #endregion
        
        #region  FlattenedXmlMapWithXmlNamespace


        /// <summary>
        /// Flattened maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlNamespace service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        FlattenedXmlMapWithXmlNamespaceResponse FlattenedXmlMapWithXmlNamespace(FlattenedXmlMapWithXmlNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMapWithXmlNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        IAsyncResult BeginFlattenedXmlMapWithXmlNamespace(FlattenedXmlMapWithXmlNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMapWithXmlNamespace.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapWithXmlNamespaceResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        FlattenedXmlMapWithXmlNamespaceResponse EndFlattenedXmlMapWithXmlNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  FractionalSeconds


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        FractionalSecondsResponse FractionalSeconds(FractionalSecondsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FractionalSeconds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFractionalSeconds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        IAsyncResult BeginFractionalSeconds(FractionalSecondsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FractionalSeconds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFractionalSeconds.</param>
        /// 
        /// <returns>Returns a  FractionalSecondsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        FractionalSecondsResponse EndFractionalSeconds(IAsyncResult asyncResult);

        #endregion
        
        #region  GreetingWithErrors


        /// <summary>
        /// This operation has three possible return values:
        /// 
        ///  <ol> <li>A successful response in the form of GreetingWithErrorsOutput</li> <li>An
        /// InvalidGreeting error.</li> <li>A BadRequest error.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by QueryProtocol.</returns>
        /// <exception cref="Amazon.QueryProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.QueryProtocol.Model.CustomCodeErrorException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.QueryProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGreetingWithErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        IAsyncResult BeginGreetingWithErrors(GreetingWithErrorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGreetingWithErrors.</param>
        /// 
        /// <returns>Returns a  GreetingWithErrorsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        GreetingWithErrorsResponse EndGreetingWithErrors(IAsyncResult asyncResult);

        #endregion
        
        #region  HostWithPathOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// 
        /// <returns>The response from the HostWithPathOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        HostWithPathOperationResponse HostWithPathOperation(HostWithPathOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHostWithPathOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        IAsyncResult BeginHostWithPathOperation(HostWithPathOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HostWithPathOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHostWithPathOperation.</param>
        /// 
        /// <returns>Returns a  HostWithPathOperationResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        HostWithPathOperationResponse EndHostWithPathOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  IgnoresWrappingXmlName


        /// <summary>
        /// The xmlName trait on the output structure is ignored in AWS Query.
        /// 
        ///  
        /// <para>
        /// The wrapping element is always operation name + &quot;Response&quot;, and inside of
        /// that wrapper is another wrapper named operation name + &quot;Result&quot;.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IgnoresWrappingXmlName service method.</param>
        /// 
        /// <returns>The response from the IgnoresWrappingXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/IgnoresWrappingXmlName">REST API Reference for IgnoresWrappingXmlName Operation</seealso>
        IgnoresWrappingXmlNameResponse IgnoresWrappingXmlName(IgnoresWrappingXmlNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the IgnoresWrappingXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IgnoresWrappingXmlName operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIgnoresWrappingXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/IgnoresWrappingXmlName">REST API Reference for IgnoresWrappingXmlName Operation</seealso>
        IAsyncResult BeginIgnoresWrappingXmlName(IgnoresWrappingXmlNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  IgnoresWrappingXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIgnoresWrappingXmlName.</param>
        /// 
        /// <returns>Returns a  IgnoresWrappingXmlNameResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/IgnoresWrappingXmlName">REST API Reference for IgnoresWrappingXmlName Operation</seealso>
        IgnoresWrappingXmlNameResponse EndIgnoresWrappingXmlName(IAsyncResult asyncResult);

        #endregion
        
        #region  NoInputAndNoOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        NoInputAndNoOutputResponse NoInputAndNoOutput(NoInputAndNoOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NoInputAndNoOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndNoOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        IAsyncResult BeginNoInputAndNoOutput(NoInputAndNoOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NoInputAndNoOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoInputAndNoOutput.</param>
        /// 
        /// <returns>Returns a  NoInputAndNoOutputResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        NoInputAndNoOutputResponse EndNoInputAndNoOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  NoInputAndOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// payload or response members.
        /// 
        ///  
        /// <para>
        /// While this should be rare, code generators must support this.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        NoInputAndOutputResponse NoInputAndOutput(NoInputAndOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NoInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        IAsyncResult BeginNoInputAndOutput(NoInputAndOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NoInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoInputAndOutput.</param>
        /// 
        /// <returns>Returns a  NoInputAndOutputResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        NoInputAndOutputResponse EndNoInputAndOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  PutWithContentEncoding


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        PutWithContentEncodingResponse PutWithContentEncoding(PutWithContentEncodingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWithContentEncoding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        IAsyncResult BeginPutWithContentEncoding(PutWithContentEncodingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutWithContentEncoding.</param>
        /// 
        /// <returns>Returns a  PutWithContentEncodingResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        PutWithContentEncodingResponse EndPutWithContentEncoding(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryIdempotencyTokenAutoFill


        /// <summary>
        /// Automatically adds idempotency tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill service method.</param>
        /// 
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        QueryIdempotencyTokenAutoFillResponse QueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryIdempotencyTokenAutoFill operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryIdempotencyTokenAutoFill
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        IAsyncResult BeginQueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryIdempotencyTokenAutoFill operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryIdempotencyTokenAutoFill.</param>
        /// 
        /// <returns>Returns a  QueryIdempotencyTokenAutoFillResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        QueryIdempotencyTokenAutoFillResponse EndQueryIdempotencyTokenAutoFill(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryLists


        /// <summary>
        /// This test serializes simple and complex lists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryLists service method.</param>
        /// 
        /// <returns>The response from the QueryLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryLists">REST API Reference for QueryLists Operation</seealso>
        QueryListsResponse QueryLists(QueryListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryLists operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryLists">REST API Reference for QueryLists Operation</seealso>
        IAsyncResult BeginQueryLists(QueryListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryLists.</param>
        /// 
        /// <returns>Returns a  QueryListsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryLists">REST API Reference for QueryLists Operation</seealso>
        QueryListsResponse EndQueryLists(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryMaps


        /// <summary>
        /// This test serializes simple and complex maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryMaps service method.</param>
        /// 
        /// <returns>The response from the QueryMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryMaps">REST API Reference for QueryMaps Operation</seealso>
        QueryMapsResponse QueryMaps(QueryMapsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryMaps operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryMaps">REST API Reference for QueryMaps Operation</seealso>
        IAsyncResult BeginQueryMaps(QueryMapsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryMaps.</param>
        /// 
        /// <returns>Returns a  QueryMapsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryMaps">REST API Reference for QueryMaps Operation</seealso>
        QueryMapsResponse EndQueryMaps(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryTimestamps


        /// <summary>
        /// This test serializes timestamps.
        /// 
        ///  <ol> <li>Timestamps are serialized as RFC 3339 date-time values by default.</li>
        /// <li>A timestampFormat trait on a member changes the format.</li> <li>A timestampFormat
        /// trait on the shape targeted by the member changes the format.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryTimestamps service method.</param>
        /// 
        /// <returns>The response from the QueryTimestamps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryTimestamps">REST API Reference for QueryTimestamps Operation</seealso>
        QueryTimestampsResponse QueryTimestamps(QueryTimestampsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryTimestamps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryTimestamps operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryTimestamps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryTimestamps">REST API Reference for QueryTimestamps Operation</seealso>
        IAsyncResult BeginQueryTimestamps(QueryTimestampsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryTimestamps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryTimestamps.</param>
        /// 
        /// <returns>Returns a  QueryTimestampsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryTimestamps">REST API Reference for QueryTimestamps Operation</seealso>
        QueryTimestampsResponse EndQueryTimestamps(IAsyncResult asyncResult);

        #endregion
        
        #region  RecursiveXmlShapes


        /// <summary>
        /// Recursive shapes
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveXmlShapes service method.</param>
        /// 
        /// <returns>The response from the RecursiveXmlShapes service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/RecursiveXmlShapes">REST API Reference for RecursiveXmlShapes Operation</seealso>
        RecursiveXmlShapesResponse RecursiveXmlShapes(RecursiveXmlShapesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RecursiveXmlShapes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RecursiveXmlShapes operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRecursiveXmlShapes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/RecursiveXmlShapes">REST API Reference for RecursiveXmlShapes Operation</seealso>
        IAsyncResult BeginRecursiveXmlShapes(RecursiveXmlShapesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RecursiveXmlShapes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRecursiveXmlShapes.</param>
        /// 
        /// <returns>Returns a  RecursiveXmlShapesResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/RecursiveXmlShapes">REST API Reference for RecursiveXmlShapes Operation</seealso>
        RecursiveXmlShapesResponse EndRecursiveXmlShapes(IAsyncResult asyncResult);

        #endregion
        
        #region  SimpleInputParams


        /// <summary>
        /// This test serializes strings, numbers, and boolean values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleInputParams service method.</param>
        /// 
        /// <returns>The response from the SimpleInputParams service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleInputParams">REST API Reference for SimpleInputParams Operation</seealso>
        SimpleInputParamsResponse SimpleInputParams(SimpleInputParamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SimpleInputParams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimpleInputParams operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleInputParams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleInputParams">REST API Reference for SimpleInputParams Operation</seealso>
        IAsyncResult BeginSimpleInputParams(SimpleInputParamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SimpleInputParams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimpleInputParams.</param>
        /// 
        /// <returns>Returns a  SimpleInputParamsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleInputParams">REST API Reference for SimpleInputParams Operation</seealso>
        SimpleInputParamsResponse EndSimpleInputParams(IAsyncResult asyncResult);

        #endregion
        
        #region  SimpleScalarXmlProperties


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarXmlProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarXmlProperties service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleScalarXmlProperties">REST API Reference for SimpleScalarXmlProperties Operation</seealso>
        SimpleScalarXmlPropertiesResponse SimpleScalarXmlProperties(SimpleScalarXmlPropertiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SimpleScalarXmlProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarXmlProperties operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleScalarXmlProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleScalarXmlProperties">REST API Reference for SimpleScalarXmlProperties Operation</seealso>
        IAsyncResult BeginSimpleScalarXmlProperties(SimpleScalarXmlPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SimpleScalarXmlProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimpleScalarXmlProperties.</param>
        /// 
        /// <returns>Returns a  SimpleScalarXmlPropertiesResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleScalarXmlProperties">REST API Reference for SimpleScalarXmlProperties Operation</seealso>
        SimpleScalarXmlPropertiesResponse EndSimpleScalarXmlProperties(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlBlobs


        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs service method.</param>
        /// 
        /// <returns>The response from the XmlBlobs service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        XmlBlobsResponse XmlBlobs(XmlBlobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlBlobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlBlobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        IAsyncResult BeginXmlBlobs(XmlBlobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlBlobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlBlobs.</param>
        /// 
        /// <returns>Returns a  XmlBlobsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        XmlBlobsResponse EndXmlBlobs(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlEmptyBlobs


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyBlobs service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        XmlEmptyBlobsResponse XmlEmptyBlobs(XmlEmptyBlobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyBlobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyBlobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        IAsyncResult BeginXmlEmptyBlobs(XmlEmptyBlobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyBlobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyBlobs.</param>
        /// 
        /// <returns>Returns a  XmlEmptyBlobsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        XmlEmptyBlobsResponse EndXmlEmptyBlobs(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlEmptyLists


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        XmlEmptyListsResponse XmlEmptyLists(XmlEmptyListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        IAsyncResult BeginXmlEmptyLists(XmlEmptyListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyLists.</param>
        /// 
        /// <returns>Returns a  XmlEmptyListsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        XmlEmptyListsResponse EndXmlEmptyLists(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlEmptyMaps


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        XmlEmptyMapsResponse XmlEmptyMaps(XmlEmptyMapsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        IAsyncResult BeginXmlEmptyMaps(XmlEmptyMapsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyMaps.</param>
        /// 
        /// <returns>Returns a  XmlEmptyMapsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        XmlEmptyMapsResponse EndXmlEmptyMaps(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlEnums


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums service method.</param>
        /// 
        /// <returns>The response from the XmlEnums service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        XmlEnumsResponse XmlEnums(XmlEnumsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        IAsyncResult BeginXmlEnums(XmlEnumsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEnums.</param>
        /// 
        /// <returns>Returns a  XmlEnumsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        XmlEnumsResponse EndXmlEnums(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlIntEnums


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums service method.</param>
        /// 
        /// <returns>The response from the XmlIntEnums service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        XmlIntEnumsResponse XmlIntEnums(XmlIntEnumsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlIntEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlIntEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        IAsyncResult BeginXmlIntEnums(XmlIntEnumsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlIntEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlIntEnums.</param>
        /// 
        /// <returns>Returns a  XmlIntEnumsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        XmlIntEnumsResponse EndXmlIntEnums(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlLists


        /// <summary>
        /// This test case serializes XML lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal XML lists.</li> <li>Normal XML sets.</li> <li>XML lists of lists.</li>
        /// <li>XML lists with @xmlName on its members</li> <li>Flattened XML lists.</li> <li>Flattened
        /// XML lists with @xmlName.</li> <li>Lists of structures.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlLists service method.</param>
        /// 
        /// <returns>The response from the XmlLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlLists">REST API Reference for XmlLists Operation</seealso>
        XmlListsResponse XmlLists(XmlListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlLists operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlLists">REST API Reference for XmlLists Operation</seealso>
        IAsyncResult BeginXmlLists(XmlListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlLists.</param>
        /// 
        /// <returns>Returns a  XmlListsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlLists">REST API Reference for XmlLists Operation</seealso>
        XmlListsResponse EndXmlLists(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlMaps


        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps service method.</param>
        /// 
        /// <returns>The response from the XmlMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        XmlMapsResponse XmlMaps(XmlMapsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        IAsyncResult BeginXmlMaps(XmlMapsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlMaps.</param>
        /// 
        /// <returns>Returns a  XmlMapsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        XmlMapsResponse EndXmlMaps(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlMapsXmlName


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName service method.</param>
        /// 
        /// <returns>The response from the XmlMapsXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        XmlMapsXmlNameResponse XmlMapsXmlName(XmlMapsXmlNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlMapsXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlMapsXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        IAsyncResult BeginXmlMapsXmlName(XmlMapsXmlNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlMapsXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlMapsXmlName.</param>
        /// 
        /// <returns>Returns a  XmlMapsXmlNameResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        XmlMapsXmlNameResponse EndXmlMapsXmlName(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlNamespaces


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces service method.</param>
        /// 
        /// <returns>The response from the XmlNamespaces service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        XmlNamespacesResponse XmlNamespaces(XmlNamespacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        IAsyncResult BeginXmlNamespaces(XmlNamespacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlNamespaces.</param>
        /// 
        /// <returns>Returns a  XmlNamespacesResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        XmlNamespacesResponse EndXmlNamespaces(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlTimestamps


        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps service method.</param>
        /// 
        /// <returns>The response from the XmlTimestamps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        XmlTimestampsResponse XmlTimestamps(XmlTimestampsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlTimestamps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps operation on AmazonQueryProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlTimestamps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        IAsyncResult BeginXmlTimestamps(XmlTimestampsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlTimestamps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlTimestamps.</param>
        /// 
        /// <returns>Returns a  XmlTimestampsResult from QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        XmlTimestampsResponse EndXmlTimestamps(IAsyncResult asyncResult);

        #endregion
        
    }
}