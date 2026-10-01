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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */

using System;
using System.Linq;
using System.Collections.Generic;
using Amazon.EventBridgeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.EventBridgeV2.Endpoints;

#pragma warning disable 1591

namespace Amazon.EventBridgeV2.Internal
{
    /// <summary>
    /// Amazon EventBridgeV2 endpoint resolver.
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for EventBridgeV2 service requests.
    /// Collects values for EventBridgeV2EndpointParameters and then tries to resolve endpoint by calling 
    /// ResolveEndpoint method on GlobalEndpoints.Provider if present, otherwise uses EventBridgeV2EndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class AmazonEventBridgeV2EndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {

            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonEventBridgeV2Config)requestContext.ClientConfig;
            var result = new EventBridgeV2EndpointParameters();
            result.Region = requestContext.Request.AlternateEndpoint?.SystemName ?? config.RegionEndpoint?.SystemName;;
            result.Endpoint = config.ServiceURL;
            result.UseFIPS = config.UseFIPSEndpoint;
            result.UseDualStack = config.UseDualstackEndpoint;
            result.AccountId = requestContext.Identity is AWSCredentials credentials ? credentials.GetCredentials()?.AccountId : null;
            result.AccountIdEndpointMode = config.AccountIdEndpointMode.ToString().ToLower();


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
            if (requestContext.RequestName == "CreateEventSourceRequest") {
                var request = (CreateEventSourceRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.EventBusArn;
                return result;
            }
            if (requestContext.RequestName == "CreateSubscriberRequest") {
                var request = (CreateSubscriberRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.EventBusArn;
                return result;
            }
            if (requestContext.RequestName == "DeleteEventBusRequest") {
                var request = (DeleteEventBusRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.EventBusArn;
                return result;
            }
            if (requestContext.RequestName == "DeleteResourcePolicyRequest") {
                var request = (DeleteResourcePolicyRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.ResourceArn;
                return result;
            }
            if (requestContext.RequestName == "DescribeEventBusRequest") {
                var request = (DescribeEventBusRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.EventBusArn;
                return result;
            }
            if (requestContext.RequestName == "GetResourcePolicyRequest") {
                var request = (GetResourcePolicyRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.ResourceArn;
                return result;
            }
            if (requestContext.RequestName == "ListEventSourcesRequest") {
                var request = (ListEventSourcesRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.EventBusArn;
                return result;
            }
            if (requestContext.RequestName == "ListResourcePoliciesRequest") {
                var request = (ListResourcePoliciesRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.ResourceArn;
                return result;
            }
            if (requestContext.RequestName == "ListSubscribersRequest") {
                var request = (ListSubscribersRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.EventBusArn;
                return result;
            }
            if (requestContext.RequestName == "PutEventsRequest") {
                var request = (PutEventsRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.EventBusArn;
                return result;
            }
            if (requestContext.RequestName == "PutRawEventsRequest") {
                var request = (PutRawEventsRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.EventBusArn;
                return result;
            }
            if (requestContext.RequestName == "PutResourcePolicyRequest") {
                var request = (PutResourcePolicyRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.ResourceArn;
                return result;
            }
            if (requestContext.RequestName == "UpdateEventBusRequest") {
                var request = (UpdateEventBusRequest)requestContext.OriginalRequest;
                result.EventBusArn = request.EventBusArn;
                return result;
            }

            return result;
        }
    }
}