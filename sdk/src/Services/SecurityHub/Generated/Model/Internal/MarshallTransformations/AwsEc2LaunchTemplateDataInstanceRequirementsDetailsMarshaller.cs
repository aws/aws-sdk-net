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
#pragma warning disable CS0612,CS0618
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
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcceleratorCount())
            {
                context.Writer.WritePropertyName("AcceleratorCount");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorCountDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AcceleratorCount, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAcceleratorManufacturers())
            {
                context.Writer.WritePropertyName("AcceleratorManufacturers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAcceleratorManufacturersListValue in requestObject.AcceleratorManufacturers)
                {
                        context.Writer.WriteStringValue(requestObjectAcceleratorManufacturersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAcceleratorNames())
            {
                context.Writer.WritePropertyName("AcceleratorNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAcceleratorNamesListValue in requestObject.AcceleratorNames)
                {
                        context.Writer.WriteStringValue(requestObjectAcceleratorNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAcceleratorTotalMemoryMiB())
            {
                context.Writer.WritePropertyName("AcceleratorTotalMemoryMiB");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsAcceleratorTotalMemoryMiBDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.AcceleratorTotalMemoryMiB, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAcceleratorTypes())
            {
                context.Writer.WritePropertyName("AcceleratorTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAcceleratorTypesListValue in requestObject.AcceleratorTypes)
                {
                        context.Writer.WriteStringValue(requestObjectAcceleratorTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBareMetal())
            {
                context.Writer.WritePropertyName("BareMetal");
                context.Writer.WriteStringValue(requestObject.BareMetal);
            }

            if(requestObject.IsSetBaselineEbsBandwidthMbps())
            {
                context.Writer.WritePropertyName("BaselineEbsBandwidthMbps");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsBaselineEbsBandwidthMbpsDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.BaselineEbsBandwidthMbps, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBurstablePerformance())
            {
                context.Writer.WritePropertyName("BurstablePerformance");
                context.Writer.WriteStringValue(requestObject.BurstablePerformance);
            }

            if(requestObject.IsSetCpuManufacturers())
            {
                context.Writer.WritePropertyName("CpuManufacturers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCpuManufacturersListValue in requestObject.CpuManufacturers)
                {
                        context.Writer.WriteStringValue(requestObjectCpuManufacturersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExcludedInstanceTypes())
            {
                context.Writer.WritePropertyName("ExcludedInstanceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludedInstanceTypesListValue in requestObject.ExcludedInstanceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectExcludedInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInstanceGenerations())
            {
                context.Writer.WritePropertyName("InstanceGenerations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceGenerationsListValue in requestObject.InstanceGenerations)
                {
                        context.Writer.WriteStringValue(requestObjectInstanceGenerationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLocalStorage())
            {
                context.Writer.WritePropertyName("LocalStorage");
                context.Writer.WriteStringValue(requestObject.LocalStorage);
            }

            if(requestObject.IsSetLocalStorageTypes())
            {
                context.Writer.WritePropertyName("LocalStorageTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLocalStorageTypesListValue in requestObject.LocalStorageTypes)
                {
                        context.Writer.WriteStringValue(requestObjectLocalStorageTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMemoryGiBPerVCpu())
            {
                context.Writer.WritePropertyName("MemoryGiBPerVCpu");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsMemoryGiBPerVCpuDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryGiBPerVCpu, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMemoryMiB())
            {
                context.Writer.WritePropertyName("MemoryMiB");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsMemoryMiBDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryMiB, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNetworkInterfaceCount())
            {
                context.Writer.WritePropertyName("NetworkInterfaceCount");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsNetworkInterfaceCountDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkInterfaceCount, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOnDemandMaxPricePercentageOverLowestPrice())
            {
                context.Writer.WritePropertyName("OnDemandMaxPricePercentageOverLowestPrice");
                context.Writer.WriteNumberValue(requestObject.OnDemandMaxPricePercentageOverLowestPrice.Value);
            }

            if(requestObject.IsSetRequireHibernateSupport())
            {
                context.Writer.WritePropertyName("RequireHibernateSupport");
                context.Writer.WriteBooleanValue(requestObject.RequireHibernateSupport.Value);
            }

            if(requestObject.IsSetSpotMaxPricePercentageOverLowestPrice())
            {
                context.Writer.WritePropertyName("SpotMaxPricePercentageOverLowestPrice");
                context.Writer.WriteNumberValue(requestObject.SpotMaxPricePercentageOverLowestPrice.Value);
            }

            if(requestObject.IsSetTotalLocalStorageGB())
            {
                context.Writer.WritePropertyName("TotalLocalStorageGB");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsTotalLocalStorageGBDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.TotalLocalStorageGB, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVCpuCount())
            {
                context.Writer.WritePropertyName("VCpuCount");
                context.Writer.WriteStartObject();

                var marshaller = AwsEc2LaunchTemplateDataInstanceRequirementsVCpuCountDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.VCpuCount, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEc2LaunchTemplateDataInstanceRequirementsDetailsMarshaller Instance = new AwsEc2LaunchTemplateDataInstanceRequirementsDetailsMarshaller();

    }
}