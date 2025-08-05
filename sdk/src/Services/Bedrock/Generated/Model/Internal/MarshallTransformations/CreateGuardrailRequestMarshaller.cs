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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateGuardrail Request Marshaller
    /// </summary>       
    public class CreateGuardrailRequestMarshaller : IMarshaller<IRequest, CreateGuardrailRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateGuardrailRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateGuardrailRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "POST";

            request.ResourcePath = "/guardrails";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAutomatedReasoningPolicyConfig())
                {
                    context.Writer.WritePropertyName("automatedReasoningPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = GuardrailAutomatedReasoningPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AutomatedReasoningPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

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

                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("clientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetContentPolicyConfig())
                {
                    context.Writer.WritePropertyName("contentPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = GuardrailContentPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContentPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetContextualGroundingPolicyConfig())
                {
                    context.Writer.WritePropertyName("contextualGroundingPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = GuardrailContextualGroundingPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ContextualGroundingPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCrossRegionConfig())
                {
                    context.Writer.WritePropertyName("crossRegionConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = GuardrailCrossRegionConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CrossRegionConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("kmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetSensitiveInformationPolicyConfig())
                {
                    context.Writer.WritePropertyName("sensitiveInformationPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = GuardrailSensitiveInformationPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SensitiveInformationPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTopicPolicyConfig())
                {
                    context.Writer.WritePropertyName("topicPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = GuardrailTopicPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TopicPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetWordPolicyConfig())
                {
                    context.Writer.WritePropertyName("wordPolicyConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = GuardrailWordPolicyConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.WordPolicyConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateGuardrailRequestMarshaller _instance = new CreateGuardrailRequestMarshaller();        

        internal static CreateGuardrailRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateGuardrailRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}