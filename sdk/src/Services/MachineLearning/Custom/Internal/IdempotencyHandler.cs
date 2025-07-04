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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Amazon.Runtime;
using Amazon.MachineLearning.Model;
using Amazon.Runtime.Internal;

namespace Amazon.MachineLearning.Internal
{
    /// <summary>
    /// Custom pipeline handler
    /// </summary>
    public class IdempotencyHandler : PipelineHandler
    {
        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            base.InvokeSync(executionContext);
        }

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <typeparam name="T">The response type for the current request.</typeparam>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public override System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            PreInvoke(executionContext);
            return base.InvokeAsync<T>(executionContext);                        
        }

        /// <summary>
        /// Custom pipeline handler
        /// </summary>
        /// <param name="executionContext"></param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            if (executionContext.RequestContext.OriginalRequest is CreateBatchPredictionRequest)
            {
                var req = executionContext.RequestContext.OriginalRequest as CreateBatchPredictionRequest;
                if (!req.IsSetBatchPredictionId())
                    req.BatchPredictionId = Guid.NewGuid().ToString();
            }
            else if (executionContext.RequestContext.OriginalRequest is CreateDataSourceFromS3Request)
            {
                var req = executionContext.RequestContext.OriginalRequest as CreateDataSourceFromS3Request;
                if (!req.IsSetDataSourceId())
                    req.DataSourceId = Guid.NewGuid().ToString();
            }
            else if (executionContext.RequestContext.OriginalRequest is CreateDataSourceFromRDSRequest)
            {
                var req = executionContext.RequestContext.OriginalRequest as CreateDataSourceFromRDSRequest;
                if (!req.IsSetDataSourceId())
                    req.DataSourceId = Guid.NewGuid().ToString();
            }
            else if (executionContext.RequestContext.OriginalRequest is CreateDataSourceFromRedshiftRequest)
            {
                var req = executionContext.RequestContext.OriginalRequest as CreateDataSourceFromRedshiftRequest;
                if (!req.IsSetDataSourceId())
                    req.DataSourceId = Guid.NewGuid().ToString();
            }
            else if (executionContext.RequestContext.OriginalRequest is CreateEvaluationRequest)
            {
                var req = executionContext.RequestContext.OriginalRequest as CreateEvaluationRequest;
                if (!req.IsSetEvaluationId())
                    req.EvaluationId = Guid.NewGuid().ToString();
            }
            else if (executionContext.RequestContext.OriginalRequest is CreateMLModelRequest)
            {
                var req = executionContext.RequestContext.OriginalRequest as CreateMLModelRequest;
                if (!req.IsSetMLModelId())
                    req.MLModelId = Guid.NewGuid().ToString();
            }
        }
    }
}
