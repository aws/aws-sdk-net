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
using Amazon.RpcV2Protocol.Model;

#pragma warning disable CS1570

namespace Amazon.RpcV2Protocol
{
    /// <summary>
    /// <para>Interface for accessing RpcV2Protocol</para>
    /// </summary>
    public partial interface IAmazonRpcV2Protocol : IAmazonService, IDisposable
    {
#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputOutput service method.</param>
        /// <returns>The response from the EmptyInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/EmptyInputOutput">REST API Reference for EmptyInputOutput Operation</seealso>
        EmptyInputOutputResponse EmptyInputOutput(EmptyInputOutputRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the EmptyInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/EmptyInputOutput">REST API Reference for EmptyInputOutput Operation</seealso>
        Task<EmptyInputOutputResponse> EmptyInputOutputAsync(EmptyInputOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Float16 service method.</param>
        /// <returns>The response from the Float16 service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/Float16">REST API Reference for Float16 Operation</seealso>
        Float16Response Float16(Float16Request request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Float16 service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the Float16 service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/Float16">REST API Reference for Float16 Operation</seealso>
        Task<Float16Response> Float16Async(Float16Request request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// <returns>The response from the FractionalSeconds service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        FractionalSecondsResponse FractionalSeconds(FractionalSecondsRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FractionalSeconds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the FractionalSeconds service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/FractionalSeconds">REST API Reference for FractionalSeconds Operation</seealso>
        Task<FractionalSecondsResponse> FractionalSecondsAsync(FractionalSecondsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This operation has three possible return values: 1. A successful response in the form
        /// of GreetingWithErrorsOutput 2. An InvalidGreeting error. 3. A ComplexError error.
        /// Implementations must be able to successfully take a response and properly deserialize
        /// successful and error responses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// <returns>The response from the GreetingWithErrors service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RpcV2Protocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        GreetingWithErrorsResponse GreetingWithErrors(GreetingWithErrorsRequest request);
#endif

        /// <summary>
        /// This operation has three possible return values: 1. A successful response in the form
        /// of GreetingWithErrorsOutput 2. An InvalidGreeting error. 3. A ComplexError error.
        /// Implementations must be able to successfully take a response and properly deserialize
        /// successful and error responses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GreetingWithErrors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the GreetingWithErrors service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ComplexErrorException">
        /// This error is thrown when a request is invalid.
        /// </exception>
        /// <exception cref="Amazon.RpcV2Protocol.Model.InvalidGreetingException">
        /// This error is thrown when an invalid greeting value is provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/GreetingWithErrors">REST API Reference for GreetingWithErrors Operation</seealso>
        Task<GreetingWithErrorsResponse> GreetingWithErrorsAsync(GreetingWithErrorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputOutput service method.</param>
        /// <returns>The response from the NoInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/NoInputOutput">REST API Reference for NoInputOutput Operation</seealso>
        NoInputOutputResponse NoInputOutput(NoInputOutputRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the NoInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/NoInputOutput">REST API Reference for NoInputOutput Operation</seealso>
        Task<NoInputOutputResponse> NoInputOutputAsync(NoInputOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptionalInputOutput service method.</param>
        /// <returns>The response from the OptionalInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/OptionalInputOutput">REST API Reference for OptionalInputOutput Operation</seealso>
        OptionalInputOutputResponse OptionalInputOutput(OptionalInputOutputRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OptionalInputOutput service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the OptionalInputOutput service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/OptionalInputOutput">REST API Reference for OptionalInputOutput Operation</seealso>
        Task<OptionalInputOutputResponse> OptionalInputOutputAsync(OptionalInputOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveShapes service method.</param>
        /// <returns>The response from the RecursiveShapes service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        RecursiveShapesResponse RecursiveShapes(RecursiveShapesRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RecursiveShapes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RecursiveShapes service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RecursiveShapes">REST API Reference for RecursiveShapes Operation</seealso>
        Task<RecursiveShapesResponse> RecursiveShapesAsync(RecursiveShapesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborDenseMaps service method.</param>
        /// <returns>The response from the RpcV2CborDenseMaps service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborDenseMaps">REST API Reference for RpcV2CborDenseMaps Operation</seealso>
        RpcV2CborDenseMapsResponse RpcV2CborDenseMaps(RpcV2CborDenseMapsRequest request);
#endif

        /// <summary>
        /// The example tests basic map serialization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborDenseMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RpcV2CborDenseMaps service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborDenseMaps">REST API Reference for RpcV2CborDenseMaps Operation</seealso>
        Task<RpcV2CborDenseMapsResponse> RpcV2CborDenseMapsAsync(RpcV2CborDenseMapsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This test case serializes JSON lists for the following cases for both input and output:
        /// 1. Normal lists. 2. Normal sets. 3. Lists of lists. 4. Lists of structures.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborLists service method.</param>
        /// <returns>The response from the RpcV2CborLists service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborLists">REST API Reference for RpcV2CborLists Operation</seealso>
        RpcV2CborListsResponse RpcV2CborLists(RpcV2CborListsRequest request);
#endif

        /// <summary>
        /// This test case serializes JSON lists for the following cases for both input and output:
        /// 1. Normal lists. 2. Normal sets. 3. Lists of lists. 4. Lists of structures.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RpcV2CborLists service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborLists">REST API Reference for RpcV2CborLists Operation</seealso>
        Task<RpcV2CborListsResponse> RpcV2CborListsAsync(RpcV2CborListsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborSparseMaps service method.</param>
        /// <returns>The response from the RpcV2CborSparseMaps service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborSparseMaps">REST API Reference for RpcV2CborSparseMaps Operation</seealso>
        RpcV2CborSparseMapsResponse RpcV2CborSparseMaps(RpcV2CborSparseMapsRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborSparseMaps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RpcV2CborSparseMaps service method, as returned by RpcV2Protocol.</returns>
        /// <exception cref="Amazon.RpcV2Protocol.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborSparseMaps">REST API Reference for RpcV2CborSparseMaps Operation</seealso>
        Task<RpcV2CborSparseMapsResponse> RpcV2CborSparseMapsAsync(RpcV2CborSparseMapsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborUnions service method.</param>
        /// <returns>The response from the RpcV2CborUnions service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborUnions">REST API Reference for RpcV2CborUnions Operation</seealso>
        RpcV2CborUnionsResponse RpcV2CborUnions(RpcV2CborUnionsRequest request);
#endif

        /// <summary>
        /// This operation uses unions for inputs and outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RpcV2CborUnions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the RpcV2CborUnions service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/RpcV2CborUnions">REST API Reference for RpcV2CborUnions Operation</seealso>
        Task<RpcV2CborUnionsResponse> RpcV2CborUnionsAsync(RpcV2CborUnionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        SimpleScalarPropertiesResponse SimpleScalarProperties(SimpleScalarPropertiesRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SimpleScalarProperties service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SimpleScalarProperties service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/SimpleScalarProperties">REST API Reference for SimpleScalarProperties Operation</seealso>
        Task<SimpleScalarPropertiesResponse> SimpleScalarPropertiesAsync(SimpleScalarPropertiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

#if NETFRAMEWORK
        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SparseNullsOperation service method.</param>
        /// <returns>The response from the SparseNullsOperation service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/SparseNullsOperation">REST API Reference for SparseNullsOperation Operation</seealso>
        SparseNullsOperationResponse SparseNullsOperation(SparseNullsOperationRequest request);
#endif

        /// <summary>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SparseNullsOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The response from the SparseNullsOperation service method, as returned by RpcV2Protocol.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpcv2protocol-2020-07-14/SparseNullsOperation">REST API Reference for SparseNullsOperation Operation</seealso>
        Task<SparseNullsOperationResponse> SparseNullsOperationAsync(SparseNullsOperationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRpcV2ProtocolConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRpcV2ProtocolConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
            Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRpcV2ProtocolConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRpcV2ProtocolConfig to create AmazonRpcV2ProtocolClient");
            }

            return awsCredentials == null ?
                    new AmazonRpcV2ProtocolClient(serviceClientConfig) :
                    new AmazonRpcV2ProtocolClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
    }
}
