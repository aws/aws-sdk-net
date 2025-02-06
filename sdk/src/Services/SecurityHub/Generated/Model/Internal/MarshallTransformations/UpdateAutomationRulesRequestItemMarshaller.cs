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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAutomationRulesRequestItem Marshaller
    /// </summary>
    public class UpdateAutomationRulesRequestItemMarshaller : IRequestMarshaller<UpdateAutomationRulesRequestItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateAutomationRulesRequestItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("Actions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AutomationRulesActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCriteria())
            {
                context.Writer.WritePropertyName("Criteria");
                context.Writer.WriteStartObject();

                var marshaller = AutomationRulesFindingFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.Criteria, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetIsTerminal())
            {
                context.Writer.WritePropertyName("IsTerminal");
                context.Writer.WriteBooleanValue(requestObject.IsTerminal.Value);
            }

            if(requestObject.IsSetRuleArn())
            {
                context.Writer.WritePropertyName("RuleArn");
                context.Writer.WriteStringValue(requestObject.RuleArn);
            }

            if(requestObject.IsSetRuleName())
            {
                context.Writer.WritePropertyName("RuleName");
                context.Writer.WriteStringValue(requestObject.RuleName);
            }

            if(requestObject.IsSetRuleOrder())
            {
                context.Writer.WritePropertyName("RuleOrder");
                context.Writer.WriteNumberValue(requestObject.RuleOrder.Value);
            }

            if(requestObject.IsSetRuleStatus())
            {
                context.Writer.WritePropertyName("RuleStatus");
                context.Writer.WriteStringValue(requestObject.RuleStatus);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateAutomationRulesRequestItemMarshaller Instance = new UpdateAutomationRulesRequestItemMarshaller();

    }
}