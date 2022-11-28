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
    /// WcdmaObj Marshaller
    /// </summary>
    public class WcdmaObjMarshaller : IRequestMarshaller<WcdmaObj, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(WcdmaObj requestObject, JsonMarshallerContext context)
        {
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

            if(requestObject.IsSetPathLoss())
            {
                context.Writer.WritePropertyName("PathLoss");
                context.Writer.Write(requestObject.PathLoss);
            }

            if(requestObject.IsSetRscp())
            {
                context.Writer.WritePropertyName("Rscp");
                context.Writer.Write(requestObject.Rscp);
            }

            if(requestObject.IsSetUtranCid())
            {
                context.Writer.WritePropertyName("UtranCid");
                context.Writer.Write(requestObject.UtranCid);
            }

            if(requestObject.IsSetWcdmaLocalId())
            {
                context.Writer.WritePropertyName("WcdmaLocalId");
                context.Writer.WriteObjectStart();

                var marshaller = WcdmaLocalIdMarshaller.Instance;
                marshaller.Marshall(requestObject.WcdmaLocalId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWcdmaNmr())
            {
                context.Writer.WritePropertyName("WcdmaNmr");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectWcdmaNmrListValue in requestObject.WcdmaNmr)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = WcdmaNmrObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectWcdmaNmrListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static WcdmaObjMarshaller Instance = new WcdmaObjMarshaller();

    }
}