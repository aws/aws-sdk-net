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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.WAFV2.Internal
{
    /// <summary>
    /// Amazon WAFV2 endpoint provider.
    /// Resolves endpoint for given set of WAFV2EndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonWAFV2EndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for WAFV2EndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["UseDualStack"] == null)
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            if (parameters["UseFIPS"] == null)
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["Region"] = parameters["Region"],
                ["UseDualStack"] = parameters["UseDualStack"],
                ["UseFIPS"] = parameters["UseFIPS"],
                ["Endpoint"] = parameters["Endpoint"],
            };
            if (IsSet(refs["Endpoint"]))
            {
                if (Equals(refs["UseFIPS"], true))
                {
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                }
                if (Equals(refs["UseDualStack"], true))
                {
                    throw new AmazonClientException("Invalid Configuration: Dualstack and custom endpoint are not supported");
                }
                return new Endpoint((string)refs["Endpoint"], InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]))
            {
                if ((refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
                {
                    if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")) && Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://wafv2-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                    }
                    if (Equals(refs["UseFIPS"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                        {
                            return new Endpoint(Interpolate(@"https://wafv2-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    if (Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://wafv2.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                    }
                    if (Equals(refs["Region"], "af-south-1"))
                    {
                        return new Endpoint("https://wafv2.af-south-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "ap-east-1"))
                    {
                        return new Endpoint("https://wafv2.ap-east-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "ap-northeast-1"))
                    {
                        return new Endpoint("https://wafv2.ap-northeast-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "ap-northeast-2"))
                    {
                        return new Endpoint("https://wafv2.ap-northeast-2.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "ap-northeast-3"))
                    {
                        return new Endpoint("https://wafv2.ap-northeast-3.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "ap-south-1"))
                    {
                        return new Endpoint("https://wafv2.ap-south-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "ap-southeast-1"))
                    {
                        return new Endpoint("https://wafv2.ap-southeast-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "ap-southeast-2"))
                    {
                        return new Endpoint("https://wafv2.ap-southeast-2.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "ap-southeast-3"))
                    {
                        return new Endpoint("https://wafv2.ap-southeast-3.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "ca-central-1"))
                    {
                        return new Endpoint("https://wafv2.ca-central-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "eu-central-1"))
                    {
                        return new Endpoint("https://wafv2.eu-central-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "eu-north-1"))
                    {
                        return new Endpoint("https://wafv2.eu-north-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "eu-south-1"))
                    {
                        return new Endpoint("https://wafv2.eu-south-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "eu-west-1"))
                    {
                        return new Endpoint("https://wafv2.eu-west-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "eu-west-2"))
                    {
                        return new Endpoint("https://wafv2.eu-west-2.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "eu-west-3"))
                    {
                        return new Endpoint("https://wafv2.eu-west-3.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "me-south-1"))
                    {
                        return new Endpoint("https://wafv2.me-south-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "sa-east-1"))
                    {
                        return new Endpoint("https://wafv2.sa-east-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "us-east-1"))
                    {
                        return new Endpoint("https://wafv2.us-east-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "us-east-2"))
                    {
                        return new Endpoint("https://wafv2.us-east-2.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "us-west-1"))
                    {
                        return new Endpoint("https://wafv2.us-west-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "us-west-2"))
                    {
                        return new Endpoint("https://wafv2.us-west-2.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "cn-north-1"))
                    {
                        return new Endpoint("https://wafv2.cn-north-1.amazonaws.com.cn", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "cn-northwest-1"))
                    {
                        return new Endpoint("https://wafv2.cn-northwest-1.amazonaws.com.cn", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "us-gov-east-1"))
                    {
                        return new Endpoint("https://wafv2.us-gov-east-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["Region"], "us-gov-west-1"))
                    {
                        return new Endpoint("https://wafv2.us-gov-west-1.amazonaws.com", InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    return new Endpoint(Interpolate(@"https://wafv2.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
            }
            throw new AmazonClientException("Invalid Configuration: Missing Region");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}