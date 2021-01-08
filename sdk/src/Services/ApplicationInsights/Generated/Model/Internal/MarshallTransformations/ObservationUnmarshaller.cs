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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationInsights.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Observation Object
    /// </summary>  
    public class ObservationUnmarshaller : IUnmarshaller<Observation, XmlUnmarshallerContext>, IUnmarshaller<Observation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Observation IUnmarshaller<Observation, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Observation Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            Observation unmarshalledObject = new Observation();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CloudWatchEventDetailType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchEventDetailType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudWatchEventId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchEventId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CloudWatchEventSource", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloudWatchEventSource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodeDeployApplication", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodeDeployApplication = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodeDeployDeploymentGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodeDeployDeploymentGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodeDeployDeploymentId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodeDeployDeploymentId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodeDeployInstanceGroupId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodeDeployInstanceGroupId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CodeDeployState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CodeDeployState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsCause", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbsCause = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsEvent", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbsEvent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsRequestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbsRequestId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EbsResult", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EbsResult = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Ec2State", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2State = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthEventArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HealthEventArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthEventDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HealthEventDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthEventTypeCategory", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HealthEventTypeCategory = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthEventTypeCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HealthEventTypeCode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HealthService", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.HealthService = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LineTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LineTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogFilter", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogFilter = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogText", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogText = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricNamespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricNamespace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RdsEventCategories", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RdsEventCategories = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RdsEventMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RdsEventMessage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3EventName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.S3EventName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceARN = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatesArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatesArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatesExecutionArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatesExecutionArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatesInput", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatesInput = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatesStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StatesStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Unit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Unit = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Value", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Value = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XRayErrorPercent", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.XRayErrorPercent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XRayFaultPercent", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.XRayFaultPercent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XRayNodeName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.XRayNodeName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XRayNodeType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.XRayNodeType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XRayRequestAverageLatency", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.XRayRequestAverageLatency = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XRayRequestCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.XRayRequestCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("XRayThrottlePercent", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.XRayThrottlePercent = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ObservationUnmarshaller _instance = new ObservationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ObservationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}