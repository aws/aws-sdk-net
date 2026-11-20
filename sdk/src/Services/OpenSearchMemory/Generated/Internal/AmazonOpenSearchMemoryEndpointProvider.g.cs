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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;
using Amazon.Runtime.Internal.Endpoints;
using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using Amazon.OpenSearchMemory.Endpoints;

namespace Amazon.OpenSearchMemory.Internal
{
    /// <summary>
    /// Amazon OpenSearchMemory endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="OpenSearchMemoryEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonOpenSearchMemoryEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonOpenSearchMemoryEndpointProvider.Context>
    {
        private sealed class Context
        {
            public OpenSearchMemoryEndpointParameters Parameters { get; }

            public Context(OpenSearchMemoryEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAAAcAAAADAAAAAQX14QMAAAAEAAAAAgAAAAUF9eEEAAAAAwAAAAYF9eEHAAAABAX14QUF9eEGAAAAAQX14QEF9eEC");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for OpenSearchMemoryEndpointParameters.
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters["Region"] == null)
            {
                throw new AmazonClientException("Region parameter must be set for endpoint resolution");
            }
            if (parameters["UseFIPS"] == null)
            {
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            }

            var typed = (OpenSearchMemoryEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 2:
                    return new Endpoint($"{context.Parameters.Endpoint}");
                case 3:
                    throw new AmazonClientException("Invalid Configuration: FIPS is not supported with OpenSearch Memory.");
                case 4:
                    throw new AmazonClientException("Invalid Configuration: Region must be a valid host label");
                case 5:
                    return new Endpoint($"https://{context.Parameters.SpaceId}.osm.{context.Parameters.Region}.on.aws");
                case 6:
                    throw new AmazonClientException("Invalid SpaceId: must be a valid host label");
                case 7:
                    return new Endpoint($"https://osm.{context.Parameters.Region}.api.aws");
                default:
                    throw new AmazonClientException("Cannot resolve endpoint");
            }
        }

        /// <summary>
        /// Evaluates the BDD condition at <paramref name="conditionIndex"/> against the context.
        /// </summary>
        bool IBddConditionEvaluator<Context>.EvaluateCondition(int conditionIndex, Context context)
        {
            switch (conditionIndex)
            {
                case 0:
                    return IsSet(context.Parameters.Endpoint);
                case 1:
                    return Equals(context.Parameters.UseFIPS, true);
                case 2:
                    return IsValidHostLabel((string)context.Parameters.Region, true);
                case 3:
                    return IsSet(context.Parameters.SpaceId);
                case 4:
                    return IsValidHostLabel((string)context.Parameters.SpaceId, false);
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
