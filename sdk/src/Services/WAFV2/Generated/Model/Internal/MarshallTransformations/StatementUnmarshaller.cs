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
using ThirdParty.Json.LitJson;

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Statement Object
    /// </summary>  
    public class StatementUnmarshaller : IUnmarshaller<Statement, XmlUnmarshallerContext>, IUnmarshaller<Statement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Statement IUnmarshaller<Statement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Statement Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Statement unmarshalledObject = new Statement();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AndStatement", targetDepth))
                {
                    var unmarshaller = AndStatementUnmarshaller.Instance;
                    unmarshalledObject.AndStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ByteMatchStatement", targetDepth))
                {
                    var unmarshaller = ByteMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.ByteMatchStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("GeoMatchStatement", targetDepth))
                {
                    var unmarshaller = GeoMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.GeoMatchStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IPSetReferenceStatement", targetDepth))
                {
                    var unmarshaller = IPSetReferenceStatementUnmarshaller.Instance;
                    unmarshalledObject.IPSetReferenceStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManagedRuleGroupStatement", targetDepth))
                {
                    var unmarshaller = ManagedRuleGroupStatementUnmarshaller.Instance;
                    unmarshalledObject.ManagedRuleGroupStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NotStatement", targetDepth))
                {
                    var unmarshaller = NotStatementUnmarshaller.Instance;
                    unmarshalledObject.NotStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrStatement", targetDepth))
                {
                    var unmarshaller = OrStatementUnmarshaller.Instance;
                    unmarshalledObject.OrStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RateBasedStatement", targetDepth))
                {
                    var unmarshaller = RateBasedStatementUnmarshaller.Instance;
                    unmarshalledObject.RateBasedStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RegexPatternSetReferenceStatement", targetDepth))
                {
                    var unmarshaller = RegexPatternSetReferenceStatementUnmarshaller.Instance;
                    unmarshalledObject.RegexPatternSetReferenceStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RuleGroupReferenceStatement", targetDepth))
                {
                    var unmarshaller = RuleGroupReferenceStatementUnmarshaller.Instance;
                    unmarshalledObject.RuleGroupReferenceStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SizeConstraintStatement", targetDepth))
                {
                    var unmarshaller = SizeConstraintStatementUnmarshaller.Instance;
                    unmarshalledObject.SizeConstraintStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SqliMatchStatement", targetDepth))
                {
                    var unmarshaller = SqliMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.SqliMatchStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XssMatchStatement", targetDepth))
                {
                    var unmarshaller = XssMatchStatementUnmarshaller.Instance;
                    unmarshalledObject.XssMatchStatement = unmarshaller.Unmarshall(context);
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