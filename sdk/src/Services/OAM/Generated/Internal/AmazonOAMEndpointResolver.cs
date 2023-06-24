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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */

using System;
using Amazon.OAM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.OAM.Endpoints;

#pragma warning disable 1591

namespace Amazon.OAM.Internal
{
    /// <summary>
    /// Amazon OAM endpoint resolver.
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for OAM service requests.
    /// Collects values for OAMEndpointParameters and then tries to resolve endpoint by calling 
    /// ResolveEndpoint method on GlobalEndpoints.Provider if present, otherwise uses OAMEndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class AmazonOAMEndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {

            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonOAMConfig)requestContext.ClientConfig;
            var result = new OAMEndpointParameters();
            result.Region = config.RegionEndpoint?.SystemName;
            result.UseDualStack = config.UseDualstackEndpoint;
            result.UseFIPS = config.UseFIPSEndpoint;
            result.Endpoint = config.ServiceURL;


            // The region needs to be determined from the ServiceURL if not set.
            var regionEndpoint = config.RegionEndpoint;
            if (regionEndpoint == null && !string.IsNullOrEmpty(config.ServiceURL))
            {
                var regionName = AWSSDKUtils.DetermineRegion(config.ServiceURL);
                result.Region = RegionEndpoint.GetBySystemName(regionName).SystemName;
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

            return result;
        }
    }
}