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
 * Do not modify this file. This file is generated from the chime-sdk-meetings-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMeetings.Model;
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
namespace Amazon.ChimeSDKMeetings.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchUpdateAttendeeCapabilitiesExcept Request Marshaller
    /// </summary>       
    public class BatchUpdateAttendeeCapabilitiesExceptRequestMarshaller : IMarshaller<IRequest, BatchUpdateAttendeeCapabilitiesExceptRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchUpdateAttendeeCapabilitiesExceptRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchUpdateAttendeeCapabilitiesExceptRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMeetings");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "PUT";

            request.AddSubResource("operation", "batch-update-except");
            if (!publicRequest.IsSetMeetingId())
                throw new AmazonChimeSDKMeetingsException("Request object does not have required field MeetingId set");
            request.AddPathResource("{MeetingId}", StringUtils.FromString(publicRequest.MeetingId));
            request.ResourcePath = "/meetings/{MeetingId}/attendees/capabilities";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCapabilities())
            {
                context.Writer.WritePropertyName("Capabilities");
                context.Writer.WriteStartObject();

                var marshaller = AttendeeCapabilitiesMarshaller.Instance;
                marshaller.Marshall(publicRequest.Capabilities, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExcludedAttendeeIds())
            {
                context.Writer.WritePropertyName("ExcludedAttendeeIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestExcludedAttendeeIdsListValue in publicRequest.ExcludedAttendeeIds)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttendeeIdItemMarshaller.Instance;
                    marshaller.Marshall(publicRequestExcludedAttendeeIdsListValue, context);

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
        private static BatchUpdateAttendeeCapabilitiesExceptRequestMarshaller _instance = new BatchUpdateAttendeeCapabilitiesExceptRequestMarshaller();        

        internal static BatchUpdateAttendeeCapabilitiesExceptRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchUpdateAttendeeCapabilitiesExceptRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}