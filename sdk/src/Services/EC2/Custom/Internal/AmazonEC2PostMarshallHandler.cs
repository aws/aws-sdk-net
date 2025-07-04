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
using Amazon.EC2.Model;
using System.IO;
using Amazon.Runtime.Internal;
using System.Text.RegularExpressions;

namespace Amazon.EC2.Internal
{
    /// <summary>
    /// Custom pipeline handler
    /// </summary>
    public class AmazonEC2PostMarshallHandler : PipelineHandler
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
            var originalRequest = executionContext.RequestContext.OriginalRequest;
            var request = executionContext.RequestContext.Request;

            var copySnapshotRequest = originalRequest as CopySnapshotRequest;
            if (copySnapshotRequest != null)
            {
                request.AlternateEndpoint = RegionEndpoint.GetBySystemName(copySnapshotRequest.DestinationRegion);
                request.Endpoint = EndpointResolver.DetermineEndpoint(executionContext.RequestContext.ClientConfig, request);

                return;
            }

            var requestSpotInstancesRequest = originalRequest as RequestSpotInstancesRequest;
            if (requestSpotInstancesRequest != null)
            {
                if (requestSpotInstancesRequest.LaunchSpecification != null)
                {
                    if (requestSpotInstancesRequest.LaunchSpecification.AllSecurityGroups != null)
                    {
                        int count = 1;
                        foreach (var group in requestSpotInstancesRequest.LaunchSpecification.AllSecurityGroups)
                        {
                            if (group != null && group.GroupId != null)
                            {
                                var key = "LaunchSpecification.SecurityGroupId." + count++;
                                request.Parameters[key] = group.GroupId;
                            }
                        }
                    }

                    if (requestSpotInstancesRequest.LaunchSpecification.SecurityGroups != null)
                    {
                        int count = 1;
                        foreach (var group in requestSpotInstancesRequest.LaunchSpecification.SecurityGroups)
                        {
                            var key = "LaunchSpecification.SecurityGroup." + count++;
                            request.Parameters[key] = group;
                        }
                    }
                }

                if (request.Parameters.ContainsKey("LaunchSpecification.Monitoring"))
                {
                    var val = request.Parameters["LaunchSpecification.Monitoring"];
                    request.Parameters.Remove("LaunchSpecification.Monitoring");
                    request.Parameters.Add("LaunchSpecification.Monitoring.Enabled", val);
                }

                var keysToRemove = new List<string>();
                foreach (var parameter in request.Parameters.Keys)
                {
                    if (parameter.StartsWith("LaunchSpecification.GroupSet.", StringComparison.Ordinal))
                        keysToRemove.Add(parameter);
                }
                foreach (var key in keysToRemove)
                {
                    request.Parameters.Remove(key);
                }
            }
        }
    }
}
