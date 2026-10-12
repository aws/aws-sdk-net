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

using Amazon.HealthLake.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.HealthLake.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProfileWithAgent Request Marshaller
    /// </summary>
    public partial class UpdateProfileWithAgentRequestMarshaller : IMarshaller<IRequest, UpdateProfileWithAgentRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProfileWithAgentRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateProfileWithAgentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.HealthLake");
            string target = "HealthLake.UpdateProfileWithAgent";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetConversationId())
            {
                context.Writer.WritePropertyName("ConversationId");
                context.Writer.WriteStringValue(publicRequest.ConversationId);
            }
            if (publicRequest.IsSetInputMessage())
            {
                context.Writer.WritePropertyName("InputMessage");
                context.Writer.WriteStartObject();

                var marshaller = AgentInputMessageMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputMessage, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetProfileId())
            {
                context.Writer.WritePropertyName("ProfileId");
                context.Writer.WriteStringValue(publicRequest.ProfileId);
            }
            if (publicRequest.IsSetSourceFormat())
            {
                context.Writer.WritePropertyName("SourceFormat");
                context.Writer.WriteStringValue(publicRequest.SourceFormat);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.HostPrefix = $"datatransformation.";

            return request;
        }

        private static readonly UpdateProfileWithAgentRequestMarshaller _instance = new();

        internal static UpdateProfileWithAgentRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateProfileWithAgentRequestMarshaller Instance => _instance;
    }
}
