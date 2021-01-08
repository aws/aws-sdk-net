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
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DetectMitigationActionsTaskSummary Object
    /// </summary>  
    public class DetectMitigationActionsTaskSummaryUnmarshaller : IUnmarshaller<DetectMitigationActionsTaskSummary, XmlUnmarshallerContext>, IUnmarshaller<DetectMitigationActionsTaskSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DetectMitigationActionsTaskSummary IUnmarshaller<DetectMitigationActionsTaskSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DetectMitigationActionsTaskSummary Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DetectMitigationActionsTaskSummary unmarshalledObject = new DetectMitigationActionsTaskSummary();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actionsDefinition", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MitigationAction, MitigationActionUnmarshaller>(MitigationActionUnmarshaller.Instance);
                    unmarshalledObject.ActionsDefinition = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("onlyActiveViolationsIncluded", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.OnlyActiveViolationsIncluded = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("suppressedAlertsIncluded", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.SuppressedAlertsIncluded = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("target", targetDepth))
                {
                    var unmarshaller = DetectMitigationActionsTaskTargetUnmarshaller.Instance;
                    unmarshalledObject.Target = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.TaskEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.TaskStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskStatistics", targetDepth))
                {
                    var unmarshaller = DetectMitigationActionsTaskStatisticsUnmarshaller.Instance;
                    unmarshalledObject.TaskStatistics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("violationEventOccurrenceRange", targetDepth))
                {
                    var unmarshaller = ViolationEventOccurrenceRangeUnmarshaller.Instance;
                    unmarshalledObject.ViolationEventOccurrenceRange = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DetectMitigationActionsTaskSummaryUnmarshaller _instance = new DetectMitigationActionsTaskSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DetectMitigationActionsTaskSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}