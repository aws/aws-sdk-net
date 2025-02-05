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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FraudDetector.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.FraudDetector.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EvaluatedRule Object
    /// </summary>  
    public class EvaluatedRuleUnmarshaller : IJsonUnmarshaller<EvaluatedRule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public EvaluatedRule Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            EvaluatedRule unmarshalledObject = new EvaluatedRule();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("evaluated", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Evaluated = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("expression", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Expression = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("expressionWithValues", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExpressionWithValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("matched", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.Matched = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("outcomes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Outcomes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ruleId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuleId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ruleVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RuleVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EvaluatedRuleUnmarshaller _instance = new EvaluatedRuleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EvaluatedRuleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}