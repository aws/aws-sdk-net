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
using Amazon.Runtime.Internal;
using Amazon.CloudFormation.Model;

namespace Amazon.CloudFormation.Internal
{
    /// <summary>
    /// Custom pipeline handler to pass an empty string NotificationARNs request property with collection is empty.
    /// </summary>
    public class ProcessRequestHandler : PipelineHandler
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
        /// Set NotificationARNs to empty if the collection is empty before continuing on in the pipeline.
        /// </summary>
        /// <param name="executionContext"></param>
        protected virtual void PreInvoke(IExecutionContext executionContext)
        {
            var request = executionContext.RequestContext.Request;
            var updateStackRequest = request.OriginalRequest as UpdateStackRequest;
            if (updateStackRequest != null)
            {
                var arns = updateStackRequest.NotificationARNs;

                if (arns != null)
                {
                    // if there are no NotificationARNs and the list was created by user (type is NOT AutoConstructed)
                    // only then pass empty param
                    if (arns.Count == 0 && !(arns is AutoConstructedList<string>))
                    {
                        if (request.Parameters.ContainsKey("NotificationARNs"))
                        {
                            request.Parameters["NotificationARNs"] = string.Empty;
                        }
                        else
                        {
                            request.Parameters.Add("NotificationARNs", string.Empty);
                        }
                    }
                }
            }
        }
    }
}
