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
using Amazon.PricingPlanManager.Internal;

namespace Amazon.PricingPlanManager.Endpoints
{
    /// <summary>
    /// Contains parameters used for resolving PricingPlanManager endpoints.
    /// <para />
    /// Parameters can be sourced from client config and service operations used by the
    /// internal <see cref="AmazonPricingPlanManagerEndpointProvider"/> and <see cref="AmazonPricingPlanManagerEndpointResolver"/>.
    /// <para />
    /// Can be used by custom Endpoint Providers, <see cref="ClientConfig.EndpointProvider"/>
    /// </summary>
    public class PricingPlanManagerEndpointParameters : EndpointParameters
    {
        /// <summary>
        /// PricingPlanManagerEndpointParameters constructor
        /// </summary>
        public PricingPlanManagerEndpointParameters()
        {
        }

        /// <summary>
        /// Override the endpoint URL
        /// </summary>
        public string Endpoint { get; set; }

        /// <summary>
        /// The AWS region
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
                "Endpoint" => Endpoint,
                "Region" => Region,
                _ => base[name],
            };
            set
            {
                switch (name)
                {
                    case "Endpoint": Endpoint = (string)value; break;
                    case "Region": Region = (string)value; break;
                    default: base[name] = value; break;
                }
            }
        }

        /// <inheritdoc/>
        protected override bool ParameterValuesEqual(EndpointParameters other)
        {
            var o = (PricingPlanManagerEndpointParameters)other;
            return Endpoint == o.Endpoint
                && Region == o.Region
                && base.ParameterValuesEqual(other);
        }
    }
}
