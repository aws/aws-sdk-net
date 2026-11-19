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
using Amazon.OpenSearchMemory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.OpenSearchMemory.Endpoints;

#pragma warning disable 1591

namespace Amazon.OpenSearchMemory.Internal
{
    /// <summary>
    /// Amazon OpenSearch Memory endpoint resolver.
    /// <para />
    /// Custom <see cref="PipelineHandler"/> responsible for resolving endpoint and setting authentication parameters for OpenSearchMemory service requests.
    /// <para />
    /// Collects values for <see cref="OpenSearchMemoryEndpointParameters"/> and then tries to resolve endpoint by calling
    /// <c>ResolveEndpoint</c> method on <see cref="GlobalEndpoints.Provider"/> if present, otherwise uses <see cref="AmazonOpenSearchMemoryEndpointProvider"/>.
    /// <para />
    /// Responsible for setting authentication and HTTP headers provided by resolved endpoint.
    /// </summary>
    public class AmazonOpenSearchMemoryEndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {
            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonOpenSearchMemoryConfig)requestContext.ClientConfig;
            var result = new OpenSearchMemoryEndpointParameters();
            result.Region = requestContext.Request.AlternateEndpoint?.SystemName ?? config.RegionEndpoint?.SystemName;
            result.Endpoint = config.ServiceURL;
            result.UseFIPS = config.UseFIPSEndpoint;

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
            if (requestContext.RequestName == "BatchGetEventRequest")
            {
                var request = (BatchGetEventRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "CreateEventRequest")
            {
                var request = (CreateEventRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "CreateMemoryRequest")
            {
                var request = (CreateMemoryRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "DeleteEventRequest")
            {
                var request = (DeleteEventRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "DeleteMemoryRequest")
            {
                var request = (DeleteMemoryRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "GetEventRequest")
            {
                var request = (GetEventRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "GetMemoryRequest")
            {
                var request = (GetMemoryRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "ListEventsRequest")
            {
                var request = (ListEventsRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "ListMemoriesRequest")
            {
                var request = (ListMemoriesRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "SearchEventsRequest")
            {
                var request = (SearchEventsRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "SearchMemoriesRequest")
            {
                var request = (SearchMemoriesRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }
            if (requestContext.RequestName == "UpdateMemoryRequest")
            {
                var request = (UpdateMemoryRequest)requestContext.OriginalRequest;
                result.SpaceId = request.SpaceId;
                return result;
            }

            return result;
        }
    }
}
