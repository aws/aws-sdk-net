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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendMediaMessage Request Marshaller
    /// </summary>       
    public class SendMediaMessageRequestMarshaller : IMarshaller<IRequest, SendMediaMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendMediaMessageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendMediaMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoiceV2");
            string target = "PinpointSMSVoiceV2.SendMediaMessage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConfigurationSetName())
                {
                    context.Writer.WritePropertyName("ConfigurationSetName");
                    context.Writer.Write(publicRequest.ConfigurationSetName);
                }

                if(publicRequest.IsSetContext())
                {
                    context.Writer.WritePropertyName("Context");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestContextKvp in publicRequest.Context)
                    {
                        context.Writer.WritePropertyName(publicRequestContextKvp.Key);
                        var publicRequestContextValue = publicRequestContextKvp.Value;

                            context.Writer.Write(publicRequestContextValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDestinationPhoneNumber())
                {
                    context.Writer.WritePropertyName("DestinationPhoneNumber");
                    context.Writer.Write(publicRequest.DestinationPhoneNumber);
                }

                if(publicRequest.IsSetDryRun())
                {
                    context.Writer.WritePropertyName("DryRun");
                    context.Writer.Write(publicRequest.DryRun);
                }

                if(publicRequest.IsSetMaxPrice())
                {
                    context.Writer.WritePropertyName("MaxPrice");
                    context.Writer.Write(publicRequest.MaxPrice);
                }

                if(publicRequest.IsSetMediaUrls())
                {
                    context.Writer.WritePropertyName("MediaUrls");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMediaUrlsListValue in publicRequest.MediaUrls)
                    {
                            context.Writer.Write(publicRequestMediaUrlsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMessageBody())
                {
                    context.Writer.WritePropertyName("MessageBody");
                    context.Writer.Write(publicRequest.MessageBody);
                }

                if(publicRequest.IsSetMessageFeedbackEnabled())
                {
                    context.Writer.WritePropertyName("MessageFeedbackEnabled");
                    context.Writer.Write(publicRequest.MessageFeedbackEnabled);
                }

                if(publicRequest.IsSetOriginationIdentity())
                {
                    context.Writer.WritePropertyName("OriginationIdentity");
                    context.Writer.Write(publicRequest.OriginationIdentity);
                }

                if(publicRequest.IsSetProtectConfigurationId())
                {
                    context.Writer.WritePropertyName("ProtectConfigurationId");
                    context.Writer.Write(publicRequest.ProtectConfigurationId);
                }

                if(publicRequest.IsSetTimeToLive())
                {
                    context.Writer.WritePropertyName("TimeToLive");
                    context.Writer.Write(publicRequest.TimeToLive);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static SendMediaMessageRequestMarshaller _instance = new SendMediaMessageRequestMarshaller();        

        internal static SendMediaMessageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendMediaMessageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}