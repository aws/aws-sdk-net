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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LocationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LocationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LteCellDetails Marshaller
    /// </summary>
    public class LteCellDetailsMarshaller : IRequestMarshaller<LteCellDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LteCellDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCellId())
            {
                context.Writer.WritePropertyName("CellId");
                context.Writer.Write(requestObject.CellId);
            }

            if(requestObject.IsSetLocalId())
            {
                context.Writer.WritePropertyName("LocalId");
                context.Writer.WriteObjectStart();

                var marshaller = LteLocalIdMarshaller.Instance;
                marshaller.Marshall(requestObject.LocalId, context);

                context.Writer.WriteObjectEnd();
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

            if(requestObject.IsSetNetworkMeasurements())
            {
                context.Writer.WritePropertyName("NetworkMeasurements");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetworkMeasurementsListValue in requestObject.NetworkMeasurements)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = LteNetworkMeasurementsMarshaller.Instance;
                    marshaller.Marshall(requestObjectNetworkMeasurementsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetNrCapable())
            {
                context.Writer.WritePropertyName("NrCapable");
                context.Writer.Write(requestObject.NrCapable);
            }

            if(requestObject.IsSetRsrp())
            {
                context.Writer.WritePropertyName("Rsrp");
                context.Writer.Write(requestObject.Rsrp);
            }

            if(requestObject.IsSetRsrq())
            {
                context.Writer.WritePropertyName("Rsrq");
                if(StringUtils.IsSpecialFloatValue(requestObject.Rsrq))
                {
                    context.Writer.Write(StringUtils.FromSpecialFloatValue(requestObject.Rsrq));
                }
                else
                {
                    context.Writer.Write(requestObject.Rsrq);
                }
            }

            if(requestObject.IsSetTac())
            {
                context.Writer.WritePropertyName("Tac");
                context.Writer.Write(requestObject.Tac);
            }

            if(requestObject.IsSetTimingAdvance())
            {
                context.Writer.WritePropertyName("TimingAdvance");
                context.Writer.Write(requestObject.TimingAdvance);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LteCellDetailsMarshaller Instance = new LteCellDetailsMarshaller();

    }
}