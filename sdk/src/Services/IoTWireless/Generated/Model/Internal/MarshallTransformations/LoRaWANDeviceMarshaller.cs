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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoRaWANDevice Marshaller
    /// </summary>
    public class LoRaWANDeviceMarshaller : IRequestMarshaller<LoRaWANDevice, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoRaWANDevice requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAbpV1_0_x())
            {
                context.Writer.WritePropertyName("AbpV1_0_x");
                context.Writer.WriteStartObject();

                var marshaller = AbpV1_0_xMarshaller.Instance;
                marshaller.Marshall(requestObject.AbpV1_0_x, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAbpV1_1())
            {
                context.Writer.WritePropertyName("AbpV1_1");
                context.Writer.WriteStartObject();

                var marshaller = AbpV1_1Marshaller.Instance;
                marshaller.Marshall(requestObject.AbpV1_1, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDevEui())
            {
                context.Writer.WritePropertyName("DevEui");
                context.Writer.WriteStringValue(requestObject.DevEui);
            }

            if(requestObject.IsSetDeviceProfileId())
            {
                context.Writer.WritePropertyName("DeviceProfileId");
                context.Writer.WriteStringValue(requestObject.DeviceProfileId);
            }

            if(requestObject.IsSetFPorts())
            {
                context.Writer.WritePropertyName("FPorts");
                context.Writer.WriteStartObject();

                var marshaller = FPortsMarshaller.Instance;
                marshaller.Marshall(requestObject.FPorts, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOtaaV1_0_x())
            {
                context.Writer.WritePropertyName("OtaaV1_0_x");
                context.Writer.WriteStartObject();

                var marshaller = OtaaV1_0_xMarshaller.Instance;
                marshaller.Marshall(requestObject.OtaaV1_0_x, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOtaaV1_1())
            {
                context.Writer.WritePropertyName("OtaaV1_1");
                context.Writer.WriteStartObject();

                var marshaller = OtaaV1_1Marshaller.Instance;
                marshaller.Marshall(requestObject.OtaaV1_1, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServiceProfileId())
            {
                context.Writer.WritePropertyName("ServiceProfileId");
                context.Writer.WriteStringValue(requestObject.ServiceProfileId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LoRaWANDeviceMarshaller Instance = new LoRaWANDeviceMarshaller();

    }
}