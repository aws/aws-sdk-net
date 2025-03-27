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
 * Do not modify this file. This file is generated from the ep2-complex-parameters-2022-08-24.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Ep2complexparameters.Model;

#pragma warning disable CS1570
namespace Amazon.Ep2complexparameters
{
    /// <summary>
    /// <para>Interface for accessing Ep2complexparameters</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonEp2complexparameters : IAmazonService, IDisposable
    {
                
        #region  EmptyStaticContextOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EmptyStaticContextOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EmptyStaticContextOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/EmptyStaticContextOperation">REST API Reference for EmptyStaticContextOperation Operation</seealso>
        Task<EmptyStaticContextOperationResponse> EmptyStaticContextOperationAsync(EmptyStaticContextOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOfObjectsOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfObjectsOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOfObjectsOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/ListOfObjectsOperation">REST API Reference for ListOfObjectsOperation Operation</seealso>
        Task<ListOfObjectsOperationResponse> ListOfObjectsOperationAsync(ListOfObjectsOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOfUnionsOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOfUnionsOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOfUnionsOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/ListOfUnionsOperation">REST API Reference for ListOfUnionsOperation Operation</seealso>
        Task<ListOfUnionsOperationResponse> ListOfUnionsOperationAsync(ListOfUnionsOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MapOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MapOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MapOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/MapOperation">REST API Reference for MapOperation Operation</seealso>
        Task<MapOperationResponse> MapOperationAsync(MapOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  NoBindingsOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NoBindingsOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NoBindingsOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/NoBindingsOperation">REST API Reference for NoBindingsOperation Operation</seealso>
        Task<NoBindingsOperationResponse> NoBindingsOperationAsync(NoBindingsOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StaticContextOperation



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StaticContextOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StaticContextOperation service method, as returned by Ep2complexparameters.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-complex-parameters-2022-08-24/StaticContextOperation">REST API Reference for StaticContextOperation Operation</seealso>
        Task<StaticContextOperationResponse> StaticContextOperationAsync(StaticContextOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonEp2complexparametersConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonEp2complexparametersConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonEp2complexparametersConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonEp2complexparametersConfig to create AmazonEp2complexparametersClient");
            }

            return awsCredentials == null ? 
                    new AmazonEp2complexparametersClient(serviceClientConfig) :
                    new AmazonEp2complexparametersClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}