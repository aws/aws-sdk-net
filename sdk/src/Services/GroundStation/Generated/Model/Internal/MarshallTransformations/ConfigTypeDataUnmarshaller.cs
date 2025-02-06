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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ConfigTypeData Object
    /// </summary>  
    public class ConfigTypeDataUnmarshaller : IJsonUnmarshaller<ConfigTypeData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ConfigTypeData Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ConfigTypeData unmarshalledObject = new ConfigTypeData();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("antennaDownlinkConfig", targetDepth))
                {
                    var unmarshaller = AntennaDownlinkConfigUnmarshaller.Instance;
                    unmarshalledObject.AntennaDownlinkConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("antennaDownlinkDemodDecodeConfig", targetDepth))
                {
                    var unmarshaller = AntennaDownlinkDemodDecodeConfigUnmarshaller.Instance;
                    unmarshalledObject.AntennaDownlinkDemodDecodeConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("antennaUplinkConfig", targetDepth))
                {
                    var unmarshaller = AntennaUplinkConfigUnmarshaller.Instance;
                    unmarshalledObject.AntennaUplinkConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataflowEndpointConfig", targetDepth))
                {
                    var unmarshaller = DataflowEndpointConfigUnmarshaller.Instance;
                    unmarshalledObject.DataflowEndpointConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("s3RecordingConfig", targetDepth))
                {
                    var unmarshaller = S3RecordingConfigUnmarshaller.Instance;
                    unmarshalledObject.S3RecordingConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("trackingConfig", targetDepth))
                {
                    var unmarshaller = TrackingConfigUnmarshaller.Instance;
                    unmarshalledObject.TrackingConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("uplinkEchoConfig", targetDepth))
                {
                    var unmarshaller = UplinkEchoConfigUnmarshaller.Instance;
                    unmarshalledObject.UplinkEchoConfig = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ConfigTypeDataUnmarshaller _instance = new ConfigTypeDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ConfigTypeDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}