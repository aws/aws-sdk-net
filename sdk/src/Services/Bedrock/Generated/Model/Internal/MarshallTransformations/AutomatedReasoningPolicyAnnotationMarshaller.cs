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
#pragma warning disable CS0612,CS0618
namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutomatedReasoningPolicyAnnotation Marshaller
    /// </summary>
    public class AutomatedReasoningPolicyAnnotationMarshaller : IRequestMarshaller<AutomatedReasoningPolicyAnnotation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutomatedReasoningPolicyAnnotation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddRule())
            {
                context.Writer.WritePropertyName("addRule");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyAddRuleAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.AddRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAddRuleFromNaturalLanguage())
            {
                context.Writer.WritePropertyName("addRuleFromNaturalLanguage");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyAddRuleFromNaturalLanguageAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.AddRuleFromNaturalLanguage, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAddType())
            {
                context.Writer.WritePropertyName("addType");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyAddTypeAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.AddType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAddVariable())
            {
                context.Writer.WritePropertyName("addVariable");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyAddVariableAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.AddVariable, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeleteRule())
            {
                context.Writer.WritePropertyName("deleteRule");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyDeleteRuleAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.DeleteRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeleteType())
            {
                context.Writer.WritePropertyName("deleteType");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyDeleteTypeAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.DeleteType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeleteVariable())
            {
                context.Writer.WritePropertyName("deleteVariable");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyDeleteVariableAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.DeleteVariable, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIngestContent())
            {
                context.Writer.WritePropertyName("ingestContent");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyIngestContentAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.IngestContent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpdateFromRulesFeedback())
            {
                context.Writer.WritePropertyName("updateFromRulesFeedback");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyUpdateFromRuleFeedbackAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateFromRulesFeedback, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpdateFromScenarioFeedback())
            {
                context.Writer.WritePropertyName("updateFromScenarioFeedback");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyUpdateFromScenarioFeedbackAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateFromScenarioFeedback, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpdateRule())
            {
                context.Writer.WritePropertyName("updateRule");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyUpdateRuleAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateRule, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpdateType())
            {
                context.Writer.WritePropertyName("updateType");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyUpdateTypeAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateType, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpdateVariable())
            {
                context.Writer.WritePropertyName("updateVariable");
                context.Writer.WriteStartObject();

                var marshaller = AutomatedReasoningPolicyUpdateVariableAnnotationMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateVariable, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutomatedReasoningPolicyAnnotationMarshaller Instance = new AutomatedReasoningPolicyAnnotationMarshaller();

    }
}