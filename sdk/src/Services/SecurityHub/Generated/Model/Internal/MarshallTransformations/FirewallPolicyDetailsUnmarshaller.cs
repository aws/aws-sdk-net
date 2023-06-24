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
using System.Net;
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
    /// Response Unmarshaller for FirewallPolicyDetails Object
    /// </summary>  
    public class FirewallPolicyDetailsUnmarshaller : IUnmarshaller<FirewallPolicyDetails, XmlUnmarshallerContext>, IUnmarshaller<FirewallPolicyDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FirewallPolicyDetails IUnmarshaller<FirewallPolicyDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FirewallPolicyDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FirewallPolicyDetails unmarshalledObject = new FirewallPolicyDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("StatefulRuleGroupReferences", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FirewallPolicyStatefulRuleGroupReferencesDetails, FirewallPolicyStatefulRuleGroupReferencesDetailsUnmarshaller>(FirewallPolicyStatefulRuleGroupReferencesDetailsUnmarshaller.Instance);
                    unmarshalledObject.StatefulRuleGroupReferences = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatelessCustomActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FirewallPolicyStatelessCustomActionsDetails, FirewallPolicyStatelessCustomActionsDetailsUnmarshaller>(FirewallPolicyStatelessCustomActionsDetailsUnmarshaller.Instance);
                    unmarshalledObject.StatelessCustomActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatelessDefaultActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StatelessDefaultActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatelessFragmentDefaultActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StatelessFragmentDefaultActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatelessRuleGroupReferences", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<FirewallPolicyStatelessRuleGroupReferencesDetails, FirewallPolicyStatelessRuleGroupReferencesDetailsUnmarshaller>(FirewallPolicyStatelessRuleGroupReferencesDetailsUnmarshaller.Instance);
                    unmarshalledObject.StatelessRuleGroupReferences = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FirewallPolicyDetailsUnmarshaller _instance = new FirewallPolicyDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FirewallPolicyDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}