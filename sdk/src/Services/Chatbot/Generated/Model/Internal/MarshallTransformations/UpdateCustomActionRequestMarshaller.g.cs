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

using Amazon.Chatbot.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Chatbot.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCustomAction Request Marshaller
    /// </summary>
    public partial class UpdateCustomActionRequestMarshaller : IMarshaller<IRequest, UpdateCustomActionRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateCustomActionRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateCustomActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chatbot");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-11";
            request.HttpMethod = "POST";

            request.ResourcePath = "/update-custom-action";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAliasName())
            {
                context.Writer.WritePropertyName("AliasName");
                context.Writer.WriteStringValue(publicRequest.AliasName);
            }
            if (publicRequest.IsSetAttachments())
            {
                context.Writer.WritePropertyName("Attachments");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAttachmentsListValue in publicRequest.Attachments)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomActionAttachmentMarshaller.Instance;
                    marshaller.Marshall(publicRequestAttachmentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetCustomActionArn())
            {
                context.Writer.WritePropertyName("CustomActionArn");
                context.Writer.WriteStringValue(publicRequest.CustomActionArn);
            }
            if (publicRequest.IsSetDefinition())
            {
                context.Writer.WritePropertyName("Definition");
                context.Writer.WriteStartObject();

                var marshaller = CustomActionDefinitionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Definition, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateCustomActionRequestMarshaller _instance = new();

        internal static UpdateCustomActionRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateCustomActionRequestMarshaller Instance => _instance;
    }
}
