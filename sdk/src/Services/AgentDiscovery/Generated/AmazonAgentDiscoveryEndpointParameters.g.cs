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
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using Amazon.AgentDiscovery.Internal;

namespace Amazon.AgentDiscovery.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving AgentDiscovery endpoints.
    /// <para />
    /// Parameters can be sourced from client config and service operations used by the
    /// internal <see cref="AmazonAgentDiscoveryEndpointProvider"/> and <see cref="AmazonAgentDiscoveryEndpointResolver"/>.
    /// <para />
    /// Can be used by custom Endpoint Providers, <see cref="ClientConfig.EndpointProvider"/>
    /// </summary>
    public class AgentDiscoveryEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// AgentDiscoveryEndpointParameters constructor
        /// </summary>
        public AgentDiscoveryEndpointParameters()
        {
            UseFIPS = false;
            UseDualStack = false;
        }

        /// <summary>
        /// The AWS Region the client is configured for. us-east-1, eu-west-1 and ap-northeast-1 resolve to their own Regional endpoint; any other Region resolves to the standard Regional pattern, which Agent Discovery does not serve.
        /// </summary>
        public string Region
        {
            get => (string)this["Region"];
            set => this["Region"] = value;
        }

        /// <summary>
        /// When true, send the request to a FIPS-compliant endpoint. Agent Discovery has none, so this is an error.
        /// </summary>
        public bool? UseFIPS
        {
            get => (bool?)this["UseFIPS"];
            set => this["UseFIPS"] = value;
        }

        /// <summary>
        /// When true, send the request to a dual-stack endpoint. Agent Discovery's Regional endpoints already are, so they resolve unchanged.
        /// </summary>
        public bool? UseDualStack
        {
            get => (bool?)this["UseDualStack"];
            set => this["UseDualStack"] = value;
        }

        /// <summary>
        /// Override the endpoint used to send this request.
        /// </summary>
        public string Endpoint
        {
            get => (string)this["Endpoint"];
            set => this["Endpoint"] = value;
        }
    }
}
