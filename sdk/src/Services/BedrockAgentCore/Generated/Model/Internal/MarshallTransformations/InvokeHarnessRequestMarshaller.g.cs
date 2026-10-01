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
    /// InvokeHarness Request Marshaller
    /// </summary>
    public partial class InvokeHarnessRequestMarshaller : IMarshaller<IRequest, InvokeHarnessRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeHarnessRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(InvokeHarnessRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            if (string.IsNullOrEmpty(publicRequest.HarnessArn))
            {
                throw new AmazonBedrockAgentCoreException("Request object does not have required field HarnessArn set");
            }

            if (publicRequest.IsSetHarnessArn())
            {
                request.Parameters.Add("harnessArn", StringUtils.FromString(publicRequest.HarnessArn));
            }

            if (publicRequest.IsSetQualifier())
            {
                request.Parameters.Add("qualifier", StringUtils.FromString(publicRequest.Qualifier));
            }

            if (publicRequest.IsSetBaggage())
            {
                request.Headers["baggage"] = publicRequest.Baggage;
            }

            if (publicRequest.IsSetRuntimeSessionId())
            {
                request.Headers["X-Amzn-Bedrock-AgentCore-Runtime-Session-Id"] = publicRequest.RuntimeSessionId;
            }

            if (publicRequest.IsSetRuntimeUserId())
            {
                request.Headers["X-Amzn-Bedrock-AgentCore-Runtime-User-Id"] = publicRequest.RuntimeUserId;
            }

            if (publicRequest.IsSetTraceId())
            {
                request.Headers["X-Amzn-Trace-Id"] = publicRequest.TraceId;
            }

            if (publicRequest.IsSetTraceParent())
            {
                request.Headers["traceparent"] = publicRequest.TraceParent;
            }

            if (publicRequest.IsSetTraceState())
            {
                request.Headers["tracestate"] = publicRequest.TraceState;
            }

            request.ResourcePath = "/harnesses/invoke";
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
            if (publicRequest.IsSetAllowedTools())
            {
                context.Writer.WritePropertyName("allowedTools");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAllowedToolsListValue in publicRequest.AllowedTools)
                {
                    context.Writer.WriteStringValue(publicRequestAllowedToolsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetMaxIterations())
            {
                context.Writer.WritePropertyName("maxIterations");
                context.Writer.WriteNumberValue(publicRequest.MaxIterations.Value);
            }
            if (publicRequest.IsSetMaxTokens())
            {
                context.Writer.WritePropertyName("maxTokens");
                context.Writer.WriteNumberValue(publicRequest.MaxTokens.Value);
            }
            if (publicRequest.IsSetMessages())
            {
                context.Writer.WritePropertyName("messages");
                context.Writer.WriteStartArray();
                foreach (var publicRequestMessagesListValue in publicRequest.Messages)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HarnessMessageMarshaller.Instance;
                    marshaller.Marshall(publicRequestMessagesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetModel())
            {
                context.Writer.WritePropertyName("model");
                context.Writer.WriteStartObject();

                var marshaller = HarnessModelConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Model, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSkills())
            {
                context.Writer.WritePropertyName("skills");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSkillsListValue in publicRequest.Skills)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HarnessSkillMarshaller.Instance;
                    marshaller.Marshall(publicRequestSkillsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSystemPrompt())
            {
                context.Writer.WritePropertyName("systemPrompt");
                context.Writer.WriteStartArray();
                foreach (var publicRequestSystemPromptListValue in publicRequest.SystemPrompt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HarnessSystemContentBlockMarshaller.Instance;
                    marshaller.Marshall(publicRequestSystemPromptListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetTimeoutSeconds())
            {
                context.Writer.WritePropertyName("timeoutSeconds");
                context.Writer.WriteNumberValue(publicRequest.TimeoutSeconds.Value);
            }
            if (publicRequest.IsSetTools())
            {
                context.Writer.WritePropertyName("tools");
                context.Writer.WriteStartArray();
                foreach (var publicRequestToolsListValue in publicRequest.Tools)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HarnessToolMarshaller.Instance;
                    marshaller.Marshall(publicRequestToolsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            request.UseQueryString = true;

            return request;
        }

        private static readonly InvokeHarnessRequestMarshaller _instance = new();

        internal static InvokeHarnessRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InvokeHarnessRequestMarshaller Instance => _instance;
    }
}
