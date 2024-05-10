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
                
        #region  BatchPutMetrics



        /// <summary>
        /// Used to ingest training metrics into SageMaker. These metrics can be visualized in
        /// SageMaker Studio and retrieved with the <c>GetMetrics</c> API.
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

    }
}