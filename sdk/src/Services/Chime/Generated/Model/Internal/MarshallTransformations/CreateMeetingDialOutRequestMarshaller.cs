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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chime.Model;
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
namespace Amazon.Chime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMeetingDialOut Request Marshaller
    /// </summary>       
    public class CreateMeetingDialOutRequestMarshaller : IMarshaller<IRequest, CreateMeetingDialOutRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMeetingDialOutRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMeetingDialOutRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetMeetingId())
                throw new AmazonChimeException("Request object does not have required field MeetingId set");
            request.AddPathResource("{meetingId}", StringUtils.FromString(publicRequest.MeetingId));
            request.ResourcePath = "/meetings/{meetingId}/dial-outs";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetFromPhoneNumber())
            {
                context.Writer.WritePropertyName("FromPhoneNumber");
                context.Writer.WriteStringValue(publicRequest.FromPhoneNumber);
            }

            if(publicRequest.IsSetJoinToken())
            {
                context.Writer.WritePropertyName("JoinToken");
                context.Writer.WriteStringValue(publicRequest.JoinToken);
            }

            if(publicRequest.IsSetToPhoneNumber())
            {
                context.Writer.WritePropertyName("ToPhoneNumber");
                context.Writer.WriteStringValue(publicRequest.ToPhoneNumber);
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
        private static CreateMeetingDialOutRequestMarshaller _instance = new CreateMeetingDialOutRequestMarshaller();        

        internal static CreateMeetingDialOutRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMeetingDialOutRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}