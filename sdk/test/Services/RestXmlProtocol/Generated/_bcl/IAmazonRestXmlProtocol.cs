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
using System.Threading;
using System.Threading.Tasks;
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
        /// This example uses all query string types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllQueryStringTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllQueryStringTypes service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        Task<AllQueryStringTypesResponse> AllQueryStringTypesAsync(AllQueryStringTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The following example serializes a body that uses an XML name, changing the wrapper
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BodyWithXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BodyWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/BodyWithXmlName">REST API Reference for BodyWithXmlName Operation</seealso>
        Task<BodyWithXmlNameResponse> BodyWithXmlNameAsync(BodyWithXmlNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example uses fixed query string params and variable query string params. The
        /// fixed query string parameters and variable parameters must both be serialized (implementations
        /// may need to merge them together).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantAndVariableQueryString service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConstantAndVariableQueryString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        Task<ConstantAndVariableQueryStringResponse> ConstantAndVariableQueryStringAsync(ConstantAndVariableQueryStringRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example uses a constant query string parameters and a label. This simply tests
        /// that labels and query string parameters are compatible. The fixed query string parameter
        /// named &quot;hello&quot; should in no way conflict with the label, <c>{hello}</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantQueryString service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConstantQueryString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        Task<ConstantQueryStringResponse> ConstantQueryStringAsync(ConstantQueryStringRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DatetimeOffsets service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        Task<DatetimeOffsetsResponse> DatetimeOffsetsAsync(DatetimeOffsetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has an empty input and empty output structure
        /// that reuses the same shape. While this should be rare, code generators must support
        /// this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        Task<EmptyInputAndEmptyOutputResponse> EmptyInputAndEmptyOutputAsync(EmptyInputAndEmptyOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        Task<EndpointOperationResponse> EndpointOperationAsync(EndpointOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelHeaderOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelHeaderOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelHeaderOperation">REST API Reference for EndpointWithHostLabelHeaderOperation Operation</seealso>
        Task<EndpointWithHostLabelHeaderOperationResponse> EndpointWithHostLabelHeaderOperationAsync(EndpointWithHostLabelHeaderOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        Task<EndpointWithHostLabelOperationResponse> EndpointWithHostLabelOperationAsync(EndpointWithHostLabelOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Flattened maps
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlattenedXmlMap service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        Task<FlattenedXmlMapResponse> FlattenedXmlMapAsync(FlattenedXmlMapRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Flattened maps with @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        Task<FlattenedXmlMapWithXmlNameResponse> FlattenedXmlMapWithXmlNameAsync(FlattenedXmlMapWithXmlNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Flattened maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        Task<FlattenedXmlMapWithXmlNamespaceResponse> FlattenedXmlMapWithXmlNamespaceAsync(FlattenedXmlMapWithXmlNamespaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        Task<FractionalSecondsResponse> FractionalSecondsAsync(FractionalSecondsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GreetingWithErrors service method, as returned by RestXmlProtocol.</returns>
        /// <exception cref="Amazon.RestXmlProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RestXmlProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        Task<GreetingWithErrorsResponse> GreetingWithErrorsAsync(GreetingWithErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEnumPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpEnumPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        Task<HttpEnumPayloadResponse> HttpEnumPayloadAsync(HttpEnumPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example serializes a blob shape in the payload.
        /// 
        ///  
        /// <para>
        /// In this example, no XML document is synthesized because the payload is not a structure
        /// or a union type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadTraits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadTraits service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        Task<HttpPayloadTraitsResponse> HttpPayloadTraitsAsync(HttpPayloadTraitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The following example serializes a payload that uses an XML name on the member, changing
        /// the wrapper name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithMemberXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithMemberXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithMemberXmlName">REST API Reference for HttpPayloadWithMemberXmlName Operation</seealso>
        Task<HttpPayloadWithMemberXmlNameResponse> HttpPayloadWithMemberXmlNameAsync(HttpPayloadWithMemberXmlNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example serializes a structure in the payload.
        /// 
        ///  
        /// <para>
        /// Note that serializing a structure changes the wrapper element name to match the targeted
        /// structure.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithStructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithStructure service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        Task<HttpPayloadWithStructureResponse> HttpPayloadWithStructureAsync(HttpPayloadWithStructureRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example serializes a union in the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithUnion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithUnion service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        Task<HttpPayloadWithUnionResponse> HttpPayloadWithUnionAsync(HttpPayloadWithUnionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The following example serializes a payload that uses an XML name, changing the wrapper
        /// name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlName">REST API Reference for HttpPayloadWithXmlName Operation</seealso>
        Task<HttpPayloadWithXmlNameResponse> HttpPayloadWithXmlNameAsync(HttpPayloadWithXmlNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The following example serializes a payload that uses an XML namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespace">REST API Reference for HttpPayloadWithXmlNamespace Operation</seealso>
        Task<HttpPayloadWithXmlNamespaceResponse> HttpPayloadWithXmlNamespaceAsync(HttpPayloadWithXmlNamespaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The following example serializes a payload that uses an XML namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithXmlNamespaceAndPrefix service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPayloadWithXmlNamespaceAndPrefix service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPayloadWithXmlNamespaceAndPrefix">REST API Reference for HttpPayloadWithXmlNamespaceAndPrefix Operation</seealso>
        Task<HttpPayloadWithXmlNamespaceAndPrefixResponse> HttpPayloadWithXmlNamespaceAndPrefixAsync(HttpPayloadWithXmlNamespaceAndPrefixRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This examples adds headers to the input of a request and response by prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpPrefixHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        Task<HttpPrefixHeadersResponse> HttpPrefixHeadersAsync(HttpPrefixHeadersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithFloatLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpRequestWithFloatLabels service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        Task<HttpRequestWithFloatLabelsResponse> HttpRequestWithFloatLabelsAsync(HttpRequestWithFloatLabelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithGreedyLabelInPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpRequestWithGreedyLabelInPath service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        Task<HttpRequestWithGreedyLabelInPathResponse> HttpRequestWithGreedyLabelInPathAsync(HttpRequestWithGreedyLabelInPathRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The example tests how requests are serialized when there's no input payload but there
        /// are HTTP labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpRequestWithLabels service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        Task<HttpRequestWithLabelsResponse> HttpRequestWithLabelsAsync(HttpRequestWithLabelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The example tests how requests serialize different timestamp formats in the URI path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabelsAndTimestampFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpRequestWithLabelsAndTimestampFormat service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        Task<HttpRequestWithLabelsAndTimestampFormatResponse> HttpRequestWithLabelsAndTimestampFormatAsync(HttpRequestWithLabelsAndTimestampFormatRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpResponseCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpResponseCode service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        Task<HttpResponseCodeResponse> HttpResponseCodeAsync(HttpResponseCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpStringPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HttpStringPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        Task<HttpStringPayloadResponse> HttpStringPayloadAsync(HttpStringPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example ensures that query string bound request parameters are serialized in
        /// the body of responses if the structure is used in both the request and response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IgnoreQueryParamsInResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IgnoreQueryParamsInResponse service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        Task<IgnoreQueryParamsInResponseResponse> IgnoreQueryParamsInResponseAsync(IgnoreQueryParamsInResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The example tests how requests and responses are serialized when there is no input
        /// or output payload but there are HTTP header bindings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InputAndOutputWithHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InputAndOutputWithHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        Task<InputAndOutputWithHeadersResponse> InputAndOutputWithHeadersAsync(InputAndOutputWithHeadersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NestedXmlMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NestedXmlMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NestedXmlMaps">REST API Reference for NestedXmlMaps Operation</seealso>
        Task<NestedXmlMapsResponse> NestedXmlMapsAsync(NestedXmlMapsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output. While this should
        /// be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        Task<NoInputAndNoOutputResponse> NoInputAndNoOutputAsync(NoInputAndNoOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input and the output is empty. While
        /// this should be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoInputAndOutput service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        Task<NoInputAndOutputResponse> NoInputAndOutputAsync(NoInputAndOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Null and empty headers are not sent over the wire.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NullAndEmptyHeadersClient service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        Task<NullAndEmptyHeadersClientResponse> NullAndEmptyHeadersClientAsync(NullAndEmptyHeadersClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Null and empty headers are not sent over the wire.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NullAndEmptyHeadersServer service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        Task<NullAndEmptyHeadersServerResponse> NullAndEmptyHeadersServerAsync(NullAndEmptyHeadersServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Omits null, but serializes empty string value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OmitsNullSerializesEmptyString service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OmitsNullSerializesEmptyString service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        Task<OmitsNullSerializesEmptyStringResponse> OmitsNullSerializesEmptyStringAsync(OmitsNullSerializesEmptyStringRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        Task<PutWithContentEncodingResponse> PutWithContentEncodingAsync(PutWithContentEncodingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Automatically adds idempotency tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        Task<QueryIdempotencyTokenAutoFillResponse> QueryIdempotencyTokenAutoFillAsync(QueryIdempotencyTokenAutoFillRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryParamsAsStringListMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryParamsAsStringListMap service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        Task<QueryParamsAsStringListMapResponse> QueryParamsAsStringListMapAsync(QueryParamsAsStringListMapRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryPrecedence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryPrecedence service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        Task<QueryPrecedenceResponse> QueryPrecedenceAsync(QueryPrecedenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        Task<SimpleScalarPropertiesResponse> SimpleScalarPropertiesAsync(SimpleScalarPropertiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The example tests how timestamp request and response headers are serialized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TimestampFormatHeaders service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        Task<TimestampFormatHeadersResponse> TimestampFormatHeadersAsync(TimestampFormatHeadersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example serializes an XML attributes on synthesized document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlAttributes service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributes">REST API Reference for XmlAttributes Operation</seealso>
        Task<XmlAttributesResponse> XmlAttributesAsync(XmlAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example serializes an XML attributes on a document targeted by httpPayload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlAttributesOnPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlAttributesOnPayload service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlAttributesOnPayload">REST API Reference for XmlAttributesOnPayload Operation</seealso>
        Task<XmlAttributesOnPayloadResponse> XmlAttributesOnPayloadAsync(XmlAttributesOnPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlBlobs service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        Task<XmlBlobsResponse> XmlBlobsAsync(XmlBlobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyBlobs service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        Task<XmlEmptyBlobsResponse> XmlEmptyBlobsAsync(XmlEmptyBlobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyLists service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        Task<XmlEmptyListsResponse> XmlEmptyListsAsync(XmlEmptyListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        Task<XmlEmptyMapsResponse> XmlEmptyMapsAsync(XmlEmptyMapsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyStrings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyStrings service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEmptyStrings">REST API Reference for XmlEmptyStrings Operation</seealso>
        Task<XmlEmptyStringsResponse> XmlEmptyStringsAsync(XmlEmptyStringsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEnums service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        Task<XmlEnumsResponse> XmlEnumsAsync(XmlEnumsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlIntEnums service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        Task<XmlIntEnumsResponse> XmlIntEnumsAsync(XmlIntEnumsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This test case serializes XML lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal XML lists.</li> <li>Normal XML sets.</li> <li>XML lists of lists.</li>
        /// <li>XML lists with @xmlName on its members</li> <li>Flattened XML lists.</li> <li>Flattened
        /// XML lists with @xmlName.</li> <li>Flattened XML lists with @xmlNamespace.</li> <li>Lists
        /// of structures.</li> <li>Flattened XML list of structures</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlLists service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlLists">REST API Reference for XmlLists Operation</seealso>
        Task<XmlListsResponse> XmlListsAsync(XmlListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlMaps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        Task<XmlMapsResponse> XmlMapsAsync(XmlMapsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlMapsXmlName service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        Task<XmlMapsXmlNameResponse> XmlMapsXmlNameAsync(XmlMapsXmlNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapWithXmlNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlMapWithXmlNamespace service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlMapWithXmlNamespace">REST API Reference for XmlMapWithXmlNamespace Operation</seealso>
        Task<XmlMapWithXmlNamespaceResponse> XmlMapWithXmlNamespaceAsync(XmlMapWithXmlNamespaceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlNamespaces service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        Task<XmlNamespacesResponse> XmlNamespacesAsync(XmlNamespacesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlTimestamps service method, as returned by RestXmlProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-xml-protocol-2019-12-16/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        Task<XmlTimestampsResponse> XmlTimestampsAsync(XmlTimestampsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}