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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.DevOpsAgent.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Recurrence Object
    /// </summary>
    public partial class RecurrenceUnmarshaller : IJsonUnmarshaller<Recurrence, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Recurrence Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new Recurrence();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("daily", targetDepth, ref reader))
                {
                    var unmarshaller = DailyRecurrenceUnmarshaller.Instance;
                    unmarshalledObject.Daily = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("monthly", targetDepth, ref reader))
                {
                    var unmarshaller = MonthlyRecurrenceUnmarshaller.Instance;
                    unmarshalledObject.Monthly = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("weekly", targetDepth, ref reader))
                {
                    var unmarshaller = WeeklyRecurrenceUnmarshaller.Instance;
                    unmarshalledObject.Weekly = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static RecurrenceUnmarshaller _instance = new RecurrenceUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RecurrenceUnmarshaller Instance => _instance;
    }
}
