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
 * Do not modify this file. This file is generated from the sagemaker-metrics-2022-09-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMakerMetrics.Model;

#pragma warning disable CS1570
namespace Amazon.SageMakerMetrics
{
    /// <summary>
    /// <para>Interface for accessing SageMakerMetrics</para>
    ///
    /// Contains all data plane API operations and data types for Amazon SageMaker Metrics.
    /// Use these APIs to put and retrieve (get) features related to your training run.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_metrics_BatchPutMetrics.html">BatchPutMetrics</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonSageMakerMetrics : IAmazonService, IDisposable
    {
                
        #region  BatchGetMetrics



        /// <summary>
        /// Used to retrieve training metrics from SageMaker.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchGetMetrics service method, as returned by SageMakerMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-metrics-2022-09-30/BatchGetMetrics">REST API Reference for BatchGetMetrics Operation</seealso>
        Task<BatchGetMetricsResponse> BatchGetMetricsAsync(BatchGetMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  BatchPutMetrics



        /// <summary>
        /// Used to ingest training metrics into SageMaker. These metrics can be visualized in
        /// SageMaker Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchPutMetrics service method, as returned by SageMakerMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-metrics-2022-09-30/BatchPutMetrics">REST API Reference for BatchPutMetrics Operation</seealso>
        Task<BatchPutMetricsResponse> BatchPutMetricsAsync(BatchPutMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonSageMakerMetricsConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonSageMakerMetricsConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonSageMakerMetricsConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonSageMakerMetricsConfig to create AmazonSageMakerMetricsClient");
            }

            return awsCredentials == null ? 
                    new AmazonSageMakerMetricsClient(serviceClientConfig) :
                    new AmazonSageMakerMetricsClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}