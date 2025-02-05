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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ForecastService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ForecastService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Statistics Object
    /// </summary>  
    public class StatisticsUnmarshaller : IJsonUnmarshaller<Statistics, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Statistics Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Statistics unmarshalledObject = new Statistics();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Avg", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Avg = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Count", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Count = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CountDistinct", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.CountDistinct = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CountDistinctLong", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.CountDistinctLong = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CountLong", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.CountLong = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CountNan", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.CountNan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CountNanLong", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.CountNanLong = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CountNull", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.CountNull = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CountNullLong", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.CountNullLong = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Max", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Max = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Min", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Min = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Stddev", targetDepth))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Stddev = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static StatisticsUnmarshaller _instance = new StatisticsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StatisticsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}