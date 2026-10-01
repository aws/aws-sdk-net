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

using Amazon.Backup.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFramework Request Marshaller
    /// </summary>
    public partial class CreateFrameworkRequestMarshaller : IMarshaller<IRequest, CreateFrameworkRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFrameworkRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateFrameworkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/audit/frameworks";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetFrameworkControls())
            {
                context.Writer.WritePropertyName("FrameworkControls");
                context.Writer.WriteStartArray();
                foreach (var publicRequestFrameworkControlsListValue in publicRequest.FrameworkControls)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FrameworkControlMarshaller.Instance;
                    marshaller.Marshall(publicRequestFrameworkControlsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetFrameworkDescription())
            {
                context.Writer.WritePropertyName("FrameworkDescription");
                context.Writer.WriteStringValue(publicRequest.FrameworkDescription);
            }
            if (publicRequest.IsSetFrameworkName())
            {
                context.Writer.WritePropertyName("FrameworkName");
                context.Writer.WriteStringValue(publicRequest.FrameworkName);
            }
            if (publicRequest.IsSetFrameworkTags())
            {
                context.Writer.WritePropertyName("FrameworkTags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestFrameworkTagsKvp in publicRequest.FrameworkTags)
                {
                    context.Writer.WritePropertyName(publicRequestFrameworkTagsKvp.Key);
                    var publicRequestFrameworkTagsValue = publicRequestFrameworkTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestFrameworkTagsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetIdempotencyToken())
            {
                context.Writer.WritePropertyName("IdempotencyToken");
                context.Writer.WriteStringValue(publicRequest.IdempotencyToken);
            }
            else
            {
                context.Writer.WritePropertyName("IdempotencyToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateFrameworkRequestMarshaller _instance = new();

        internal static CreateFrameworkRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateFrameworkRequestMarshaller Instance => _instance;
    }
}
