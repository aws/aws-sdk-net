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
    /// Response Unmarshaller for InternetHealth Object
    /// </summary>  
    public class InternetHealthUnmarshaller : IUnmarshaller<InternetHealth, XmlUnmarshallerContext>, IUnmarshaller<InternetHealth, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        InternetHealth IUnmarshaller<InternetHealth, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InternetHealth Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            InternetHealth unmarshalledObject = new InternetHealth();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Availability", targetDepth))
                {
                    var unmarshaller = AvailabilityMeasurementUnmarshaller.Instance;
                    unmarshalledObject.Availability = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Performance", targetDepth))
                {
                    var unmarshaller = PerformanceMeasurementUnmarshaller.Instance;
                    unmarshalledObject.Performance = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static InternetHealthUnmarshaller _instance = new InternetHealthUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InternetHealthUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}