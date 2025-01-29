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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ClosedDays Object
    /// </summary>  
    public class ClosedDaysUnmarshaller : IJsonUnmarshaller<ClosedDays, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ClosedDays Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ClosedDays unmarshalledObject = new ClosedDays();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CUSTOM", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ClosedDaysRule, ClosedDaysRuleUnmarshaller>(ClosedDaysRuleUnmarshaller.Instance);
                    unmarshalledObject.CUSTOM = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EMAIL", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ClosedDaysRule, ClosedDaysRuleUnmarshaller>(ClosedDaysRuleUnmarshaller.Instance);
                    unmarshalledObject.EMAIL = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("PUSH", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ClosedDaysRule, ClosedDaysRuleUnmarshaller>(ClosedDaysRuleUnmarshaller.Instance);
                    unmarshalledObject.PUSH = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SMS", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ClosedDaysRule, ClosedDaysRuleUnmarshaller>(ClosedDaysRuleUnmarshaller.Instance);
                    unmarshalledObject.SMS = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VOICE", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ClosedDaysRule, ClosedDaysRuleUnmarshaller>(ClosedDaysRuleUnmarshaller.Instance);
                    unmarshalledObject.VOICE = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ClosedDaysUnmarshaller _instance = new ClosedDaysUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClosedDaysUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}