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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
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
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetFlowAlias Request Marshaller
    /// </summary>       
    public class GetFlowAliasRequestMarshaller : IMarshaller<IRequest, GetFlowAliasRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetFlowAliasRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetFlowAliasRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgent");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetAliasIdentifier())
                throw new AmazonBedrockAgentException("Request object does not have required field AliasIdentifier set");
            request.AddPathResource("{aliasIdentifier}", StringUtils.FromString(publicRequest.AliasIdentifier));
            if (!publicRequest.IsSetFlowIdentifier())
                throw new AmazonBedrockAgentException("Request object does not have required field FlowIdentifier set");
            request.AddPathResource("{flowIdentifier}", StringUtils.FromString(publicRequest.FlowIdentifier));
            request.ResourcePath = "/flows/{flowIdentifier}/aliases/{aliasIdentifier}";

            return request;
        }
        private static GetFlowAliasRequestMarshaller _instance = new GetFlowAliasRequestMarshaller();        

        internal static GetFlowAliasRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetFlowAliasRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}