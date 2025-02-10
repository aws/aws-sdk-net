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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendVoiceMessage Request Marshaller
    /// </summary>       
    public class SendVoiceMessageRequestMarshaller : IMarshaller<IRequest, SendVoiceMessageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendVoiceMessageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendVoiceMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoiceV2");
            string target = "PinpointSMSVoiceV2.SendVoiceMessage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetConfigurationSetName())
            {
                context.Writer.WritePropertyName("ConfigurationSetName");
                context.Writer.WriteStringValue(publicRequest.ConfigurationSetName);
            }

            if(publicRequest.IsSetContext())
            {
                context.Writer.WritePropertyName("Context");
                context.Writer.WriteStartObject();
                foreach (var publicRequestContextKvp in publicRequest.Context)
                {
                    context.Writer.WritePropertyName(publicRequestContextKvp.Key);
                    var publicRequestContextValue = publicRequestContextKvp.Value;

                        context.Writer.WriteStringValue(publicRequestContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDestinationPhoneNumber())
            {
                context.Writer.WritePropertyName("DestinationPhoneNumber");
                context.Writer.WriteStringValue(publicRequest.DestinationPhoneNumber);
            }

            if(publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("DryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }

            if(publicRequest.IsSetMaxPricePerMinute())
            {
                context.Writer.WritePropertyName("MaxPricePerMinute");
                context.Writer.WriteStringValue(publicRequest.MaxPricePerMinute);
            }

            if(publicRequest.IsSetMessageBody())
            {
                context.Writer.WritePropertyName("MessageBody");
                context.Writer.WriteStringValue(publicRequest.MessageBody);
            }

            if(publicRequest.IsSetMessageBodyTextType())
            {
                context.Writer.WritePropertyName("MessageBodyTextType");
                context.Writer.WriteStringValue(publicRequest.MessageBodyTextType);
            }

            if(publicRequest.IsSetMessageFeedbackEnabled())
            {
                context.Writer.WritePropertyName("MessageFeedbackEnabled");
                context.Writer.WriteBooleanValue(publicRequest.MessageFeedbackEnabled.Value);
            }

            if(publicRequest.IsSetOriginationIdentity())
            {
                context.Writer.WritePropertyName("OriginationIdentity");
                context.Writer.WriteStringValue(publicRequest.OriginationIdentity);
            }

            if(publicRequest.IsSetProtectConfigurationId())
            {
                context.Writer.WritePropertyName("ProtectConfigurationId");
                context.Writer.WriteStringValue(publicRequest.ProtectConfigurationId);
            }

            if(publicRequest.IsSetTimeToLive())
            {
                context.Writer.WritePropertyName("TimeToLive");
                context.Writer.WriteNumberValue(publicRequest.TimeToLive.Value);
            }

            if(publicRequest.IsSetVoiceId())
            {
                context.Writer.WritePropertyName("VoiceId");
                context.Writer.WriteStringValue(publicRequest.VoiceId);
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
        private static SendVoiceMessageRequestMarshaller _instance = new SendVoiceMessageRequestMarshaller();        

        internal static SendVoiceMessageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendVoiceMessageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}