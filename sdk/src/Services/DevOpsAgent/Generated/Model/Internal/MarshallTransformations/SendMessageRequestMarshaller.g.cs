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

using Amazon.DevOpsAgent.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendMessage Request Marshaller
    /// </summary>
    public partial class SendMessageRequestMarshaller : IMarshaller<IRequest, SendMessageRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendMessageRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(SendMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DevOpsAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-01-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAgentSpaceId())
            {
                throw new AmazonDevOpsAgentException("Request object does not have required field AgentSpaceId set");
            }
            request.AddPathResource("{agentSpaceId}", StringUtils.FromString(publicRequest.AgentSpaceId));

            request.ResourcePath = "/agents/agent-space/{agentSpaceId}/chat/sendMessage";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAssetIds())
            {
                context.Writer.WritePropertyName("assetIds");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAssetIdsListValue in publicRequest.AssetIds)
                {
                    context.Writer.WriteStringValue(publicRequestAssetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetContent())
            {
                context.Writer.WritePropertyName("content");
                context.Writer.WriteStringValue(publicRequest.Content);
            }
            if (publicRequest.IsSetContext())
            {
                context.Writer.WritePropertyName("context");
                context.Writer.WriteStartObject();

                var marshaller = SendMessageContextMarshaller.Instance;
                marshaller.Marshall(publicRequest.Context, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetExecutionId())
            {
                context.Writer.WritePropertyName("executionId");
                context.Writer.WriteStringValue(publicRequest.ExecutionId);
            }
            if (publicRequest.IsSetModelTier())
            {
                context.Writer.WritePropertyName("modelTier");
                context.Writer.WriteStringValue(publicRequest.ModelTier);
            }
            if (publicRequest.IsSetUserId())
            {
                context.Writer.WritePropertyName("userId");
                context.Writer.WriteStringValue(publicRequest.UserId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.HostPrefix = $"dp.";

            return request;
        }

        private static readonly SendMessageRequestMarshaller _instance = new();

        internal static SendMessageRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static SendMessageRequestMarshaller Instance => _instance;
    }
}
