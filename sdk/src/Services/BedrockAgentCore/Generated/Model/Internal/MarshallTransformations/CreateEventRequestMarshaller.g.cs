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
    /// CreateEvent Request Marshaller
    /// </summary>
    public partial class CreateEventRequestMarshaller : IMarshaller<IRequest, CreateEventRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEventRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateEventRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetMemoryId())
            {
                throw new AmazonBedrockAgentCoreException("Request object does not have required field MemoryId set");
            }
            request.AddPathResource("{memoryId}", StringUtils.FromString(publicRequest.MemoryId));

            request.ResourcePath = "/memories/{memoryId}/events";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetActorId())
            {
                context.Writer.WritePropertyName("actorId");
                context.Writer.WriteStringValue(publicRequest.ActorId);
            }
            if (publicRequest.IsSetBranch())
            {
                context.Writer.WritePropertyName("branch");
                context.Writer.WriteStartObject();

                var marshaller = BranchMarshaller.Instance;
                marshaller.Marshall(publicRequest.Branch, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }
            else
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetEventTimestamp())
            {
                context.Writer.WritePropertyName("eventTimestamp");
                context.Writer.WriteNumberValue(Amazon.Util.AWSSDKUtils.ConvertToUnixEpochSecondsDecimal(publicRequest.EventTimestamp.Value));
            }
            if (publicRequest.IsSetExtractionConfig())
            {
                context.Writer.WritePropertyName("extractionConfig");
                context.Writer.WriteStartObject();

                var marshaller = ExtractionConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExtractionConfig, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetExtractionMode())
            {
                context.Writer.WritePropertyName("extractionMode");
                context.Writer.WriteStringValue(publicRequest.ExtractionMode);
            }
            if (publicRequest.IsSetMetadata())
            {
                context.Writer.WritePropertyName("metadata");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMetadataKvp in publicRequest.Metadata)
                {
                    context.Writer.WritePropertyName(publicRequestMetadataKvp.Key);
                    var publicRequestMetadataValue = publicRequestMetadataKvp.Value;
                    context.Writer.WriteStartObject();

                    var marshaller = MetadataValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestMetadataValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetPayload())
            {
                context.Writer.WritePropertyName("payload");
                context.Writer.WriteStartArray();
                foreach (var publicRequestPayloadListValue in publicRequest.Payload)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PayloadTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequestPayloadListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSessionId())
            {
                context.Writer.WritePropertyName("sessionId");
                context.Writer.WriteStringValue(publicRequest.SessionId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateEventRequestMarshaller _instance = new();

        internal static CreateEventRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateEventRequestMarshaller Instance => _instance;
    }
}
