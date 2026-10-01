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
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.NetworkFlowMonitor.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.NetworkFlowMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StopQueryWorkloadInsightsTopContributors Request Marshaller
    /// </summary>
    public partial class StopQueryWorkloadInsightsTopContributorsRequestMarshaller : IMarshaller<IRequest, StopQueryWorkloadInsightsTopContributorsRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StopQueryWorkloadInsightsTopContributorsRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(StopQueryWorkloadInsightsTopContributorsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFlowMonitor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-19";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetQueryId())
            {
                throw new AmazonNetworkFlowMonitorException("Request object does not have required field QueryId set");
            }
            request.AddPathResource("{queryId}", StringUtils.FromString(publicRequest.QueryId));

            if (!publicRequest.IsSetScopeId())
            {
                throw new AmazonNetworkFlowMonitorException("Request object does not have required field ScopeId set");
            }
            request.AddPathResource("{scopeId}", StringUtils.FromString(publicRequest.ScopeId));

            request.ResourcePath = "/workloadInsights/{scopeId}/topContributorsQueries/{queryId}";

            return request;
        }

        private static readonly StopQueryWorkloadInsightsTopContributorsRequestMarshaller _instance = new();

        internal static StopQueryWorkloadInsightsTopContributorsRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static StopQueryWorkloadInsightsTopContributorsRequestMarshaller Instance => _instance;
    }
}
