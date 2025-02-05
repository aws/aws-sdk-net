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
    /// WirelessMetadata Marshaller
    /// </summary>
    public class WirelessMetadataMarshaller : IRequestMarshaller<WirelessMetadata, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WirelessMetadata requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLoRaWAN())
            {
                context.Writer.WritePropertyName("LoRaWAN");
                context.Writer.WriteStartObject();

                var marshaller = LoRaWANSendDataToDeviceMarshaller.Instance;
                marshaller.Marshall(requestObject.LoRaWAN, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSidewalk())
            {
                context.Writer.WritePropertyName("Sidewalk");
                context.Writer.WriteStartObject();

                var marshaller = SidewalkSendDataToDeviceMarshaller.Instance;
                marshaller.Marshall(requestObject.Sidewalk, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WirelessMetadataMarshaller Instance = new WirelessMetadataMarshaller();

    }
}