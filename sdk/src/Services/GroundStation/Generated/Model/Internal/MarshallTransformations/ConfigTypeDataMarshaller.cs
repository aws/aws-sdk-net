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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConfigTypeData Marshaller
    /// </summary>       
    public class ConfigTypeDataMarshaller : IRequestMarshaller<ConfigTypeData, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConfigTypeData requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAntennaDownlinkConfig())
            {
                context.Writer.WritePropertyName("antennaDownlinkConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AntennaDownlinkConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AntennaDownlinkConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAntennaDownlinkDemodDecodeConfig())
            {
                context.Writer.WritePropertyName("antennaDownlinkDemodDecodeConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AntennaDownlinkDemodDecodeConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AntennaDownlinkDemodDecodeConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAntennaUplinkConfig())
            {
                context.Writer.WritePropertyName("antennaUplinkConfig");
                context.Writer.WriteObjectStart();

                var marshaller = AntennaUplinkConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.AntennaUplinkConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDataflowEndpointConfig())
            {
                context.Writer.WritePropertyName("dataflowEndpointConfig");
                context.Writer.WriteObjectStart();

                var marshaller = DataflowEndpointConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DataflowEndpointConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetTrackingConfig())
            {
                context.Writer.WritePropertyName("trackingConfig");
                context.Writer.WriteObjectStart();

                var marshaller = TrackingConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TrackingConfig, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUplinkEchoConfig())
            {
                context.Writer.WritePropertyName("uplinkEchoConfig");
                context.Writer.WriteObjectStart();

                var marshaller = UplinkEchoConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.UplinkEchoConfig, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ConfigTypeDataMarshaller Instance = new ConfigTypeDataMarshaller();

    }
}