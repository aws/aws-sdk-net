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
    /// Response Unmarshaller for WebACL Object
    /// </summary>  
    public class WebACLUnmarshaller : IUnmarshaller<WebACL, XmlUnmarshallerContext>, IUnmarshaller<WebACL, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        WebACL IUnmarshaller<WebACL, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public WebACL Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            WebACL unmarshalledObject = new WebACL();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Capacity", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Capacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CaptchaConfig", targetDepth))
                {
                    var unmarshaller = CaptchaConfigUnmarshaller.Instance;
                    unmarshalledObject.CaptchaConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ChallengeConfig", targetDepth))
                {
                    var unmarshaller = ChallengeConfigUnmarshaller.Instance;
                    unmarshalledObject.ChallengeConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomResponseBodies", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, CustomResponseBody, StringUnmarshaller, CustomResponseBodyUnmarshaller>(StringUnmarshaller.Instance, CustomResponseBodyUnmarshaller.Instance);
                    unmarshalledObject.CustomResponseBodies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DefaultAction", targetDepth))
                {
                    var unmarshaller = DefaultActionUnmarshaller.Instance;
                    unmarshalledObject.DefaultAction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LabelNamespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LabelNamespace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManagedByFirewallManager", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ManagedByFirewallManager = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PostProcessFirewallManagerRuleGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FirewallManagerRuleGroup, FirewallManagerRuleGroupUnmarshaller>(FirewallManagerRuleGroupUnmarshaller.Instance);
                    unmarshalledObject.PostProcessFirewallManagerRuleGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PreProcessFirewallManagerRuleGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FirewallManagerRuleGroup, FirewallManagerRuleGroupUnmarshaller>(FirewallManagerRuleGroupUnmarshaller.Instance);
                    unmarshalledObject.PreProcessFirewallManagerRuleGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Rules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Rule, RuleUnmarshaller>(RuleUnmarshaller.Instance);
                    unmarshalledObject.Rules = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TokenDomains", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TokenDomains = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VisibilityConfig", targetDepth))
                {
                    var unmarshaller = VisibilityConfigUnmarshaller.Instance;
                    unmarshalledObject.VisibilityConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static WebACLUnmarshaller _instance = new WebACLUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WebACLUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}