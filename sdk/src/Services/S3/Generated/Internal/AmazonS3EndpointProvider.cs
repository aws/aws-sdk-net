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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.S3.Internal
{
    /// <summary>
    /// Amazon S3 endpoint provider.
    /// Resolves endpoint for given set of S3EndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonS3EndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for S3EndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["UseFIPS"] == null)
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            if (parameters["UseDualStack"] == null)
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            if (parameters["Accelerate"] == null)
                throw new AmazonClientException("Accelerate parameter must be set for endpoint resolution");
            if (parameters["UseGlobalEndpoint"] == null)
                throw new AmazonClientException("UseGlobalEndpoint parameter must be set for endpoint resolution");
            if (parameters["DisableMultiRegionAccessPoints"] == null)
                throw new AmazonClientException("DisableMultiRegionAccessPoints parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["Bucket"] = parameters["Bucket"],
                ["Region"] = parameters["Region"],
                ["UseFIPS"] = parameters["UseFIPS"],
                ["UseDualStack"] = parameters["UseDualStack"],
                ["Endpoint"] = parameters["Endpoint"],
                ["ForcePathStyle"] = parameters["ForcePathStyle"],
                ["Accelerate"] = parameters["Accelerate"],
                ["UseGlobalEndpoint"] = parameters["UseGlobalEndpoint"],
                ["UseObjectLambdaEndpoint"] = parameters["UseObjectLambdaEndpoint"],
                ["DisableAccessPoints"] = parameters["DisableAccessPoints"],
                ["DisableMultiRegionAccessPoints"] = parameters["DisableMultiRegionAccessPoints"],
                ["UseArnRegion"] = parameters["UseArnRegion"],
            };
            if (IsSet(refs["Region"]))
            {
                if (IsSet(refs["Bucket"]) && (refs["hardwareType"] = Substring((string)refs["Bucket"], 49, 50, true)) != null && (refs["regionPrefix"] = Substring((string)refs["Bucket"], 8, 12, true)) != null && (refs["abbaSuffix"] = Substring((string)refs["Bucket"], 0, 7, true)) != null && (refs["outpostId"] = Substring((string)refs["Bucket"], 32, 49, true)) != null && (refs["regionPartition"] = Partition((string)refs["Region"])) != null && Equals(refs["abbaSuffix"], "--op-s3"))
                {
                    if (IsValidHostLabel((string)refs["outpostId"], false))
                    {
                        if (Equals(refs["hardwareType"], "e"))
                        {
                            if (Equals(refs["regionPrefix"], "beta"))
                            {
                                if (!IsSet(refs["Endpoint"]))
                                {
                                    throw new AmazonClientException("Expected a endpoint to be specified but no endpoint was found");
                                }
                                if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.ec2.{url#authority}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                            }
                            return new Endpoint(Interpolate(@"https://{Bucket}.ec2.s3-outposts.{Region}.{regionPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        if (Equals(refs["hardwareType"], "o"))
                        {
                            if (Equals(refs["regionPrefix"], "beta"))
                            {
                                if (!IsSet(refs["Endpoint"]))
                                {
                                    throw new AmazonClientException("Expected a endpoint to be specified but no endpoint was found");
                                }
                                if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.op-{outpostId}.{url#authority}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                            }
                            return new Endpoint(Interpolate(@"https://{Bucket}.op-{outpostId}.s3-outposts.{Region}.{regionPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException(Interpolate(@"Unrecognized hardware type: ""Expected hardware type o or e but got {hardwareType}""", refs));
                    }
                    throw new AmazonClientException("Invalid ARN: The outpost Id must only contain a-z, A-Z, 0-9 and `-`.");
                }
                if (IsSet(refs["Bucket"]))
                {
                    if (IsSet(refs["Endpoint"]) && !IsSet(ParseURL((string)refs["Endpoint"])))
                    {
                        throw new AmazonClientException(Interpolate(@"Custom endpoint `{Endpoint}` was not a valid URI", refs));
                    }
                    if (IsSet(refs["ForcePathStyle"]) && Equals(refs["ForcePathStyle"], true))
                    {
                        if (ParseArn((string)refs["Bucket"]) != null)
                        {
                            throw new AmazonClientException("Path-style addressing cannot be used with ARN buckets");
                        }
                        if ((refs["uri_encoded_bucket"] = UriEncode((string)refs["Bucket"])) != null)
                        {
                            if (Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]))
                            {
                                throw new AmazonClientException("Cannot set dual-stack in combination with a custom endpoint.");
                            }
                            if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                            {
                                if (Equals(refs["Accelerate"], false))
                                {
                                    if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3-fips.dualstack.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3-fips.dualstack.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3-fips.dualstack.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3-fips.dualstack.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                    {
                                        return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                    {
                                        return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3-fips.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3-fips.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3-fips.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3-fips.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3.dualstack.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3.dualstack.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3.dualstack.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3.dualstack.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                    {
                                        if (Equals(refs["Region"], "us-east-1"))
                                        {
                                            return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                        }
                                        return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                    {
                                        return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                    {
                                        if (Equals(refs["Region"], "us-east-1"))
                                        {
                                            return new Endpoint(Interpolate(@"https://s3.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                        }
                                        return new Endpoint(Interpolate(@"https://s3.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                }
                                throw new AmazonClientException("Path-style addressing cannot be used with S3 Accelerate");
                            }
                            throw new AmazonClientException("A valid partition could not be determined");
                        }
                    }
                    if (IsVirtualHostableS3Bucket((string)refs["Bucket"], false))
                    {
                        if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                        {
                            if (IsValidHostLabel((string)refs["Region"], false))
                            {
                                if (Equals(refs["UseFIPS"], true) && Equals(GetAttr(refs["partitionResult"], "name"), "aws-cn"))
                                {
                                    throw new AmazonClientException("Partition does not support FIPS");
                                }
                                if (Equals(refs["Accelerate"], true) && Equals(refs["UseFIPS"], true))
                                {
                                    throw new AmazonClientException("Accelerate cannot be used with FIPS");
                                }
                                if (Equals(refs["Accelerate"], true) && Equals(GetAttr(refs["partitionResult"], "name"), "aws-cn"))
                                {
                                    throw new AmazonClientException("S3 Accelerate cannot be used in this region");
                                }
                                if (IsSet(refs["Endpoint"]) && Equals(refs["UseDualStack"], true))
                                {
                                    throw new AmazonClientException("Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate");
                                }
                                if (IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true))
                                {
                                    throw new AmazonClientException("Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate");
                                }
                                if (IsSet(refs["Endpoint"]) && Equals(refs["Accelerate"], true))
                                {
                                    throw new AmazonClientException("Host override cannot be combined with Dualstack, FIPS, or S3 Accelerate");
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], true) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-fips.dualstack.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], true) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-fips.dualstack.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], true) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-fips.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], true) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-fips.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], true) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-fips.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], true) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-fips.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], true) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-fips.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], true) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-fips.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-accelerate.dualstack.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-accelerate.dualstack.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], true) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-accelerate.dualstack.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], true) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-accelerate.dualstack.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3.dualstack.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3.dualstack.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(GetAttr(refs["url"], "isIp"), true) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{Bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(GetAttr(refs["url"], "isIp"), false) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{Bucket}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(GetAttr(refs["url"], "isIp"), true) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{Bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(GetAttr(refs["url"], "isIp"), false) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{Bucket}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(GetAttr(refs["url"], "isIp"), true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    if (Equals(refs["Region"], "us-east-1"))
                                    {
                                        return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{Bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{Bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(GetAttr(refs["url"], "isIp"), false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    if (Equals(refs["Region"], "us-east-1"))
                                    {
                                        return new Endpoint(Interpolate(@"{url#scheme}://{Bucket}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    return new Endpoint(Interpolate(@"{url#scheme}://{Bucket}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(GetAttr(refs["url"], "isIp"), true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{Bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(GetAttr(refs["url"], "isIp"), false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{Bucket}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-accelerate.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-accelerate.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], true) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    if (Equals(refs["Region"], "us-east-1"))
                                    {
                                        return new Endpoint(Interpolate(@"https://{Bucket}.s3-accelerate.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-accelerate.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], true) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3-accelerate.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    if (Equals(refs["Region"], "us-east-1"))
                                    {
                                        return new Endpoint(Interpolate(@"https://{Bucket}.s3.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && Equals(refs["UseFIPS"], false) && Equals(refs["Accelerate"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"https://{Bucket}.s3.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                            }
                            throw new AmazonClientException("Invalid region: region was not a valid DNS name.");
                        }
                        throw new AmazonClientException("A valid partition could not be determined");
                    }
                    if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(GetAttr(refs["url"], "scheme"), "http") && IsVirtualHostableS3Bucket((string)refs["Bucket"], true) && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && Equals(refs["Accelerate"], false))
                    {
                        if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                        {
                            if (IsValidHostLabel((string)refs["Region"], false))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{Bucket}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            throw new AmazonClientException("Invalid region: region was not a valid DNS name.");
                        }
                        throw new AmazonClientException("A valid partition could not be determined");
                    }
                    if ((refs["bucketArn"] = ParseArn((string)refs["Bucket"])) != null)
                    {
                        if ((refs["arnType"] = GetAttr(refs["bucketArn"], "resourceId[0]")) != null && !Equals(refs["arnType"], ""))
                        {
                            if (Equals(GetAttr(refs["bucketArn"], "service"), "s3-object-lambda"))
                            {
                                if (Equals(refs["arnType"], "accesspoint"))
                                {
                                    if ((refs["accessPointName"] = GetAttr(refs["bucketArn"], "resourceId[1]")) != null && !Equals(refs["accessPointName"], ""))
                                    {
                                        if (Equals(refs["UseDualStack"], true))
                                        {
                                            throw new AmazonClientException("S3 Object Lambda does not support Dual-stack");
                                        }
                                        if (Equals(refs["Accelerate"], true))
                                        {
                                            throw new AmazonClientException("S3 Object Lambda does not support S3 Accelerate");
                                        }
                                        if (!Equals(GetAttr(refs["bucketArn"], "region"), ""))
                                        {
                                            if (IsSet(refs["DisableAccessPoints"]) && Equals(refs["DisableAccessPoints"], true))
                                            {
                                                throw new AmazonClientException("Access points are not supported for this operation");
                                            }
                                            if (!IsSet(GetAttr(refs["bucketArn"], "resourceId[2]")))
                                            {
                                                if (IsSet(refs["UseArnRegion"]) && Equals(refs["UseArnRegion"], false) && !Equals(GetAttr(refs["bucketArn"], "region"), Interpolate(@"{Region}", refs)))
                                                {
                                                    throw new AmazonClientException(Interpolate(@"Invalid configuration: region from ARN `{bucketArn#region}` does not match client region `{Region}` and UseArnRegion is `false`", refs));
                                                }
                                                if ((refs["bucketPartition"] = Partition((string)GetAttr(refs["bucketArn"], "region"))) != null)
                                                {
                                                    if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                                                    {
                                                        if (Equals(GetAttr(refs["bucketPartition"], "name"), GetAttr(refs["partitionResult"], "name")))
                                                        {
                                                            if (IsValidHostLabel((string)GetAttr(refs["bucketArn"], "region"), true))
                                                            {
                                                                if (Equals(GetAttr(refs["bucketArn"], "accountId"), ""))
                                                                {
                                                                    throw new AmazonClientException("Invalid ARN: Missing account id");
                                                                }
                                                                if (IsValidHostLabel((string)GetAttr(refs["bucketArn"], "accountId"), false))
                                                                {
                                                                    if (IsValidHostLabel((string)refs["accessPointName"], false))
                                                                    {
                                                                        if (Equals(refs["UseFIPS"], true) && Equals(GetAttr(refs["bucketPartition"], "name"), "aws-cn"))
                                                                        {
                                                                            throw new AmazonClientException("Partition does not support FIPS");
                                                                        }
                                                                        if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                                                                        {
                                                                            return new Endpoint(Interpolate(@"{url#scheme}://{accessPointName}-{bucketArn#accountId}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-object-lambda"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"", refs));
                                                                        }
                                                                        if (Equals(refs["UseFIPS"], true))
                                                                        {
                                                                            return new Endpoint(Interpolate(@"https://{accessPointName}-{bucketArn#accountId}.s3-object-lambda-fips.{bucketArn#region}.{bucketPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-object-lambda"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"", refs));
                                                                        }
                                                                        return new Endpoint(Interpolate(@"https://{accessPointName}-{bucketArn#accountId}.s3-object-lambda.{bucketArn#region}.{bucketPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-object-lambda"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"", refs));
                                                                    }
                                                                    throw new AmazonClientException(Interpolate(@"Invalid ARN: The access point name may only contain a-z, A-Z, 0-9 and `-`. Found: `{accessPointName}`", refs));
                                                                }
                                                                throw new AmazonClientException(Interpolate(@"Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `{bucketArn#accountId}`", refs));
                                                            }
                                                            throw new AmazonClientException(Interpolate(@"Invalid region in ARN: `{bucketArn#region}` (invalid DNS name)", refs));
                                                        }
                                                        throw new AmazonClientException(Interpolate(@"Client was configured for partition `{partitionResult#name}` but ARN (`{Bucket}`) has `{bucketPartition#name}`", refs));
                                                    }
                                                    throw new AmazonClientException("A valid partition could not be determined");
                                                }
                                                throw new AmazonClientException(Interpolate(@"Could not load partition for ARN region `{bucketArn#region}`", refs));
                                            }
                                            throw new AmazonClientException("Invalid ARN: The ARN may only contain a single resource component after `accesspoint`.");
                                        }
                                        throw new AmazonClientException("Invalid ARN: bucket ARN is missing a region");
                                    }
                                    throw new AmazonClientException("Invalid ARN: Expected a resource of the format `accesspoint:<accesspoint name>` but no name was provided");
                                }
                                throw new AmazonClientException(Interpolate(@"Invalid ARN: Object Lambda ARNs only support `accesspoint` arn types, but found: `{arnType}`", refs));
                            }
                            if (Equals(refs["arnType"], "accesspoint"))
                            {
                                if ((refs["accessPointName"] = GetAttr(refs["bucketArn"], "resourceId[1]")) != null && !Equals(refs["accessPointName"], ""))
                                {
                                    if (!Equals(GetAttr(refs["bucketArn"], "region"), ""))
                                    {
                                        if (Equals(refs["arnType"], "accesspoint"))
                                        {
                                            if (!Equals(GetAttr(refs["bucketArn"], "region"), ""))
                                            {
                                                if (IsSet(refs["DisableAccessPoints"]) && Equals(refs["DisableAccessPoints"], true))
                                                {
                                                    throw new AmazonClientException("Access points are not supported for this operation");
                                                }
                                                if (!IsSet(GetAttr(refs["bucketArn"], "resourceId[2]")))
                                                {
                                                    if (IsSet(refs["UseArnRegion"]) && Equals(refs["UseArnRegion"], false) && !Equals(GetAttr(refs["bucketArn"], "region"), Interpolate(@"{Region}", refs)))
                                                    {
                                                        throw new AmazonClientException(Interpolate(@"Invalid configuration: region from ARN `{bucketArn#region}` does not match client region `{Region}` and UseArnRegion is `false`", refs));
                                                    }
                                                    if ((refs["bucketPartition"] = Partition((string)GetAttr(refs["bucketArn"], "region"))) != null)
                                                    {
                                                        if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                                                        {
                                                            if (Equals(GetAttr(refs["bucketPartition"], "name"), Interpolate(@"{partitionResult#name}", refs)))
                                                            {
                                                                if (IsValidHostLabel((string)GetAttr(refs["bucketArn"], "region"), true))
                                                                {
                                                                    if (Equals(GetAttr(refs["bucketArn"], "service"), "s3"))
                                                                    {
                                                                        if (IsValidHostLabel((string)GetAttr(refs["bucketArn"], "accountId"), false))
                                                                        {
                                                                            if (IsValidHostLabel((string)refs["accessPointName"], false))
                                                                            {
                                                                                if (Equals(refs["Accelerate"], true))
                                                                                {
                                                                                    throw new AmazonClientException("Access Points do not support S3 Accelerate");
                                                                                }
                                                                                if (Equals(refs["UseFIPS"], true) && Equals(GetAttr(refs["bucketPartition"], "name"), "aws-cn"))
                                                                                {
                                                                                    throw new AmazonClientException("Partition does not support FIPS");
                                                                                }
                                                                                if (Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]))
                                                                                {
                                                                                    throw new AmazonClientException("DualStack cannot be combined with a Host override (PrivateLink)");
                                                                                }
                                                                                if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                                                                                {
                                                                                    return new Endpoint(Interpolate(@"https://{accessPointName}-{bucketArn#accountId}.s3-accesspoint-fips.dualstack.{bucketArn#region}.{bucketPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"", refs));
                                                                                }
                                                                                if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false))
                                                                                {
                                                                                    return new Endpoint(Interpolate(@"https://{accessPointName}-{bucketArn#accountId}.s3-accesspoint-fips.{bucketArn#region}.{bucketPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"", refs));
                                                                                }
                                                                                if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true))
                                                                                {
                                                                                    return new Endpoint(Interpolate(@"https://{accessPointName}-{bucketArn#accountId}.s3-accesspoint.dualstack.{bucketArn#region}.{bucketPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"", refs));
                                                                                }
                                                                                if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                                                                                {
                                                                                    return new Endpoint(Interpolate(@"{url#scheme}://{accessPointName}-{bucketArn#accountId}.{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"", refs));
                                                                                }
                                                                                if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false))
                                                                                {
                                                                                    return new Endpoint(Interpolate(@"https://{accessPointName}-{bucketArn#accountId}.s3-accesspoint.{bucketArn#region}.{bucketPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"", refs));
                                                                                }
                                                                            }
                                                                            throw new AmazonClientException(Interpolate(@"Invalid ARN: The access point name may only contain a-z, A-Z, 0-9 and `-`. Found: `{accessPointName}`", refs));
                                                                        }
                                                                        throw new AmazonClientException(Interpolate(@"Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `{bucketArn#accountId}`", refs));
                                                                    }
                                                                    throw new AmazonClientException(Interpolate(@"Invalid ARN: The ARN was not for the S3 service, found: {bucketArn#service}", refs));
                                                                }
                                                                throw new AmazonClientException(Interpolate(@"Invalid region in ARN: `{bucketArn#region}` (invalid DNS name)", refs));
                                                            }
                                                            throw new AmazonClientException(Interpolate(@"Client was configured for partition `{partitionResult#name}` but ARN (`{Bucket}`) has `{bucketPartition#name}`", refs));
                                                        }
                                                        throw new AmazonClientException("A valid partition could not be determined");
                                                    }
                                                    throw new AmazonClientException(Interpolate(@"Could not load partition for ARN region `{bucketArn#region}`", refs));
                                                }
                                                throw new AmazonClientException("Invalid ARN: The ARN may only contain a single resource component after `accesspoint`.");
                                            }
                                            throw new AmazonClientException("Invalid ARN: bucket ARN is missing a region");
                                        }
                                    }
                                    if (IsValidHostLabel((string)refs["accessPointName"], true))
                                    {
                                        if (Equals(refs["UseDualStack"], true))
                                        {
                                            throw new AmazonClientException("S3 MRAP does not support dual-stack");
                                        }
                                        if (Equals(refs["UseFIPS"], true))
                                        {
                                            throw new AmazonClientException("S3 MRAP does not support FIPS");
                                        }
                                        if (Equals(refs["Accelerate"], true))
                                        {
                                            throw new AmazonClientException("S3 MRAP does not support S3 Accelerate");
                                        }
                                        if (Equals(refs["DisableMultiRegionAccessPoints"], true))
                                        {
                                            throw new AmazonClientException("Invalid configuration: Multi-Region Access Point ARNs are disabled.");
                                        }
                                        if ((refs["mrapPartition"] = Partition((string)refs["Region"])) != null)
                                        {
                                            if (Equals(GetAttr(refs["mrapPartition"], "name"), GetAttr(refs["bucketArn"], "partition")))
                                            {
                                                return new Endpoint(Interpolate(@"https://{accessPointName}.accesspoint.s3-global.{mrapPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4a"",""signingName"":""s3"",""signingRegionSet"":[""*""]}]}", refs), InterpolateJson(@"", refs));
                                            }
                                            throw new AmazonClientException(Interpolate(@"Client was configured for partition `{mrapPartition#name}` but bucket referred to partition `{bucketArn#partition}`", refs));
                                        }
                                        throw new AmazonClientException(Interpolate(@"{Region} was not a valid region", refs));
                                    }
                                    throw new AmazonClientException("Invalid Access Point Name");
                                }
                                throw new AmazonClientException("Invalid ARN: Expected a resource of the format `accesspoint:<accesspoint name>` but no name was provided");
                            }
                            if (Equals(GetAttr(refs["bucketArn"], "service"), "s3-outposts"))
                            {
                                if (Equals(refs["UseDualStack"], true))
                                {
                                    throw new AmazonClientException("S3 Outposts does not support Dual-stack");
                                }
                                if (Equals(refs["UseFIPS"], true))
                                {
                                    throw new AmazonClientException("S3 Outposts does not support FIPS");
                                }
                                if (Equals(refs["Accelerate"], true))
                                {
                                    throw new AmazonClientException("S3 Outposts does not support S3 Accelerate");
                                }
                                if (IsSet(GetAttr(refs["bucketArn"], "resourceId[4]")))
                                {
                                    throw new AmazonClientException("Invalid Arn: Outpost Access Point ARN contains sub resources");
                                }
                                if ((refs["outpostId"] = GetAttr(refs["bucketArn"], "resourceId[1]")) != null)
                                {
                                    if (IsValidHostLabel((string)refs["outpostId"], false))
                                    {
                                        if (IsSet(refs["UseArnRegion"]) && Equals(refs["UseArnRegion"], false) && !Equals(GetAttr(refs["bucketArn"], "region"), Interpolate(@"{Region}", refs)))
                                        {
                                            throw new AmazonClientException(Interpolate(@"Invalid configuration: region from ARN `{bucketArn#region}` does not match client region `{Region}` and UseArnRegion is `false`", refs));
                                        }
                                        if ((refs["bucketPartition"] = Partition((string)GetAttr(refs["bucketArn"], "region"))) != null)
                                        {
                                            if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                                            {
                                                if (Equals(GetAttr(refs["bucketPartition"], "name"), GetAttr(refs["partitionResult"], "name")))
                                                {
                                                    if (IsValidHostLabel((string)GetAttr(refs["bucketArn"], "region"), true))
                                                    {
                                                        if (IsValidHostLabel((string)GetAttr(refs["bucketArn"], "accountId"), false))
                                                        {
                                                            if ((refs["outpostType"] = GetAttr(refs["bucketArn"], "resourceId[2]")) != null)
                                                            {
                                                                if ((refs["accessPointName"] = GetAttr(refs["bucketArn"], "resourceId[3]")) != null)
                                                                {
                                                                    if (Equals(refs["outpostType"], "accesspoint"))
                                                                    {
                                                                        if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                                                                        {
                                                                            return new Endpoint(Interpolate(@"https://{accessPointName}-{bucketArn#accountId}.{outpostId}.{url#authority}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"", refs));
                                                                        }
                                                                        return new Endpoint(Interpolate(@"https://{accessPointName}-{bucketArn#accountId}.{outpostId}.s3-outposts.{bucketArn#region}.{bucketPartition#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-outposts"",""signingRegion"":""{bucketArn#region}""}]}", refs), InterpolateJson(@"", refs));
                                                                    }
                                                                    throw new AmazonClientException(Interpolate(@"Expected an outpost type `accesspoint`, found {outpostType}", refs));
                                                                }
                                                                throw new AmazonClientException("Invalid ARN: expected an access point name");
                                                            }
                                                            throw new AmazonClientException("Invalid ARN: Expected a 4-component resource");
                                                        }
                                                        throw new AmazonClientException(Interpolate(@"Invalid ARN: The account id may only contain a-z, A-Z, 0-9 and `-`. Found: `{bucketArn#accountId}`", refs));
                                                    }
                                                    throw new AmazonClientException(Interpolate(@"Invalid region in ARN: `{bucketArn#region}` (invalid DNS name)", refs));
                                                }
                                                throw new AmazonClientException(Interpolate(@"Client was configured for partition `{partitionResult#name}` but ARN (`{Bucket}`) has `{bucketPartition#name}`", refs));
                                            }
                                            throw new AmazonClientException("A valid partition could not be determined");
                                        }
                                        throw new AmazonClientException(Interpolate(@"Could not load partition for ARN region {bucketArn#region}", refs));
                                    }
                                    throw new AmazonClientException(Interpolate(@"Invalid ARN: The outpost Id may only contain a-z, A-Z, 0-9 and `-`. Found: `{outpostId}`", refs));
                                }
                                throw new AmazonClientException("Invalid ARN: The Outpost Id was not set");
                            }
                            throw new AmazonClientException(Interpolate(@"Invalid ARN: Unrecognized format: {Bucket} (type: {arnType})", refs));
                        }
                        throw new AmazonClientException("Invalid ARN: No ARN type specified");
                    }
                    if ((refs["arnPrefix"] = Substring((string)refs["Bucket"], 0, 4, false)) != null && Equals(refs["arnPrefix"], "arn:") && !IsSet(ParseArn((string)refs["Bucket"])))
                    {
                        throw new AmazonClientException(Interpolate(@"Invalid ARN: `{Bucket}` was not a valid ARN", refs));
                    }
                    if ((refs["uri_encoded_bucket"] = UriEncode((string)refs["Bucket"])) != null)
                    {
                        if (Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]))
                        {
                            throw new AmazonClientException("Cannot set dual-stack in combination with a custom endpoint.");
                        }
                        if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                        {
                            if (Equals(refs["Accelerate"], false))
                            {
                                if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://s3-fips.dualstack.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://s3-fips.dualstack.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    return new Endpoint(Interpolate(@"https://s3-fips.dualstack.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"https://s3-fips.dualstack.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://s3-fips.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://s3-fips.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    return new Endpoint(Interpolate(@"https://s3-fips.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"https://s3-fips.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://s3.dualstack.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://s3.dualstack.us-east-1.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    return new Endpoint(Interpolate(@"https://s3.dualstack.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"https://s3.dualstack.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    if (Equals(refs["Region"], "us-east-1"))
                                    {
                                        return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#normalizedPath}{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://s3.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && Equals(refs["Region"], "aws-global"))
                                {
                                    return new Endpoint(Interpolate(@"https://s3.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                                {
                                    if (Equals(refs["Region"], "us-east-1"))
                                    {
                                        return new Endpoint(Interpolate(@"https://s3.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                    }
                                    return new Endpoint(Interpolate(@"https://s3.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                if (Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], false) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                                {
                                    return new Endpoint(Interpolate(@"https://s3.{Region}.{partitionResult#dnsSuffix}/{uri_encoded_bucket}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                            }
                            throw new AmazonClientException("Path-style addressing cannot be used with S3 Accelerate");
                        }
                        throw new AmazonClientException("A valid partition could not be determined");
                    }
                }
                if (IsSet(refs["UseObjectLambdaEndpoint"]) && Equals(refs["UseObjectLambdaEndpoint"], true))
                {
                    if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                    {
                        if (IsValidHostLabel((string)refs["Region"], true))
                        {
                            if (Equals(refs["UseDualStack"], true))
                            {
                                throw new AmazonClientException("S3 Object Lambda does not support Dual-stack");
                            }
                            if (Equals(refs["Accelerate"], true))
                            {
                                throw new AmazonClientException("S3 Object Lambda does not support S3 Accelerate");
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(GetAttr(refs["partitionResult"], "name"), "aws-cn"))
                            {
                                throw new AmazonClientException("Partition does not support FIPS");
                            }
                            if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-object-lambda"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true))
                            {
                                return new Endpoint(Interpolate(@"https://s3-object-lambda-fips.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-object-lambda"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            return new Endpoint(Interpolate(@"https://s3-object-lambda.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3-object-lambda"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("Invalid region: region was not a valid DNS name.");
                    }
                    throw new AmazonClientException("A valid partition could not be determined");
                }
                if (!IsSet(refs["Bucket"]))
                {
                    if ((refs["partitionResult"] = Partition((string)refs["Region"])) != null)
                    {
                        if (IsValidHostLabel((string)refs["Region"], true))
                        {
                            if (Equals(refs["UseFIPS"], true) && Equals(GetAttr(refs["partitionResult"], "name"), "aws-cn"))
                            {
                                throw new AmazonClientException("Partition does not support FIPS");
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"https://s3-fips.dualstack.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"https://s3-fips.dualstack.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                            {
                                return new Endpoint(Interpolate(@"https://s3-fips.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                            {
                                return new Endpoint(Interpolate(@"https://s3-fips.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"https://s3-fips.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"https://s3-fips.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                            {
                                return new Endpoint(Interpolate(@"https://s3-fips.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                            {
                                return new Endpoint(Interpolate(@"https://s3-fips.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"https://s3.dualstack.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"https://s3.dualstack.us-east-1.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                            {
                                return new Endpoint(Interpolate(@"https://s3.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], true) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                            {
                                return new Endpoint(Interpolate(@"https://s3.dualstack.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                            {
                                if (Equals(refs["Region"], "us-east-1"))
                                {
                                    return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                            {
                                return new Endpoint(Interpolate(@"{url#scheme}://{url#authority}{url#path}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"https://s3.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && Equals(refs["Region"], "aws-global"))
                            {
                                return new Endpoint(Interpolate(@"https://s3.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], true))
                            {
                                if (Equals(refs["Region"], "us-east-1"))
                                {
                                    return new Endpoint(Interpolate(@"https://s3.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                                }
                                return new Endpoint(Interpolate(@"https://s3.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false) && !IsSet(refs["Endpoint"]) && !Equals(refs["Region"], "aws-global") && Equals(refs["UseGlobalEndpoint"], false))
                            {
                                return new Endpoint(Interpolate(@"https://s3.{Region}.{partitionResult#dnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""disableDoubleEncoding"":true,""name"":""sigv4"",""signingName"":""s3"",""signingRegion"":""{Region}""}]}", refs), InterpolateJson(@"", refs));
                            }
                        }
                        throw new AmazonClientException("Invalid region: region was not a valid DNS name.");
                    }
                    throw new AmazonClientException("A valid partition could not be determined");
                }
            }
            throw new AmazonClientException("A region must be set when sending requests to S3.");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}