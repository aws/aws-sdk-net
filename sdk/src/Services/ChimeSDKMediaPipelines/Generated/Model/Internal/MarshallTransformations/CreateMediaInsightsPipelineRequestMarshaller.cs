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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ChimeSDKMediaPipelines.Model;
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
namespace Amazon.ChimeSDKMediaPipelines.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMediaInsightsPipeline Request Marshaller
    /// </summary>       
    public class CreateMediaInsightsPipelineRequestMarshaller : IMarshaller<IRequest, CreateMediaInsightsPipelineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMediaInsightsPipelineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMediaInsightsPipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMediaPipelines");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/media-insights-pipelines";
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

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetKinesisVideoStreamRecordingSourceRuntimeConfiguration())
            {
                context.Writer.WritePropertyName("KinesisVideoStreamRecordingSourceRuntimeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KinesisVideoStreamRecordingSourceRuntimeConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.KinesisVideoStreamRecordingSourceRuntimeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKinesisVideoStreamSourceRuntimeConfiguration())
            {
                context.Writer.WritePropertyName("KinesisVideoStreamSourceRuntimeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = KinesisVideoStreamSourceRuntimeConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.KinesisVideoStreamSourceRuntimeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMediaInsightsPipelineConfigurationArn())
            {
                context.Writer.WritePropertyName("MediaInsightsPipelineConfigurationArn");
                context.Writer.WriteStringValue(publicRequest.MediaInsightsPipelineConfigurationArn);
            }

            if(publicRequest.IsSetMediaInsightsRuntimeMetadata())
            {
                context.Writer.WritePropertyName("MediaInsightsRuntimeMetadata");
                context.Writer.WriteStartObject();
                foreach (var publicRequestMediaInsightsRuntimeMetadataKvp in publicRequest.MediaInsightsRuntimeMetadata)
                {
                    context.Writer.WritePropertyName(publicRequestMediaInsightsRuntimeMetadataKvp.Key);
                    var publicRequestMediaInsightsRuntimeMetadataValue = publicRequestMediaInsightsRuntimeMetadataKvp.Value;

                        context.Writer.WriteStringValue(publicRequestMediaInsightsRuntimeMetadataValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetS3RecordingSinkRuntimeConfiguration())
            {
                context.Writer.WritePropertyName("S3RecordingSinkRuntimeConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = S3RecordingSinkRuntimeConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.S3RecordingSinkRuntimeConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static CreateMediaInsightsPipelineRequestMarshaller _instance = new CreateMediaInsightsPipelineRequestMarshaller();        

        internal static CreateMediaInsightsPipelineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMediaInsightsPipelineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}