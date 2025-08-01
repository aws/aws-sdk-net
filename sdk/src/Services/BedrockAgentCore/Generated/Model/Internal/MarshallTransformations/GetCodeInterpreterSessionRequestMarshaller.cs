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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
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
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetCodeInterpreterSession Request Marshaller
    /// </summary>       
    public class GetCodeInterpreterSessionRequestMarshaller : IMarshaller<IRequest, GetCodeInterpreterSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetCodeInterpreterSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetCodeInterpreterSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetCodeInterpreterIdentifier())
                throw new AmazonBedrockAgentCoreException("Request object does not have required field CodeInterpreterIdentifier set");
            request.AddPathResource("{codeInterpreterIdentifier}", StringUtils.FromString(publicRequest.CodeInterpreterIdentifier));
            
            if (publicRequest.IsSetSessionId())
                request.Parameters.Add("sessionId", StringUtils.FromString(publicRequest.SessionId));
            request.ResourcePath = "/code-interpreters/{codeInterpreterIdentifier}/sessions/get";
            request.UseQueryString = true;

            return request;
        }
        private static GetCodeInterpreterSessionRequestMarshaller _instance = new GetCodeInterpreterSessionRequestMarshaller();        

        internal static GetCodeInterpreterSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetCodeInterpreterSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}