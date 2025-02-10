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
                                if (publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.Overrides.Count == 0)
                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides", "");
                                else
                                {
                                     int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex = 1;
                                     foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue in publicRequest.DesiredConfiguration.MixedInstancesPolicy.LaunchTemplate.Overrides)
                                     {
                                        if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.IsSetInstanceRequirements())
                                        {
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAcceleratorCount())
                                            {
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorCount.IsSetMax())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorCount.Max));
                                                }
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorCount.IsSetMin())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorCount.Min));
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAcceleratorManufacturers())
                                            {
                                                if (publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturers", "");
                                                else
                                                {
                                                     int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorManufacturers)
                                                     {
                                                         request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturers" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                                         publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAcceleratorNames())
                                            {
                                                if (publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorNames.Count == 0)
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorNames", "");
                                                else
                                                {
                                                     int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorNames)
                                                     {
                                                         request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorNames" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                                         publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                            {
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                                                }
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAcceleratorTypes())
                                            {
                                                if (publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTypes.Count == 0)
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTypes", "");
                                                else
                                                {
                                                     int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AcceleratorTypes)
                                                     {
                                                         request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTypes" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                                         publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetAllowedInstanceTypes())
                                            {
                                                if (publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceTypes", "");
                                                else
                                                {
                                                     int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.AllowedInstanceTypes)
                                                     {
                                                         request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceTypes" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                                         publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetBareMetal())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BareMetal));
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                            {
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                                                }
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetBaselinePerformanceFactors())
                                            {
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                                                {
                                                    if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                                                    {
                                                        if (publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                                            request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "Reference", "");
                                                        else
                                                        {
                                                             int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex = 1;
                                                             foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue in publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                                             {
                                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue.IsSetInstanceFamily())
                                                                {
                                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "Reference" + "." + "item" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex + "." + "InstanceFamily", StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValue.InstanceFamily));
                                                                }
                                                                 publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex++;
                                                             }
                                                        }
                                                    }
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetBurstablePerformance())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.BurstablePerformance));
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetCpuManufacturers())
                                            {
                                                if (publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.CpuManufacturers.Count == 0)
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturers", "");
                                                else
                                                {
                                                     int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.CpuManufacturers)
                                                     {
                                                         request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturers" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                                         publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetExcludedInstanceTypes())
                                            {
                                                if (publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceTypes", "");
                                                else
                                                {
                                                     int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.ExcludedInstanceTypes)
                                                     {
                                                         request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceTypes" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                                         publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetInstanceGenerations())
                                            {
                                                if (publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.InstanceGenerations.Count == 0)
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGenerations", "");
                                                else
                                                {
                                                     int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.InstanceGenerations)
                                                     {
                                                         request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGenerations" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                                         publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetLocalStorage())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.LocalStorage));
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetLocalStorageTypes())
                                            {
                                                if (publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.LocalStorageTypes.Count == 0)
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageTypes", "");
                                                else
                                                {
                                                     int publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex = 1;
                                                     foreach(var publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue in publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.LocalStorageTypes)
                                                     {
                                                         request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageTypes" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValue));
                                                         publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueInstanceRequirementslistValueIndex++;
                                                     }
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice));
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                            {
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryGiBPerVCpu.Max));
                                                }
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryGiBPerVCpu.Min));
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetMemoryMiB())
                                            {
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryMiB.IsSetMax())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryMiB.Max));
                                                }
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryMiB.IsSetMin())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.MemoryMiB.Min));
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                            {
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkBandwidthGbps.Max));
                                                }
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkBandwidthGbps.Min));
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetNetworkInterfaceCount())
                                            {
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkInterfaceCount.Max));
                                                }
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.NetworkInterfaceCount.Min));
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetRequireHibernateSupport())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.RequireHibernateSupport));
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                            {
                                                request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetTotalLocalStorageGB())
                                            {
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.TotalLocalStorageGB.Max));
                                                }
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.TotalLocalStorageGB.Min));
                                                }
                                            }
                                            if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.IsSetVCpuCount())
                                            {
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.VCpuCount.IsSetMax())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.VCpuCount.Max));
                                                }
                                                if(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.VCpuCount.IsSetMin())
                                                {
                                                    request.Parameters.Add("DesiredConfiguration" + "." + "MixedInstancesPolicy" + "." + "LaunchTemplate" + "." + "Overrides" + "." + "member" + "." + publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequestDesiredConfigurationMixedInstancesPolicyLaunchTemplatelistValue.InstanceRequirements.VCpuCount.Min));
                                                }
                                            }
                                        }
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
                }
                if(publicRequest.IsSetPreferences())
                {
                    if(publicRequest.Preferences.IsSetAlarmSpecification())
                    {
                        if(publicRequest.Preferences.AlarmSpecification.IsSetAlarms())
                        {
                            if (publicRequest.Preferences.AlarmSpecification.Alarms.Count == 0)
                                request.Parameters.Add("Preferences" + "." + "AlarmSpecification" + "." + "Alarms", "");
                            else
                            {
                                 int publicRequestPreferencesAlarmSpecificationlistValueIndex = 1;
                                 foreach(var publicRequestPreferencesAlarmSpecificationlistValue in publicRequest.Preferences.AlarmSpecification.Alarms)
                                 {
                                     request.Parameters.Add("Preferences" + "." + "AlarmSpecification" + "." + "Alarms" + "." + "member" + "." + publicRequestPreferencesAlarmSpecificationlistValueIndex, StringUtils.FromString(publicRequestPreferencesAlarmSpecificationlistValue));
                                     publicRequestPreferencesAlarmSpecificationlistValueIndex++;
                                 }
                            }
                        }
                    }
                    if(publicRequest.Preferences.IsSetAutoRollback())
                    {
                        request.Parameters.Add("Preferences" + "." + "AutoRollback", StringUtils.FromBool(publicRequest.Preferences.AutoRollback));
                    }
                    if(publicRequest.Preferences.IsSetBakeTime())
                    {
                        request.Parameters.Add("Preferences" + "." + "BakeTime", StringUtils.FromInt(publicRequest.Preferences.BakeTime));
                    }
                    if(publicRequest.Preferences.IsSetCheckpointDelay())
                    {
                        request.Parameters.Add("Preferences" + "." + "CheckpointDelay", StringUtils.FromInt(publicRequest.Preferences.CheckpointDelay));
                    }
                    if(publicRequest.Preferences.IsSetCheckpointPercentages())
                    {
                        if (publicRequest.Preferences.CheckpointPercentages.Count == 0)
                            request.Parameters.Add("Preferences" + "." + "CheckpointPercentages", "");
                        else
                        {
                             int publicRequestPreferenceslistValueIndex = 1;
                             foreach(var publicRequestPreferenceslistValue in publicRequest.Preferences.CheckpointPercentages)
                             {
                                 request.Parameters.Add("Preferences" + "." + "CheckpointPercentages" + "." + "member" + "." + publicRequestPreferenceslistValueIndex, StringUtils.FromInt(publicRequestPreferenceslistValue));
                                 publicRequestPreferenceslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.Preferences.IsSetInstanceWarmup())
                    {
                        request.Parameters.Add("Preferences" + "." + "InstanceWarmup", StringUtils.FromInt(publicRequest.Preferences.InstanceWarmup));
                    }
                    if(publicRequest.Preferences.IsSetMaxHealthyPercentage())
                    {
                        request.Parameters.Add("Preferences" + "." + "MaxHealthyPercentage", StringUtils.FromInt(publicRequest.Preferences.MaxHealthyPercentage));
                    }
                    if(publicRequest.Preferences.IsSetMinHealthyPercentage())
                    {
                        request.Parameters.Add("Preferences" + "." + "MinHealthyPercentage", StringUtils.FromInt(publicRequest.Preferences.MinHealthyPercentage));
                    }
                    if(publicRequest.Preferences.IsSetScaleInProtectedInstances())
                    {
                        request.Parameters.Add("Preferences" + "." + "ScaleInProtectedInstances", StringUtils.FromString(publicRequest.Preferences.ScaleInProtectedInstances));
                    }
                    if(publicRequest.Preferences.IsSetSkipMatching())
                    {
                        request.Parameters.Add("Preferences" + "." + "SkipMatching", StringUtils.FromBool(publicRequest.Preferences.SkipMatching));
                    }
                    if(publicRequest.Preferences.IsSetStandbyInstances())
                    {
                        request.Parameters.Add("Preferences" + "." + "StandbyInstances", StringUtils.FromString(publicRequest.Preferences.StandbyInstances));
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