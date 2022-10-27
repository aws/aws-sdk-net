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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteObjectStart();

                var marshaller = RuleActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Action, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCaptchaConfig())
            {
                context.Writer.WritePropertyName("CaptchaConfig");
                context.Writer.WriteObjectStart();

                var marshaller = CaptchaConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.CaptchaConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetChallengeConfig())
            {
                context.Writer.WritePropertyName("ChallengeConfig");
                context.Writer.WriteObjectStart();

                var marshaller = ChallengeConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.ChallengeConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetOverrideAction())
            {
                context.Writer.WritePropertyName("OverrideAction");
                context.Writer.WriteObjectStart();

                var marshaller = OverrideActionMarshaller.Instance;
                marshaller.Marshall(requestObject.OverrideAction, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                context.Writer.Write(requestObject.Priority);
            }

            if(requestObject.IsSetRuleLabels())
            {
                context.Writer.WritePropertyName("RuleLabels");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectRuleLabelsListValue in requestObject.RuleLabels)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = LabelMarshaller.Instance;
                    marshaller.Marshall(requestObjectRuleLabelsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetStatement())
            {
                context.Writer.WritePropertyName("Statement");
                context.Writer.WriteObjectStart();

                var marshaller = StatementMarshaller.Instance;
                marshaller.Marshall(requestObject.Statement, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVisibilityConfig())
            {
                context.Writer.WritePropertyName("VisibilityConfig");
                context.Writer.WriteObjectStart();

                var marshaller = VisibilityConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.VisibilityConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleMarshaller Instance = new RuleMarshaller();

    }
}