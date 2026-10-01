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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";
            request.HttpMethod = "POST";

            if (publicRequest.IsSetChimeBearer())
            {
                request.Headers["x-amz-chime-bearer"] = publicRequest.ChimeBearer;
            }

            request.ResourcePath = "/channels";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetAppInstanceArn())
            {
                context.Writer.WritePropertyName("AppInstanceArn");
                context.Writer.WriteStringValue(publicRequest.AppInstanceArn);
            }
            if (publicRequest.IsSetChannelId())
            {
                context.Writer.WritePropertyName("ChannelId");
                context.Writer.WriteStringValue(publicRequest.ChannelId);
            }
            if (publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }
            else
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if (publicRequest.IsSetElasticChannelConfiguration())
            {
                context.Writer.WritePropertyName("ElasticChannelConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ElasticChannelConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ElasticChannelConfiguration, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetExpirationSettings())
            {
                context.Writer.WritePropertyName("ExpirationSettings");
                context.Writer.WriteStartObject();

                var marshaller = ExpirationSettingsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ExpirationSettings, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetMemberArns())
            {
                context.Writer.WritePropertyName("MemberArns");
                context.Writer.WriteStartArray();
                foreach (var publicRequestMemberArnsListValue in publicRequest.MemberArns)
                {
                    context.Writer.WriteStringValue(publicRequestMemberArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetMetadata())
            {
                context.Writer.WritePropertyName("Metadata");
                context.Writer.WriteStringValue(publicRequest.Metadata);
            }
            if (publicRequest.IsSetMode())
            {
                context.Writer.WritePropertyName("Mode");
                context.Writer.WriteStringValue(publicRequest.Mode);
            }
            if (publicRequest.IsSetModeratorArns())
            {
                context.Writer.WritePropertyName("ModeratorArns");
                context.Writer.WriteStartArray();
                foreach (var publicRequestModeratorArnsListValue in publicRequest.ModeratorArns)
                {
                    context.Writer.WriteStringValue(publicRequestModeratorArnsListValue);
                }
                context.Writer.WriteEndArray();
            }
            if (publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }
            if (publicRequest.IsSetPrivacy())
            {
                context.Writer.WritePropertyName("Privacy");
                context.Writer.WriteStringValue(publicRequest.Privacy);
            }
            if (publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach (var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
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

        private static readonly CreateChannelRequestMarshaller _instance = new();

        internal static CreateChannelRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CreateChannelRequestMarshaller Instance => _instance;
    }
}
