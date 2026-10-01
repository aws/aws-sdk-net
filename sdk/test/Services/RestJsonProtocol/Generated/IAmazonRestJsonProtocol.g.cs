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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.RestJsonProtocol.Model;

#pragma warning disable CS1570

namespace Amazon.RestJsonProtocol
{
    /// <summary>
    /// <para>Interface for accessing RestJsonProtocol</para>
    /// </summary>
    public partial interface IAmazonRestJsonProtocol : IAmazonService, IDisposable
    {
#if NETFRAMEWORK
        /// <summary>
        /// This example uses all query string types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllQueryStringTypes service method.</param>
        /// <returns>The response from the AllQueryStringTypes service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        AllQueryStringTypesResponse AllQueryStringTypes(AllQueryStringTypesRequest request);
#endif

        /// <summary>
        /// This example uses all query string types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllQueryStringTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the AllQueryStringTypes service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/AllQueryStringTypes">REST API Reference for AllQueryStringTypes Operation</seealso>
        Task<AllQueryStringTypesResponse> AllQueryStringTypesAsync(AllQueryStringTypesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example uses fixed query string params and variable query string params. The
        /// fixed query string parameters and variable parameters must both be serialized (implementations
        /// may need to merge them together).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantAndVariableQueryString service method.</param>
        /// <returns>The response from the ConstantAndVariableQueryString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        ConstantAndVariableQueryStringResponse ConstantAndVariableQueryString(ConstantAndVariableQueryStringRequest request);
#endif

        /// <summary>
        /// This example uses fixed query string params and variable query string params. The
        /// fixed query string parameters and variable parameters must both be serialized (implementations
        /// may need to merge them together).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantAndVariableQueryString service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ConstantAndVariableQueryString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantAndVariableQueryString">REST API Reference for ConstantAndVariableQueryString Operation</seealso>
        Task<ConstantAndVariableQueryStringResponse> ConstantAndVariableQueryStringAsync(ConstantAndVariableQueryStringRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example uses a constant query string parameters and a label. This simply tests
        /// that labels and query string parameters are compatible. The fixed query string parameter
        /// named "hello" should in no way conflict with the label, `{hello}`.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantQueryString service method.</param>
        /// <returns>The response from the ConstantQueryString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        ConstantQueryStringResponse ConstantQueryString(ConstantQueryStringRequest request);
#endif

        /// <summary>
        /// This example uses a constant query string parameters and a label. This simply tests
        /// that labels and query string parameters are compatible. The fixed query string parameter
        /// named "hello" should in no way conflict with the label, `{hello}`.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConstantQueryString service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ConstantQueryString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ConstantQueryString">REST API Reference for ConstantQueryString Operation</seealso>
        Task<ConstantQueryStringResponse> ConstantQueryStringAsync(ConstantQueryStringRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The example tests how servers must support requests containing a `Content-Type` header
        /// with parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContentTypeParameters service method.</param>
        /// <returns>The response from the ContentTypeParameters service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
        ContentTypeParametersResponse ContentTypeParameters(ContentTypeParametersRequest request);
#endif

        /// <summary>
        /// The example tests how servers must support requests containing a `Content-Type` header
        /// with parameters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ContentTypeParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ContentTypeParameters service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ContentTypeParameters">REST API Reference for ContentTypeParameters Operation</seealso>
        Task<ContentTypeParametersResponse> ContentTypeParametersAsync(ContentTypeParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// <returns>The response from the DatetimeOffsets service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        DatetimeOffsetsResponse DatetimeOffsets(DatetimeOffsetsRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DatetimeOffsets service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        Task<DatetimeOffsetsResponse> DatetimeOffsetsAsync(DatetimeOffsetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example serializes a document as part of the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentType service method.</param>
        /// <returns>The response from the DocumentType service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentType">REST API Reference for DocumentType Operation</seealso>
        DocumentTypeResponse DocumentType(DocumentTypeRequest request);
#endif

        /// <summary>
        /// This example serializes a document as part of the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DocumentType service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentType">REST API Reference for DocumentType Operation</seealso>
        Task<DocumentTypeResponse> DocumentTypeAsync(DocumentTypeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example serializes documents as the value of maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentTypeAsMapValue service method.</param>
        /// <returns>The response from the DocumentTypeAsMapValue service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsMapValue">REST API Reference for DocumentTypeAsMapValue Operation</seealso>
        DocumentTypeAsMapValueResponse DocumentTypeAsMapValue(DocumentTypeAsMapValueRequest request);
#endif

        /// <summary>
        /// This example serializes documents as the value of maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentTypeAsMapValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DocumentTypeAsMapValue service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsMapValue">REST API Reference for DocumentTypeAsMapValue Operation</seealso>
        Task<DocumentTypeAsMapValueResponse> DocumentTypeAsMapValueAsync(DocumentTypeAsMapValueRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example serializes a document as the entire HTTP payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentTypeAsPayload service method.</param>
        /// <returns>The response from the DocumentTypeAsPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsPayload">REST API Reference for DocumentTypeAsPayload Operation</seealso>
        DocumentTypeAsPayloadResponse DocumentTypeAsPayload(DocumentTypeAsPayloadRequest request);
#endif

        /// <summary>
        /// This example serializes a document as the entire HTTP payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DocumentTypeAsPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DocumentTypeAsPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DocumentTypeAsPayload">REST API Reference for DocumentTypeAsPayload Operation</seealso>
        Task<DocumentTypeAsPayloadResponse> DocumentTypeAsPayloadAsync(DocumentTypeAsPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DuplexStream service method.</param>
        /// <returns>The response from the DuplexStream service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DuplexStream">REST API Reference for DuplexStream Operation</seealso>
        DuplexStreamResponse DuplexStream(DuplexStreamRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DuplexStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DuplexStream service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DuplexStream">REST API Reference for DuplexStream Operation</seealso>
        Task<DuplexStreamResponse> DuplexStreamAsync(DuplexStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DuplexStreamWithInitialMessages service method.</param>
        /// <returns>The response from the DuplexStreamWithInitialMessages service method, as returned by RestJsonProtocol.</returns>
        /// <exception cref="Amazon.RestJsonProtocol.Model.ServiceUnavailableErrorException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DuplexStreamWithInitialMessages">REST API Reference for DuplexStreamWithInitialMessages Operation</seealso>
        DuplexStreamWithInitialMessagesResponse DuplexStreamWithInitialMessages(DuplexStreamWithInitialMessagesRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DuplexStreamWithInitialMessages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the DuplexStreamWithInitialMessages service method, as returned by RestJsonProtocol.</returns>
        /// <exception cref="Amazon.RestJsonProtocol.Model.ServiceUnavailableErrorException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/DuplexStreamWithInitialMessages">REST API Reference for DuplexStreamWithInitialMessages Operation</seealso>
        Task<DuplexStreamWithInitialMessagesResponse> DuplexStreamWithInitialMessagesAsync(DuplexStreamWithInitialMessagesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has an empty input and empty output structure
        /// that reuses the same shape. While this should be rare, code generators must support
        /// this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputAndEmptyOutput service method.</param>
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        EmptyInputAndEmptyOutputResponse EmptyInputAndEmptyOutput(EmptyInputAndEmptyOutputRequest request);
#endif

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
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        Task<EmptyInputAndEmptyOutputResponse> EmptyInputAndEmptyOutputAsync(EmptyInputAndEmptyOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// <returns>The response from the EndpointOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        EndpointOperationResponse EndpointOperation(EndpointOperationRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EndpointOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        Task<EndpointOperationResponse> EndpointOperationAsync(EndpointOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        EndpointWithHostLabelOperationResponse EndpointWithHostLabelOperation(EndpointWithHostLabelOperationRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        Task<EndpointWithHostLabelOperationResponse> EndpointWithHostLabelOperationAsync(EndpointWithHostLabelOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// <returns>The response from the FractionalSeconds service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        FractionalSecondsResponse FractionalSeconds(FractionalSecondsRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the FractionalSeconds service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        Task<FractionalSecondsResponse> FractionalSecondsAsync(FractionalSecondsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This operation has four possible return values: 1. A successful response in the form
        /// of GreetingWithErrorsOutput 2. An InvalidGreeting error. 3. A BadRequest error. 4.
        /// A FooError. Implementations must be able to successfully take a response and properly
        /// (de)serialize successful and error responses based on the the presence of the
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// <returns>The response from the GreetingWithErrors service method, as returned by RestJsonProtocol.</returns>
        /// <exception cref="Amazon.RestJsonProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RestJsonProtocol.Model.FooErrorException">
        /// This error has test cases that test some of the dark corners of Amazon service framework
        /// history. It should only be implemented by clients.
        /// </exception>
        /// <exception cref="Amazon.RestJsonProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request);
#endif

        /// <summary>
        /// This operation has four possible return values: 1. A successful response in the form
        /// of GreetingWithErrorsOutput 2. An InvalidGreeting error. 3. A BadRequest error. 4.
        /// A FooError. Implementations must be able to successfully take a response and properly
        /// (de)serialize successful and error responses based on the the presence of the
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GreetingWithErrors service method, as returned by RestJsonProtocol.</returns>
        /// <exception cref="Amazon.RestJsonProtocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RestJsonProtocol.Model.FooErrorException">
        /// This error has test cases that test some of the dark corners of Amazon service framework
        /// history. It should only be implemented by clients.
        /// </exception>
        /// <exception cref="Amazon.RestJsonProtocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        Task<GreetingWithErrorsResponse> GreetingWithErrorsAsync(GreetingWithErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// <returns>The response from the HostWithPathOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        HostWithPathOperationResponse HostWithPathOperation(HostWithPathOperationRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HostWithPathOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        Task<HostWithPathOperationResponse> HostWithPathOperationAsync(HostWithPathOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example tests httpChecksumRequired trait
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpChecksumRequired service method.</param>
        /// <returns>The response from the HttpChecksumRequired service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpChecksumRequired">REST API Reference for HttpChecksumRequired Operation</seealso>
        HttpChecksumRequiredResponse HttpChecksumRequired(HttpChecksumRequiredRequest request);
#endif

        /// <summary>
        /// This example tests httpChecksumRequired trait
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpChecksumRequired service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpChecksumRequired service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpChecksumRequired">REST API Reference for HttpChecksumRequired Operation</seealso>
        Task<HttpChecksumRequiredResponse> HttpChecksumRequiredAsync(HttpChecksumRequiredRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Clients that perform this test extract all headers from the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEmptyPrefixHeaders service method.</param>
        /// <returns>The response from the HttpEmptyPrefixHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEmptyPrefixHeaders">REST API Reference for HttpEmptyPrefixHeaders Operation</seealso>
        HttpEmptyPrefixHeadersResponse HttpEmptyPrefixHeaders(HttpEmptyPrefixHeadersRequest request);
#endif

        /// <summary>
        /// Clients that perform this test extract all headers from the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEmptyPrefixHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpEmptyPrefixHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEmptyPrefixHeaders">REST API Reference for HttpEmptyPrefixHeaders Operation</seealso>
        Task<HttpEmptyPrefixHeadersResponse> HttpEmptyPrefixHeadersAsync(HttpEmptyPrefixHeadersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEnumPayload service method.</param>
        /// <returns>The response from the HttpEnumPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        HttpEnumPayloadResponse HttpEnumPayload(HttpEnumPayloadRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpEnumPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpEnumPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpEnumPayload">REST API Reference for HttpEnumPayload Operation</seealso>
        Task<HttpEnumPayloadResponse> HttpEnumPayloadAsync(HttpEnumPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example serializes a blob shape in the payload. In this example, no JSON document
        /// is synthesized because the payload is not a structure or a union type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadTraits service method.</param>
        /// <returns>The response from the HttpPayloadTraits service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        HttpPayloadTraitsResponse HttpPayloadTraits(HttpPayloadTraitsRequest request);
#endif

        /// <summary>
        /// This example serializes a blob shape in the payload. In this example, no JSON document
        /// is synthesized because the payload is not a structure or a union type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadTraits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpPayloadTraits service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadTraits">REST API Reference for HttpPayloadTraits Operation</seealso>
        Task<HttpPayloadTraitsResponse> HttpPayloadTraitsAsync(HttpPayloadTraitsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example serializes a structure in the payload. Note that serializing a structure
        /// changes the wrapper element name to match the targeted structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithStructure service method.</param>
        /// <returns>The response from the HttpPayloadWithStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        HttpPayloadWithStructureResponse HttpPayloadWithStructure(HttpPayloadWithStructureRequest request);
#endif

        /// <summary>
        /// This example serializes a structure in the payload. Note that serializing a structure
        /// changes the wrapper element name to match the targeted structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithStructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpPayloadWithStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithStructure">REST API Reference for HttpPayloadWithStructure Operation</seealso>
        Task<HttpPayloadWithStructureResponse> HttpPayloadWithStructureAsync(HttpPayloadWithStructureRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example serializes a union in the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithUnion service method.</param>
        /// <returns>The response from the HttpPayloadWithUnion service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        HttpPayloadWithUnionResponse HttpPayloadWithUnion(HttpPayloadWithUnionRequest request);
#endif

        /// <summary>
        /// This example serializes a union in the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPayloadWithUnion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpPayloadWithUnion service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPayloadWithUnion">REST API Reference for HttpPayloadWithUnion Operation</seealso>
        Task<HttpPayloadWithUnionResponse> HttpPayloadWithUnionAsync(HttpPayloadWithUnionRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This examples adds headers to the input of a request and response by prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeaders service method.</param>
        /// <returns>The response from the HttpPrefixHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        HttpPrefixHeadersResponse HttpPrefixHeaders(HttpPrefixHeadersRequest request);
#endif

        /// <summary>
        /// This examples adds headers to the input of a request and response by prefix.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpPrefixHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeaders">REST API Reference for HttpPrefixHeaders Operation</seealso>
        Task<HttpPrefixHeadersResponse> HttpPrefixHeadersAsync(HttpPrefixHeadersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Clients that perform this test extract all headers from the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeadersInResponse service method.</param>
        /// <returns>The response from the HttpPrefixHeadersInResponse service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeadersInResponse">REST API Reference for HttpPrefixHeadersInResponse Operation</seealso>
        HttpPrefixHeadersInResponseResponse HttpPrefixHeadersInResponse(HttpPrefixHeadersInResponseRequest request);
#endif

        /// <summary>
        /// Clients that perform this test extract all headers from the response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpPrefixHeadersInResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpPrefixHeadersInResponse service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpPrefixHeadersInResponse">REST API Reference for HttpPrefixHeadersInResponse Operation</seealso>
        Task<HttpPrefixHeadersInResponseResponse> HttpPrefixHeadersInResponseAsync(HttpPrefixHeadersInResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example tests httpQueryParams when no other query parameters exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpQueryParamsOnlyOperation service method.</param>
        /// <returns>The response from the HttpQueryParamsOnlyOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpQueryParamsOnlyOperation">REST API Reference for HttpQueryParamsOnlyOperation Operation</seealso>
        HttpQueryParamsOnlyOperationResponse HttpQueryParamsOnlyOperation(HttpQueryParamsOnlyOperationRequest request);
#endif

        /// <summary>
        /// This example tests httpQueryParams when no other query parameters exist.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpQueryParamsOnlyOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpQueryParamsOnlyOperation service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpQueryParamsOnlyOperation">REST API Reference for HttpQueryParamsOnlyOperation Operation</seealso>
        Task<HttpQueryParamsOnlyOperationResponse> HttpQueryParamsOnlyOperationAsync(HttpQueryParamsOnlyOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithFloatLabels service method.</param>
        /// <returns>The response from the HttpRequestWithFloatLabels service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        HttpRequestWithFloatLabelsResponse HttpRequestWithFloatLabels(HttpRequestWithFloatLabelsRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithFloatLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpRequestWithFloatLabels service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithFloatLabels">REST API Reference for HttpRequestWithFloatLabels Operation</seealso>
        Task<HttpRequestWithFloatLabelsResponse> HttpRequestWithFloatLabelsAsync(HttpRequestWithFloatLabelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithGreedyLabelInPath service method.</param>
        /// <returns>The response from the HttpRequestWithGreedyLabelInPath service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        HttpRequestWithGreedyLabelInPathResponse HttpRequestWithGreedyLabelInPath(HttpRequestWithGreedyLabelInPathRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithGreedyLabelInPath service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpRequestWithGreedyLabelInPath service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithGreedyLabelInPath">REST API Reference for HttpRequestWithGreedyLabelInPath Operation</seealso>
        Task<HttpRequestWithGreedyLabelInPathResponse> HttpRequestWithGreedyLabelInPathAsync(HttpRequestWithGreedyLabelInPathRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The example tests how requests are serialized when there's no input payload but there
        /// are HTTP labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabels service method.</param>
        /// <returns>The response from the HttpRequestWithLabels service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        HttpRequestWithLabelsResponse HttpRequestWithLabels(HttpRequestWithLabelsRequest request);
#endif

        /// <summary>
        /// The example tests how requests are serialized when there's no input payload but there
        /// are HTTP labels.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpRequestWithLabels service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabels">REST API Reference for HttpRequestWithLabels Operation</seealso>
        Task<HttpRequestWithLabelsResponse> HttpRequestWithLabelsAsync(HttpRequestWithLabelsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The example tests how requests serialize different timestamp formats in the URI path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabelsAndTimestampFormat service method.</param>
        /// <returns>The response from the HttpRequestWithLabelsAndTimestampFormat service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        HttpRequestWithLabelsAndTimestampFormatResponse HttpRequestWithLabelsAndTimestampFormat(HttpRequestWithLabelsAndTimestampFormatRequest request);
#endif

        /// <summary>
        /// The example tests how requests serialize different timestamp formats in the URI path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithLabelsAndTimestampFormat service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpRequestWithLabelsAndTimestampFormat service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithLabelsAndTimestampFormat">REST API Reference for HttpRequestWithLabelsAndTimestampFormat Operation</seealso>
        Task<HttpRequestWithLabelsAndTimestampFormatResponse> HttpRequestWithLabelsAndTimestampFormatAsync(HttpRequestWithLabelsAndTimestampFormatRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithRegexLiteral service method.</param>
        /// <returns>The response from the HttpRequestWithRegexLiteral service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithRegexLiteral">REST API Reference for HttpRequestWithRegexLiteral Operation</seealso>
        HttpRequestWithRegexLiteralResponse HttpRequestWithRegexLiteral(HttpRequestWithRegexLiteralRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpRequestWithRegexLiteral service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpRequestWithRegexLiteral service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpRequestWithRegexLiteral">REST API Reference for HttpRequestWithRegexLiteral Operation</seealso>
        Task<HttpRequestWithRegexLiteralResponse> HttpRequestWithRegexLiteralAsync(HttpRequestWithRegexLiteralRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpResponseCode service method.</param>
        /// <returns>The response from the HttpResponseCode service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        HttpResponseCodeResponse HttpResponseCode(HttpResponseCodeRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpResponseCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpResponseCode service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpResponseCode">REST API Reference for HttpResponseCode Operation</seealso>
        Task<HttpResponseCodeResponse> HttpResponseCodeAsync(HttpResponseCodeRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpStringPayload service method.</param>
        /// <returns>The response from the HttpStringPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        HttpStringPayloadResponse HttpStringPayload(HttpStringPayloadRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HttpStringPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the HttpStringPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/HttpStringPayload">REST API Reference for HttpStringPayload Operation</seealso>
        Task<HttpStringPayloadResponse> HttpStringPayloadAsync(HttpStringPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example ensures that query string bound request parameters are serialized in
        /// the body of responses if the structure is used in both the request and response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IgnoreQueryParamsInResponse service method.</param>
        /// <returns>The response from the IgnoreQueryParamsInResponse service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        IgnoreQueryParamsInResponseResponse IgnoreQueryParamsInResponse(IgnoreQueryParamsInResponseRequest request);
#endif

        /// <summary>
        /// This example ensures that query string bound request parameters are serialized in
        /// the body of responses if the structure is used in both the request and response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the IgnoreQueryParamsInResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the IgnoreQueryParamsInResponse service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/IgnoreQueryParamsInResponse">REST API Reference for IgnoreQueryParamsInResponse Operation</seealso>
        Task<IgnoreQueryParamsInResponseResponse> IgnoreQueryParamsInResponseAsync(IgnoreQueryParamsInResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The example tests how requests and responses are serialized when there is no input
        /// or output payload but there are HTTP header bindings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InputAndOutputWithHeaders service method.</param>
        /// <returns>The response from the InputAndOutputWithHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        InputAndOutputWithHeadersResponse InputAndOutputWithHeaders(InputAndOutputWithHeadersRequest request);
#endif

        /// <summary>
        /// The example tests how requests and responses are serialized when there is no input
        /// or output payload but there are HTTP header bindings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InputAndOutputWithHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the InputAndOutputWithHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/InputAndOutputWithHeaders">REST API Reference for InputAndOutputWithHeaders Operation</seealso>
        Task<InputAndOutputWithHeadersResponse> InputAndOutputWithHeadersAsync(InputAndOutputWithHeadersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InputStream service method.</param>
        /// <returns>The response from the InputStream service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/InputStream">REST API Reference for InputStream Operation</seealso>
        InputStreamResponse InputStream(InputStreamRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InputStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the InputStream service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/InputStream">REST API Reference for InputStream Operation</seealso>
        Task<InputStreamResponse> InputStreamAsync(InputStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InputStreamWithInitialRequest service method.</param>
        /// <returns>The response from the InputStreamWithInitialRequest service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/InputStreamWithInitialRequest">REST API Reference for InputStreamWithInitialRequest Operation</seealso>
        InputStreamWithInitialRequestResponse InputStreamWithInitialRequest(InputStreamWithInitialRequestRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InputStreamWithInitialRequest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the InputStreamWithInitialRequest service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/InputStreamWithInitialRequest">REST API Reference for InputStreamWithInitialRequest Operation</seealso>
        Task<InputStreamWithInitialRequestResponse> InputStreamWithInitialRequestAsync(InputStreamWithInitialRequestRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonBlobs service method.</param>
        /// <returns>The response from the JsonBlobs service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonBlobs">REST API Reference for JsonBlobs Operation</seealso>
        JsonBlobsResponse JsonBlobs(JsonBlobsRequest request);
#endif

        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonBlobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the JsonBlobs service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonBlobs">REST API Reference for JsonBlobs Operation</seealso>
        Task<JsonBlobsResponse> JsonBlobsAsync(JsonBlobsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonEnums service method.</param>
        /// <returns>The response from the JsonEnums service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        JsonEnumsResponse JsonEnums(JsonEnumsRequest request);
#endif

        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the JsonEnums service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        Task<JsonEnumsResponse> JsonEnumsAsync(JsonEnumsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example serializes intEnums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonIntEnums service method.</param>
        /// <returns>The response from the JsonIntEnums service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonIntEnums">REST API Reference for JsonIntEnums Operation</seealso>
        JsonIntEnumsResponse JsonIntEnums(JsonIntEnumsRequest request);
#endif

        /// <summary>
        /// This example serializes intEnums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonIntEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the JsonIntEnums service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonIntEnums">REST API Reference for JsonIntEnums Operation</seealso>
        Task<JsonIntEnumsResponse> JsonIntEnumsAsync(JsonIntEnumsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This test case serializes JSON lists for the following cases for both input and output:
        /// 1. Normal JSON lists. 2. Normal JSON sets. 3. JSON lists of lists. 4. Lists of structures.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonLists service method.</param>
        /// <returns>The response from the JsonLists service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonLists">REST API Reference for JsonLists Operation</seealso>
        JsonListsResponse JsonLists(JsonListsRequest request);
#endif

        /// <summary>
        /// This test case serializes JSON lists for the following cases for both input and output:
        /// 1. Normal JSON lists. 2. Normal JSON sets. 3. JSON lists of lists. 4. Lists of structures.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the JsonLists service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonLists">REST API Reference for JsonLists Operation</seealso>
        Task<JsonListsResponse> JsonListsAsync(JsonListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonMaps service method.</param>
        /// <returns>The response from the JsonMaps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonMaps">REST API Reference for JsonMaps Operation</seealso>
        JsonMapsResponse JsonMaps(JsonMapsRequest request);
#endif

        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the JsonMaps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonMaps">REST API Reference for JsonMaps Operation</seealso>
        Task<JsonMapsResponse> JsonMapsAsync(JsonMapsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonTimestamps service method.</param>
        /// <returns>The response from the JsonTimestamps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonTimestamps">REST API Reference for JsonTimestamps Operation</seealso>
        JsonTimestampsResponse JsonTimestamps(JsonTimestampsRequest request);
#endif

        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonTimestamps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the JsonTimestamps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonTimestamps">REST API Reference for JsonTimestamps Operation</seealso>
        Task<JsonTimestampsResponse> JsonTimestampsAsync(JsonTimestampsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions service method.</param>
        /// <returns>The response from the JsonUnions service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        JsonUnionsResponse JsonUnions(JsonUnionsRequest request);
#endif

        /// <summary>
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the JsonUnions service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        Task<JsonUnionsResponse> JsonUnionsAsync(JsonUnionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example ensures that mediaType strings are base64 encoded in headers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MediaTypeHeader service method.</param>
        /// <returns>The response from the MediaTypeHeader service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/MediaTypeHeader">REST API Reference for MediaTypeHeader Operation</seealso>
        MediaTypeHeaderResponse MediaTypeHeader(MediaTypeHeaderRequest request);
#endif

        /// <summary>
        /// This example ensures that mediaType strings are base64 encoded in headers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MediaTypeHeader service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the MediaTypeHeader service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/MediaTypeHeader">REST API Reference for MediaTypeHeader Operation</seealso>
        Task<MediaTypeHeaderResponse> MediaTypeHeaderAsync(MediaTypeHeaderRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output. While this should
        /// be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        NoInputAndNoOutputResponse NoInputAndNoOutput(NoInputAndNoOutputRequest request);
#endif

        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input or output. While this should
        /// be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndNoOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        Task<NoInputAndNoOutputResponse> NoInputAndNoOutputAsync(NoInputAndNoOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input and the output is empty. While
        /// this should be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput service method.</param>
        /// <returns>The response from the NoInputAndOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        NoInputAndOutputResponse NoInputAndOutput(NoInputAndOutputRequest request);
#endif

        /// <summary>
        /// The example tests how requests and responses are serialized when there's no request
        /// or response payload because the operation has no input and the output is empty. While
        /// this should be rare, code generators must support this.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputAndOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the NoInputAndOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        Task<NoInputAndOutputResponse> NoInputAndOutputAsync(NoInputAndOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Null headers are not sent over the wire, empty headers are serialized to ""
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersClient service method.</param>
        /// <returns>The response from the NullAndEmptyHeadersClient service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        NullAndEmptyHeadersClientResponse NullAndEmptyHeadersClient(NullAndEmptyHeadersClientRequest request);
#endif

        /// <summary>
        /// Null headers are not sent over the wire, empty headers are serialized to ""
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersClient service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the NullAndEmptyHeadersClient service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersClient">REST API Reference for NullAndEmptyHeadersClient Operation</seealso>
        Task<NullAndEmptyHeadersClientResponse> NullAndEmptyHeadersClientAsync(NullAndEmptyHeadersClientRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Null headers are not sent over the wire, empty headers are serialized to ""
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersServer service method.</param>
        /// <returns>The response from the NullAndEmptyHeadersServer service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        NullAndEmptyHeadersServerResponse NullAndEmptyHeadersServer(NullAndEmptyHeadersServerRequest request);
#endif

        /// <summary>
        /// Null headers are not sent over the wire, empty headers are serialized to ""
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullAndEmptyHeadersServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the NullAndEmptyHeadersServer service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/NullAndEmptyHeadersServer">REST API Reference for NullAndEmptyHeadersServer Operation</seealso>
        Task<NullAndEmptyHeadersServerResponse> NullAndEmptyHeadersServerAsync(NullAndEmptyHeadersServerRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Omits null, but serializes empty string value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OmitsNullSerializesEmptyString service method.</param>
        /// <returns>The response from the OmitsNullSerializesEmptyString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        OmitsNullSerializesEmptyStringResponse OmitsNullSerializesEmptyString(OmitsNullSerializesEmptyStringRequest request);
#endif

        /// <summary>
        /// Omits null, but serializes empty string value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OmitsNullSerializesEmptyString service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the OmitsNullSerializesEmptyString service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsNullSerializesEmptyString">REST API Reference for OmitsNullSerializesEmptyString Operation</seealso>
        Task<OmitsNullSerializesEmptyStringResponse> OmitsNullSerializesEmptyStringAsync(OmitsNullSerializesEmptyStringRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Omits serializing empty lists. Because empty strings are serilized as `Foo=`, empty
        /// lists cannot also be serialized as `Foo=` and instead must be omitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OmitsSerializingEmptyLists service method.</param>
        /// <returns>The response from the OmitsSerializingEmptyLists service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsSerializingEmptyLists">REST API Reference for OmitsSerializingEmptyLists Operation</seealso>
        OmitsSerializingEmptyListsResponse OmitsSerializingEmptyLists(OmitsSerializingEmptyListsRequest request);
#endif

        /// <summary>
        /// Omits serializing empty lists. Because empty strings are serilized as `Foo=`, empty
        /// lists cannot also be serialized as `Foo=` and instead must be omitted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OmitsSerializingEmptyLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the OmitsSerializingEmptyLists service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OmitsSerializingEmptyLists">REST API Reference for OmitsSerializingEmptyLists Operation</seealso>
        Task<OmitsSerializingEmptyListsResponse> OmitsSerializingEmptyListsAsync(OmitsSerializingEmptyListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OutputStream service method.</param>
        /// <returns>The response from the OutputStream service method, as returned by RestJsonProtocol.</returns>
        /// <exception cref="Amazon.RestJsonProtocol.Model.ServiceUnavailableErrorException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OutputStream">REST API Reference for OutputStream Operation</seealso>
        OutputStreamResponse OutputStream(OutputStreamRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OutputStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the OutputStream service method, as returned by RestJsonProtocol.</returns>
        /// <exception cref="Amazon.RestJsonProtocol.Model.ServiceUnavailableErrorException">
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OutputStream">REST API Reference for OutputStream Operation</seealso>
        Task<OutputStreamResponse> OutputStreamAsync(OutputStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OutputStreamWithInitialResponse service method.</param>
        /// <returns>The response from the OutputStreamWithInitialResponse service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OutputStreamWithInitialResponse">REST API Reference for OutputStreamWithInitialResponse Operation</seealso>
        OutputStreamWithInitialResponseResponse OutputStreamWithInitialResponse(OutputStreamWithInitialResponseRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OutputStreamWithInitialResponse service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the OutputStreamWithInitialResponse service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/OutputStreamWithInitialResponse">REST API Reference for OutputStreamWithInitialResponse Operation</seealso>
        Task<OutputStreamWithInitialResponseResponse> OutputStreamWithInitialResponseAsync(OutputStreamWithInitialResponseRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This operation defines a union that uses jsonName on some members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostUnionWithJsonName service method.</param>
        /// <returns>The response from the PostUnionWithJsonName service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PostUnionWithJsonName">REST API Reference for PostUnionWithJsonName Operation</seealso>
        PostUnionWithJsonNameResponse PostUnionWithJsonName(PostUnionWithJsonNameRequest request);
#endif

        /// <summary>
        /// This operation defines a union that uses jsonName on some members.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostUnionWithJsonName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PostUnionWithJsonName service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PostUnionWithJsonName">REST API Reference for PostUnionWithJsonName Operation</seealso>
        Task<PostUnionWithJsonNameResponse> PostUnionWithJsonNameAsync(PostUnionWithJsonNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// <returns>The response from the PutWithContentEncoding service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        PutWithContentEncodingResponse PutWithContentEncoding(PutWithContentEncodingRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the PutWithContentEncoding service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        Task<PutWithContentEncodingResponse> PutWithContentEncodingAsync(PutWithContentEncodingRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Automatically adds idempotency tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill service method.</param>
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        QueryIdempotencyTokenAutoFillResponse QueryIdempotencyTokenAutoFill(QueryIdempotencyTokenAutoFillRequest request);
#endif

        /// <summary>
        /// Automatically adds idempotency tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        Task<QueryIdempotencyTokenAutoFillResponse> QueryIdempotencyTokenAutoFillAsync(QueryIdempotencyTokenAutoFillRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryParamsAsStringListMap service method.</param>
        /// <returns>The response from the QueryParamsAsStringListMap service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        QueryParamsAsStringListMapResponse QueryParamsAsStringListMap(QueryParamsAsStringListMapRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryParamsAsStringListMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the QueryParamsAsStringListMap service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryParamsAsStringListMap">REST API Reference for QueryParamsAsStringListMap Operation</seealso>
        Task<QueryParamsAsStringListMapResponse> QueryParamsAsStringListMapAsync(QueryParamsAsStringListMapRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryPrecedence service method.</param>
        /// <returns>The response from the QueryPrecedence service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        QueryPrecedenceResponse QueryPrecedence(QueryPrecedenceRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryPrecedence service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the QueryPrecedence service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/QueryPrecedence">REST API Reference for QueryPrecedence Operation</seealso>
        Task<QueryPrecedenceResponse> QueryPrecedenceAsync(QueryPrecedenceRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// Recursive shapes
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveShapes service method.</param>
        /// <returns>The response from the RecursiveShapes service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        RecursiveShapesResponse RecursiveShapes(RecursiveShapesRequest request);
#endif

        /// <summary>
        /// Recursive shapes
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveShapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RecursiveShapes service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        Task<RecursiveShapesResponse> RecursiveShapesAsync(RecursiveShapesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResponseCodeHttpFallback service method.</param>
        /// <returns>The response from the ResponseCodeHttpFallback service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ResponseCodeHttpFallback">REST API Reference for ResponseCodeHttpFallback Operation</seealso>
        ResponseCodeHttpFallbackResponse ResponseCodeHttpFallback(ResponseCodeHttpFallbackRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResponseCodeHttpFallback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ResponseCodeHttpFallback service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ResponseCodeHttpFallback">REST API Reference for ResponseCodeHttpFallback Operation</seealso>
        Task<ResponseCodeHttpFallbackResponse> ResponseCodeHttpFallbackAsync(ResponseCodeHttpFallbackRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResponseCodeRequired service method.</param>
        /// <returns>The response from the ResponseCodeRequired service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ResponseCodeRequired">REST API Reference for ResponseCodeRequired Operation</seealso>
        ResponseCodeRequiredResponse ResponseCodeRequired(ResponseCodeRequiredRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResponseCodeRequired service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the ResponseCodeRequired service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/ResponseCodeRequired">REST API Reference for ResponseCodeRequired Operation</seealso>
        Task<ResponseCodeRequiredResponse> ResponseCodeRequiredAsync(ResponseCodeRequiredRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        Task<SimpleScalarPropertiesResponse> SimpleScalarPropertiesAsync(SimpleScalarPropertiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SparseJsonLists service method.</param>
        /// <returns>The response from the SparseJsonLists service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SparseJsonLists">REST API Reference for SparseJsonLists Operation</seealso>
        SparseJsonListsResponse SparseJsonLists(SparseJsonListsRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SparseJsonLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SparseJsonLists service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SparseJsonLists">REST API Reference for SparseJsonLists Operation</seealso>
        Task<SparseJsonListsResponse> SparseJsonListsAsync(SparseJsonListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example tests sparse map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SparseJsonMaps service method.</param>
        /// <returns>The response from the SparseJsonMaps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SparseJsonMaps">REST API Reference for SparseJsonMaps Operation</seealso>
        SparseJsonMapsResponse SparseJsonMaps(SparseJsonMapsRequest request);
#endif

        /// <summary>
        /// This example tests sparse map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SparseJsonMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SparseJsonMaps service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/SparseJsonMaps">REST API Reference for SparseJsonMaps Operation</seealso>
        Task<SparseJsonMapsResponse> SparseJsonMapsAsync(SparseJsonMapsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example operation serializes a structure in the HTTP body. It should ensure Content-Type:
        /// application/json is used in all requests and that an "empty" body is an empty JSON
        /// document ({}).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBodyStructure service method.</param>
        /// <returns>The response from the TestBodyStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestBodyStructure">REST API Reference for TestBodyStructure Operation</seealso>
        TestBodyStructureResponse TestBodyStructure(TestBodyStructureRequest request);
#endif

        /// <summary>
        /// This example operation serializes a structure in the HTTP body. It should ensure Content-Type:
        /// application/json is used in all requests and that an "empty" body is an empty JSON
        /// document ({}).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestBodyStructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TestBodyStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestBodyStructure">REST API Reference for TestBodyStructure Operation</seealso>
        Task<TestBodyStructureResponse> TestBodyStructureAsync(TestBodyStructureRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example GET operation has no input and serializes a request without a HTTP body.
        /// These tests are to ensure we do not attach a body or related headers (Content-Length,
        /// Content-Type) to operations that semantically cannot produce an HTTP body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestGetNoInputNoPayload service method.</param>
        /// <returns>The response from the TestGetNoInputNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestGetNoInputNoPayload">REST API Reference for TestGetNoInputNoPayload Operation</seealso>
        TestGetNoInputNoPayloadResponse TestGetNoInputNoPayload(TestGetNoInputNoPayloadRequest request);
#endif

        /// <summary>
        /// This example GET operation has no input and serializes a request without a HTTP body.
        /// These tests are to ensure we do not attach a body or related headers (Content-Length,
        /// Content-Type) to operations that semantically cannot produce an HTTP body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestGetNoInputNoPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TestGetNoInputNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestGetNoInputNoPayload">REST API Reference for TestGetNoInputNoPayload Operation</seealso>
        Task<TestGetNoInputNoPayloadResponse> TestGetNoInputNoPayloadAsync(TestGetNoInputNoPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example GET operation serializes a request without a modeled HTTP body. These
        /// tests are to ensure we do not attach a body or related headers (Content-Length, Content-Type)
        /// to operations that semantically cannot produce an HTTP body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestGetNoPayload service method.</param>
        /// <returns>The response from the TestGetNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestGetNoPayload">REST API Reference for TestGetNoPayload Operation</seealso>
        TestGetNoPayloadResponse TestGetNoPayload(TestGetNoPayloadRequest request);
#endif

        /// <summary>
        /// This example GET operation serializes a request without a modeled HTTP body. These
        /// tests are to ensure we do not attach a body or related headers (Content-Length, Content-Type)
        /// to operations that semantically cannot produce an HTTP body.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestGetNoPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TestGetNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestGetNoPayload">REST API Reference for TestGetNoPayload Operation</seealso>
        Task<TestGetNoPayloadResponse> TestGetNoPayloadAsync(TestGetNoPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example operation serializes a payload targeting a blob. The Blob shape is not
        /// structured content and we cannot make assumptions about what data will be sent. This
        /// test ensures only a generic "Content-Type: application/octet-stream" header is used,
        /// and that we are not treating an empty body as an empty JSON document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayloadBlob service method.</param>
        /// <returns>The response from the TestPayloadBlob service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadBlob">REST API Reference for TestPayloadBlob Operation</seealso>
        TestPayloadBlobResponse TestPayloadBlob(TestPayloadBlobRequest request);
#endif

        /// <summary>
        /// This example operation serializes a payload targeting a blob. The Blob shape is not
        /// structured content and we cannot make assumptions about what data will be sent. This
        /// test ensures only a generic "Content-Type: application/octet-stream" header is used,
        /// and that we are not treating an empty body as an empty JSON document.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayloadBlob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TestPayloadBlob service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadBlob">REST API Reference for TestPayloadBlob Operation</seealso>
        Task<TestPayloadBlobResponse> TestPayloadBlobAsync(TestPayloadBlobRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example operation serializes a payload targeting a structure. This enforces the
        /// same requirements as TestBodyStructure but with the body specified by the @httpPayload
        /// trait.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayloadStructure service method.</param>
        /// <returns>The response from the TestPayloadStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadStructure">REST API Reference for TestPayloadStructure Operation</seealso>
        TestPayloadStructureResponse TestPayloadStructure(TestPayloadStructureRequest request);
#endif

        /// <summary>
        /// This example operation serializes a payload targeting a structure. This enforces the
        /// same requirements as TestBodyStructure but with the body specified by the @httpPayload
        /// trait.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPayloadStructure service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TestPayloadStructure service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPayloadStructure">REST API Reference for TestPayloadStructure Operation</seealso>
        Task<TestPayloadStructureResponse> TestPayloadStructureAsync(TestPayloadStructureRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example POST operation has no input and serializes a request without a HTTP body.
        /// These tests are to ensure we do not attach a body or related headers (Content-Type)
        /// to a POST operation with no modeled input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPostNoInputNoPayload service method.</param>
        /// <returns>The response from the TestPostNoInputNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPostNoInputNoPayload">REST API Reference for TestPostNoInputNoPayload Operation</seealso>
        TestPostNoInputNoPayloadResponse TestPostNoInputNoPayload(TestPostNoInputNoPayloadRequest request);
#endif

        /// <summary>
        /// This example POST operation has no input and serializes a request without a HTTP body.
        /// These tests are to ensure we do not attach a body or related headers (Content-Type)
        /// to a POST operation with no modeled input.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPostNoInputNoPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TestPostNoInputNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPostNoInputNoPayload">REST API Reference for TestPostNoInputNoPayload Operation</seealso>
        Task<TestPostNoInputNoPayloadResponse> TestPostNoInputNoPayloadAsync(TestPostNoInputNoPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example POST operation serializes a request without a modeled HTTP body. These
        /// tests are to ensure we do not attach a body or related headers (Content-Type) to a
        /// POST operation with no modeled payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPostNoPayload service method.</param>
        /// <returns>The response from the TestPostNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPostNoPayload">REST API Reference for TestPostNoPayload Operation</seealso>
        TestPostNoPayloadResponse TestPostNoPayload(TestPostNoPayloadRequest request);
#endif

        /// <summary>
        /// This example POST operation serializes a request without a modeled HTTP body. These
        /// tests are to ensure we do not attach a body or related headers (Content-Type) to a
        /// POST operation with no modeled payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestPostNoPayload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TestPostNoPayload service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TestPostNoPayload">REST API Reference for TestPostNoPayload Operation</seealso>
        Task<TestPostNoPayloadResponse> TestPostNoPayloadAsync(TestPostNoPayloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This example tests how timestamp request and response headers are serialized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders service method.</param>
        /// <returns>The response from the TimestampFormatHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        TimestampFormatHeadersResponse TimestampFormatHeaders(TimestampFormatHeadersRequest request);
#endif

        /// <summary>
        /// This example tests how timestamp request and response headers are serialized.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TimestampFormatHeaders service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the TimestampFormatHeaders service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/TimestampFormatHeaders">REST API Reference for TimestampFormatHeaders Operation</seealso>
        Task<TimestampFormatHeadersResponse> TimestampFormatHeadersAsync(TimestampFormatHeadersRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This test is similar to NoInputAndNoOutput, but uses explicit Unit types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnitInputAndOutput service method.</param>
        /// <returns>The response from the UnitInputAndOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/UnitInputAndOutput">REST API Reference for UnitInputAndOutput Operation</seealso>
        UnitInputAndOutputResponse UnitInputAndOutput(UnitInputAndOutputRequest request);
#endif

        /// <summary>
        /// This test is similar to NoInputAndNoOutput, but uses explicit Unit types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnitInputAndOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the UnitInputAndOutput service method, as returned by RestJsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rest-json-protocol-2019-12-16/UnitInputAndOutput">REST API Reference for UnitInputAndOutput Operation</seealso>
        Task<UnitInputAndOutputResponse> UnitInputAndOutputAsync(UnitInputAndOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);

#if NET8_0_OR_GREATER
        // Warning CA1033 is issued when the child types can not call the method defined in parent types.
        // In this use case the intended caller is only meant to be the interface as a factory
        // method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRestJsonProtocolConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRestJsonProtocolConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRestJsonProtocolConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRestJsonProtocolConfig to create AmazonRestJsonProtocolClient");
            }

            return awsCredentials == null ?
                    new AmazonRestJsonProtocolClient(serviceClientConfig) :
                    new AmazonRestJsonProtocolClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
