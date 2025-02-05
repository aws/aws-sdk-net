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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMeetings.Model;
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
namespace Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMeeting Request Marshaller
    /// </summary>       
    public class CreateMeetingRequestMarshaller : IMarshaller<IRequest, CreateMeetingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMeetingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMeetingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMeetings");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/meetings";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetExternalMeetingId())
            {
                context.Writer.WritePropertyName("ExternalMeetingId");
                context.Writer.WriteStringValue(publicRequest.ExternalMeetingId);
            }

            if(publicRequest.IsSetMediaRegion())
            {
                context.Writer.WritePropertyName("MediaRegion");
                context.Writer.WriteStringValue(publicRequest.MediaRegion);
            }

            if(publicRequest.IsSetMeetingFeatures())
            {
                context.Writer.WritePropertyName("MeetingFeatures");
                context.Writer.WriteStartObject();

                var marshaller = MeetingFeaturesConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.MeetingFeatures, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMeetingHostId())
            {
                context.Writer.WritePropertyName("MeetingHostId");
                context.Writer.WriteStringValue(publicRequest.MeetingHostId);
            }

            if(publicRequest.IsSetNotificationsConfiguration())
            {
                context.Writer.WritePropertyName("NotificationsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NotificationsConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationsConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPrimaryMeetingId())
            {
                context.Writer.WritePropertyName("PrimaryMeetingId");
                context.Writer.WriteStringValue(publicRequest.PrimaryMeetingId);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTenantIds())
            {
                context.Writer.WritePropertyName("TenantIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTenantIdsListValue in publicRequest.TenantIds)
                {
                        context.Writer.WriteStringValue(publicRequestTenantIdsListValue);
                }
                context.Writer.WriteEndArray();
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
        private static CreateMeetingRequestMarshaller _instance = new CreateMeetingRequestMarshaller();        

        internal static CreateMeetingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMeetingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}