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
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Observation Object
    /// </summary>  
    public class ObservationUnmarshaller : ICborUnmarshaller<Observation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Observation Unmarshall(CborUnmarshallerContext context)
        {
            Observation unmarshalledObject = new Observation();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "CloudWatchEventDetailType":
                        {
                            context.AddPathSegment("CloudWatchEventDetailType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CloudWatchEventDetailType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CloudWatchEventId":
                        {
                            context.AddPathSegment("CloudWatchEventId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CloudWatchEventId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CloudWatchEventSource":
                        {
                            context.AddPathSegment("CloudWatchEventSource");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CloudWatchEventSource = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CodeDeployApplication":
                        {
                            context.AddPathSegment("CodeDeployApplication");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CodeDeployApplication = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CodeDeployDeploymentGroup":
                        {
                            context.AddPathSegment("CodeDeployDeploymentGroup");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CodeDeployDeploymentGroup = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CodeDeployDeploymentId":
                        {
                            context.AddPathSegment("CodeDeployDeploymentId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CodeDeployDeploymentId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CodeDeployInstanceGroupId":
                        {
                            context.AddPathSegment("CodeDeployInstanceGroupId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CodeDeployInstanceGroupId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "CodeDeployState":
                        {
                            context.AddPathSegment("CodeDeployState");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CodeDeployState = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EbsCause":
                        {
                            context.AddPathSegment("EbsCause");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EbsCause = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EbsEvent":
                        {
                            context.AddPathSegment("EbsEvent");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EbsEvent = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EbsRequestId":
                        {
                            context.AddPathSegment("EbsRequestId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EbsRequestId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EbsResult":
                        {
                            context.AddPathSegment("EbsResult");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EbsResult = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Ec2State":
                        {
                            context.AddPathSegment("Ec2State");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Ec2State = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "EndTime":
                        {
                            context.AddPathSegment("EndTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "HealthEventArn":
                        {
                            context.AddPathSegment("HealthEventArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HealthEventArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "HealthEventDescription":
                        {
                            context.AddPathSegment("HealthEventDescription");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HealthEventDescription = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "HealthEventTypeCategory":
                        {
                            context.AddPathSegment("HealthEventTypeCategory");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HealthEventTypeCategory = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "HealthEventTypeCode":
                        {
                            context.AddPathSegment("HealthEventTypeCode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HealthEventTypeCode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "HealthService":
                        {
                            context.AddPathSegment("HealthService");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.HealthService = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Id":
                        {
                            context.AddPathSegment("Id");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LineTime":
                        {
                            context.AddPathSegment("LineTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LineTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LogFilter":
                        {
                            context.AddPathSegment("LogFilter");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogFilter = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LogGroup":
                        {
                            context.AddPathSegment("LogGroup");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogGroup = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "LogText":
                        {
                            context.AddPathSegment("LogText");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LogText = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MetricName":
                        {
                            context.AddPathSegment("MetricName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.MetricName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MetricNamespace":
                        {
                            context.AddPathSegment("MetricNamespace");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.MetricNamespace = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RdsEventCategories":
                        {
                            context.AddPathSegment("RdsEventCategories");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RdsEventCategories = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RdsEventMessage":
                        {
                            context.AddPathSegment("RdsEventMessage");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RdsEventMessage = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "S3EventName":
                        {
                            context.AddPathSegment("S3EventName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.S3EventName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SourceARN":
                        {
                            context.AddPathSegment("SourceARN");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SourceARN = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SourceType":
                        {
                            context.AddPathSegment("SourceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SourceType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StartTime":
                        {
                            context.AddPathSegment("StartTime");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatesArn":
                        {
                            context.AddPathSegment("StatesArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatesArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatesExecutionArn":
                        {
                            context.AddPathSegment("StatesExecutionArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatesExecutionArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatesInput":
                        {
                            context.AddPathSegment("StatesInput");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatesInput = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatesStatus":
                        {
                            context.AddPathSegment("StatesStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StatesStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Unit":
                        {
                            context.AddPathSegment("Unit");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Unit = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Value":
                        {
                            context.AddPathSegment("Value");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.Value = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "XRayErrorPercent":
                        {
                            context.AddPathSegment("XRayErrorPercent");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.XRayErrorPercent = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "XRayFaultPercent":
                        {
                            context.AddPathSegment("XRayFaultPercent");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.XRayFaultPercent = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "XRayNodeName":
                        {
                            context.AddPathSegment("XRayNodeName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.XRayNodeName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "XRayNodeType":
                        {
                            context.AddPathSegment("XRayNodeType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.XRayNodeType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "XRayRequestAverageLatency":
                        {
                            context.AddPathSegment("XRayRequestAverageLatency");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.XRayRequestAverageLatency = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "XRayRequestCount":
                        {
                            context.AddPathSegment("XRayRequestCount");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.XRayRequestCount = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "XRayThrottlePercent":
                        {
                            context.AddPathSegment("XRayThrottlePercent");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.XRayThrottlePercent = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
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