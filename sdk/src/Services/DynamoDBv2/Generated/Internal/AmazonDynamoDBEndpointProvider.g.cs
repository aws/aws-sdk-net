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
using Amazon.DynamoDBv2.Endpoints;

namespace Amazon.DynamoDBv2.Internal
{
    /// <summary>
    /// Amazon DynamoDB endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="DynamoDBEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonDynamoDBEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonDynamoDBEndpointProvider.Context>
    {
        private sealed class Context
        {
            public DynamoDBEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.URL ParsedEndpoint { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ParsedArnSsa2 { get; set; }
            public object FirstArn { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ParsedArnSsa1 { get; set; }

            public Context(DynamoDBEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAAAAAYAAAADAAAAAQAAAAQF9eEjAAAAAgX14QEAAAAFAAAAAwX14QIF9eEEAAAAAQAAAFUAAAAHAAAAAgAAAEUAAAAIAAAAAwAAACYAAAAJAAAABAAAAAoF9eEjAAAABQX14QcAAAALAAAACwAAAAwAAABNAAAADAAAABIAAAANAAAADQAAABIAAAAOAAAADgAAABIAAAAPAAAADwAAABIAAAAQAAAAEAAAABIAAAARAAAAIAX14REAAABNAAAAEQAAACUAAAATAAAAEgAAABQAAAAZAAAAEwAAABUAAAAZAAAAFAAAABYAAAAZAAAAFQAAABcAAAAZAAAAFgAAABgAAAAZAAAAFwAAACQAAAAZAAAAGAAAABoAAAAgAAAAGQAAABsAAAAgAAAAGgAAABwAAAAgAAAAGwAAAB0AAAAgAAAAHAAAAB4AAAAgAAAAHQAAAB8AAAAgAAAAHgAAACMAAAAgAAAAHwAAACEAAAAlAAAAIQAAACIF9eEaAAAAIwX14SEF9eEiAAAAIwX14R8F9eEgAAAAIwX14R0F9eEeAAAAIAX14RsAAABNAAAABAAAACcF9eEjAAAABQX14QYAAAAoAAAACQAAACkF9eEcAAAACwAAACoAAABEAAAADAAAADAAAAArAAAADQAAADAAAAAsAAAADgAAADAAAAAtAAAADwAAADAAAAAuAAAAEAAAADAAAAAvAAAAIAX14REAAABEAAAAEQAAAEMAAAAxAAAAEgAAADIAAAA3AAAAEwAAADMAAAA3AAAAFAAAADQAAAA3AAAAFQAAADUAAAA3AAAAFgAAADYAAAA3AAAAFwAAAEIAAAA3AAAAGAAAADgAAAA+AAAAGQAAADkAAAA+AAAAGgAAADoAAAA+AAAAGwAAADsAAAA+AAAAHAAAADwAAAA+AAAAHQAAAD0AAAA+AAAAHgAAAEEAAAA+AAAAHwAAAD8AAABDAAAAIQAAAEAF9eEaAAAAIwX14RgF9eEZAAAAIwX14RYF9eEXAAAAIwX14RQF9eEVAAAAIAX14RsAAABEAAAAIwX14RIF9eETAAAAAwAAAE4AAABGAAAABAAAAEcF9eEjAAAABQX14QUAAABIAAAABgAAAEkF9eEQAAAACwAAAEoAAABLAAAAIAX14QgAAABLAAAAIgAAAE0AAABMAAAAIwX14Q4F9eEPAAAAIwX14QwF9eENAAAABAAAAE8F9eEjAAAABQX14QUAAABQAAAABgAAAFEF9eELAAAACQAAAFIF9eELAAAACwAAAFMAAABUAAAAIAX14QgAAABUAAAAIwX14QkF9eEKAAAAAgX14QEAAABWAAAAAwX14QIAAABXAAAABAAAAFgF9eEEAAAABwAAAFkF9eEEAAAACAX14QMAAABaAAAACgX14QMF9eEE");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for DynamoDBEndpointParameters.
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

            var typed = (DynamoDBEndpointParameters)parameters;
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
                    throw new AmazonClientException("Endpoint override is not supported for dual-stack endpoints. Please enable dual-stack functionality by enabling the configuration. For more details, see: https://docs.aws.amazon.com/sdkref/latest/guide/feature-endpoints.html");
                case 4:
                    return new Endpoint($"{context.Parameters.Endpoint}");
                case 5:
                    throw new AmazonClientException("Invalid Configuration: FIPS and local endpoint are not supported");
                case 6:
                    throw new AmazonClientException("Invalid Configuration: Dualstack and local endpoint are not supported");
                case 7:
                    return new Endpoint("http://localhost:8000")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "dynamodb", "us-east-1", null, null) },
                    };
                case 8:
                    throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required and FIPS is enabled, but FIPS account endpoints are not supported");
                case 9:
                    return new Endpoint($"https://search-dynamodb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 10:
                    return new Endpoint($"https://dynamodb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 11:
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                case 12:
                    return new Endpoint($"https://search-dynamodb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 13:
                    return new Endpoint($"https://dynamodb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 14:
                    return new Endpoint($"https://search-dynamodb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 15:
                    return new Endpoint($"https://dynamodb-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}");
                case 16:
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                case 17:
                    throw new AmazonClientException("Invalid Configuration: AccountIdEndpointMode is required but account endpoints are not supported in this region");
                case 18:
                    return new Endpoint($"https://search-dynamodb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 19:
                    return new Endpoint($"https://dynamodb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}");
                case 20:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa2, "accountId")}.search-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 21:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa2, "accountId")}.ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 22:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa1, "accountId")}.search-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 23:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa1, "accountId")}.ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 24:
                    return new Endpoint($"https://{context.Parameters.AccountId}.search-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 25:
                    return new Endpoint($"https://{context.Parameters.AccountId}.ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 26:
                    throw new AmazonClientException("Credentials-sourced account ID parameter is invalid");
                case 27:
                    throw new AmazonClientException("AccountIdEndpointMode is required but no AccountID was provided or able to be loaded");
                case 28:
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                case 29:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa2, "accountId")}.search-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 30:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa2, "accountId")}.ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 31:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa1, "accountId")}.search-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 32:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArnSsa1, "accountId")}.ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 33:
                    return new Endpoint($"https://{context.Parameters.AccountId}.search-ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 34:
                    return new Endpoint($"https://{context.Parameters.AccountId}.ddb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        Attributes = new PropertyBag { ["metricValues"] = new List<object> { "O" } },
                    };
                case 35:
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
                    return Equals(context.Parameters.UseFIPS, true);
                case 3:
                    return Equals(context.Parameters.UseDualStack, true);
                case 4:
                    return (context.PartitionResult = Partition((string)context.Parameters.Region)) != null;
                case 5:
                    return Equals(context.Parameters.Region, "local");
                case 6:
                    return Equals(GetAttr(context.PartitionResult, "supportsFIPS"), true);
                case 7:
                    return (context.ParsedEndpoint = ParseURL((string)context.Parameters.Endpoint)) != null;
                case 8:
                    return Equals($"dynamodb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}", GetAttr(context.ParsedEndpoint, "authority"));
                case 9:
                    return Equals(GetAttr(context.PartitionResult, "supportsDualStack"), true);
                case 10:
                    return Equals($"search-dynamodb.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}", GetAttr(context.ParsedEndpoint, "authority"));
                case 11:
                    return IsSet(context.Parameters.AccountIdEndpointMode);
                case 12:
                    return Equals(context.Parameters.Region, "us-gov-east-1");
                case 13:
                    return Equals(context.Parameters.Region, "cn-north-1");
                case 14:
                    return Equals(context.Parameters.Region, "cn-northwest-1");
                case 15:
                    return Equals(context.Parameters.Region, "us-gov-west-1");
                case 16:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws");
                case 17:
                    return Equals(context.Parameters.AccountIdEndpointMode, "disabled");
                case 18:
                    return IsSet(context.Parameters.ResourceArn);
                case 19:
                    return (context.ParsedArnSsa2 = ParseArn((string)context.Parameters.ResourceArn)) != null;
                case 20:
                    return Equals(GetAttr(context.ParsedArnSsa2, "service"), "dynamodb");
                case 21:
                    return Equals(GetAttr(context.ParsedArnSsa2, "region"), context.Parameters.Region);
                case 22:
                    return IsValidHostLabel((string)GetAttr(context.ParsedArnSsa2, "accountId"), false);
                case 23:
                    return IsValidHostLabel((string)GetAttr(context.ParsedArnSsa2, "region"), false);
                case 24:
                    return IsSet(context.Parameters.ResourceArnList);
                case 25:
                    return (context.FirstArn = GetAttr(context.Parameters.ResourceArnList, "[0]")) != null;
                case 26:
                    return (context.ParsedArnSsa1 = ParseArn((string)context.FirstArn)) != null;
                case 27:
                    return Equals(GetAttr(context.ParsedArnSsa1, "region"), context.Parameters.Region);
                case 28:
                    return Equals(GetAttr(context.ParsedArnSsa1, "service"), "dynamodb");
                case 29:
                    return IsValidHostLabel((string)GetAttr(context.ParsedArnSsa1, "accountId"), false);
                case 30:
                    return IsValidHostLabel((string)GetAttr(context.ParsedArnSsa1, "region"), false);
                case 31:
                    return IsSet(context.Parameters.AccountId);
                case 32:
                    return Equals(context.Parameters.AccountIdEndpointMode, "required");
                case 33:
                    return IsValidHostLabel((string)context.Parameters.AccountId, false);
                case 34:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-us-gov");
                case 35:
                    return Equals((context.Parameters.IsSearchOperation ?? false), true);
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
