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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkInterface Object
    /// </summary>  
    public class NetworkInterfaceUnmarshaller : IUnmarshaller<NetworkInterface, XmlUnmarshallerContext>, IUnmarshaller<NetworkInterface, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        NetworkInterface IUnmarshaller<NetworkInterface, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public NetworkInterface Unmarshall(JsonUnmarshallerContext context)
        {
            NetworkInterface unmarshalledObject = new NetworkInterface();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("canInterface", targetDepth))
                {
                    var unmarshaller = CanInterfaceUnmarshaller.Instance;
                    unmarshalledObject.CanInterface = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("customDecodingInterface", targetDepth))
                {
                    var unmarshaller = CustomDecodingInterfaceUnmarshaller.Instance;
                    unmarshalledObject.CustomDecodingInterface = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("interfaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InterfaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("obdInterface", targetDepth))
                {
                    var unmarshaller = ObdInterfaceUnmarshaller.Instance;
                    unmarshalledObject.ObdInterface = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vehicleMiddleware", targetDepth))
                {
                    var unmarshaller = VehicleMiddlewareUnmarshaller.Instance;
                    unmarshalledObject.VehicleMiddleware = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static NetworkInterfaceUnmarshaller _instance = new NetworkInterfaceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkInterfaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}