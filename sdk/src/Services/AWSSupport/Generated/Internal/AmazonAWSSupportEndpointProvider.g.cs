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
using Amazon.AWSSupport.Endpoints;

namespace Amazon.AWSSupport.Internal
{
    /// <summary>
    /// Amazon AWSSupport endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="AWSSupportEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonAWSSupportEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonAWSSupportEndpointProvider.Context>
    {
        private sealed class Context
        {
            public AWSSupportEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(AWSSupportEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAABIAAAADAAAAAQAAAAQF9eEQAAAAAgAAAAUF9eEQAAAAAwAAAA0AAAAGAAAABAAAAAwAAAAHAAAABQX14QQAAAAIAAAABwX14QUAAAAJAAAACAX14QYAAAAKAAAACgX14QcAAAALAAAACwX14QgF9eEPAAAABgX14Q0F9eEOAAAABAAAABAAAAAOAAAACAX14QYAAAAPAAAACQX14QsF9eEMAAAABgAAABEF9eEKAAAACQX14QkF9eEKAAAAAwX14QEAAAATAAAABAX14QIF9eED");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for AWSSupportEndpointParameters.
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

            var typed = (AWSSupportEndpointParameters)parameters;
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
                    return new Endpoint("https://support.us-east-1.amazonaws.com")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "support", "us-east-1", null, null) },
                    };
                case 5:
                    return new Endpoint("https://support.cn-north-1.amazonaws.com.cn")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "support", "cn-north-1", null, null) },
                    };
                case 6:
                    return new Endpoint("https://support.us-gov-west-1.amazonaws.com")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "support", "us-gov-west-1", null, null) },
                    };
                case 7:
                    return new Endpoint("https://support.us-iso-east-1.c2s.ic.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "support", "us-iso-east-1", null, null) },
                    };
                case 8:
                    return new Endpoint("https://support.us-isob-east-1.sc2s.sgov.gov")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "support", "us-isob-east-1", null, null) },
                    };
                case 9:
                    return new Endpoint($"https://support-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 10:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 11:
                    return new Endpoint($"https://support-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 12:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 13:
                    return new Endpoint($"https://support.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 14:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 15:
                    return new Endpoint($"https://support.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 16:
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
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws");
                case 6:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 7:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-cn");
                case 8:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                case 9:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                case 10:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso");
                case 11:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-b");
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
