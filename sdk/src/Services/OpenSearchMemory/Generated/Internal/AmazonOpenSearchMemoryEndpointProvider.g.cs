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
using Amazon.OpenSearchMemory.Endpoints;

namespace Amazon.OpenSearchMemory.Internal
{
    /// <summary>
    /// Amazon OpenSearch Memory endpoint provider.
    /// <para />
    /// Resolves endpoint for given set of <see cref="OpenSearchMemoryEndpointParameters"/>.
    /// Can throw <see cref="AmazonClientException"/> if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonOpenSearchMemoryEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for OpenSearchMemoryEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters["Region"] == null)
            {
                throw new AmazonClientException("Region parameter must be set for endpoint resolution");
            }
            if (parameters["UseFIPS"] == null)
            {
                throw new AmazonClientException("UseFIPS parameter must be set for endpoint resolution");
            }

            var refs = new Dictionary<string, object>()
            {
                ["Region"] = parameters["Region"],
                ["Endpoint"] = parameters["Endpoint"],
                ["SpaceId"] = parameters["SpaceId"],
                ["UseFIPS"] = parameters["UseFIPS"],
            };
            if (IsSet(refs["Endpoint"]) && Equals(refs["UseFIPS"], true))
            {
                throw new AmazonClientException("Invalid Configuration: FIPS and custom endpoint are not supported");
            }
            if (IsSet(refs["Endpoint"]))
            {
                return new Endpoint(Interpolate(@"{Endpoint}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (Equals(refs["UseFIPS"], true))
            {
                throw new AmazonClientException("Invalid Configuration: FIPS is not supported with OpenSearch Memory.");
            }
            if (!IsValidHostLabel((string)refs["Region"], true))
            {
                throw new AmazonClientException("Invalid Configuration: Region must be a valid host label");
            }
            if (IsSet(refs["SpaceId"]) && IsValidHostLabel((string)refs["SpaceId"], false))
            {
                return new Endpoint(Interpolate(@"https://{SpaceId}.osm.{Region}.on.aws", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsSet(refs["SpaceId"]))
            {
                throw new AmazonClientException("Invalid SpaceId: must be a valid host label");
            }
            return new Endpoint(Interpolate(@"https://osm.{Region}.api.aws", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
        }
    }
}
