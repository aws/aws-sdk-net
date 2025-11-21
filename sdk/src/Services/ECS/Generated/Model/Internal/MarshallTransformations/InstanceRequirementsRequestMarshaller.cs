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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InstanceRequirementsRequest Marshaller
    /// </summary>
    public class InstanceRequirementsRequestMarshaller : IRequestMarshaller<InstanceRequirementsRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InstanceRequirementsRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcceleratorCount())
            {
                context.Writer.WritePropertyName("acceleratorCount");
                context.Writer.WriteStartObject();

                var marshaller = AcceleratorCountRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.AcceleratorCount, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAcceleratorManufacturers())
            {
                context.Writer.WritePropertyName("acceleratorManufacturers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAcceleratorManufacturersListValue in requestObject.AcceleratorManufacturers)
                {
                        context.Writer.WriteStringValue(requestObjectAcceleratorManufacturersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAcceleratorNames())
            {
                context.Writer.WritePropertyName("acceleratorNames");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAcceleratorNamesListValue in requestObject.AcceleratorNames)
                {
                        context.Writer.WriteStringValue(requestObjectAcceleratorNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAcceleratorTotalMemoryMiB())
            {
                context.Writer.WritePropertyName("acceleratorTotalMemoryMiB");
                context.Writer.WriteStartObject();

                var marshaller = AcceleratorTotalMemoryMiBRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.AcceleratorTotalMemoryMiB, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAcceleratorTypes())
            {
                context.Writer.WritePropertyName("acceleratorTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAcceleratorTypesListValue in requestObject.AcceleratorTypes)
                {
                        context.Writer.WriteStringValue(requestObjectAcceleratorTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAllowedInstanceTypes())
            {
                context.Writer.WritePropertyName("allowedInstanceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowedInstanceTypesListValue in requestObject.AllowedInstanceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectAllowedInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetBareMetal())
            {
                context.Writer.WritePropertyName("bareMetal");
                context.Writer.WriteStringValue(requestObject.BareMetal);
            }

            if(requestObject.IsSetBaselineEbsBandwidthMbps())
            {
                context.Writer.WritePropertyName("baselineEbsBandwidthMbps");
                context.Writer.WriteStartObject();

                var marshaller = BaselineEbsBandwidthMbpsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.BaselineEbsBandwidthMbps, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBurstablePerformance())
            {
                context.Writer.WritePropertyName("burstablePerformance");
                context.Writer.WriteStringValue(requestObject.BurstablePerformance);
            }

            if(requestObject.IsSetCpuManufacturers())
            {
                context.Writer.WritePropertyName("cpuManufacturers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCpuManufacturersListValue in requestObject.CpuManufacturers)
                {
                        context.Writer.WriteStringValue(requestObjectCpuManufacturersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExcludedInstanceTypes())
            {
                context.Writer.WritePropertyName("excludedInstanceTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExcludedInstanceTypesListValue in requestObject.ExcludedInstanceTypes)
                {
                        context.Writer.WriteStringValue(requestObjectExcludedInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetInstanceGenerations())
            {
                context.Writer.WritePropertyName("instanceGenerations");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInstanceGenerationsListValue in requestObject.InstanceGenerations)
                {
                        context.Writer.WriteStringValue(requestObjectInstanceGenerationsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLocalStorage())
            {
                context.Writer.WritePropertyName("localStorage");
                context.Writer.WriteStringValue(requestObject.LocalStorage);
            }

            if(requestObject.IsSetLocalStorageTypes())
            {
                context.Writer.WritePropertyName("localStorageTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLocalStorageTypesListValue in requestObject.LocalStorageTypes)
                {
                        context.Writer.WriteStringValue(requestObjectLocalStorageTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
            {
                context.Writer.WritePropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice");
                context.Writer.WriteNumberValue(requestObject.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice.Value);
            }

            if(requestObject.IsSetMemoryGiBPerVCpu())
            {
                context.Writer.WritePropertyName("memoryGiBPerVCpu");
                context.Writer.WriteStartObject();

                var marshaller = MemoryGiBPerVCpuRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryGiBPerVCpu, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMemoryMiB())
            {
                context.Writer.WritePropertyName("memoryMiB");
                context.Writer.WriteStartObject();

                var marshaller = MemoryMiBRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryMiB, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNetworkBandwidthGbps())
            {
                context.Writer.WritePropertyName("networkBandwidthGbps");
                context.Writer.WriteStartObject();

                var marshaller = NetworkBandwidthGbpsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkBandwidthGbps, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetNetworkInterfaceCount())
            {
                context.Writer.WritePropertyName("networkInterfaceCount");
                context.Writer.WriteStartObject();

                var marshaller = NetworkInterfaceCountRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkInterfaceCount, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOnDemandMaxPricePercentageOverLowestPrice())
            {
                context.Writer.WritePropertyName("onDemandMaxPricePercentageOverLowestPrice");
                context.Writer.WriteNumberValue(requestObject.OnDemandMaxPricePercentageOverLowestPrice.Value);
            }

            if(requestObject.IsSetRequireHibernateSupport())
            {
                context.Writer.WritePropertyName("requireHibernateSupport");
                context.Writer.WriteBooleanValue(requestObject.RequireHibernateSupport.Value);
            }

            if(requestObject.IsSetSpotMaxPricePercentageOverLowestPrice())
            {
                context.Writer.WritePropertyName("spotMaxPricePercentageOverLowestPrice");
                context.Writer.WriteNumberValue(requestObject.SpotMaxPricePercentageOverLowestPrice.Value);
            }

            if(requestObject.IsSetTotalLocalStorageGB())
            {
                context.Writer.WritePropertyName("totalLocalStorageGB");
                context.Writer.WriteStartObject();

                var marshaller = TotalLocalStorageGBRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.TotalLocalStorageGB, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVCpuCount())
            {
                context.Writer.WritePropertyName("vCpuCount");
                context.Writer.WriteStartObject();

                var marshaller = VCpuCountRangeRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.VCpuCount, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceRequirementsRequestMarshaller Instance = new InstanceRequirementsRequestMarshaller();

    }
}