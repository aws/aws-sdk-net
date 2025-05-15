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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KnowledgeBaseFlowNodeConfiguration Marshaller
    /// </summary>
    public class KnowledgeBaseFlowNodeConfigurationMarshaller : IRequestMarshaller<KnowledgeBaseFlowNodeConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(KnowledgeBaseFlowNodeConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGuardrailConfiguration())
            {
                context.Writer.WritePropertyName("guardrailConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = GuardrailConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GuardrailConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetInferenceConfiguration())
            {
                context.Writer.WritePropertyName("inferenceConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = PromptInferenceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.InferenceConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetKnowledgeBaseId())
            {
                context.Writer.WritePropertyName("knowledgeBaseId");
                context.Writer.Write(requestObject.KnowledgeBaseId);
            }

            if(requestObject.IsSetModelId())
            {
                context.Writer.WritePropertyName("modelId");
                context.Writer.Write(requestObject.ModelId);
            }

            if(requestObject.IsSetNumberOfResults())
            {
                context.Writer.WritePropertyName("numberOfResults");
                context.Writer.Write(requestObject.NumberOfResults);
            }

            if(requestObject.IsSetOrchestrationConfiguration())
            {
                context.Writer.WritePropertyName("orchestrationConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = KnowledgeBaseOrchestrationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.OrchestrationConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPromptTemplate())
            {
                context.Writer.WritePropertyName("promptTemplate");
                context.Writer.WriteObjectStart();

                var marshaller = KnowledgeBasePromptTemplateMarshaller.Instance;
                marshaller.Marshall(requestObject.PromptTemplate, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRerankingConfiguration())
            {
                context.Writer.WritePropertyName("rerankingConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = VectorSearchRerankingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.RerankingConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static KnowledgeBaseFlowNodeConfigurationMarshaller Instance = new KnowledgeBaseFlowNodeConfigurationMarshaller();

    }
}