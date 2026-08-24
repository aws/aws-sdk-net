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
 * Do not modify this file. This file is generated from the pricing-plan-manager-2025-08-05.normal.json service model.
 */

using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using static Amazon.Runtime.Internal.Endpoints.StandardLibrary.Fn;

namespace Amazon.PricingPlanManager.Internal
{
    /// <summary>
    /// Amazon PricingPlanManager endpoint provider.
    /// Resolves endpoint for given set of PricingPlanManagerEndpointParameters.
    /// Can throw AmazonClientException if endpoint resolution is unsuccessful.
    /// </summary>
    public class AmazonPricingPlanManagerEndpointProvider : IEndpointProvider
    {
        /// <summary>
        /// Resolve endpoint for PricingPlanManagerEndpointParameters
        /// </summary>
        public Endpoint ResolveEndpoint(EndpointParameters parameters)
        {
            if (parameters == null) 
                throw new ArgumentNullException("parameters");

            if (parameters["Region"] == null)
                throw new AmazonClientException("Region parameter must be set for endpoint resolution");

            var refs = new Dictionary<string, object>()
            {
                ["Endpoint"] = parameters["Endpoint"],
                ["Region"] = parameters["Region"],
            };
            if (IsSet(refs["Endpoint"]))
            {
                return new Endpoint(Interpolate(@"{Endpoint}", refs), InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""pricingplanmanager"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));
            }
            return new Endpoint("https://pricingplanmanager.us-east-1.api.aws", InterpolateJson(@"{""authSchemes"":[{""name"":""sigv4"",""signingName"":""pricingplanmanager"",""signingRegion"":""us-east-1""}]}", refs), InterpolateJson(@"", refs));

            throw new AmazonClientException("Cannot resolve endpoint");
        }
    }
}