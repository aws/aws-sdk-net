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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */

using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Identity;
using System.Collections.Generic;

namespace Amazon.EventBridge.Internal
{
    /// <inheritdoc cref="IAuthSchemeParameters" />
    public class AmazonEventBridgeAuthSchemeParameters : IAuthSchemeParameters
    {
        /// <inheritdoc />
        public string Operation { get; set; }

        /// <summary>
        /// Region is included as the service supports SigV4.
        /// </summary>
        public string Region { get; set; }
    }

    /// <summary>
    /// Handler responsible for converting the request context into the parameters expected by the auth scheme resolver.
    /// </summary>
    public class AmazonEventBridgeAuthSchemeHandler : BaseAuthResolverHandler
    {
        private readonly AmazonEventBridgeEndpointResolver _endpointResolver = new();

        /// <summary>
        /// Modeled auth scheme resolver for EventBridge.
        /// </summary>
        public AmazonEventBridgeAuthSchemeResolver AuthSchemeResolver { get; } = new();

        /// <inheritdoc/>
        protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)
        {
            // Since EventBridge includes auth schemes in its endpoint rules, we'll attempt to delegate resolution to the endpoint
            // resolver first (falling back to the modeled resolver if no options are returned).
            var endpoint = _endpointResolver.GetEndpoint(executionContext);

            // This means the endpoints resolver is executed twice intentionally (at this point and then later in the pipeline
            // to determine which endpoint the SDK should use for the request).
            var endpointAuthSchemes = RetrieveSchemesFromEndpoint(endpoint);
            if (endpointAuthSchemes != null)
            {
                return endpointAuthSchemes;
            }

            var requestContext = executionContext.RequestContext;
            var mappedParameters = new AmazonEventBridgeAuthSchemeParameters
            {
                Operation = requestContext.Request.RequestName,
                Region = requestContext.ClientConfig.RegionEndpoint?.SystemName,
            };

            return AuthSchemeResolver.ResolveAuthScheme(mappedParameters);
        }
    }

    /// <inheritdoc cref="IAuthSchemeResolver{T}" />
    public class AmazonEventBridgeAuthSchemeResolver : IAuthSchemeResolver<AmazonEventBridgeAuthSchemeParameters>
    {
        /// <inheritdoc />
        public List<IAuthSchemeOption> ResolveAuthScheme(AmazonEventBridgeAuthSchemeParameters authParameters)
        {
            switch (authParameters.Operation)
            {
                default:
                    // Default for the service, applies to all remaining operations.
                    return AuthSchemeOption.DEFAULT_SIGV4;
            }
        }
    }
}