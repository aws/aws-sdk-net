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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
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
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateGuardrail Request Marshaller
    /// </summary>       
    public class UpdateGuardrailRequestMarshaller : IMarshaller<IRequest, UpdateGuardrailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGuardrailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateGuardrailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetGuardrailIdentifier())
                throw new AmazonBedrockException("Request object does not have required field GuardrailIdentifier set");
            request.AddPathResource("{guardrailIdentifier}", StringUtils.FromString(publicRequest.GuardrailIdentifier));
            request.ResourcePath = "/guardrails/{guardrailIdentifier}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAutomatedReasoningPolicyConfig())
            {
                context.Writer.WritePropertyName("automatedReasoningPolicyConfig");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailAutomatedReasoningPolicyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.AutomatedReasoningPolicyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetBlockedInputMessaging())
            {
                context.Writer.WritePropertyName("blockedInputMessaging");
                context.Writer.WriteStringValue(publicRequest.BlockedInputMessaging);
            }

            if(publicRequest.IsSetBlockedOutputsMessaging())
            {
                context.Writer.WritePropertyName("blockedOutputsMessaging");
                context.Writer.WriteStringValue(publicRequest.BlockedOutputsMessaging);
            }

            if(publicRequest.IsSetContentPolicyConfig())
            {
                context.Writer.WritePropertyName("contentPolicyConfig");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailContentPolicyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ContentPolicyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetContextualGroundingPolicyConfig())
            {
                context.Writer.WritePropertyName("contextualGroundingPolicyConfig");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailContextualGroundingPolicyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ContextualGroundingPolicyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCrossRegionConfig())
            {
                context.Writer.WritePropertyName("crossRegionConfig");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailCrossRegionConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CrossRegionConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("kmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetSensitiveInformationPolicyConfig())
            {
                context.Writer.WritePropertyName("sensitiveInformationPolicyConfig");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailSensitiveInformationPolicyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SensitiveInformationPolicyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTopicPolicyConfig())
            {
                context.Writer.WritePropertyName("topicPolicyConfig");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailTopicPolicyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.TopicPolicyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWordPolicyConfig())
            {
                context.Writer.WritePropertyName("wordPolicyConfig");
                context.Writer.WriteStartObject();

                var marshaller = GuardrailWordPolicyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.WordPolicyConfig, context);

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
        private static UpdateGuardrailRequestMarshaller _instance = new UpdateGuardrailRequestMarshaller();        

        internal static UpdateGuardrailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateGuardrailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}