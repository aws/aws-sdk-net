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

using Amazon.SecurityAgent.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.SecurityAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateThreatModel Request Marshaller
    /// </summary>
    public partial class CreateThreatModelRequestMarshaller : IMarshaller<IRequest, CreateThreatModelRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateThreatModelRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateThreatModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateThreatModel";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAgentSpaceId())
            {
                context.Writer.WritePropertyName("agentSpaceId");
                context.Writer.WriteStringValue(publicRequest.AgentSpaceId);
            }
            if (publicRequest.IsSetAssets())
            {
                context.Writer.WritePropertyName("assets");
                context.Writer.WriteStartObject();

                var marshaller = AssetsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Assets, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }
            if (publicRequest.IsSetLogConfig())
            {
                context.Writer.WritePropertyName("logConfig");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchLogMarshaller.Instance;
                marshaller.Marshall(publicRequest.LogConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetReportDestination())
            {
                context.Writer.WritePropertyName("reportDestination");
                context.Writer.WriteStartObject();

                var marshaller = ReportDestinationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ReportDestination, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetScopeDocs())
            {
                context.Writer.WritePropertyName("scopeDocs");
                context.Writer.WriteStartArray();
                foreach (var publicRequestScopeDocsListValue in publicRequest.ScopeDocs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DocumentInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequestScopeDocsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetServiceRole())
            {
                context.Writer.WritePropertyName("serviceRole");
                context.Writer.WriteStringValue(publicRequest.ServiceRole);
            }
            if (publicRequest.IsSetTitle())
            {
                context.Writer.WritePropertyName("title");
                context.Writer.WriteStringValue(publicRequest.Title);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateThreatModelRequestMarshaller _instance = new();

        internal static CreateThreatModelRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateThreatModelRequestMarshaller Instance => _instance;
    }
}
