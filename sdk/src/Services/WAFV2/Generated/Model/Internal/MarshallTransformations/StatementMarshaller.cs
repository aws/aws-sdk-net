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
    /// Statement Marshaller
    /// </summary>
    public class StatementMarshaller : IRequestMarshaller<Statement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Statement requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAndStatement())
            {
                context.Writer.WritePropertyName("AndStatement");
                context.Writer.WriteStartObject();

                var marshaller = AndStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.AndStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAsnMatchStatement())
            {
                context.Writer.WritePropertyName("AsnMatchStatement");
                context.Writer.WriteStartObject();

                var marshaller = AsnMatchStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.AsnMatchStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetByteMatchStatement())
            {
                context.Writer.WritePropertyName("ByteMatchStatement");
                context.Writer.WriteStartObject();

                var marshaller = ByteMatchStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.ByteMatchStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGeoMatchStatement())
            {
                context.Writer.WritePropertyName("GeoMatchStatement");
                context.Writer.WriteStartObject();

                var marshaller = GeoMatchStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.GeoMatchStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetIPSetReferenceStatement())
            {
                context.Writer.WritePropertyName("IPSetReferenceStatement");
                context.Writer.WriteStartObject();

                var marshaller = IPSetReferenceStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.IPSetReferenceStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLabelMatchStatement())
            {
                context.Writer.WritePropertyName("LabelMatchStatement");
                context.Writer.WriteStartObject();

                var marshaller = LabelMatchStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.LabelMatchStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetManagedRuleGroupStatement())
            {
                context.Writer.WritePropertyName("ManagedRuleGroupStatement");
                context.Writer.WriteStartObject();

                var marshaller = ManagedRuleGroupStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.ManagedRuleGroupStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNotStatement())
            {
                context.Writer.WritePropertyName("NotStatement");
                context.Writer.WriteStartObject();

                var marshaller = NotStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.NotStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOrStatement())
            {
                context.Writer.WritePropertyName("OrStatement");
                context.Writer.WriteStartObject();

                var marshaller = OrStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.OrStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRateBasedStatement())
            {
                context.Writer.WritePropertyName("RateBasedStatement");
                context.Writer.WriteStartObject();

                var marshaller = RateBasedStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.RateBasedStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRegexMatchStatement())
            {
                context.Writer.WritePropertyName("RegexMatchStatement");
                context.Writer.WriteStartObject();

                var marshaller = RegexMatchStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.RegexMatchStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRegexPatternSetReferenceStatement())
            {
                context.Writer.WritePropertyName("RegexPatternSetReferenceStatement");
                context.Writer.WriteStartObject();

                var marshaller = RegexPatternSetReferenceStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.RegexPatternSetReferenceStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRuleGroupReferenceStatement())
            {
                context.Writer.WritePropertyName("RuleGroupReferenceStatement");
                context.Writer.WriteStartObject();

                var marshaller = RuleGroupReferenceStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.RuleGroupReferenceStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSizeConstraintStatement())
            {
                context.Writer.WritePropertyName("SizeConstraintStatement");
                context.Writer.WriteStartObject();

                var marshaller = SizeConstraintStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.SizeConstraintStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSqliMatchStatement())
            {
                context.Writer.WritePropertyName("SqliMatchStatement");
                context.Writer.WriteStartObject();

                var marshaller = SqliMatchStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.SqliMatchStatement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetXssMatchStatement())
            {
                context.Writer.WritePropertyName("XssMatchStatement");
                context.Writer.WriteStartObject();

                var marshaller = XssMatchStatementMarshaller.Instance;
                marshaller.Marshall(requestObject.XssMatchStatement, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StatementMarshaller Instance = new StatementMarshaller();

    }
}