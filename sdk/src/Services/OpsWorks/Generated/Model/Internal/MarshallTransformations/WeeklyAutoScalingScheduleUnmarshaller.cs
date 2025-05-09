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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorks.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.OpsWorks.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WeeklyAutoScalingSchedule Object
    /// </summary>  
    public class WeeklyAutoScalingScheduleUnmarshaller : IJsonUnmarshaller<WeeklyAutoScalingSchedule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public WeeklyAutoScalingSchedule Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            WeeklyAutoScalingSchedule unmarshalledObject = new WeeklyAutoScalingSchedule();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Friday", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Friday = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Monday", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Monday = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Saturday", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Saturday = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Sunday", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Sunday = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Thursday", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Thursday = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Tuesday", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tuesday = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Wednesday", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Wednesday = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WeeklyAutoScalingScheduleUnmarshaller _instance = new WeeklyAutoScalingScheduleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WeeklyAutoScalingScheduleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}