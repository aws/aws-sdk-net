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
    /// GetInstanceTypesFromInstanceRequirements Request Marshaller
    /// </summary>       
    public class GetInstanceTypesFromInstanceRequirementsRequestMarshaller : IMarshaller<IRequest, GetInstanceTypesFromInstanceRequirementsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetInstanceTypesFromInstanceRequirementsRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetInstanceTypesFromInstanceRequirementsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EC2");
            request.Parameters.Add("Action", "GetInstanceTypesFromInstanceRequirements");
            request.Parameters.Add("Version", "2016-11-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetArchitectureTypes())
                {
                    if (publicRequest.ArchitectureTypes.Count == 0)
                        request.Parameters.Add("ArchitectureType", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ArchitectureTypes)
                         {
                             request.Parameters.Add("ArchitectureType" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetContext())
                {
                    request.Parameters.Add("Context", StringUtils.FromString(publicRequest.Context));
                }
                if(publicRequest.IsSetDryRun())
                {
                    request.Parameters.Add("DryRun", StringUtils.FromBool(publicRequest.DryRun));
                }
                if(publicRequest.IsSetInstanceRequirements())
                {
                    if(publicRequest.InstanceRequirements.IsSetAcceleratorCount())
                    {
                        if(publicRequest.InstanceRequirements.AcceleratorCount.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "AcceleratorCount" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirements.AcceleratorCount.Max));
                        }
                        if(publicRequest.InstanceRequirements.AcceleratorCount.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "AcceleratorCount" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirements.AcceleratorCount.Min));
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetAcceleratorManufacturers())
                    {
                        if (publicRequest.InstanceRequirements.AcceleratorManufacturers.Count == 0)
                            request.Parameters.Add("InstanceRequirements" + "." + "AcceleratorManufacturer", "");
                        else
                        {
                             int publicRequestInstanceRequirementslistValueIndex = 1;
                             foreach(var publicRequestInstanceRequirementslistValue in publicRequest.InstanceRequirements.AcceleratorManufacturers)
                             {
                                 request.Parameters.Add("InstanceRequirements" + "." + "AcceleratorManufacturer" + "." + publicRequestInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementslistValue));
                                 publicRequestInstanceRequirementslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetAcceleratorNames())
                    {
                        if (publicRequest.InstanceRequirements.AcceleratorNames.Count == 0)
                            request.Parameters.Add("InstanceRequirements" + "." + "AcceleratorName", "");
                        else
                        {
                             int publicRequestInstanceRequirementslistValueIndex = 1;
                             foreach(var publicRequestInstanceRequirementslistValue in publicRequest.InstanceRequirements.AcceleratorNames)
                             {
                                 request.Parameters.Add("InstanceRequirements" + "." + "AcceleratorName" + "." + publicRequestInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementslistValue));
                                 publicRequestInstanceRequirementslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetAcceleratorTotalMemoryMiB())
                    {
                        if(publicRequest.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirements.AcceleratorTotalMemoryMiB.Max));
                        }
                        if(publicRequest.InstanceRequirements.AcceleratorTotalMemoryMiB.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "AcceleratorTotalMemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirements.AcceleratorTotalMemoryMiB.Min));
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetAcceleratorTypes())
                    {
                        if (publicRequest.InstanceRequirements.AcceleratorTypes.Count == 0)
                            request.Parameters.Add("InstanceRequirements" + "." + "AcceleratorType", "");
                        else
                        {
                             int publicRequestInstanceRequirementslistValueIndex = 1;
                             foreach(var publicRequestInstanceRequirementslistValue in publicRequest.InstanceRequirements.AcceleratorTypes)
                             {
                                 request.Parameters.Add("InstanceRequirements" + "." + "AcceleratorType" + "." + publicRequestInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementslistValue));
                                 publicRequestInstanceRequirementslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetAllowedInstanceTypes())
                    {
                        if (publicRequest.InstanceRequirements.AllowedInstanceTypes.Count == 0)
                            request.Parameters.Add("InstanceRequirements" + "." + "AllowedInstanceType", "");
                        else
                        {
                             int publicRequestInstanceRequirementslistValueIndex = 1;
                             foreach(var publicRequestInstanceRequirementslistValue in publicRequest.InstanceRequirements.AllowedInstanceTypes)
                             {
                                 request.Parameters.Add("InstanceRequirements" + "." + "AllowedInstanceType" + "." + publicRequestInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementslistValue));
                                 publicRequestInstanceRequirementslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetBareMetal())
                    {
                        request.Parameters.Add("InstanceRequirements" + "." + "BareMetal", StringUtils.FromString(publicRequest.InstanceRequirements.BareMetal));
                    }
                    if(publicRequest.InstanceRequirements.IsSetBaselineEbsBandwidthMbps())
                    {
                        if(publicRequest.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirements.BaselineEbsBandwidthMbps.Max));
                        }
                        if(publicRequest.InstanceRequirements.BaselineEbsBandwidthMbps.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "BaselineEbsBandwidthMbps" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirements.BaselineEbsBandwidthMbps.Min));
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetBaselinePerformanceFactors())
                    {
                        if(publicRequest.InstanceRequirements.BaselinePerformanceFactors.IsSetCpu())
                        {
                            if(publicRequest.InstanceRequirements.BaselinePerformanceFactors.Cpu.IsSetReferences())
                            {
                                if (publicRequest.InstanceRequirements.BaselinePerformanceFactors.Cpu.References.Count == 0)
                                    request.Parameters.Add("InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "Reference", "");
                                else
                                {
                                     int publicRequestInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex = 1;
                                     foreach(var publicRequestInstanceRequirementsBaselinePerformanceFactorsCpulistValue in publicRequest.InstanceRequirements.BaselinePerformanceFactors.Cpu.References)
                                     {
                                        if(publicRequestInstanceRequirementsBaselinePerformanceFactorsCpulistValue.IsSetInstanceFamily())
                                        {
                                            request.Parameters.Add("InstanceRequirements" + "." + "BaselinePerformanceFactors" + "." + "Cpu" + "." + "Reference" + "." + publicRequestInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex + "." + "InstanceFamily", StringUtils.FromString(publicRequestInstanceRequirementsBaselinePerformanceFactorsCpulistValue.InstanceFamily));
                                        }
                                         publicRequestInstanceRequirementsBaselinePerformanceFactorsCpulistValueIndex++;
                                     }
                                }
                            }
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetBurstablePerformance())
                    {
                        request.Parameters.Add("InstanceRequirements" + "." + "BurstablePerformance", StringUtils.FromString(publicRequest.InstanceRequirements.BurstablePerformance));
                    }
                    if(publicRequest.InstanceRequirements.IsSetCpuManufacturers())
                    {
                        if (publicRequest.InstanceRequirements.CpuManufacturers.Count == 0)
                            request.Parameters.Add("InstanceRequirements" + "." + "CpuManufacturer", "");
                        else
                        {
                             int publicRequestInstanceRequirementslistValueIndex = 1;
                             foreach(var publicRequestInstanceRequirementslistValue in publicRequest.InstanceRequirements.CpuManufacturers)
                             {
                                 request.Parameters.Add("InstanceRequirements" + "." + "CpuManufacturer" + "." + publicRequestInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementslistValue));
                                 publicRequestInstanceRequirementslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetExcludedInstanceTypes())
                    {
                        if (publicRequest.InstanceRequirements.ExcludedInstanceTypes.Count == 0)
                            request.Parameters.Add("InstanceRequirements" + "." + "ExcludedInstanceType", "");
                        else
                        {
                             int publicRequestInstanceRequirementslistValueIndex = 1;
                             foreach(var publicRequestInstanceRequirementslistValue in publicRequest.InstanceRequirements.ExcludedInstanceTypes)
                             {
                                 request.Parameters.Add("InstanceRequirements" + "." + "ExcludedInstanceType" + "." + publicRequestInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementslistValue));
                                 publicRequestInstanceRequirementslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetInstanceGenerations())
                    {
                        if (publicRequest.InstanceRequirements.InstanceGenerations.Count == 0)
                            request.Parameters.Add("InstanceRequirements" + "." + "InstanceGeneration", "");
                        else
                        {
                             int publicRequestInstanceRequirementslistValueIndex = 1;
                             foreach(var publicRequestInstanceRequirementslistValue in publicRequest.InstanceRequirements.InstanceGenerations)
                             {
                                 request.Parameters.Add("InstanceRequirements" + "." + "InstanceGeneration" + "." + publicRequestInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementslistValue));
                                 publicRequestInstanceRequirementslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetLocalStorage())
                    {
                        request.Parameters.Add("InstanceRequirements" + "." + "LocalStorage", StringUtils.FromString(publicRequest.InstanceRequirements.LocalStorage));
                    }
                    if(publicRequest.InstanceRequirements.IsSetLocalStorageTypes())
                    {
                        if (publicRequest.InstanceRequirements.LocalStorageTypes.Count == 0)
                            request.Parameters.Add("InstanceRequirements" + "." + "LocalStorageType", "");
                        else
                        {
                             int publicRequestInstanceRequirementslistValueIndex = 1;
                             foreach(var publicRequestInstanceRequirementslistValue in publicRequest.InstanceRequirements.LocalStorageTypes)
                             {
                                 request.Parameters.Add("InstanceRequirements" + "." + "LocalStorageType" + "." + publicRequestInstanceRequirementslistValueIndex, StringUtils.FromString(publicRequestInstanceRequirementslistValue));
                                 publicRequestInstanceRequirementslistValueIndex++;
                             }
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
                    {
                        request.Parameters.Add("InstanceRequirements" + "." + "MaxSpotPriceAsPercentageOfOptimalOnDemandPrice", StringUtils.FromInt(publicRequest.InstanceRequirements.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice));
                    }
                    if(publicRequest.InstanceRequirements.IsSetMemoryGiBPerVCpu())
                    {
                        if(publicRequest.InstanceRequirements.MemoryGiBPerVCpu.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Max", StringUtils.FromDouble(publicRequest.InstanceRequirements.MemoryGiBPerVCpu.Max));
                        }
                        if(publicRequest.InstanceRequirements.MemoryGiBPerVCpu.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "MemoryGiBPerVCpu" + "." + "Min", StringUtils.FromDouble(publicRequest.InstanceRequirements.MemoryGiBPerVCpu.Min));
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetMemoryMiB())
                    {
                        if(publicRequest.InstanceRequirements.MemoryMiB.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "MemoryMiB" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirements.MemoryMiB.Max));
                        }
                        if(publicRequest.InstanceRequirements.MemoryMiB.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "MemoryMiB" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirements.MemoryMiB.Min));
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetNetworkBandwidthGbps())
                    {
                        if(publicRequest.InstanceRequirements.NetworkBandwidthGbps.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Max", StringUtils.FromDouble(publicRequest.InstanceRequirements.NetworkBandwidthGbps.Max));
                        }
                        if(publicRequest.InstanceRequirements.NetworkBandwidthGbps.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "NetworkBandwidthGbps" + "." + "Min", StringUtils.FromDouble(publicRequest.InstanceRequirements.NetworkBandwidthGbps.Min));
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetNetworkInterfaceCount())
                    {
                        if(publicRequest.InstanceRequirements.NetworkInterfaceCount.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirements.NetworkInterfaceCount.Max));
                        }
                        if(publicRequest.InstanceRequirements.NetworkInterfaceCount.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "NetworkInterfaceCount" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirements.NetworkInterfaceCount.Min));
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetOnDemandMaxPricePercentageOverLowestPrice())
                    {
                        request.Parameters.Add("InstanceRequirements" + "." + "OnDemandMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.InstanceRequirements.OnDemandMaxPricePercentageOverLowestPrice));
                    }
                    if(publicRequest.InstanceRequirements.IsSetRequireHibernateSupport())
                    {
                        request.Parameters.Add("InstanceRequirements" + "." + "RequireHibernateSupport", StringUtils.FromBool(publicRequest.InstanceRequirements.RequireHibernateSupport));
                    }
                    if(publicRequest.InstanceRequirements.IsSetSpotMaxPricePercentageOverLowestPrice())
                    {
                        request.Parameters.Add("InstanceRequirements" + "." + "SpotMaxPricePercentageOverLowestPrice", StringUtils.FromInt(publicRequest.InstanceRequirements.SpotMaxPricePercentageOverLowestPrice));
                    }
                    if(publicRequest.InstanceRequirements.IsSetTotalLocalStorageGB())
                    {
                        if(publicRequest.InstanceRequirements.TotalLocalStorageGB.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Max", StringUtils.FromDouble(publicRequest.InstanceRequirements.TotalLocalStorageGB.Max));
                        }
                        if(publicRequest.InstanceRequirements.TotalLocalStorageGB.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "TotalLocalStorageGB" + "." + "Min", StringUtils.FromDouble(publicRequest.InstanceRequirements.TotalLocalStorageGB.Min));
                        }
                    }
                    if(publicRequest.InstanceRequirements.IsSetVCpuCount())
                    {
                        if(publicRequest.InstanceRequirements.VCpuCount.IsSetMax())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "VCpuCount" + "." + "Max", StringUtils.FromInt(publicRequest.InstanceRequirements.VCpuCount.Max));
                        }
                        if(publicRequest.InstanceRequirements.VCpuCount.IsSetMin())
                        {
                            request.Parameters.Add("InstanceRequirements" + "." + "VCpuCount" + "." + "Min", StringUtils.FromInt(publicRequest.InstanceRequirements.VCpuCount.Min));
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
                if(publicRequest.IsSetVirtualizationTypes())
                {
                    if (publicRequest.VirtualizationTypes.Count == 0)
                        request.Parameters.Add("VirtualizationType", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.VirtualizationTypes)
                         {
                             request.Parameters.Add("VirtualizationType" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static GetInstanceTypesFromInstanceRequirementsRequestMarshaller _instance = new GetInstanceTypesFromInstanceRequirementsRequestMarshaller();        

        internal static GetInstanceTypesFromInstanceRequirementsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetInstanceTypesFromInstanceRequirementsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}