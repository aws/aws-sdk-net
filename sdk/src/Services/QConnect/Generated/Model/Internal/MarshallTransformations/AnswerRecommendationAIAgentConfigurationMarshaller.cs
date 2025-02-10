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
#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AnswerRecommendationAIAgentConfiguration Marshaller
    /// </summary>
    public class AnswerRecommendationAIAgentConfigurationMarshaller : IRequestMarshaller<AnswerRecommendationAIAgentConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AnswerRecommendationAIAgentConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnswerGenerationAIGuardrailId())
            {
                context.Writer.WritePropertyName("answerGenerationAIGuardrailId");
                context.Writer.WriteStringValue(requestObject.AnswerGenerationAIGuardrailId);
            }

            if(requestObject.IsSetAnswerGenerationAIPromptId())
            {
                context.Writer.WritePropertyName("answerGenerationAIPromptId");
                context.Writer.WriteStringValue(requestObject.AnswerGenerationAIPromptId);
            }

            if(requestObject.IsSetAssociationConfigurations())
            {
                context.Writer.WritePropertyName("associationConfigurations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAssociationConfigurationsListValue in requestObject.AssociationConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AssociationConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectAssociationConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetIntentLabelingGenerationAIPromptId())
            {
                context.Writer.WritePropertyName("intentLabelingGenerationAIPromptId");
                context.Writer.WriteStringValue(requestObject.IntentLabelingGenerationAIPromptId);
            }

            if(requestObject.IsSetLocale())
            {
                context.Writer.WritePropertyName("locale");
                context.Writer.WriteStringValue(requestObject.Locale);
            }

            if(requestObject.IsSetQueryReformulationAIPromptId())
            {
                context.Writer.WritePropertyName("queryReformulationAIPromptId");
                context.Writer.WriteStringValue(requestObject.QueryReformulationAIPromptId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AnswerRecommendationAIAgentConfigurationMarshaller Instance = new AnswerRecommendationAIAgentConfigurationMarshaller();

    }
}