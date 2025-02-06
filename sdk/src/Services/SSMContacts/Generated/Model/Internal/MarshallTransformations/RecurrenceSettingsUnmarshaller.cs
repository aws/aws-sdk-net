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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMContacts.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SSMContacts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecurrenceSettings Object
    /// </summary>  
    public class RecurrenceSettingsUnmarshaller : IJsonUnmarshaller<RecurrenceSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RecurrenceSettings Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RecurrenceSettings unmarshalledObject = new RecurrenceSettings();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DailySettings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<HandOffTime, HandOffTimeUnmarshaller>(HandOffTimeUnmarshaller.Instance);
                    unmarshalledObject.DailySettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MonthlySettings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<MonthlySetting, MonthlySettingUnmarshaller>(MonthlySettingUnmarshaller.Instance);
                    unmarshalledObject.MonthlySettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NumberOfOnCalls", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfOnCalls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RecurrenceMultiplier", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.RecurrenceMultiplier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ShiftCoverages", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, List<CoverageTime>, StringUnmarshaller, JsonListUnmarshaller<CoverageTime,CoverageTimeUnmarshaller>>(StringUnmarshaller.Instance, new JsonListUnmarshaller<CoverageTime, CoverageTimeUnmarshaller>(CoverageTimeUnmarshaller.Instance));
                    unmarshalledObject.ShiftCoverages = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("WeeklySettings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<WeeklySetting, WeeklySettingUnmarshaller>(WeeklySettingUnmarshaller.Instance);
                    unmarshalledObject.WeeklySettings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RecurrenceSettingsUnmarshaller _instance = new RecurrenceSettingsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecurrenceSettingsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}