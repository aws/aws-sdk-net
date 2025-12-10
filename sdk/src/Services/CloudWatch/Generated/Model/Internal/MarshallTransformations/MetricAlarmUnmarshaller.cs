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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MetricAlarm Object
    /// </summary>  
    public class MetricAlarmUnmarshaller : IUnmarshaller<MetricAlarm, XmlUnmarshallerContext>, IUnmarshaller<MetricAlarm, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        MetricAlarm IUnmarshaller<MetricAlarm, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public MetricAlarm Unmarshall(JsonUnmarshallerContext context)
        {
            MetricAlarm unmarshalledObject = new MetricAlarm();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ActionsEnabled", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.ActionsEnabled = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AlarmActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlarmArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmConfigurationUpdatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.AlarmConfigurationUpdatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlarmDescription = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AlarmName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AlarmName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ComparisonOperator", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComparisonOperator = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DatapointsToAlarm", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.DatapointsToAlarm = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Dimensions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<Dimension, DimensionUnmarshaller>(DimensionUnmarshaller.Instance);
                    unmarshalledObject.Dimensions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluateLowSampleCountPercentile", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluateLowSampleCountPercentile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationPeriods", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.EvaluationPeriods = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EvaluationState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EvaluationState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExtendedStatistic", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExtendedStatistic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InsufficientDataActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InsufficientDataActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MetricName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MetricName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Metrics", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MetricDataQuery, MetricDataQueryUnmarshaller>(MetricDataQueryUnmarshaller.Instance);
                    unmarshalledObject.Metrics = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Namespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Namespace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OKActions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.OKActions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Period", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.Period = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateReason = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateReasonData", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateReasonData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateTransitionedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StateTransitionedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateUpdatedTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StateUpdatedTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StateValue", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StateValue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Statistic", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Statistic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Threshold", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.Threshold = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThresholdMetricId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ThresholdMetricId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TreatMissingData", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TreatMissingData = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Unit", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Unit = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MetricAlarmUnmarshaller _instance = new MetricAlarmUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MetricAlarmUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}