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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifySpotFleetRequest Request Marshaller
    /// </summary>       
    public class ModifySpotFleetRequestRequestMarshaller : IMarshaller<IRequest, ModifySpotFleetRequestRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifySpotFleetRequestRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifySpotFleetRequestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "ModifySpotFleetRequest");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetContext())
                {
                    request.Parameters.Add("Context", StringUtils.FromString(publicRequest.Context));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetExcessCapacityTerminationPolicy())
                {
                    request.Parameters.Add("ExcessCapacityTerminationPolicy", StringUtils.FromString(publicRequest.ExcessCapacityTerminationPolicy));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetLaunchTemplateConfigs())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.LaunchTemplateConfigs)
                    {
                        if(publicRequestlistValue.IsSetLaunchTemplateSpecification())
                        {
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetLaunchTemplateId())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateName));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetVersion())
                            {
                                request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.Version));
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetOverrides())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Overrides)
                            {
                                if(publicRequestlistValuelistValue.IsSetAvailabilityZone())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.AvailabilityZone));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetInstanceRequirements())
                                {
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorCount())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorManufacturers())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorManufacturers)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturerSet" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorNames())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorNames)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorNameSet" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTypeSet" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAllowedInstanceTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AllowedInstanceTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceTypeSet" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBareMetal())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.BareMetal));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBurstablePerformance())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.BurstablePerformance));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetCpuManufacturers())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.CpuManufacturers)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturerSet" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetExcludedInstanceTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.ExcludedInstanceTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceTypeSet" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetInstanceGenerations())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.InstanceGenerations)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGenerationSet" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetLocalStorage())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.LocalStorage));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetLocalStorageTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.LocalStorageTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageTypeSet" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMemoryMiB())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetNetworkInterfaceCount())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetRequireHibernateSupport())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequestlistValuelistValue.InstanceRequirements.RequireHibernateSupport));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetTotalLocalStorageGB())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetVCpuCount())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetInstanceType())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestlistValuelistValue.InstanceType));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetPriority())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Priority", StringUtils.FromDouble(publicRequestlistValuelistValue.Priority));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetSpotPrice())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "SpotPrice", StringUtils.FromString(publicRequestlistValuelistValue.SpotPrice));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetSubnetId())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValuelistValue.SubnetId));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetWeightedCapacity())
                                {
                                    request.Parameters.Add("LaunchTemplateConfig" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "WeightedCapacity", StringUtils.FromDouble(publicRequestlistValuelistValue.WeightedCapacity));
                                }
#pragma warning restore CS0612,CS0618
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
#pragma warning restore CS0612,CS0618
                        publicRequestlistValueIndex++;
                    }
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetOnDemandTargetCapacity())
                {
                    request.Parameters.Add("OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.OnDemandTargetCapacity));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSpotFleetRequestId())
                {
                    request.Parameters.Add("SpotFleetRequestId", StringUtils.FromString(publicRequest.SpotFleetRequestId));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTargetCapacity())
                {
                    request.Parameters.Add("TargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacity));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static ModifySpotFleetRequestRequestMarshaller _instance = new ModifySpotFleetRequestRequestMarshaller();        

        internal static ModifySpotFleetRequestRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifySpotFleetRequestRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}