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
 * Do not modify this file. This file is generated from the ep2-parse-arn-2022-08-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.Ep2parsearn.Internal
{
    /// <summary>
    /// Amazon Ep2parsearn endpoint provider.
    /// Resolves endpoint for given set of Ep2parsearnEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonEp2parsearnEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for Ep2parsearnEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");


            var refs = new Dictionary<string, object>()
            {
                ["Region"] = parameters["Region"],
                ["Bucket"] = parameters["Bucket"],
                ["TestCaseId"] = parameters["TestCaseId"],
            };
            if (IsSet(refs["TestCaseId"]) && IsSet(refs["Bucket"]) && Equals(Interpolate(@"{TestCaseId}", refs), "invalid-arn"))
            {
                if (ParseArn(Interpolate(@"{Bucket}", refs)) != null)
                {
                    throw new AmazonClientException(Interpolate(@"A valid ARN was parsed but `{Bucket}` is not a valid ARN", refs));
                }
                throw new AmazonClientException(Interpolate(@"Test case passed: `{Bucket}` is not a valid ARN.", refs));
            }
            if (IsSet(refs["TestCaseId"]) && IsSet(refs["Bucket"]) && Equals(Interpolate(@"{TestCaseId}", refs), "valid-arn"))
            {
                if ((refs["arn"] = ParseArn(Interpolate(@"{Bucket}", refs))) != null && (refs["resource"] = GetAttr(refs["arn"], "resourceId[0]")) != null)
                {
                    throw new AmazonClientException(Interpolate(@"Test case passed: A valid ARN was parsed: service: `{arn#service}`, partition: `{arn#partition}, region: `{arn#region}`, accountId: `{arn#accountId}`, resource: `{resource}`", refs));
                }
                throw new AmazonClientException(Interpolate(@"Test case failed: `{Bucket}` is a valid ARN but parseArn failed to parse it.", refs));
            }
            if (IsSet(refs["Region"]) && (refs["partitionResult"] = Partition(Interpolate(@"{Region}", refs))) != null)
            {
                if (IsSet(refs["Bucket"]))
                {
                    if ((refs["bucketArn"] = ParseArn((string)refs["Bucket"])) != null)
                    {
                        if ((refs["outpostId"] = GetAttr(refs["bucketArn"], "resourceId[1]")) != null)
                        {
                            if (Equals(Interpolate(@"{outpostId}", refs), ""))
                            {
                                throw new AmazonClientException("OutpostId was empty");
                            }
                            return new Endpoint(Interpolate(@"https://{outpostId}-{bucketArn#accountId}.{bucketArn#region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("Invalid ARN: outpostId was not set");
                    }
                    if (IsValidHostLabel(Interpolate(@"{Bucket}", refs), false))
                    {
                        return new Endpoint(Interpolate(@"https://{Bucket}.{Region}.amazonaws.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    return new Endpoint(Interpolate(@"https://{Region}.amazonaws.com/{Bucket}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                return new Endpoint(Interpolate(@"https://{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            throw new AmazonClientException("Region must be set to resolve a valid endpoint");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}