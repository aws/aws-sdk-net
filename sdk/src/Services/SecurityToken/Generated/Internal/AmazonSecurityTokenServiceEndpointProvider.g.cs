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
using Amazon.SecurityToken.Endpoints;

namespace Amazon.SecurityToken.Internal
{
    /// <summary>
    /// Amazon SecurityTokenService endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="SecurityTokenServiceEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonSecurityTokenServiceEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonSecurityTokenServiceEndpointProvider.Context>
    {
        private sealed class Context
        {
            public SecurityTokenServiceEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(SecurityTokenServiceEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAAB4AAAADAAAAAQAAAAQF9eEOAAAAAgAAAAUF9eEOAAAAAwAAABkAAAAGAAAABAAAABgAAAAHAAAABQX14QEAAAAIAAAABgAAAAkF9eENAAAABwX14QEAAAAKAAAACgX14QEAAAALAAAACwX14QEAAAAMAAAADAX14QEAAAANAAAADQX14QEAAAAOAAAADgX14QEAAAAPAAAADwX14QEAAAAQAAAAEAX14QEAAAARAAAAEQX14QEAAAASAAAAEgX14QEAAAATAAAAEwX14QEAAAAUAAAAFAX14QEAAAAVAAAAFQX14QEAAAAWAAAAFgX14QEAAAAXAAAAFwX14QEF9eECAAAACAX14QsF9eEMAAAABAAAABwAAAAaAAAACQAAABsF9eEKAAAAGAX14QgF9eEJAAAACAAAAB0F9eEHAAAACQX14QYF9eEHAAAAAwX14QMAAAAfAAAABAX14QQF9eEF");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for SecurityTokenServiceEndpointParameters.
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
            if (parameters["UseGlobalEndpoint"] == null)
            {
                throw new AmazonClientException("UseGlobalEndpoint parameter must be set for endpoint resolution");
            }

            var typed = (SecurityTokenServiceEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    return new Endpoint("https://sts.amazonaws.com")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "sts", "us-east-1", null, null) },
                    };
                case 2:
                    return new Endpoint($"https://sts.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "sts", $"{context.Parameters.Region}", null, null) },
                    };
                case 3:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 4:
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                case 5:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 6:
                    return new Endpoint($"https://sts-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 7:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 8:
                    return new Endpoint($"https://sts.{context.Parameters.Region}.amazonaws.com");
                case 9:
                    return new Endpoint($"https://sts-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 10:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 11:
                    return new Endpoint($"https://sts.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 12:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 13:
                    return new Endpoint($"https://sts.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 14:
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
                    return Equals(context.Parameters.Region, "aws-global");
                case 6:
                    return Equals(context.Parameters.UseGlobalEndpoint, true);
                case 7:
                    return Equals(context.Parameters.Region, "eu-central-1");
                case 8:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 9:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                case 10:
                    return Equals(context.Parameters.Region, "ap-south-1");
                case 11:
                    return Equals(context.Parameters.Region, "eu-north-1");
                case 12:
                    return Equals(context.Parameters.Region, "eu-west-1");
                case 13:
                    return Equals(context.Parameters.Region, "eu-west-2");
                case 14:
                    return Equals(context.Parameters.Region, "eu-west-3");
                case 15:
                    return Equals(context.Parameters.Region, "sa-east-1");
                case 16:
                    return Equals(context.Parameters.Region, "us-east-1");
                case 17:
                    return Equals(context.Parameters.Region, "us-east-2");
                case 18:
                    return Equals(context.Parameters.Region, "us-west-2");
                case 19:
                    return Equals(context.Parameters.Region, "us-west-1");
                case 20:
                    return Equals(context.Parameters.Region, "ca-central-1");
                case 21:
                    return Equals(context.Parameters.Region, "ap-southeast-1");
                case 22:
                    return Equals(context.Parameters.Region, "ap-northeast-1");
                case 23:
                    return Equals(context.Parameters.Region, "ap-southeast-2");
                case 24:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
