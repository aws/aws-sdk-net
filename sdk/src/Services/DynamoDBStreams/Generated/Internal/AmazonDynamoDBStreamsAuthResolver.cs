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
 * Do not modify this file. This file is generated from the streams.dynamodb-2012-08-10.normal.json service model.
 */

using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Identity;
using System.Collections.Generic;

namespace Amazon.DynamoDBStreams.Internal
{
    /// <inheritdoc cref="IAuthSchemeParameters" />
    public class AmazonDynamoDBStreamsAuthSchemeParameters : IAuthSchemeParameters
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
    public class AmazonDynamoDBStreamsAuthSchemeHandler : BaseAuthResolverHandler
    {
        /// <summary>
        /// Modeled auth scheme resolver for DynamoDBStreams.
        /// </summary>
        public AmazonDynamoDBStreamsAuthSchemeResolver AuthSchemeResolver { get; } = new();

        /// <inheritdoc/>
        protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)
        {
            var requestContext = executionContext.RequestContext;
            var mappedParameters = new AmazonDynamoDBStreamsAuthSchemeParameters
            {
                Operation = requestContext.Request.RequestName,
                Region = requestContext.ClientConfig.RegionEndpoint?.SystemName,
            };

            return AuthSchemeResolver.ResolveAuthScheme(mappedParameters);
        }
    }

    /// <inheritdoc cref="IAuthSchemeResolver{T}" />
    public class AmazonDynamoDBStreamsAuthSchemeResolver : IAuthSchemeResolver<AmazonDynamoDBStreamsAuthSchemeParameters>
    {
        /// <inheritdoc />
        public List<IAuthSchemeOption> ResolveAuthScheme(AmazonDynamoDBStreamsAuthSchemeParameters authParameters)
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