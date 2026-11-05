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
using Amazon.CloudFrontKeyValueStore.Endpoints;

namespace Amazon.CloudFrontKeyValueStore.Internal
{
    /// <summary>
    /// Amazon CloudFrontKeyValueStore endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="CloudFrontKeyValueStoreEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonCloudFrontKeyValueStoreEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonCloudFrontKeyValueStoreEndpointProvider.Context>
    {
        private sealed class Context
        {
            public CloudFrontKeyValueStoreEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ParsedArn { get; set; }
            public object ArnType { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.URL Url { get; set; }

            public Context(CloudFrontKeyValueStoreEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("/////wAAAAH/////AAAAAAX14QwAAAADAAAAAQAAAAQF9eELAAAAAgAAAAUF9eEKAAAAAwAAAAYF9eEJAAAABAAAAAcF9eEIAAAABQAAAAgF9eEHAAAABgX14QcAAAAJAAAABwAAAAoF9eEGAAAACAAAAAsF9eEFAAAACQAAAAwAAAAOAAAACgAAAA0AAAAOAAAACwAAAA4F9eEEAAAADAAAAA8F9eEDAAAADQX14QEF9eEC");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for CloudFrontKeyValueStoreEndpointParameters.
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters["UseFIPS"] == null)
            {
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            }

            var typed = (CloudFrontKeyValueStoreEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    return new Endpoint($"{Fn.GetAttr(context.Url, "scheme")}://{Fn.GetAttr(context.ParsedArn, "accountId")}.{Fn.GetAttr(context.Url, "authority")}{Fn.GetAttr(context.Url, "path")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", "cloudfront-keyvaluestore", null, new List<string> { "*" }, null) },
                    };
                case 2:
                    throw new AmazonClientException("Provided endpoint is not a valid URL");
                case 3:
                    return new Endpoint($"https://{Fn.GetAttr(context.ParsedArn, "accountId")}.cloudfront-kvs.global.api.aws")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4a", "cloudfront-keyvaluestore", null, new List<string> { "*" }, null) },
                    };
                case 4:
                    throw new AmazonClientException($"Client was configured for partition `{Fn.GetAttr(context.PartitionResult, "name")}` but Kvs ARN has `{Fn.GetAttr(context.ParsedArn, "partition")}`");
                case 5:
                    throw new AmazonClientException($"CloudFront-KeyValueStore is not supported in partition `{Fn.GetAttr(context.ParsedArn, "partition")}`");
                case 6:
                    throw new AmazonClientException($"ARN resource type is invalid. Expected `key-value-store`, found: `{context.ArnType}`");
                case 7:
                    throw new AmazonClientException("No resource type found in the KVS ARN. Resource type must be `key-value-store`.");
                case 8:
                    throw new AmazonClientException($"Provided ARN must be a global resource ARN. Found: `{Fn.GetAttr(context.ParsedArn, "region")}`");
                case 9:
                    throw new AmazonClientException($"Provided ARN is not a valid CloudFront Service ARN. Found: `{Fn.GetAttr(context.ParsedArn, "service")}`");
                case 10:
                    throw new AmazonClientException("KVS ARN must be a valid ARN");
                case 11:
                    throw new AmazonClientException("KVS ARN must be provided to use this service");
                case 12:
                    throw new AmazonClientException("Invalid Configuration: FIPS is not supported with CloudFront-KeyValueStore.");
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
                    return Equals(context.Parameters.UseFIPS, true);
                case 1:
                    return IsSet(context.Parameters.KvsARN);
                case 2:
                    return (context.ParsedArn = ParseArn((string)context.Parameters.KvsARN)) != null;
                case 3:
                    return Equals(GetAttr(context.ParsedArn, "service"), "cloudfront");
                case 4:
                    return Equals(GetAttr(context.ParsedArn, "region"), "");
                case 5:
                    return (context.ArnType = GetAttr(context.ParsedArn, "resourceId[0]")) != null;
                case 6:
                    return Equals(context.ArnType, "");
                case 7:
                    return Equals(context.ArnType, "key-value-store");
                case 8:
                    return Equals(GetAttr(context.ParsedArn, "partition"), "aws");
                case 9:
                    return IsSet(context.Parameters.Region);
                case 10:
                    return (context.PartitionResult = Partition((string)context.Parameters.Region)) != null;
                case 11:
                    return Equals(GetAttr(context.ParsedArn, "partition"), GetAttr(context.PartitionResult, "name"));
                case 12:
                    return IsSet(context.Parameters.Endpoint);
                case 13:
                    return (context.Url = ParseURL((string)context.Parameters.Endpoint)) != null;
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
