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
using Amazon.DynamoDBStreams.Endpoints;

namespace Amazon.DynamoDBStreams.Internal
{
    /// <summary>
    /// Amazon DynamoDBStreams endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="DynamoDBStreamsEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonDynamoDBStreamsEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonDynamoDBStreamsEndpointProvider.Context>
    {
        private sealed class Context
        {
            public DynamoDBStreamsEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ParsedArnSsa2 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ParsedArnSsa1 { get; set; }

            public Context(DynamoDBStreamsEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAAHgAAAADAAAAAQAAAAQF9eEaAAAAAgAAAAUF9eEaAAAAAwAAADQAAAAGAAAABAAAABwAAAAHAAAABwAAAAgF9eEMAAAACAAAAF4AAAAJAAAACQAAAF4AAAAKAAAACgAAAA0AAAALAAAACwAAAA0AAAAMAAAADAAAAA0AAABeAAAADQAAAFsAAAAOAAAADgAAAA8AAAAUAAAADwAAABAAAAAUAAAAEAAAABEAAAAUAAAAEQAAABIAAAAUAAAAEgAAABMAAAAUAAAAEwX14RcAAAAUAAAAFAAAABUAAAAaAAAAFQAAABYAAAAaAAAAFgAAABcAAAAaAAAAFwAAABgAAAAaAAAAGAAAABkAAAAaAAAAGQX14RgAAAAaAAAAGgAAABsAAABbAAAAHAX14RkF9eEJAAAABQAAAB0F9eEWAAAABwAAAB4F9eESAAAACAAAADMAAAAfAAAACQAAADMAAAAgAAAACgAAACMAAAAhAAAACwAAACMAAAAiAAAADAAAACMAAAAzAAAADQAAADIAAAAkAAAADgAAACUAAAAqAAAADwAAACYAAAAqAAAAEAAAACcAAAAqAAAAEQAAACgAAAAqAAAAEgAAACkAAAAqAAAAEwX14RMAAAAqAAAAFAAAACsAAAAwAAAAFQAAACwAAAAwAAAAFgAAAC0AAAAwAAAAFwAAAC4AAAAwAAAAGAAAAC8AAAAwAAAAGQX14RQAAAAwAAAAGgAAADEAAAAyAAAAHAX14RUF9eEJAAAAGwX14QoF9eESAAAAGwX14QQF9eESAAAABAAAAF8AAAA1AAAABgAAADYF9eERAAAABwAAADgAAAA3AAAACgX14QwF9eEQAAAACAAAAFwAAAA5AAAACQAAAFwAAAA6AAAACgAAAEwAAAA7AAAACwAAAD0AAAA8AAAADAAAAD0AAABdAAAADQAAAEsAAAA+AAAADgAAAD8AAABEAAAADwAAAEAAAABEAAAAEAAAAEEAAABEAAAAEQAAAEIAAABEAAAAEgAAAEMAAABEAAAAEwX14Q0AAABEAAAAFAAAAEUAAABKAAAAFQAAAEYAAABKAAAAFgAAAEcAAABKAAAAFwAAAEgAAABKAAAAGAAAAEkAAABKAAAAGQX14Q4AAABKAAAAGgAAAFoAAABLAAAAGwX14QoF9eEQAAAADQAAAFsAAABNAAAADgAAAE4AAABTAAAADwAAAE8AAABTAAAAEAAAAFAAAABTAAAAEQAAAFEAAABTAAAAEgAAAFIAAABTAAAAEwX14Q0AAABTAAAAFAAAAFQAAABZAAAAFQAAAFUAAABZAAAAFgAAAFYAAABZAAAAFwAAAFcAAABZAAAAGAAAAFgAAABZAAAAGQX14Q4AAABZAAAAGgAAAFoAAABbAAAAHAX14Q8F9eEJAAAAGwX14QoF9eEMAAAACgAAAF4AAABdAAAAGwX14QQF9eEQAAAAGwX14QQF9eEMAAAABQAAAGAF9eELAAAABgAAAGEF9eELAAAABwAAAGIF9eEFAAAACAAAAHcAAABjAAAACQAAAHcAAABkAAAACgAAAGcAAABlAAAACwAAAGcAAABmAAAADAAAAGcAAAB3AAAADQAAAHYAAABoAAAADgAAAGkAAABuAAAADwAAAGoAAABuAAAAEAAAAGsAAABuAAAAEQAAAGwAAABuAAAAEgAAAG0AAABuAAAAEwX14QYAAABuAAAAFAAAAG8AAAB0AAAAFQAAAHAAAAB0AAAAFgAAAHEAAAB0AAAAFwAAAHIAAAB0AAAAGAAAAHMAAAB0AAAAGQX14QcAAAB0AAAAGgAAAHUAAAB2AAAAHAX14QgF9eEJAAAAGwX14QoF9eEFAAAAGwX14QQF9eEFAAAAAwX14QEAAAB5AAAABAX14QIF9eED");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for DynamoDBStreamsEndpointParameters.
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

            var typed = (DynamoDBStreamsEndpointParameters)parameters;
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
                    return new Endpoint($"{context.Parameters.Endpoint}");
                case 4:
                    throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region");
                case 5:
                    return new Endpoint($"https://streams-dynamodb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 6:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa2, "accountId")}.streams-ddb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 7:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa1, "accountId")}.streams-ddb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 8:
                    return new Endpoint($"https://{context.Parameters.AccountId}.streams-ddb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 9:
                    throw new AmazonClientException("Credentials-sourced account ID parameter is invalid");
                case 10:
                    throw new AmazonClientException("AccountIdEndpointMode is required but no AccountID was provided or able to be loaded");
                case 11:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 12:
                    return new Endpoint($"https://streams.dynamodb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 13:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa2, "accountId")}.streams-ddb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 14:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa1, "accountId")}.streams-ddb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 15:
                    return new Endpoint($"https://{context.Parameters.AccountId}.streams-ddb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 16:
                    return new Endpoint($"https://streams.dynamodb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 17:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 18:
                    return new Endpoint($"https://streams-dynamodb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 19:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa2, "accountId")}.streams-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 20:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa1, "accountId")}.streams-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 21:
                    return new Endpoint($"https://{context.Parameters.AccountId}.streams-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 22:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 23:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa2, "accountId")}.streams-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 24:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa1, "accountId")}.streams-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 25:
                    return new Endpoint($"https://{context.Parameters.AccountId}.streams-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 26:
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
                    return IsSet(context.Parameters.AccountIdEndpointMode);
                case 8:
                    return Equals(context.Parameters.Region, "me-south-1");
                case 9:
                    return Equals(context.Parameters.Region, "me-central-1");
                case 10:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                case 11:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws");
                case 12:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-cn");
                case 13:
                    return Equals(context.Parameters.AccountIdEndpointMode, "disabled");
                case 14:
                    return IsSet(context.Parameters.StreamArn);
                case 15:
                    return (context.ParsedArnSsa2 = ParseArn((string)context.Parameters.StreamArn)) != null;
                case 16:
                    return Equals(GetAttr(context.ParsedArnSsa2, "region"), context.Parameters.Region);
                case 17:
                    return Equals(GetAttr(context.ParsedArnSsa2, "service"), "dynamodb");
                case 18:
                    return IsValidHostLabel((string)GetAttr(context.ParsedArnSsa2, "accountId"), false);
                case 19:
                    return IsValidHostLabel((string)GetAttr(context.ParsedArnSsa2, "region"), false);
                case 20:
                    return IsSet(context.Parameters.ShardIterator);
                case 21:
                    return (context.ParsedArnSsa1 = ParseArn((string)context.Parameters.ShardIterator)) != null;
                case 22:
                    return Equals(GetAttr(context.ParsedArnSsa1, "region"), context.Parameters.Region);
                case 23:
                    return Equals(GetAttr(context.ParsedArnSsa1, "service"), "dynamodb");
                case 24:
                    return IsValidHostLabel((string)GetAttr(context.ParsedArnSsa1, "region"), false);
                case 25:
                    return IsValidHostLabel((string)GetAttr(context.ParsedArnSsa1, "accountId"), false);
                case 26:
                    return IsSet(context.Parameters.AccountId);
                case 27:
                    return Equals(context.Parameters.AccountIdEndpointMode, "required");
                case 28:
                    return IsValidHostLabel((string)context.Parameters.AccountId, false);
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
