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

using Amazon.MediaTailor.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateChannel Request Marshaller
    /// </summary>
    public partial class CreateChannelRequestMarshaller : IMarshaller<IRequest, CreateChannelRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateChannelRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateChannelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-23";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetChannelName())
            {
                throw new AmazonMediaTailorException("Request object does not have required field ChannelName set");
            }
            request.AddPathResource("{ChannelName}", StringUtils.FromString(publicRequest.ChannelName));

            request.ResourcePath = "/channel/{ChannelName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAudiences())
            {
                context.Writer.WritePropertyName("Audiences");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAudiencesListValue in publicRequest.Audiences)
                {
                    context.Writer.WriteStringValue(publicRequestAudiencesListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetFillerSlate())
            {
                context.Writer.WritePropertyName("FillerSlate");
                context.Writer.WriteStartObject();

                var marshaller = SlateSourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.FillerSlate, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetOutputs())
            {
                context.Writer.WritePropertyName("Outputs");
                context.Writer.WriteStartArray();
                foreach (var publicRequestOutputsListValue in publicRequest.Outputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RequestOutputItemMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetPlaybackMode())
            {
                context.Writer.WritePropertyName("PlaybackMode");
                context.Writer.WriteStringValue(publicRequest.PlaybackMode);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;
                    context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetTier())
            {
                context.Writer.WritePropertyName("Tier");
                context.Writer.WriteStringValue(publicRequest.Tier);
            }
            if (publicRequest.IsSetTimeShiftConfiguration())
            {
                context.Writer.WritePropertyName("TimeShiftConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TimeShiftConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.TimeShiftConfiguration, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateChannelRequestMarshaller _instance = new();

        internal static CreateChannelRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateChannelRequestMarshaller Instance => _instance;
    }
}
