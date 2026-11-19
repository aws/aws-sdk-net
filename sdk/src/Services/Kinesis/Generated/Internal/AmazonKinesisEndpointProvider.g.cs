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
using Amazon.Kinesis.Endpoints;

namespace Amazon.Kinesis.Internal
{
    /// <summary>
    /// Amazon Kinesis endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="KinesisEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonKinesisEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonKinesisEndpointProvider.Context>
    {
        private sealed class Context
        {
            public KinesisEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }
            public string StreamIdSuffixValue { get; set; }
            public string StreamIdPrefixValue { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ArnSsa2 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ArnSsa4 { get; set; }
            public object IsoArnType { get; set; }
            public object ArnTypeSsa2 { get; set; }
            public string HttpsCustomEndpointSuffixValue { get; set; }
            public string PlainCustomEndpointSuffixValue { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ArnSsa5 { get; set; }
            public object ArnTypeSsa1 { get; set; }
            public object ArnTypeSsa3 { get; set; }
            public object ResourceIdSsa1 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ArnSsa1 { get; set; }
            public object ArnTypeSsa4 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ArnSsa3 { get; set; }
            public object ArnTypeSsa5 { get; set; }
            public object ResourceIdSsa2 { get; set; }
            public object ResourceIdSsa3 { get; set; }
            public object IsoResourceId { get; set; }

            public Context(KinesisEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("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");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for KinesisEndpointParameters.
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
            if (parameters["ResourceType"] == null)
            {
                throw new AmazonClientException("ResourceType parameter must be set for endpoint resolution");
            }

            var typed = (KinesisEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis{context.HttpsCustomEndpointSuffixValue}-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 2:
                    throw new AmazonClientException("DualStack is enabled, but this partition does not support DualStack.");
                case 3:
                    throw new AmazonClientException("FIPS is enabled, but this partition does not support FIPS.");
                case 4:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis{context.HttpsCustomEndpointSuffixValue}-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 5:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 6:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis{context.HttpsCustomEndpointSuffixValue}.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 7:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 8:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis{context.HttpsCustomEndpointSuffixValue}.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 9:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis{context.PlainCustomEndpointSuffixValue}-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 10:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis{context.PlainCustomEndpointSuffixValue}-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 11:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis{context.PlainCustomEndpointSuffixValue}.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 12:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis{context.PlainCustomEndpointSuffixValue}.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 13:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 14:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 15:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 16:
                    return new Endpoint($"https://{context.StreamIdPrefixValue}.{context.StreamIdSuffixValue}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 17:
                    throw new AmazonClientException("Operation Type is not set. Please contact service team for resolution.");
                case 18:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa5, "accountId")}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 19:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa5, "accountId")}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 20:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa5, "accountId")}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 21:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa5, "accountId")}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 22:
                    throw new AmazonClientException($"Partition: {Fn.GetAttr(context.ArnSsa5, "partition")} from ARN doesn't match with partition name: {Fn.GetAttr(context.PartitionResult, "name")}.");
                case 23:
                    throw new AmazonClientException($"Invalid ARN: Kinesis ARNs don't support `{context.ArnTypeSsa1}` arn types.");
                case 24:
                    throw new AmazonClientException("Invalid ARN: No ARN type specified");
                case 25:
                    throw new AmazonClientException($"Invalid ARN: The ARN was not for the Kinesis service, found: {Fn.GetAttr(context.ArnSsa5, "service")}.");
                case 26:
                    throw new AmazonClientException("Invalid ARN: Invalid region.");
                case 27:
                    throw new AmazonClientException("Invalid ARN: Invalid account id.");
                case 28:
                    throw new AmazonClientException("Invalid ARN: Failed to parse ARN.");
                case 29:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa2, "accountId")}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 30:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa2, "accountId")}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 31:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa2, "accountId")}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 32:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa2, "accountId")}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 33:
                    throw new AmazonClientException($"Partition: {Fn.GetAttr(context.ArnSsa2, "partition")} from ARN doesn't match with partition name: {Fn.GetAttr(context.PartitionResult, "name")}.");
                case 34:
                    throw new AmazonClientException($"Invalid ARN: Kinesis ARNs don't support `{context.ArnTypeSsa2}` arn types.");
                case 35:
                    throw new AmazonClientException($"Invalid ARN: The ARN was not for the Kinesis service, found: {Fn.GetAttr(context.ArnSsa2, "service")}.");
                case 36:
                    throw new AmazonClientException($"Invalid ARN: Unsupported resource type `{context.ArnTypeSsa3}`. Expected: stream, channel, or queue.");
                case 37:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa4, "accountId")}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 38:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa4, "accountId")}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 39:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa4, "accountId")}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 40:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa4, "accountId")}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 41:
                    return new Endpoint($"https://{context.ResourceIdSsa1}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 42:
                    return new Endpoint($"https://{context.ResourceIdSsa1}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 43:
                    return new Endpoint($"https://{context.ResourceIdSsa1}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 44:
                    return new Endpoint($"https://{context.ResourceIdSsa1}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 45:
                    throw new AmazonClientException("Invalid ARN: Invalid channel id.");
                case 46:
                    throw new AmazonClientException("Invalid ARN: Missing channel id.");
                case 47:
                    return new Endpoint($"https://{context.ResourceIdSsa1}.{context.Parameters.OperationType}-kinesis-queues-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 48:
                    return new Endpoint($"https://{context.ResourceIdSsa1}.{context.Parameters.OperationType}-kinesis-queues-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 49:
                    return new Endpoint($"https://{context.ResourceIdSsa1}.{context.Parameters.OperationType}-kinesis-queues.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 50:
                    return new Endpoint($"https://{context.ResourceIdSsa1}.{context.Parameters.OperationType}-kinesis-queues.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 51:
                    throw new AmazonClientException("Invalid ARN: Invalid queue id.");
                case 52:
                    throw new AmazonClientException("Invalid ARN: Missing queue id.");
                case 53:
                    throw new AmazonClientException($"Partition: {Fn.GetAttr(context.ArnSsa4, "partition")} from ARN doesn't match with partition name: {Fn.GetAttr(context.PartitionResult, "name")}.");
                case 54:
                    throw new AmazonClientException($"Invalid ARN: The ARN was not for the Kinesis service, found: {Fn.GetAttr(context.ArnSsa4, "service")}.");
                case 55:
                    return new Endpoint($"https://kinesis-queues-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 56:
                    return new Endpoint($"https://kinesis-queues-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 57:
                    return new Endpoint($"https://kinesis-queues.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 58:
                    return new Endpoint($"https://kinesis-queues.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 59:
                    return new Endpoint($"https://{context.ResourceIdSsa2}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 60:
                    return new Endpoint($"https://{context.ResourceIdSsa2}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 61:
                    return new Endpoint($"https://{context.ResourceIdSsa2}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 62:
                    return new Endpoint($"https://{context.ResourceIdSsa2}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 63:
                    throw new AmazonClientException("ChannelARN does not support the `data` operation type.");
                case 64:
                    throw new AmazonClientException($"Partition: {Fn.GetAttr(context.ArnSsa1, "partition")} from ARN doesn't match with partition name: {Fn.GetAttr(context.PartitionResult, "name")}.");
                case 65:
                    throw new AmazonClientException($"Invalid ARN: ChannelARN only supports `channel` arn types, found: `{context.ArnTypeSsa4}`.");
                case 66:
                    throw new AmazonClientException($"Invalid ARN: The ARN was not for the Kinesis service, found: {Fn.GetAttr(context.ArnSsa1, "service")}.");
                case 67:
                    return new Endpoint($"https://{context.ResourceIdSsa3}.{context.Parameters.OperationType}-kinesis-queues-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 68:
                    return new Endpoint($"https://{context.ResourceIdSsa3}.{context.Parameters.OperationType}-kinesis-queues-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 69:
                    return new Endpoint($"https://{context.ResourceIdSsa3}.{context.Parameters.OperationType}-kinesis-queues.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 70:
                    return new Endpoint($"https://{context.ResourceIdSsa3}.{context.Parameters.OperationType}-kinesis-queues.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 71:
                    throw new AmazonClientException($"Partition: {Fn.GetAttr(context.ArnSsa3, "partition")} from ARN doesn't match with partition name: {Fn.GetAttr(context.PartitionResult, "name")}.");
                case 72:
                    throw new AmazonClientException($"Invalid ARN: QueueARN only supports `queue` ARN types, found: `{context.ArnTypeSsa5}`.");
                case 73:
                    throw new AmazonClientException($"Invalid ARN: The ARN was not for the Kinesis service, found: {Fn.GetAttr(context.ArnSsa3, "service")}.");
                case 74:
                    throw new AmazonClientException("Invalid Configuration: ResourceType must be \"queue\" when QueueARN is set.");
                case 75:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis-queues-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 76:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis-queues-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 77:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis-queues.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 78:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis-queues.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 79:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 80:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 81:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 82:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 83:
                    throw new AmazonClientException("Invalid account id.");
                case 84:
                    throw new AmazonClientException("AccountIdEndpointMode is required but no AccountID was provided or able to be loaded");
                case 85:
                    throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition");
                case 86:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 87:
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                case 88:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 89:
                    return new Endpoint($"https://kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 90:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 91:
                    return new Endpoint($"https://kinesis.{context.Parameters.Region}.amazonaws.com");
                case 92:
                    return new Endpoint($"https://kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 93:
                    return new Endpoint($"https://kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 94:
                    return new Endpoint($"https://kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 95:
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
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso-b");
                case 3:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-iso");
                case 4:
                    return IsSet(context.Parameters.StreamId);
                case 5:
                    return (context.StreamIdSuffixValue = Substring((string)context.Parameters.StreamId, 21, 24, false)) != null;
                case 6:
                    return (context.StreamIdPrefixValue = Substring((string)context.Parameters.StreamId, 0, 20, false)) != null;
                case 7:
                    return Equals((Substring((string)context.Parameters.StreamId, 20, 21, false) ?? ""), "-");
                case 8:
                    return Equals((Substring((string)context.Parameters.StreamId, 3, 4, true) ?? ""), "-");
                case 9:
                    return IsSet(context.Parameters.Endpoint);
                case 10:
                    return IsSet(context.Parameters.StreamARN);
                case 11:
                    return IsSet(context.Parameters.ConsumerARN);
                case 12:
                    return IsSet(context.Parameters.ResourceARN);
                case 13:
                    return (context.ArnSsa2 = ParseArn((string)context.Parameters.ConsumerARN)) != null;
                case 14:
                    return (context.ArnSsa4 = ParseArn((string)context.Parameters.ResourceARN)) != null;
                case 15:
                    return (context.IsoArnType = GetAttr(context.ArnSsa4, "resourceId[0]")) != null;
                case 16:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa2, "accountId"), false);
                case 17:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa2, "region"), false);
                case 18:
                    return Equals(GetAttr(context.ArnSsa2, "service"), "kinesis");
                case 19:
                    return (context.ArnTypeSsa2 = GetAttr(context.ArnSsa2, "resourceId[0]")) != null;
                case 20:
                    return Equals(context.ArnTypeSsa2, "");
                case 21:
                    return (context.HttpsCustomEndpointSuffixValue = Substring((string)context.Parameters.Endpoint, 15, 20, false)) != null;
                case 22:
                    return Equals((Substring((string)context.Parameters.Endpoint, 20, 21, false) ?? ""), ".");
                case 23:
                    return Equals((Substring((string)context.Parameters.Endpoint, 15, 16, false) ?? ""), "-");
                case 24:
                    return (context.PlainCustomEndpointSuffixValue = Substring((string)context.Parameters.Endpoint, 7, 12, false)) != null;
                case 25:
                    return Equals(context.ArnTypeSsa2, "stream");
                case 26:
                    return Equals(GetAttr(context.PartitionResult, "name"), GetAttr(context.ArnSsa2, "partition"));
                case 27:
                    return (context.ArnSsa5 = ParseArn((string)context.Parameters.StreamARN)) != null;
                case 28:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa5, "accountId"), false);
                case 29:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa5, "region"), false);
                case 30:
                    return Equals(GetAttr(context.ArnSsa5, "service"), "kinesis");
                case 31:
                    return (context.ArnTypeSsa1 = GetAttr(context.ArnSsa5, "resourceId[0]")) != null;
                case 32:
                    return Equals(context.ArnTypeSsa1, "");
                case 33:
                    return Equals(context.IsoArnType, "queue");
                case 34:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa4, "accountId"), false);
                case 35:
                    return Equals(context.ArnTypeSsa1, "stream");
                case 36:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa4, "region"), false);
                case 37:
                    return Equals(GetAttr(context.PartitionResult, "name"), GetAttr(context.ArnSsa5, "partition"));
                case 38:
                    return Equals(GetAttr(context.ArnSsa4, "service"), "kinesis");
                case 39:
                    return (context.ArnTypeSsa3 = GetAttr(context.ArnSsa4, "resourceId[0]")) != null;
                case 40:
                    return Equals(context.ArnTypeSsa3, "");
                case 41:
                    return Equals(context.ArnTypeSsa3, "stream");
                case 42:
                    return Equals(context.ArnTypeSsa3, "channel");
                case 43:
                    return Equals(context.ArnTypeSsa3, "queue");
                case 44:
                    return Equals(GetAttr(context.PartitionResult, "name"), GetAttr(context.ArnSsa4, "partition"));
                case 45:
                    return IsSet(context.Parameters.ChannelARN);
                case 46:
                    return (context.ResourceIdSsa1 = GetAttr(context.ArnSsa4, "resourceId[1]")) != null;
                case 47:
                    return IsSet(context.Parameters.QueueARN);
                case 48:
                    return (context.ArnSsa1 = ParseArn((string)context.Parameters.ChannelARN)) != null;
                case 49:
                    return IsSet(context.Parameters.AccountIdEndpointMode);
                case 50:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa1, "accountId"), false);
                case 51:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa1, "region"), false);
                case 52:
                    return IsSet(context.Parameters.AccountId);
                case 53:
                    return Equals(context.Parameters.AccountIdEndpointMode, "disabled");
                case 54:
                    return Equals(context.Parameters.AccountIdEndpointMode, "required");
                case 55:
                    return IsValidHostLabel((string)context.Parameters.AccountId, false);
                case 56:
                    return Equals(GetAttr(context.ArnSsa1, "service"), "kinesis");
                case 57:
                    return (context.ArnTypeSsa4 = GetAttr(context.ArnSsa1, "resourceId[0]")) != null;
                case 58:
                    return Equals(context.ArnTypeSsa4, "");
                case 59:
                    return Equals(context.Parameters.ResourceType, "queue");
                case 60:
                    return (context.ArnSsa3 = ParseArn((string)context.Parameters.QueueARN)) != null;
                case 61:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa3, "accountId"), false);
                case 62:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa3, "region"), false);
                case 63:
                    return Equals(GetAttr(context.ArnSsa3, "service"), "kinesis");
                case 64:
                    return (context.ArnTypeSsa5 = GetAttr(context.ArnSsa3, "resourceId[0]")) != null;
                case 65:
                    return Equals(context.ArnTypeSsa5, "");
                case 66:
                    return Equals(context.ArnTypeSsa5, "queue");
                case 67:
                    return Equals(GetAttr(context.PartitionResult, "name"), GetAttr(context.ArnSsa3, "partition"));
                case 68:
                    return IsValidHostLabel((string)context.ResourceIdSsa1, false);
                case 69:
                    return Equals(context.ArnTypeSsa4, "channel");
                case 70:
                    return Equals(GetAttr(context.PartitionResult, "name"), GetAttr(context.ArnSsa1, "partition"));
                case 71:
                    return IsSet(context.Parameters.OperationType);
                case 72:
                    return (context.ResourceIdSsa2 = GetAttr(context.ArnSsa1, "resourceId[1]")) != null;
                case 73:
                    return (context.ResourceIdSsa3 = GetAttr(context.ArnSsa3, "resourceId[1]")) != null;
                case 74:
                    return IsValidHostLabel((string)context.ResourceIdSsa3, false);
                case 75:
                    return IsValidHostLabel((string)context.ResourceIdSsa2, false);
                case 76:
                    return (context.IsoResourceId = GetAttr(context.ArnSsa4, "resourceId[1]")) != null;
                case 77:
                    return IsValidHostLabel((string)context.IsoResourceId, false);
                case 78:
                    return Equals(context.Parameters.OperationType, "data");
                case 79:
                    return Equals(context.Parameters.UseFIPS, true);
                case 80:
                    return Equals(context.Parameters.UseDualStack, true);
                case 81:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                case 82:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 83:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                case 84:
                    return Equals((Substring((string)context.Parameters.Endpoint, 12, 13, false) ?? ""), ".");
                case 85:
                    return Equals((Substring((string)context.Parameters.Endpoint, 7, 8, false) ?? ""), "-");
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
