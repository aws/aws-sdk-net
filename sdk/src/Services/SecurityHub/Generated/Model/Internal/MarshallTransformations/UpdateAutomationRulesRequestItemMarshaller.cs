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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetActions())
            {
                context.Writer.WritePropertyName("Actions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectActionsListValue in requestObject.Actions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AutomationRulesActionMarshaller.Instance;
                    marshaller.Marshall(requestObjectActionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCriteria())
            {
                context.Writer.WritePropertyName("Criteria");
                context.Writer.WriteObjectStart();

                var marshaller = AutomationRulesFindingFiltersMarshaller.Instance;
                marshaller.Marshall(requestObject.Criteria, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetIsTerminal())
            {
                context.Writer.WritePropertyName("IsTerminal");
                context.Writer.Write(requestObject.IsTerminal);
            }

            if(requestObject.IsSetRuleArn())
            {
                context.Writer.WritePropertyName("RuleArn");
                context.Writer.Write(requestObject.RuleArn);
            }

            if(requestObject.IsSetRuleName())
            {
                context.Writer.WritePropertyName("RuleName");
                context.Writer.Write(requestObject.RuleName);
            }

            if(requestObject.IsSetRuleOrder())
            {
                context.Writer.WritePropertyName("RuleOrder");
                context.Writer.Write(requestObject.RuleOrder);
            }

            if(requestObject.IsSetRuleStatus())
            {
                context.Writer.WritePropertyName("RuleStatus");
                context.Writer.Write(requestObject.RuleStatus);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateAutomationRulesRequestItemMarshaller Instance = new UpdateAutomationRulesRequestItemMarshaller();

    }
}