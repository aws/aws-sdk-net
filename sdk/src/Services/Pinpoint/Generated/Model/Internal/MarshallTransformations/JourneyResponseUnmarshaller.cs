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
    /// Response Unmarshaller for JourneyResponse Object
    /// </summary>  
    public class JourneyResponseUnmarshaller : IJsonUnmarshaller<JourneyResponse, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public JourneyResponse Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            JourneyResponse unmarshalledObject = new JourneyResponse();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Activities", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, Activity, StringUnmarshaller, ActivityUnmarshaller>(StringUnmarshaller.Instance, ActivityUnmarshaller.Instance);
                    unmarshalledObject.Activities = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ApplicationId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ClosedDays", targetDepth))
                {
                    var unmarshaller = ClosedDaysUnmarshaller.Instance;
                    unmarshalledObject.ClosedDays = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JourneyChannelSettings", targetDepth))
                {
                    var unmarshaller = JourneyChannelSettingsUnmarshaller.Instance;
                    unmarshalledObject.JourneyChannelSettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModifiedDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Limits", targetDepth))
                {
                    var unmarshaller = JourneyLimitsUnmarshaller.Instance;
                    unmarshalledObject.Limits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LocalTime", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.LocalTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OpenHours", targetDepth))
                {
                    var unmarshaller = OpenHoursUnmarshaller.Instance;
                    unmarshalledObject.OpenHours = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("QuietTime", targetDepth))
                {
                    var unmarshaller = QuietTimeUnmarshaller.Instance;
                    unmarshalledObject.QuietTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RefreshFrequency", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RefreshFrequency = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RefreshOnSegmentUpdate", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.RefreshOnSegmentUpdate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Schedule", targetDepth))
                {
                    var unmarshaller = JourneyScheduleUnmarshaller.Instance;
                    unmarshalledObject.Schedule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SendingSchedule", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.SendingSchedule = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartActivity", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartActivity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StartCondition", targetDepth))
                {
                    var unmarshaller = StartConditionUnmarshaller.Instance;
                    unmarshalledObject.StartCondition = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TimezoneEstimationMethods", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TimezoneEstimationMethods = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WaitForQuietTime", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.WaitForQuietTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static JourneyResponseUnmarshaller _instance = new JourneyResponseUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static JourneyResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}