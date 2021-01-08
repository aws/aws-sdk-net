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
using ThirdParty.Json.LitJson;

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoRaWANUpdateGatewayTaskCreate Marshaller
    /// </summary>       
    public class LoRaWANUpdateGatewayTaskCreateMarshaller : IRequestMarshaller<LoRaWANUpdateGatewayTaskCreate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoRaWANUpdateGatewayTaskCreate requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCurrentVersion())
            {
                context.Writer.WritePropertyName("CurrentVersion");
                context.Writer.WriteObjectStart();

                var marshaller = LoRaWANGatewayVersionMarshaller.Instance;
                marshaller.Marshall(requestObject.CurrentVersion, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSigKeyCrc())
            {
                context.Writer.WritePropertyName("SigKeyCrc");
                context.Writer.Write(requestObject.SigKeyCrc);
            }

            if(requestObject.IsSetUpdateSignature())
            {
                context.Writer.WritePropertyName("UpdateSignature");
                context.Writer.Write(requestObject.UpdateSignature);
            }

            if(requestObject.IsSetUpdateVersion())
            {
                context.Writer.WritePropertyName("UpdateVersion");
                context.Writer.WriteObjectStart();

                var marshaller = LoRaWANGatewayVersionMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateVersion, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static LoRaWANUpdateGatewayTaskCreateMarshaller Instance = new LoRaWANUpdateGatewayTaskCreateMarshaller();

    }
}