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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */

using System;
using System.Linq;
using System.Collections.Generic;
using Amazon.NeptuneGraph.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Util;
using Amazon.NeptuneGraph.Endpoints;

#pragma warning disable 1591

namespace Amazon.NeptuneGraph.Internal
{
    /// <summary>
    /// Amazon NeptuneGraph endpoint resolver.
    /// Custom PipelineHandler responsible for resolving endpoint and setting authentication parameters for NeptuneGraph service requests.
    /// Collects values for NeptuneGraphEndpointParameters and then tries to resolve endpoint by calling 
    /// ResolveEndpoint method on GlobalEndpoints.Provider if present, otherwise uses NeptuneGraphEndpointProvider.
    /// Responsible for setting authentication and http headers provided by resolved endpoint.
    /// </summary>
    public class AmazonNeptuneGraphEndpointResolver : BaseEndpointResolver
    {
        protected override void ServiceSpecificHandler(IExecutionContext executionContext, EndpointParameters parameters)
        {

            InjectHostPrefix(executionContext.RequestContext);
        }

        protected override EndpointParameters MapEndpointsParameters(IRequestContext requestContext)
        {
            var config = (AmazonNeptuneGraphConfig)requestContext.ClientConfig;
            var result = new NeptuneGraphEndpointParameters();
            result.Region = requestContext.Request.AlternateEndpoint?.SystemName ?? config.RegionEndpoint?.SystemName;;
            result.UseFIPS = config.UseFIPSEndpoint;
            result.UseDualStack = config.UseDualstackEndpoint;
            result.Endpoint = config.ServiceURL;


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
            if (requestContext.RequestName == "CancelExportTaskRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "CancelImportTaskRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "CancelQueryRequest") {
                result.ApiType = "DataPlane";
                return result;
            }
            if (requestContext.RequestName == "CreateGraphRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "CreateGraphSnapshotRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "CreateGraphUsingImportTaskRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "CreatePrivateGraphEndpointRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "DeleteGraphRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "DeleteGraphSnapshotRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "DeletePrivateGraphEndpointRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "ExecuteQueryRequest") {
                result.ApiType = "DataPlane";
                return result;
            }
            if (requestContext.RequestName == "GetExportTaskRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "GetGraphRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "GetGraphSnapshotRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "GetGraphSummaryRequest") {
                result.ApiType = "DataPlane";
                return result;
            }
            if (requestContext.RequestName == "GetImportTaskRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "GetPrivateGraphEndpointRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "GetQueryRequest") {
                result.ApiType = "DataPlane";
                return result;
            }
            if (requestContext.RequestName == "ListExportTasksRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "ListGraphsRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "ListGraphSnapshotsRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "ListImportTasksRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "ListPrivateGraphEndpointsRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "ListQueriesRequest") {
                result.ApiType = "DataPlane";
                return result;
            }
            if (requestContext.RequestName == "ListTagsForResourceRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "ResetGraphRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "RestoreGraphFromSnapshotRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "StartExportTaskRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "StartGraphRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "StartImportTaskRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "StopGraphRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "TagResourceRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "UntagResourceRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }
            if (requestContext.RequestName == "UpdateGraphRequest") {
                result.ApiType = "ControlPlane";
                return result;
            }

            return result;
        }
    }
}