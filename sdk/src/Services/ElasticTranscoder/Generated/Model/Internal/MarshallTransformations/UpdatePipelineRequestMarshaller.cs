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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePipeline Request Marshaller
    /// </summary>       
    public class UpdatePipelineRequestMarshaller : IMarshaller<IRequest, UpdatePipelineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePipelineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-09-25";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetId())
                throw new AmazonElasticTranscoderException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/2012-09-25/pipelines/{Id}";
#if NETCOREAPP3_1_OR_GREATER
            ArrayBufferWriter<byte> arrayBufferWriter = new ArrayBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAwsKmsKeyArn())
            {
                context.Writer.WritePropertyName("AwsKmsKeyArn");
                context.Writer.WriteStringValue(publicRequest.AwsKmsKeyArn);
            }

            if(publicRequest.IsSetContentConfig())
            {
                context.Writer.WritePropertyName("ContentConfig");
                context.Writer.WriteStartObject();

                var marshaller = PipelineOutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ContentConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputBucket())
            {
                context.Writer.WritePropertyName("InputBucket");
                context.Writer.WriteStringValue(publicRequest.InputBucket);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNotifications())
            {
                context.Writer.WritePropertyName("Notifications");
                context.Writer.WriteStartObject();

                var marshaller = NotificationsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Notifications, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetThumbnailConfig())
            {
                context.Writer.WritePropertyName("ThumbnailConfig");
                context.Writer.WriteStartObject();

                var marshaller = PipelineOutputConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ThumbnailConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETCOREAPP3_1_OR_GREATER
            request.Content = arrayBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdatePipelineRequestMarshaller _instance = new UpdatePipelineRequestMarshaller();        

        internal static UpdatePipelineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePipelineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}