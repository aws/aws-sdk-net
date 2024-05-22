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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OpenHours Object
    /// </summary>  
    public class OpenHoursUnmarshaller : IUnmarshaller<OpenHours, XmlUnmarshallerContext>, IUnmarshaller<OpenHours, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        OpenHours IUnmarshaller<OpenHours, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OpenHours Unmarshall(JsonUnmarshallerContext context)
        {
            OpenHours unmarshalledObject = new OpenHours();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CUSTOM", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<OpenHoursRule>, StringUnmarshaller, ListUnmarshaller<OpenHoursRule, OpenHoursRuleUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<OpenHoursRule, OpenHoursRuleUnmarshaller>(OpenHoursRuleUnmarshaller.Instance));
                    unmarshalledObject.CUSTOM = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EMAIL", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<OpenHoursRule>, StringUnmarshaller, ListUnmarshaller<OpenHoursRule, OpenHoursRuleUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<OpenHoursRule, OpenHoursRuleUnmarshaller>(OpenHoursRuleUnmarshaller.Instance));
                    unmarshalledObject.EMAIL = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PUSH", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<OpenHoursRule>, StringUnmarshaller, ListUnmarshaller<OpenHoursRule, OpenHoursRuleUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<OpenHoursRule, OpenHoursRuleUnmarshaller>(OpenHoursRuleUnmarshaller.Instance));
                    unmarshalledObject.PUSH = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SMS", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<OpenHoursRule>, StringUnmarshaller, ListUnmarshaller<OpenHoursRule, OpenHoursRuleUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<OpenHoursRule, OpenHoursRuleUnmarshaller>(OpenHoursRuleUnmarshaller.Instance));
                    unmarshalledObject.SMS = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VOICE", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<OpenHoursRule>, StringUnmarshaller, ListUnmarshaller<OpenHoursRule, OpenHoursRuleUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<OpenHoursRule, OpenHoursRuleUnmarshaller>(OpenHoursRuleUnmarshaller.Instance));
                    unmarshalledObject.VOICE = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static OpenHoursUnmarshaller _instance = new OpenHoursUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpenHoursUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}