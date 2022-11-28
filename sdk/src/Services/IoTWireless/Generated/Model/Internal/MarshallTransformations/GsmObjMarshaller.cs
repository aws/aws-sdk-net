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
            if(requestObject.IsSetGeranCid())
            {
                context.Writer.WritePropertyName("GeranCid");
                context.Writer.Write(requestObject.GeranCid);
            }

            if(requestObject.IsSetGsmLocalId())
            {
                context.Writer.WritePropertyName("GsmLocalId");
                context.Writer.WriteObjectStart();

                var marshaller = GsmLocalIdMarshaller.Instance;
                marshaller.Marshall(requestObject.GsmLocalId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGsmNmr())
            {
                context.Writer.WritePropertyName("GsmNmr");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectGsmNmrListValue in requestObject.GsmNmr)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = GsmNmrObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectGsmNmrListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetGsmTimingAdvance())
            {
                context.Writer.WritePropertyName("GsmTimingAdvance");
                context.Writer.Write(requestObject.GsmTimingAdvance);
            }

            if(requestObject.IsSetLac())
            {
                context.Writer.WritePropertyName("Lac");
                context.Writer.Write(requestObject.Lac);
            }

            if(requestObject.IsSetMcc())
            {
                context.Writer.WritePropertyName("Mcc");
                context.Writer.Write(requestObject.Mcc);
            }

            if(requestObject.IsSetMnc())
            {
                context.Writer.WritePropertyName("Mnc");
                context.Writer.Write(requestObject.Mnc);
            }

            if(requestObject.IsSetRxLevel())
            {
                context.Writer.WritePropertyName("RxLevel");
                context.Writer.Write(requestObject.RxLevel);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GsmObjMarshaller Instance = new GsmObjMarshaller();

    }
}