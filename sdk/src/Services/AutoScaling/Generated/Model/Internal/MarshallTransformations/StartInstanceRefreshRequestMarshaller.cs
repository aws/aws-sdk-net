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
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartInstanceRefresh Request Marshaller
    /// </summary>       
    public class StartInstanceRefreshRequestMarshaller : IMarshaller<IRequest, StartInstanceRefreshRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartInstanceRefreshRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartInstanceRefreshRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AutoScaling");
            request.Parameters.Add("Action", "StartInstanceRefresh");
            request.Parameters.Add("Version", "2011-01-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAutoScalingGroupName())
                {
                    request.Parameters.Add("AutoScalingGroupName", StringUtils.FromString(publicRequest.AutoScalingGroupName));
                }
                if(publicRequest.IsSetDesiredConfiguration())
                {
                    if(publicRequest.DesiredConfiguration.IsSetLaunchTemplate())
                    {
                        if(publicRequest.DesiredConfiguration.LaunchTemplate.IsSetLaunchTemplateId())
                        {
                            request.Parameters.Add("DesiredConfiguration" + "." + "LaunchTemplate" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequest.DesiredConfiguration.LaunchTemplate.LaunchTemplateId));
                        }
                        if(publicRequest.DesiredConfiguration.LaunchTemplate.IsSetLaunchTemplateName())
                        {
                            request.Parameters.Add("DesiredConfiguration" + "." + "LaunchTemplate" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequest.DesiredConfiguration.LaunchTemplate.LaunchTemplateName));
                        }
                        if(publicRequest.DesiredConfiguration.LaunchTemplate.IsSetVersion())
                        {
                            request.Parameters.Add("DesiredConfiguration" + "." + "LaunchTemplate" + "." + "Version", StringUtils.FromString(publicRequest.DesiredConfiguration.LaunchTemplate.Version));
                        }
                    }
                    if(publicRequest.DesiredConfiguration.IsSetMixedInstancesPolicy())
                    {
                        if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.IsSetInstancesDistribution())
                        {
                            if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandAllocationStrategy())
                            {
                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "OnDemandAllocationStrategy", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.OnDemandAllocationStrategy));
                            }
                            if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandBaseCapacity())
                            {
                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "OnDemandBaseCapacity", StringUtils.FromInt(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.OnDemandBaseCapacity));
                            }
                            if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetOnDemandPercentageAboveBaseCapacity())
                            {
                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "OnDemandPercentageAboveBaseCapacity", StringUtils.FromInt(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.OnDemandPercentageAboveBaseCapacity));
                            }
                            if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetSpotAllocationStrategy())
                            {
                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "SpotAllocationStrategy", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.SpotAllocationStrategy));
                            }
                            if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetSpotInstancePools())
                            {
                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "SpotInstancePools", StringUtils.FromInt(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.SpotInstancePools));
                            }
                            if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.IsSetSpotMaxPrice())
                            {
                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "InstancesDistribution" + "." + "SpotMaxPrice", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.InstancesDistribution.SpotMaxPrice));
                            }
                        }
                        if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.IsSetLaunchTemplate())
                        {
                            if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.IsSetLaunchTemplateSpecification())
                            {
                                if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                                {
                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.LaunchTemplateId));
                                }
                                if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                                {
                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.LaunchTemplateName));
                                }
                                if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.IsSetVersion())
                                {
                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.LaunchTemplateSpecification.Version));
                                }
                            }
                            if(publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.IsSetOverrides())
                            {
                                int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex = 1;
                                foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue in publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.Overrides)
                                {
                                    if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.IsSetInstanceType())
                                    {
                                        request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceType));
                                    }
                                    if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.IsSetLaunchTemplateSpecification())
                                    {
                                        if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.LaunchTemplateId));
                                        }
                                        if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.LaunchTemplateName));
                                        }
                                        if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.IsSetVersion())
                                        {
                                            request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.LaunchTemplateSpecification.Version));
                                        }
                                    }
                                    if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.IsSetWeightedCapacity())
                                    {
                                        request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "WeightedCapacity", StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.WeightedCapacity));
                                    }
                                    publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex++;
                                }
                            }
                        }
                    }
                }
                if(publicRequest.IsSetPreferences())
                {
                    if(publicRequest.Preferences.IsSetCheckpointDelay())
                    {
                        request.Parameters.Add("Preferences" + "." + "CheckpointDelay", StringUtils.FromInt(publicRequest.Preferences.CheckpointDelay));
                    }
                    if(publicRequest.Preferences.IsSetCheckpointPercentages())
                    {
                        int publicRequestPreferenceslistValueIndex = 1;
                        foreach(var publicRequestPreferenceslistValue in publicRequest.Preferences.CheckpointPercentages)
                        {
                            request.Parameters.Add("Preferences" + "." + "CheckpointPercentages" + "." + "member" + "." + publicRequestPreferenceslistValueIndex, StringUtils.FromInt(publicRequestPreferenceslistValue));
                            publicRequestPreferenceslistValueIndex++;
                        }
                    }
                    if(publicRequest.Preferences.IsSetInstanceWarmup())
                    {
                        request.Parameters.Add("Preferences" + "." + "InstanceWarmup", StringUtils.FromInt(publicRequest.Preferences.InstanceWarmup));
                    }
                    if(publicRequest.Preferences.IsSetMinHealthyPercentage())
                    {
                        request.Parameters.Add("Preferences" + "." + "MinHealthyPercentage", StringUtils.FromInt(publicRequest.Preferences.MinHealthyPercentage));
                    }
                    if(publicRequest.Preferences.IsSetSkipMatching())
                    {
                        request.Parameters.Add("Preferences" + "." + "SkipMatching", StringUtils.FromBool(publicRequest.Preferences.SkipMatching));
                    }
                }
                if(publicRequest.IsSetStrategy())
                {
                    request.Parameters.Add("Strategy", StringUtils.FromString(publicRequest.Strategy));
                }
            }
            return request;
        }
                    private static StartInstanceRefreshRequestMarshaller _instance = new StartInstanceRefreshRequestMarshaller();        

        internal static StartInstanceRefreshRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartInstanceRefreshRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}