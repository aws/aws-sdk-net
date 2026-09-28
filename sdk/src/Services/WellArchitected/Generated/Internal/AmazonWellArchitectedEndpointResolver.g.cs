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
using System.Linq;
using System.Collections.Generic;
using Amazon.WellArchitected.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.WellArchitected.Endpoints;

#pragma warning disable 1591

namespace Amazon.WellArchitected.Internal
{
    /// <summary>
    /// Amazon WellArchitected endpoint resolver.
    /// <para />
    /// Custom <see cref="PipelineHandler"/> responsible for resolving endpoint and setting authentication parameters for WellArchitected service requests.
    /// <para />
    /// Collects values for <see cref="WellArchitectedEndpointParameters"/> and then tries to resolve endpoint by calling
    /// <c>ResolveEndpoint</c> method on <see cref="GlobalEndpoints.Provider"/> if present, otherwise uses <see cref="AmazonWellArchitectedEndpointProvider"/>.
    /// <para />
    /// Responsible for setting authentication and HTTP headers provided by resolved endpoint.
    /// </summary>
    public class AmazonWellArchitectedEndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {
            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonWellArchitectedConfig)requestContext.ClientConfig;
            var result = new WellArchitectedEndpointParameters();
            result.UseDualStack = config.UseDualstackEndpoint;
            result.UseFIPS = config.UseFIPSEndpoint;
            result.Endpoint = config.ServiceURL;
            result.Region = requestContext.Request.AlternateEndpoint?.SystemName ?? config.RegionEndpoint?.SystemName;

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

            // To support legacy endpoint overriding rules in the endpoints.json
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
            if (requestContext.RequestName == "CreateAgentContextRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "CreateAgentGoalRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "CreateAgentProfileRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "DeleteAgentContextRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "DeleteAgentGoalRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "DeleteAgentProfileRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "GetAgentContextRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "GetAgentGoalRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "GetAgentProfileRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "GetAgentRecommendationRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "GetAgentRecommendationGenerationRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "ListAgentContextsRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "ListAgentGoalsRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "ListAgentProfilesRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "ListAgentRecommendationGenerationsRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "ListAgentRecommendationItemsRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "ListAgentRecommendationsRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "PutAgentRecommendationFeedbackRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "StartAgentRecommendationGenerationRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "UpdateAgentContextRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "UpdateAgentGoalRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "UpdateAgentProfileRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }
            if (requestContext.RequestName == "UpdateAgentRecommendationStatusRequest")
            {
                result.SubServiceType = "AGENT";
                return result;
            }

            return result;
        }
    }
}
