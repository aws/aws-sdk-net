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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
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
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreatePrefetchSchedule Request Marshaller
    /// </summary>       
    public class CreatePrefetchScheduleRequestMarshaller : IMarshaller<IRequest, CreatePrefetchScheduleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreatePrefetchScheduleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreatePrefetchScheduleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-23";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetName())
                throw new AmazonMediaTailorException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            if (!publicRequest.IsSetPlaybackConfigurationName())
                throw new AmazonMediaTailorException("Request object does not have required field PlaybackConfigurationName set");
            request.AddPathResource("{PlaybackConfigurationName}", StringUtils.FromString(publicRequest.PlaybackConfigurationName));
            request.ResourcePath = "/prefetchSchedule/{PlaybackConfigurationName}/{Name}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetConsumption())
            {
                context.Writer.WritePropertyName("Consumption");
                context.Writer.WriteStartObject();

                var marshaller = PrefetchConsumptionMarshaller.Instance;
                marshaller.Marshall(publicRequest.Consumption, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRecurringPrefetchConfiguration())
            {
                context.Writer.WritePropertyName("RecurringPrefetchConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = RecurringPrefetchConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.RecurringPrefetchConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRetrieval())
            {
                context.Writer.WritePropertyName("Retrieval");
                context.Writer.WriteStartObject();

                var marshaller = PrefetchRetrievalMarshaller.Instance;
                marshaller.Marshall(publicRequest.Retrieval, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetScheduleType())
            {
                context.Writer.WritePropertyName("ScheduleType");
                context.Writer.WriteStringValue(publicRequest.ScheduleType);
            }

            if(publicRequest.IsSetStreamId())
            {
                context.Writer.WritePropertyName("StreamId");
                context.Writer.WriteStringValue(publicRequest.StreamId);
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
        private static CreatePrefetchScheduleRequestMarshaller _instance = new CreatePrefetchScheduleRequestMarshaller();        

        internal static CreatePrefetchScheduleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreatePrefetchScheduleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}