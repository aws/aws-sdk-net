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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
 */

using System;
using System.Linq;
using System.Collections.Generic;
using Amazon.ARCRegionswitch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.ARCRegionswitch.Endpoints;

#pragma warning disable 1591

namespace Amazon.ARCRegionswitch.Internal
{
    /// <summary>
    /// Amazon ARCRegionswitch endpoint resolver.
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for ARCRegionswitch service requests.
    /// Collects values for ARCRegionswitchEndpointParameters and then tries to resolve endpoint by calling 
    /// ResolveEndpoint method on GlobalEndpoints.Provider if present, otherwise uses ARCRegionswitchEndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class AmazonARCRegionswitchEndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {

            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonARCRegionswitchConfig)requestContext.ClientConfig;
            var result = new ARCRegionswitchEndpointParameters();
            result.UseFIPS = config.UseFIPSEndpoint;
            result.Endpoint = config.ServiceURL;
            result.Region = requestContext.Request.AlternateEndpoint?.SystemName ?? config.RegionEndpoint?.SystemName;;


            // The region needs to be determined from the ServiceURL if not set.
            var regionEndpoint = config.RegionEndpoint;
            if (regionEndpoint == null && !string.IsNullOrEmpty(config.ServiceURL))
            {
                // Use the specified signing region if it was provided alongside a custom ServiceURL
                if (!string.IsNullOrEmpty(config.AuthenticationRegion))
                {
                    result.Region = config.AuthenticationRegion;
                }
                else // try to extract a region from the custom ServiceURL
                {
                    var regionName = AWSSDKUtils.DetermineRegion(config.ServiceURL);
                    result.Region = RegionEndpoint.GetBySystemName(regionName).SystemName;
                }
            }

            // To support legacy endpoint overridding rules in the endpoints.json
            if (result.Region == "us-east-1-regional")
            {
                result.Region = "us-east-1";
            }

            // Use AlternateEndpoint region override if set
            if (requestContext.Request.AlternateEndpoint != null)
            {
                result.Region = requestContext.Request.AlternateEndpoint.SystemName;
            }


            // Assign staticContextParams and contextParam per operation
            if (requestContext.RequestName == "CreatePlanRequest") {
                result.UseControlPlaneEndpoint = true;
                return result;
            }
            if (requestContext.RequestName == "DeletePlanRequest") {
                result.UseControlPlaneEndpoint = true;
                return result;
            }
            if (requestContext.RequestName == "GetPlanRequest") {
                result.UseControlPlaneEndpoint = true;
                return result;
            }
            if (requestContext.RequestName == "ListPlansRequest") {
                result.UseControlPlaneEndpoint = true;
                return result;
            }
            if (requestContext.RequestName == "ListRoute53HealthChecksRequest") {
                result.UseControlPlaneEndpoint = true;
                return result;
            }
            if (requestContext.RequestName == "ListTagsForResourceRequest") {
                result.UseControlPlaneEndpoint = true;
                return result;
            }
            if (requestContext.RequestName == "TagResourceRequest") {
                result.UseControlPlaneEndpoint = true;
                return result;
            }
            if (requestContext.RequestName == "UntagResourceRequest") {
                result.UseControlPlaneEndpoint = true;
                return result;
            }
            if (requestContext.RequestName == "UpdatePlanRequest") {
                result.UseControlPlaneEndpoint = true;
                return result;
            }

            return result;
        }
    }
}