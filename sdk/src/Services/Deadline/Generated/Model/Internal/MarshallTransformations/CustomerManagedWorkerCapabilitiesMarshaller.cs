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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CustomerManagedWorkerCapabilities Marshaller
    /// </summary>
    public class CustomerManagedWorkerCapabilitiesMarshaller : IRequestMarshaller<CustomerManagedWorkerCapabilities, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CustomerManagedWorkerCapabilities requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAcceleratorCount())
            {
                context.Writer.WritePropertyName("acceleratorCount");
                context.Writer.WriteStartObject();

                var marshaller = AcceleratorCountRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.AcceleratorCount, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAcceleratorTotalMemoryMiB())
            {
                context.Writer.WritePropertyName("acceleratorTotalMemoryMiB");
                context.Writer.WriteStartObject();

                var marshaller = AcceleratorTotalMemoryMiBRangeMarshaller.Instance;
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

            if(requestObject.IsSetCpuArchitectureType())
            {
                context.Writer.WritePropertyName("cpuArchitectureType");
                context.Writer.WriteStringValue(requestObject.CpuArchitectureType);
            }

            if(requestObject.IsSetCustomAmounts())
            {
                context.Writer.WritePropertyName("customAmounts");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomAmountsListValue in requestObject.CustomAmounts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FleetAmountCapabilityMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomAmountsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCustomAttributes())
            {
                context.Writer.WritePropertyName("customAttributes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomAttributesListValue in requestObject.CustomAttributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FleetAttributeCapabilityMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMemoryMiB())
            {
                context.Writer.WritePropertyName("memoryMiB");
                context.Writer.WriteStartObject();

                var marshaller = MemoryMiBRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryMiB, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOsFamily())
            {
                context.Writer.WritePropertyName("osFamily");
                context.Writer.WriteStringValue(requestObject.OsFamily);
            }

            if(requestObject.IsSetVCpuCount())
            {
                context.Writer.WritePropertyName("vCpuCount");
                context.Writer.WriteStartObject();

                var marshaller = VCpuCountRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.VCpuCount, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CustomerManagedWorkerCapabilitiesMarshaller Instance = new CustomerManagedWorkerCapabilitiesMarshaller();

    }
}