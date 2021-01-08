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
    /// AwsWafWebAclRule Marshaller
    /// </summary>       
    public class AwsWafWebAclRuleMarshaller : IRequestMarshaller<AwsWafWebAclRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsWafWebAclRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteObjectStart();

                var marshaller = WafActionMarshaller.Instance;
                marshaller.Marshall(requestObject.Action, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExcludedRules())
            {
                context.Writer.WritePropertyName("ExcludedRules");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExcludedRulesListValue in requestObject.ExcludedRules)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = WafExcludedRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectExcludedRulesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetOverrideAction())
            {
                context.Writer.WritePropertyName("OverrideAction");
                context.Writer.WriteObjectStart();

                var marshaller = WafOverrideActionMarshaller.Instance;
                marshaller.Marshall(requestObject.OverrideAction, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPriority())
            {
                context.Writer.WritePropertyName("Priority");
                context.Writer.Write(requestObject.Priority);
            }

            if(requestObject.IsSetRuleId())
            {
                context.Writer.WritePropertyName("RuleId");
                context.Writer.Write(requestObject.RuleId);
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsWafWebAclRuleMarshaller Instance = new AwsWafWebAclRuleMarshaller();

    }
}