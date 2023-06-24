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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMakerMetrics.Model;

namespace Amazon.SageMakerMetrics
{
    /// <summary>
    /// Interface for accessing SageMakerMetrics
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
        /// SageMaker Studio and retrieved with the <code>GetMetrics</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMetrics service method.</param>
        /// 
        /// <returns>The response from the BatchPutMetrics service method, as returned by SageMakerMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-metrics-2022-09-30/BatchPutMetrics">REST API Reference for BatchPutMetrics Operation</seealso>
        BatchPutMetricsResponse BatchPutMetrics(BatchPutMetricsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchPutMetrics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchPutMetrics operation on AmazonSageMakerMetricsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchPutMetrics
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-metrics-2022-09-30/BatchPutMetrics">REST API Reference for BatchPutMetrics Operation</seealso>
        IAsyncResult BeginBatchPutMetrics(BatchPutMetricsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchPutMetrics operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchPutMetrics.</param>
        /// 
        /// <returns>Returns a  BatchPutMetricsResult from SageMakerMetrics.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-metrics-2022-09-30/BatchPutMetrics">REST API Reference for BatchPutMetrics Operation</seealso>
        BatchPutMetricsResponse EndBatchPutMetrics(IAsyncResult asyncResult);

        #endregion
        
    }
}