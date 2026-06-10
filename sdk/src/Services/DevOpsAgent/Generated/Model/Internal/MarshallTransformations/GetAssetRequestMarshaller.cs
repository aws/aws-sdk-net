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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAsset Request Marshaller
    /// </summary>       
    public class GetAssetRequestMarshaller : IMarshaller<IRequest, GetAssetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAssetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAssetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DevOpsAgent");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-01-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAgentSpaceId())
                throw new AmazonDevOpsAgentException("Request object does not have required field AgentSpaceId set");
            request.AddPathResource("{agentSpaceId}", StringUtils.FromString(publicRequest.AgentSpaceId));
            if (!publicRequest.IsSetAssetId())
                throw new AmazonDevOpsAgentException("Request object does not have required field AssetId set");
            request.AddPathResource("{assetId}", StringUtils.FromString(publicRequest.AssetId));
            
            if (publicRequest.IsSetAssetVersion())
                request.Parameters.Add("assetVersion", StringUtils.FromInt(publicRequest.AssetVersion));
            request.ResourcePath = "/asset/agent-space/{agentSpaceId}/assets/{assetId}";
            request.UseQueryString = true;
            
            request.HostPrefix = $"dp.";

            return request;
        }
        private static GetAssetRequestMarshaller _instance = new GetAssetRequestMarshaller();        

        internal static GetAssetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAssetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}