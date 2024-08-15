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
 * Do not modify this file. This file is generated from the ep2-complex-parameters-2022-08-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.Ep2complexparameters.Internal
{
    /// <summary>
    /// Amazon Ep2complexparameters endpoint provider.
    /// Resolves endpoint for given set of Ep2complexparametersEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonEp2complexparametersEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for Ep2complexparametersEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["stringArrayParam"] == null)
                throw new AmazonClientException("stringArrayParam parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["stringArrayParam"] = parameters["stringArrayParam"],
            };
            if ((refs["arrayValue"] = GetAttr(refs["stringArrayParam"], "[0]")) != null)
            {
                return new Endpoint(Interpolate(@"https://example.com/{arrayValue}", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            throw new AmazonClientException("no array values set");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}