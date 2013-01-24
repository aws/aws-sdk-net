/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Put Metric Alarm Request Marshaller
    /// </summary>       
    public class PutMetricAlarmRequestMarshaller : IMarshaller<IRequest, PutMetricAlarmRequest>
    {
        public IRequest Marshall(PutMetricAlarmRequest putMetricAlarmRequest)
        {
            IRequest request = new DefaultRequest(putMetricAlarmRequest, "AmazonCloudWatch");
            request.Parameters.Add("Action", "PutMetricAlarm");
            request.Parameters.Add("Version", "2010-08-01");
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetAlarmName())
            {
                request.Parameters.Add("AlarmName", StringUtils.FromString(putMetricAlarmRequest.AlarmName));
            }
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetAlarmDescription())
            {
                request.Parameters.Add("AlarmDescription", StringUtils.FromString(putMetricAlarmRequest.AlarmDescription));
            }
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetActionsEnabled())
            {
                request.Parameters.Add("ActionsEnabled", StringUtils.FromBool(putMetricAlarmRequest.ActionsEnabled));
            }
            if (putMetricAlarmRequest != null)
            {
                List<string> oKActionsList = putMetricAlarmRequest.OKActions;

                int oKActionsListIndex = 1;
                foreach (string oKActionsListValue in oKActionsList)
                { 
                    request.Parameters.Add("OKActions.member." + oKActionsListIndex, StringUtils.FromString(oKActionsListValue));
                    oKActionsListIndex++;
                }
            }
            if (putMetricAlarmRequest != null)
            {
                List<string> alarmActionsList = putMetricAlarmRequest.AlarmActions;

                int alarmActionsListIndex = 1;
                foreach (string alarmActionsListValue in alarmActionsList)
                { 
                    request.Parameters.Add("AlarmActions.member." + alarmActionsListIndex, StringUtils.FromString(alarmActionsListValue));
                    alarmActionsListIndex++;
                }
            }
            if (putMetricAlarmRequest != null)
            {
                List<string> insufficientDataActionsList = putMetricAlarmRequest.InsufficientDataActions;

                int insufficientDataActionsListIndex = 1;
                foreach (string insufficientDataActionsListValue in insufficientDataActionsList)
                { 
                    request.Parameters.Add("InsufficientDataActions.member." + insufficientDataActionsListIndex, StringUtils.FromString(insufficientDataActionsListValue));
                    insufficientDataActionsListIndex++;
                }
            }
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetMetricName())
            {
                request.Parameters.Add("MetricName", StringUtils.FromString(putMetricAlarmRequest.MetricName));
            }
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetNamespace())
            {
                request.Parameters.Add("Namespace", StringUtils.FromString(putMetricAlarmRequest.Namespace));
            }
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetStatistic())
            {
                request.Parameters.Add("Statistic", StringUtils.FromString(putMetricAlarmRequest.Statistic));
            }

            if (putMetricAlarmRequest != null)
            {
                List<Dimension> dimensionsList = putMetricAlarmRequest.Dimensions;
                int dimensionsListIndex = 1;
                foreach (Dimension dimensionsListValue in dimensionsList)
                {
                    if (dimensionsListValue != null && dimensionsListValue.IsSetName())
                    {
                        request.Parameters.Add("Dimensions.member." + dimensionsListIndex + ".Name", StringUtils.FromString(dimensionsListValue.Name));
                    }
                    if (dimensionsListValue != null && dimensionsListValue.IsSetValue())
                    {
                        request.Parameters.Add("Dimensions.member." + dimensionsListIndex + ".Value", StringUtils.FromString(dimensionsListValue.Value));
                    }

                    dimensionsListIndex++;
                }
            }
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetPeriod())
            {
                request.Parameters.Add("Period", StringUtils.FromInt(putMetricAlarmRequest.Period));
            }
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetUnit())
            {
                request.Parameters.Add("Unit", StringUtils.FromString(putMetricAlarmRequest.Unit));
            }
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetEvaluationPeriods())
            {
                request.Parameters.Add("EvaluationPeriods", StringUtils.FromInt(putMetricAlarmRequest.EvaluationPeriods));
            }
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetThreshold())
            {
                request.Parameters.Add("Threshold", StringUtils.FromDouble(putMetricAlarmRequest.Threshold));
            }
            if (putMetricAlarmRequest != null && putMetricAlarmRequest.IsSetComparisonOperator())
            {
                request.Parameters.Add("ComparisonOperator", StringUtils.FromString(putMetricAlarmRequest.ComparisonOperator));
            }

            return request;
        }
    }
}
