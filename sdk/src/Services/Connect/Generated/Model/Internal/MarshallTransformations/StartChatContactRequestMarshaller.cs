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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
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
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartChatContact Request Marshaller
    /// </summary>       
    public class StartChatContactRequestMarshaller : IMarshaller<IRequest, StartChatContactRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartChatContactRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartChatContactRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/contact/chat";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestAttributesKvp in publicRequest.Attributes)
                {
                    context.Writer.WritePropertyName(publicRequestAttributesKvp.Key);
                    var publicRequestAttributesValue = publicRequestAttributesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetChatDurationInMinutes())
            {
                context.Writer.WritePropertyName("ChatDurationInMinutes");
                context.Writer.WriteNumberValue(publicRequest.ChatDurationInMinutes.Value);
            }

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
            if(publicRequest.IsSetContactFlowId())
            {
                context.Writer.WritePropertyName("ContactFlowId");
                context.Writer.WriteStringValue(publicRequest.ContactFlowId);
            }

            if(publicRequest.IsSetCustomerId())
            {
                context.Writer.WritePropertyName("CustomerId");
                context.Writer.WriteStringValue(publicRequest.CustomerId);
            }

            if(publicRequest.IsSetInitialMessage())
            {
                context.Writer.WritePropertyName("InitialMessage");
                context.Writer.WriteStartObject();

                var marshaller = ChatMessageMarshaller.Instance;
                marshaller.Marshall(publicRequest.InitialMessage, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInstanceId())
            {
                context.Writer.WritePropertyName("InstanceId");
                context.Writer.WriteStringValue(publicRequest.InstanceId);
            }

            if(publicRequest.IsSetParticipantDetails())
            {
                context.Writer.WritePropertyName("ParticipantDetails");
                context.Writer.WriteStartObject();

                var marshaller = ParticipantDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ParticipantDetails, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPersistentChat())
            {
                context.Writer.WritePropertyName("PersistentChat");
                context.Writer.WriteStartObject();

                var marshaller = PersistentChatMarshaller.Instance;
                marshaller.Marshall(publicRequest.PersistentChat, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRelatedContactId())
            {
                context.Writer.WritePropertyName("RelatedContactId");
                context.Writer.WriteStringValue(publicRequest.RelatedContactId);
            }

            if(publicRequest.IsSetSegmentAttributes())
            {
                context.Writer.WritePropertyName("SegmentAttributes");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSegmentAttributesKvp in publicRequest.SegmentAttributes)
                {
                    context.Writer.WritePropertyName(publicRequestSegmentAttributesKvp.Key);
                    var publicRequestSegmentAttributesValue = publicRequestSegmentAttributesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = SegmentAttributeValueMarshaller.Instance;
                    marshaller.Marshall(publicRequestSegmentAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSupportedMessagingContentTypes())
            {
                context.Writer.WritePropertyName("SupportedMessagingContentTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSupportedMessagingContentTypesListValue in publicRequest.SupportedMessagingContentTypes)
                {
                        context.Writer.WriteStringValue(publicRequestSupportedMessagingContentTypesListValue);
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
        private static StartChatContactRequestMarshaller _instance = new StartChatContactRequestMarshaller();        

        internal static StartChatContactRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartChatContactRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}