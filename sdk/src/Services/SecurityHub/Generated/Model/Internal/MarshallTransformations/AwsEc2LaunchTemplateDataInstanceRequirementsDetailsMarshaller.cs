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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEc2LaunchTemplateDataInstanceRequirementsDetails Marshaller
    /// </summary>
    public class AwsEc2LaunchTemplateDataInstanceRequirementsDetailsMarshaller : IRequestMarshaller<AwsEc2LaunchTemplateDataInstanceRequirementsDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEc2LaunchTemplateDataInstanceRequirementsDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAcceleratorCount())
            {
                context.Writer.WritePropertyName("AcceleratorCount");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorCountDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AcceleratorCount, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAcceleratorManufacturers())
            {
                context.Writer.WritePropertyName("AcceleratorManufacturers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAcceleratorManufacturersListValue in requestObject.AcceleratorManufacturers)
                {
                        context.Writer.Write(requestObjectAcceleratorManufacturersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAcceleratorNames())
            {
                context.Writer.WritePropertyName("AcceleratorNames");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAcceleratorNamesListValue in requestObject.AcceleratorNames)
                {
                        context.Writer.Write(requestObjectAcceleratorNamesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAcceleratorTotalMemoryMiB())
            {
                context.Writer.WritePropertyName("AcceleratorTotalMemoryMiB");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorTotalMemoryMiBDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AcceleratorTotalMemoryMiB, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAcceleratorTypes())
            {
                context.Writer.WritePropertyName("AcceleratorTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAcceleratorTypesListValue in requestObject.AcceleratorTypes)
                {
                        context.Writer.Write(requestObjectAcceleratorTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBareMetal())
            {
                context.Writer.WritePropertyName("BareMetal");
                context.Writer.Write(requestObject.BareMetal);
            }

            if(requestObject.IsSetBaselineEbsBandwidthMbps())
            {
                context.Writer.WritePropertyName("BaselineEbsBandwidthMbps");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsBaselineEbsBandwidthMbpsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.BaselineEbsBandwidthMbps, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBurstablePerformance())
            {
                context.Writer.WritePropertyName("BurstablePerformance");
                context.Writer.Write(requestObject.BurstablePerformance);
            }

            if(requestObject.IsSetCpuManufacturers())
            {
                context.Writer.WritePropertyName("CpuManufacturers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCpuManufacturersListValue in requestObject.CpuManufacturers)
                {
                        context.Writer.Write(requestObjectCpuManufacturersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExcludedInstanceTypes())
            {
                context.Writer.WritePropertyName("ExcludedInstanceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExcludedInstanceTypesListValue in requestObject.ExcludedInstanceTypes)
                {
                        context.Writer.Write(requestObjectExcludedInstanceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInstanceGenerations())
            {
                context.Writer.WritePropertyName("InstanceGenerations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInstanceGenerationsListValue in requestObject.InstanceGenerations)
                {
                        context.Writer.Write(requestObjectInstanceGenerationsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLocalStorage())
            {
                context.Writer.WritePropertyName("LocalStorage");
                context.Writer.Write(requestObject.LocalStorage);
            }

            if(requestObject.IsSetLocalStorageTypes())
            {
                context.Writer.WritePropertyName("LocalStorageTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLocalStorageTypesListValue in requestObject.LocalStorageTypes)
                {
                        context.Writer.Write(requestObjectLocalStorageTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMemoryGiBPerVCpu())
            {
                context.Writer.WritePropertyName("MemoryGiBPerVCpu");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryGiBPerVCpu, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMemoryMiB())
            {
                context.Writer.WritePropertyName("MemoryMiB");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsMemoryMiBDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryMiB, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNetworkInterfaceCount())
            {
                context.Writer.WritePropertyName("NetworkInterfaceCount");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsNetworkInterfaceCountDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkInterfaceCount, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOnDemandMaxPricePercentageOverLowestPrice())
            {
                context.Writer.WritePropertyName("OnDemandMaxPricePercentageOverLowestPrice");
                context.Writer.Write(requestObject.OnDemandMaxPricePercentageOverLowestPrice);
            }

            if(requestObject.IsSetRequireHibernateSupport())
            {
                context.Writer.WritePropertyName("RequireHibernateSupport");
                context.Writer.Write(requestObject.RequireHibernateSupport);
            }

            if(requestObject.IsSetSpotMaxPricePercentageOverLowestPrice())
            {
                context.Writer.WritePropertyName("SpotMaxPricePercentageOverLowestPrice");
                context.Writer.Write(requestObject.SpotMaxPricePercentageOverLowestPrice);
            }

            if(requestObject.IsSetTotalLocalStorageGB())
            {
                context.Writer.WritePropertyName("TotalLocalStorageGB");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsTotalLocalStorageGBDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.TotalLocalStorageGB, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVCpuCount())
            {
                context.Writer.WritePropertyName("VCpuCount");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsVCpuCountDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.VCpuCount, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2LaunchTemplateDataInstanceRequirementsDetailsMarshaller Instance = new AwsEc2LaunchTemplateDataInstanceRequirementsDetailsMarshaller();

    }
}