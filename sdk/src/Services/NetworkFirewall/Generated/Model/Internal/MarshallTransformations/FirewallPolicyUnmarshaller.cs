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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FirewallPolicy Object
    /// </summary>  
    public class FirewallPolicyUnmarshaller : IUnmarshaller<FirewallPolicy, XmlUnmarshallerContext>, IUnmarshaller<FirewallPolicy, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FirewallPolicy IUnmarshaller<FirewallPolicy, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FirewallPolicy Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FirewallPolicy unmarshalledObject = new FirewallPolicy();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("StatefulDefaultActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StatefulDefaultActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatefulEngineOptions", targetDepth))
                {
                    var unmarshaller = StatefulEngineOptionsUnmarshaller.Instance;
                    unmarshalledObject.StatefulEngineOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatefulRuleGroupReferences", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StatefulRuleGroupReference, StatefulRuleGroupReferenceUnmarshaller>(StatefulRuleGroupReferenceUnmarshaller.Instance);
                    unmarshalledObject.StatefulRuleGroupReferences = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatelessCustomActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CustomAction, CustomActionUnmarshaller>(CustomActionUnmarshaller.Instance);
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
                    var unmarshaller = new ListUnmarshaller<StatelessRuleGroupReference, StatelessRuleGroupReferenceUnmarshaller>(StatelessRuleGroupReferenceUnmarshaller.Instance);
                    unmarshalledObject.StatelessRuleGroupReferences = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TLSInspectionConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TLSInspectionConfigurationArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FirewallPolicyUnmarshaller _instance = new FirewallPolicyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FirewallPolicyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}