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
using ThirdParty.Json.LitJson;

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
                context.Writer.Write(requestObject.ActionsEnabled);
            }

            if(requestObject.IsSetAlarmActions())
            {
                context.Writer.WritePropertyName("AlarmActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAlarmActionsListValue in requestObject.AlarmActions)
                {
                        context.Writer.Write(requestObjectAlarmActionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAlarmArn())
            {
                context.Writer.WritePropertyName("AlarmArn");
                context.Writer.Write(requestObject.AlarmArn);
            }

            if(requestObject.IsSetAlarmConfigurationUpdatedTimestamp())
            {
                context.Writer.WritePropertyName("AlarmConfigurationUpdatedTimestamp");
                context.Writer.Write(requestObject.AlarmConfigurationUpdatedTimestamp);
            }

            if(requestObject.IsSetAlarmDescription())
            {
                context.Writer.WritePropertyName("AlarmDescription");
                context.Writer.Write(requestObject.AlarmDescription);
            }

            if(requestObject.IsSetAlarmName())
            {
                context.Writer.WritePropertyName("AlarmName");
                context.Writer.Write(requestObject.AlarmName);
            }

            if(requestObject.IsSetComparisonOperator())
            {
                context.Writer.WritePropertyName("ComparisonOperator");
                context.Writer.Write(requestObject.ComparisonOperator);
            }

            if(requestObject.IsSetDatapointsToAlarm())
            {
                context.Writer.WritePropertyName("DatapointsToAlarm");
                context.Writer.Write(requestObject.DatapointsToAlarm);
            }

            if(requestObject.IsSetDimensions())
            {
                context.Writer.WritePropertyName("Dimensions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDimensionsListValue in requestObject.Dimensions)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsCloudWatchAlarmDimensionsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectDimensionsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEvaluateLowSampleCountPercentile())
            {
                context.Writer.WritePropertyName("EvaluateLowSampleCountPercentile");
                context.Writer.Write(requestObject.EvaluateLowSampleCountPercentile);
            }

            if(requestObject.IsSetEvaluationPeriods())
            {
                context.Writer.WritePropertyName("EvaluationPeriods");
                context.Writer.Write(requestObject.EvaluationPeriods);
            }

            if(requestObject.IsSetExtendedStatistic())
            {
                context.Writer.WritePropertyName("ExtendedStatistic");
                context.Writer.Write(requestObject.ExtendedStatistic);
            }

            if(requestObject.IsSetInsufficientDataActions())
            {
                context.Writer.WritePropertyName("InsufficientDataActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInsufficientDataActionsListValue in requestObject.InsufficientDataActions)
                {
                        context.Writer.Write(requestObjectInsufficientDataActionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMetricName())
            {
                context.Writer.WritePropertyName("MetricName");
                context.Writer.Write(requestObject.MetricName);
            }

            if(requestObject.IsSetNamespace())
            {
                context.Writer.WritePropertyName("Namespace");
                context.Writer.Write(requestObject.Namespace);
            }

            if(requestObject.IsSetOkActions())
            {
                context.Writer.WritePropertyName("OkActions");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectOkActionsListValue in requestObject.OkActions)
                {
                        context.Writer.Write(requestObjectOkActionsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPeriod())
            {
                context.Writer.WritePropertyName("Period");
                context.Writer.Write(requestObject.Period);
            }

            if(requestObject.IsSetStatistic())
            {
                context.Writer.WritePropertyName("Statistic");
                context.Writer.Write(requestObject.Statistic);
            }

            if(requestObject.IsSetThreshold())
            {
                context.Writer.WritePropertyName("Threshold");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Threshold))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Threshold));
                }
                else
                {
                    context.Writer.Write(requestObject.Threshold);
                }
            }

            if(requestObject.IsSetThresholdMetricId())
            {
                context.Writer.WritePropertyName("ThresholdMetricId");
                context.Writer.Write(requestObject.ThresholdMetricId);
            }

            if(requestObject.IsSetTreatMissingData())
            {
                context.Writer.WritePropertyName("TreatMissingData");
                context.Writer.Write(requestObject.TreatMissingData);
            }

            if(requestObject.IsSetUnit())
            {
                context.Writer.WritePropertyName("Unit");
                context.Writer.Write(requestObject.Unit);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsCloudWatchAlarmDetailsMarshaller Instance = new AwsCloudWatchAlarmDetailsMarshaller();

    }
}