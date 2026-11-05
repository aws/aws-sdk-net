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
using Amazon.Sustainability.Endpoints;

namespace Amazon.Sustainability.Internal
{
    /// <summary>
    /// Amazon Sustainability endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="SustainabilityEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonSustainabilityEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonSustainabilityEndpointProvider.Context>
    {
        private sealed class Context
        {
            public SustainabilityEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(SustainabilityEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAAAkAAAADAAAAAQAAAAQF9eEIAAAAAgAAAAUF9eEIAAAAAwAAAAgAAAAGAAAABAX14QMAAAAHAAAABQX14QQF9eEHAAAABQX14QUF9eEGAAAAAwX14QEF9eEC");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for SustainabilityEndpointParameters.
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters["UseFIPS"] == null)
            {
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            }

            var typed = (SustainabilityEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 2:
                    return new Endpoint((string)context.Parameters.Endpoint)
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", null, null, new List<string> { "*" }, null), new AuthScheme("sigv4", null, null, null, null) },
                    };
                case 3:
                    return new Endpoint($"https://api.sustainability.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", null, null, new List<string> { "*" }, null), new AuthScheme("sigv4", null, "us-east-1", null, null) },
                    };
                case 4:
                    return new Endpoint($"https://sustainability.us-gov.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", null, null, new List<string> { "*" }, null), new AuthScheme("sigv4", null, "us-gov-west-1", null, null) },
                    };
                case 5:
                    return new Endpoint($"https://sustainability-fips.us-gov.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", null, null, new List<string> { "*" }, null), new AuthScheme("sigv4", null, "us-gov-west-1", null, null) },
                    };
                case 6:
                    return new Endpoint($"https://sustainability-fips.global.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", null, null, new List<string> { "*" }, null), new AuthScheme("sigv4", null, $"{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}", null, null) },
                    };
                case 7:
                    return new Endpoint($"https://sustainability.global.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", null, null, new List<string> { "*" }, null), new AuthScheme("sigv4", null, $"{Fn.GetAttr(context.PartitionResult, "implicitGlobalRegion")}", null, null) },
                    };
                case 8:
                    throw new AmazonClientException("Invalid Configuration: Missing Region");
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
                    return IsSet(context.Parameters.Region);
                case 2:
                    return (context.PartitionResult = Partition((string)context.Parameters.Region)) != null;
                case 3:
                    return Equals(context.Parameters.UseFIPS, true);
                case 4:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws");
                case 5:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
