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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.NeptuneGraph.Internal
{
    /// <summary>
    /// Amazon NeptuneGraph endpoint provider.
    /// Resolves endpoint for given set of NeptuneGraphEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonNeptuneGraphEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for NeptuneGraphEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["UseFIPS"] == null)
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            if (parameters["UseDualStack"] == null)
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            if (parameters["ApiType"] == null)
                throw new AmazonClientException("ApiType parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["Region"] = parameters["Region"],
                ["UseFIPS"] = parameters["UseFIPS"],
                ["UseDualStack"] = parameters["UseDualStack"],
                ["Endpoint"] = parameters["Endpoint"],
                ["ApiType"] = parameters["ApiType"],
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
                            if (Equals(refs["ApiType"], "ControlPlane"))
                            {
                                return new Endpoint(Interpolate(@"https://neptune-graph-fips.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["ApiType"], "DataPlane"))
                            {
                                throw new AmazonClientException("Invalid Configuration: fips endpoint is not supported for this API");
                            }
                            throw new AmazonClientException("Invalid Configuration: Unknown ApiType");
                        }
                        throw new AmazonClientException("FIPS and DualStack are enabled, but this partition does not support one or both");
                    }
                    if (Equals(refs["UseFIPS"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsFIPS")))
                        {
                            if (Equals(refs["ApiType"], "ControlPlane"))
                            {
                                return new Endpoint(Interpolate(@"https://neptune-graph-fips.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["ApiType"], "DataPlane"))
                            {
                                throw new AmazonClientException("Invalid Configuration: fips endpoint is not supported for this API");
                            }
                            throw new AmazonClientException("Invalid Configuration: Unknown ApiType");
                        }
                        throw new AmazonClientException("FIPS is enabled but this partition does not support FIPS");
                    }
                    if (Equals(refs["UseDualStack"], true))
                    {
                        if (Equals(true, GetAttr(refs["PartitionResult"], "supportsDualStack")))
                        {
                            if (Equals(refs["ApiType"], "ControlPlane"))
                            {
                                return new Endpoint(Interpolate(@"https://neptune-graph.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                            }
                            if (Equals(refs["ApiType"], "DataPlane"))
                            {
                                return new Endpoint(Interpolate(@"https://neptune-graph.{Region}.on.aws", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                            }
                            throw new AmazonClientException("Invalid Configuration: Unknown ApiType");
                        }
                        throw new AmazonClientException("DualStack is enabled but this partition does not support DualStack");
                    }
                    if (Equals(refs["ApiType"], "ControlPlane"))
                    {
                        return new Endpoint(Interpolate(@"https://neptune-graph.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    if (Equals(refs["ApiType"], "DataPlane"))
                    {
                        return new Endpoint(Interpolate(@"https://{Region}.neptune-graph.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                    }
                    throw new AmazonClientException("Invalid Configuration: Unknown ApiType");
                }
            }
            throw new AmazonClientException("Invalid Configuration: Missing Region");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}