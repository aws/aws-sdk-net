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
    /// CreateQueue Request Marshaller
    /// </summary>       
    public class CreateQueueRequestMarshaller : IMarshaller<IRequest, CreateQueueRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateQueueRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateQueueRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Connect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-08";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetInstanceId())
                throw new AmazonConnectException("Request object does not have required field InstanceId set");
            request.AddPathResource("{InstanceId}", StringUtils.FromString(publicRequest.InstanceId));
            request.ResourcePath = "/queues/{InstanceId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetHoursOfOperationId())
            {
                context.Writer.WritePropertyName("HoursOfOperationId");
                context.Writer.WriteStringValue(publicRequest.HoursOfOperationId);
            }

            if(publicRequest.IsSetMaxContacts())
            {
                context.Writer.WritePropertyName("MaxContacts");
                context.Writer.WriteNumberValue(publicRequest.MaxContacts.Value);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetOutboundCallerConfig())
            {
                context.Writer.WritePropertyName("OutboundCallerConfig");
                context.Writer.WriteStartObject();

                var marshaller = OutboundCallerConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutboundCallerConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutboundEmailConfig())
            {
                context.Writer.WritePropertyName("OutboundEmailConfig");
                context.Writer.WriteStartObject();

                var marshaller = OutboundEmailConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutboundEmailConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetQuickConnectIds())
            {
                context.Writer.WritePropertyName("QuickConnectIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestQuickConnectIdsListValue in publicRequest.QuickConnectIds)
                {
                        context.Writer.WriteStringValue(publicRequestQuickConnectIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
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
        private static CreateQueueRequestMarshaller _instance = new CreateQueueRequestMarshaller();        

        internal static CreateQueueRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateQueueRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}