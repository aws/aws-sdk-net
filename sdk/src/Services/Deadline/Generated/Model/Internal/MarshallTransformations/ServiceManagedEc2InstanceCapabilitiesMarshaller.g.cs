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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.Deadline.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServiceManagedEc2InstanceCapabilities Marshaller
    /// </summary>
    public partial class ServiceManagedEc2InstanceCapabilitiesMarshaller : IRequestMarshaller<ServiceManagedEc2InstanceCapabilities, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(ServiceManagedEc2InstanceCapabilities requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetAcceleratorCapabilities())
            {
                context.Writer.WritePropertyName("acceleratorCapabilities");
                context.Writer.WriteStartObject();

                var marshaller = AcceleratorCapabilitiesMarshaller.Instance;
                marshaller.Marshall(requestObject.AcceleratorCapabilities, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetAllowedInstanceTypes())
            {
                context.Writer.WritePropertyName("allowedInstanceTypes");
                context.Writer.WriteStartArray();
                foreach (var requestObjectAllowedInstanceTypesListValue in requestObject.AllowedInstanceTypes)
                {
                    context.Writer.WriteStringValue(requestObjectAllowedInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetCpuArchitectureType())
            {
                context.Writer.WritePropertyName("cpuArchitectureType");
                context.Writer.WriteStringValue(requestObject.CpuArchitectureType);
            }

            if (requestObject.IsSetCustomAmounts())
            {
                context.Writer.WritePropertyName("customAmounts");
                context.Writer.WriteStartArray();
                foreach (var requestObjectCustomAmountsListValue in requestObject.CustomAmounts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FleetAmountCapabilityMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomAmountsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetCustomAttributes())
            {
                context.Writer.WritePropertyName("customAttributes");
                context.Writer.WriteStartArray();
                foreach (var requestObjectCustomAttributesListValue in requestObject.CustomAttributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FleetAttributeCapabilityMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetExcludedInstanceTypes())
            {
                context.Writer.WritePropertyName("excludedInstanceTypes");
                context.Writer.WriteStartArray();
                foreach (var requestObjectExcludedInstanceTypesListValue in requestObject.ExcludedInstanceTypes)
                {
                    context.Writer.WriteStringValue(requestObjectExcludedInstanceTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetMemoryMiB())
            {
                context.Writer.WritePropertyName("memoryMiB");
                context.Writer.WriteStartObject();

                var marshaller = MemoryMiBRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.MemoryMiB, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetOsFamily())
            {
                context.Writer.WritePropertyName("osFamily");
                context.Writer.WriteStringValue(requestObject.OsFamily);
            }

            if (requestObject.IsSetRootEbsVolume())
            {
                context.Writer.WritePropertyName("rootEbsVolume");
                context.Writer.WriteStartObject();

                var marshaller = Ec2EbsVolumeMarshaller.Instance;
                marshaller.Marshall(requestObject.RootEbsVolume, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetSoftwareAddOns())
            {
                context.Writer.WritePropertyName("softwareAddOns");
                context.Writer.WriteStartArray();
                foreach (var requestObjectSoftwareAddOnsListValue in requestObject.SoftwareAddOns)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FleetSoftwareAddOnMarshaller.Instance;
                    marshaller.Marshall(requestObjectSoftwareAddOnsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if (requestObject.IsSetVCpuCount())
            {
                context.Writer.WritePropertyName("vCpuCount");
                context.Writer.WriteStartObject();

                var marshaller = VCpuCountRangeMarshaller.Instance;
                marshaller.Marshall(requestObject.VCpuCount, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static ServiceManagedEc2InstanceCapabilitiesMarshaller Instance = new ServiceManagedEc2InstanceCapabilitiesMarshaller();
    }
}
