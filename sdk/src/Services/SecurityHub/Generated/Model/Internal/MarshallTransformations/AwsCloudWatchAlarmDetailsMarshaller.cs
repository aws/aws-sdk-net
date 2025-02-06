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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsCloudWatchAlarmDetails Marshaller
    /// </summary>
    public class AwsCloudWatchAlarmDetailsMarshaller : IRequestMarshaller<AwsCloudWatchAlarmDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsCloudWatchAlarmDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionsEnabled())
            {
                context.Writer.WritePropertyName("ActionsEnabled");
                context.Writer.WriteBooleanValue(requestObject.ActionsEnabled.Value);
            }

            if(requestObject.IsSetAlarmActions())
            {
                context.Writer.WritePropertyName("AlarmActions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAlarmActionsListValue in requestObject.AlarmActions)
                {
                        context.Writer.WriteStringValue(requestObjectAlarmActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAlarmArn())
            {
                context.Writer.WritePropertyName("AlarmArn");
                context.Writer.WriteStringValue(requestObject.AlarmArn);
            }

            if(requestObject.IsSetAlarmConfigurationUpdatedTimestamp())
            {
                context.Writer.WritePropertyName("AlarmConfigurationUpdatedTimestamp");
                context.Writer.WriteStringValue(requestObject.AlarmConfigurationUpdatedTimestamp);
            }

            if(requestObject.IsSetAlarmDescription())
            {
                context.Writer.WritePropertyName("AlarmDescription");
                context.Writer.WriteStringValue(requestObject.AlarmDescription);
            }

            if(requestObject.IsSetAlarmName())
            {
                context.Writer.WritePropertyName("AlarmName");
                context.Writer.WriteStringValue(requestObject.AlarmName);
            }

            if(requestObject.IsSetComparisonOperator())
            {
                context.Writer.WritePropertyName("ComparisonOperator");
                context.Writer.WriteStringValue(requestObject.ComparisonOperator);
            }

            if(requestObject.IsSetDatapointsToAlarm())
            {
                context.Writer.WritePropertyName("DatapointsToAlarm");
                context.Writer.WriteNumberValue(requestObject.DatapointsToAlarm.Value);
            }

            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDimensionsListValue in requestObject.Dimensions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsCloudWatchAlarmDimensionsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDimensionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetEvaluateLowSampleCountPercentile())
            {
                context.Writer.WritePropertyName("EvaluateLowSampleCountPercentile");
                context.Writer.WriteStringValue(requestObject.EvaluateLowSampleCountPercentile);
            }

            if(requestObject.IsSetEvaluationPeriods())
            {
                context.Writer.WritePropertyName("EvaluationPeriods");
                context.Writer.WriteNumberValue(requestObject.EvaluationPeriods.Value);
            }

            if(requestObject.IsSetExtendedStatistic())
            {
                context.Writer.WritePropertyName("ExtendedStatistic");
                context.Writer.WriteStringValue(requestObject.ExtendedStatistic);
            }

            if(requestObject.IsSetInsufficientDataActions())
            {
                context.Writer.WritePropertyName("InsufficientDataActions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInsufficientDataActionsListValue in requestObject.InsufficientDataActions)
                {
                        context.Writer.WriteStringValue(requestObjectInsufficientDataActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("MetricName");
                context.Writer.WriteStringValue(requestObject.MetricName);
            }

            if(requestObject.IsSetNamespace())
            {
                context.Writer.WritePropertyName("Namespace");
                context.Writer.WriteStringValue(requestObject.Namespace);
            }

            if(requestObject.IsSetOkActions())
            {
                context.Writer.WritePropertyName("OkActions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOkActionsListValue in requestObject.OkActions)
                {
                        context.Writer.WriteStringValue(requestObjectOkActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPeriod())
            {
                context.Writer.WritePropertyName("Period");
                context.Writer.WriteNumberValue(requestObject.Period.Value);
            }

            if(requestObject.IsSetStatistic())
            {
                context.Writer.WritePropertyName("Statistic");
                context.Writer.WriteStringValue(requestObject.Statistic);
            }

            if(requestObject.IsSetThreshold())
            {
                context.Writer.WritePropertyName("Threshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Threshold.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Threshold.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Threshold.Value);
                }
            }

            if(requestObject.IsSetThresholdMetricId())
            {
                context.Writer.WritePropertyName("ThresholdMetricId");
                context.Writer.WriteStringValue(requestObject.ThresholdMetricId);
            }

            if(requestObject.IsSetTreatMissingData())
            {
                context.Writer.WritePropertyName("TreatMissingData");
                context.Writer.WriteStringValue(requestObject.TreatMissingData);
            }

            if(requestObject.IsSetUnit())
            {
                context.Writer.WritePropertyName("Unit");
                context.Writer.WriteStringValue(requestObject.Unit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCloudWatchAlarmDetailsMarshaller Instance = new AwsCloudWatchAlarmDetailsMarshaller();

    }
}