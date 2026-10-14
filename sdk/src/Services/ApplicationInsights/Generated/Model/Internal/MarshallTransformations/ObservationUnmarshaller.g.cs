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

using Amazon.ApplicationInsights.Model;
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
    public partial class ObservationUnmarshaller : ICborUnmarshaller<Observation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Observation Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Observation();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "CloudWatchEventDetailType":
                        context.AddPathSegment("CloudWatchEventDetailType");
                        unmarshalledObject.CloudWatchEventDetailType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CloudWatchEventId":
                        context.AddPathSegment("CloudWatchEventId");
                        unmarshalledObject.CloudWatchEventId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CloudWatchEventSource":
                        context.AddPathSegment("CloudWatchEventSource");
                        unmarshalledObject.CloudWatchEventSource = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CodeDeployApplication":
                        context.AddPathSegment("CodeDeployApplication");
                        unmarshalledObject.CodeDeployApplication = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CodeDeployDeploymentGroup":
                        context.AddPathSegment("CodeDeployDeploymentGroup");
                        unmarshalledObject.CodeDeployDeploymentGroup = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CodeDeployDeploymentId":
                        context.AddPathSegment("CodeDeployDeploymentId");
                        unmarshalledObject.CodeDeployDeploymentId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CodeDeployInstanceGroupId":
                        context.AddPathSegment("CodeDeployInstanceGroupId");
                        unmarshalledObject.CodeDeployInstanceGroupId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "CodeDeployState":
                        context.AddPathSegment("CodeDeployState");
                        unmarshalledObject.CodeDeployState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EbsCause":
                        context.AddPathSegment("EbsCause");
                        unmarshalledObject.EbsCause = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EbsEvent":
                        context.AddPathSegment("EbsEvent");
                        unmarshalledObject.EbsEvent = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EbsRequestId":
                        context.AddPathSegment("EbsRequestId");
                        unmarshalledObject.EbsRequestId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EbsResult":
                        context.AddPathSegment("EbsResult");
                        unmarshalledObject.EbsResult = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Ec2State":
                        context.AddPathSegment("Ec2State");
                        unmarshalledObject.Ec2State = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EndTime":
                        context.AddPathSegment("EndTime");
                        unmarshalledObject.EndTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HealthEventArn":
                        context.AddPathSegment("HealthEventArn");
                        unmarshalledObject.HealthEventArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HealthEventDescription":
                        context.AddPathSegment("HealthEventDescription");
                        unmarshalledObject.HealthEventDescription = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HealthEventTypeCategory":
                        context.AddPathSegment("HealthEventTypeCategory");
                        unmarshalledObject.HealthEventTypeCategory = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HealthEventTypeCode":
                        context.AddPathSegment("HealthEventTypeCode");
                        unmarshalledObject.HealthEventTypeCode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "HealthService":
                        context.AddPathSegment("HealthService");
                        unmarshalledObject.HealthService = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Id":
                        context.AddPathSegment("Id");
                        unmarshalledObject.Id = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LineTime":
                        context.AddPathSegment("LineTime");
                        unmarshalledObject.LineTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LogFilter":
                        context.AddPathSegment("LogFilter");
                        unmarshalledObject.LogFilter = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LogGroup":
                        context.AddPathSegment("LogGroup");
                        unmarshalledObject.LogGroup = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "LogText":
                        context.AddPathSegment("LogText");
                        unmarshalledObject.LogText = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MetricName":
                        context.AddPathSegment("MetricName");
                        unmarshalledObject.MetricName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MetricNamespace":
                        context.AddPathSegment("MetricNamespace");
                        unmarshalledObject.MetricNamespace = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RdsEventCategories":
                        context.AddPathSegment("RdsEventCategories");
                        unmarshalledObject.RdsEventCategories = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "RdsEventMessage":
                        context.AddPathSegment("RdsEventMessage");
                        unmarshalledObject.RdsEventMessage = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "S3EventName":
                        context.AddPathSegment("S3EventName");
                        unmarshalledObject.S3EventName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceARN":
                        context.AddPathSegment("SourceARN");
                        unmarshalledObject.SourceARN = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "SourceType":
                        context.AddPathSegment("SourceType");
                        unmarshalledObject.SourceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StartTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StatesArn":
                        context.AddPathSegment("StatesArn");
                        unmarshalledObject.StatesArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StatesExecutionArn":
                        context.AddPathSegment("StatesExecutionArn");
                        unmarshalledObject.StatesExecutionArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StatesInput":
                        context.AddPathSegment("StatesInput");
                        unmarshalledObject.StatesInput = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StatesStatus":
                        context.AddPathSegment("StatesStatus");
                        unmarshalledObject.StatesStatus = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Unit":
                        context.AddPathSegment("Unit");
                        unmarshalledObject.Unit = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Value":
                        context.AddPathSegment("Value");
                        unmarshalledObject.Value = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "XRayErrorPercent":
                        context.AddPathSegment("XRayErrorPercent");
                        unmarshalledObject.XRayErrorPercent = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "XRayFaultPercent":
                        context.AddPathSegment("XRayFaultPercent");
                        unmarshalledObject.XRayFaultPercent = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "XRayNodeName":
                        context.AddPathSegment("XRayNodeName");
                        unmarshalledObject.XRayNodeName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "XRayNodeType":
                        context.AddPathSegment("XRayNodeType");
                        unmarshalledObject.XRayNodeType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "XRayRequestAverageLatency":
                        context.AddPathSegment("XRayRequestAverageLatency");
                        unmarshalledObject.XRayRequestAverageLatency = CborNullableLongUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "XRayRequestCount":
                        context.AddPathSegment("XRayRequestCount");
                        unmarshalledObject.XRayRequestCount = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "XRayThrottlePercent":
                        context.AddPathSegment("XRayThrottlePercent");
                        unmarshalledObject.XRayThrottlePercent = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

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
        public static ObservationUnmarshaller Instance => _instance;
    }
}
