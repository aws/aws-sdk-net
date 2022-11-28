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
    /// CdmaObj Marshaller
    /// </summary>
    public class CdmaObjMarshaller : IRequestMarshaller<CdmaObj, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CdmaObj requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBaseLat())
            {
                context.Writer.WritePropertyName("BaseLat");
                context.Writer.Write(requestObject.BaseLat);
            }

            if(requestObject.IsSetBaseLng())
            {
                context.Writer.WritePropertyName("BaseLng");
                context.Writer.Write(requestObject.BaseLng);
            }

            if(requestObject.IsSetBaseStationId())
            {
                context.Writer.WritePropertyName("BaseStationId");
                context.Writer.Write(requestObject.BaseStationId);
            }

            if(requestObject.IsSetCdmaLocalId())
            {
                context.Writer.WritePropertyName("CdmaLocalId");
                context.Writer.WriteObjectStart();

                var marshaller = CdmaLocalIdMarshaller.Instance;
                marshaller.Marshall(requestObject.CdmaLocalId, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCdmaNmr())
            {
                context.Writer.WritePropertyName("CdmaNmr");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCdmaNmrListValue in requestObject.CdmaNmr)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = CdmaNmrObjMarshaller.Instance;
                    marshaller.Marshall(requestObjectCdmaNmrListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNetworkId())
            {
                context.Writer.WritePropertyName("NetworkId");
                context.Writer.Write(requestObject.NetworkId);
            }

            if(requestObject.IsSetPilotPower())
            {
                context.Writer.WritePropertyName("PilotPower");
                context.Writer.Write(requestObject.PilotPower);
            }

            if(requestObject.IsSetRegistrationZone())
            {
                context.Writer.WritePropertyName("RegistrationZone");
                context.Writer.Write(requestObject.RegistrationZone);
            }

            if(requestObject.IsSetSystemId())
            {
                context.Writer.WritePropertyName("SystemId");
                context.Writer.Write(requestObject.SystemId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CdmaObjMarshaller Instance = new CdmaObjMarshaller();

    }
}