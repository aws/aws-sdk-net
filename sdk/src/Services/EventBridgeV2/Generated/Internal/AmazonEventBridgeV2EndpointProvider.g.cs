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
using Amazon.EventBridgeV2.Endpoints;

namespace Amazon.EventBridgeV2.Internal
{
    /// <summary>
    /// Amazon EventBridgeV2 endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="EventBridgeV2EndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonEventBridgeV2EndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonEventBridgeV2EndpointProvider.Context>
    {
        private sealed class Context
        {
            public EventBridgeV2EndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ParsedBusArn { get; set; }

            public Context(EventBridgeV2EndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAACIAAAADAAAAAQAAAAQF9eEAAAAAAgAAAAUAAAAbAAAAAwAAABoAAAAGAAAABAAAAAcAAAAKAAAABQAAAAgAAAAKAAAABgAAAAkAAAAKAAAABwAAABMAAAAKAAAACAAAAAsAAAAaAAAACgAAAAwF9eEPAAAACwAAAA8AAAANAAAADAAAAA4F9eEOAAAADQX14Q0F9eEJAAAADAAAABEAAAAQAAAADgX14QwF9eEHAAAADQAAABIF9eEFAAAADgX14QsF9eEFAAAACwAAABYAAAAUAAAADAAAABUF9eEKAAAADQX14QgF9eEJAAAADAAAABgAAAAXAAAADgX14QYF9eEHAAAADQAAABkF9eEFAAAADgX14QQF9eEFAAAACQX14RAAAAAbAAAACwAAAB4AAAAcAAAADAAAAB0F9eEUAAAADQX14RMF9eEJAAAADAAAACAAAAAfAAAADgX14RIF9eEHAAAADQAAACEF9eEFAAAADgX14REF9eEFAAAACwX14QEAAAAjAAAADAX14QIF9eED");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for EventBridgeV2EndpointParameters.
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
            if (parameters["UseFIPS"] == null)
            {
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            }
            if (parameters["UseDualStack"] == null)
            {
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            }

            var typed = (EventBridgeV2EndpointParameters)parameters;
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
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedBusArn, "accountId")}.eventsv2-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 5:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 6:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedBusArn, "accountId")}.eventsv2-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 7:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 8:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedBusArn, "accountId")}.eventsv2.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 9:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 10:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedBusArn, "accountId")}.eventsv2.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 11:
                    return new Endpoint($"https://{context.Parameters.AccountId}.eventsv2-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 12:
                    return new Endpoint($"https://{context.Parameters.AccountId}.eventsv2-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 13:
                    return new Endpoint($"https://{context.Parameters.AccountId}.eventsv2.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 14:
                    return new Endpoint($"https://{context.Parameters.AccountId}.eventsv2.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 15:
                    throw new AmazonClientException("Credentials-sourced account ID parameter is invalid");
                case 16:
                    throw new AmazonClientException("AccountIdEndpointMode is required but no AccountID was provided or able to be loaded");
                case 17:
                    return new Endpoint($"https://eventsv2-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 18:
                    return new Endpoint($"https://eventsv2-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 19:
                    return new Endpoint($"https://eventsv2.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 20:
                    return new Endpoint($"https://eventsv2.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
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
                    return (context.PartitionResult = Partition((string)context.Parameters.Region)) != null;
                case 2:
                    return IsSet(context.Parameters.AccountIdEndpointMode);
                case 3:
                    return Equals(context.Parameters.AccountIdEndpointMode, "disabled");
                case 4:
                    return IsSet(context.Parameters.EventBusArn);
                case 5:
                    return (context.ParsedBusArn = ParseArn((string)context.Parameters.EventBusArn)) != null;
                case 6:
                    return Equals(GetAttr(context.ParsedBusArn, "service"), "events");
                case 7:
                    return IsValidHostLabel((string)GetAttr(context.ParsedBusArn, "accountId"), false);
                case 8:
                    return IsSet(context.Parameters.AccountId);
                case 9:
                    return Equals(context.Parameters.AccountIdEndpointMode, "required");
                case 10:
                    return IsValidHostLabel((string)context.Parameters.AccountId, false);
                case 11:
                    return Equals(context.Parameters.UseFIPS, true);
                case 12:
                    return Equals(context.Parameters.UseDualStack, true);
                case 13:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 14:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
