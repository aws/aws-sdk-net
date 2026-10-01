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

using Amazon.BedrockAgentRuntime.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteAgentMemory Request Marshaller
    /// </summary>
    public partial class DeleteAgentMemoryRequestMarshaller : IMarshaller<IRequest, DeleteAgentMemoryRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteAgentMemoryRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteAgentMemoryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentRuntime");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "DELETE";

            if (publicRequest.IsSetMemoryId())
            {
                request.Parameters.Add("memoryId", StringUtils.FromString(publicRequest.MemoryId));
            }

            if (publicRequest.IsSetSessionId())
            {
                request.Parameters.Add("sessionId", StringUtils.FromString(publicRequest.SessionId));
            }

            if (!publicRequest.IsSetAgentAliasId())
            {
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field AgentAliasId set");
            }
            request.AddPathResource("{agentAliasId}", StringUtils.FromString(publicRequest.AgentAliasId));

            if (!publicRequest.IsSetAgentId())
            {
                throw new AmazonBedrockAgentRuntimeException("Request object does not have required field AgentId set");
            }
            request.AddPathResource("{agentId}", StringUtils.FromString(publicRequest.AgentId));

            request.ResourcePath = "/agents/{agentId}/agentAliases/{agentAliasId}/memories";

            request.UseQueryString = true;

            return request;
        }

        private static readonly DeleteAgentMemoryRequestMarshaller _instance = new();

        internal static DeleteAgentMemoryRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteAgentMemoryRequestMarshaller Instance => _instance;
    }
}
