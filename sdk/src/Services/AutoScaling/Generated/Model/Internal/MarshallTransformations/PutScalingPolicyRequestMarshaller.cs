/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
                if(publicRequest.IsSetAutoScalingGroupName())
                {
                    request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
                }
                if(publicRequest.IsSetCooldown())
                {
                    request.Parameters.Add("Cooldown", StringUtils.FromInt(publicRequest.Cooldown));
                }
                if(publicRequest.IsSetEstimatedInstanceWarmup())
                {
                    request.Parameters.Add("EstimatedInstanceWarmup", StringUtils.FromInt(publicRequest.EstimatedInstanceWarmup));
                }
                if(publicRequest.IsSetMetricAggregationType())
                {
                    request.Parameters.Add("MetricAggregationType", StringUtils.FromString(publicRequest.MetricAggregationType));
                }
                if(publicRequest.IsSetMinAdjustmentMagnitude())
                {
                    request.Parameters.Add("MinAdjustmentMagnitude", StringUtils.FromInt(publicRequest.MinAdjustmentMagnitude));
                }
                if(publicRequest.IsSetMinAdjustmentStep())
                {
                    request.Parameters.Add("MinAdjustmentStep", StringUtils.FromInt(publicRequest.MinAdjustmentStep));
                }
                if(publicRequest.IsSetPolicyName())
                {
                    request.Parameters.Add("PolicyName", StringUtils.FromString(publicRequest.PolicyName));
                }
                if(publicRequest.IsSetPolicyType())
                {
                    request.Parameters.Add("PolicyType", StringUtils.FromString(publicRequest.PolicyType));
                }
                if(publicRequest.IsSetScalingAdjustment())
                {
                    request.Parameters.Add("ScalingAdjustment", StringUtils.FromInt(publicRequest.ScalingAdjustment));
                }
                if(publicRequest.IsSetStepAdjustments())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.StepAdjustments)
                    {
                        if(publicRequestlistValue.IsSetMetricIntervalLowerBound())
                        {
                            request.Parameters.Add("StepAdjustments" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricIntervalLowerBound", StringUtils.FromDouble(publicRequestlistValue.MetricIntervalLowerBound));
                        }
                        if(publicRequestlistValue.IsSetMetricIntervalUpperBound())
                        {
                            request.Parameters.Add("StepAdjustments" + "." + "member" + "." + publicRequestlistValueIndex + "." + "MetricIntervalUpperBound", StringUtils.FromDouble(publicRequestlistValue.MetricIntervalUpperBound));
                        }
                        if(publicRequestlistValue.IsSetScalingAdjustment())
                        {
                            request.Parameters.Add("StepAdjustments" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ScalingAdjustment", StringUtils.FromInt(publicRequestlistValue.ScalingAdjustment));
                        }
                        publicRequestlistValueIndex++;
                    }
                }
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
                                if(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Dimensions" + "." + "member" + "." + publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValue.Value));
                                }
                                publicRequestTargetTrackingConfigurationCustomizedMetricSpecificationlistValueIndex++;
                            }
                        }
                        if(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetMetricName())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "MetricName", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.MetricName));
                        }
                        if(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetNamespace())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Namespace", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Namespace));
                        }
                        if(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetStatistic())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Statistic", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Statistic));
                        }
                        if(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.IsSetUnit())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "CustomizedMetricSpecification" + "." + "Unit", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.CustomizedMetricSpecification.Unit));
                        }
                    }
                    if(publicRequest.TargetTrackingConfiguration.IsSetDisableScaleIn())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + "." + "DisableScaleIn", StringUtils.FromBool(publicRequest.TargetTrackingConfiguration.DisableScaleIn));
                    }
                    if(publicRequest.TargetTrackingConfiguration.IsSetPredefinedMetricSpecification())
                    {
                        if(publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.IsSetPredefinedMetricType())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "PredefinedMetricSpecification" + "." + "PredefinedMetricType", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.PredefinedMetricType));
                        }
                        if(publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.IsSetResourceLabel())
                        {
                            request.Parameters.Add("TargetTrackingConfiguration" + "." + "PredefinedMetricSpecification" + "." + "ResourceLabel", StringUtils.FromString(publicRequest.TargetTrackingConfiguration.PredefinedMetricSpecification.ResourceLabel));
                        }
                    }
                    if(publicRequest.TargetTrackingConfiguration.IsSetTargetValue())
                    {
                        request.Parameters.Add("TargetTrackingConfiguration" + "." + "TargetValue", StringUtils.FromDouble(publicRequest.TargetTrackingConfiguration.TargetValue));
                    }
                }
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