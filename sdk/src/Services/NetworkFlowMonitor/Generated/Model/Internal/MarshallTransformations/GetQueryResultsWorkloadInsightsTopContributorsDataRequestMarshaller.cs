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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFlowMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFlowMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetQueryResultsWorkloadInsightsTopContributorsData Request Marshaller
    /// </summary>       
    public class GetQueryResultsWorkloadInsightsTopContributorsDataRequestMarshaller : IMarshaller<IRequest, GetQueryResultsWorkloadInsightsTopContributorsDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetQueryResultsWorkloadInsightsTopContributorsDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetQueryResultsWorkloadInsightsTopContributorsDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFlowMonitor");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-19";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetQueryId())
                throw new AmazonNetworkFlowMonitorException("Request object does not have required field QueryId set");
            request.AddPathResource("{queryId}", StringUtils.FromString(publicRequest.QueryId));
            if (!publicRequest.IsSetScopeId())
                throw new AmazonNetworkFlowMonitorException("Request object does not have required field ScopeId set");
            request.AddPathResource("{scopeId}", StringUtils.FromString(publicRequest.ScopeId));
            
            if (publicRequest.IsSetMaxResults())
                request.Parameters.Add("maxResults", StringUtils.FromInt(publicRequest.MaxResults));
            
            if (publicRequest.IsSetNextToken())
                request.Parameters.Add("nextToken", StringUtils.FromString(publicRequest.NextToken));
            request.ResourcePath = "/workloadInsights/{scopeId}/topContributorsDataQueries/{queryId}/results";
            request.UseQueryString = true;

            return request;
        }
        private static GetQueryResultsWorkloadInsightsTopContributorsDataRequestMarshaller _instance = new GetQueryResultsWorkloadInsightsTopContributorsDataRequestMarshaller();        

        internal static GetQueryResultsWorkloadInsightsTopContributorsDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetQueryResultsWorkloadInsightsTopContributorsDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}