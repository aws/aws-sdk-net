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
    /// CreateProgram Request Marshaller
    /// </summary>
    public partial class CreateProgramRequestMarshaller : IMarshaller<IRequest, CreateProgramRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProgramRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(CreateProgramRequest publicRequest)
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

            if (!publicRequest.IsSetProgramName())
            {
                throw new AmazonMediaTailorException("Request object does not have required field ProgramName set");
            }
            request.AddPathResource("{ProgramName}", StringUtils.FromString(publicRequest.ProgramName));

            request.ResourcePath = "/channel/{ChannelName}/program/{ProgramName}";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAdBreaks())
            {
                context.Writer.WritePropertyName("AdBreaks");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAdBreaksListValue in publicRequest.AdBreaks)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AdBreakMarshaller.Instance;
                    marshaller.Marshall(publicRequestAdBreaksListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetAudienceMedia())
            {
                context.Writer.WritePropertyName("AudienceMedia");
                context.Writer.WriteStartArray();
                foreach (var publicRequestAudienceMediaListValue in publicRequest.AudienceMedia)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AudienceMediaMarshaller.Instance;
                    marshaller.Marshall(publicRequestAudienceMediaListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetLiveSourceName())
            {
                context.Writer.WritePropertyName("LiveSourceName");
                context.Writer.WriteStringValue(publicRequest.LiveSourceName);
            }
            if (publicRequest.IsSetScheduleConfiguration())
            {
                context.Writer.WritePropertyName("ScheduleConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScheduleConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetSourceLocationName())
            {
                context.Writer.WritePropertyName("SourceLocationName");
                context.Writer.WriteStringValue(publicRequest.SourceLocationName);
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
            if (publicRequest.IsSetVodSourceName())
            {
                context.Writer.WritePropertyName("VodSourceName");
                context.Writer.WriteStringValue(publicRequest.VodSourceName);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly CreateProgramRequestMarshaller _instance = new();

        internal static CreateProgramRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateProgramRequestMarshaller Instance => _instance;
    }
}
