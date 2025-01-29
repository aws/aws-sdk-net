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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Rule Marshaller
    /// </summary>
    public class RuleMarshaller : IRequestMarshaller<Rule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Rule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStartObject();

                var marshaller = RuleActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Action, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCaptchaConfig())
            {
                context.Writer.WritePropertyName("CaptchaConfig");
                context.Writer.WriteStartObject();

                var marshaller = CaptchaConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CaptchaConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetChallengeConfig())
            {
                context.Writer.WritePropertyName("ChallengeConfig");
                context.Writer.WriteStartObject();

                var marshaller = ChallengeConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ChallengeConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOverrideAction())
            {
                context.Writer.WritePropertyName("OverrideAction");
                context.Writer.WriteStartObject();

                var marshaller = OverrideActionMarshaller.Instance;
                marshaller.Marshall(requestObject.OverrideAction, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                context.Writer.WriteNumberValue(requestObject.Priority.Value);
            }

            if(requestObject.IsSetRuleLabels())
            {
                context.Writer.WritePropertyName("RuleLabels");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRuleLabelsListValue in requestObject.RuleLabels)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LabelMarshaller.Instance;
                    marshaller.Marshall(requestObjectRuleLabelsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetStatement())
            {
                context.Writer.WritePropertyName("Statement");
                context.Writer.WriteStartObject();

                var marshaller = StatementMarshaller.Instance;
                marshaller.Marshall(requestObject.Statement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisibilityConfig())
            {
                context.Writer.WritePropertyName("VisibilityConfig");
                context.Writer.WriteStartObject();

                var marshaller = VisibilityConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VisibilityConfig, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleMarshaller Instance = new RuleMarshaller();

    }
}