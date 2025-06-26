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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Device Marshaller
    /// </summary>
    public class DeviceMarshaller : IRequestMarshaller<Device, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Device requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCapabilityReport())
            {
                context.Writer.WritePropertyName("CapabilityReport");
                context.Writer.WriteObjectStart();

                var marshaller = MatterCapabilityReportMarshaller.Instance;
                marshaller.Marshall(requestObject.CapabilityReport, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCapabilitySchemas())
            {
                context.Writer.WritePropertyName("CapabilitySchemas");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCapabilitySchemasListValue in requestObject.CapabilitySchemas)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CapabilitySchemaItemMarshaller.Instance;
                    marshaller.Marshall(requestObjectCapabilitySchemasListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetConnectorDeviceId())
            {
                context.Writer.WritePropertyName("ConnectorDeviceId");
                context.Writer.Write(requestObject.ConnectorDeviceId);
            }

            if(requestObject.IsSetConnectorDeviceName())
            {
                context.Writer.WritePropertyName("ConnectorDeviceName");
                context.Writer.Write(requestObject.ConnectorDeviceName);
            }

            if(requestObject.IsSetDeviceMetadata())
            {
                context.Writer.WritePropertyName("DeviceMetadata");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.DeviceMetadata);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DeviceMarshaller Instance = new DeviceMarshaller();

    }
}