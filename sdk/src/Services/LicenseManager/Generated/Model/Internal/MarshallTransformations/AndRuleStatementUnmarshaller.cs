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
    /// Response Unmarshaller for AndRuleStatement Object
    /// </summary>  
    public class AndRuleStatementUnmarshaller : IUnmarshaller<AndRuleStatement, XmlUnmarshallerContext>, IUnmarshaller<AndRuleStatement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AndRuleStatement IUnmarshaller<AndRuleStatement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AndRuleStatement Unmarshall(JsonUnmarshallerContext context)
        {
            AndRuleStatement unmarshalledObject = new AndRuleStatement();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("MatchingRuleStatements", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MatchingRuleStatement, MatchingRuleStatementUnmarshaller>(MatchingRuleStatementUnmarshaller.Instance);
                    unmarshalledObject.MatchingRuleStatements = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScriptRuleStatements", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ScriptRuleStatement, ScriptRuleStatementUnmarshaller>(ScriptRuleStatementUnmarshaller.Instance);
                    unmarshalledObject.ScriptRuleStatements = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AndRuleStatementUnmarshaller _instance = new AndRuleStatementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AndRuleStatementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}