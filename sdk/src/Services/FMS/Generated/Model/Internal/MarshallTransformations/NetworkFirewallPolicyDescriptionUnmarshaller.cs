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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkFirewallPolicyDescription Object
    /// </summary>  
    public class NetworkFirewallPolicyDescriptionUnmarshaller : IUnmarshaller<NetworkFirewallPolicyDescription, XmlUnmarshallerContext>, IUnmarshaller<NetworkFirewallPolicyDescription, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetworkFirewallPolicyDescription IUnmarshaller<NetworkFirewallPolicyDescription, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public NetworkFirewallPolicyDescription Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            NetworkFirewallPolicyDescription unmarshalledObject = new NetworkFirewallPolicyDescription();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("StatefulRuleGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StatefulRuleGroup, StatefulRuleGroupUnmarshaller>(StatefulRuleGroupUnmarshaller.Instance);
                    unmarshalledObject.StatefulRuleGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatelessCustomActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
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
                if (context.TestExpression("StatelessRuleGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StatelessRuleGroup, StatelessRuleGroupUnmarshaller>(StatelessRuleGroupUnmarshaller.Instance);
                    unmarshalledObject.StatelessRuleGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static NetworkFirewallPolicyDescriptionUnmarshaller _instance = new NetworkFirewallPolicyDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkFirewallPolicyDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}