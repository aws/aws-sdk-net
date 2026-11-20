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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;
using Amazon.AgentDiscovery.Endpoints;

namespace Amazon.AgentDiscovery.Internal
{
    /// <summary>
    /// Agent Discovery endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="AgentDiscoveryEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonAgentDiscoveryEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for AgentDiscoveryEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters["UseFIPS"] == null)
            {
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            }
            if (parameters["UseDualStack"] == null)
            {
                throw new AmazonClientException("UseDualStack parameter must be set for endpoint resolution");
            }

            var refs = new Dictionary<string, object>()
            {
                ["Region"] = parameters["Region"],
                ["UseFIPS"] = parameters["UseFIPS"],
                ["UseDualStack"] = parameters["UseDualStack"],
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
            if (IsSet(refs["Region"]) && (refs["PartitionResult"] = Partition((string)refs["Region"])) != null)
            {
                if (Equals(refs["UseFIPS"], true))
                {
                    throw new AmazonClientException("FIPS is enabled but Agent Discovery does not have a FIPS endpoint");
                }
                if (Equals(refs["Region"], "us-east-1"))
                {
                    return new Endpoint("https://agent-discovery.us-east-1.api.aws", InterpolateJson(@"{
                                            ""authSchemes"": [
                                                {
                                                    ""name"": ""sigv4"",
                                                    ""signingName"": ""agent-discovery"",
                                                    ""signingRegion"": ""us-east-1""
                                                }
                                            ]
                                        }", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["Region"], "eu-west-1"))
                {
                    return new Endpoint("https://agent-discovery.eu-west-1.api.aws", InterpolateJson(@"{
                                            ""authSchemes"": [
                                                {
                                                    ""name"": ""sigv4"",
                                                    ""signingName"": ""agent-discovery"",
                                                    ""signingRegion"": ""eu-west-1""
                                                }
                                            ]
                                        }", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["Region"], "ap-northeast-1"))
                {
                    return new Endpoint("https://agent-discovery.ap-northeast-1.api.aws", InterpolateJson(@"{
                                            ""authSchemes"": [
                                                {
                                                    ""name"": ""sigv4"",
                                                    ""signingName"": ""agent-discovery"",
                                                    ""signingRegion"": ""ap-northeast-1""
                                                }
                                            ]
                                        }", refs), InterpolateJson(@"", refs));
                }
                if (Equals(refs["UseDualStack"], true))
                {
                    return new Endpoint(Interpolate(@"https://agent-discovery.{Region}.{PartitionResult#dualStackDnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
                }
                return new Endpoint(Interpolate(@"https://agent-discovery.{Region}.{PartitionResult#dnsSuffix}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            throw new AmazonClientException("Invalid Configuration: Missing Region");
        }
    }
}
