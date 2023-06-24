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
    /// ChannelFlowCallback Request Marshaller
    /// </summary>       
    public class ChannelFlowCallbackRequestMarshaller : IMarshaller<IRequest, ChannelFlowCallbackRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ChannelFlowCallbackRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ChannelFlowCallbackRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-05-15";
            request.HttpMethod = "POST";

            request.AddSubResource("operation", "channel-flow-callback");
            if (!publicRequest.IsSetChannelArn())
                throw new AmazonChimeSDKMessagingException("Request object does not have required field ChannelArn set");
            request.AddPathResource("{channelArn}", StringUtils.FromString(publicRequest.ChannelArn));
            request.ResourcePath = "/channels/{channelArn}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCallbackId())
                {
                    context.Writer.WritePropertyName("CallbackId");
                    context.Writer.Write(publicRequest.CallbackId);
                }

                else if(!(publicRequest.IsSetCallbackId()))
                {
                    context.Writer.WritePropertyName("CallbackId");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetChannelMessage())
                {
                    context.Writer.WritePropertyName("ChannelMessage");
                    context.Writer.WriteObjectStart();

                    var marshaller = ChannelMessageCallbackMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ChannelMessage, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDeleteResource())
                {
                    context.Writer.WritePropertyName("DeleteResource");
                    context.Writer.Write(publicRequest.DeleteResource);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ChannelFlowCallbackRequestMarshaller _instance = new ChannelFlowCallbackRequestMarshaller();        

        internal static ChannelFlowCallbackRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChannelFlowCallbackRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}