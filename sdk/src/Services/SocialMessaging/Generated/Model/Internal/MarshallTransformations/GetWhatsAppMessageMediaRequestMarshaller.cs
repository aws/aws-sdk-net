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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SocialMessaging.Model;
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
namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetWhatsAppMessageMedia Request Marshaller
    /// </summary>       
    public class GetWhatsAppMessageMediaRequestMarshaller : IMarshaller<IRequest, GetWhatsAppMessageMediaRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetWhatsAppMessageMediaRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetWhatsAppMessageMediaRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SocialMessaging");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/whatsapp/media/get";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDestinationS3File())
            {
                context.Writer.WritePropertyName("destinationS3File");
                context.Writer.WriteStartObject();

                var marshaller = S3FileMarshaller.Instance;
                marshaller.Marshall(publicRequest.DestinationS3File, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDestinationS3PresignedUrl())
            {
                context.Writer.WritePropertyName("destinationS3PresignedUrl");
                context.Writer.WriteStartObject();

                var marshaller = S3PresignedUrlMarshaller.Instance;
                marshaller.Marshall(publicRequest.DestinationS3PresignedUrl, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMediaId())
            {
                context.Writer.WritePropertyName("mediaId");
                context.Writer.WriteStringValue(publicRequest.MediaId);
            }

            if(publicRequest.IsSetMetadataOnly())
            {
                context.Writer.WritePropertyName("metadataOnly");
                context.Writer.WriteBooleanValue(publicRequest.MetadataOnly.Value);
            }

            if(publicRequest.IsSetOriginationPhoneNumberId())
            {
                context.Writer.WritePropertyName("originationPhoneNumberId");
                context.Writer.WriteStringValue(publicRequest.OriginationPhoneNumberId);
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
        private static GetWhatsAppMessageMediaRequestMarshaller _instance = new GetWhatsAppMessageMediaRequestMarshaller();        

        internal static GetWhatsAppMessageMediaRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetWhatsAppMessageMediaRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}