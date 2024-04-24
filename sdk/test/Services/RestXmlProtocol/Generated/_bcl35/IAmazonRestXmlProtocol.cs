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
 * Do not modify this file. This file is generated from the rest-xml-protocol-2019-12-16.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RestXmlProtocol.Model;

#pragma warning disable CS1570
namespace Amazon.RestXmlProtocol
{
    /// <summary>
    /// <para>Interface for accessing RestXmlProtocol</para>
    ///
    /// A REST XML service that sends XML requests and responses.
    /// </summary>
    public partial interface IAmazonRestXmlProtocol : IAmazonService, IDisposable
    {




        
        #region  AllQueryStringTypes


        /// <summary>
        /// This example uses all query string types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllQueryStringTypes service method.</param>
        /// 
        /// <returns>The response from the AllQueryStringTypes service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        AllQueryStringTypesResponse AllQueryStringTypes(AllQueryStringTypesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllQueryStringTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllQueryStringTypes operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllQueryStringTypes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        IAsyncResult BeginAllQueryStringTypes(AllQueryStringTypesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AllQueryStringTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllQueryStringTypes.</param>
        /// 
        /// <returns>Returns a  AllQueryStringTypesResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        AllQueryStringTypesResponse EndAllQueryStringTypes(IAsyncResult asyncResult);

        #endregion
        
        #region  BodyWithXmlName


        /// <summary>
        /// The following example serializes a body that uses an XML name, changing the wrapper
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BodyWithXmlName service method.</param>
        /// 
        /// <returns>The response from the BodyWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/BodyWithXmlName">REST API Reference for BodyWithXmlName Operation</seealso>
        BodyWithXmlNameResponse BodyWithXmlName(BodyWithXmlNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BodyWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BodyWithXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBodyWithXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/BodyWithXmlName">REST API Reference for BodyWithXmlName Operation</seealso>
        IAsyncResult BeginBodyWithXmlName(BodyWithXmlNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BodyWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBodyWithXmlName.</param>
        /// 
        /// <returns>Returns a  BodyWithXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/BodyWithXmlName">REST API Reference for BodyWithXmlName Operation</seealso>
        BodyWithXmlNameResponse EndBodyWithXmlName(IAsyncResult asyncResult);

        #endregion
        
        #region  ConstantAndVariableQueryString


        /// <summary>
        /// This example uses fixed query string params and variable query string params. The
        /// fixed query string parameters and variable parameters must both be serialized (implementations
        /// may need to merge them together).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantAndVariableQueryString service method.</param>
        /// 
        /// <returns>The response from the ConstantAndVariableQueryString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        ConstantAndVariableQueryStringResponse ConstantAndVariableQueryString(ConstantAndVariableQueryStringRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConstantAndVariableQueryString operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConstantAndVariableQueryString operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConstantAndVariableQueryString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        IAsyncResult BeginConstantAndVariableQueryString(ConstantAndVariableQueryStringRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConstantAndVariableQueryString operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConstantAndVariableQueryString.</param>
        /// 
        /// <returns>Returns a  ConstantAndVariableQueryStringResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        ConstantAndVariableQueryStringResponse EndConstantAndVariableQueryString(IAsyncResult asyncResult);

        #endregion
        
        #region  ConstantQueryString


        /// <summary>
        /// This example uses a constant query string parameters and a label. This simply tests
        /// that labels and query string parameters are compatible. The fixed query string parameter
        /// named &quot;hello&quot; should in no way conflict with the label, <c>{hello}</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantQueryString service method.</param>
        /// 
        /// <returns>The response from the ConstantQueryString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        ConstantQueryStringResponse ConstantQueryString(ConstantQueryStringRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConstantQueryString operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConstantQueryString operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConstantQueryString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        IAsyncResult BeginConstantQueryString(ConstantQueryStringRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConstantQueryString operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConstantQueryString.</param>
        /// 
        /// <returns>Returns a  ConstantQueryStringResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        ConstantQueryStringResponse EndConstantQueryString(IAsyncResult asyncResult);

        #endregion
        
        #region  DatetimeOffsets


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// 
        /// <returns>The response from the DatetimeOffsets service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        DatetimeOffsetsResponse DatetimeOffsets(DatetimeOffsetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DatetimeOffsets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDatetimeOffsets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        IAsyncResult BeginDatetimeOffsets(DatetimeOffsetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DatetimeOffsets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDatetimeOffsets.</param>
        /// 
        /// <returns>Returns a  DatetimeOffsetsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        DatetimeOffsetsResponse EndDatetimeOffsets(IAsyncResult asyncResult);

        #endregion
        
        #region  EmptyInputAndEmptyOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has an empty input and empty output structure
        /// that reuses the same shape. While this should be rare, code generators must support
        /// this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput service method.</param>
        /// 
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        EmptyInputAndEmptyOutputResponse EmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EmptyInputAndEmptyOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEmptyInputAndEmptyOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        IAsyncResult BeginEmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EmptyInputAndEmptyOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEmptyInputAndEmptyOutput.</param>
        /// 
        /// <returns>Returns a  EmptyInputAndEmptyOutputResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        EmptyInputAndEmptyOutputResponse EndEmptyInputAndEmptyOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  EndpointOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        EndpointOperationResponse EndpointOperation(EndpointOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        IAsyncResult BeginEndpointOperation(EndpointOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointOperation.</param>
        /// 
        /// <returns>Returns a  EndpointOperationResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        EndpointOperationResponse EndEndpointOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  EndpointWithHostLabelHeaderOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelHeaderOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelHeaderOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelHeaderOperation">REST API Reference for EndpointWithHostLabelHeaderOperation Operation</seealso>
        EndpointWithHostLabelHeaderOperationResponse EndpointWithHostLabelHeaderOperation(EndpointWithHostLabelHeaderOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointWithHostLabelHeaderOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelHeaderOperation operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelHeaderOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelHeaderOperation">REST API Reference for EndpointWithHostLabelHeaderOperation Operation</seealso>
        IAsyncResult BeginEndpointWithHostLabelHeaderOperation(EndpointWithHostLabelHeaderOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointWithHostLabelHeaderOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointWithHostLabelHeaderOperation.</param>
        /// 
        /// <returns>Returns a  EndpointWithHostLabelHeaderOperationResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelHeaderOperation">REST API Reference for EndpointWithHostLabelHeaderOperation Operation</seealso>
        EndpointWithHostLabelHeaderOperationResponse EndEndpointWithHostLabelHeaderOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  EndpointWithHostLabelOperation


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        EndpointWithHostLabelOperationResponse EndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEndpointWithHostLabelOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        IAsyncResult BeginEndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EndpointWithHostLabelOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEndpointWithHostLabelOperation.</param>
        /// 
        /// <returns>Returns a  EndpointWithHostLabelOperationResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        EndpointWithHostLabelOperationResponse EndEndpointWithHostLabelOperation(IAsyncResult asyncResult);

        #endregion
        
        #region  FlattenedXmlMap


        /// <summary>
        /// Flattened maps
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMap service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        FlattenedXmlMapResponse FlattenedXmlMap(FlattenedXmlMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        IAsyncResult BeginFlattenedXmlMap(FlattenedXmlMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMap.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        FlattenedXmlMapResponse EndFlattenedXmlMap(IAsyncResult asyncResult);

        #endregion
        
        #region  FlattenedXmlMapWithXmlName


        /// <summary>
        /// Flattened maps with @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        FlattenedXmlMapWithXmlNameResponse FlattenedXmlMapWithXmlName(FlattenedXmlMapWithXmlNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMapWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMapWithXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        IAsyncResult BeginFlattenedXmlMapWithXmlName(FlattenedXmlMapWithXmlNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMapWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMapWithXmlName.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapWithXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        FlattenedXmlMapWithXmlNameResponse EndFlattenedXmlMapWithXmlName(IAsyncResult asyncResult);

        #endregion
        
        #region  FlattenedXmlMapWithXmlNamespace


        /// <summary>
        /// Flattened maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace service method.</param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        FlattenedXmlMapWithXmlNamespaceResponse FlattenedXmlMapWithXmlNamespace(FlattenedXmlMapWithXmlNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FlattenedXmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFlattenedXmlMapWithXmlNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        IAsyncResult BeginFlattenedXmlMapWithXmlNamespace(FlattenedXmlMapWithXmlNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FlattenedXmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFlattenedXmlMapWithXmlNamespace.</param>
        /// 
        /// <returns>Returns a  FlattenedXmlMapWithXmlNamespaceResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        FlattenedXmlMapWithXmlNamespaceResponse EndFlattenedXmlMapWithXmlNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  FractionalSeconds


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        FractionalSecondsResponse FractionalSeconds(FractionalSecondsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the FractionalSeconds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFractionalSeconds
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        IAsyncResult BeginFractionalSeconds(FractionalSecondsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  FractionalSeconds operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFractionalSeconds.</param>
        /// 
        /// <returns>Returns a  FractionalSecondsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        FractionalSecondsResponse EndFractionalSeconds(IAsyncResult asyncResult);

        #endregion
        
        #region  GreetingWithErrors


        /// <summary>
        /// This operation has three possible return values:
        /// 
        ///  <ol> <li>A successful response in the form of GreetingWithErrorsOutput</li> <li>An
        /// InvalidGreeting error.</li> <li>A BadRequest error.</li> </ol> 
        /// <para>
        /// Implementations must be able to successfully take a response and properly (de)serialize
        /// successful and error responses based on the the presence of the
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by RestXmlProtocol.</returns>
        /// <exception cref="Amazon.RestXmlProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RestXmlProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGreetingWithErrors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        IAsyncResult BeginGreetingWithErrors(GreetingWithErrorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GreetingWithErrors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGreetingWithErrors.</param>
        /// 
        /// <returns>Returns a  GreetingWithErrorsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        GreetingWithErrorsResponse EndGreetingWithErrors(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpEnumPayload


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEnumPayload service method.</param>
        /// 
        /// <returns>The response from the HttpEnumPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        HttpEnumPayloadResponse HttpEnumPayload(HttpEnumPayloadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpEnumPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpEnumPayload operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpEnumPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        IAsyncResult BeginHttpEnumPayload(HttpEnumPayloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpEnumPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpEnumPayload.</param>
        /// 
        /// <returns>Returns a  HttpEnumPayloadResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        HttpEnumPayloadResponse EndHttpEnumPayload(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpPayloadTraits


        /// <summary>
        /// This example serializes a blob shape in the payload.
        /// 
        ///  
        /// <para>
        /// In this example, no XML document is synthesized because the payload is not a structure
        /// or a union type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadTraits service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadTraits service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        HttpPayloadTraitsResponse HttpPayloadTraits(HttpPayloadTraitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadTraits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadTraits operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadTraits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        IAsyncResult BeginHttpPayloadTraits(HttpPayloadTraitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadTraits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadTraits.</param>
        /// 
        /// <returns>Returns a  HttpPayloadTraitsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        HttpPayloadTraitsResponse EndHttpPayloadTraits(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpPayloadWithMemberXmlName


        /// <summary>
        /// The following example serializes a payload that uses an XML name on the member, changing
        /// the wrapper name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithMemberXmlName service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithMemberXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithMemberXmlName">REST API Reference for HttpPayloadWithMemberXmlName Operation</seealso>
        HttpPayloadWithMemberXmlNameResponse HttpPayloadWithMemberXmlName(HttpPayloadWithMemberXmlNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithMemberXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithMemberXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithMemberXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithMemberXmlName">REST API Reference for HttpPayloadWithMemberXmlName Operation</seealso>
        IAsyncResult BeginHttpPayloadWithMemberXmlName(HttpPayloadWithMemberXmlNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithMemberXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithMemberXmlName.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithMemberXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithMemberXmlName">REST API Reference for HttpPayloadWithMemberXmlName Operation</seealso>
        HttpPayloadWithMemberXmlNameResponse EndHttpPayloadWithMemberXmlName(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpPayloadWithStructure


        /// <summary>
        /// This example serializes a structure in the payload.
        /// 
        ///  
        /// <para>
        /// Note that serializing a structure changes the wrapper element name to match the targeted
        /// structure.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithStructure service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithStructure service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        HttpPayloadWithStructureResponse HttpPayloadWithStructure(HttpPayloadWithStructureRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithStructure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithStructure operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithStructure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        IAsyncResult BeginHttpPayloadWithStructure(HttpPayloadWithStructureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithStructure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithStructure.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithStructureResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        HttpPayloadWithStructureResponse EndHttpPayloadWithStructure(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpPayloadWithUnion


        /// <summary>
        /// This example serializes a union in the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithUnion service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithUnion service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        HttpPayloadWithUnionResponse HttpPayloadWithUnion(HttpPayloadWithUnionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithUnion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithUnion operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithUnion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        IAsyncResult BeginHttpPayloadWithUnion(HttpPayloadWithUnionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithUnion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithUnion.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithUnionResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        HttpPayloadWithUnionResponse EndHttpPayloadWithUnion(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpPayloadWithXmlName


        /// <summary>
        /// The following example serializes a payload that uses an XML name, changing the wrapper
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlName service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlName">REST API Reference for HttpPayloadWithXmlName Operation</seealso>
        HttpPayloadWithXmlNameResponse HttpPayloadWithXmlName(HttpPayloadWithXmlNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlName">REST API Reference for HttpPayloadWithXmlName Operation</seealso>
        IAsyncResult BeginHttpPayloadWithXmlName(HttpPayloadWithXmlNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithXmlName.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlName">REST API Reference for HttpPayloadWithXmlName Operation</seealso>
        HttpPayloadWithXmlNameResponse EndHttpPayloadWithXmlName(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpPayloadWithXmlNamespace


        /// <summary>
        /// The following example serializes a payload that uses an XML namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespace service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespace">REST API Reference for HttpPayloadWithXmlNamespace Operation</seealso>
        HttpPayloadWithXmlNamespaceResponse HttpPayloadWithXmlNamespace(HttpPayloadWithXmlNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespace operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithXmlNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespace">REST API Reference for HttpPayloadWithXmlNamespace Operation</seealso>
        IAsyncResult BeginHttpPayloadWithXmlNamespace(HttpPayloadWithXmlNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithXmlNamespace.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithXmlNamespaceResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespace">REST API Reference for HttpPayloadWithXmlNamespace Operation</seealso>
        HttpPayloadWithXmlNamespaceResponse EndHttpPayloadWithXmlNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpPayloadWithXmlNamespaceAndPrefix


        /// <summary>
        /// The following example serializes a payload that uses an XML namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespaceAndPrefix service method.</param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlNamespaceAndPrefix service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespaceAndPrefix">REST API Reference for HttpPayloadWithXmlNamespaceAndPrefix Operation</seealso>
        HttpPayloadWithXmlNamespaceAndPrefixResponse HttpPayloadWithXmlNamespaceAndPrefix(HttpPayloadWithXmlNamespaceAndPrefixRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPayloadWithXmlNamespaceAndPrefix operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespaceAndPrefix operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPayloadWithXmlNamespaceAndPrefix
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespaceAndPrefix">REST API Reference for HttpPayloadWithXmlNamespaceAndPrefix Operation</seealso>
        IAsyncResult BeginHttpPayloadWithXmlNamespaceAndPrefix(HttpPayloadWithXmlNamespaceAndPrefixRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPayloadWithXmlNamespaceAndPrefix operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPayloadWithXmlNamespaceAndPrefix.</param>
        /// 
        /// <returns>Returns a  HttpPayloadWithXmlNamespaceAndPrefixResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespaceAndPrefix">REST API Reference for HttpPayloadWithXmlNamespaceAndPrefix Operation</seealso>
        HttpPayloadWithXmlNamespaceAndPrefixResponse EndHttpPayloadWithXmlNamespaceAndPrefix(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpPrefixHeaders


        /// <summary>
        /// This examples adds headers to the input of a request and response by prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeaders service method.</param>
        /// 
        /// <returns>The response from the HttpPrefixHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        HttpPrefixHeadersResponse HttpPrefixHeaders(HttpPrefixHeadersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpPrefixHeaders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeaders operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpPrefixHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        IAsyncResult BeginHttpPrefixHeaders(HttpPrefixHeadersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpPrefixHeaders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpPrefixHeaders.</param>
        /// 
        /// <returns>Returns a  HttpPrefixHeadersResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        HttpPrefixHeadersResponse EndHttpPrefixHeaders(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpRequestWithFloatLabels


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithFloatLabels service method.</param>
        /// 
        /// <returns>The response from the HttpRequestWithFloatLabels service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        HttpRequestWithFloatLabelsResponse HttpRequestWithFloatLabels(HttpRequestWithFloatLabelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpRequestWithFloatLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithFloatLabels operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithFloatLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        IAsyncResult BeginHttpRequestWithFloatLabels(HttpRequestWithFloatLabelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpRequestWithFloatLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpRequestWithFloatLabels.</param>
        /// 
        /// <returns>Returns a  HttpRequestWithFloatLabelsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        HttpRequestWithFloatLabelsResponse EndHttpRequestWithFloatLabels(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpRequestWithGreedyLabelInPath


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithGreedyLabelInPath service method.</param>
        /// 
        /// <returns>The response from the HttpRequestWithGreedyLabelInPath service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        HttpRequestWithGreedyLabelInPathResponse HttpRequestWithGreedyLabelInPath(HttpRequestWithGreedyLabelInPathRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpRequestWithGreedyLabelInPath operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithGreedyLabelInPath operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithGreedyLabelInPath
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        IAsyncResult BeginHttpRequestWithGreedyLabelInPath(HttpRequestWithGreedyLabelInPathRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpRequestWithGreedyLabelInPath operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpRequestWithGreedyLabelInPath.</param>
        /// 
        /// <returns>Returns a  HttpRequestWithGreedyLabelInPathResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        HttpRequestWithGreedyLabelInPathResponse EndHttpRequestWithGreedyLabelInPath(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpRequestWithLabels


        /// <summary>
        /// The example tests how requests are serialized when there's no input payload but there
        /// are HTTP labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabels service method.</param>
        /// 
        /// <returns>The response from the HttpRequestWithLabels service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        HttpRequestWithLabelsResponse HttpRequestWithLabels(HttpRequestWithLabelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpRequestWithLabels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabels operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithLabels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        IAsyncResult BeginHttpRequestWithLabels(HttpRequestWithLabelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpRequestWithLabels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpRequestWithLabels.</param>
        /// 
        /// <returns>Returns a  HttpRequestWithLabelsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        HttpRequestWithLabelsResponse EndHttpRequestWithLabels(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpRequestWithLabelsAndTimestampFormat


        /// <summary>
        /// The example tests how requests serialize different timestamp formats in the URI path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabelsAndTimestampFormat service method.</param>
        /// 
        /// <returns>The response from the HttpRequestWithLabelsAndTimestampFormat service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        HttpRequestWithLabelsAndTimestampFormatResponse HttpRequestWithLabelsAndTimestampFormat(HttpRequestWithLabelsAndTimestampFormatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpRequestWithLabelsAndTimestampFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabelsAndTimestampFormat operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpRequestWithLabelsAndTimestampFormat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        IAsyncResult BeginHttpRequestWithLabelsAndTimestampFormat(HttpRequestWithLabelsAndTimestampFormatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpRequestWithLabelsAndTimestampFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpRequestWithLabelsAndTimestampFormat.</param>
        /// 
        /// <returns>Returns a  HttpRequestWithLabelsAndTimestampFormatResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        HttpRequestWithLabelsAndTimestampFormatResponse EndHttpRequestWithLabelsAndTimestampFormat(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpResponseCode


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpResponseCode service method.</param>
        /// 
        /// <returns>The response from the HttpResponseCode service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        HttpResponseCodeResponse HttpResponseCode(HttpResponseCodeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpResponseCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpResponseCode operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpResponseCode
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        IAsyncResult BeginHttpResponseCode(HttpResponseCodeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpResponseCode operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpResponseCode.</param>
        /// 
        /// <returns>Returns a  HttpResponseCodeResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        HttpResponseCodeResponse EndHttpResponseCode(IAsyncResult asyncResult);

        #endregion
        
        #region  HttpStringPayload


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpStringPayload service method.</param>
        /// 
        /// <returns>The response from the HttpStringPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        HttpStringPayloadResponse HttpStringPayload(HttpStringPayloadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the HttpStringPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HttpStringPayload operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndHttpStringPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        IAsyncResult BeginHttpStringPayload(HttpStringPayloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  HttpStringPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginHttpStringPayload.</param>
        /// 
        /// <returns>Returns a  HttpStringPayloadResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        HttpStringPayloadResponse EndHttpStringPayload(IAsyncResult asyncResult);

        #endregion
        
        #region  IgnoreQueryParamsInResponse


        /// <summary>
        /// This example ensures that query string bound request parameters are serialized in
        /// the body of responses if the structure is used in both the request and response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IgnoreQueryParamsInResponse service method.</param>
        /// 
        /// <returns>The response from the IgnoreQueryParamsInResponse service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        IgnoreQueryParamsInResponseResponse IgnoreQueryParamsInResponse(IgnoreQueryParamsInResponseRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the IgnoreQueryParamsInResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the IgnoreQueryParamsInResponse operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndIgnoreQueryParamsInResponse
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        IAsyncResult BeginIgnoreQueryParamsInResponse(IgnoreQueryParamsInResponseRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  IgnoreQueryParamsInResponse operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginIgnoreQueryParamsInResponse.</param>
        /// 
        /// <returns>Returns a  IgnoreQueryParamsInResponseResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        IgnoreQueryParamsInResponseResponse EndIgnoreQueryParamsInResponse(IAsyncResult asyncResult);

        #endregion
        
        #region  InputAndOutputWithHeaders


        /// <summary>
        /// The example tests how requests and responses are serialized when there is no input
        /// or output payload but there are HTTP header bindings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InputAndOutputWithHeaders service method.</param>
        /// 
        /// <returns>The response from the InputAndOutputWithHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        InputAndOutputWithHeadersResponse InputAndOutputWithHeaders(InputAndOutputWithHeadersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InputAndOutputWithHeaders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InputAndOutputWithHeaders operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInputAndOutputWithHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        IAsyncResult BeginInputAndOutputWithHeaders(InputAndOutputWithHeadersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InputAndOutputWithHeaders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInputAndOutputWithHeaders.</param>
        /// 
        /// <returns>Returns a  InputAndOutputWithHeadersResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        InputAndOutputWithHeadersResponse EndInputAndOutputWithHeaders(IAsyncResult asyncResult);

        #endregion
        
        #region  NestedXmlMaps


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NestedXmlMaps service method.</param>
        /// 
        /// <returns>The response from the NestedXmlMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMaps">REST API Reference for NestedXmlMaps Operation</seealso>
        NestedXmlMapsResponse NestedXmlMaps(NestedXmlMapsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NestedXmlMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NestedXmlMaps operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNestedXmlMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMaps">REST API Reference for NestedXmlMaps Operation</seealso>
        IAsyncResult BeginNestedXmlMaps(NestedXmlMapsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NestedXmlMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNestedXmlMaps.</param>
        /// 
        /// <returns>Returns a  NestedXmlMapsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMaps">REST API Reference for NestedXmlMaps Operation</seealso>
        NestedXmlMapsResponse EndNestedXmlMaps(IAsyncResult asyncResult);

        #endregion
        
        #region  NoInputAndNoOutput


        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output. While this should
        /// be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        NoInputAndNoOutputResponse NoInputAndNoOutput(NoInputAndNoOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NoInputAndNoOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndNoOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        IAsyncResult BeginNoInputAndNoOutput(NoInputAndNoOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NoInputAndNoOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoInputAndNoOutput.</param>
        /// 
        /// <returns>Returns a  NoInputAndNoOutputResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
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
        /// <returns>The response from the NoInputAndOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        NoInputAndOutputResponse NoInputAndOutput(NoInputAndOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NoInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNoInputAndOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        IAsyncResult BeginNoInputAndOutput(NoInputAndOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NoInputAndOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNoInputAndOutput.</param>
        /// 
        /// <returns>Returns a  NoInputAndOutputResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        NoInputAndOutputResponse EndNoInputAndOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  NullAndEmptyHeadersClient


        /// <summary>
        /// Null and empty headers are not sent over the wire.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersClient service method.</param>
        /// 
        /// <returns>The response from the NullAndEmptyHeadersClient service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        NullAndEmptyHeadersClientResponse NullAndEmptyHeadersClient(NullAndEmptyHeadersClientRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NullAndEmptyHeadersClient operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersClient operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNullAndEmptyHeadersClient
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        IAsyncResult BeginNullAndEmptyHeadersClient(NullAndEmptyHeadersClientRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NullAndEmptyHeadersClient operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNullAndEmptyHeadersClient.</param>
        /// 
        /// <returns>Returns a  NullAndEmptyHeadersClientResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        NullAndEmptyHeadersClientResponse EndNullAndEmptyHeadersClient(IAsyncResult asyncResult);

        #endregion
        
        #region  NullAndEmptyHeadersServer


        /// <summary>
        /// Null and empty headers are not sent over the wire.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersServer service method.</param>
        /// 
        /// <returns>The response from the NullAndEmptyHeadersServer service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        NullAndEmptyHeadersServerResponse NullAndEmptyHeadersServer(NullAndEmptyHeadersServerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the NullAndEmptyHeadersServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersServer operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNullAndEmptyHeadersServer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        IAsyncResult BeginNullAndEmptyHeadersServer(NullAndEmptyHeadersServerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  NullAndEmptyHeadersServer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNullAndEmptyHeadersServer.</param>
        /// 
        /// <returns>Returns a  NullAndEmptyHeadersServerResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        NullAndEmptyHeadersServerResponse EndNullAndEmptyHeadersServer(IAsyncResult asyncResult);

        #endregion
        
        #region  OmitsNullSerializesEmptyString


        /// <summary>
        /// Omits null, but serializes empty string value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OmitsNullSerializesEmptyString service method.</param>
        /// 
        /// <returns>The response from the OmitsNullSerializesEmptyString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        OmitsNullSerializesEmptyStringResponse OmitsNullSerializesEmptyString(OmitsNullSerializesEmptyStringRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the OmitsNullSerializesEmptyString operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OmitsNullSerializesEmptyString operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOmitsNullSerializesEmptyString
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        IAsyncResult BeginOmitsNullSerializesEmptyString(OmitsNullSerializesEmptyStringRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  OmitsNullSerializesEmptyString operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOmitsNullSerializesEmptyString.</param>
        /// 
        /// <returns>Returns a  OmitsNullSerializesEmptyStringResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        OmitsNullSerializesEmptyStringResponse EndOmitsNullSerializesEmptyString(IAsyncResult asyncResult);

        #endregion
        
        #region  PutWithContentEncoding


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        PutWithContentEncodingResponse PutWithContentEncoding(PutWithContentEncodingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutWithContentEncoding
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        IAsyncResult BeginPutWithContentEncoding(PutWithContentEncodingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutWithContentEncoding operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutWithContentEncoding.</param>
        /// 
        /// <returns>Returns a  PutWithContentEncodingResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        PutWithContentEncodingResponse EndPutWithContentEncoding(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryIdempotencyTokenAutoFill


        /// <summary>
        /// Automatically adds idempotency tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill service method.</param>
        /// 
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        QueryIdempotencyTokenAutoFillResponse QueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryIdempotencyTokenAutoFill operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryIdempotencyTokenAutoFill
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        IAsyncResult BeginQueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryIdempotencyTokenAutoFill operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryIdempotencyTokenAutoFill.</param>
        /// 
        /// <returns>Returns a  QueryIdempotencyTokenAutoFillResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        QueryIdempotencyTokenAutoFillResponse EndQueryIdempotencyTokenAutoFill(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryParamsAsStringListMap


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryParamsAsStringListMap service method.</param>
        /// 
        /// <returns>The response from the QueryParamsAsStringListMap service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        QueryParamsAsStringListMapResponse QueryParamsAsStringListMap(QueryParamsAsStringListMapRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryParamsAsStringListMap operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryParamsAsStringListMap operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryParamsAsStringListMap
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        IAsyncResult BeginQueryParamsAsStringListMap(QueryParamsAsStringListMapRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryParamsAsStringListMap operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryParamsAsStringListMap.</param>
        /// 
        /// <returns>Returns a  QueryParamsAsStringListMapResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        QueryParamsAsStringListMapResponse EndQueryParamsAsStringListMap(IAsyncResult asyncResult);

        #endregion
        
        #region  QueryPrecedence


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryPrecedence service method.</param>
        /// 
        /// <returns>The response from the QueryPrecedence service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        QueryPrecedenceResponse QueryPrecedence(QueryPrecedenceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the QueryPrecedence operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the QueryPrecedence operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndQueryPrecedence
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        IAsyncResult BeginQueryPrecedence(QueryPrecedenceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  QueryPrecedence operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginQueryPrecedence.</param>
        /// 
        /// <returns>Returns a  QueryPrecedenceResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        QueryPrecedenceResponse EndQueryPrecedence(IAsyncResult asyncResult);

        #endregion
        
        #region  SimpleScalarProperties


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSimpleScalarProperties
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        IAsyncResult BeginSimpleScalarProperties(SimpleScalarPropertiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SimpleScalarProperties operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSimpleScalarProperties.</param>
        /// 
        /// <returns>Returns a  SimpleScalarPropertiesResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse EndSimpleScalarProperties(IAsyncResult asyncResult);

        #endregion
        
        #region  TimestampFormatHeaders


        /// <summary>
        /// The example tests how timestamp request and response headers are serialized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders service method.</param>
        /// 
        /// <returns>The response from the TimestampFormatHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        TimestampFormatHeadersResponse TimestampFormatHeaders(TimestampFormatHeadersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TimestampFormatHeaders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTimestampFormatHeaders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        IAsyncResult BeginTimestampFormatHeaders(TimestampFormatHeadersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TimestampFormatHeaders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTimestampFormatHeaders.</param>
        /// 
        /// <returns>Returns a  TimestampFormatHeadersResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        TimestampFormatHeadersResponse EndTimestampFormatHeaders(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlAttributes


        /// <summary>
        /// This example serializes an XML attributes on synthesized document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributes service method.</param>
        /// 
        /// <returns>The response from the XmlAttributes service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributes">REST API Reference for XmlAttributes Operation</seealso>
        XmlAttributesResponse XmlAttributes(XmlAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributes operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributes">REST API Reference for XmlAttributes Operation</seealso>
        IAsyncResult BeginXmlAttributes(XmlAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlAttributes.</param>
        /// 
        /// <returns>Returns a  XmlAttributesResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributes">REST API Reference for XmlAttributes Operation</seealso>
        XmlAttributesResponse EndXmlAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlAttributesOnPayload


        /// <summary>
        /// This example serializes an XML attributes on a document targeted by httpPayload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributesOnPayload service method.</param>
        /// 
        /// <returns>The response from the XmlAttributesOnPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributesOnPayload">REST API Reference for XmlAttributesOnPayload Operation</seealso>
        XmlAttributesOnPayloadResponse XmlAttributesOnPayload(XmlAttributesOnPayloadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlAttributesOnPayload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributesOnPayload operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlAttributesOnPayload
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributesOnPayload">REST API Reference for XmlAttributesOnPayload Operation</seealso>
        IAsyncResult BeginXmlAttributesOnPayload(XmlAttributesOnPayloadRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlAttributesOnPayload operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlAttributesOnPayload.</param>
        /// 
        /// <returns>Returns a  XmlAttributesOnPayloadResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributesOnPayload">REST API Reference for XmlAttributesOnPayload Operation</seealso>
        XmlAttributesOnPayloadResponse EndXmlAttributesOnPayload(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlBlobs


        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs service method.</param>
        /// 
        /// <returns>The response from the XmlBlobs service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        XmlBlobsResponse XmlBlobs(XmlBlobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlBlobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlBlobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        IAsyncResult BeginXmlBlobs(XmlBlobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlBlobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlBlobs.</param>
        /// 
        /// <returns>Returns a  XmlBlobsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        XmlBlobsResponse EndXmlBlobs(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlEmptyBlobs


        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyBlobs service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        XmlEmptyBlobsResponse XmlEmptyBlobs(XmlEmptyBlobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyBlobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyBlobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        IAsyncResult BeginXmlEmptyBlobs(XmlEmptyBlobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyBlobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyBlobs.</param>
        /// 
        /// <returns>Returns a  XmlEmptyBlobsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        XmlEmptyBlobsResponse EndXmlEmptyBlobs(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlEmptyLists


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyLists service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        XmlEmptyListsResponse XmlEmptyLists(XmlEmptyListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        IAsyncResult BeginXmlEmptyLists(XmlEmptyListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyLists.</param>
        /// 
        /// <returns>Returns a  XmlEmptyListsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        XmlEmptyListsResponse EndXmlEmptyLists(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlEmptyMaps


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        XmlEmptyMapsResponse XmlEmptyMaps(XmlEmptyMapsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        IAsyncResult BeginXmlEmptyMaps(XmlEmptyMapsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyMaps.</param>
        /// 
        /// <returns>Returns a  XmlEmptyMapsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        XmlEmptyMapsResponse EndXmlEmptyMaps(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlEmptyStrings


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyStrings service method.</param>
        /// 
        /// <returns>The response from the XmlEmptyStrings service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyStrings">REST API Reference for XmlEmptyStrings Operation</seealso>
        XmlEmptyStringsResponse XmlEmptyStrings(XmlEmptyStringsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEmptyStrings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyStrings operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEmptyStrings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyStrings">REST API Reference for XmlEmptyStrings Operation</seealso>
        IAsyncResult BeginXmlEmptyStrings(XmlEmptyStringsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEmptyStrings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEmptyStrings.</param>
        /// 
        /// <returns>Returns a  XmlEmptyStringsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyStrings">REST API Reference for XmlEmptyStrings Operation</seealso>
        XmlEmptyStringsResponse EndXmlEmptyStrings(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlEnums


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums service method.</param>
        /// 
        /// <returns>The response from the XmlEnums service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        XmlEnumsResponse XmlEnums(XmlEnumsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        IAsyncResult BeginXmlEnums(XmlEnumsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlEnums.</param>
        /// 
        /// <returns>Returns a  XmlEnumsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        XmlEnumsResponse EndXmlEnums(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlIntEnums


        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums service method.</param>
        /// 
        /// <returns>The response from the XmlIntEnums service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        XmlIntEnumsResponse XmlIntEnums(XmlIntEnumsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlIntEnums operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlIntEnums
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        IAsyncResult BeginXmlIntEnums(XmlIntEnumsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlIntEnums operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlIntEnums.</param>
        /// 
        /// <returns>Returns a  XmlIntEnumsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        XmlIntEnumsResponse EndXmlIntEnums(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlLists


        /// <summary>
        /// This test case serializes XML lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal XML lists.</li> <li>Normal XML sets.</li> <li>XML lists of lists.</li>
        /// <li>XML lists with @xmlName on its members</li> <li>Flattened XML lists.</li> <li>Flattened
        /// XML lists with @xmlName.</li> <li>Flattened XML lists with @xmlNamespace.</li> <li>Lists
        /// of structures.</li> <li>Flattened XML list of structures</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlLists service method.</param>
        /// 
        /// <returns>The response from the XmlLists service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlLists">REST API Reference for XmlLists Operation</seealso>
        XmlListsResponse XmlLists(XmlListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlLists operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlLists">REST API Reference for XmlLists Operation</seealso>
        IAsyncResult BeginXmlLists(XmlListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlLists.</param>
        /// 
        /// <returns>Returns a  XmlListsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlLists">REST API Reference for XmlLists Operation</seealso>
        XmlListsResponse EndXmlLists(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlMaps


        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps service method.</param>
        /// 
        /// <returns>The response from the XmlMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        XmlMapsResponse XmlMaps(XmlMapsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlMaps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlMaps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        IAsyncResult BeginXmlMaps(XmlMapsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlMaps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlMaps.</param>
        /// 
        /// <returns>Returns a  XmlMapsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        XmlMapsResponse EndXmlMaps(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlMapsXmlName


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName service method.</param>
        /// 
        /// <returns>The response from the XmlMapsXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        XmlMapsXmlNameResponse XmlMapsXmlName(XmlMapsXmlNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlMapsXmlName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlMapsXmlName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        IAsyncResult BeginXmlMapsXmlName(XmlMapsXmlNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlMapsXmlName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlMapsXmlName.</param>
        /// 
        /// <returns>Returns a  XmlMapsXmlNameResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        XmlMapsXmlNameResponse EndXmlMapsXmlName(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlMapWithXmlNamespace


        /// <summary>
        /// Maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapWithXmlNamespace service method.</param>
        /// 
        /// <returns>The response from the XmlMapWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapWithXmlNamespace">REST API Reference for XmlMapWithXmlNamespace Operation</seealso>
        XmlMapWithXmlNamespaceResponse XmlMapWithXmlNamespace(XmlMapWithXmlNamespaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlMapWithXmlNamespace operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlMapWithXmlNamespace
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapWithXmlNamespace">REST API Reference for XmlMapWithXmlNamespace Operation</seealso>
        IAsyncResult BeginXmlMapWithXmlNamespace(XmlMapWithXmlNamespaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlMapWithXmlNamespace operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlMapWithXmlNamespace.</param>
        /// 
        /// <returns>Returns a  XmlMapWithXmlNamespaceResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapWithXmlNamespace">REST API Reference for XmlMapWithXmlNamespace Operation</seealso>
        XmlMapWithXmlNamespaceResponse EndXmlMapWithXmlNamespace(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlNamespaces


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces service method.</param>
        /// 
        /// <returns>The response from the XmlNamespaces service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        XmlNamespacesResponse XmlNamespaces(XmlNamespacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlNamespaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlNamespaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        IAsyncResult BeginXmlNamespaces(XmlNamespacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlNamespaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlNamespaces.</param>
        /// 
        /// <returns>Returns a  XmlNamespacesResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        XmlNamespacesResponse EndXmlNamespaces(IAsyncResult asyncResult);

        #endregion
        
        #region  XmlTimestamps


        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps service method.</param>
        /// 
        /// <returns>The response from the XmlTimestamps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        XmlTimestampsResponse XmlTimestamps(XmlTimestampsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the XmlTimestamps operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps operation on AmazonRestXmlProtocolClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndXmlTimestamps
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        IAsyncResult BeginXmlTimestamps(XmlTimestampsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  XmlTimestamps operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginXmlTimestamps.</param>
        /// 
        /// <returns>Returns a  XmlTimestampsResult from RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        XmlTimestampsResponse EndXmlTimestamps(IAsyncResult asyncResult);

        #endregion
        
    }
}