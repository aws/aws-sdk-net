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
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;
using Amazon.S3Control.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace Amazon.S3Control.Internal
{
    /// <summary>
    /// Shared helper methods for S3 ARNs
    /// </summary>
    public static class S3ArnUtils
    {
        private static readonly char[] separators = new char[] { '/', '?' };

        /// <summary>
        /// An array of the characters which split sections of an ARN
        /// </summary>
        public static readonly char[] ArnSplit = new char[] { '/', ':' };
        
        /// <summary>
        /// Service name of S3 outposts
        /// </summary>
        public const string S3OutpostsService = "s3-outposts";
        
        /// <summary>
        /// Service name of S3
        /// </summary>
        public const string S3Service = "s3";
        
        /// <summary>
        /// If the ARN contains an account ID and the request does not, then return it.
        /// Throw an exception if there is a mismatch, or if neither the ARN or the
        /// request contain an account Id.
        /// </summary>
        /// <param name="requestAccountId">The account ID in the request</param>
        /// <param name="arnAccountId">The account ID in the ARN</param>
        /// <returns>A string Account ID</returns>
        internal static string GetAccountIdBasedOnArn(string requestAccountId, string arnAccountId)
        {
            if (!string.IsNullOrEmpty(arnAccountId) && !string.IsNullOrEmpty(requestAccountId)
                && !string.Equals(arnAccountId, requestAccountId))
            {
                throw new AmazonClientException("Account ID mismatch, the Account ID cannot be specified in an ARN and in the accountId field");
            }
            if (string.IsNullOrEmpty(arnAccountId) && string.IsNullOrEmpty(requestAccountId))
            {
                throw new AmazonClientException("Invalid ARN, Account ID not set");
            }
            if (string.IsNullOrEmpty(requestAccountId) && !(arnAccountId.Length == 12 && arnAccountId.ToCharArray().All(x => char.IsDigit(x))))
            {
                throw new AmazonAccountIdException();
            }

            return !string.IsNullOrEmpty(requestAccountId) ? requestAccountId : arnAccountId;
        }

        /// <summary>
        /// Get the endpoint for an outpost request which doesn't use
        /// an ARN.
        /// </summary>
        /// <param name="config">The client config object for this request</param>
        /// <returns>The Uri Endpoint for the outpost request</returns>
        internal static Uri GetNonStandardOutpostIdEndpoint(IClientConfig config)
        {
            return new UriBuilder($"{(config.UseHttp ? "http" : "https")}" +
                    $"://s3-outposts.{config.RegionEndpoint.SystemName}.{config.RegionEndpoint.PartitionDnsSuffix}").Uri;
        }

        /// <summary>
        /// Check if the request resource is an outpost resource.
        /// </summary>
        /// <param name="request">The S3 request object</param>
        /// <returns>A boolean value of whether or not the resource path contains an outpost resource</returns>
        internal static bool ResourcePathContainsOutpostsResource(IRequest request)
        {
            Arn arn;
            return RequestContainsArn(request, out arn) 
                && arn.IsOutpostArn();
        }

        /// <summary>
        /// Check the outpost id against certain criteria.
        /// </summary>
        /// <param name="outpostId">The outpost id to be checked</param>
        /// <returns>A boolean whether or not the string is an outpost Id</returns>
        public static bool IsValidOutpostId(string outpostId)
        {
            return outpostId.Length <= 63 && outpostId.Length >= 1
                        && outpostId.All(x => char.IsLetterOrDigit(x) || x == '-');
        }

        /// <summary>
        /// Check the many places that the ARN could be in an S3 Control request
        /// for an ARN. 
        /// <ul>
        /// <li> CreateAccessPoint can contain the ARN in the payload </li>
        /// <li> ListAccessPoints can contain an ARN in the query params </li>
        /// <li> Most other requests can contain an ARN in the resource path </li>
        /// </ul>
        /// </summary>
        /// <param name="request">The request being sent to S3Control</param>
        /// <param name="arn">Any ARN found in the request</param>
        /// <returns>A boolean of whether or not the request contains an ARN</returns>
        internal static bool RequestContainsArn(IRequest request, out Arn arn)
        {
            var createAccessPointRequest = request.OriginalRequest as CreateAccessPointRequest;
            if (createAccessPointRequest != null && createAccessPointRequest.IsSetBucket() 
                && Arn.TryParse(createAccessPointRequest.Bucket.Trim().Trim(separators), out arn))
            {
                return true;
            }
            return DictionaryContainsArn(request.PathResources, out arn)
                || DictionaryContainsArn(request.Parameters, out arn);
        }

        /// <summary>
        /// Check if the value of any dictionary item
        /// is of type ARN.
        /// <b>Note:</b> this assumes that there is just 0-1 ARN in the path resource dictionary
        /// </summary>
        /// <param name="dictValues">The dictionary</param>
        /// <param name="arn">ARN found in dictionary</param>
        /// <returns>A boolean whether or not the dictionary contains an ARN in the values</returns>
        internal static bool DictionaryContainsArn(IDictionary<string, string> dictValues, out Arn arn)
        {
            Arn outArn = null;
            var matchingKvp = dictValues.FirstOrDefault(kvp => Arn.TryParse(kvp.Value, out outArn));
            arn = matchingKvp.Value != null ? outArn : null;
            return arn != null;
        }

        /// <summary>
        /// Replace the ARNs in the dictionary
        /// with the extracted bucket or access point name.
        /// <b>Note:</b> this assumes that there is just 0-1 ARN in the path resource dictionary
        /// </summary>
        /// <param name="dictValues">The dictionary of values</param>
        /// <param name="bucketOrAccessPointName">bucket or access point name</param>
        public static void ReplacePathResourceArns(IDictionary<string, string> dictValues, string bucketOrAccessPointName)
        {
            var matchingKvp = dictValues.FirstOrDefault(kvp => Arn.TryParse(kvp.Value, out _));
            if (!matchingKvp.Equals(default(KeyValuePair<string, string>)))
            {
                dictValues[matchingKvp.Key] = bucketOrAccessPointName;
            }
        }

        /// <summary>
        /// Need to hardcode special cases where the outpost ID can be set
        /// but there is no ARN in the request.
        /// </summary>
        /// <param name="request">An AmazonWebServiceRequest object</param>
        /// <param name="outpostId">The outpost id found in the request</param>
        /// <returns>A boolean of whether or not the request contains a non-null outpost ID</returns>
        public static bool DoesRequestHaveOutpostId(AmazonWebServiceRequest request, out string outpostId)
        {
            var createBucketRequest = request as CreateBucketRequest;
            var listRegionalBucketsRequest = request as ListRegionalBucketsRequest;
            var createAccessPointRequest = request as CreateAccessPointRequest;
            outpostId = createBucketRequest?.OutpostId ?? listRegionalBucketsRequest?.OutpostId 
                ?? createAccessPointRequest?.OutpostId;
            return outpostId != null;
        }
    }
}
