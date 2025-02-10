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
    /// CreateMediaCapturePipeline Request Marshaller
    /// </summary>       
    public class CreateMediaCapturePipelineRequestMarshaller : IMarshaller<IRequest, CreateMediaCapturePipelineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMediaCapturePipelineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMediaCapturePipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ChimeSDKMediaPipelines");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-15";
            request.HttpMethod = "POST";

            request.ResourcePath = "/sdk-media-capture-pipelines";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChimeSdkMeetingConfiguration())
            {
                context.Writer.WritePropertyName("ChimeSdkMeetingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ChimeSdkMeetingConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ChimeSdkMeetingConfiguration, context);

                context.Writer.WriteEndObject();
            }

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
            if(publicRequest.IsSetSinkArn())
            {
                context.Writer.WritePropertyName("SinkArn");
                context.Writer.WriteStringValue(publicRequest.SinkArn);
            }

            if(publicRequest.IsSetSinkIamRoleArn())
            {
                context.Writer.WritePropertyName("SinkIamRoleArn");
                context.Writer.WriteStringValue(publicRequest.SinkIamRoleArn);
            }

            if(publicRequest.IsSetSinkType())
            {
                context.Writer.WritePropertyName("SinkType");
                context.Writer.WriteStringValue(publicRequest.SinkType);
            }

            if(publicRequest.IsSetSourceArn())
            {
                context.Writer.WritePropertyName("SourceArn");
                context.Writer.WriteStringValue(publicRequest.SourceArn);
            }

            if(publicRequest.IsSetSourceType())
            {
                context.Writer.WritePropertyName("SourceType");
                context.Writer.WriteStringValue(publicRequest.SourceType);
            }

            if(publicRequest.IsSetSseAwsKeyManagementParams())
            {
                context.Writer.WritePropertyName("SseAwsKeyManagementParams");
                context.Writer.WriteStartObject();

                var marshaller = SseAwsKeyManagementParamsMarshaller.Instance;
                marshaller.Marshall(publicRequest.SseAwsKeyManagementParams, context);

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
        private static CreateMediaCapturePipelineRequestMarshaller _instance = new CreateMediaCapturePipelineRequestMarshaller();        

        internal static CreateMediaCapturePipelineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMediaCapturePipelineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}