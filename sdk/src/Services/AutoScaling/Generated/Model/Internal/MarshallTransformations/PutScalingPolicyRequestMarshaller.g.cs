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
using System.Globalization;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

using Amazon.AutoScaling.Model;
#pragma warning disable CS0612,CS0618

namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutScalingPolicy Request Marshaller
    /// </summary>
    public partial class PutScalingPolicyRequestMarshaller : IMarshaller<IRequest, PutScalingPolicyRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutScalingPolicyRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(PutScalingPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.HttpMethod = "POST";
            request.Parameters.Add("Action", "PutScalingPolicy");
            request.Parameters.Add("Version", "2011-01-01");

            if (publicRequest.IsSetAdjustmentType())
            {
                request.Parameters.Add("AdjustmentType", StringUtils.FromString(publicRequest.AdjustmentType));
            }
            if (publicRequest.IsSetAutoScalingGroupName())
            {
                request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
            }
            if (publicRequest.IsSetCooldown())
            {
                request.Parameters.Add("Cooldown", StringUtils.FromInt(publicRequest.Cooldown.Value));
            }
            if (publicRequest.IsSetEnabled())
            {
                request.Parameters.Add("Enabled", StringUtils.FromBool(publicRequest.Enabled.Value));
            }
            if (publicRequest.IsSetEstimatedInstanceWarmup())
            {
                request.Parameters.Add("EstimatedInstanceWarmup", StringUtils.FromInt(publicRequest.EstimatedInstanceWarmup.Value));
            }
            if (publicRequest.IsSetMetricAggregationType())
            {
                request.Parameters.Add("MetricAggregationType", StringUtils.FromString(publicRequest.MetricAggregationType));
            }
            if (publicRequest.IsSetMinAdjustmentMagnitude())
            {
                request.Parameters.Add("MinAdjustmentMagnitude", StringUtils.FromInt(publicRequest.MinAdjustmentMagnitude.Value));
            }
            if (publicRequest.IsSetMinAdjustmentStep())
            {
                request.Parameters.Add("MinAdjustmentStep", StringUtils.FromInt(publicRequest.MinAdjustmentStep.Value));
            }
            if (publicRequest.IsSetPolicyName())
            {
                request.Parameters.Add("PolicyName", StringUtils.FromString(publicRequest.PolicyName));
            }
            if (publicRequest.IsSetPolicyType())
            {
                request.Parameters.Add("PolicyType", StringUtils.FromString(publicRequest.PolicyType));
            }
            if (publicRequest.IsSetPredictiveScalingConfiguration())
            {
                if (publicRequest.PredictiveScalingConfiguration.IsSetMaxCapacityBreachBehavior())
                {
                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MaxCapacityBreachBehavior", StringUtils.FromString(publicRequest.PredictiveScalingConfiguration.MaxCapacityBreachBehavior));
                }
                if (publicRequest.PredictiveScalingConfiguration.IsSetMaxCapacityBuffer())
                {
                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MaxCapacityBuffer", StringUtils.FromInt(publicRequest.PredictiveScalingConfiguration.MaxCapacityBuffer.Value));
                }
                if (publicRequest.PredictiveScalingConfiguration.IsSetMetricSpecifications())
                {
                    if (publicRequest.PredictiveScalingConfiguration.MetricSpecifications.Count == 0)
                    {
                        request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications", "");
                    }
                    else
                    {
                        int index1 = 1;
                        foreach (var item1 in publicRequest.PredictiveScalingConfiguration.MetricSpecifications)
                        {
                            if (item1.IsSetCustomizedCapacityMetricSpecification())
                            {
                                if (item1.CustomizedCapacityMetricSpecification.IsSetMetricDataQueries())
                                {
                                    if (item1.CustomizedCapacityMetricSpecification.MetricDataQueries.Count == 0)
                                    {
                                        request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.CustomizedCapacityMetricSpecification.MetricDataQueries)
                                        {
                                            if (item3.IsSetExpression())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".Expression", StringUtils.FromString(item3.Expression));
                                            }
                                            if (item3.IsSetId())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".Id", StringUtils.FromString(item3.Id));
                                            }
                                            if (item3.IsSetLabel())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".Label", StringUtils.FromString(item3.Label));
                                            }
                                            if (item3.IsSetMetricStat())
                                            {
                                                if (item3.MetricStat.IsSetMetric())
                                                {
                                                    if (item3.MetricStat.Metric.IsSetDimensions())
                                                    {
                                                        if (item3.MetricStat.Metric.Dimensions.Count == 0)
                                                        {
                                                            request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Dimensions", "");
                                                        }
                                                        else
                                                        {
                                                            int index6 = 1;
                                                            foreach (var item6 in item3.MetricStat.Metric.Dimensions)
                                                            {
                                                                if (item6.IsSetName())
                                                                {
                                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Dimensions" + ".member" + "." + index6 + ".Name", StringUtils.FromString(item6.Name));
                                                                }
                                                                if (item6.IsSetValue())
                                                                {
                                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Dimensions" + ".member" + "." + index6 + ".Value", StringUtils.FromString(item6.Value));
                                                                }
                                                                index6++;
                                                            }
                                                        }
                                                    }
                                                    if (item3.MetricStat.Metric.IsSetMetricName())
                                                    {
                                                        request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".MetricName", StringUtils.FromString(item3.MetricStat.Metric.MetricName));
                                                    }
                                                    if (item3.MetricStat.Metric.IsSetNamespace())
                                                    {
                                                        request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Namespace", StringUtils.FromString(item3.MetricStat.Metric.Namespace));
                                                    }
                                                }
                                                if (item3.MetricStat.IsSetStat())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Stat", StringUtils.FromString(item3.MetricStat.Stat));
                                                }
                                                if (item3.MetricStat.IsSetUnit())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Unit", StringUtils.FromString(item3.MetricStat.Unit));
                                                }
                                            }
                                            if (item3.IsSetReturnData())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedCapacityMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".ReturnData", StringUtils.FromBool(item3.ReturnData.Value));
                                            }
                                            index3++;
                                        }
                                    }
                                }
                            }
                            if (item1.IsSetCustomizedLoadMetricSpecification())
                            {
                                if (item1.CustomizedLoadMetricSpecification.IsSetMetricDataQueries())
                                {
                                    if (item1.CustomizedLoadMetricSpecification.MetricDataQueries.Count == 0)
                                    {
                                        request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.CustomizedLoadMetricSpecification.MetricDataQueries)
                                        {
                                            if (item3.IsSetExpression())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".Expression", StringUtils.FromString(item3.Expression));
                                            }
                                            if (item3.IsSetId())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".Id", StringUtils.FromString(item3.Id));
                                            }
                                            if (item3.IsSetLabel())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".Label", StringUtils.FromString(item3.Label));
                                            }
                                            if (item3.IsSetMetricStat())
                                            {
                                                if (item3.MetricStat.IsSetMetric())
                                                {
                                                    if (item3.MetricStat.Metric.IsSetDimensions())
                                                    {
                                                        if (item3.MetricStat.Metric.Dimensions.Count == 0)
                                                        {
                                                            request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Dimensions", "");
                                                        }
                                                        else
                                                        {
                                                            int index6 = 1;
                                                            foreach (var item6 in item3.MetricStat.Metric.Dimensions)
                                                            {
                                                                if (item6.IsSetName())
                                                                {
                                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Dimensions" + ".member" + "." + index6 + ".Name", StringUtils.FromString(item6.Name));
                                                                }
                                                                if (item6.IsSetValue())
                                                                {
                                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Dimensions" + ".member" + "." + index6 + ".Value", StringUtils.FromString(item6.Value));
                                                                }
                                                                index6++;
                                                            }
                                                        }
                                                    }
                                                    if (item3.MetricStat.Metric.IsSetMetricName())
                                                    {
                                                        request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".MetricName", StringUtils.FromString(item3.MetricStat.Metric.MetricName));
                                                    }
                                                    if (item3.MetricStat.Metric.IsSetNamespace())
                                                    {
                                                        request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Namespace", StringUtils.FromString(item3.MetricStat.Metric.Namespace));
                                                    }
                                                }
                                                if (item3.MetricStat.IsSetStat())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Stat", StringUtils.FromString(item3.MetricStat.Stat));
                                                }
                                                if (item3.MetricStat.IsSetUnit())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Unit", StringUtils.FromString(item3.MetricStat.Unit));
                                                }
                                            }
                                            if (item3.IsSetReturnData())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedLoadMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".ReturnData", StringUtils.FromBool(item3.ReturnData.Value));
                                            }
                                            index3++;
                                        }
                                    }
                                }
                            }
                            if (item1.IsSetCustomizedScalingMetricSpecification())
                            {
                                if (item1.CustomizedScalingMetricSpecification.IsSetMetricDataQueries())
                                {
                                    if (item1.CustomizedScalingMetricSpecification.MetricDataQueries.Count == 0)
                                    {
                                        request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries", "");
                                    }
                                    else
                                    {
                                        int index3 = 1;
                                        foreach (var item3 in item1.CustomizedScalingMetricSpecification.MetricDataQueries)
                                        {
                                            if (item3.IsSetExpression())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".Expression", StringUtils.FromString(item3.Expression));
                                            }
                                            if (item3.IsSetId())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".Id", StringUtils.FromString(item3.Id));
                                            }
                                            if (item3.IsSetLabel())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".Label", StringUtils.FromString(item3.Label));
                                            }
                                            if (item3.IsSetMetricStat())
                                            {
                                                if (item3.MetricStat.IsSetMetric())
                                                {
                                                    if (item3.MetricStat.Metric.IsSetDimensions())
                                                    {
                                                        if (item3.MetricStat.Metric.Dimensions.Count == 0)
                                                        {
                                                            request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Dimensions", "");
                                                        }
                                                        else
                                                        {
                                                            int index6 = 1;
                                                            foreach (var item6 in item3.MetricStat.Metric.Dimensions)
                                                            {
                                                                if (item6.IsSetName())
                                                                {
                                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Dimensions" + ".member" + "." + index6 + ".Name", StringUtils.FromString(item6.Name));
                                                                }
                                                                if (item6.IsSetValue())
                                                                {
                                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Dimensions" + ".member" + "." + index6 + ".Value", StringUtils.FromString(item6.Value));
                                                                }
                                                                index6++;
                                                            }
                                                        }
                                                    }
                                                    if (item3.MetricStat.Metric.IsSetMetricName())
                                                    {
                                                        request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".MetricName", StringUtils.FromString(item3.MetricStat.Metric.MetricName));
                                                    }
                                                    if (item3.MetricStat.Metric.IsSetNamespace())
                                                    {
                                                        request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Metric" + ".Namespace", StringUtils.FromString(item3.MetricStat.Metric.Namespace));
                                                    }
                                                }
                                                if (item3.MetricStat.IsSetStat())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Stat", StringUtils.FromString(item3.MetricStat.Stat));
                                                }
                                                if (item3.MetricStat.IsSetUnit())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".MetricStat" + ".Unit", StringUtils.FromString(item3.MetricStat.Unit));
                                                }
                                            }
                                            if (item3.IsSetReturnData())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".CustomizedScalingMetricSpecification" + ".MetricDataQueries" + ".member" + "." + index3 + ".ReturnData", StringUtils.FromBool(item3.ReturnData.Value));
                                            }
                                            index3++;
                                        }
                                    }
                                }
                            }
                            if (item1.IsSetPredefinedLoadMetricSpecification())
                            {
                                if (item1.PredefinedLoadMetricSpecification.IsSetPredefinedMetricType())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".PredefinedLoadMetricSpecification" + ".PredefinedMetricType", StringUtils.FromString(item1.PredefinedLoadMetricSpecification.PredefinedMetricType));
                                }
                                if (item1.PredefinedLoadMetricSpecification.IsSetResourceLabel())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".PredefinedLoadMetricSpecification" + ".ResourceLabel", StringUtils.FromString(item1.PredefinedLoadMetricSpecification.ResourceLabel));
                                }
                            }
                            if (item1.IsSetPredefinedMetricPairSpecification())
                            {
                                if (item1.PredefinedMetricPairSpecification.IsSetPredefinedMetricType())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".PredefinedMetricPairSpecification" + ".PredefinedMetricType", StringUtils.FromString(item1.PredefinedMetricPairSpecification.PredefinedMetricType));
                                }
                                if (item1.PredefinedMetricPairSpecification.IsSetResourceLabel())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".PredefinedMetricPairSpecification" + ".ResourceLabel", StringUtils.FromString(item1.PredefinedMetricPairSpecification.ResourceLabel));
                                }
                            }
                            if (item1.IsSetPredefinedScalingMetricSpecification())
                            {
                                if (item1.PredefinedScalingMetricSpecification.IsSetPredefinedMetricType())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".PredefinedScalingMetricSpecification" + ".PredefinedMetricType", StringUtils.FromString(item1.PredefinedScalingMetricSpecification.PredefinedMetricType));
                                }
                                if (item1.PredefinedScalingMetricSpecification.IsSetResourceLabel())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".PredefinedScalingMetricSpecification" + ".ResourceLabel", StringUtils.FromString(item1.PredefinedScalingMetricSpecification.ResourceLabel));
                                }
                            }
                            if (item1.IsSetTargetValue())
                            {
                                request.Parameters.Add("PredictiveScalingConfiguration" + ".MetricSpecifications" + ".member" + "." + index1 + ".TargetValue", StringUtils.FromDouble(item1.TargetValue.Value));
                            }
                            index1++;
                        }
                    }
                }
                if (publicRequest.PredictiveScalingConfiguration.IsSetMode())
                {
                    request.Parameters.Add("PredictiveScalingConfiguration" + ".Mode", StringUtils.FromString(publicRequest.PredictiveScalingConfiguration.Mode));
                }
                if (publicRequest.PredictiveScalingConfiguration.IsSetSchedulingBufferTime())
                {
                    request.Parameters.Add("PredictiveScalingConfiguration" + ".SchedulingBufferTime", StringUtils.FromInt(publicRequest.PredictiveScalingConfiguration.SchedulingBufferTime.Value));
                }
            }
            if (publicRequest.IsSetScalingAdjustment())
            {
                request.Parameters.Add("ScalingAdjustment", StringUtils.FromInt(publicRequest.ScalingAdjustment.Value));
            }
            if (publicRequest.IsSetStepAdjustments())
            {
                if (publicRequest.StepAdjustments.Count == 0)
                {
                    request.Parameters.Add("StepAdjustments", "");
                }
                else
                {
                    int index0 = 1;
                    foreach (var item0 in publicRequest.StepAdjustments)
                    {
                        if (item0.IsSetMetricIntervalLowerBound())
                        {
                            request.Parameters.Add("StepAdjustments" + ".member" + "." + index0 + ".MetricIntervalLowerBound", StringUtils.FromDouble(item0.MetricIntervalLowerBound.Value));
                        }
                        if (item0.IsSetMetricIntervalUpperBound())
                        {
                            request.Parameters.Add("StepAdjustments" + ".member" + "." + index0 + ".MetricIntervalUpperBound", StringUtils.FromDouble(item0.MetricIntervalUpperBound.Value));
                        }
                        if (item0.IsSetScalingAdjustment())
                        {
                            request.Parameters.Add("StepAdjustments" + ".member" + "." + index0 + ".ScalingAdjustment", StringUtils.FromInt(item0.ScalingAdjustment.Value));
                        }
                        index0++;
                    }
                }
            }
            if (publicRequest.IsSetTargetTrackingConfiguration())
            {
                if (publicRequest.TargetTrackingConfiguration.IsSetCustomizedMetricSpecification())
                {
                    if (publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetDimensions())
                    {
                        if (publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Dimensions.Count == 0)
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Dimensions", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Dimensions)
                            {
                                if (item2.IsSetName())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Dimensions" + ".member" + "." + index2 + ".Name", StringUtils.FromString(item2.Name));
                                }
                                if (item2.IsSetValue())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Dimensions" + ".member" + "." + index2 + ".Value", StringUtils.FromString(item2.Value));
                                }
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetMetricName())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".MetricName", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.MetricName));
                    }
                    if (publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetMetrics())
                    {
                        if (publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Metrics.Count == 0)
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics", "");
                        }
                        else
                        {
                            int index2 = 1;
                            foreach (var item2 in publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Metrics)
                            {
                                if (item2.IsSetExpression())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".Expression", StringUtils.FromString(item2.Expression));
                                }
                                if (item2.IsSetId())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".Id", StringUtils.FromString(item2.Id));
                                }
                                if (item2.IsSetLabel())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".Label", StringUtils.FromString(item2.Label));
                                }
                                if (item2.IsSetMetricStat())
                                {
                                    if (item2.MetricStat.IsSetMetric())
                                    {
                                        if (item2.MetricStat.Metric.IsSetDimensions())
                                        {
                                            if (item2.MetricStat.Metric.Dimensions.Count == 0)
                                            {
                                                request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".MetricStat" + ".Metric" + ".Dimensions", "");
                                            }
                                            else
                                            {
                                                int index5 = 1;
                                                foreach (var item5 in item2.MetricStat.Metric.Dimensions)
                                                {
                                                    if (item5.IsSetName())
                                                    {
                                                        request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".MetricStat" + ".Metric" + ".Dimensions" + ".member" + "." + index5 + ".Name", StringUtils.FromString(item5.Name));
                                                    }
                                                    if (item5.IsSetValue())
                                                    {
                                                        request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".MetricStat" + ".Metric" + ".Dimensions" + ".member" + "." + index5 + ".Value", StringUtils.FromString(item5.Value));
                                                    }
                                                    index5++;
                                                }
                                            }
                                        }
                                        if (item2.MetricStat.Metric.IsSetMetricName())
                                        {
                                            request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".MetricStat" + ".Metric" + ".MetricName", StringUtils.FromString(item2.MetricStat.Metric.MetricName));
                                        }
                                        if (item2.MetricStat.Metric.IsSetNamespace())
                                        {
                                            request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".MetricStat" + ".Metric" + ".Namespace", StringUtils.FromString(item2.MetricStat.Metric.Namespace));
                                        }
                                    }
                                    if (item2.MetricStat.IsSetPeriod())
                                    {
                                        request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".MetricStat" + ".Period", StringUtils.FromInt(item2.MetricStat.Period.Value));
                                    }
                                    if (item2.MetricStat.IsSetStat())
                                    {
                                        request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".MetricStat" + ".Stat", StringUtils.FromString(item2.MetricStat.Stat));
                                    }
                                    if (item2.MetricStat.IsSetUnit())
                                    {
                                        request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".MetricStat" + ".Unit", StringUtils.FromString(item2.MetricStat.Unit));
                                    }
                                }
                                if (item2.IsSetPeriod())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".Period", StringUtils.FromInt(item2.Period.Value));
                                }
                                if (item2.IsSetReturnData())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Metrics" + ".member" + "." + index2 + ".ReturnData", StringUtils.FromBool(item2.ReturnData.Value));
                                }
                                index2++;
                            }
                        }
                    }
                    if (publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetNamespace())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Namespace", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Namespace));
                    }
                    if (publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetPeriod())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Period", StringUtils.FromInt(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Period.Value));
                    }
                    if (publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetStatistic())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Statistic", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Statistic));
                    }
                    if (publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetUnit())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + ".CustomizedMetricSpecification" + ".Unit", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Unit));
                    }
                }
                if (publicRequest.TargetTrackingConfiguration.IsSetDisableScaleIn())
                {
                    request.Parameters.Add("TargetTrackingConfiguration" + ".DisableScaleIn", StringUtils.FromBool(publicRequest.TargetTrackingConfiguration.DisableScaleIn.Value));
                }
                if (publicRequest.TargetTrackingConfiguration.IsSetPredefinedMetricSpecification())
                {
                    if (publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.IsSetPredefinedMetricType())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + ".PredefinedMetricSpecification" + ".PredefinedMetricType", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.PredefinedMetricType));
                    }
                    if (publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.IsSetResourceLabel())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + ".PredefinedMetricSpecification" + ".ResourceLabel", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.ResourceLabel));
                    }
                }
                if (publicRequest.TargetTrackingConfiguration.IsSetTargetValue())
                {
                    request.Parameters.Add("TargetTrackingConfiguration" + ".TargetValue", StringUtils.FromDouble(publicRequest.TargetTrackingConfiguration.TargetValue.Value));
                }
            }

#if !NETFRAMEWORK
            request.ContentStream = Amazon.Util.AWSSDKUtils.WriteParametersToPooledStream(request);
#else
            request.Content = Amazon.Util.AWSSDKUtils.GetRequestPayloadBytes(request);
#endif

            return request;
        }

        private static readonly PutScalingPolicyRequestMarshaller _instance = new();

        internal static PutScalingPolicyRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PutScalingPolicyRequestMarshaller Instance => _instance;
    }
}
