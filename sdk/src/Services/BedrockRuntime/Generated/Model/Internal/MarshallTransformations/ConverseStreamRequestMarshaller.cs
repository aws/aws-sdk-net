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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockRuntime.Model;
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
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConverseStream Request Marshaller
    /// </summary>       
    public class ConverseStreamRequestMarshaller : IMarshaller<IRequest, ConverseStreamRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ConverseStreamRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ConverseStreamRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-30";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetModelId())
                throw new AmazonBedrockRuntimeException("Request object does not have required field ModelId set");
            request.AddPathResource("{modelId}", StringUtils.FromString(publicRequest.ModelId));
            request.ResourcePath = "/model/{modelId}/converse-stream";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdditionalModelRequestFields())
            {
                context.Writer.WritePropertyName("additionalModelRequestFields");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequest.AdditionalModelRequestFields);
            }

            if(publicRequest.IsSetAdditionalModelResponseFieldPaths())
            {
                context.Writer.WritePropertyName("additionalModelResponseFieldPaths");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdditionalModelResponseFieldPathsListValue in publicRequest.AdditionalModelResponseFieldPaths)
                {
                        context.Writer.WriteStringValue(publicRequestAdditionalModelResponseFieldPathsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetGuardrailConfig())
            {
                context.Writer.WritePropertyName("guardrailConfig");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailStreamConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.GuardrailConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetInferenceConfig())
            {
                context.Writer.WritePropertyName("inferenceConfig");
                context.Writer.WriteStartObject();

                var marshaller = InferenceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.InferenceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMessages())
            {
                context.Writer.WritePropertyName("messages");
                context.Writer.WriteStartArray();
                foreach(var publicRequestMessagesListValue in publicRequest.Messages)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MessageMarshaller.Instance;
                    marshaller.Marshall(publicRequestMessagesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPerformanceConfig())
            {
                context.Writer.WritePropertyName("performanceConfig");
                context.Writer.WriteStartObject();

                var marshaller = PerformanceConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.PerformanceConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPromptVariables())
            {
                context.Writer.WritePropertyName("promptVariables");
                context.Writer.WriteStartObject();
                foreach (var publicRequestPromptVariablesKvp in publicRequest.PromptVariables)
                {
                    context.Writer.WritePropertyName(publicRequestPromptVariablesKvp.Key);
                    var publicRequestPromptVariablesValue = publicRequestPromptVariablesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = PromptVariableValuesMarshaller.Instance;
                    marshaller.Marshall(publicRequestPromptVariablesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRequestMetadata())
            {
                context.Writer.WritePropertyName("requestMetadata");
                context.Writer.WriteStartObject();
                foreach (var publicRequestRequestMetadataKvp in publicRequest.RequestMetadata)
                {
                    context.Writer.WritePropertyName(publicRequestRequestMetadataKvp.Key);
                    var publicRequestRequestMetadataValue = publicRequestRequestMetadataKvp.Value;

                        context.Writer.WriteStringValue(publicRequestRequestMetadataValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSystem())
            {
                context.Writer.WritePropertyName("system");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSystemListValue in publicRequest.System)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SystemContentBlockMarshaller.Instance;
                    marshaller.Marshall(publicRequestSystemListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetToolConfig())
            {
                context.Writer.WritePropertyName("toolConfig");
                context.Writer.WriteStartObject();

                var marshaller = ToolConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ToolConfig, context);

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
        private static ConverseStreamRequestMarshaller _instance = new ConverseStreamRequestMarshaller();        

        internal static ConverseStreamRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConverseStreamRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}