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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
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
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateHarness Request Marshaller
    /// </summary>       
    public class UpdateHarnessRequestMarshaller : IMarshaller<IRequest, UpdateHarnessRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateHarnessRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateHarnessRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetHarnessId())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field HarnessId set");
            request.AddPathResource("{harnessId}", StringUtils.FromString(publicRequest.HarnessId));
            request.ResourcePath = "/harnesses/{harnessId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAllowedTools())
            {
                context.Writer.WritePropertyName("allowedTools");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAllowedToolsListValue in publicRequest.AllowedTools)
                {
                        context.Writer.WriteStringValue(publicRequestAllowedToolsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAuthorizerConfiguration())
            {
                context.Writer.WritePropertyName("authorizerConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = UpdatedAuthorizerConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.AuthorizerConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("environment");
                context.Writer.WriteStartObject();

                var marshaller = HarnessEnvironmentProviderRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.Environment, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnvironmentArtifact())
            {
                context.Writer.WritePropertyName("environmentArtifact");
                context.Writer.WriteStartObject();

                var marshaller = UpdatedHarnessEnvironmentArtifactMarshaller.Instance;
                marshaller.Marshall(publicRequest.EnvironmentArtifact, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnvironmentVariables())
            {
                context.Writer.WritePropertyName("environmentVariables");
                context.Writer.WriteStartObject();
                foreach (var publicRequestEnvironmentVariablesKvp in publicRequest.EnvironmentVariables)
                {
                    context.Writer.WritePropertyName(publicRequestEnvironmentVariablesKvp.Key);
                    var publicRequestEnvironmentVariablesValue = publicRequestEnvironmentVariablesKvp.Value;

                        context.Writer.WriteStringValue(publicRequestEnvironmentVariablesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetExecutionRoleArn())
            {
                context.Writer.WritePropertyName("executionRoleArn");
                context.Writer.WriteStringValue(publicRequest.ExecutionRoleArn);
            }

            if(publicRequest.IsSetMaxIterations())
            {
                context.Writer.WritePropertyName("maxIterations");
                context.Writer.WriteNumberValue(publicRequest.MaxIterations.Value);
            }

            if(publicRequest.IsSetMaxTokens())
            {
                context.Writer.WritePropertyName("maxTokens");
                context.Writer.WriteNumberValue(publicRequest.MaxTokens.Value);
            }

            if(publicRequest.IsSetMemory())
            {
                context.Writer.WritePropertyName("memory");
                context.Writer.WriteStartObject();

                var marshaller = UpdatedHarnessMemoryConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Memory, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetModel())
            {
                context.Writer.WritePropertyName("model");
                context.Writer.WriteStartObject();

                var marshaller = HarnessModelConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Model, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSkills())
            {
                context.Writer.WritePropertyName("skills");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSkillsListValue in publicRequest.Skills)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HarnessSkillMarshaller.Instance;
                    marshaller.Marshall(publicRequestSkillsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSystemPrompt())
            {
                context.Writer.WritePropertyName("systemPrompt");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSystemPromptListValue in publicRequest.SystemPrompt)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HarnessSystemContentBlockMarshaller.Instance;
                    marshaller.Marshall(publicRequestSystemPromptListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTimeoutSeconds())
            {
                context.Writer.WritePropertyName("timeoutSeconds");
                context.Writer.WriteNumberValue(publicRequest.TimeoutSeconds.Value);
            }

            if(publicRequest.IsSetTools())
            {
                context.Writer.WritePropertyName("tools");
                context.Writer.WriteStartArray();
                foreach(var publicRequestToolsListValue in publicRequest.Tools)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HarnessToolMarshaller.Instance;
                    marshaller.Marshall(publicRequestToolsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTruncation())
            {
                context.Writer.WritePropertyName("truncation");
                context.Writer.WriteStartObject();

                var marshaller = HarnessTruncationConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.Truncation, context);

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
        private static UpdateHarnessRequestMarshaller _instance = new UpdateHarnessRequestMarshaller();        

        internal static UpdateHarnessRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateHarnessRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}