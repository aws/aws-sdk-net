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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutScalingPolicy Request Marshaller
    /// </summary>       
    public class PutScalingPolicyRequestMarshaller : IMarshaller<IRequest, PutScalingPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutScalingPolicyRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutScalingPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "PutScalingPolicy");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAdjustmentType())
                {
                    request.Parameters.Add("AdjustmentType", StringUtils.FromString(publicRequest.AdjustmentType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetAutoScalingGroupName())
                {
                    request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetCooldown())
                {
                    request.Parameters.Add("Cooldown", StringUtils.FromInt(publicRequest.Cooldown));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEnabled())
                {
                    request.Parameters.Add("Enabled", StringUtils.FromBool(publicRequest.Enabled));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetEstimatedInstanceWarmup())
                {
                    request.Parameters.Add("EstimatedInstanceWarmup", StringUtils.FromInt(publicRequest.EstimatedInstanceWarmup));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMetricAggregationType())
                {
                    request.Parameters.Add("MetricAggregationType", StringUtils.FromString(publicRequest.MetricAggregationType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMinAdjustmentMagnitude())
                {
                    request.Parameters.Add("MinAdjustmentMagnitude", StringUtils.FromInt(publicRequest.MinAdjustmentMagnitude));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetMinAdjustmentStep())
                {
                    request.Parameters.Add("MinAdjustmentStep", StringUtils.FromInt(publicRequest.MinAdjustmentStep));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPolicyName())
                {
                    request.Parameters.Add("PolicyName", StringUtils.FromString(publicRequest.PolicyName));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPolicyType())
                {
                    request.Parameters.Add("PolicyType", StringUtils.FromString(publicRequest.PolicyType));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetPredictiveScalingConfiguration())
                {
                    if(publicRequest.PredictiveScalingConfiguration.IsSetMaxCapacityBreachBehavior())
                    {
                        request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MaxCapacityBreachBehavior", StringUtils.FromString(publicRequest.PredictiveScalingConfiguration.MaxCapacityBreachBehavior));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.PredictiveScalingConfiguration.IsSetMaxCapacityBuffer())
                    {
                        request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MaxCapacityBuffer", StringUtils.FromInt(publicRequest.PredictiveScalingConfiguration.MaxCapacityBuffer));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.PredictiveScalingConfiguration.IsSetMetricSpecifications())
                    {
                        int publicRequestPredictiveScalingConfigurationlistValueIndex = 1;
                        foreach(var publicRequestPredictiveScalingConfigurationlistValue in publicRequest.PredictiveScalingConfiguration.MetricSpecifications)
                        {
                            if(publicRequestPredictiveScalingConfigurationlistValue.IsSetCustomizedCapacityMetricSpecification())
                            {
                                if(publicRequestPredictiveScalingConfigurationlistValue.CustomizedCapacityMetricSpecification.IsSetMetricDataQueries())
                                {
                                    int publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex = 1;
                                    foreach(var publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue in publicRequestPredictiveScalingConfigurationlistValue.CustomizedCapacityMetricSpecification.MetricDataQueries)
                                    {
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.IsSetExpression())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedCapacityMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex + "." + "Expression", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.Expression));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.IsSetId())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedCapacityMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.Id));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.IsSetLabel())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedCapacityMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex + "." + "Label", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.Label));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.IsSetMetricStat())
                                        {
                                            if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.IsSetMetric())
                                            {
                                                if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.Metric.IsSetDimensions())
                                                {
                                                    int publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueMetricStatMetriclistValueIndex = 1;
                                                    foreach(var publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueMetricStatMetriclistValue in publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.Metric.Dimensions)
                                                    {
                                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueMetricStatMetriclistValue.IsSetName())
                                                        {
                                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedCapacityMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueMetricStatMetriclistValueIndex + "." + "Name", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueMetricStatMetriclistValue.Name));
                                                        }
#pragma warning restore CS0612,CS0618
                                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueMetricStatMetriclistValue.IsSetValue())
                                                        {
                                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedCapacityMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueMetricStatMetriclistValueIndex + "." + "Value", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueMetricStatMetriclistValue.Value));
                                                        }
#pragma warning restore CS0612,CS0618
                                                        publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueMetricStatMetriclistValueIndex++;
                                                    }
                                                }
#pragma warning restore CS0612,CS0618
                                                if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.Metric.IsSetMetricName())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedCapacityMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "MetricName", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.Metric.MetricName));
                                                }
#pragma warning restore CS0612,CS0618
                                                if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.Metric.IsSetNamespace())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedCapacityMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Namespace", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.Metric.Namespace));
                                                }
#pragma warning restore CS0612,CS0618
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.IsSetStat())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedCapacityMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Stat", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.Stat));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.IsSetUnit())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedCapacityMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Unit", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.MetricStat.Unit));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.IsSetReturnData())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedCapacityMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex + "." + "ReturnData", StringUtils.FromBool(publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValue.ReturnData));
                                        }
#pragma warning restore CS0612,CS0618
                                        publicRequestPredictiveScalingConfigurationlistValueCustomizedCapacityMetricSpecificationlistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestPredictiveScalingConfigurationlistValue.IsSetCustomizedLoadMetricSpecification())
                            {
                                if(publicRequestPredictiveScalingConfigurationlistValue.CustomizedLoadMetricSpecification.IsSetMetricDataQueries())
                                {
                                    int publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex = 1;
                                    foreach(var publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue in publicRequestPredictiveScalingConfigurationlistValue.CustomizedLoadMetricSpecification.MetricDataQueries)
                                    {
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.IsSetExpression())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedLoadMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex + "." + "Expression", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.Expression));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.IsSetId())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedLoadMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.Id));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.IsSetLabel())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedLoadMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex + "." + "Label", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.Label));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.IsSetMetricStat())
                                        {
                                            if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.IsSetMetric())
                                            {
                                                if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.Metric.IsSetDimensions())
                                                {
                                                    int publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueMetricStatMetriclistValueIndex = 1;
                                                    foreach(var publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueMetricStatMetriclistValue in publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.Metric.Dimensions)
                                                    {
                                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueMetricStatMetriclistValue.IsSetName())
                                                        {
                                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedLoadMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueMetricStatMetriclistValueIndex + "." + "Name", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueMetricStatMetriclistValue.Name));
                                                        }
#pragma warning restore CS0612,CS0618
                                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueMetricStatMetriclistValue.IsSetValue())
                                                        {
                                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedLoadMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueMetricStatMetriclistValueIndex + "." + "Value", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueMetricStatMetriclistValue.Value));
                                                        }
#pragma warning restore CS0612,CS0618
                                                        publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueMetricStatMetriclistValueIndex++;
                                                    }
                                                }
#pragma warning restore CS0612,CS0618
                                                if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.Metric.IsSetMetricName())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedLoadMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "MetricName", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.Metric.MetricName));
                                                }
#pragma warning restore CS0612,CS0618
                                                if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.Metric.IsSetNamespace())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedLoadMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Namespace", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.Metric.Namespace));
                                                }
#pragma warning restore CS0612,CS0618
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.IsSetStat())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedLoadMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Stat", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.Stat));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.IsSetUnit())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedLoadMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Unit", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.MetricStat.Unit));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.IsSetReturnData())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedLoadMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex + "." + "ReturnData", StringUtils.FromBool(publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValue.ReturnData));
                                        }
#pragma warning restore CS0612,CS0618
                                        publicRequestPredictiveScalingConfigurationlistValueCustomizedLoadMetricSpecificationlistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestPredictiveScalingConfigurationlistValue.IsSetCustomizedScalingMetricSpecification())
                            {
                                if(publicRequestPredictiveScalingConfigurationlistValue.CustomizedScalingMetricSpecification.IsSetMetricDataQueries())
                                {
                                    int publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex = 1;
                                    foreach(var publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue in publicRequestPredictiveScalingConfigurationlistValue.CustomizedScalingMetricSpecification.MetricDataQueries)
                                    {
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.IsSetExpression())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedScalingMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex + "." + "Expression", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.Expression));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.IsSetId())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedScalingMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.Id));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.IsSetLabel())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedScalingMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex + "." + "Label", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.Label));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.IsSetMetricStat())
                                        {
                                            if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.IsSetMetric())
                                            {
                                                if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.Metric.IsSetDimensions())
                                                {
                                                    int publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueMetricStatMetriclistValueIndex = 1;
                                                    foreach(var publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueMetricStatMetriclistValue in publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.Metric.Dimensions)
                                                    {
                                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueMetricStatMetriclistValue.IsSetName())
                                                        {
                                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedScalingMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueMetricStatMetriclistValueIndex + "." + "Name", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueMetricStatMetriclistValue.Name));
                                                        }
#pragma warning restore CS0612,CS0618
                                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueMetricStatMetriclistValue.IsSetValue())
                                                        {
                                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedScalingMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueMetricStatMetriclistValueIndex + "." + "Value", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueMetricStatMetriclistValue.Value));
                                                        }
#pragma warning restore CS0612,CS0618
                                                        publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueMetricStatMetriclistValueIndex++;
                                                    }
                                                }
#pragma warning restore CS0612,CS0618
                                                if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.Metric.IsSetMetricName())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedScalingMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "MetricName", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.Metric.MetricName));
                                                }
#pragma warning restore CS0612,CS0618
                                                if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.Metric.IsSetNamespace())
                                                {
                                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedScalingMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Namespace", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.Metric.Namespace));
                                                }
#pragma warning restore CS0612,CS0618
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.IsSetStat())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedScalingMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Stat", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.Stat));
                                            }
#pragma warning restore CS0612,CS0618
                                            if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.IsSetUnit())
                                            {
                                                request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedScalingMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Unit", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.MetricStat.Unit));
                                            }
#pragma warning restore CS0612,CS0618
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.IsSetReturnData())
                                        {
                                            request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "CustomizedScalingMetricSpecification" + "." + "MetricDataQueries" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex + "." + "ReturnData", StringUtils.FromBool(publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValue.ReturnData));
                                        }
#pragma warning restore CS0612,CS0618
                                        publicRequestPredictiveScalingConfigurationlistValueCustomizedScalingMetricSpecificationlistValueIndex++;
                                    }
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestPredictiveScalingConfigurationlistValue.IsSetPredefinedLoadMetricSpecification())
                            {
                                if(publicRequestPredictiveScalingConfigurationlistValue.PredefinedLoadMetricSpecification.IsSetPredefinedMetricType())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "PredefinedLoadMetricSpecification" + "." + "PredefinedMetricType", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValue.PredefinedLoadMetricSpecification.PredefinedMetricType));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestPredictiveScalingConfigurationlistValue.PredefinedLoadMetricSpecification.IsSetResourceLabel())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "PredefinedLoadMetricSpecification" + "." + "ResourceLabel", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValue.PredefinedLoadMetricSpecification.ResourceLabel));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestPredictiveScalingConfigurationlistValue.IsSetPredefinedMetricPairSpecification())
                            {
                                if(publicRequestPredictiveScalingConfigurationlistValue.PredefinedMetricPairSpecification.IsSetPredefinedMetricType())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "PredefinedMetricPairSpecification" + "." + "PredefinedMetricType", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValue.PredefinedMetricPairSpecification.PredefinedMetricType));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestPredictiveScalingConfigurationlistValue.PredefinedMetricPairSpecification.IsSetResourceLabel())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "PredefinedMetricPairSpecification" + "." + "ResourceLabel", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValue.PredefinedMetricPairSpecification.ResourceLabel));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestPredictiveScalingConfigurationlistValue.IsSetPredefinedScalingMetricSpecification())
                            {
                                if(publicRequestPredictiveScalingConfigurationlistValue.PredefinedScalingMetricSpecification.IsSetPredefinedMetricType())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "PredefinedScalingMetricSpecification" + "." + "PredefinedMetricType", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValue.PredefinedScalingMetricSpecification.PredefinedMetricType));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestPredictiveScalingConfigurationlistValue.PredefinedScalingMetricSpecification.IsSetResourceLabel())
                                {
                                    request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "PredefinedScalingMetricSpecification" + "." + "ResourceLabel", StringUtils.FromString(publicRequestPredictiveScalingConfigurationlistValue.PredefinedScalingMetricSpecification.ResourceLabel));
                                }
#pragma warning restore CS0612,CS0618
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestPredictiveScalingConfigurationlistValue.IsSetTargetValue())
                            {
                                request.Parameters.Add("PredictiveScalingConfiguration" + "." + "MetricSpecifications" + "." + "member" + "." + publicRequestPredictiveScalingConfigurationlistValueIndex + "." + "TargetValue", StringUtils.FromDouble(publicRequestPredictiveScalingConfigurationlistValue.TargetValue));
                            }
#pragma warning restore CS0612,CS0618
                            publicRequestPredictiveScalingConfigurationlistValueIndex++;
                        }
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.PredictiveScalingConfiguration.IsSetMode())
                    {
                        request.Parameters.Add("PredictiveScalingConfiguration" + "." + "Mode", StringUtils.FromString(publicRequest.PredictiveScalingConfiguration.Mode));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.PredictiveScalingConfiguration.IsSetSchedulingBufferTime())
                    {
                        request.Parameters.Add("PredictiveScalingConfiguration" + "." + "SchedulingBufferTime", StringUtils.FromInt(publicRequest.PredictiveScalingConfiguration.SchedulingBufferTime));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetScalingAdjustment())
                {
                    request.Parameters.Add("ScalingAdjustment", StringUtils.FromInt(publicRequest.ScalingAdjustment));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetStepAdjustments())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.StepAdjustments)
                    {
                        if(publicRequestlistValue.IsSetMetricIntervalLowerBound())
                        {
                            request.Parameters.Add("StepAdjustments" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricIntervalLowerBound", StringUtils.FromDouble(publicRequestlistValue.MetricIntervalLowerBound));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetMetricIntervalUpperBound())
                        {
                            request.Parameters.Add("StepAdjustments" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricIntervalUpperBound", StringUtils.FromDouble(publicRequestlistValue.MetricIntervalUpperBound));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetScalingAdjustment())
                        {
                            request.Parameters.Add("StepAdjustments" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ScalingAdjustment", StringUtils.FromInt(publicRequestlistValue.ScalingAdjustment));
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTargetTrackingConfiguration())
                {
                    if(publicRequest.TargetTrackingConfiguration.IsSetCustomizedMetricSpecification())
                    {
                        if(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetDimensions())
                        {
                            int publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex = 1;
                            foreach(var publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue in publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Dimensions)
                            {
                                if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.IsSetName())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Dimensions" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "Name", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.Name));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Dimensions" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.Value));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetMetricName())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "MetricName", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.MetricName));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetMetrics())
                        {
                            int publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex = 1;
                            foreach(var publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue in publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Metrics)
                            {
                                if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.IsSetExpression())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Metrics" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "Expression", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.Expression));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.IsSetId())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Metrics" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "Id", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.Id));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.IsSetLabel())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Metrics" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "Label", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.Label));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.IsSetMetricStat())
                                {
                                    if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.IsSetMetric())
                                    {
                                        if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.Metric.IsSetDimensions())
                                        {
                                            int publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueMetricStatMetriclistValueIndex = 1;
                                            foreach(var publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueMetricStatMetriclistValue in publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.Metric.Dimensions)
                                            {
                                                if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueMetricStatMetriclistValue.IsSetName())
                                                {
                                                    request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Metrics" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueMetricStatMetriclistValueIndex + "." + "Name", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueMetricStatMetriclistValue.Name));
                                                }
#pragma warning restore CS0612,CS0618
                                                if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueMetricStatMetriclistValue.IsSetValue())
                                                {
                                                    request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Metrics" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Dimensions" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueMetricStatMetriclistValueIndex + "." + "Value", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueMetricStatMetriclistValue.Value));
                                                }
#pragma warning restore CS0612,CS0618
                                                publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueMetricStatMetriclistValueIndex++;
                                            }
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.Metric.IsSetMetricName())
                                        {
                                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Metrics" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "MetricName", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.Metric.MetricName));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.Metric.IsSetNamespace())
                                        {
                                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Metrics" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Metric" + "." + "Namespace", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.Metric.Namespace));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.IsSetStat())
                                    {
                                        request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Metrics" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Stat", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.Stat));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.IsSetUnit())
                                    {
                                        request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Metrics" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "MetricStat" + "." + "Unit", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.MetricStat.Unit));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.IsSetReturnData())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Metrics" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "ReturnData", StringUtils.FromBool(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.ReturnData));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetNamespace())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Namespace", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Namespace));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetStatistic())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Statistic", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Statistic));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetUnit())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Unit", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Unit));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.TargetTrackingConfiguration.IsSetDisableScaleIn())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + "." + "DisableScaleIn", StringUtils.FromBool(publicRequest.TargetTrackingConfiguration.DisableScaleIn));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.TargetTrackingConfiguration.IsSetPredefinedMetricSpecification())
                    {
                        if(publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.IsSetPredefinedMetricType())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "PredefinedMetricSpecification" + "." + "PredefinedMetricType", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.PredefinedMetricType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.IsSetResourceLabel())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "PredefinedMetricSpecification" + "." + "ResourceLabel", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.ResourceLabel));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.TargetTrackingConfiguration.IsSetTargetValue())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + "." + "TargetValue", StringUtils.FromDouble(publicRequest.TargetTrackingConfiguration.TargetValue));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static PutScalingPolicyRequestMarshaller _instance = new PutScalingPolicyRequestMarshaller();        

        internal static PutScalingPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutScalingPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}