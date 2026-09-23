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

using Amazon.ChimeSDKMessaging.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ChannelFlowCallback Request Marshaller
    /// </summary>
    public partial class ChannelFlowCallbackRequestMarshaller : IMarshaller<IRequest, ChannelFlowCallbackRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ChannelFlowCallbackRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(ChannelFlowCallbackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetChannelArn())
            {
                throw new AmazonChimeSDKMessagingException("Request object does not have required field ChannelArn set");
            }
            request.AddPathResource("{ChannelArn}", StringUtils.FromString(publicRequest.ChannelArn));

            request.AddSubResource("operation", "channel-flow-callback");
            request.ResourcePath = "/channels/{ChannelArn}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetCallbackId())
            {
                context.Writer.WritePropertyName("CallbackId");
                context.Writer.WriteStringValue(publicRequest.CallbackId);
            }
            else
            {
                context.Writer.WritePropertyName("CallbackId");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetChannelMessage())
            {
                context.Writer.WritePropertyName("ChannelMessage");
                context.Writer.WriteStartObject();

                var marshaller = ChannelMessageCallbackMarshaller.Instance;
                marshaller.Marshall(publicRequest.ChannelMessage, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetDeleteResource())
            {
                context.Writer.WritePropertyName("DeleteResource");
                context.Writer.WriteBooleanValue(publicRequest.DeleteResource.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly ChannelFlowCallbackRequestMarshaller _instance = new();

        internal static ChannelFlowCallbackRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ChannelFlowCallbackRequestMarshaller Instance => _instance;
    }
}
