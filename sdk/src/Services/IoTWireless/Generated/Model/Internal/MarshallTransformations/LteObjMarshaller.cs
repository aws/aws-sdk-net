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
    /// LteObj Marshaller
    /// </summary>
    public class LteObjMarshaller : IRequestMarshaller<LteObj, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LteObj requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEutranCid())
            {
                context.Writer.WritePropertyName("EutranCid");
                context.Writer.WriteNumberValue(requestObject.EutranCid.Value);
            }

            if(requestObject.IsSetLteLocalId())
            {
                context.Writer.WritePropertyName("LteLocalId");
                context.Writer.WriteStartObject();

                var marshaller = LteLocalIdMarshaller.Instance;
                marshaller.Marshall(requestObject.LteLocalId, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLteNmr())
            {
                context.Writer.WritePropertyName("LteNmr");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLteNmrListValue in requestObject.LteNmr)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LteNmrObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectLteNmrListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLteTimingAdvance())
            {
                context.Writer.WritePropertyName("LteTimingAdvance");
                context.Writer.WriteNumberValue(requestObject.LteTimingAdvance.Value);
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

            if(requestObject.IsSetNrCapable())
            {
                context.Writer.WritePropertyName("NrCapable");
                context.Writer.WriteBooleanValue(requestObject.NrCapable.Value);
            }

            if(requestObject.IsSetRsrp())
            {
                context.Writer.WritePropertyName("Rsrp");
                context.Writer.WriteNumberValue(requestObject.Rsrp.Value);
            }

            if(requestObject.IsSetRsrq())
            {
                context.Writer.WritePropertyName("Rsrq");
                if(StringUtils.IsSpecialFloatValue(requestObject.Rsrq.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(requestObject.Rsrq.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Rsrq.Value);
                }
            }

            if(requestObject.IsSetTac())
            {
                context.Writer.WritePropertyName("Tac");
                context.Writer.WriteNumberValue(requestObject.Tac.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LteObjMarshaller Instance = new LteObjMarshaller();

    }
}