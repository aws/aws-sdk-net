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
using Amazon.DSQL.Endpoints;

namespace Amazon.DSQL.Internal
{
    /// <summary>
    /// Amazon DSQL endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="DSQLEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonDSQLEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonDSQLEndpointProvider.Context>
    {
        private sealed class Context
        {
            public DSQLEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(DSQLEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAAAYAAAADAAAAAQAAAAQF9eEFAAAAAgAAAAUF9eEFAAAAAwX14QMF9eEEAAAAAwX14QEF9eEC");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for DSQLEndpointParameters.
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

            var typed = (DSQLEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 2:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 3:
                    return new Endpoint($"https://dsql-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 4:
                    return new Endpoint($"https://dsql.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 5:
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
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
