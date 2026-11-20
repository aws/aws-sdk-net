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
using Amazon.SecurityAgent.Internal;

namespace Amazon.SecurityAgent.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving SecurityAgent endpoints.
    /// <para />
    /// Parameters can be sourced from client config and service operations used by the
    /// internal <see cref="AmazonSecurityAgentEndpointProvider"/> and <see cref="AmazonSecurityAgentEndpointResolver"/>.
    /// <para />
    /// Can be used by custom Endpoint Providers, <see cref="ClientConfig.EndpointProvider"/>
    /// </summary>
    public class SecurityAgentEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// SecurityAgentEndpointParameters constructor
        /// </summary>
        public SecurityAgentEndpointParameters()
        {
            UseFIPS = false;
        }

        /// <summary>
        /// When true, send this request to the FIPS-compliant regional endpoint. If the configured endpoint does not have a FIPS compliant endpoint, dispatching the request will return an error.
        /// </summary>
        public bool? UseFIPS { get; set; }

        /// <summary>
        /// Override the endpoint used to send this request
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// The AWS region used to dispatch the request.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Gets or sets an endpoint parameter by name. Known parameters read and write the typed
        /// properties; any other name falls through to the underlying property bag.
        /// </summary>
        public override object this[string name]
        {
            get => name switch
            {
                "UseFIPS" => UseFIPS,
                "Endpoint" => Endpoint,
                "Region" => Region,
                _ => base[name],
            };
            set
            {
                switch (name)
                {
                    case "UseFIPS": UseFIPS = (bool?)value; break;
                    case "Endpoint": Endpoint = (string)value; break;
                    case "Region": Region = (string)value; break;
                    default: base[name] = value; break;
                }
            }
        }

        /// <inheritdoc/>
        protected override bool ParameterValuesEqual(EndpointParameters other)
        {
            var o = (SecurityAgentEndpointParameters)other;
            return UseFIPS == o.UseFIPS
                && Endpoint == o.Endpoint
                && Region == o.Region
                && base.ParameterValuesEqual(other);
        }
    }
}
