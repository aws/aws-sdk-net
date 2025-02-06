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
    /// CreateEventDestination Request Marshaller
    /// </summary>       
    public class CreateEventDestinationRequestMarshaller : IMarshaller<IRequest, CreateEventDestinationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEventDestinationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEventDestinationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PinpointSMSVoiceV2");
            string target = "PinpointSMSVoiceV2.CreateEventDestination";
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
            if(publicRequest.IsSetCloudWatchLogsDestination())
            {
                context.Writer.WritePropertyName("CloudWatchLogsDestination");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchLogsDestinationMarshaller.Instance;
                marshaller.Marshall(publicRequest.CloudWatchLogsDestination, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConfigurationSetName())
            {
                context.Writer.WritePropertyName("ConfigurationSetName");
                context.Writer.WriteStringValue(publicRequest.ConfigurationSetName);
            }

            if(publicRequest.IsSetEventDestinationName())
            {
                context.Writer.WritePropertyName("EventDestinationName");
                context.Writer.WriteStringValue(publicRequest.EventDestinationName);
            }

            if(publicRequest.IsSetKinesisFirehoseDestination())
            {
                context.Writer.WritePropertyName("KinesisFirehoseDestination");
                context.Writer.WriteStartObject();

                var marshaller = KinesisFirehoseDestinationMarshaller.Instance;
                marshaller.Marshall(publicRequest.KinesisFirehoseDestination, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMatchingEventTypes())
            {
                context.Writer.WritePropertyName("MatchingEventTypes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMatchingEventTypesListValue in publicRequest.MatchingEventTypes)
                {
                        context.Writer.WriteStringValue(publicRequestMatchingEventTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSnsDestination())
            {
                context.Writer.WritePropertyName("SnsDestination");
                context.Writer.WriteStartObject();

                var marshaller = SnsDestinationMarshaller.Instance;
                marshaller.Marshall(publicRequest.SnsDestination, context);

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
        private static CreateEventDestinationRequestMarshaller _instance = new CreateEventDestinationRequestMarshaller();        

        internal static CreateEventDestinationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEventDestinationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}