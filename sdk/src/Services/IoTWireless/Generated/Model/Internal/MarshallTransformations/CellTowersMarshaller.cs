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
    /// CellTowers Marshaller
    /// </summary>
    public class CellTowersMarshaller : IRequestMarshaller<CellTowers, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CellTowers requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCdma())
            {
                context.Writer.WritePropertyName("Cdma");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCdmaListValue in requestObject.Cdma)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CdmaObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectCdmaListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetGsm())
            {
                context.Writer.WritePropertyName("Gsm");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGsmListValue in requestObject.Gsm)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GsmObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectGsmListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetLte())
            {
                context.Writer.WritePropertyName("Lte");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLteListValue in requestObject.Lte)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LteObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectLteListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTdscdma())
            {
                context.Writer.WritePropertyName("Tdscdma");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTdscdmaListValue in requestObject.Tdscdma)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TdscdmaObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectTdscdmaListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetWcdma())
            {
                context.Writer.WritePropertyName("Wcdma");
                context.Writer.WriteStartArray();
                foreach(var requestObjectWcdmaListValue in requestObject.Wcdma)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = WcdmaObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectWcdmaListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CellTowersMarshaller Instance = new CellTowersMarshaller();

    }
}