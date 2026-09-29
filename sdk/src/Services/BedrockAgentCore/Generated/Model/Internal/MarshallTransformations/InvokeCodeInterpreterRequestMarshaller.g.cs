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
    /// InvokeCodeInterpreter Request Marshaller
    /// </summary>
    public partial class InvokeCodeInterpreterRequestMarshaller : IMarshaller<IRequest, InvokeCodeInterpreterRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeCodeInterpreterRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(InvokeCodeInterpreterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetSessionId())
            {
                request.Headers["x-amzn-code-interpreter-session-id"] = publicRequest.SessionId;
            }

            if (publicRequest.IsSetTraceId())
            {
                request.Headers["X-Amzn-Trace-Id"] = publicRequest.TraceId;
            }

            if (publicRequest.IsSetTraceParent())
            {
                request.Headers["traceparent"] = publicRequest.TraceParent;
            }

            if (!publicRequest.IsSetCodeInterpreterIdentifier())
            {
                throw new AmazonBedrockAgentCoreException("Request object does not have required field CodeInterpreterIdentifier set");
            }
            request.AddPathResource("{codeInterpreterIdentifier}", StringUtils.FromString(publicRequest.CodeInterpreterIdentifier));

            request.ResourcePath = "/code-interpreters/{codeInterpreterIdentifier}/tools/invoke";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetArguments())
            {
                context.Writer.WritePropertyName("arguments");
                context.Writer.WriteStartObject();

                var marshaller = ToolArgumentsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Arguments, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly InvokeCodeInterpreterRequestMarshaller _instance = new();

        internal static InvokeCodeInterpreterRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static InvokeCodeInterpreterRequestMarshaller Instance => _instance;
    }
}
