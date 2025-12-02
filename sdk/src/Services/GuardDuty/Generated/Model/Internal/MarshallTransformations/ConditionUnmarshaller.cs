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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Condition Object
    /// </summary>  
    public class ConditionUnmarshaller : IUnmarshaller<Condition, XmlUnmarshallerContext>, IUnmarshaller<Condition, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Condition IUnmarshaller<Condition, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Condition Unmarshall(JsonUnmarshallerContext context)
        {
            Condition unmarshalledObject = new Condition();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("eq", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Eq = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("equals", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Equals = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("greaterThan", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.GreaterThan = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("greaterThanOrEqual", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.GreaterThanOrEqual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gt", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Gt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("gte", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Gte = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lessThan", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.LessThan = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lessThanOrEqual", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.LessThanOrEqual = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lt", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Lt = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lte", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Lte = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("matches", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Matches = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("neq", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Neq = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("notEquals", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NotEquals = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("notMatches", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.NotMatches = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConditionUnmarshaller _instance = new ConditionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConditionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}