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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAFV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Statement Object
    /// </summary>  
    public class StatementUnmarshaller : IJsonUnmarshaller<Statement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Statement Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Statement unmarshalledObject = new Statement();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AndStatement", targetDepth))
                {
                    var unmarshaller = AndStatementUnmarshaller.Instance;
                    unmarshalledObject.AndStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AsnMatchStatement", targetDepth))
                {
                    var unmarshaller = AsnMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.AsnMatchStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ByteMatchStatement", targetDepth))
                {
                    var unmarshaller = ByteMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.ByteMatchStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GeoMatchStatement", targetDepth))
                {
                    var unmarshaller = GeoMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.GeoMatchStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("IPSetReferenceStatement", targetDepth))
                {
                    var unmarshaller = IPSetReferenceStatementUnmarshaller.Instance;
                    unmarshalledObject.IPSetReferenceStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LabelMatchStatement", targetDepth))
                {
                    var unmarshaller = LabelMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.LabelMatchStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ManagedRuleGroupStatement", targetDepth))
                {
                    var unmarshaller = ManagedRuleGroupStatementUnmarshaller.Instance;
                    unmarshalledObject.ManagedRuleGroupStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NotStatement", targetDepth))
                {
                    var unmarshaller = NotStatementUnmarshaller.Instance;
                    unmarshalledObject.NotStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OrStatement", targetDepth))
                {
                    var unmarshaller = OrStatementUnmarshaller.Instance;
                    unmarshalledObject.OrStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RateBasedStatement", targetDepth))
                {
                    var unmarshaller = RateBasedStatementUnmarshaller.Instance;
                    unmarshalledObject.RateBasedStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RegexMatchStatement", targetDepth))
                {
                    var unmarshaller = RegexMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.RegexMatchStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RegexPatternSetReferenceStatement", targetDepth))
                {
                    var unmarshaller = RegexPatternSetReferenceStatementUnmarshaller.Instance;
                    unmarshalledObject.RegexPatternSetReferenceStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RuleGroupReferenceStatement", targetDepth))
                {
                    var unmarshaller = RuleGroupReferenceStatementUnmarshaller.Instance;
                    unmarshalledObject.RuleGroupReferenceStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SizeConstraintStatement", targetDepth))
                {
                    var unmarshaller = SizeConstraintStatementUnmarshaller.Instance;
                    unmarshalledObject.SizeConstraintStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SqliMatchStatement", targetDepth))
                {
                    var unmarshaller = SqliMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.SqliMatchStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("XssMatchStatement", targetDepth))
                {
                    var unmarshaller = XssMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.XssMatchStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StatementUnmarshaller _instance = new StatementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StatementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}