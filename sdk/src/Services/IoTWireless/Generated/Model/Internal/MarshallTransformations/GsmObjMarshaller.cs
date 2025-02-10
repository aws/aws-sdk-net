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
    /// GsmObj Marshaller
    /// </summary>
    public class GsmObjMarshaller : IRequestMarshaller<GsmObj, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GsmObj requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGeranCid())
            {
                context.Writer.WritePropertyName("GeranCid");
                context.Writer.WriteNumberValue(requestObject.GeranCid.Value);
            }

            if(requestObject.IsSetGsmLocalId())
            {
                context.Writer.WritePropertyName("GsmLocalId");
                context.Writer.WriteStartObject();

                var marshaller = GsmLocalIdMarshaller.Instance;
                marshaller.Marshall(requestObject.GsmLocalId, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGsmNmr())
            {
                context.Writer.WritePropertyName("GsmNmr");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGsmNmrListValue in requestObject.GsmNmr)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GsmNmrObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectGsmNmrListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGsmTimingAdvance())
            {
                context.Writer.WritePropertyName("GsmTimingAdvance");
                context.Writer.WriteNumberValue(requestObject.GsmTimingAdvance.Value);
            }

            if(requestObject.IsSetLac())
            {
                context.Writer.WritePropertyName("Lac");
                context.Writer.WriteNumberValue(requestObject.Lac.Value);
            }

            if(requestObject.IsSetMcc())
            {
                context.Writer.WritePropertyName("Mcc");
                context.Writer.WriteNumberValue(requestObject.Mcc.Value);
            }

            if(requestObject.IsSetMnc())
            {
                context.Writer.WritePropertyName("Mnc");
                context.Writer.WriteNumberValue(requestObject.Mnc.Value);
            }

            if(requestObject.IsSetRxLevel())
            {
                context.Writer.WritePropertyName("RxLevel");
                context.Writer.WriteNumberValue(requestObject.RxLevel.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GsmObjMarshaller Instance = new GsmObjMarshaller();

    }
}