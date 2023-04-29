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
 * Do not modify this file. This file is generated from the internetmonitor-2021-06-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.InternetMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.InternetMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PerformanceMeasurement Object
    /// </summary>  
    public class PerformanceMeasurementUnmarshaller : IUnmarshaller<PerformanceMeasurement, XmlUnmarshallerContext>, IUnmarshaller<PerformanceMeasurement, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PerformanceMeasurement IUnmarshaller<PerformanceMeasurement, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PerformanceMeasurement Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PerformanceMeasurement unmarshalledObject = new PerformanceMeasurement();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ExperienceScore", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.ExperienceScore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PercentOfClientLocationImpacted", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.PercentOfClientLocationImpacted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PercentOfTotalTrafficImpacted", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.PercentOfTotalTrafficImpacted = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RoundTripTime", targetDepth))
                {
                    var unmarshaller = RoundTripTimeUnmarshaller.Instance;
                    unmarshalledObject.RoundTripTime = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PerformanceMeasurementUnmarshaller _instance = new PerformanceMeasurementUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PerformanceMeasurementUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}