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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.ARCRegionswitch.Internal
{
    /// <summary>
    /// Amazon ARCRegionswitch endpoint provider.
    /// Resolves endpoint for given set of ARCRegionswitchEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonARCRegionswitchEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for ARCRegionswitchEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["UseFIPS"] == null)
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["UseFIPS"] = parameters["UseFIPS"],
                ["Endpoint"] = parameters["Endpoint"],
                ["Region"] = parameters["Region"],
                ["UseControlPlaneEndpoint"] = parameters["UseControlPlaneEndpoint"],
            };
            if (IsSet(refs["UseControlPlaneEndpoint"]) && Equals(refs["UseControlPlaneEndpoint"], true) && IsSet(refs["Region"]) && !Equals(refs["UseFIPS"], true) && !IsSet(refs["Endpoint"]) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null && Equals(GetAttr(refs["PartitionResult"], "name"), "aws-cn"))
            {
                return new Endpoint(Interpolate(@"https://arc-region-switch-control-plane.cn-north-1.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""arc-region-switch"",""signingRegion"":""cn-north-1""}]}", refs), InterpolateJson(@"", refs));
            }
            if (!IsSet(refs["Endpoint"]) && IsSet(refs["UseControlPlaneEndpoint"]) && Equals(refs["UseControlPlaneEndpoint"], true) && IsSet(refs["Region"]) && Equals(refs["UseFIPS"], true) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
            {
                if (Equals(GetAttr(refs["PartitionResult"], "name"), "aws-cn"))
                {
                    throw new AmazonClientException("Invalid Configuration: FIPS is not supported in this partition");
                }
                return new Endpoint(Interpolate(@"https://arc-region-switch-control-plane-fips.{PartitionResult#implicitGlobalRegion}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""arc-region-switch"",""signingRegion"":""{PartitionResult#implicitGlobalRegion}""}]}", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["UseControlPlaneEndpoint"]) && Equals(refs["UseControlPlaneEndpoint"], true) && IsSet(refs["Region"]) && !Equals(refs["UseFIPS"], true) && !IsSet(refs["Endpoint"]) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
            {
                return new Endpoint(Interpolate(@"https://arc-region-switch-control-plane.{PartitionResult#implicitGlobalRegion}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""arc-region-switch"",""signingRegion"":""{PartitionResult#implicitGlobalRegion}""}]}", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Endpoint"]))
            {
                if (Equals(refs["UseFIPS"], true))
                {
                    throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
                }
                return new Endpoint((string)refs["Endpoint"], InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]))
            {
                if ((refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
                {
                    if (Equals(refs["UseFIPS"], true))
                    {
                        return new Endpoint(Interpolate(@"https://arc-region-switch-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    return new Endpoint(Interpolate(@"https://arc-region-switch.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
            }
            throw new AmazonClientException("Invalid Configuration: Missing Region");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}