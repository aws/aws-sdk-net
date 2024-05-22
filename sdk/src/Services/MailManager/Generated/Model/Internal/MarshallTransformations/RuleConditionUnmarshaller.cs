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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MailManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MailManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuleCondition Object
    /// </summary>  
    public class RuleConditionUnmarshaller : IUnmarshaller<RuleCondition, XmlUnmarshallerContext>, IUnmarshaller<RuleCondition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RuleCondition IUnmarshaller<RuleCondition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RuleCondition Unmarshall(JsonUnmarshallerContext context)
        {
            RuleCondition unmarshalledObject = new RuleCondition();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BooleanExpression", targetDepth))
                {
                    var unmarshaller = RuleBooleanExpressionUnmarshaller.Instance;
                    unmarshalledObject.BooleanExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DmarcExpression", targetDepth))
                {
                    var unmarshaller = RuleDmarcExpressionUnmarshaller.Instance;
                    unmarshalledObject.DmarcExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpExpression", targetDepth))
                {
                    var unmarshaller = RuleIpExpressionUnmarshaller.Instance;
                    unmarshalledObject.IpExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberExpression", targetDepth))
                {
                    var unmarshaller = RuleNumberExpressionUnmarshaller.Instance;
                    unmarshalledObject.NumberExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StringExpression", targetDepth))
                {
                    var unmarshaller = RuleStringExpressionUnmarshaller.Instance;
                    unmarshalledObject.StringExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VerdictExpression", targetDepth))
                {
                    var unmarshaller = RuleVerdictExpressionUnmarshaller.Instance;
                    unmarshalledObject.VerdictExpression = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RuleConditionUnmarshaller _instance = new RuleConditionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RuleConditionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}