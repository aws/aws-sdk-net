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

using Amazon.OpenSearchMemory.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.OpenSearchMemory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSpace Request Marshaller
    /// </summary>
    public partial class UpdateSpaceRequestMarshaller : IMarshaller<IRequest, UpdateSpaceRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSpaceRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateSpaceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpenSearchMemory");
            string target = "OpenSearchMemory.UpdateSpace";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-08-24";
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
            if (publicRequest.IsSetEventExpiryDays())
            {
                context.Writer.WritePropertyName("eventExpiryDays");
                context.Writer.WriteNumberValue(publicRequest.EventExpiryDays.Value);
            }
            if (publicRequest.IsSetExtractionModelId())
            {
                context.Writer.WritePropertyName("extractionModelId");
                context.Writer.WriteStringValue(publicRequest.ExtractionModelId);
            }
            if (publicRequest.IsSetMemoryExpiryDays())
            {
                context.Writer.WritePropertyName("memoryExpiryDays");
                context.Writer.WriteNumberValue(publicRequest.MemoryExpiryDays.Value);
            }
            if (publicRequest.IsSetMemoryStrategies())
            {
                context.Writer.WritePropertyName("memoryStrategies");
                context.Writer.WriteStartArray();
                foreach (var publicRequestMemoryStrategiesListValue in publicRequest.MemoryStrategies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MemoryStrategyMarshaller.Instance;
                    marshaller.Marshall(publicRequestMemoryStrategiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetSpaceId())
            {
                context.Writer.WritePropertyName("spaceId");
                context.Writer.WriteStringValue(publicRequest.SpaceId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateSpaceRequestMarshaller _instance = new();

        internal static UpdateSpaceRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateSpaceRequestMarshaller Instance => _instance;
    }
}
