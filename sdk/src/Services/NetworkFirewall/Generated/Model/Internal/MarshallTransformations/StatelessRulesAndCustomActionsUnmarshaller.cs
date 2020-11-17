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
    /// Response Unmarshaller for StatelessRulesAndCustomActions Object
    /// </summary>  
    public class StatelessRulesAndCustomActionsUnmarshaller : IUnmarshaller<StatelessRulesAndCustomActions, XmlUnmarshallerContext>, IUnmarshaller<StatelessRulesAndCustomActions, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        StatelessRulesAndCustomActions IUnmarshaller<StatelessRulesAndCustomActions, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StatelessRulesAndCustomActions Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            StatelessRulesAndCustomActions unmarshalledObject = new StatelessRulesAndCustomActions();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CustomActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CustomAction, CustomActionUnmarshaller>(CustomActionUnmarshaller.Instance);
                    unmarshalledObject.CustomActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatelessRules", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<StatelessRule, StatelessRuleUnmarshaller>(StatelessRuleUnmarshaller.Instance);
                    unmarshalledObject.StatelessRules = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static StatelessRulesAndCustomActionsUnmarshaller _instance = new StatelessRulesAndCustomActionsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StatelessRulesAndCustomActionsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}