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
 * Do not modify this file. This file is generated from the ep2-host-label-2022-08-24.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.Ep2hostlabel.Internal
{
    /// <summary>
    /// Amazon Ep2hostlabel endpoint provider.
    /// Resolves endpoint for given set of Ep2hostlabelEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonEp2hostlabelEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for Ep2hostlabelEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["Region"] == null)
                throw new AmazonClientException("Region parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["Region"] = parameters["Region"],
            };
            if (IsValidHostLabel((string)refs["Region"], false))
            {
                return new Endpoint(Interpolate(@"https://{Region}.amazonaws.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            if (IsValidHostLabel((string)refs["Region"], true))
            {
                return new Endpoint(Interpolate(@"https://{Region}-subdomains.amazonaws.com", refs), InterpolateJson(@"", refs), InterpolateJson(@"", refs));
            }
            throw new AmazonClientException("Invalid hostlabel");

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}