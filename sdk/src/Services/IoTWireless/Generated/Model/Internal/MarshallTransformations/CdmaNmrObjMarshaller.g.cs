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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.IoTWireless.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CdmaNmrObj Marshaller
    /// </summary>
    public partial class CdmaNmrObjMarshaller : IRequestMarshaller<CdmaNmrObj, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(CdmaNmrObj requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetBaseStationId())
            {
                context.Writer.WritePropertyName("BaseStationId");
                context.Writer.WriteNumberValue(requestObject.BaseStationId.Value);
            }

            if (requestObject.IsSetCdmaChannel())
            {
                context.Writer.WritePropertyName("CdmaChannel");
                context.Writer.WriteNumberValue(requestObject.CdmaChannel.Value);
            }

            if (requestObject.IsSetPilotPower())
            {
                context.Writer.WritePropertyName("PilotPower");
                context.Writer.WriteNumberValue(requestObject.PilotPower.Value);
            }

            if (requestObject.IsSetPnOffset())
            {
                context.Writer.WritePropertyName("PnOffset");
                context.Writer.WriteNumberValue(requestObject.PnOffset.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static CdmaNmrObjMarshaller Instance = new CdmaNmrObjMarshaller();
    }
}
