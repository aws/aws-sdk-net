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
 * Do not modify this file. This file is generated from the rpccbordataplane-1999-12-31.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.RpcCborDataPlane.Model;

#pragma warning disable CS1570
namespace Amazon.RpcCborDataPlane
{
    /// <summary>
    /// <para>Interface for accessing RpcCborDataPlane</para>
    ///
    /// 
    /// </summary>
    public partial interface IAmazonRpcCborDataPlane : IAmazonService, IDisposable
    {
                
        #region  GetItem



        /// <summary>
        /// <pre><c>From Amazon DynamoDB. Deserialization of recursive structures. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/GetItem">REST API Reference for GetItem Operation</seealso>
        Task<GetItemResponse> GetItemAsync(GetItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetMetricData



        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMetricData service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/GetMetricData">REST API Reference for GetMetricData Operation</seealso>
        Task<GetMetricDataResponse> GetMetricDataAsync(GetMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  Healthcheck



        /// <summary>
        /// <pre><c>A response that only says &quot;OK&quot;, if it can. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Healthcheck service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the Healthcheck service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/Healthcheck">REST API Reference for Healthcheck Operation</seealso>
        Task<HealthcheckResponse> HealthcheckAsync(HealthcheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutItem



        /// <summary>
        /// <pre><c>From Amazon DynamoDB. Serialization of recursive structures. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutItem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/PutItem">REST API Reference for PutItem Operation</seealso>
        Task<PutItemResponse> PutItemAsync(PutItemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutMetricData



        /// <summary>
        /// <pre><c>As seen in Amazon CloudWatch. </c></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricData service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetricData service method, as returned by RpcCborDataPlane.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rpccbordataplane-1999-12-31/PutMetricData">REST API Reference for PutMetricData Operation</seealso>
        Task<PutMetricDataResponse> PutMetricDataAsync(PutMetricDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonRpcCborDataPlaneConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonRpcCborDataPlaneConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonRpcCborDataPlaneConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonRpcCborDataPlaneConfig to create AmazonRpcCborDataPlaneClient");
            }

            return awsCredentials == null ? 
                    new AmazonRpcCborDataPlaneClient(serviceClientConfig) :
                    new AmazonRpcCborDataPlaneClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}