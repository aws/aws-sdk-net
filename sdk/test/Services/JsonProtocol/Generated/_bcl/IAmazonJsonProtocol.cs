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
using System.Threading;
using System.Threading.Tasks;
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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DatetimeOffsets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DatetimeOffsets service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        Task<DatetimeOffsetsResponse> DatetimeOffsetsAsync(DatetimeOffsetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EmptyOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EmptyOperation">REST API Reference for EmptyOperation Operation</seealso>
        Task<EmptyOperationResponse> EmptyOperationAsync(EmptyOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        Task<EndpointOperationResponse> EndpointOperationAsync(EndpointOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        Task<EndpointWithHostLabelOperationResponse> EndpointWithHostLabelOperationAsync(EndpointWithHostLabelOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        Task<FractionalSecondsResponse> FractionalSecondsAsync(FractionalSecondsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GreetingWithErrorsResponse> GreetingWithErrorsAsync(GreetingWithErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HostWithPathOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        Task<HostWithPathOperationResponse> HostWithPathOperationAsync(HostWithPathOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JsonEnums service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonEnums">REST API Reference for JsonEnums Operation</seealso>
        Task<JsonEnumsResponse> JsonEnumsAsync(JsonEnumsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the JsonUnions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the JsonUnions service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/JsonUnions">REST API Reference for JsonUnions Operation</seealso>
        Task<JsonUnionsResponse> JsonUnionsAsync(JsonUnionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the KitchenSinkOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the KitchenSinkOperation service method, as returned by JsonProtocol.</returns>
        /// <exception cref="Amazon.JsonProtocol.Model.ErrorWithMembersException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.JsonProtocol.Model.ErrorWithoutMembersException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/KitchenSinkOperation">REST API Reference for KitchenSinkOperation Operation</seealso>
        Task<KitchenSinkOperationResponse> KitchenSinkOperationAsync(KitchenSinkOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NullOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NullOperation service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/NullOperation">REST API Reference for NullOperation Operation</seealso>
        Task<NullOperationResponse> NullOperationAsync(NullOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OperationWithOptionalInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OperationWithOptionalInputOutput service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/OperationWithOptionalInputOutput">REST API Reference for OperationWithOptionalInputOutput Operation</seealso>
        Task<OperationWithOptionalInputOutputResponse> OperationWithOptionalInputOutputAsync(OperationWithOptionalInputOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// This example serializes an inline document as part of the payload.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAndGetInlineDocuments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAndGetInlineDocuments service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutAndGetInlineDocuments">REST API Reference for PutAndGetInlineDocuments Operation</seealso>
        Task<PutAndGetInlineDocumentsResponse> PutAndGetInlineDocumentsAsync(PutAndGetInlineDocumentsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        Task<PutWithContentEncodingResponse> PutWithContentEncodingAsync(PutWithContentEncodingRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by JsonProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/json-protocol-2018-01-01/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        Task<SimpleScalarPropertiesResponse> SimpleScalarPropertiesAsync(SimpleScalarPropertiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}