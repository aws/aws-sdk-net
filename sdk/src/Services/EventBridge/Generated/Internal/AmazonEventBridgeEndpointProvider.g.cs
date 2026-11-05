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
using Amazon.EventBridge.Endpoints;

namespace Amazon.EventBridge.Internal
{
    /// <summary>
    /// Amazon EventBridge endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="EventBridgeEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonEventBridgeEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonEventBridgeEndpointProvider.Context>
    {
        private sealed class Context
        {
            public EventBridgeEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }

            public Context(EventBridgeEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAAAQAAAADAAAAAQAAABsF9eESAAAAAQAAABkAAAAFAAAAAgAAABEAAAAGAAAAAwAAAAcF9eESAAAABAAAAAoAAAAIAAAABQAAAAkF9eERAAAACQX14QEF9eEEAAAABQAAAA4AAAALAAAACAAAAAwF9eEQAAAACgX14Q0AAAANAAAACwX14Q4F9eEPAAAABgX14QEAAAAPAAAACAAAABAF9eEMAAAACQX14QsF9eEMAAAAAwAAABIF9eESAAAABAAAABcAAAATAAAABQAAABUAAAAUAAAABwX14QUF9eEHAAAABwAAABYF9eEHAAAACQX14QMF9eEEAAAABQAAABgAAAAfAAAABgX14QEAAAAfAAAAAgAAABoAAAAbAAAAAwAAAB0AAAAbAAAABAX14QgAAAAcAAAABQX14QkF9eEKAAAABAAAAB8AAAAeAAAABwX14QIF9eEHAAAABwX14QYF9eEH");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for EventBridgeEndpointParameters.
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

            var typed = (EventBridgeEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    return new Endpoint($"https://events.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 2:
                    return new Endpoint((string)context.Parameters.Endpoint)
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", "events", null, new List<string> { "*" }, null) },
                    };
                case 3:
                    return new Endpoint($"https://{context.Parameters.EndpointId}.endpoint.events.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", "events", null, new List<string> { "*" }, null) },
                    };
                case 4:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 5:
                    return new Endpoint($"https://{context.Parameters.EndpointId}.endpoint.events.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", "events", null, new List<string> { "*" }, null) },
                    };
                case 6:
                    throw new AmazonClientException("Invalid Configuration: FIPS is not supported with EventBridge multi-region endpoints.");
                case 7:
                    throw new AmazonClientException("EndpointId must be a valid host label.");
                case 8:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 9:
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                case 10:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 11:
                    return new Endpoint($"https://events-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 12:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 13:
                    return new Endpoint("https://events.us-gov-east-1.amazonaws.com");
                case 14:
                    return new Endpoint("https://events.us-gov-west-1.amazonaws.com");
                case 15:
                    return new Endpoint($"https://events-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 16:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 17:
                    return new Endpoint($"https://events.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
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
                    return IsSet(context.Parameters.Endpoint);
                case 2:
                    return IsSet(context.Parameters.EndpointId);
                case 3:
                    return (context.PartitionResult = Partition((string)context.Parameters.Region)) != null;
                case 4:
                    return Equals(context.Parameters.UseFIPS, true);
                case 5:
                    return Equals(context.Parameters.UseDualStack, true);
                case 6:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                case 7:
                    return IsValidHostLabel((string)context.Parameters.EndpointId, true);
                case 8:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                case 9:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 10:
                    return Equals(context.Parameters.Region, "us-gov-east-1");
                case 11:
                    return Equals(context.Parameters.Region, "us-gov-west-1");
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
