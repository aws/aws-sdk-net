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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManager.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceRuleStatement Object
    /// </summary>  
    public class InstanceRuleStatementUnmarshaller : IUnmarshaller<InstanceRuleStatement, XmlUnmarshallerContext>, IUnmarshaller<InstanceRuleStatement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InstanceRuleStatement IUnmarshaller<InstanceRuleStatement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public InstanceRuleStatement Unmarshall(JsonUnmarshallerContext context)
        {
            InstanceRuleStatement unmarshalledObject = new InstanceRuleStatement();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AndRuleStatement", targetDepth))
                {
                    var unmarshaller = AndRuleStatementUnmarshaller.Instance;
                    unmarshalledObject.AndRuleStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MatchingRuleStatement", targetDepth))
                {
                    var unmarshaller = MatchingRuleStatementUnmarshaller.Instance;
                    unmarshalledObject.MatchingRuleStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OrRuleStatement", targetDepth))
                {
                    var unmarshaller = OrRuleStatementUnmarshaller.Instance;
                    unmarshalledObject.OrRuleStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScriptRuleStatement", targetDepth))
                {
                    var unmarshaller = ScriptRuleStatementUnmarshaller.Instance;
                    unmarshalledObject.ScriptRuleStatement = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InstanceRuleStatementUnmarshaller _instance = new InstanceRuleStatementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceRuleStatementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}