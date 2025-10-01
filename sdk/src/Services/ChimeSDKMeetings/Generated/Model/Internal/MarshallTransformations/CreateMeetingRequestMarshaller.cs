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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetExternalMeetingId())
                {
                    context.Writer.WritePropertyName("ExternalMeetingId");
                    context.Writer.Write(publicRequest.ExternalMeetingId);
                }

                if(publicRequest.IsSetMediaPlacementNetworkType())
                {
                    context.Writer.WritePropertyName("MediaPlacementNetworkType");
                    context.Writer.Write(publicRequest.MediaPlacementNetworkType);
                }

                if(publicRequest.IsSetMediaRegion())
                {
                    context.Writer.WritePropertyName("MediaRegion");
                    context.Writer.Write(publicRequest.MediaRegion);
                }

                if(publicRequest.IsSetMeetingFeatures())
                {
                    context.Writer.WritePropertyName("MeetingFeatures");
                    context.Writer.WriteObjectStart();

                    var marshaller = MeetingFeaturesConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MeetingFeatures, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMeetingHostId())
                {
                    context.Writer.WritePropertyName("MeetingHostId");
                    context.Writer.Write(publicRequest.MeetingHostId);
                }

                if(publicRequest.IsSetNotificationsConfiguration())
                {
                    context.Writer.WritePropertyName("NotificationsConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationsConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NotificationsConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPrimaryMeetingId())
                {
                    context.Writer.WritePropertyName("PrimaryMeetingId");
                    context.Writer.Write(publicRequest.PrimaryMeetingId);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTenantIds())
                {
                    context.Writer.WritePropertyName("TenantIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTenantIdsListValue in publicRequest.TenantIds)
                    {
                            context.Writer.Write(publicRequestTenantIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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