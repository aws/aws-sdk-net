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
    /// RequestSenderId Request Marshaller
    /// </summary>       
    public class RequestSenderIdRequestMarshaller : IMarshaller<IRequest, RequestSenderIdRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RequestSenderIdRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RequestSenderIdRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoiceV2");
            string target = "PinpointSMSVoiceV2.RequestSenderId";
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
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("ClientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDeletionProtectionEnabled())
            {
                context.Writer.WritePropertyName("DeletionProtectionEnabled");
                context.Writer.WriteBooleanValue(publicRequest.DeletionProtectionEnabled.Value);
            }

            if(publicRequest.IsSetIsoCountryCode())
            {
                context.Writer.WritePropertyName("IsoCountryCode");
                context.Writer.WriteStringValue(publicRequest.IsoCountryCode);
            }

            if(publicRequest.IsSetMessageTypes())
            {
                context.Writer.WritePropertyName("MessageTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMessageTypesListValue in publicRequest.MessageTypes)
                {
                        context.Writer.WriteStringValue(publicRequestMessageTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSenderId())
            {
                context.Writer.WritePropertyName("SenderId");
                context.Writer.WriteStringValue(publicRequest.SenderId);
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
        private static RequestSenderIdRequestMarshaller _instance = new RequestSenderIdRequestMarshaller();        

        internal static RequestSenderIdRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RequestSenderIdRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}