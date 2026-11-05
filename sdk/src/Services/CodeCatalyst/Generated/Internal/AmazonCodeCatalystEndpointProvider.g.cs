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
using Amazon.CodeCatalyst.Endpoints;

namespace Amazon.CodeCatalyst.Internal
{
    /// <summary>
    /// Amazon CodeCatalyst endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="CodeCatalystEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonCodeCatalystEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonCodeCatalystEndpointProvider.Context>
    {
        private sealed class Context
        {
            public CodeCatalystEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResultSsa2 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResultSsa1 { get; set; }

            public Context(CodeCatalystEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAX14QEAAAADAAAAAQAAAAcAAAAEAAAAAwAAAAUF9eEAAAAABAAAAAYF9eEEAAAABQX14QMF9eECAAAAAgAAAAgF9eEAAAAABAAAAAkF9eEGAAAABgX14QUF9eEC");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for CodeCatalystEndpointParameters.
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

            var typed = (CodeCatalystEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 2:
                    throw new AmazonClientException("Partition does not support FIPS.");
                case 3:
                    return new Endpoint($"https://codecatalyst-fips.global.{Fn.GetAttr(context.PartitionResultSsa1, "dualStackDnsSuffix")}");
                case 4:
                    return new Endpoint($"https://codecatalyst.global.{Fn.GetAttr(context.PartitionResultSsa1, "dualStackDnsSuffix")}");
                case 5:
                    return new Endpoint($"https://codecatalyst-fips.global.{Fn.GetAttr(context.PartitionResultSsa2, "dualStackDnsSuffix")}");
                case 6:
                    return new Endpoint($"https://codecatalyst.global.{Fn.GetAttr(context.PartitionResultSsa2, "dualStackDnsSuffix")}");
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
                    return (context.PartitionResultSsa2 = Partition((string)context.Parameters.Region)) != null;
                case 3:
                    return (context.PartitionResultSsa1 = Partition("us-west-2")) != null;
                case 4:
                    return Equals(context.Parameters.UseFIPS, true);
                case 5:
                    return Equals(GetAttr(context.PartitionResultSsa1, "supportsFIPS"), true);
                case 6:
                    return Equals(GetAttr(context.PartitionResultSsa2, "supportsFIPS"), true);
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
