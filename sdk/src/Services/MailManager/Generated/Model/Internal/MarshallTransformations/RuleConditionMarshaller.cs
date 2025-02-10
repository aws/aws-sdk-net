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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuleCondition Marshaller
    /// </summary>
    public class RuleConditionMarshaller : IRequestMarshaller<RuleCondition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleCondition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBooleanExpression())
            {
                context.Writer.WritePropertyName("BooleanExpression");
                context.Writer.WriteStartObject();

                var marshaller = RuleBooleanExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.BooleanExpression, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDmarcExpression())
            {
                context.Writer.WritePropertyName("DmarcExpression");
                context.Writer.WriteStartObject();

                var marshaller = RuleDmarcExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.DmarcExpression, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIpExpression())
            {
                context.Writer.WritePropertyName("IpExpression");
                context.Writer.WriteStartObject();

                var marshaller = RuleIpExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.IpExpression, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNumberExpression())
            {
                context.Writer.WritePropertyName("NumberExpression");
                context.Writer.WriteStartObject();

                var marshaller = RuleNumberExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.NumberExpression, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStringExpression())
            {
                context.Writer.WritePropertyName("StringExpression");
                context.Writer.WriteStartObject();

                var marshaller = RuleStringExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.StringExpression, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVerdictExpression())
            {
                context.Writer.WritePropertyName("VerdictExpression");
                context.Writer.WriteStartObject();

                var marshaller = RuleVerdictExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.VerdictExpression, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleConditionMarshaller Instance = new RuleConditionMarshaller();

    }
}