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
using Amazon.Greengrass.Endpoints;

namespace Amazon.Greengrass.Internal
{
    /// <summary>
    /// Amazon Greengrass endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="GreengrassEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonGreengrassEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonGreengrassEndpointProvider.Context>
    {
        private sealed class Context
        {
            public GreengrassEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(GreengrassEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAABAAAAADAAAAAQAAAAQF9eEPAAAAAgAAAAUF9eEPAAAAAwAAAAoAAAAGAAAABAAAAAkAAAAHAAAACQX14QwAAAAIAAAACgX14Q0F9eEOAAAABQX14QoF9eELAAAABAAAAA4AAAALAAAABgAAAAwF9eEJAAAABwX14QYAAAANAAAACAX14QcF9eEIAAAABQAAAA8F9eEFAAAABgX14QQF9eEFAAAAAwX14QEAAAARAAAABAX14QIF9eED");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for GreengrassEndpointParameters.
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters["UseDualStack"] == null)
            {
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            }
            if (parameters["UseFIPS"] == null)
            {
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            }

            var typed = (GreengrassEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 2:
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                case 3:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 4:
                    return new Endpoint($"https://greengrass-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 5:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 6:
                    return new Endpoint("https://greengrass.us-gov-east-1.amazonaws.com");
                case 7:
                    return new Endpoint("https://greengrass.us-gov-west-1.amazonaws.com");
                case 8:
                    return new Endpoint($"https://greengrass-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 9:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 10:
                    return new Endpoint($"https://greengrass.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 11:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 12:
                    return new Endpoint("https://greengrass-ats.iot.us-gov-east-1.amazonaws.com")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "greengrass", "us-gov-east-1", null, null) },
                    };
                case 13:
                    return new Endpoint("https://greengrass-ats.iot.us-gov-west-1.amazonaws.com")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "greengrass", "us-gov-west-1", null, null) },
                    };
                case 14:
                    return new Endpoint($"https://greengrass.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 15:
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
                    return Equals(context.Parameters.UseDualStack, true);
                case 5:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 6:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                case 7:
                    return Equals(context.Parameters.Region, "us-gov-east-1");
                case 8:
                    return Equals(context.Parameters.Region, "us-gov-west-1");
                case 9:
                    return Equals(context.Parameters.Region, "dataplane-us-gov-east-1");
                case 10:
                    return Equals(context.Parameters.Region, "dataplane-us-gov-west-1");
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
