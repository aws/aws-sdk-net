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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Rekognition.Model;
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
namespace Amazon.Rekognition.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartFaceSearch Request Marshaller
    /// </summary>       
    public class StartFaceSearchRequestMarshaller : IMarshaller<IRequest, StartFaceSearchRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartFaceSearchRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartFaceSearchRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Rekognition");
            string target = "RekognitionService.StartFaceSearch";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-06-27";
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
            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            if(publicRequest.IsSetCollectionId())
            {
                context.Writer.WritePropertyName("CollectionId");
                context.Writer.WriteStringValue(publicRequest.CollectionId);
            }

            if(publicRequest.IsSetFaceMatchThreshold())
            {
                context.Writer.WritePropertyName("FaceMatchThreshold");
                if(StringUtils.IsSpecialFloatValue(publicRequest.FaceMatchThreshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(publicRequest.FaceMatchThreshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.FaceMatchThreshold.Value);
                }
            }

            if(publicRequest.IsSetJobTag())
            {
                context.Writer.WritePropertyName("JobTag");
                context.Writer.WriteStringValue(publicRequest.JobTag);
            }

            if(publicRequest.IsSetNotificationChannel())
            {
                context.Writer.WritePropertyName("NotificationChannel");
                context.Writer.WriteStartObject();

                var marshaller = NotificationChannelMarshaller.Instance;
                marshaller.Marshall(publicRequest.NotificationChannel, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVideo())
            {
                context.Writer.WritePropertyName("Video");
                context.Writer.WriteStartObject();

                var marshaller = VideoMarshaller.Instance;
                marshaller.Marshall(publicRequest.Video, context);

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
        private static StartFaceSearchRequestMarshaller _instance = new StartFaceSearchRequestMarshaller();        

        internal static StartFaceSearchRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartFaceSearchRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}