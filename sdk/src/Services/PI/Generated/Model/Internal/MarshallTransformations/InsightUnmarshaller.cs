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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PI.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Insight Object
    /// </summary>  
    public class InsightUnmarshaller : IUnmarshaller<Insight, XmlUnmarshallerContext>, IUnmarshaller<Insight, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Insight IUnmarshaller<Insight, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Insight Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Insight unmarshalledObject = new Insight();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("BaselineData", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Data, DataUnmarshaller>(DataUnmarshaller.Instance);
                    unmarshalledObject.BaselineData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Context", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Context = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InsightData", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Data, DataUnmarshaller>(DataUnmarshaller.Instance);
                    unmarshalledObject.InsightData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InsightId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InsightId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InsightType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InsightType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Recommendations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Recommendation, RecommendationUnmarshaller>(RecommendationUnmarshaller.Instance);
                    unmarshalledObject.Recommendations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Severity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Severity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SupportingInsights", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Insight, InsightUnmarshaller>(InsightUnmarshaller.Instance);
                    unmarshalledObject.SupportingInsights = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InsightUnmarshaller _instance = new InsightUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InsightUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}