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
    /// Response Unmarshaller for ManagedRuleGroupStatement Object
    /// </summary>  
    public class ManagedRuleGroupStatementUnmarshaller : IJsonUnmarshaller<ManagedRuleGroupStatement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ManagedRuleGroupStatement Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ManagedRuleGroupStatement unmarshalledObject = new ManagedRuleGroupStatement();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ExcludedRules", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ExcludedRule, ExcludedRuleUnmarshaller>(ExcludedRuleUnmarshaller.Instance);
                    unmarshalledObject.ExcludedRules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ManagedRuleGroupConfigs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ManagedRuleGroupConfig, ManagedRuleGroupConfigUnmarshaller>(ManagedRuleGroupConfigUnmarshaller.Instance);
                    unmarshalledObject.ManagedRuleGroupConfigs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RuleActionOverrides", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<RuleActionOverride, RuleActionOverrideUnmarshaller>(RuleActionOverrideUnmarshaller.Instance);
                    unmarshalledObject.RuleActionOverrides = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ScopeDownStatement", targetDepth))
                {
                    var unmarshaller = StatementUnmarshaller.Instance;
                    unmarshalledObject.ScopeDownStatement = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VendorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VendorName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Version", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Version = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ManagedRuleGroupStatementUnmarshaller _instance = new ManagedRuleGroupStatementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ManagedRuleGroupStatementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}