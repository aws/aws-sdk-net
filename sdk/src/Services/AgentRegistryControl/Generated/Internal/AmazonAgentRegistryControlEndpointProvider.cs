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
 * Do not modify this file. This file is generated from the agent-registry-control-2025-12-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.AgentRegistryControl.Internal
{
    /// <summary>
    /// Amazon AgentRegistryControl endpoint provider.
    /// Resolves endpoint for given set of AgentRegistryControlEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonAgentRegistryControlEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for AgentRegistryControlEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");


            var refs = new Dictionary<string, object>()
            {
                ["Region"] = parameters["Region"],
                ["Endpoint"] = parameters["Endpoint"],
            };
            if (IsSet(refs["Endpoint"]))
            {
                return new Endpoint((string)refs["Endpoint"], InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["Region"]))
            {
                return new Endpoint(Interpolate(@"https://agent-registry-control.{Region}.api.aws", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            throw new AmazonClientException("Unable to resolve an Agent Registry Control endpoint: Region was not set and no explicit Endpoint override was provided.");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}