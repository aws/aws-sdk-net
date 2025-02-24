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
    /// GetSpotPlacementScores Request Marshaller
    /// </summary>       
    public class GetSpotPlacementScoresRequestMarshaller : IMarshaller<IRequest, GetSpotPlacementScoresRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetSpotPlacementScoresRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetSpotPlacementScoresRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "GetSpotPlacementScores");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceRequirementsWithMetadata())
                {
                    if(publicRequest.InstanceRequirementsWithMetadata.IsSetArchitectureTypes())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.ArchitectureTypes.Count == 0)
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "ArchitectureType", "");
                        else
                        {
                             int publicRequestInstanceRequirementsWithMetadatalistValueIndex = 1;
                             foreach(var publicRequestInstanceRequirementsWithMetadatalistValue in publicRequest.InstanceRequirementsWithMetadata.ArchitectureTypes)
                             {
                                 request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "ArchitectureType" + "." + publicRequestInstanceRequirementsWithMetadatalistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementsWithMetadatalistValue));
                                 publicRequestInstanceRequirementsWithMetadatalistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceRequirementsWithMetadata.IsSetInstanceRequirements())
                    {
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAcceleratorCount())
                        {
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorCount.IsSetMax())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorCount.Max));
                            }
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorCount.IsSetMin())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorCount.Min));
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAcceleratorManufacturers())
                        {
                            if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AcceleratorManufacturer", "");
                            else
                            {
                                 int publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex = 1;
                                 foreach(var publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorManufacturers)
                                 {
                                     request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AcceleratorManufacturer" + "." + publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue));
                                     publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex++;
                                 }
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAcceleratorNames())
                        {
                            if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorNames.Count == 0)
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AcceleratorName", "");
                            else
                            {
                                 int publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex = 1;
                                 foreach(var publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorNames)
                                 {
                                     request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AcceleratorName" + "." + publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue));
                                     publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex++;
                                 }
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                        {
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                            }
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAcceleratorTypes())
                        {
                            if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTypes.Count == 0)
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AcceleratorType", "");
                            else
                            {
                                 int publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex = 1;
                                 foreach(var publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AcceleratorTypes)
                                 {
                                     request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AcceleratorType" + "." + publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue));
                                     publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex++;
                                 }
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetAllowedInstanceTypes())
                        {
                            if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AllowedInstanceType", "");
                            else
                            {
                                 int publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex = 1;
                                 foreach(var publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.AllowedInstanceTypes)
                                 {
                                     request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "AllowedInstanceType" + "." + publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue));
                                     publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex++;
                                 }
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetBareMetal())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BareMetal));
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                        {
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                            }
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetBaselinePerformanceFactors())
                        {
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                            {
                                if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                                {
                                    if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                        request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "Reference", "");
                                    else
                                    {
                                         int publicRequestInstanceRequirementsWithMetadataInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex = 1;
                                         foreach(var publicRequestInstanceRequirementsWithMetadataInstanceRequirementsBaselinePerformanceFactorsCpulistValue in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                         {
                                            if(publicRequestInstanceRequirementsWithMetadataInstanceRequirementsBaselinePerformanceFactorsCpulistValue.IsSetInstanceFamily())
                                            {
                                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "Reference" + "." + publicRequestInstanceRequirementsWithMetadataInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex + "." + "InstanceFamily", StringUtils.FromString(publicRequestInstanceRequirementsWithMetadataInstanceRequirementsBaselinePerformanceFactorsCpulistValue.InstanceFamily));
                                            }
                                             publicRequestInstanceRequirementsWithMetadataInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex++;
                                         }
                                    }
                                }
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetBurstablePerformance())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.BurstablePerformance));
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetCpuManufacturers())
                        {
                            if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.CpuManufacturers.Count == 0)
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "CpuManufacturer", "");
                            else
                            {
                                 int publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex = 1;
                                 foreach(var publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.CpuManufacturers)
                                 {
                                     request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "CpuManufacturer" + "." + publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue));
                                     publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex++;
                                 }
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetExcludedInstanceTypes())
                        {
                            if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "ExcludedInstanceType", "");
                            else
                            {
                                 int publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex = 1;
                                 foreach(var publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.ExcludedInstanceTypes)
                                 {
                                     request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "ExcludedInstanceType" + "." + publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue));
                                     publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex++;
                                 }
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetInstanceGenerations())
                        {
                            if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.InstanceGenerations.Count == 0)
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "InstanceGeneration", "");
                            else
                            {
                                 int publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex = 1;
                                 foreach(var publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.InstanceGenerations)
                                 {
                                     request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "InstanceGeneration" + "." + publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue));
                                     publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex++;
                                 }
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetLocalStorage())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.LocalStorage));
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetLocalStorageTypes())
                        {
                            if (publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.LocalStorageTypes.Count == 0)
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "LocalStorageType", "");
                            else
                            {
                                 int publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex = 1;
                                 foreach(var publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue in publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.LocalStorageTypes)
                                 {
                                     request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "LocalStorageType" + "." + publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValue));
                                     publicRequestInstanceRequirementsWithMetadataInstanceRequirementslistValueIndex++;
                                 }
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice));
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                        {
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryGiBPerVCpu.Max));
                            }
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryGiBPerVCpu.Min));
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetMemoryMiB())
                        {
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryMiB.IsSetMax())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryMiB.Max));
                            }
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryMiB.IsSetMin())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.MemoryMiB.Min));
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetNetworkBandwidthGbps())
                        {
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkBandwidthGbps.Max));
                            }
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkBandwidthGbps.Min));
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetNetworkInterfaceCount())
                        {
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkInterfaceCount.Max));
                            }
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.NetworkInterfaceCount.Min));
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetRequireHibernateSupport())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.RequireHibernateSupport));
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                        {
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetTotalLocalStorageGB())
                        {
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.TotalLocalStorageGB.Max));
                            }
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.TotalLocalStorageGB.Min));
                            }
                        }
                        if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.IsSetVCpuCount())
                        {
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.VCpuCount.IsSetMax())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.VCpuCount.Max));
                            }
                            if(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.VCpuCount.IsSetMin())
                            {
                                request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirementsWithMetadata.InstanceRequirements.VCpuCount.Min));
                            }
                        }
                    }
                    if(publicRequest.InstanceRequirementsWithMetadata.IsSetVirtualizationTypes())
                    {
                        if (publicRequest.InstanceRequirementsWithMetadata.VirtualizationTypes.Count == 0)
                            request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "VirtualizationType", "");
                        else
                        {
                             int publicRequestInstanceRequirementsWithMetadatalistValueIndex = 1;
                             foreach(var publicRequestInstanceRequirementsWithMetadatalistValue in publicRequest.InstanceRequirementsWithMetadata.VirtualizationTypes)
                             {
                                 request.Parameters.Add("InstanceRequirementsWithMetadata" + "." + "VirtualizationType" + "." + publicRequestInstanceRequirementsWithMetadatalistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementsWithMetadatalistValue));
                                 publicRequestInstanceRequirementsWithMetadatalistValueIndex++;
                             }
                        }
                    }
                }
                if(publicRequest.IsSetInstanceTypes())
                {
                    if (publicRequest.InstanceTypes.Count == 0)
                        request.Parameters.Add("InstanceType", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.InstanceTypes)
                         {
                             request.Parameters.Add("InstanceType" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetMaxResults())
                {
                    request.Parameters.Add("MaxResults", StringUtils.FromInt(publicRequest.MaxResults));
                }
                if(publicRequest.IsSetNextToken())
                {
                    request.Parameters.Add("NextToken", StringUtils.FromString(publicRequest.NextToken));
                }
                if(publicRequest.IsSetRegionNames())
                {
                    if (publicRequest.RegionNames.Count == 0)
                        request.Parameters.Add("RegionName", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RegionNames)
                         {
                             request.Parameters.Add("RegionName" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSingleAvailabilityZone())
                {
                    request.Parameters.Add("SingleAvailabilityZone", StringUtils.FromBool(publicRequest.SingleAvailabilityZone));
                }
                if(publicRequest.IsSetTargetCapacity())
                {
                    request.Parameters.Add("TargetCapacity", StringUtils.FromInt(publicRequest.TargetCapacity));
                }
                if(publicRequest.IsSetTargetCapacityUnitType())
                {
                    request.Parameters.Add("TargetCapacityUnitType", StringUtils.FromString(publicRequest.TargetCapacityUnitType));
                }
            }
            return request;
        }
                    private static GetSpotPlacementScoresRequestMarshaller _instance = new GetSpotPlacementScoresRequestMarshaller();        

        internal static GetSpotPlacementScoresRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSpotPlacementScoresRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}