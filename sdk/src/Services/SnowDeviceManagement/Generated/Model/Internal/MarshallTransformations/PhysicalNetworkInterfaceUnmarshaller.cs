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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SnowDeviceManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SnowDeviceManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PhysicalNetworkInterface Object
    /// </summary>  
    public class PhysicalNetworkInterfaceUnmarshaller : IUnmarshaller<PhysicalNetworkInterface, XmlUnmarshallerContext>, IUnmarshaller<PhysicalNetworkInterface, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PhysicalNetworkInterface IUnmarshaller<PhysicalNetworkInterface, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PhysicalNetworkInterface Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            PhysicalNetworkInterface unmarshalledObject = new PhysicalNetworkInterface();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("defaultGateway", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultGateway = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ipAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ipAddressAssignment", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IpAddressAssignment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("macAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MacAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("netmask", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Netmask = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("physicalConnectorType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhysicalConnectorType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("physicalNetworkInterfaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PhysicalNetworkInterfaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static PhysicalNetworkInterfaceUnmarshaller _instance = new PhysicalNetworkInterfaceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PhysicalNetworkInterfaceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}