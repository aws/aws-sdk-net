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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.Route53.Internal
{
    /// <summary>
    /// Amazon Route53 endpoint provider.
    /// Resolves endpoint for given set of Route53EndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonRoute53EndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for Route53EndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["Region"] == null)
                throw new AmazonClientException("Region parameter must be set for endpoint resolution");
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
            if ((refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
            {
                if (IsSet(refs["Endpoint"]) && (refs["url"] = ParseURL((string)refs["Endpoint"])) != null)
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
                if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws"))
                {
                    if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")) && Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://route-53-fips.{Region}.api.aws", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                    }
                    if (Equals(refs["UseFIPS"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                        {
                            return new Endpoint("https://route53-fips.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    if (Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://route-53.{Region}.api.aws", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                    }
                    return new Endpoint("https://route53.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                }
                if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-cn"))
                {
                    if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")) && Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://route-53-fips.{Region}.api.amazonwebservices.com.cn", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""cn-northwest-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                    }
                    if (Equals(refs["UseFIPS"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                        {
                            return new Endpoint(Interpolate(@"https://route-53-fips.{Region}.amazonaws.com.cn", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""cn-northwest-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    if (Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://route-53.{Region}.api.amazonwebservices.com.cn", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""cn-northwest-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                    }
                    return new Endpoint("https://route53.amazonaws.com.cn", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""cn-northwest-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                }
                if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-us-gov"))
                {
                    if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")) && Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://route-53-fips.{Region}.api.aws", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-gov-west-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                    }
                    if (Equals(refs["UseFIPS"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                        {
                            return new Endpoint("https://route53.us-gov.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-gov-west-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    if (Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://route-53.{Region}.api.aws", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-gov-west-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                    }
                    return new Endpoint("https://route53.us-gov.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-gov-west-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                }
                if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso"))
                {
                    if (Equals(refs["UseFIPS"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                        {
                            return new Endpoint(Interpolate(@"https://route-53-fips.{Region}.c2s.ic.gov", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-iso-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    return new Endpoint("https://route53.c2s.ic.gov", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-iso-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                }
                if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso-b"))
                {
                    if (Equals(refs["UseFIPS"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                        {
                            return new Endpoint(Interpolate(@"https://route-53-fips.{Region}.sc2s.sgov.gov", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-isob-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    return new Endpoint("https://route53.sc2s.sgov.gov", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-isob-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                {
                    if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")) && Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                    {
                        return new Endpoint(Interpolate(@"https://route53-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                }
                if (Equals(refs["UseFIPS"], true))
                {
                    if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                    {
                        if (Equals(refs["Region"], "aws-global"))
                        {
                            return new Endpoint("https://route53-fips.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        if (Equals(refs["Region"], "aws-us-gov-global"))
                        {
                            return new Endpoint("https://route53.us-gov.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-gov-west-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                        }
                        return new Endpoint(Interpolate(@"https://route53-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                }
                if (Equals(refs["UseDualStack"], true))
                {
                    if (Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                    {
                        return new Endpoint(Interpolate(@"https://route53.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                }
                if (Equals(refs["Region"], "aws-global"))
                {
                    return new Endpoint("https://route53.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["Region"], "aws-cn-global"))
                {
                    return new Endpoint("https://route53.amazonaws.com.cn", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""cn-northwest-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["Region"], "aws-us-gov-global"))
                {
                    return new Endpoint("https://route53.us-gov.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-gov-west-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["Region"], "aws-iso-global"))
                {
                    return new Endpoint("https://route53.c2s.ic.gov", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-iso-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["Region"], "aws-iso-b-global"))
                {
                    return new Endpoint("https://route53.sc2s.sgov.gov", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingRegion"":""us-isob-east-1"",""signingName"":""route53""}]}", refs), InterpolateJson(@"", refs));
                }
                return new Endpoint(Interpolate(@"https://route53.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}