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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Converse Request Marshaller
    /// </summary>       
    public class ConverseRequestMarshaller : IMarshaller<IRequest, ConverseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ConverseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ConverseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-09-30";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetModelId())
                throw new AmazonBedrockRuntimeException("Request object does not have required field ModelId set");
            request.AddPathResource("{modelId}", StringUtils.FromString(publicRequest.ModelId));
            request.ResourcePath = "/model/{modelId}/converse";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalModelRequestFields())
                {
                    context.Writer.WritePropertyName("additionalModelRequestFields");
                    Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, publicRequest.AdditionalModelRequestFields);
                }

                if(publicRequest.IsSetAdditionalModelResponseFieldPaths())
                {
                    context.Writer.WritePropertyName("additionalModelResponseFieldPaths");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAdditionalModelResponseFieldPathsListValue in publicRequest.AdditionalModelResponseFieldPaths)
                    {
                            context.Writer.Write(publicRequestAdditionalModelResponseFieldPathsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetGuardrailConfig())
                {
                    context.Writer.WritePropertyName("guardrailConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = GuardrailConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.GuardrailConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInferenceConfig())
                {
                    context.Writer.WritePropertyName("inferenceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = InferenceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InferenceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMessages())
                {
                    context.Writer.WritePropertyName("messages");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestMessagesListValue in publicRequest.Messages)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = MessageMarshaller.Instance;
                        marshaller.Marshall(publicRequestMessagesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPerformanceConfig())
                {
                    context.Writer.WritePropertyName("performanceConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = PerformanceConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PerformanceConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPromptVariables())
                {
                    context.Writer.WritePropertyName("promptVariables");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestPromptVariablesKvp in publicRequest.PromptVariables)
                    {
                        context.Writer.WritePropertyName(publicRequestPromptVariablesKvp.Key);
                        var publicRequestPromptVariablesValue = publicRequestPromptVariablesKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = PromptVariableValuesMarshaller.Instance;
                        marshaller.Marshall(publicRequestPromptVariablesValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRequestMetadata())
                {
                    context.Writer.WritePropertyName("requestMetadata");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestRequestMetadataKvp in publicRequest.RequestMetadata)
                    {
                        context.Writer.WritePropertyName(publicRequestRequestMetadataKvp.Key);
                        var publicRequestRequestMetadataValue = publicRequestRequestMetadataKvp.Value;

                            context.Writer.Write(publicRequestRequestMetadataValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetServiceTier())
                {
                    context.Writer.WritePropertyName("serviceTier");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceTierMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ServiceTier, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSystem())
                {
                    context.Writer.WritePropertyName("system");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSystemListValue in publicRequest.System)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SystemContentBlockMarshaller.Instance;
                        marshaller.Marshall(publicRequestSystemListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetToolConfig())
                {
                    context.Writer.WritePropertyName("toolConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ToolConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ToolConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ConverseRequestMarshaller _instance = new ConverseRequestMarshaller();        

        internal static ConverseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConverseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}