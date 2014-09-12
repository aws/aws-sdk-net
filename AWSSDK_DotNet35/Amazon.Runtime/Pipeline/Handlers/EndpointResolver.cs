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

namespace Amazon.Runtime.Internal
{
    /// <summary>
    /// This handler resolves the endpoint to be used for the current request.
    /// </summary>
    public class EndpointResolver : GenericHandler
    {
        /// <summary>
        /// Resolves the endpoint to be used for the current request
        /// before invoking the next handler.
        /// </summary>
        /// <param name="executionContext">The execution context, it contains the
        /// request and response context.</param>
        protected override void PreInvoke(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            if(requestContext.Request.Endpoint == null)
                requestContext.Request.Endpoint = DetermineEndpoint(executionContext.RequestContext);
        }

        /// <summary>
        /// Determines the endpoint for the request.
        /// </summary>
        /// <param name="requestContext">The request context.</param>
        /// <returns></returns>
        protected virtual Uri DetermineEndpoint(IRequestContext requestContext)
        {
            return DetermineEndpoint(requestContext.ClientConfig, requestContext.Request);
        }

        internal static Uri DetermineEndpoint(ClientConfig config, IRequest request)
        {
            return request.AlternateEndpoint != null
                 ? new Uri(ClientConfig.GetUrl(request.AlternateEndpoint, config.RegionEndpointServiceName, config.UseHttp))
                 : new Uri(config.DetermineServiceURL());
        }
    }
}
