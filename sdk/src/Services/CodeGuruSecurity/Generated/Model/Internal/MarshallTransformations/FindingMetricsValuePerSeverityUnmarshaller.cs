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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruSecurity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CodeGuruSecurity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FindingMetricsValuePerSeverity Object
    /// </summary>  
    public class FindingMetricsValuePerSeverityUnmarshaller : IUnmarshaller<FindingMetricsValuePerSeverity, XmlUnmarshallerContext>, IUnmarshaller<FindingMetricsValuePerSeverity, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        FindingMetricsValuePerSeverity IUnmarshaller<FindingMetricsValuePerSeverity, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public FindingMetricsValuePerSeverity Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            FindingMetricsValuePerSeverity unmarshalledObject = new FindingMetricsValuePerSeverity();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("critical", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Critical = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("high", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.High = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("info", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Info = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("low", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Low = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("medium", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Medium = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static FindingMetricsValuePerSeverityUnmarshaller _instance = new FindingMetricsValuePerSeverityUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FindingMetricsValuePerSeverityUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}