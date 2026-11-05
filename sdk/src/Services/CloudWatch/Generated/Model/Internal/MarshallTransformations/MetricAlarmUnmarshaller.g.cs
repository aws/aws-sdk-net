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

using Amazon.CloudWatch.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MetricAlarm Object
    /// </summary>
    public partial class MetricAlarmUnmarshaller : ICborUnmarshaller<MetricAlarm, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public MetricAlarm Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new MetricAlarm();
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
                    case "ActionConfiguration":
                        context.AddPathSegment("ActionConfiguration");
                        unmarshalledObject.ActionConfiguration = ActionConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ActionsEnabled":
                        context.AddPathSegment("ActionsEnabled");
                        unmarshalledObject.ActionsEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmActions":
                        context.AddPathSegment("AlarmActions");
                        unmarshalledObject.AlarmActions = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmArn":
                        context.AddPathSegment("AlarmArn");
                        unmarshalledObject.AlarmArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmConfigurationUpdatedTimestamp":
                        context.AddPathSegment("AlarmConfigurationUpdatedTimestamp");
                        unmarshalledObject.AlarmConfigurationUpdatedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmDescription":
                        context.AddPathSegment("AlarmDescription");
                        unmarshalledObject.AlarmDescription = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "AlarmName":
                        context.AddPathSegment("AlarmName");
                        unmarshalledObject.AlarmName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ComparisonOperator":
                        context.AddPathSegment("ComparisonOperator");
                        unmarshalledObject.ComparisonOperator = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "DatapointsToAlarm":
                        context.AddPathSegment("DatapointsToAlarm");
                        unmarshalledObject.DatapointsToAlarm = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Dimensions":
                        context.AddPathSegment("Dimensions");
                        unmarshalledObject.Dimensions = new CborListUnmarshaller<Dimension, DimensionUnmarshaller>(DimensionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EvaluateLowSampleCountPercentile":
                        context.AddPathSegment("EvaluateLowSampleCountPercentile");
                        unmarshalledObject.EvaluateLowSampleCountPercentile = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EvaluationCriteria":
                        context.AddPathSegment("EvaluationCriteria");
                        unmarshalledObject.EvaluationCriteria = EvaluationCriteriaUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EvaluationInterval":
                        context.AddPathSegment("EvaluationInterval");
                        unmarshalledObject.EvaluationInterval = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EvaluationPeriods":
                        context.AddPathSegment("EvaluationPeriods");
                        unmarshalledObject.EvaluationPeriods = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EvaluationState":
                        context.AddPathSegment("EvaluationState");
                        unmarshalledObject.EvaluationState = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "EvaluationWindow":
                        context.AddPathSegment("EvaluationWindow");
                        unmarshalledObject.EvaluationWindow = EvaluationWindowUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ExtendedStatistic":
                        context.AddPathSegment("ExtendedStatistic");
                        unmarshalledObject.ExtendedStatistic = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "InsufficientDataActions":
                        context.AddPathSegment("InsufficientDataActions");
                        unmarshalledObject.InsufficientDataActions = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "MetricName":
                        context.AddPathSegment("MetricName");
                        unmarshalledObject.MetricName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Metrics":
                        context.AddPathSegment("Metrics");
                        unmarshalledObject.Metrics = new CborListUnmarshaller<MetricDataQuery, MetricDataQueryUnmarshaller>(MetricDataQueryUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Namespace":
                        context.AddPathSegment("Namespace");
                        unmarshalledObject.Namespace = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "OKActions":
                        context.AddPathSegment("OKActions");
                        unmarshalledObject.OKActions = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Period":
                        context.AddPathSegment("Period");
                        unmarshalledObject.Period = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateReason":
                        context.AddPathSegment("StateReason");
                        unmarshalledObject.StateReason = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateReasonData":
                        context.AddPathSegment("StateReasonData");
                        unmarshalledObject.StateReasonData = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateTransitionedTimestamp":
                        context.AddPathSegment("StateTransitionedTimestamp");
                        unmarshalledObject.StateTransitionedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateUpdatedTimestamp":
                        context.AddPathSegment("StateUpdatedTimestamp");
                        unmarshalledObject.StateUpdatedTimestamp = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "StateValue":
                        context.AddPathSegment("StateValue");
                        unmarshalledObject.StateValue = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Statistic":
                        context.AddPathSegment("Statistic");
                        unmarshalledObject.Statistic = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Threshold":
                        context.AddPathSegment("Threshold");
                        unmarshalledObject.Threshold = CborNullableDoubleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ThresholdMetricId":
                        context.AddPathSegment("ThresholdMetricId");
                        unmarshalledObject.ThresholdMetricId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "TreatMissingData":
                        context.AddPathSegment("TreatMissingData");
                        unmarshalledObject.TreatMissingData = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "Unit":
                        context.AddPathSegment("Unit");
                        unmarshalledObject.Unit = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "WarmUpConfiguration":
                        context.AddPathSegment("WarmUpConfiguration");
                        unmarshalledObject.WarmUpConfiguration = WarmUpConfigurationUnmarshaller.Instance.Unmarshall(context);
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

        private static MetricAlarmUnmarshaller _instance = new MetricAlarmUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static MetricAlarmUnmarshaller Instance => _instance;
    }
}
