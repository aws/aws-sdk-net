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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MetricValue Object
    /// </summary>  
    public class MetricValueUnmarshaller : IJsonUnmarshaller<MetricValue, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MetricValue Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MetricValue unmarshalledObject = new MetricValue();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cidrs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Cidrs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("count", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Count = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("number", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Number = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("numbers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<double, DoubleUnmarshaller>(DoubleUnmarshaller.Instance);
                    unmarshalledObject.Numbers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ports", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.Ports = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("strings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Strings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MetricValueUnmarshaller _instance = new MetricValueUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MetricValueUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}