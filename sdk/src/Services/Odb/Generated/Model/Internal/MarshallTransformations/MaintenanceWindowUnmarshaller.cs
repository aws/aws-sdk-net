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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Odb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Odb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MaintenanceWindow Object
    /// </summary>  
    public class MaintenanceWindowUnmarshaller : IJsonUnmarshaller<MaintenanceWindow, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MaintenanceWindow Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MaintenanceWindow unmarshalledObject = new MaintenanceWindow();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("customActionTimeoutInMins", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.CustomActionTimeoutInMins = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("daysOfWeek", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DayOfWeek, DayOfWeekUnmarshaller>(DayOfWeekUnmarshaller.Instance);
                    unmarshalledObject.DaysOfWeek = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("hoursOfDay", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.HoursOfDay = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("isCustomActionTimeoutEnabled", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.IsCustomActionTimeoutEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("leadTimeInWeeks", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.LeadTimeInWeeks = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("months", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Month, MonthUnmarshaller>(MonthUnmarshaller.Instance);
                    unmarshalledObject.Months = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("patchingMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PatchingMode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("preference", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Preference = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("skipRu", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.SkipRu = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("weeksOfMonth", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<int, IntUnmarshaller>(IntUnmarshaller.Instance);
                    unmarshalledObject.WeeksOfMonth = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MaintenanceWindowUnmarshaller _instance = new MaintenanceWindowUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MaintenanceWindowUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}