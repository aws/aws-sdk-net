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

using Amazon.BedrockAgentCore.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteEvent Request Marshaller
    /// </summary>
    public partial class DeleteEventRequestMarshaller : IMarshaller<IRequest, DeleteEventRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteEventRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(DeleteEventRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetActorId())
            {
                throw new AmazonBedrockAgentCoreException("Request object does not have required field ActorId set");
            }
            request.AddPathResource("{actorId}", StringUtils.FromString(publicRequest.ActorId));

            if (!publicRequest.IsSetEventId())
            {
                throw new AmazonBedrockAgentCoreException("Request object does not have required field EventId set");
            }
            request.AddPathResource("{eventId}", StringUtils.FromString(publicRequest.EventId));

            if (!publicRequest.IsSetMemoryId())
            {
                throw new AmazonBedrockAgentCoreException("Request object does not have required field MemoryId set");
            }
            request.AddPathResource("{memoryId}", StringUtils.FromString(publicRequest.MemoryId));

            if (!publicRequest.IsSetSessionId())
            {
                throw new AmazonBedrockAgentCoreException("Request object does not have required field SessionId set");
            }
            request.AddPathResource("{sessionId}", StringUtils.FromString(publicRequest.SessionId));

            request.ResourcePath = "/memories/{memoryId}/actor/{actorId}/sessions/{sessionId}/events/{eventId}";

            return request;
        }

        private static readonly DeleteEventRequestMarshaller _instance = new();

        internal static DeleteEventRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeleteEventRequestMarshaller Instance => _instance;
    }
}
