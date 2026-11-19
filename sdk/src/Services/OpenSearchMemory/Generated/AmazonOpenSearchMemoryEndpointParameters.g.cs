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
        public string Region
        {
            get => (string)this["Region"];
            set => this["Region"] = value;
        }

        /// <summary>
        /// An endpoint URL to use instead of the one the rules resolve.
        /// </summary>
        public string Endpoint
        {
            get => (string)this["Endpoint"];
            set => this["Endpoint"] = value;
        }

        /// <summary>
        /// The ID of the space the request targets. When set, the request goes to that space's endpoint.
        /// </summary>
        public string SpaceId
        {
            get => (string)this["SpaceId"];
            set => this["SpaceId"] = value;
        }

        /// <summary>
        /// When true, send the request to a FIPS endpoint. The service has no FIPS endpoint, so the request fails.
        /// </summary>
        public bool? UseFIPS
        {
            get => (bool?)this["UseFIPS"];
            set => this["UseFIPS"] = value;
        }
    }
}
