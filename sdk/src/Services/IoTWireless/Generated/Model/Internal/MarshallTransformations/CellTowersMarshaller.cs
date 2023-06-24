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
            if(requestObject.IsSetCdma())
            {
                context.Writer.WritePropertyName("Cdma");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCdmaListValue in requestObject.Cdma)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CdmaObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectCdmaListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetGsm())
            {
                context.Writer.WritePropertyName("Gsm");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectGsmListValue in requestObject.Gsm)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = GsmObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectGsmListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLte())
            {
                context.Writer.WritePropertyName("Lte");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLteListValue in requestObject.Lte)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = LteObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectLteListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTdscdma())
            {
                context.Writer.WritePropertyName("Tdscdma");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectTdscdmaListValue in requestObject.Tdscdma)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = TdscdmaObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectTdscdmaListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetWcdma())
            {
                context.Writer.WritePropertyName("Wcdma");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectWcdmaListValue in requestObject.Wcdma)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = WcdmaObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectWcdmaListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CellTowersMarshaller Instance = new CellTowersMarshaller();

    }
}