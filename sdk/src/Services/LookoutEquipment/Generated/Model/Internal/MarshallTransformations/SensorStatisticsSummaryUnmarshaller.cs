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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.LookoutEquipment.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.LookoutEquipment.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SensorStatisticsSummary Object
    /// </summary>  
    public class SensorStatisticsSummaryUnmarshaller : IJsonUnmarshaller<SensorStatisticsSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public SensorStatisticsSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            SensorStatisticsSummary unmarshalledObject = new SensorStatisticsSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CategoricalValues", targetDepth))
                {
                    var unmarshaller = CategoricalValuesUnmarshaller.Instance;
                    unmarshalledObject.CategoricalValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ComponentName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComponentName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataEndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.DataEndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataExists", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.DataExists = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DataStartTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.DataStartTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DuplicateTimestamps", targetDepth))
                {
                    var unmarshaller = CountPercentUnmarshaller.Instance;
                    unmarshalledObject.DuplicateTimestamps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InvalidDateEntries", targetDepth))
                {
                    var unmarshaller = CountPercentUnmarshaller.Instance;
                    unmarshalledObject.InvalidDateEntries = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InvalidValues", targetDepth))
                {
                    var unmarshaller = CountPercentUnmarshaller.Instance;
                    unmarshalledObject.InvalidValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LargeTimestampGaps", targetDepth))
                {
                    var unmarshaller = LargeTimestampGapsUnmarshaller.Instance;
                    unmarshalledObject.LargeTimestampGaps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MissingValues", targetDepth))
                {
                    var unmarshaller = CountPercentUnmarshaller.Instance;
                    unmarshalledObject.MissingValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MonotonicValues", targetDepth))
                {
                    var unmarshaller = MonotonicValuesUnmarshaller.Instance;
                    unmarshalledObject.MonotonicValues = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MultipleOperatingModes", targetDepth))
                {
                    var unmarshaller = MultipleOperatingModesUnmarshaller.Instance;
                    unmarshalledObject.MultipleOperatingModes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SensorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SensorName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SensorStatisticsSummaryUnmarshaller _instance = new SensorStatisticsSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SensorStatisticsSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}