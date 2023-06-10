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
    /// LoRaWANGateway Marshaller
    /// </summary>
    public class LoRaWANGatewayMarshaller : IRequestMarshaller<LoRaWANGateway, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoRaWANGateway requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBeaconing())
            {
                context.Writer.WritePropertyName("Beaconing");
                context.Writer.WriteObjectStart();

                var marshaller = BeaconingMarshaller.Instance;
                marshaller.Marshall(requestObject.Beaconing, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGatewayEui())
            {
                context.Writer.WritePropertyName("GatewayEui");
                context.Writer.Write(requestObject.GatewayEui);
            }

            if(requestObject.IsSetJoinEuiFilters())
            {
                context.Writer.WritePropertyName("JoinEuiFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectJoinEuiFiltersListValue in requestObject.JoinEuiFilters)
                {
                    context.Writer.WriteArrayStart();
                    foreach(var requestObjectJoinEuiFiltersListValueListValue in requestObjectJoinEuiFiltersListValue)
                    {
                            context.Writer.Write(requestObjectJoinEuiFiltersListValueListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetMaxEirp())
            {
                context.Writer.WritePropertyName("MaxEirp");
                context.Writer.Write(requestObject.MaxEirp);
            }

            if(requestObject.IsSetNetIdFilters())
            {
                context.Writer.WritePropertyName("NetIdFilters");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectNetIdFiltersListValue in requestObject.NetIdFilters)
                {
                        context.Writer.Write(requestObjectNetIdFiltersListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRfRegion())
            {
                context.Writer.WritePropertyName("RfRegion");
                context.Writer.Write(requestObject.RfRegion);
            }

            if(requestObject.IsSetSubBands())
            {
                context.Writer.WritePropertyName("SubBands");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSubBandsListValue in requestObject.SubBands)
                {
                        context.Writer.Write(requestObjectSubBandsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LoRaWANGatewayMarshaller Instance = new LoRaWANGatewayMarshaller();

    }
}