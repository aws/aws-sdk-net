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
using Amazon.PricingPlanManager.Endpoints;

namespace Amazon.PricingPlanManager.Internal
{
    /// <summary>
    /// Amazon PricingPlanManager endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="PricingPlanManagerEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonPricingPlanManagerEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonPricingPlanManagerEndpointProvider.Context>
    {
        private sealed class Context
        {
            public PricingPlanManagerEndpointParameters Parameters { get; }

            public Context(PricingPlanManagerEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAX14QEF9eEC");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for PricingPlanManagerEndpointParameters.
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

            var typed = (PricingPlanManagerEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    return new Endpoint($"{context.Parameters.Endpoint}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "pricingplanmanager", "us-east-1", null, null) },
                    };
                case 2:
                    return new Endpoint("https://pricingplanmanager.us-east-1.api.aws")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "pricingplanmanager", "us-east-1", null, null) },
                    };
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
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
