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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
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
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAIGuardrail Request Marshaller
    /// </summary>       
    public class CreateAIGuardrailRequestMarshaller : IMarshaller<IRequest, CreateAIGuardrailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAIGuardrailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAIGuardrailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAssistantId())
                throw new AmazonQConnectException("Request object does not have required field AssistantId set");
            request.AddPathResource("{assistantId}", StringUtils.FromString(publicRequest.AssistantId));
            request.ResourcePath = "/assistants/{assistantId}/aiguardrails";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
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
            if(publicRequest.IsSetContentPolicyConfig())
            {
                context.Writer.WritePropertyName("contentPolicyConfig");
                context.Writer.WriteStartObject();

                var marshaller = AIGuardrailContentPolicyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ContentPolicyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetContextualGroundingPolicyConfig())
            {
                context.Writer.WritePropertyName("contextualGroundingPolicyConfig");
                context.Writer.WriteStartObject();

                var marshaller = AIGuardrailContextualGroundingPolicyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ContextualGroundingPolicyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
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

                var marshaller = AIGuardrailSensitiveInformationPolicyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.SensitiveInformationPolicyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTopicPolicyConfig())
            {
                context.Writer.WritePropertyName("topicPolicyConfig");
                context.Writer.WriteStartObject();

                var marshaller = AIGuardrailTopicPolicyConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.TopicPolicyConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVisibilityStatus())
            {
                context.Writer.WritePropertyName("visibilityStatus");
                context.Writer.WriteStringValue(publicRequest.VisibilityStatus);
            }

            if(publicRequest.IsSetWordPolicyConfig())
            {
                context.Writer.WritePropertyName("wordPolicyConfig");
                context.Writer.WriteStartObject();

                var marshaller = AIGuardrailWordPolicyConfigMarshaller.Instance;
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
        private static CreateAIGuardrailRequestMarshaller _instance = new CreateAIGuardrailRequestMarshaller();        

        internal static CreateAIGuardrailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAIGuardrailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}