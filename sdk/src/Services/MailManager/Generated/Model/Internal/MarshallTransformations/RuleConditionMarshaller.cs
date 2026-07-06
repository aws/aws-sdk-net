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
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RuleCondition Marshaller
    /// </summary>
    public class RuleConditionMarshaller : IRequestMarshaller<RuleCondition, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RuleCondition requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetBooleanExpression())
            {
                context.Writer.WriteTextString("BooleanExpression");
                context.Writer.WriteStartMap(null);

                var marshaller = RuleBooleanExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.BooleanExpression, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetDmarcExpression())
            {
                context.Writer.WriteTextString("DmarcExpression");
                context.Writer.WriteStartMap(null);

                var marshaller = RuleDmarcExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.DmarcExpression, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetIpExpression())
            {
                context.Writer.WriteTextString("IpExpression");
                context.Writer.WriteStartMap(null);

                var marshaller = RuleIpExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.IpExpression, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetNumberExpression())
            {
                context.Writer.WriteTextString("NumberExpression");
                context.Writer.WriteStartMap(null);

                var marshaller = RuleNumberExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.NumberExpression, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetStringExpression())
            {
                context.Writer.WriteTextString("StringExpression");
                context.Writer.WriteStartMap(null);

                var marshaller = RuleStringExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.StringExpression, context);

                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetVerdictExpression())
            {
                context.Writer.WriteTextString("VerdictExpression");
                context.Writer.WriteStartMap(null);

                var marshaller = RuleVerdictExpressionMarshaller.Instance;
                marshaller.Marshall(requestObject.VerdictExpression, context);

                context.Writer.WriteEndMap();
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleConditionMarshaller Instance = new RuleConditionMarshaller();

    }
}