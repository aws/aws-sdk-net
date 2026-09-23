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

using Amazon.OAM.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.OAM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLink Request Marshaller
    /// </summary>
    public partial class UpdateLinkRequestMarshaller : IMarshaller<IRequest, UpdateLinkRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLinkRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(UpdateLinkRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OAM");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-06-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateLink";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetIdentifier())
            {
                context.Writer.WritePropertyName("Identifier");
                context.Writer.WriteStringValue(publicRequest.Identifier);
            }
            if (publicRequest.IsSetIncludeTags())
            {
                context.Writer.WritePropertyName("IncludeTags");
                context.Writer.WriteBooleanValue(publicRequest.IncludeTags.Value);
            }
            if (publicRequest.IsSetLinkConfiguration())
            {
                context.Writer.WritePropertyName("LinkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = LinkConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LinkConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetResourceTypes())
            {
                context.Writer.WritePropertyName("ResourceTypes");
                context.Writer.WriteStartArray();
                foreach (var publicRequestResourceTypesListValue in publicRequest.ResourceTypes)
                {
                    context.Writer.WriteStringValue(publicRequestResourceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly UpdateLinkRequestMarshaller _instance = new();

        internal static UpdateLinkRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static UpdateLinkRequestMarshaller Instance => _instance;
    }
}
