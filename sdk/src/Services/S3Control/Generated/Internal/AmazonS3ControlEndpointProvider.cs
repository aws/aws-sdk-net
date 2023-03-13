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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.S3Control.Internal
{
    /// <summary>
    /// Amazon S3Control endpoint provider.
    /// Resolves endpoint for given set of S3ControlEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonS3ControlEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for S3ControlEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["UseFIPS"] == null)
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            if (parameters["UseDualStack"] == null)
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["Region"] = parameters["Region"],
                ["UseFIPS"] = parameters["UseFIPS"],
                ["UseDualStack"] = parameters["UseDualStack"],
                ["Endpoint"] = parameters["Endpoint"],
                ["AccountId"] = parameters["AccountId"],
                ["RequiresAccountId"] = parameters["RequiresAccountId"],
                ["OutpostId"] = parameters["OutpostId"],
                ["Bucket"] = parameters["Bucket"],
                ["AccessPointName"] = parameters["AccessPointName"],
                ["UseArnRegion"] = parameters["UseArnRegion"],
            };
            if (IsSet(refs["Region"]))
            {
                if (IsSet(refs["OutpostId"]))
                {
                    if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                    {
                        if (Equals(refs["UseFIPS"], true) && Equals(GetAttr(refs["partitionResult"], "name"), "aws-cn"))
                        {
                            throw new AmazonClientException("Partition does not support FIPS");
                        }
                        if (IsSet(refs["RequiresAccountId"]) && Equals(refs["RequiresAccountId"], true) && !IsSet(refs["AccountId"]))
                        {
                            throw new AmazonClientException("AccountId is required but not set");
                        }
                        if (IsSet(refs["AccountId"]) && !IsValidHostLabel((string)refs["AccountId"], false))
                        {
                            throw new AmazonClientException("AccountId must only contain a-z, A-Z, 0-9 and `-`.");
                        }
                        if (!IsValidHostLabel((string)refs["OutpostId"], false))
                        {
                            throw new AmazonClientException("OutpostId must only contain a-z, A-Z, 0-9 and `-`.");
                        }
                        if (IsValidHostLabel((string)refs["Region"], true))
                        {
                            if (Equals(refs["UseDualStack"], true))
                            {
                                throw new AmazonClientException("Invalid configuration: Outposts do not support dual-stack");
                            }
                            if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true))
                            {
                                return new Endpoint(Interpolate(@"https://s3-outposts-fips.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            return new Endpoint(Interpolate(@"https://s3-outposts.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("Invalid region: region was not a valid DNS name.");
                    }
                    throw new AmazonClientException("A valid partition could not be determined");
                }
                if (IsSet(refs["AccessPointName"]) && (refs["accessPointArn"] = ParseArn((string)refs["AccessPointName"])) != null)
                {
                    if ((refs["arnType"] = GetAttr(refs["accessPointArn"], "resourceId[0]")) != null && !Equals(refs["arnType"], ""))
                    {
                        if (Equals(GetAttr(refs["accessPointArn"], "service"), "s3-outposts"))
                        {
                            if (Equals(refs["UseDualStack"], true))
                            {
                                throw new AmazonClientException("Invalid configuration: Outpost Access Points do not support dual-stack");
                            }
                            if ((refs["outpostId"] = GetAttr(refs["accessPointArn"], "resourceId[1]")) != null)
                            {
                                if (IsValidHostLabel((string)refs["outpostId"], false))
                                {
                                    if (IsSet(refs["UseArnRegion"]) && Equals(refs["UseArnRegion"], false) && !Equals(GetAttr(refs["accessPointArn"], "region"), Interpolate(@"{Region}", refs)))
                                    {
                                        throw new AmazonClientException(Interpolate(@"Invalid configuration: region from ARN `{accessPointArn#region}` does not match client region `{Region}` and UseArnRegion is `false`", refs));
                                    }
                                    if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                                    {
                                        if ((refs["arnPartition"] = Partition((string)GetAttr(refs["accessPointArn"], "region"))) != null)
                                        {
                                            if (Equals(GetAttr(refs["arnPartition"], "name"), GetAttr(refs["partitionResult"], "name")))
                                            {
                                                if (IsValidHostLabel((string)GetAttr(refs["accessPointArn"], "region"), true))
                                                {
                                                    if (!Equals(GetAttr(refs["accessPointArn"], "accountId"), ""))
                                                    {
                                                        if (IsValidHostLabel((string)GetAttr(refs["accessPointArn"], "accountId"), false))
                                                        {
                                                            if (IsSet(refs["AccountId"]) && !Equals(refs["AccountId"], Interpolate(@"{accessPointArn#accountId}", refs)))
                                                            {
                                                                throw new AmazonClientException(Interpolate(@"Invalid ARN: the accountId specified in the ARN (`{accessPointArn#accountId}`) does not match the parameter (`{AccountId}`)", refs));
                                                            }
                                                            if ((refs["outpostType"] = GetAttr(refs["accessPointArn"], "resourceId[2]")) != null)
                                                            {
                                                                if ((refs["accessPointName"] = GetAttr(refs["accessPointArn"], "resourceId[3]")) != null)
                                                                {
                                                                    if (Equals(refs["outpostType"], "accesspoint"))
                                                                    {
                                                                        if (Equals(refs["UseFIPS"], true))
                                                                        {
                                                                            return new Endpoint(Interpolate(@"https://s3-outposts-fips.{accessPointArn#region}.{arnPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{accessPointArn#region}""}]}", refs), InterpolateJson(@"{""x-amz-account-id"":[""{accessPointArn#accountId}""],""x-amz-outpost-id"":[""{outpostId}""]}", refs));
                                                                        }
                                                                        if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                                                                        {
                                                                            return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{accessPointArn#region}""}]}", refs), InterpolateJson(@"{""x-amz-account-id"":[""{accessPointArn#accountId}""],""x-amz-outpost-id"":[""{outpostId}""]}", refs));
                                                                        }
                                                                        return new Endpoint(Interpolate(@"https://s3-outposts.{accessPointArn#region}.{arnPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{accessPointArn#region}""}]}", refs), InterpolateJson(@"{""x-amz-account-id"":[""{accessPointArn#accountId}""],""x-amz-outpost-id"":[""{outpostId}""]}", refs));
                                                                    }
                                                                    throw new AmazonClientException(Interpolate(@"Expected an outpost type `accesspoint`, found `{outpostType}`", refs));
                                                                }
                                                                throw new AmazonClientException("Invalid ARN: expected an access point name");
                                                            }
                                                            throw new AmazonClientException("Invalid ARN: Expected a 4-component resource");
                                                        }
                                                        throw new AmazonClientException(Interpolate(@"Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `{accessPointArn#accountId}`", refs));
                                                    }
                                                    throw new AmazonClientException("Invalid ARN: missing account ID");
                                                }
                                                throw new AmazonClientException(Interpolate(@"Invalid region in ARN: `{accessPointArn#region}` (invalid DNS name)", refs));
                                            }
                                            throw new AmazonClientException(Interpolate(@"Client was configured for partition `{partitionResult#name}` but ARN has `{arnPartition#name}`", refs));
                                        }
                                        throw new AmazonClientException(Interpolate(@"Could not load partition for ARN region `{accessPointArn#region}`", refs));
                                    }
                                    throw new AmazonClientException("A valid partition could not be determined");
                                }
                                throw new AmazonClientException(Interpolate(@"Invalid ARN: The outpost Id must only contain a-z, A-Z, 0-9 and `-`., found: `{outpostId}`", refs));
                            }
                            throw new AmazonClientException("Invalid ARN: The Outpost Id was not set");
                        }
                    }
                    throw new AmazonClientException("Invalid ARN: No ARN type specified");
                }
                if (IsSet(refs["Bucket"]) && (refs["bucketArn"] = ParseArn((string)refs["Bucket"])) != null)
                {
                    if ((refs["arnType"] = GetAttr(refs["bucketArn"], "resourceId[0]")) != null && !Equals(refs["arnType"], ""))
                    {
                        if (Equals(GetAttr(refs["bucketArn"], "service"), "s3-outposts"))
                        {
                            if (Equals(refs["UseDualStack"], true))
                            {
                                throw new AmazonClientException("Invalid configuration: Outpost buckets do not support dual-stack");
                            }
                            if ((refs["outpostId"] = GetAttr(refs["bucketArn"], "resourceId[1]")) != null)
                            {
                                if (IsValidHostLabel((string)refs["outpostId"], false))
                                {
                                    if (IsSet(refs["UseArnRegion"]) && Equals(refs["UseArnRegion"], false) && !Equals(GetAttr(refs["bucketArn"], "region"), Interpolate(@"{Region}", refs)))
                                    {
                                        throw new AmazonClientException(Interpolate(@"Invalid configuration: region from ARN `{bucketArn#region}` does not match client region `{Region}` and UseArnRegion is `false`", refs));
                                    }
                                    if ((refs["arnPartition"] = Partition((string)GetAttr(refs["bucketArn"], "region"))) != null)
                                    {
                                        if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                                        {
                                            if (Equals(GetAttr(refs["arnPartition"], "name"), GetAttr(refs["partitionResult"], "name")))
                                            {
                                                if (IsValidHostLabel((string)GetAttr(refs["bucketArn"], "region"), true))
                                                {
                                                    if (!Equals(GetAttr(refs["bucketArn"], "accountId"), ""))
                                                    {
                                                        if (IsValidHostLabel((string)GetAttr(refs["bucketArn"], "accountId"), false))
                                                        {
                                                            if (IsSet(refs["AccountId"]) && !Equals(refs["AccountId"], Interpolate(@"{bucketArn#accountId}", refs)))
                                                            {
                                                                throw new AmazonClientException(Interpolate(@"Invalid ARN: the accountId specified in the ARN (`{bucketArn#accountId}`) does not match the parameter (`{AccountId}`)", refs));
                                                            }
                                                            if ((refs["outpostType"] = GetAttr(refs["bucketArn"], "resourceId[2]")) != null)
                                                            {
                                                                if ((refs["bucketName"] = GetAttr(refs["bucketArn"], "resourceId[3]")) != null)
                                                                {
                                                                    if (Equals(refs["outpostType"], "bucket"))
                                                                    {
                                                                        if (Equals(refs["UseFIPS"], true))
                                                                        {
                                                                            return new Endpoint(Interpolate(@"https://s3-outposts-fips.{bucketArn#region}.{arnPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"{""x-amz-account-id"":[""{bucketArn#accountId}""],""x-amz-outpost-id"":[""{outpostId}""]}", refs));
                                                                        }
                                                                        if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                                                                        {
                                                                            return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"{""x-amz-account-id"":[""{bucketArn#accountId}""],""x-amz-outpost-id"":[""{outpostId}""]}", refs));
                                                                        }
                                                                        return new Endpoint(Interpolate(@"https://s3-outposts.{bucketArn#region}.{arnPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"{""x-amz-account-id"":[""{bucketArn#accountId}""],""x-amz-outpost-id"":[""{outpostId}""]}", refs));
                                                                    }
                                                                    throw new AmazonClientException(Interpolate(@"Invalid ARN: Expected an outpost type `bucket`, found `{outpostType}`", refs));
                                                                }
                                                                throw new AmazonClientException("Invalid ARN: expected a bucket name");
                                                            }
                                                            throw new AmazonClientException("Invalid ARN: Expected a 4-component resource");
                                                        }
                                                        throw new AmazonClientException(Interpolate(@"Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `{bucketArn#accountId}`", refs));
                                                    }
                                                    throw new AmazonClientException("Invalid ARN: missing account ID");
                                                }
                                                throw new AmazonClientException(Interpolate(@"Invalid region in ARN: `{bucketArn#region}` (invalid DNS name)", refs));
                                            }
                                            throw new AmazonClientException(Interpolate(@"Client was configured for partition `{partitionResult#name}` but ARN has `{arnPartition#name}`", refs));
                                        }
                                        throw new AmazonClientException("A valid partition could not be determined");
                                    }
                                    throw new AmazonClientException(Interpolate(@"Could not load partition for ARN region `{bucketArn#region}`", refs));
                                }
                                throw new AmazonClientException(Interpolate(@"Invalid ARN: The outpost Id must only contain a-z, A-Z, 0-9 and `-`., found: `{outpostId}`", refs));
                            }
                            throw new AmazonClientException("Invalid ARN: The Outpost Id was not set");
                        }
                    }
                    throw new AmazonClientException("Invalid ARN: No ARN type specified");
                }
                if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                {
                    if (IsValidHostLabel((string)refs["Region"], true))
                    {
                        if (Equals(refs["UseFIPS"], true) && Equals(GetAttr(refs["partitionResult"], "name"), "aws-cn"))
                        {
                            throw new AmazonClientException("Partition does not support FIPS");
                        }
                        if (IsSet(refs["RequiresAccountId"]) && Equals(refs["RequiresAccountId"], true) && !IsSet(refs["AccountId"]))
                        {
                            throw new AmazonClientException("AccountId is required but not set");
                        }
                        if (IsSet(refs["AccountId"]) && !IsValidHostLabel((string)refs["AccountId"], false))
                        {
                            throw new AmazonClientException("AccountId must only contain a-z, A-Z, 0-9 and `-`.");
                        }
                        if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                        {
                            if (Equals(refs["UseDualStack"], true))
                            {
                                throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                            }
                            if (IsSet(refs["RequiresAccountId"]) && Equals(refs["RequiresAccountId"], true) && IsSet(refs["AccountId"]))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{AccountId}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true) && IsSet(refs["RequiresAccountId"]) && Equals(refs["RequiresAccountId"], true) && IsSet(refs["AccountId"]))
                        {
                            return new Endpoint(Interpolate(@"https://{AccountId}.s3-control-fips.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                        {
                            return new Endpoint(Interpolate(@"https://s3-control-fips.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && IsSet(refs["RequiresAccountId"]) && Equals(refs["RequiresAccountId"], true) && IsSet(refs["AccountId"]))
                        {
                            return new Endpoint(Interpolate(@"https://{AccountId}.s3-control-fips.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false))
                        {
                            return new Endpoint(Interpolate(@"https://s3-control-fips.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true) && IsSet(refs["RequiresAccountId"]) && Equals(refs["RequiresAccountId"], true) && IsSet(refs["AccountId"]))
                        {
                            return new Endpoint(Interpolate(@"https://{AccountId}.s3-control.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true))
                        {
                            return new Endpoint(Interpolate(@"https://s3-control.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && IsSet(refs["RequiresAccountId"]) && Equals(refs["RequiresAccountId"], true) && IsSet(refs["AccountId"]))
                        {
                            return new Endpoint(Interpolate(@"https://{AccountId}.s3-control.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false))
                        {
                            return new Endpoint(Interpolate(@"https://s3-control.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                    }
                    throw new AmazonClientException("Invalid region: region was not a valid DNS name.");
                }
                throw new AmazonClientException("A valid partition could not be determined");
            }
            throw new AmazonClientException("Region must be set");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}