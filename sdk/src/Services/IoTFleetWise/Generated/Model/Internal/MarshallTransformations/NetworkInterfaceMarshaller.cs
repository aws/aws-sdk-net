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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NetworkInterface Marshaller
    /// </summary>
    public class NetworkInterfaceMarshaller : IRequestMarshaller<NetworkInterface, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NetworkInterface requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCanInterface())
            {
                context.Writer.WritePropertyName("canInterface");
                context.Writer.WriteStartObject();

                var marshaller = CanInterfaceMarshaller.Instance;
                marshaller.Marshall(requestObject.CanInterface, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomDecodingInterface())
            {
                context.Writer.WritePropertyName("customDecodingInterface");
                context.Writer.WriteStartObject();

                var marshaller = CustomDecodingInterfaceMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomDecodingInterface, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInterfaceId())
            {
                context.Writer.WritePropertyName("interfaceId");
                context.Writer.WriteStringValue(requestObject.InterfaceId);
            }

            if(requestObject.IsSetObdInterface())
            {
                context.Writer.WritePropertyName("obdInterface");
                context.Writer.WriteStartObject();

                var marshaller = ObdInterfaceMarshaller.Instance;
                marshaller.Marshall(requestObject.ObdInterface, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetVehicleMiddleware())
            {
                context.Writer.WritePropertyName("vehicleMiddleware");
                context.Writer.WriteStartObject();

                var marshaller = VehicleMiddlewareMarshaller.Instance;
                marshaller.Marshall(requestObject.VehicleMiddleware, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NetworkInterfaceMarshaller Instance = new NetworkInterfaceMarshaller();

    }
}