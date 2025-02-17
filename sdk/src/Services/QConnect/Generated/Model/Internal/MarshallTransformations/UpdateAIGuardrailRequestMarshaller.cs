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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAIGuardrail Request Marshaller
    /// </summary>       
    public class UpdateAIGuardrailRequestMarshaller : IMarshaller<IRequest, UpdateAIGuardrailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAIGuardrailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAIGuardrailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QConnect");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAiGuardrailId())
                throw new AmazonQConnectException("Request object does not have required field AiGuardrailId set");
            request.AddPathResource("{aiGuardrailId}", StringUtils.FromString(publicRequest.AiGuardrailId));
            if (!publicRequest.IsSetAssistantId())
                throw new AmazonQConnectException("Request object does not have required field AssistantId set");
            request.AddPathResource("{assistantId}", StringUtils.FromString(publicRequest.AssistantId));
            request.ResourcePath = "/assistants/{assistantId}/aiguardrails/{aiGuardrailId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBlockedInputMessaging())
                {
                    context.Writer.WritePropertyName("blockedInputMessaging");
                    context.Writer.Write(publicRequest.BlockedInputMessaging);
                }

                if(publicRequest.IsSetBlockedOutputsMessaging())
                {
                    context.Writer.WritePropertyName("blockedOutputsMessaging");
                    context.Writer.Write(publicRequest.BlockedOutputsMessaging);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetContentPolicyConfig())
                {
                    context.Writer.WritePropertyName("contentPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AIGuardrailContentPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContentPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetContextualGroundingPolicyConfig())
                {
                    context.Writer.WritePropertyName("contextualGroundingPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AIGuardrailContextualGroundingPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContextualGroundingPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetSensitiveInformationPolicyConfig())
                {
                    context.Writer.WritePropertyName("sensitiveInformationPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AIGuardrailSensitiveInformationPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SensitiveInformationPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTopicPolicyConfig())
                {
                    context.Writer.WritePropertyName("topicPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AIGuardrailTopicPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TopicPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVisibilityStatus())
                {
                    context.Writer.WritePropertyName("visibilityStatus");
                    context.Writer.Write(publicRequest.VisibilityStatus);
                }

                if(publicRequest.IsSetWordPolicyConfig())
                {
                    context.Writer.WritePropertyName("wordPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AIGuardrailWordPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.WordPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateAIGuardrailRequestMarshaller _instance = new UpdateAIGuardrailRequestMarshaller();        

        internal static UpdateAIGuardrailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAIGuardrailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}