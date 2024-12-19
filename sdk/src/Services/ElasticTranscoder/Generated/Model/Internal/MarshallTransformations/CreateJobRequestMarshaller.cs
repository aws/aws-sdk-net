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
    /// CreateJob Request Marshaller
    /// </summary>       
    public class CreateJobRequestMarshaller : IMarshaller<IRequest, CreateJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-09-25";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2012-09-25/jobs";
#if NETCOREAPP3_1_OR_GREATER
            ArrayBufferWriter<byte> arrayBufferWriter = new ArrayBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetInput())
            {
                context.Writer.WritePropertyName("Input");
                context.Writer.WriteStartObject();

                var marshaller = JobInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Input, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInputs())
            {
                context.Writer.WritePropertyName("Inputs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInputsListValue in publicRequest.Inputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = JobInputMarshaller.Instance;
                    marshaller.Marshall(publicRequestInputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOutput())
            {
                context.Writer.WritePropertyName("Output");
                context.Writer.WriteStartObject();

                var marshaller = CreateJobOutputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Output, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutputKeyPrefix())
            {
                context.Writer.WritePropertyName("OutputKeyPrefix");
                context.Writer.WriteStringValue(publicRequest.OutputKeyPrefix);
            }

            if(publicRequest.IsSetOutputs())
            {
                context.Writer.WritePropertyName("Outputs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOutputsListValue in publicRequest.Outputs)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CreateJobOutputMarshaller.Instance;
                    marshaller.Marshall(publicRequestOutputsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPipelineId())
            {
                context.Writer.WritePropertyName("PipelineId");
                context.Writer.WriteStringValue(publicRequest.PipelineId);
            }

            if(publicRequest.IsSetPlaylists())
            {
                context.Writer.WritePropertyName("Playlists");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPlaylistsListValue in publicRequest.Playlists)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CreateJobPlaylistMarshaller.Instance;
                    marshaller.Marshall(publicRequestPlaylistsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetUserMetadata())
            {
                context.Writer.WritePropertyName("UserMetadata");
                context.Writer.WriteStartObject();
                foreach (var publicRequestUserMetadataKvp in publicRequest.UserMetadata)
                {
                    context.Writer.WritePropertyName(publicRequestUserMetadataKvp.Key);
                    var publicRequestUserMetadataValue = publicRequestUserMetadataKvp.Value;

                        context.Writer.WriteStringValue(publicRequestUserMetadataValue);
                }
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
        private static CreateJobRequestMarshaller _instance = new CreateJobRequestMarshaller();        

        internal static CreateJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}