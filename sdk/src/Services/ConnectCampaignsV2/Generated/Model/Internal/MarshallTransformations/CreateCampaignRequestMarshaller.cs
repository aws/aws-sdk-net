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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ConnectCampaignsV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.ConnectCampaignsV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCampaign Request Marshaller
    /// </summary>       
    public class CreateCampaignRequestMarshaller : IMarshaller<IRequest, CreateCampaignRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCampaignRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCampaignRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ConnectCampaignsV2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-04-23";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/v2/campaigns";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChannelSubtypeConfig())
            {
                context.Writer.WritePropertyName("channelSubtypeConfig");
                context.Writer.WriteStartObject();

                var marshaller = ChannelSubtypeConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ChannelSubtypeConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCommunicationLimitsOverride())
            {
                context.Writer.WritePropertyName("communicationLimitsOverride");
                context.Writer.WriteStartObject();

                var marshaller = CommunicationLimitsConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CommunicationLimitsOverride, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCommunicationTimeConfig())
            {
                context.Writer.WritePropertyName("communicationTimeConfig");
                context.Writer.WriteStartObject();

                var marshaller = CommunicationTimeConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CommunicationTimeConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConnectCampaignFlowArn())
            {
                context.Writer.WritePropertyName("connectCampaignFlowArn");
                context.Writer.WriteStringValue(publicRequest.ConnectCampaignFlowArn);
            }

            if(publicRequest.IsSetConnectInstanceId())
            {
                context.Writer.WritePropertyName("connectInstanceId");
                context.Writer.WriteStringValue(publicRequest.ConnectInstanceId);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetSchedule())
            {
                context.Writer.WritePropertyName("schedule");
                context.Writer.WriteStartObject();

                var marshaller = ScheduleMarshaller.Instance;
                marshaller.Marshall(publicRequest.Schedule, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSource())
            {
                context.Writer.WritePropertyName("source");
                context.Writer.WriteStartObject();

                var marshaller = SourceMarshaller.Instance;
                marshaller.Marshall(publicRequest.Source, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
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

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateCampaignRequestMarshaller _instance = new CreateCampaignRequestMarshaller();        

        internal static CreateCampaignRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCampaignRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}