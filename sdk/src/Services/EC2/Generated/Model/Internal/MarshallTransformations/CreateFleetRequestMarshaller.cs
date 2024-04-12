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
    /// CreateFleet Request Marshaller
    /// </summary>       
    public class CreateFleetRequestMarshaller : IMarshaller<IRequest, CreateFleetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFleetRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFleetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "CreateFleet");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientToken())
                {
                    request.Parameters.Add("ClientToken", StringUtils.FromString(publicRequest.ClientToken));
                }
#pragma warning restore CS0612,CS0618
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
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateId", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateId));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetLaunchTemplateName())
                            {
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "LaunchTemplateName", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.LaunchTemplateName));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequestlistValue.LaunchTemplateSpecification.IsSetVersion())
                            {
                                request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "LaunchTemplateSpecification" + "." + "Version", StringUtils.FromString(publicRequestlistValue.LaunchTemplateSpecification.Version));
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
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.AvailabilityZone));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetImageId())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "ImageId", StringUtils.FromString(publicRequestlistValuelistValue.ImageId));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetInstanceRequirements())
                                {
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorCount())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorCount.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorManufacturers())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorManufacturers)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorManufacturer" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorNames())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorNames)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorName" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAcceleratorTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AcceleratorTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AcceleratorType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetAllowedInstanceTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.AllowedInstanceTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "AllowedInstanceType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBareMetal())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.BareMetal));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetBurstablePerformance())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.BurstablePerformance));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetCpuManufacturers())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.CpuManufacturers)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "CpuManufacturer" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetExcludedInstanceTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.ExcludedInstanceTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "ExcludedInstanceType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetInstanceGenerations())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.InstanceGenerations)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "InstanceGeneration" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetLocalStorage())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequestlistValuelistValue.InstanceRequirements.LocalStorage));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetLocalStorageTypes())
                                    {
                                        int publicRequestlistValuelistValueInstanceRequirementslistValueIndex = 1;
                                        foreach(var publicRequestlistValuelistValueInstanceRequirementslistValue in publicRequestlistValuelistValue.InstanceRequirements.LocalStorageTypes)
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "LocalStorageType" + "." + publicRequestlistValuelistValueInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestlistValuelistValueInstanceRequirementslistValue));
                                            publicRequestlistValuelistValueInstanceRequirementslistValueIndex++;
                                        }
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.MemoryGiBPerVCpu.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetMemoryMiB())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.MemoryMiB.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetNetworkBandwidthGbps())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.NetworkBandwidthGbps.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetNetworkInterfaceCount())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.NetworkInterfaceCount.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetRequireHibernateSupport())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequestlistValuelistValue.InstanceRequirements.RequireHibernateSupport));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetTotalLocalStorageGB())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequestlistValuelistValue.InstanceRequirements.TotalLocalStorageGB.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.InstanceRequirements.IsSetVCpuCount())
                                    {
                                        if(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.IsSetMax())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.Max));
                                        }
#pragma warning restore CS0612,CS0618
                                        if(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.IsSetMin())
                                        {
                                            request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequestlistValuelistValue.InstanceRequirements.VCpuCount.Min));
                                        }
#pragma warning restore CS0612,CS0618
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetInstanceType())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "InstanceType", StringUtils.FromString(publicRequestlistValuelistValue.InstanceType));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetMaxPrice())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "MaxPrice", StringUtils.FromString(publicRequestlistValuelistValue.MaxPrice));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetPlacement())
                                {
                                    if(publicRequestlistValuelistValue.Placement.IsSetAffinity())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "Affinity", StringUtils.FromString(publicRequestlistValuelistValue.Placement.Affinity));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.Placement.IsSetAvailabilityZone())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "AvailabilityZone", StringUtils.FromString(publicRequestlistValuelistValue.Placement.AvailabilityZone));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.Placement.IsSetGroupId())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "GroupId", StringUtils.FromString(publicRequestlistValuelistValue.Placement.GroupId));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.Placement.IsSetGroupName())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "GroupName", StringUtils.FromString(publicRequestlistValuelistValue.Placement.GroupName));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.Placement.IsSetHostId())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "HostId", StringUtils.FromString(publicRequestlistValuelistValue.Placement.HostId));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.Placement.IsSetHostResourceGroupArn())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "HostResourceGroupArn", StringUtils.FromString(publicRequestlistValuelistValue.Placement.HostResourceGroupArn));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.Placement.IsSetPartitionNumber())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "PartitionNumber", StringUtils.FromInt(publicRequestlistValuelistValue.Placement.PartitionNumber));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.Placement.IsSetSpreadDomain())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "SpreadDomain", StringUtils.FromString(publicRequestlistValuelistValue.Placement.SpreadDomain));
                                    }
#pragma warning restore CS0612,CS0618
                                    if(publicRequestlistValuelistValue.Placement.IsSetTenancy())
                                    {
                                        request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Placement" + "." + "Tenancy", StringUtils.FromString(publicRequestlistValuelistValue.Placement.Tenancy));
                                    }
#pragma warning restore CS0612,CS0618
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetPriority())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "Priority", StringUtils.FromDouble(publicRequestlistValuelistValue.Priority));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetSubnetId())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "SubnetId", StringUtils.FromString(publicRequestlistValuelistValue.SubnetId));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetWeightedCapacity())
                                {
                                    request.Parameters.Add("LaunchTemplateConfigs" + "." + publicRequestlistValueIndex + "." + "Overrides" + "." + publicRequestlistValuelistValueIndex + "." + "WeightedCapacity", StringUtils.FromDouble(publicRequestlistValuelistValue.WeightedCapacity));
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
                if(publicRequest.IsSetOnDemandOptions())
                {
                    if(publicRequest.OnDemandOptions.IsSetAllocationStrategy())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "AllocationStrategy", StringUtils.FromString(publicRequest.OnDemandOptions.AllocationStrategy));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OnDemandOptions.IsSetCapacityReservationOptions())
                    {
                        if(publicRequest.OnDemandOptions.CapacityReservationOptions.IsSetUsageStrategy())
                        {
                            request.Parameters.Add("OnDemandOptions" + "." + "CapacityReservationOptions" + "." + "UsageStrategy", StringUtils.FromString(publicRequest.OnDemandOptions.CapacityReservationOptions.UsageStrategy));
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OnDemandOptions.IsSetMaxTotalPrice())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "MaxTotalPrice", StringUtils.FromString(publicRequest.OnDemandOptions.MaxTotalPrice));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OnDemandOptions.IsSetMinTargetCapacity())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "MinTargetCapacity", StringUtils.FromInt(publicRequest.OnDemandOptions.MinTargetCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OnDemandOptions.IsSetSingleAvailabilityZone())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "SingleAvailabilityZone", StringUtils.FromBool(publicRequest.OnDemandOptions.SingleAvailabilityZone));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.OnDemandOptions.IsSetSingleInstanceType())
                    {
                        request.Parameters.Add("OnDemandOptions" + "." + "SingleInstanceType", StringUtils.FromBool(publicRequest.OnDemandOptions.SingleInstanceType));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetReplaceUnhealthyInstances())
                {
                    request.Parameters.Add("ReplaceUnhealthyInstances", StringUtils.FromBool(publicRequest.ReplaceUnhealthyInstances));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetSpotOptions())
                {
                    if(publicRequest.SpotOptions.IsSetAllocationStrategy())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "AllocationStrategy", StringUtils.FromString(publicRequest.SpotOptions.AllocationStrategy));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotOptions.IsSetInstanceInterruptionBehavior())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "InstanceInterruptionBehavior", StringUtils.FromString(publicRequest.SpotOptions.InstanceInterruptionBehavior));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotOptions.IsSetInstancePoolsToUseCount())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "InstancePoolsToUseCount", StringUtils.FromInt(publicRequest.SpotOptions.InstancePoolsToUseCount));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotOptions.IsSetMaintenanceStrategies())
                    {
                        if(publicRequest.SpotOptions.MaintenanceStrategies.IsSetCapacityRebalance())
                        {
                            if(publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.IsSetReplacementStrategy())
                            {
                                request.Parameters.Add("SpotOptions" + "." + "MaintenanceStrategies" + "." + "CapacityRebalance" + "." + "ReplacementStrategy", StringUtils.FromString(publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.ReplacementStrategy));
                            }
#pragma warning restore CS0612,CS0618
                            if(publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.IsSetTerminationDelay())
                            {
                                request.Parameters.Add("SpotOptions" + "." + "MaintenanceStrategies" + "." + "CapacityRebalance" + "." + "TerminationDelay", StringUtils.FromInt(publicRequest.SpotOptions.MaintenanceStrategies.CapacityRebalance.TerminationDelay));
                            }
#pragma warning restore CS0612,CS0618
                        }
#pragma warning restore CS0612,CS0618
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotOptions.IsSetMaxTotalPrice())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "MaxTotalPrice", StringUtils.FromString(publicRequest.SpotOptions.MaxTotalPrice));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotOptions.IsSetMinTargetCapacity())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "MinTargetCapacity", StringUtils.FromInt(publicRequest.SpotOptions.MinTargetCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotOptions.IsSetSingleAvailabilityZone())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "SingleAvailabilityZone", StringUtils.FromBool(publicRequest.SpotOptions.SingleAvailabilityZone));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.SpotOptions.IsSetSingleInstanceType())
                    {
                        request.Parameters.Add("SpotOptions" + "." + "SingleInstanceType", StringUtils.FromBool(publicRequest.SpotOptions.SingleInstanceType));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTagSpecifications())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.TagSpecifications)
                    {
                        if(publicRequestlistValue.IsSetResourceType())
                        {
                            request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                        }
#pragma warning restore CS0612,CS0618
                        if(publicRequestlistValue.IsSetTags())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Tags)
                            {
                                if(publicRequestlistValuelistValue.IsSetKey())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValuelistValue.Key));
                                }
#pragma warning restore CS0612,CS0618
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("TagSpecification" + "." + publicRequestlistValueIndex + "." + "Tag" + "." + publicRequestlistValuelistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
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
                if(publicRequest.IsSetTargetCapacitySpecification())
                {
                    if(publicRequest.TargetCapacitySpecification.IsSetDefaultTargetCapacityType())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "DefaultTargetCapacityType", StringUtils.FromString(publicRequest.TargetCapacitySpecification.DefaultTargetCapacityType));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.TargetCapacitySpecification.IsSetOnDemandTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "OnDemandTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.OnDemandTargetCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.TargetCapacitySpecification.IsSetSpotTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "SpotTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.SpotTargetCapacity));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.TargetCapacitySpecification.IsSetTargetCapacityUnitType())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "TargetCapacityUnitType", StringUtils.FromString(publicRequest.TargetCapacitySpecification.TargetCapacityUnitType));
                    }
#pragma warning restore CS0612,CS0618
                    if(publicRequest.TargetCapacitySpecification.IsSetTotalTargetCapacity())
                    {
                        request.Parameters.Add("TargetCapacitySpecification" + "." + "TotalTargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacitySpecification.TotalTargetCapacity));
                    }
#pragma warning restore CS0612,CS0618
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetTerminateInstancesWithExpiration())
                {
                    request.Parameters.Add("TerminateInstancesWithExpiration", StringUtils.FromBool(publicRequest.TerminateInstancesWithExpiration));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetType())
                {
                    request.Parameters.Add("Type", StringUtils.FromString(publicRequest.Type));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetValidFromUtc())
                {
                    request.Parameters.Add("ValidFrom", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ValidFromUtc));
                }
#pragma warning restore CS0612,CS0618
                if(publicRequest.IsSetValidUntilUtc())
                {
                    request.Parameters.Add("ValidUntil", StringUtils.FromDateTimeToISO8601WithOptionalMs(publicRequest.ValidUntilUtc));
                }
#pragma warning restore CS0612,CS0618
            }
            return request;
        }
                    private static CreateFleetRequestMarshaller _instance = new CreateFleetRequestMarshaller();        

        internal static CreateFleetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFleetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}