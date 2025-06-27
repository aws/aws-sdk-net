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
 * Do not modify this file. This file is generated from the rpcv2protocol-2020-07-14.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RpcV2Protocol.Model;

#pragma warning disable CS1570
namespace Amazon.RpcV2Protocol
{
    /// <summary>
    /// <para>Interface for accessing RpcV2Protocol</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRpcV2Protocol : IAmazonService, IDisposable
    {


        
        #region  EmptyInputOutput


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputOutput service method.</param>
        /// 
        /// <returns>The response from the EmptyInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/EmptyInputOutput">REST API Reference for EmptyInputOutput Operation</seealso>
        EmptyInputOutputResponse EmptyInputOutput(EmptyInputOutputRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EmptyInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/EmptyInputOutput">REST API Reference for EmptyInputOutput Operation</seealso>
        Task<EmptyInputOutputResponse> EmptyInputOutputAsync(EmptyInputOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  Float16


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Float16 service method.</param>
        /// 
        /// <returns>The response from the Float16 service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/Float16">REST API Reference for Float16 Operation</seealso>
        Float16Response Float16(Float16Request request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Float16 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Float16 service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/Float16">REST API Reference for Float16 Operation</seealso>
        Task<Float16Response> Float16Async(Float16Request request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  FractionalSeconds


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        FractionalSecondsResponse FractionalSeconds(FractionalSecondsRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the FractionalSeconds service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
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
        /// <returns>The response from the GreetingWithErrors service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RpcV2Protocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
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
        /// <returns>The response from the GreetingWithErrors service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RpcV2Protocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        Task<GreetingWithErrorsResponse> GreetingWithErrorsAsync(GreetingWithErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  NoInputOutput


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputOutput service method.</param>
        /// 
        /// <returns>The response from the NoInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/NoInputOutput">REST API Reference for NoInputOutput Operation</seealso>
        NoInputOutputResponse NoInputOutput(NoInputOutputRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/NoInputOutput">REST API Reference for NoInputOutput Operation</seealso>
        Task<NoInputOutputResponse> NoInputOutputAsync(NoInputOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  OptionalInputOutput


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptionalInputOutput service method.</param>
        /// 
        /// <returns>The response from the OptionalInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/OptionalInputOutput">REST API Reference for OptionalInputOutput Operation</seealso>
        OptionalInputOutputResponse OptionalInputOutput(OptionalInputOutputRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptionalInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the OptionalInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/OptionalInputOutput">REST API Reference for OptionalInputOutput Operation</seealso>
        Task<OptionalInputOutputResponse> OptionalInputOutputAsync(OptionalInputOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RecursiveShapes


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveShapes service method.</param>
        /// 
        /// <returns>The response from the RecursiveShapes service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        RecursiveShapesResponse RecursiveShapes(RecursiveShapesRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveShapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RecursiveShapes service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        Task<RecursiveShapesResponse> RecursiveShapesAsync(RecursiveShapesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RpcV2CborDenseMaps


        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborDenseMaps service method.</param>
        /// 
        /// <returns>The response from the RpcV2CborDenseMaps service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborDenseMaps">REST API Reference for RpcV2CborDenseMaps Operation</seealso>
        RpcV2CborDenseMapsResponse RpcV2CborDenseMaps(RpcV2CborDenseMapsRequest request);



        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborDenseMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RpcV2CborDenseMaps service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborDenseMaps">REST API Reference for RpcV2CborDenseMaps Operation</seealso>
        Task<RpcV2CborDenseMapsResponse> RpcV2CborDenseMapsAsync(RpcV2CborDenseMapsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RpcV2CborLists


        /// <summary>
        /// This test case serializes JSON lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal lists.</li> <li>Normal sets.</li> <li>Lists of lists.</li> <li>Lists
        /// of structures.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborLists service method.</param>
        /// 
        /// <returns>The response from the RpcV2CborLists service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborLists">REST API Reference for RpcV2CborLists Operation</seealso>
        RpcV2CborListsResponse RpcV2CborLists(RpcV2CborListsRequest request);



        /// <summary>
        /// This test case serializes JSON lists for the following cases for both input and output:
        /// 
        ///  <ol> <li>Normal lists.</li> <li>Normal sets.</li> <li>Lists of lists.</li> <li>Lists
        /// of structures.</li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RpcV2CborLists service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborLists">REST API Reference for RpcV2CborLists Operation</seealso>
        Task<RpcV2CborListsResponse> RpcV2CborListsAsync(RpcV2CborListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  SimpleScalarProperties


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request);



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        Task<SimpleScalarPropertiesResponse> SimpleScalarPropertiesAsync(SimpleScalarPropertiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}