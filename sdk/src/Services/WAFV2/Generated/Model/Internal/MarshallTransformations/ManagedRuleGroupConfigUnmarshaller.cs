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
    /// Response Unmarshaller for ManagedRuleGroupConfig Object
    /// </summary>  
    public class ManagedRuleGroupConfigUnmarshaller : IJsonUnmarshaller<ManagedRuleGroupConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ManagedRuleGroupConfig Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ManagedRuleGroupConfig unmarshalledObject = new ManagedRuleGroupConfig();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AWSManagedRulesACFPRuleSet", targetDepth))
                {
                    var unmarshaller = AWSManagedRulesACFPRuleSetUnmarshaller.Instance;
                    unmarshalledObject.AWSManagedRulesACFPRuleSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AWSManagedRulesAntiDDoSRuleSet", targetDepth))
                {
                    var unmarshaller = AWSManagedRulesAntiDDoSRuleSetUnmarshaller.Instance;
                    unmarshalledObject.AWSManagedRulesAntiDDoSRuleSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AWSManagedRulesATPRuleSet", targetDepth))
                {
                    var unmarshaller = AWSManagedRulesATPRuleSetUnmarshaller.Instance;
                    unmarshalledObject.AWSManagedRulesATPRuleSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AWSManagedRulesBotControlRuleSet", targetDepth))
                {
                    var unmarshaller = AWSManagedRulesBotControlRuleSetUnmarshaller.Instance;
                    unmarshalledObject.AWSManagedRulesBotControlRuleSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LoginPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LoginPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PasswordField", targetDepth))
                {
                    var unmarshaller = PasswordFieldUnmarshaller.Instance;
                    unmarshalledObject.PasswordField = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PayloadType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PayloadType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("UsernameField", targetDepth))
                {
                    var unmarshaller = UsernameFieldUnmarshaller.Instance;
                    unmarshalledObject.UsernameField = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ManagedRuleGroupConfigUnmarshaller _instance = new ManagedRuleGroupConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ManagedRuleGroupConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}