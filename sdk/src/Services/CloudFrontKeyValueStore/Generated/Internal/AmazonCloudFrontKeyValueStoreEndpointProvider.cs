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
 * Do not modify this file. This file is generated from the cloudfront-keyvaluestore-2022-07-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.CloudFrontKeyValueStore.Internal
{
    /// <summary>
    /// Amazon CloudFrontKeyValueStore endpoint provider.
    /// Resolves endpoint for given set of CloudFrontKeyValueStoreEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonCloudFrontKeyValueStoreEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for CloudFrontKeyValueStoreEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["UseFIPS"] == null)
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["KvsARN"] = parameters["KvsARN"],
                ["Region"] = parameters["Region"],
                ["UseFIPS"] = parameters["UseFIPS"],
                ["Endpoint"] = parameters["Endpoint"],
            };
            if (Equals(refs["UseFIPS"], false))
            {
                if (IsSet(refs["KvsARN"]))
                {
                    if ((refs["parsedArn"] = ParseArn((string)refs["KvsARN"])) != null)
                    {
                        if (Equals(GetAttr(refs["parsedArn"], "service"), "cloudfront"))
                        {
                            if (Equals(GetAttr(refs["parsedArn"], "region"), ""))
                            {
                                if ((refs["arnType"] = GetAttr(refs["parsedArn"], "resourceId[0]")) != null)
                                {
                                    if (!Equals(refs["arnType"], ""))
                                    {
                                        if (Equals(refs["arnType"], "key-value-store"))
                                        {
                                            if (Equals(GetAttr(refs["parsedArn"], "partition"), "aws"))
                                            {
                                                if (IsSet(refs["Region"]))
                                                {
                                                    if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                                                    {
                                                        if (Equals(GetAttr(refs["partitionResult"], "name"), Interpolate(@"{parsedArn#partition}", refs)))
                                                        {
                                                            if (IsSet(refs["Endpoint"]))
                                                            {
                                                                if ((refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                                                                {
                                                                    return new Endpoint(Interpolate(@"{url#scheme}://{parsedArn#accountId}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4a"",""signingName"":""cloudfront-keyvaluestore"",""signingRegionSet"":[""*""]}]}", refs), InterpolateJson(@"", refs));
                                                                }
                                                                throw new AmazonClientException("Provided endpoint is not a valid URL");
                                                            }
                                                            return new Endpoint(Interpolate(@"https://{parsedArn#accountId}.cloudfront-kvs.global.api.aws", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4a"",""signingName"":""cloudfront-keyvaluestore"",""signingRegionSet"":[""*""]}]}", refs), InterpolateJson(@"", refs));
                                                        }
                                                        throw new AmazonClientException(Interpolate(@"Client was configured for partition `{partitionResult#name}` but Kvs ARN has `{parsedArn#partition}`", refs));
                                                    }
                                                }
                                                if (IsSet(refs["Endpoint"]))
                                                {
                                                    if ((refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                                                    {
                                                        return new Endpoint(Interpolate(@"{url#scheme}://{parsedArn#accountId}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4a"",""signingName"":""cloudfront-keyvaluestore"",""signingRegionSet"":[""*""]}]}", refs), InterpolateJson(@"", refs));
                                                    }
                                                    throw new AmazonClientException("Provided endpoint is not a valid URL");
                                                }
                                                return new Endpoint(Interpolate(@"https://{parsedArn#accountId}.cloudfront-kvs.global.api.aws", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4a"",""signingName"":""cloudfront-keyvaluestore"",""signingRegionSet"":[""*""]}]}", refs), InterpolateJson(@"", refs));
                                            }
                                            throw new AmazonClientException(Interpolate(@"CloudFront-KeyValueStore is not supported in partition `{parsedArn#partition}`", refs));
                                        }
                                        throw new AmazonClientException(Interpolate(@"ARN resource type is invalid. Expected `key-value-store`, found: `{arnType}`", refs));
                                    }
                                    throw new AmazonClientException("No resource type found in the KVS ARN. Resource type must be `key-value-store`.");
                                }
                                throw new AmazonClientException("No resource type found in the KVS ARN. Resource type must be `key-value-store`.");
                            }
                            throw new AmazonClientException(Interpolate(@"Provided ARN must be a global resource ARN. Found: `{parsedArn#region}`", refs));
                        }
                        throw new AmazonClientException(Interpolate(@"Provided ARN is not a valid CloudFront Service ARN. Found: `{parsedArn#service}`", refs));
                    }
                    throw new AmazonClientException("KVS ARN must be a valid ARN");
                }
                throw new AmazonClientException("KVS ARN must be provided to use this service");
            }
            throw new AmazonClientException("Invalid Configuration: FIPS is not supported with CloudFront-KeyValueStore.");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}