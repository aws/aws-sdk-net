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
using Amazon.S3Control.Endpoints;

namespace Amazon.S3Control.Internal
{
    /// <summary>
    /// Amazon S3Control endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="S3ControlEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonS3ControlEndpointProvider : IEndpointProvider, IBddConditionEvaluator<AmazonS3ControlEndpointProvider.Context>
    {
        private sealed class Context
        {
            public S3ControlEndpointParameters Parameters { get; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition PartitionResult { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn ResourceArn { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition ArnPartitionSsa3 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.URL Url { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn AccessPointArn { get; set; }
            public object ArnTypeSsa1 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Arn BucketArn { get; set; }
            public object ArnTypeSsa2 { get; set; }
            public object OutpostIdSsa2 { get; set; }
            public object OutpostIdSsa1 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition ArnPartitionSsa2 { get; set; }
            public global::Amazon.Runtime.Internal.Endpoints.StandardLibrary.Partition ArnPartitionSsa1 { get; set; }
            public object OutpostTypeSsa1 { get; set; }
            public object OutpostTypeSsa2 { get; set; }

            public Context(S3ControlEndpointParameters parameters)
            {
                Parameters = parameters;
            }
        }

        private static readonly int[] Nodes = BddNodeDecoder.Decode("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");
        private const int Root = 2;

        /// <summary>
        /// Resolves the endpoint for S3ControlEndpointParameters.
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
            if (parameters["UseDualStack"] == null)
            {
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            }

            var typed = (S3ControlEndpointParameters)parameters;
            var context = new Context(typed);
            var result = BddEvaluator.Evaluate(Nodes, Root, this, context);
            switch (result)
            {
                case 0:
                    throw new AmazonClientException("Cannot resolve endpoint");
                case 1:
                    throw new AmazonClientException("Partition does not support FIPS");
                case 2:
                    throw new AmazonClientException("AccountId is required but not set");
                case 3:
                    throw new AmazonClientException("AccountId must only contain a-z, A-Z, 0-9 and `-`.");
                case 4:
                    throw new AmazonClientException("OutpostId must only contain a-z, A-Z, 0-9 and `-`.");
                case 5:
                    throw new AmazonClientException("Invalid Configuration: DualStack and custom endpoint are not supported");
                case 6:
                    return new Endpoint($"{Fn.GetAttr(context.Url, "scheme")}://{Fn.GetAttr(context.Url, "authority")}{Fn.GetAttr(context.Url, "path")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{context.Parameters.Region}", null, true) },
                    };
                case 7:
                    return new Endpoint($"https://s3-outposts-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{context.Parameters.Region}", null, true) },
                    };
                case 8:
                    return new Endpoint($"https://s3-outposts-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{context.Parameters.Region}", null, true) },
                    };
                case 9:
                    return new Endpoint($"https://s3-outposts.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{context.Parameters.Region}", null, true) },
                    };
                case 10:
                    return new Endpoint($"https://s3-outposts.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{context.Parameters.Region}", null, true) },
                    };
                case 11:
                    throw new AmazonClientException("Invalid region: region was not a valid DNS name.");
                case 12:
                    throw new AmazonClientException($"Invalid configuration: region from ARN `{Fn.GetAttr(context.ResourceArn, "region")}` does not match client region `{context.Parameters.Region}` and UseArnRegion is `false`");
                case 13:
                    throw new AmazonClientException("S3Express does not support Dual-stack.");
                case 14:
                    return new Endpoint($"{Fn.GetAttr(context.Url, "scheme")}://{Fn.GetAttr(context.Url, "authority")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3express", $"{context.Parameters.Region}", null, true) },
                    };
                case 15:
                    return new Endpoint($"https://s3express-control-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3express", $"{context.Parameters.Region}", null, true) },
                    };
                case 16:
                    return new Endpoint($"https://s3express-control.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3express", $"{context.Parameters.Region}", null, true) },
                    };
                case 17:
                    throw new AmazonClientException($"Client was configured for partition `{Fn.GetAttr(context.PartitionResult, "name")}` but ARN has `{Fn.GetAttr(context.ArnPartitionSsa3, "name")}`");
                case 18:
                    throw new AmazonClientException("Unrecognized S3Express Access Point name format.");
                case 19:
                    throw new AmazonClientException("S3 Snow does not support DualStack");
                case 20:
                    throw new AmazonClientException("S3 Snow does not support FIPS");
                case 21:
                    return new Endpoint($"{Fn.GetAttr(context.Url, "scheme")}://{Fn.GetAttr(context.Url, "authority")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 22:
                    throw new AmazonClientException($"Invalid configuration: region from ARN `{Fn.GetAttr(context.AccessPointArn, "region")}` does not match client region `{context.Parameters.Region}` and UseArnRegion is `false`");
                case 23:
                    throw new AmazonClientException($"Invalid ARN: the accountId specified in the ARN (`{Fn.GetAttr(context.AccessPointArn, "accountId")}`) does not match the parameter (`{context.Parameters.AccountId}`)");
                case 24:
                    return new Endpoint($"https://s3-outposts-fips.{Fn.GetAttr(context.AccessPointArn, "region")}.{Fn.GetAttr(context.ArnPartitionSsa1, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{Fn.GetAttr(context.AccessPointArn, "region")}", null, true) },
                        Headers = new Dictionary<string, IList<string>> { ["x-amz-account-id"] = new List<string> { $"{Fn.GetAttr(context.AccessPointArn, "accountId")}" }, ["x-amz-outpost-id"] = new List<string> { $"{context.OutpostIdSsa1}" } },
                    };
                case 25:
                    return new Endpoint($"https://s3-outposts-fips.{Fn.GetAttr(context.AccessPointArn, "region")}.{Fn.GetAttr(context.ArnPartitionSsa1, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{Fn.GetAttr(context.AccessPointArn, "region")}", null, true) },
                        Headers = new Dictionary<string, IList<string>> { ["x-amz-account-id"] = new List<string> { $"{Fn.GetAttr(context.AccessPointArn, "accountId")}" }, ["x-amz-outpost-id"] = new List<string> { $"{context.OutpostIdSsa1}" } },
                    };
                case 26:
                    return new Endpoint($"https://s3-outposts.{Fn.GetAttr(context.AccessPointArn, "region")}.{Fn.GetAttr(context.ArnPartitionSsa1, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{Fn.GetAttr(context.AccessPointArn, "region")}", null, true) },
                        Headers = new Dictionary<string, IList<string>> { ["x-amz-account-id"] = new List<string> { $"{Fn.GetAttr(context.AccessPointArn, "accountId")}" }, ["x-amz-outpost-id"] = new List<string> { $"{context.OutpostIdSsa1}" } },
                    };
                case 27:
                    return new Endpoint($"{Fn.GetAttr(context.Url, "scheme")}://{Fn.GetAttr(context.Url, "authority")}{Fn.GetAttr(context.Url, "path")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{Fn.GetAttr(context.AccessPointArn, "region")}", null, true) },
                        Headers = new Dictionary<string, IList<string>> { ["x-amz-account-id"] = new List<string> { $"{Fn.GetAttr(context.AccessPointArn, "accountId")}" }, ["x-amz-outpost-id"] = new List<string> { $"{context.OutpostIdSsa1}" } },
                    };
                case 28:
                    return new Endpoint($"https://s3-outposts.{Fn.GetAttr(context.AccessPointArn, "region")}.{Fn.GetAttr(context.ArnPartitionSsa1, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{Fn.GetAttr(context.AccessPointArn, "region")}", null, true) },
                        Headers = new Dictionary<string, IList<string>> { ["x-amz-account-id"] = new List<string> { $"{Fn.GetAttr(context.AccessPointArn, "accountId")}" }, ["x-amz-outpost-id"] = new List<string> { $"{context.OutpostIdSsa1}" } },
                    };
                case 29:
                    throw new AmazonClientException($"Expected an outpost type `accesspoint`, found `{context.OutpostTypeSsa1}`");
                case 30:
                    throw new AmazonClientException("Invalid ARN: expected an access point name");
                case 31:
                    throw new AmazonClientException("Invalid ARN: Expected a 4-component resource");
                case 32:
                    throw new AmazonClientException($"Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `{Fn.GetAttr(context.AccessPointArn, "accountId")}`");
                case 33:
                    throw new AmazonClientException("Invalid ARN: missing account ID");
                case 34:
                    throw new AmazonClientException($"Invalid region in ARN: `{Fn.GetAttr(context.AccessPointArn, "region")}` (invalid DNS name)");
                case 35:
                    throw new AmazonClientException($"Client was configured for partition `{Fn.GetAttr(context.PartitionResult, "name")}` but ARN has `{Fn.GetAttr(context.ArnPartitionSsa1, "name")}`");
                case 36:
                    throw new AmazonClientException($"Invalid ARN: The outpost Id must only contain a-z, A-Z, 0-9 and `-`., found: `{context.OutpostIdSsa1}`");
                case 37:
                    throw new AmazonClientException("Invalid ARN: The Outpost Id was not set");
                case 38:
                    throw new AmazonClientException("Invalid ARN: No ARN type specified");
                case 39:
                    throw new AmazonClientException($"Invalid configuration: region from ARN `{Fn.GetAttr(context.BucketArn, "region")}` does not match client region `{context.Parameters.Region}` and UseArnRegion is `false`");
                case 40:
                    throw new AmazonClientException($"Invalid ARN: the accountId specified in the ARN (`{Fn.GetAttr(context.BucketArn, "accountId")}`) does not match the parameter (`{context.Parameters.AccountId}`)");
                case 41:
                    return new Endpoint($"https://s3-outposts-fips.{Fn.GetAttr(context.BucketArn, "region")}.{Fn.GetAttr(context.ArnPartitionSsa2, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{Fn.GetAttr(context.BucketArn, "region")}", null, true) },
                        Headers = new Dictionary<string, IList<string>> { ["x-amz-account-id"] = new List<string> { $"{Fn.GetAttr(context.BucketArn, "accountId")}" }, ["x-amz-outpost-id"] = new List<string> { $"{context.OutpostIdSsa2}" } },
                    };
                case 42:
                    return new Endpoint($"https://s3-outposts-fips.{Fn.GetAttr(context.BucketArn, "region")}.{Fn.GetAttr(context.ArnPartitionSsa2, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{Fn.GetAttr(context.BucketArn, "region")}", null, true) },
                        Headers = new Dictionary<string, IList<string>> { ["x-amz-account-id"] = new List<string> { $"{Fn.GetAttr(context.BucketArn, "accountId")}" }, ["x-amz-outpost-id"] = new List<string> { $"{context.OutpostIdSsa2}" } },
                    };
                case 43:
                    return new Endpoint($"https://s3-outposts.{Fn.GetAttr(context.BucketArn, "region")}.{Fn.GetAttr(context.ArnPartitionSsa2, "dualStackDnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{Fn.GetAttr(context.BucketArn, "region")}", null, true) },
                        Headers = new Dictionary<string, IList<string>> { ["x-amz-account-id"] = new List<string> { $"{Fn.GetAttr(context.BucketArn, "accountId")}" }, ["x-amz-outpost-id"] = new List<string> { $"{context.OutpostIdSsa2}" } },
                    };
                case 44:
                    return new Endpoint($"{Fn.GetAttr(context.Url, "scheme")}://{Fn.GetAttr(context.Url, "authority")}{Fn.GetAttr(context.Url, "path")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{Fn.GetAttr(context.BucketArn, "region")}", null, true) },
                        Headers = new Dictionary<string, IList<string>> { ["x-amz-account-id"] = new List<string> { $"{Fn.GetAttr(context.BucketArn, "accountId")}" }, ["x-amz-outpost-id"] = new List<string> { $"{context.OutpostIdSsa2}" } },
                    };
                case 45:
                    return new Endpoint($"https://s3-outposts.{Fn.GetAttr(context.BucketArn, "region")}.{Fn.GetAttr(context.ArnPartitionSsa2, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3-outposts", $"{Fn.GetAttr(context.BucketArn, "region")}", null, true) },
                        Headers = new Dictionary<string, IList<string>> { ["x-amz-account-id"] = new List<string> { $"{Fn.GetAttr(context.BucketArn, "accountId")}" }, ["x-amz-outpost-id"] = new List<string> { $"{context.OutpostIdSsa2}" } },
                    };
                case 46:
                    throw new AmazonClientException($"Invalid ARN: Expected an outpost type `bucket`, found `{context.OutpostTypeSsa2}`");
                case 47:
                    throw new AmazonClientException("Invalid ARN: expected a bucket name");
                case 48:
                    throw new AmazonClientException($"Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `{Fn.GetAttr(context.BucketArn, "accountId")}`");
                case 49:
                    throw new AmazonClientException($"Invalid region in ARN: `{Fn.GetAttr(context.BucketArn, "region")}` (invalid DNS name)");
                case 50:
                    throw new AmazonClientException($"Client was configured for partition `{Fn.GetAttr(context.PartitionResult, "name")}` but ARN has `{Fn.GetAttr(context.ArnPartitionSsa2, "name")}`");
                case 51:
                    throw new AmazonClientException($"Invalid ARN: The outpost Id must only contain a-z, A-Z, 0-9 and `-`., found: `{context.OutpostIdSsa2}`");
                case 52:
                    return new Endpoint($"{Fn.GetAttr(context.Url, "scheme")}://{context.Parameters.AccountId}.{Fn.GetAttr(context.Url, "authority")}{Fn.GetAttr(context.Url, "path")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 53:
                    return new Endpoint($"{Fn.GetAttr(context.Url, "scheme")}://{Fn.GetAttr(context.Url, "authority")}{Fn.GetAttr(context.Url, "path")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 54:
                    return new Endpoint($"https://{context.Parameters.AccountId}.s3-control-fips.dualstack.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 55:
                    return new Endpoint($"https://s3-control-fips.dualstack.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 56:
                    return new Endpoint($"https://{context.Parameters.AccountId}.s3-control-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 57:
                    return new Endpoint($"https://s3-control-fips.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 58:
                    return new Endpoint($"https://{context.Parameters.AccountId}.s3-control.dualstack.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 59:
                    return new Endpoint($"https://s3-control.dualstack.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 60:
                    return new Endpoint($"https://{context.Parameters.AccountId}.s3-control.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 61:
                    return new Endpoint($"https://s3-control.{context.Parameters.Region}.{Fn.GetAttr(context.PartitionResult, "dnsSuffix")}")
                    {
                        AuthSchemes = new AuthScheme[] { new AuthScheme("sigv4", "s3", $"{context.Parameters.Region}", null, true) },
                    };
                case 62:
                    throw new AmazonClientException("Region must be set");
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
                    return Equals(context.Parameters.UseFIPS, true);
                case 3:
                    return Equals(GetAttr(context.PartitionResult, "name"), "aws-cn");
                case 4:
                    return IsSet(context.Parameters.OutpostId);
                case 5:
                    return IsValidHostLabel((string)context.Parameters.OutpostId, false);
                case 6:
                    return IsSet(context.Parameters.ResourceArn);
                case 7:
                    return (context.ResourceArn = ParseArn((string)context.Parameters.ResourceArn)) != null;
                case 8:
                    return Equals(GetAttr(context.ResourceArn, "service"), "s3express");
                case 9:
                    return (context.ArnPartitionSsa3 = Partition((string)GetAttr(context.ResourceArn, "region"))) != null;
                case 10:
                    return Equals(GetAttr(context.ArnPartitionSsa3, "name"), GetAttr(context.PartitionResult, "name"));
                case 11:
                    return IsSet(context.Parameters.Endpoint);
                case 12:
                    return Equals(context.Parameters.UseDualStack, true);
                case 13:
                    return Equals((context.Parameters.UseS3ExpressControlEndpoint ?? false), true);
                case 14:
                    return (context.Url = ParseURL((string)context.Parameters.Endpoint)) != null;
                case 15:
                    return IsSet(context.Parameters.AccessPointName);
                case 16:
                    return Equals((Substring((string)context.Parameters.AccessPointName, 0, 7, true) ?? ""), "--xa-s3");
                case 17:
                    return Substring((string)context.Parameters.AccessPointName, 7, 15, true) != null;
                case 18:
                    return Equals((Substring((string)context.Parameters.AccessPointName, 15, 17, true) ?? ""), "--");
                case 19:
                    return Substring((string)context.Parameters.AccessPointName, 7, 16, true) != null;
                case 20:
                    return Equals(context.Parameters.Region, "snow");
                case 21:
                    return (context.AccessPointArn = ParseArn((string)context.Parameters.AccessPointName)) != null;
                case 22:
                    return (context.ArnTypeSsa1 = GetAttr(context.AccessPointArn, "resourceId[0]")) != null;
                case 23:
                    return IsSet(context.Parameters.Bucket);
                case 24:
                    return (context.BucketArn = ParseArn((string)context.Parameters.Bucket)) != null;
                case 25:
                    return (context.ArnTypeSsa2 = GetAttr(context.BucketArn, "resourceId[0]")) != null;
                case 26:
                    return Equals(context.ArnTypeSsa2, "");
                case 27:
                    return Equals(GetAttr(context.BucketArn, "service"), "s3-outposts");
                case 28:
                    return (context.OutpostIdSsa2 = GetAttr(context.BucketArn, "resourceId[1]")) != null;
                case 29:
                    return Equals((Substring((string)context.Parameters.AccessPointName, 16, 18, true) ?? ""), "--");
                case 30:
                    return Equals(context.ArnTypeSsa1, "");
                case 31:
                    return Equals(GetAttr(context.AccessPointArn, "service"), "s3-outposts");
                case 32:
                    return (context.OutpostIdSsa1 = GetAttr(context.AccessPointArn, "resourceId[1]")) != null;
                case 33:
                    return IsSet(context.Parameters.AccountId);
                case 34:
                    return IsValidHostLabel((string)context.Parameters.AccountId, false);
                case 35:
                    return Equals((context.Parameters.RequiresAccountId ?? false), true);
                case 36:
                    return Equals(context.Parameters.AccountId, GetAttr(context.AccessPointArn, "accountId"));
                case 37:
                    return IsValidHostLabel((string)context.Parameters.Region, true);
                case 38:
                    return Equals(context.Parameters.AccountId, GetAttr(context.BucketArn, "accountId"));
                case 39:
                    return Equals((context.Parameters.UseArnRegion ?? true), true);
                case 40:
                    return IsValidHostLabel((string)context.OutpostIdSsa2, false);
                case 41:
                    return Equals(context.Parameters.Region, GetAttr(context.AccessPointArn, "region"));
                case 42:
                    return Equals(context.Parameters.Region, GetAttr(context.BucketArn, "region"));
                case 43:
                    return (context.ArnPartitionSsa2 = Partition((string)GetAttr(context.BucketArn, "region"))) != null;
                case 44:
                    return Equals(GetAttr(context.ArnPartitionSsa2, "name"), GetAttr(context.PartitionResult, "name"));
                case 45:
                    return IsValidHostLabel((string)GetAttr(context.BucketArn, "region"), true);
                case 46:
                    return Equals(GetAttr(context.BucketArn, "accountId"), "");
                case 47:
                    return IsValidHostLabel((string)GetAttr(context.BucketArn, "accountId"), false);
                case 48:
                    return IsValidHostLabel((string)context.OutpostIdSsa1, false);
                case 49:
                    return (context.ArnPartitionSsa1 = Partition((string)GetAttr(context.AccessPointArn, "region"))) != null;
                case 50:
                    return Equals(GetAttr(context.ArnPartitionSsa1, "name"), GetAttr(context.PartitionResult, "name"));
                case 51:
                    return IsValidHostLabel((string)GetAttr(context.AccessPointArn, "region"), true);
                case 52:
                    return Equals(GetAttr(context.AccessPointArn, "accountId"), "");
                case 53:
                    return IsValidHostLabel((string)GetAttr(context.AccessPointArn, "accountId"), false);
                case 54:
                    return Substring((string)context.Parameters.AccessPointName, 7, 20, true) != null;
                case 55:
                    return Equals((Substring((string)context.Parameters.AccessPointName, 20, 22, true) ?? ""), "--");
                case 56:
                    return Substring((string)context.Parameters.AccessPointName, 7, 21, true) != null;
                case 57:
                    return Equals((Substring((string)context.Parameters.AccessPointName, 21, 23, true) ?? ""), "--");
                case 58:
                    return (context.OutpostTypeSsa1 = GetAttr(context.AccessPointArn, "resourceId[2]")) != null;
                case 59:
                    return GetAttr(context.AccessPointArn, "resourceId[3]") != null;
                case 60:
                    return Equals(context.OutpostTypeSsa1, "accesspoint");
                case 61:
                    return Substring((string)context.Parameters.AccessPointName, 7, 27, true) != null;
                case 62:
                    return Equals((Substring((string)context.Parameters.AccessPointName, 27, 29, true) ?? ""), "--");
                case 63:
                    return (context.OutpostTypeSsa2 = GetAttr(context.BucketArn, "resourceId[2]")) != null;
                case 64:
                    return GetAttr(context.BucketArn, "resourceId[3]") != null;
                case 65:
                    return Equals(context.OutpostTypeSsa2, "bucket");
                case 66:
                    return Equals(context.Parameters.Region, GetAttr(context.ResourceArn, "region"));
                default:
                    throw new AmazonClientException($"Unknown BDD condition index {conditionIndex}");
            }
        }
    }
}
