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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteObjectStart();

                var marshaller = AcceleratorCountRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.AcceleratorCount, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAcceleratorManufacturers())
            {
                context.Writer.WritePropertyName("acceleratorManufacturers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAcceleratorManufacturersListValue in requestObject.AcceleratorManufacturers)
                {
                        context.Writer.Write(requestObjectAcceleratorManufacturersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAcceleratorNames())
            {
                context.Writer.WritePropertyName("acceleratorNames");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAcceleratorNamesListValue in requestObject.AcceleratorNames)
                {
                        context.Writer.Write(requestObjectAcceleratorNamesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAcceleratorTotalMemoryMiB())
            {
                context.Writer.WritePropertyName("acceleratorTotalMemoryMiB");
                context.Writer.WriteObjectStart();

                var marshaller = AcceleratorTotalMemoryMiBRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.AcceleratorTotalMemoryMiB, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAcceleratorTypes())
            {
                context.Writer.WritePropertyName("acceleratorTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAcceleratorTypesListValue in requestObject.AcceleratorTypes)
                {
                        context.Writer.Write(requestObjectAcceleratorTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAllowedInstanceTypes())
            {
                context.Writer.WritePropertyName("allowedInstanceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAllowedInstanceTypesListValue in requestObject.AllowedInstanceTypes)
                {
                        context.Writer.Write(requestObjectAllowedInstanceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetBareMetal())
            {
                context.Writer.WritePropertyName("bareMetal");
                context.Writer.Write(requestObject.BareMetal);
            }

            if(requestObject.IsSetBaselineEbsBandwidthMbps())
            {
                context.Writer.WritePropertyName("baselineEbsBandwidthMbps");
                context.Writer.WriteObjectStart();

                var marshaller = BaselineEbsBandwidthMbpsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.BaselineEbsBandwidthMbps, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetBurstablePerformance())
            {
                context.Writer.WritePropertyName("burstablePerformance");
                context.Writer.Write(requestObject.BurstablePerformance);
            }

            if(requestObject.IsSetCpuManufacturers())
            {
                context.Writer.WritePropertyName("cpuManufacturers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCpuManufacturersListValue in requestObject.CpuManufacturers)
                {
                        context.Writer.Write(requestObjectCpuManufacturersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExcludedInstanceTypes())
            {
                context.Writer.WritePropertyName("excludedInstanceTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExcludedInstanceTypesListValue in requestObject.ExcludedInstanceTypes)
                {
                        context.Writer.Write(requestObjectExcludedInstanceTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInstanceGenerations())
            {
                context.Writer.WritePropertyName("instanceGenerations");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInstanceGenerationsListValue in requestObject.InstanceGenerations)
                {
                        context.Writer.Write(requestObjectInstanceGenerationsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLocalStorage())
            {
                context.Writer.WritePropertyName("localStorage");
                context.Writer.Write(requestObject.LocalStorage);
            }

            if(requestObject.IsSetLocalStorageTypes())
            {
                context.Writer.WritePropertyName("localStorageTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLocalStorageTypesListValue in requestObject.LocalStorageTypes)
                {
                        context.Writer.Write(requestObjectLocalStorageTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMaxSpotPriceAsPercentageOfOptimalOnDemandPrice())
            {
                context.Writer.WritePropertyName("maxSpotPriceAsPercentageOfOptimalOnDemandPrice");
                context.Writer.Write(requestObject.MaxSpotPriceAsPercentageOfOptimalOnDemandPrice);
            }

            if(requestObject.IsSetMemoryGiBPerVCpu())
            {
                context.Writer.WritePropertyName("memoryGiBPerVCpu");
                context.Writer.WriteObjectStart();

                var marshaller = MemoryGiBPerVCpuRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryGiBPerVCpu, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMemoryMiB())
            {
                context.Writer.WritePropertyName("memoryMiB");
                context.Writer.WriteObjectStart();

                var marshaller = MemoryMiBRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryMiB, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNetworkBandwidthGbps())
            {
                context.Writer.WritePropertyName("networkBandwidthGbps");
                context.Writer.WriteObjectStart();

                var marshaller = NetworkBandwidthGbpsRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkBandwidthGbps, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNetworkInterfaceCount())
            {
                context.Writer.WritePropertyName("networkInterfaceCount");
                context.Writer.WriteObjectStart();

                var marshaller = NetworkInterfaceCountRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkInterfaceCount, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOnDemandMaxPricePercentageOverLowestPrice())
            {
                context.Writer.WritePropertyName("onDemandMaxPricePercentageOverLowestPrice");
                context.Writer.Write(requestObject.OnDemandMaxPricePercentageOverLowestPrice);
            }

            if(requestObject.IsSetRequireHibernateSupport())
            {
                context.Writer.WritePropertyName("requireHibernateSupport");
                context.Writer.Write(requestObject.RequireHibernateSupport);
            }

            if(requestObject.IsSetSpotMaxPricePercentageOverLowestPrice())
            {
                context.Writer.WritePropertyName("spotMaxPricePercentageOverLowestPrice");
                context.Writer.Write(requestObject.SpotMaxPricePercentageOverLowestPrice);
            }

            if(requestObject.IsSetTotalLocalStorageGB())
            {
                context.Writer.WritePropertyName("totalLocalStorageGB");
                context.Writer.WriteObjectStart();

                var marshaller = TotalLocalStorageGBRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.TotalLocalStorageGB, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVCpuCount())
            {
                context.Writer.WritePropertyName("vCpuCount");
                context.Writer.WriteObjectStart();

                var marshaller = VCpuCountRangeRequestMarshaller.Instance;
                marshaller.Marshall(requestObject.VCpuCount, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InstanceRequirementsRequestMarshaller Instance = new InstanceRequirementsRequestMarshaller();

    }
}