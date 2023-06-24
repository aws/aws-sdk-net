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
 * Do not modify this file. This file is generated from the chime-sdk-messaging-2021-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ChimeSDKMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateChannel Request Marshaller
    /// </summary>       
    public class CreateChannelRequestMarshaller : IMarshaller<IRequest, CreateChannelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateChannelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateChannelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/channels";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAppInstanceArn())
                {
                    context.Writer.WritePropertyName("AppInstanceArn");
                    context.Writer.Write(publicRequest.AppInstanceArn);
                }

                if(publicRequest.IsSetChannelId())
                {
                    context.Writer.WritePropertyName("ChannelId");
                    context.Writer.Write(publicRequest.ChannelId);
                }

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
                if(publicRequest.IsSetElasticChannelConfiguration())
                {
                    context.Writer.WritePropertyName("ElasticChannelConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ElasticChannelConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ElasticChannelConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExpirationSettings())
                {
                    context.Writer.WritePropertyName("ExpirationSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = ExpirationSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExpirationSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMemberArns())
                {
                    context.Writer.WritePropertyName("MemberArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMemberArnsListValue in publicRequest.MemberArns)
                    {
                            context.Writer.Write(publicRequestMemberArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMetadata())
                {
                    context.Writer.WritePropertyName("Metadata");
                    context.Writer.Write(publicRequest.Metadata);
                }

                if(publicRequest.IsSetMode())
                {
                    context.Writer.WritePropertyName("Mode");
                    context.Writer.Write(publicRequest.Mode);
                }

                if(publicRequest.IsSetModeratorArns())
                {
                    context.Writer.WritePropertyName("ModeratorArns");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestModeratorArnsListValue in publicRequest.ModeratorArns)
                    {
                            context.Writer.Write(publicRequestModeratorArnsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetPrivacy())
                {
                    context.Writer.WritePropertyName("Privacy");
                    context.Writer.Write(publicRequest.Privacy);
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetChimeBearer()) 
            {
                request.Headers["x-amz-chime-bearer"] = publicRequest.ChimeBearer;
            }

            return request;
        }
        private static CreateChannelRequestMarshaller _instance = new CreateChannelRequestMarshaller();        

        internal static CreateChannelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateChannelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}