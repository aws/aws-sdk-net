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
using Amazon.OpenSearchMemory.Internal;

namespace Amazon.OpenSearchMemory.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving OpenSearchMemory endpoints.
    /// <para />
    /// Parameters can be sourced from client config and service operations used by the
    /// internal <see cref="AmazonOpenSearchMemoryEndpointProvider"/> and <see cref="AmazonOpenSearchMemoryEndpointResolver"/>.
    /// <para />
    /// Can be used by custom Endpoint Providers, <see cref="ClientConfig.EndpointProvider"/>
    /// </summary>
    public class OpenSearchMemoryEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// OpenSearchMemoryEndpointParameters constructor
        /// </summary>
        public OpenSearchMemoryEndpointParameters()
        {
            UseFIPS = false;
        }

        /// <summary>
        /// The AWS Region to send the request to.
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// An endpoint URL to use instead of the one the rules resolve.
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// The ID of the space the request targets. When set, the request goes to that space's endpoint.
        /// </summary>
        public string SpaceId { get; set; }

        /// <summary>
        /// When true, send the request to a FIPS endpoint. The service has no FIPS endpoint, so the request fails.
        /// </summary>
        public bool? UseFIPS { get; set; }

        /// <summary>
        /// Gets or sets an endpoint parameter by name. Known parameters read and write the typed
        /// properties; any other name falls through to the underlying property bag.
        /// </summary>
        public override object this[string name]
        {
            get => name switch
            {
                "Region" => Region,
                "Endpoint" => Endpoint,
                "SpaceId" => SpaceId,
                "UseFIPS" => UseFIPS,
                _ => base[name],
            };
            set
            {
                switch (name)
                {
                    case "Region": Region = (string)value; break;
                    case "Endpoint": Endpoint = (string)value; break;
                    case "SpaceId": SpaceId = (string)value; break;
                    case "UseFIPS": UseFIPS = (bool?)value; break;
                    default: base[name] = value; break;
                }
            }
        }

        /// <inheritdoc/>
        protected override bool ParameterValuesEqual(EndpointParameters other)
        {
            var o = (OpenSearchMemoryEndpointParameters)other;
            return Region == o.Region
                && Endpoint == o.Endpoint
                && SpaceId == o.SpaceId
                && UseFIPS == o.UseFIPS
                && base.ParameterValuesEqual(other);
        }
    }
}
