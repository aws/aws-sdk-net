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
            public string HttpsCustomEndpointSuffixValue { get; set; }
            public string PlainCustomEndpointSuffixValue { get; set; }
            public object ArnTypeSsa2 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ArnSsa4 { get; set; }
            public object ArnTypeSsa1 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ArnSsa1 { get; set; }
            public object ArnTypeSsa4 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ArnSsa3 { get; set; }
            public object ArnTypeSsa3 { get; set; }
            public object ResourceIdSsa1 { get; set; }
            public object ResourceIdSsa2 { get; set; }

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
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa4, "accountId")}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 19:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa4, "accountId")}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 20:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa4, "accountId")}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 21:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa4, "accountId")}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 22:
                    throw new AmazonClientException($"Partition: {Fn.GetAttr(context.ArnSsa4, "partition")} from ARN doesn't match with partition name: {Fn.GetAttr(context.PartitionResult, "name")}.");
                case 23:
                    throw new AmazonClientException($"Invalid ARN: Kinesis ARNs don't support `{context.ArnTypeSsa1}` arn types.");
                case 24:
                    throw new AmazonClientException("Invalid ARN: No ARN type specified");
                case 25:
                    throw new AmazonClientException($"Invalid ARN: The ARN was not for the Kinesis service, found: {Fn.GetAttr(context.ArnSsa4, "service")}.");
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
                    throw new AmazonClientException($"Invalid ARN: Unsupported resource type `{context.ArnTypeSsa3}`. Expected: stream or channel");
                case 37:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa3, "accountId")}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 38:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa3, "accountId")}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 39:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa3, "accountId")}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 40:
                    return new Endpoint($"https://{Fn.GetAttr(context.ArnSsa3, "accountId")}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
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
                    throw new AmazonClientException($"Partition: {Fn.GetAttr(context.ArnSsa3, "partition")} from ARN doesn't match with partition name: {Fn.GetAttr(context.PartitionResult, "name")}.");
                case 48:
                    throw new AmazonClientException($"Invalid ARN: The ARN was not for the Kinesis service, found: {Fn.GetAttr(context.ArnSsa3, "service")}.");
                case 49:
                    return new Endpoint($"https://{context.ResourceIdSsa2}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 50:
                    return new Endpoint($"https://{context.ResourceIdSsa2}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 51:
                    return new Endpoint($"https://{context.ResourceIdSsa2}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 52:
                    return new Endpoint($"https://{context.ResourceIdSsa2}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 53:
                    throw new AmazonClientException("ChannelARN does not support the `data` operation type.");
                case 54:
                    throw new AmazonClientException($"Partition: {Fn.GetAttr(context.ArnSsa1, "partition")} from ARN doesn't match with partition name: {Fn.GetAttr(context.PartitionResult, "name")}.");
                case 55:
                    throw new AmazonClientException($"Invalid ARN: ChannelARN only supports `channel` arn types, found: `{context.ArnTypeSsa4}`.");
                case 56:
                    throw new AmazonClientException($"Invalid ARN: The ARN was not for the Kinesis service, found: {Fn.GetAttr(context.ArnSsa1, "service")}.");
                case 57:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 58:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 59:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 60:
                    return new Endpoint($"https://{context.Parameters.AccountId}.{context.Parameters.OperationType}-kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 61:
                    throw new AmazonClientException("Invalid account id.");
                case 62:
                    throw new AmazonClientException("AccountIdEndpointMode is required but no AccountID was provided or able to be loaded");
                case 63:
                    throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this partition");
                case 64:
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                case 65:
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                case 66:
                    return new Endpoint((string)context.Parameters.Endpoint);
                case 67:
                    return new Endpoint($"https://kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 68:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 69:
                    return new Endpoint($"https://kinesis.{context.Parameters.Region}.amazonaws.com");
                case 70:
                    return new Endpoint($"https://kinesis-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 71:
                    return new Endpoint($"https://kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 72:
                    return new Endpoint($"https://kinesis.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 73:
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
                    return (context.ArnSsa2 = ParseArn((string)context.Parameters.ConsumerARN)) != null;
                case 13:
                    return (context.HttpsCustomEndpointSuffixValue = Substring((string)context.Parameters.Endpoint, 15, 20, false)) != null;
                case 14:
                    return Equals((Substring((string)context.Parameters.Endpoint, 15, 16, false) ?? ""), "-");
                case 15:
                    return Equals((Substring((string)context.Parameters.Endpoint, 20, 21, false) ?? ""), ".");
                case 16:
                    return (context.PlainCustomEndpointSuffixValue = Substring((string)context.Parameters.Endpoint, 7, 12, false)) != null;
                case 17:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa2, "accountId"), false);
                case 18:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa2, "region"), false);
                case 19:
                    return Equals(GetAttr(context.ArnSsa2, "service"), "kinesis");
                case 20:
                    return (context.ArnTypeSsa2 = GetAttr(context.ArnSsa2, "resourceId[0]")) != null;
                case 21:
                    return Equals(context.ArnTypeSsa2, "");
                case 22:
                    return (context.ArnSsa4 = ParseArn((string)context.Parameters.StreamARN)) != null;
                case 23:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa4, "accountId"), false);
                case 24:
                    return Equals(context.ArnTypeSsa2, "stream");
                case 25:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa4, "region"), false);
                case 26:
                    return Equals(GetAttr(context.PartitionResult, "name"), GetAttr(context.ArnSsa2, "partition"));
                case 27:
                    return Equals(GetAttr(context.ArnSsa4, "service"), "kinesis");
                case 28:
                    return (context.ArnTypeSsa1 = GetAttr(context.ArnSsa4, "resourceId[0]")) != null;
                case 29:
                    return Equals(context.ArnTypeSsa1, "");
                case 30:
                    return IsSet(context.Parameters.ResourceARN);
                case 31:
                    return IsSet(context.Parameters.ChannelARN);
                case 32:
                    return IsSet(context.Parameters.AccountIdEndpointMode);
                case 33:
                    return IsSet(context.Parameters.AccountId);
                case 34:
                    return (context.ArnSsa1 = ParseArn((string)context.Parameters.ChannelARN)) != null;
                case 35:
                    return Equals(context.Parameters.AccountIdEndpointMode, "disabled");
                case 36:
                    return IsValidHostLabel((string)context.Parameters.AccountId, false);
                case 37:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa1, "accountId"), false);
                case 38:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa1, "region"), false);
                case 39:
                    return Equals(GetAttr(context.ArnSsa1, "service"), "kinesis");
                case 40:
                    return (context.ArnTypeSsa4 = GetAttr(context.ArnSsa1, "resourceId[0]")) != null;
                case 41:
                    return Equals(context.ArnTypeSsa4, "");
                case 42:
                    return Equals(context.ArnTypeSsa4, "channel");
                case 43:
                    return Equals(GetAttr(context.PartitionResult, "name"), GetAttr(context.ArnSsa1, "partition"));
                case 44:
                    return (context.ArnSsa3 = ParseArn((string)context.Parameters.ResourceARN)) != null;
                case 45:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa3, "accountId"), false);
                case 46:
                    return IsValidHostLabel((string)GetAttr(context.ArnSsa3, "region"), false);
                case 47:
                    return Equals(GetAttr(context.ArnSsa3, "service"), "kinesis");
                case 48:
                    return (context.ArnTypeSsa3 = GetAttr(context.ArnSsa3, "resourceId[0]")) != null;
                case 49:
                    return Equals(context.ArnTypeSsa3, "");
                case 50:
                    return Equals(context.ArnTypeSsa3, "stream");
                case 51:
                    return Equals(context.ArnTypeSsa3, "channel");
                case 52:
                    return Equals(GetAttr(context.PartitionResult, "name"), GetAttr(context.ArnSsa3, "partition"));
                case 53:
                    return Equals(context.ArnTypeSsa1, "stream");
                case 54:
                    return Equals(GetAttr(context.PartitionResult, "name"), GetAttr(context.ArnSsa4, "partition"));
                case 55:
                    return Equals(context.Parameters.AccountIdEndpointMode, "required");
                case 56:
                    return IsSet(context.Parameters.OperationType);
                case 57:
                    return (context.ResourceIdSsa1 = GetAttr(context.ArnSsa3, "resourceId[1]")) != null;
                case 58:
                    return IsValidHostLabel((string)context.ResourceIdSsa1, false);
                case 59:
                    return (context.ResourceIdSsa2 = GetAttr(context.ArnSsa1, "resourceId[1]")) != null;
                case 60:
                    return IsValidHostLabel((string)context.ResourceIdSsa2, false);
                case 61:
                    return Equals(context.Parameters.OperationType, "data");
                case 62:
                    return Equals((Substring((string)context.Parameters.Endpoint, 7, 8, false) ?? ""), "-");
                case 63:
                    return Equals(context.Parameters.UseFIPS, true);
                case 64:
                    return Equals(context.Parameters.UseDualStack, true);
                case 65:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                case 66:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 67:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                case 68:
                    return Equals((Substring((string)context.Parameters.Endpoint, 12, 13, false) ?? ""), ".");
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
