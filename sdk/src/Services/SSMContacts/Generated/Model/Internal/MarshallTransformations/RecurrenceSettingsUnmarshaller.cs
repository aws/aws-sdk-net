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
using ThirdParty.Json.LitJson;

namespace Amazon.SSMContacts.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecurrenceSettings Object
    /// </summary>  
    public class RecurrenceSettingsUnmarshaller : IUnmarshaller<RecurrenceSettings, XmlUnmarshallerContext>, IUnmarshaller<RecurrenceSettings, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RecurrenceSettings IUnmarshaller<RecurrenceSettings, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public RecurrenceSettings Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            RecurrenceSettings unmarshalledObject = new RecurrenceSettings();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("DailySettings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<HandOffTime, HandOffTimeUnmarshaller>(HandOffTimeUnmarshaller.Instance);
                    unmarshalledObject.DailySettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MonthlySettings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MonthlySetting, MonthlySettingUnmarshaller>(MonthlySettingUnmarshaller.Instance);
                    unmarshalledObject.MonthlySettings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NumberOfOnCalls", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.NumberOfOnCalls = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RecurrenceMultiplier", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RecurrenceMultiplier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ShiftCoverages", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, List<CoverageTime>, StringUnmarshaller, ListUnmarshaller<CoverageTime, CoverageTimeUnmarshaller>>(StringUnmarshaller.Instance, new ListUnmarshaller<CoverageTime, CoverageTimeUnmarshaller>(CoverageTimeUnmarshaller.Instance));
                    unmarshalledObject.ShiftCoverages = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WeeklySettings", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<WeeklySetting, WeeklySettingUnmarshaller>(WeeklySettingUnmarshaller.Instance);
                    unmarshalledObject.WeeklySettings = unmarshaller.Unmarshall(context);
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