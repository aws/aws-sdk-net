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
    /// Response Unmarshaller for RuleGroupReferenceStatement Object
    /// </summary>  
    public class RuleGroupReferenceStatementUnmarshaller : IUnmarshaller<RuleGroupReferenceStatement, XmlUnmarshallerContext>, IUnmarshaller<RuleGroupReferenceStatement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RuleGroupReferenceStatement IUnmarshaller<RuleGroupReferenceStatement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RuleGroupReferenceStatement Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RuleGroupReferenceStatement unmarshalledObject = new RuleGroupReferenceStatement();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExcludedRules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ExcludedRule, ExcludedRuleUnmarshaller>(ExcludedRuleUnmarshaller.Instance);
                    unmarshalledObject.ExcludedRules = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RuleActionOverrides", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RuleActionOverride, RuleActionOverrideUnmarshaller>(RuleActionOverrideUnmarshaller.Instance);
                    unmarshalledObject.RuleActionOverrides = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static RuleGroupReferenceStatementUnmarshaller _instance = new RuleGroupReferenceStatementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RuleGroupReferenceStatementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}