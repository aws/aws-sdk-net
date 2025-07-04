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
using System.Net;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.S3Control.Model;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3Control.Internal
{
    /// <summary>
    /// Custom pipeline handler to extract the X-Amz-Id-2 header from WebExceptions
    /// </summary>
    public class AmazonS3ControlExceptionHandler : PipelineHandler
    {
        /// <summary>
        /// Extracts the X-Amz-Id-2 header from WebExceptions and adds it to the AmazonS3ControlException and metrics
        /// </summary>
        /// <param name="executionContext"></param>
        public override void InvokeSync(IExecutionContext executionContext)
        {
            try
            {
                base.InvokeSync(executionContext);
            }
            catch (Exception exception)
            {
                ExtractAmazonIdHeader(executionContext, exception);
                throw;
            }
        }

        public override async System.Threading.Tasks.Task<T> InvokeAsync<T>(IExecutionContext executionContext)
        {
            try
            {
                return await base.InvokeAsync<T>(executionContext).ConfigureAwait(false);
            }
            catch(Exception exception)
            {
                ExtractAmazonIdHeader(executionContext, exception);
                throw;
            }
        }

        private static void ExtractAmazonIdHeader(IExecutionContext executionContext, Exception exception)
        {
            var metrics = executionContext.RequestContext.Metrics;

            var amazonS3ControlException = exception as AmazonS3ControlException;
            if (amazonS3ControlException != null)
            {
                amazonS3ControlException.AmazonId2 = (exception.GetBaseException() as WebException)?.Response.Headers[HeaderKeys.XAmzId2Header];

                if (amazonS3ControlException.AmazonId2 != null)
                {
                    metrics.AddProperty(Metric.AmzId2, amazonS3ControlException.AmazonId2);
                }

                if (amazonS3ControlException.RequestId != null)
                {
                    metrics.AddProperty(Metric.AmzCfId, amazonS3ControlException.RequestId);
                }
            }
        }
    }
}
