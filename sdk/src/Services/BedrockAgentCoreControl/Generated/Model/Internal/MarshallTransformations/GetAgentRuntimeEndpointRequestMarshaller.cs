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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
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
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetAgentRuntimeEndpoint Request Marshaller
    /// </summary>       
    public class GetAgentRuntimeEndpointRequestMarshaller : IMarshaller<IRequest, GetAgentRuntimeEndpointRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetAgentRuntimeEndpointRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetAgentRuntimeEndpointRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAgentRuntimeId())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field AgentRuntimeId set");
            request.AddPathResource("{agentRuntimeId}", StringUtils.FromString(publicRequest.AgentRuntimeId));
            if (!publicRequest.IsSetEndpointName())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field EndpointName set");
            request.AddPathResource("{endpointName}", StringUtils.FromString(publicRequest.EndpointName));
            request.ResourcePath = "/runtimes/{agentRuntimeId}/runtime-endpoints/{endpointName}/";

            return request;
        }
        private static GetAgentRuntimeEndpointRequestMarshaller _instance = new GetAgentRuntimeEndpointRequestMarshaller();        

        internal static GetAgentRuntimeEndpointRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetAgentRuntimeEndpointRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}