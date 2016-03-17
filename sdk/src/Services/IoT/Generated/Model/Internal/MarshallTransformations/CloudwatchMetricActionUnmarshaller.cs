/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CloudwatchMetricAction Object
    /// </summary>  
    public class CloudwatchMetricActionUnmarshaller : IUnmarshaller<CloudwatchMetricAction, XmlUnmarshallerContext>, IUnmarshaller<CloudwatchMetricAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CloudwatchMetricAction IUnmarshaller<CloudwatchMetricAction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CloudwatchMetricAction Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CloudwatchMetricAction unmarshalledObject = new CloudwatchMetricAction();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("metricName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metricNamespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricNamespace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metricTimestamp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metricUnit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricUnit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("metricValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("roleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CloudwatchMetricActionUnmarshaller _instance = new CloudwatchMetricActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CloudwatchMetricActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}