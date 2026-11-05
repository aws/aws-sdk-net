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
using Amazon.SimpleEmailV2.Endpoints;

namespace Amazon.SimpleEmailV2.Internal
{
    /// <summary>
    /// Amazon SimpleEmailServiceV2 endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="SimpleEmailServiceV2EndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonSimpleEmailServiceV2EndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonSimpleEmailServiceV2EndpointProvider.Context>
    {
        private sealed class Context
        {
            public SimpleEmailServiceV2EndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(SimpleEmailServiceV2EndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAAAMAAAAEAAAAAQAAAAUAAAAEAAAABAAAAA4F9eESAAAAAgAAABAAAAAGAAAABAAAAA4AAAAHAAAABQAAAAoAAAAIAAAABgAAAAkF9eERAAAABwX14RAF9eEDAAAABgAAAAwAAAALAAAACQX14Q4F9eEPAAAABwAAAA0F9eENAAAACQX14QwF9eENAAAABQX14QkAAAAPAAAABgX14QoF9eELAAAAAwAAABEF9eEIAAAABAAAABcAAAASAAAABQX14QcAAAATAAAABgAAABUAAAAUAAAACAX14QQF9eEGAAAABwAAABYF9eEDAAAACAX14QIF9eEFAAAABQX14QcF9eEB");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for SimpleEmailServiceV2EndpointParameters.
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

            var typed = (SimpleEmailServiceV2EndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    return new Endpoint((string)context.Parameters.Endpoint)
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", "ses", null, new List<string> { "*" }, null) },
                    };
                case 2:
                    return new Endpoint($"https://{context.Parameters.EndpointId}.endpoints.email.us-gov.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", "ses", null, new List<string> { "*" }, null) },
                    };
                case 3:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 4:
                    return new Endpoint($"https://{context.Parameters.EndpointId}.endpoints.email.us-gov.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", "ses", null, new List<string> { "*" }, null) },
                    };
                case 5:
                    return new Endpoint($"https://{context.Parameters.EndpointId}.endpoints.email.global.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", "ses", null, new List<string> { "*" }, null) },
                    };
                case 6:
                    return new Endpoint($"https://{context.Parameters.EndpointId}.endpoints.email.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", "ses", null, new List<string> { "*" }, null) },
                    };
                case 7:
                    throw new AmazonClientException("Invalid Configuration: FIPS is not supported with multi-region endpoints");
                case 8:
                    throw new AmazonClientException("EndpointId must be a valid host label");
                case 9:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 10:
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                case 11:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 12:
                    return new Endpoint($"https://email-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 13:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 14:
                    return new Endpoint($"https://email-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 15:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 16:
                    return new Endpoint($"https://email.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 17:
                    return new Endpoint($"https://email.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 18:
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
                    return IsSet(context.Parameters.Region);
                case 1:
                    return (context.PartitionResult = Partition((string)context.Parameters.Region)) != null;
                case 2:
                    return IsSet(context.Parameters.EndpointId);
                case 3:
                    return IsValidHostLabel((string)context.Parameters.EndpointId, true);
                case 4:
                    return IsSet(context.Parameters.Endpoint);
                case 5:
                    return Equals(context.Parameters.UseFIPS, true);
                case 6:
                    return Equals(context.Parameters.UseDualStack, true);
                case 7:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 8:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                case 9:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
