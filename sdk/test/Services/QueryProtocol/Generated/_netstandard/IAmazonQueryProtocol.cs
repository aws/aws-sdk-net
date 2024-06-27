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
using System.Threading;
using System.Threading.Tasks;
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DatetimeOffsets service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/DatetimeOffsets">REST API Reference for DatetimeOffsets Operation</seealso>
        Task<DatetimeOffsetsResponse> DatetimeOffsetsAsync(DatetimeOffsetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EmptyInputAndEmptyOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EmptyInputAndEmptyOutput">REST API Reference for EmptyInputAndEmptyOutput Operation</seealso>
        Task<EmptyInputAndEmptyOutputResponse> EmptyInputAndEmptyOutputAsync(EmptyInputAndEmptyOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EndpointOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndpointOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointOperation">REST API Reference for EndpointOperation Operation</seealso>
        Task<EndpointOperationResponse> EndpointOperationAsync(EndpointOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EndpointWithHostLabelOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EndpointWithHostLabelOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EndpointWithHostLabelOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/EndpointWithHostLabelOperation">REST API Reference for EndpointWithHostLabelOperation Operation</seealso>
        Task<EndpointWithHostLabelOperationResponse> EndpointWithHostLabelOperationAsync(EndpointWithHostLabelOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  FlattenedXmlMap



        /// <summary>
        /// Flattened maps
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMap service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlattenedXmlMap service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMap">REST API Reference for FlattenedXmlMap Operation</seealso>
        Task<FlattenedXmlMapResponse> FlattenedXmlMapAsync(FlattenedXmlMapRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  FlattenedXmlMapWithXmlName



        /// <summary>
        /// Flattened maps with @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlName">REST API Reference for FlattenedXmlMapWithXmlName Operation</seealso>
        Task<FlattenedXmlMapWithXmlNameResponse> FlattenedXmlMapWithXmlNameAsync(FlattenedXmlMapWithXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  FlattenedXmlMapWithXmlNamespace



        /// <summary>
        /// Flattened maps with @xmlNamespace and @xmlName
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FlattenedXmlMapWithXmlNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FlattenedXmlMapWithXmlNamespace service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FlattenedXmlMapWithXmlNamespace">REST API Reference for FlattenedXmlMapWithXmlNamespace Operation</seealso>
        Task<FlattenedXmlMapWithXmlNamespaceResponse> FlattenedXmlMapWithXmlNamespaceAsync(FlattenedXmlMapWithXmlNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  FractionalSeconds



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        Task<FractionalSecondsResponse> FractionalSecondsAsync(FractionalSecondsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GreetingWithErrors



        /// <summary>
        /// This operation has three possible return values:
        /// 
        ///  <ol> <li>A successful response in the form of GreetingWithErrorsOutput</li> <li>An
        /// InvalidGreeting error.</li> <li>A BadRequest error.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GreetingWithErrorsResponse> GreetingWithErrorsAsync(GreetingWithErrorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  HostWithPathOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the HostWithPathOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the HostWithPathOperation service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/HostWithPathOperation">REST API Reference for HostWithPathOperation Operation</seealso>
        Task<HostWithPathOperationResponse> HostWithPathOperationAsync(HostWithPathOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the IgnoresWrappingXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/IgnoresWrappingXmlName">REST API Reference for IgnoresWrappingXmlName Operation</seealso>
        Task<IgnoresWrappingXmlNameResponse> IgnoresWrappingXmlNameAsync(IgnoresWrappingXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoInputAndNoOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndNoOutput">REST API Reference for NoInputAndNoOutput Operation</seealso>
        Task<NoInputAndNoOutputResponse> NoInputAndNoOutputAsync(NoInputAndNoOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoInputAndOutput service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/NoInputAndOutput">REST API Reference for NoInputAndOutput Operation</seealso>
        Task<NoInputAndOutputResponse> NoInputAndOutputAsync(NoInputAndOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutWithContentEncoding



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWithContentEncoding service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutWithContentEncoding service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/PutWithContentEncoding">REST API Reference for PutWithContentEncoding Operation</seealso>
        Task<PutWithContentEncodingResponse> PutWithContentEncodingAsync(PutWithContentEncodingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  QueryIdempotencyTokenAutoFill



        /// <summary>
        /// Automatically adds idempotency tokens.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryIdempotencyTokenAutoFill service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryIdempotencyTokenAutoFill service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryIdempotencyTokenAutoFill">REST API Reference for QueryIdempotencyTokenAutoFill Operation</seealso>
        Task<QueryIdempotencyTokenAutoFillResponse> QueryIdempotencyTokenAutoFillAsync(QueryIdempotencyTokenAutoFillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  QueryLists



        /// <summary>
        /// This test serializes simple and complex lists.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryLists">REST API Reference for QueryLists Operation</seealso>
        Task<QueryListsResponse> QueryListsAsync(QueryListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  QueryMaps



        /// <summary>
        /// This test serializes simple and complex maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the QueryMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryMaps">REST API Reference for QueryMaps Operation</seealso>
        Task<QueryMapsResponse> QueryMapsAsync(QueryMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the QueryTimestamps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/QueryTimestamps">REST API Reference for QueryTimestamps Operation</seealso>
        Task<QueryTimestampsResponse> QueryTimestampsAsync(QueryTimestampsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RecursiveXmlShapes



        /// <summary>
        /// Recursive shapes
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveXmlShapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecursiveXmlShapes service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/RecursiveXmlShapes">REST API Reference for RecursiveXmlShapes Operation</seealso>
        Task<RecursiveXmlShapesResponse> RecursiveXmlShapesAsync(RecursiveXmlShapesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SimpleInputParams



        /// <summary>
        /// This test serializes strings, numbers, and boolean values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleInputParams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimpleInputParams service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleInputParams">REST API Reference for SimpleInputParams Operation</seealso>
        Task<SimpleInputParamsResponse> SimpleInputParamsAsync(SimpleInputParamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  SimpleScalarXmlProperties



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarXmlProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimpleScalarXmlProperties service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/SimpleScalarXmlProperties">REST API Reference for SimpleScalarXmlProperties Operation</seealso>
        Task<SimpleScalarXmlPropertiesResponse> SimpleScalarXmlPropertiesAsync(SimpleScalarXmlPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  XmlBlobs



        /// <summary>
        /// Blobs are base64 encoded
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlBlobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlBlobs service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlBlobs">REST API Reference for XmlBlobs Operation</seealso>
        Task<XmlBlobsResponse> XmlBlobsAsync(XmlBlobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  XmlEmptyBlobs



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyBlobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyBlobs service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyBlobs">REST API Reference for XmlEmptyBlobs Operation</seealso>
        Task<XmlEmptyBlobsResponse> XmlEmptyBlobsAsync(XmlEmptyBlobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  XmlEmptyLists



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyLists">REST API Reference for XmlEmptyLists Operation</seealso>
        Task<XmlEmptyListsResponse> XmlEmptyListsAsync(XmlEmptyListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  XmlEmptyMaps



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEmptyMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEmptyMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEmptyMaps">REST API Reference for XmlEmptyMaps Operation</seealso>
        Task<XmlEmptyMapsResponse> XmlEmptyMapsAsync(XmlEmptyMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  XmlEnums



        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlEnums service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlEnums">REST API Reference for XmlEnums Operation</seealso>
        Task<XmlEnumsResponse> XmlEnumsAsync(XmlEnumsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  XmlIntEnums



        /// <summary>
        /// This example serializes enums as top level properties, in lists, sets, and maps.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlIntEnums service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlIntEnums service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlIntEnums">REST API Reference for XmlIntEnums Operation</seealso>
        Task<XmlIntEnumsResponse> XmlIntEnumsAsync(XmlIntEnumsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlLists service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlLists">REST API Reference for XmlLists Operation</seealso>
        Task<XmlListsResponse> XmlListsAsync(XmlListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  XmlMaps



        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlMaps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMaps">REST API Reference for XmlMaps Operation</seealso>
        Task<XmlMapsResponse> XmlMapsAsync(XmlMapsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  XmlMapsXmlName



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlMapsXmlName service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlMapsXmlName service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlMapsXmlName">REST API Reference for XmlMapsXmlName Operation</seealso>
        Task<XmlMapsXmlNameResponse> XmlMapsXmlNameAsync(XmlMapsXmlNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  XmlNamespaces



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlNamespaces service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlNamespaces">REST API Reference for XmlNamespaces Operation</seealso>
        Task<XmlNamespacesResponse> XmlNamespacesAsync(XmlNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  XmlTimestamps



        /// <summary>
        /// This tests how timestamps are serialized, including using the default format of date-time
        /// and various @timestampFormat trait values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the XmlTimestamps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the XmlTimestamps service method, as returned by QueryProtocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/query-protocol-2020-01-08/XmlTimestamps">REST API Reference for XmlTimestamps Operation</seealso>
        Task<XmlTimestampsResponse> XmlTimestampsAsync(XmlTimestampsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonQueryProtocolConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonQueryProtocolConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonQueryProtocolConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonQueryProtocolConfig to create AmazonQueryProtocolClient");
            }

            return awsCredentials == null ? 
                    new AmazonQueryProtocolClient(serviceClientConfig) :
                    new AmazonQueryProtocolClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}