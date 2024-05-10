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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.AWSSupport.Internal
{
    /// <summary>
    /// Amazon AWSSupport endpoint provider.
    /// Resolves endpoint for given set of AWSSupportEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonAWSSupportEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for AWSSupportEndpointParameters
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
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws") && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false))
                    {
                        return new Endpoint("https://support.us-east-1.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""support"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-cn") && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false))
                    {
                        return new Endpoint("https://support.cn-north-1.amazonaws.com.cn", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""support"",""signingRegion"":""cn-north-1""}]}", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-us-gov") && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false))
                    {
                        return new Endpoint("https://support.us-gov-west-1.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""support"",""signingRegion"":""us-gov-west-1""}]}", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-us-gov") && Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], false))
                    {
                        return new Endpoint("https://support.us-gov-west-1.amazonaws.com", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""support"",""signingRegion"":""us-gov-west-1""}]}", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso") && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false))
                    {
                        return new Endpoint("https://support.us-iso-east-1.c2s.ic.gov", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""support"",""signingRegion"":""us-iso-east-1""}]}", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-iso-b") && Equals(refs["UseFIPS"], false) && Equals(refs["UseDualStack"], false))
                    {
                        return new Endpoint("https://support.us-isob-east-1.sc2s.sgov.gov", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""support"",""signingRegion"":""us-isob-east-1""}]}", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["UseFIPS"], true) && Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")) && Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://support-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                    }
                    if (Equals(refs["UseFIPS"], true))
                    {
                        if (Equals(GetAttr(refs["PartitionResult"], "supportsFIPS"), true))
                        {
                            return new Endpoint(Interpolate(@"https://support-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    if (Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            return new Endpoint(Interpolate(@"https://support.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                        }
                        throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                    }
                    return new Endpoint(Interpolate(@"https://support.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
            }
            throw new AmazonClientException("Invalid Configuration: Missing Region");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}