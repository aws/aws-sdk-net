/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.S3Control.Model;
using System.IO;
using Amazon.Runtime.Internal;
using Amazon.S3Control;
using System.Text.RegularExpressions;
using Amazon.Util;
using System.Globalization;

#pragma warning disable 1591

namespace Amazon.S3Control.Internal
{
    public class AmazonS3ControlPostMarshallHandler : PipelineHandler
    {
#if BCL
        private static Regex accountIdValidationRegex = new Regex(@"^[A-Za-z0-9\-]+$", RegexOptions.Compiled);
#else
        private static Regex accountIdValidationRegex = new Regex(@"^[A-Za-z0-9\-]+$");
#endif

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
#if AWS_ASYNC_API

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

#elif AWS_APM_API

        /// <summary>
        /// Calls pre invoke logic before calling the next handler 
        /// in the pipeline.
        /// </summary>
        /// <param name="executionContext">The execution context which contains both the
        /// requests and response context.</param>
        /// <returns>IAsyncResult which represent an async operation.</returns>
        public override IAsyncResult InvokeAsync(IAsyncExecutionContext executionContext)
        {
            PreInvoke(ExecutionContext.CreateFromAsyncContext(executionContext));
            return base.InvokeAsync(executionContext);
        }
#endif

        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            ProcessRequestHandlers(executionContext);
        }

        public static void ProcessRequestHandlers(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            var config = executionContext.RequestContext.ClientConfig;

            string accountId;
            request.Headers.TryGetValue(HeaderKeys.XAmzAccountId, out accountId);

            if (accountId != null)
            {
                if (!IsValidAccountId(accountId))
                {
                    throw new AmazonClientException("AccountId can only contain alphanumeric characters and dashes and must be between 1 and 63 characters long.");
                }

                request.Headers.Remove(HeaderKeys.XAmzAccountId);

                var ub = new UriBuilder(EndpointResolver.DetermineEndpoint(config, request));

                // Add account id to host
                ub.Host = string.Concat(accountId, ".", ub.Host);
                request.Endpoint = ub.Uri;
            }
        }

        // Returns true if the account id is valid
        public static bool IsValidAccountId(string accountId)
        {
            // Check if the account id is between 1 and 63 characters
            if (accountId.Length < 1 || accountId.Length > 63)
                return false;

            // Check if the account id contains a newline character
            if (accountId.IndexOf('\n') >= 0)
                return false;

            // Check if the account id only contains:
            //  uppercase letters, lowercase letters, numbers,
            //  dashes (-)
            if (!accountIdValidationRegex.IsMatch(accountId))
                return false;

            return true;
        }

    }
}
