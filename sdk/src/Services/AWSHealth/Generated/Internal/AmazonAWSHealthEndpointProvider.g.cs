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
using Amazon.AWSHealth.Endpoints;

namespace Amazon.AWSHealth.Internal
{
    /// <summary>
    /// Amazon AWSHealth endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="AWSHealthEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonAWSHealthEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonAWSHealthEndpointProvider.Context>
    {
        private sealed class Context
        {
            public AWSHealthEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(AWSHealthEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAABYAAAADAAAAAQAAAAQF9eENAAAAAgAAAAUF9eENAAAAAwAAABIAAAAGAAAABAAAAA4AAAAHAAAABQAAAA4AAAAIAAAABgAAAA4AAAAJAAAABwAAAA4AAAAKAAAACAAAAA4AAAALAAAACgAAAA4AAAAMAAAACwAAAA4AAAANAAAADAX14QEF9eECAAAADAAAABEAAAAPAAAADgX14QoAAAAQAAAADwX14QsF9eEMAAAADQX14QcF9eEIAAAACQAAABQAAAATAAAADAX14QYF9eEJAAAADAAAABUF9eECAAAADQX14QEF9eEGAAAAAwAAABgAAAAXAAAADAX14QMF9eEFAAAADAX14QMF9eEE");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for AWSHealthEndpointParameters.
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

            var typed = (AWSHealthEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    return new Endpoint($"https://health-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 2:
                    return new Endpoint($"https://health.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 3:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 4:
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                case 5:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 6:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 7:
                    return new Endpoint($"https://health-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 8:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 9:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 10:
                    return new Endpoint("https://global.health.amazonaws.com")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "health", "us-east-1", null, null) },
                    };
                case 11:
                    return new Endpoint("https://global.health.amazonaws.com.cn")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "health", "cn-northwest-1", null, null) },
                    };
                case 12:
                    return new Endpoint($"https://health.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 13:
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
                    return Equals(context.Parameters.UseDualStack, true);
                case 4:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws");
                case 5:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                case 6:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso");
                case 7:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-b");
                case 8:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-e");
                case 9:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 10:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-f");
                case 11:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-cn");
                case 12:
                    return Equals(context.Parameters.UseFIPS, true);
                case 13:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                case 14:
                    return Equals(context.Parameters.Region, "aws-global");
                case 15:
                    return Equals(context.Parameters.Region, "aws-cn-global");
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
