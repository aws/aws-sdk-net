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
    /// SendChatIntegrationEvent Request Marshaller
    /// </summary>       
    public class SendChatIntegrationEventRequestMarshaller : IMarshaller<IRequest, SendChatIntegrationEventRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SendChatIntegrationEventRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SendChatIntegrationEventRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "POST";

            request.ResourcePath = "/chat-integration-event";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDestinationId())
            {
                context.Writer.WritePropertyName("DestinationId");
                context.Writer.WriteStringValue(publicRequest.DestinationId);
            }

            if(publicRequest.IsSetEvent())
            {
                context.Writer.WritePropertyName("Event");
                context.Writer.WriteStartObject();

                var marshaller = ChatEventMarshaller.Instance;
                marshaller.Marshall(publicRequest.Event, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetNewSessionDetails())
            {
                context.Writer.WritePropertyName("NewSessionDetails");
                context.Writer.WriteStartObject();

                var marshaller = NewSessionDetailsMarshaller.Instance;
                marshaller.Marshall(publicRequest.NewSessionDetails, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceId())
            {
                context.Writer.WritePropertyName("SourceId");
                context.Writer.WriteStringValue(publicRequest.SourceId);
            }

            if(publicRequest.IsSetSubtype())
            {
                context.Writer.WritePropertyName("Subtype");
                context.Writer.WriteStringValue(publicRequest.Subtype);
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
        private static SendChatIntegrationEventRequestMarshaller _instance = new SendChatIntegrationEventRequestMarshaller();        

        internal static SendChatIntegrationEventRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SendChatIntegrationEventRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}