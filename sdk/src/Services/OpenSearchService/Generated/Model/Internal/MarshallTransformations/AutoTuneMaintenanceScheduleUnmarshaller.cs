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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutoTuneMaintenanceSchedule Object
    /// </summary>  
    public class AutoTuneMaintenanceScheduleUnmarshaller : IUnmarshaller<AutoTuneMaintenanceSchedule, XmlUnmarshallerContext>, IUnmarshaller<AutoTuneMaintenanceSchedule, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        AutoTuneMaintenanceSchedule IUnmarshaller<AutoTuneMaintenanceSchedule, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AutoTuneMaintenanceSchedule Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            AutoTuneMaintenanceSchedule unmarshalledObject = new AutoTuneMaintenanceSchedule();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CronExpressionForRecurrence", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CronExpressionForRecurrence = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Duration", targetDepth))
                {
                    var unmarshaller = DurationUnmarshaller.Instance;
                    unmarshalledObject.Duration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartAt", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartAt = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static AutoTuneMaintenanceScheduleUnmarshaller _instance = new AutoTuneMaintenanceScheduleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutoTuneMaintenanceScheduleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}