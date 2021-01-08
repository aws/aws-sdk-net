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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VirtualGatewayListener Object
    /// </summary>  
    public class VirtualGatewayListenerUnmarshaller : IUnmarshaller<VirtualGatewayListener, XmlUnmarshallerContext>, IUnmarshaller<VirtualGatewayListener, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        VirtualGatewayListener IUnmarshaller<VirtualGatewayListener, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public VirtualGatewayListener Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            VirtualGatewayListener unmarshalledObject = new VirtualGatewayListener();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("connectionPool", targetDepth))
                {
                    var unmarshaller = VirtualGatewayConnectionPoolUnmarshaller.Instance;
                    unmarshalledObject.ConnectionPool = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("healthCheck", targetDepth))
                {
                    var unmarshaller = VirtualGatewayHealthCheckPolicyUnmarshaller.Instance;
                    unmarshalledObject.HealthCheck = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("portMapping", targetDepth))
                {
                    var unmarshaller = VirtualGatewayPortMappingUnmarshaller.Instance;
                    unmarshalledObject.PortMapping = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tls", targetDepth))
                {
                    var unmarshaller = VirtualGatewayListenerTlsUnmarshaller.Instance;
                    unmarshalledObject.Tls = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static VirtualGatewayListenerUnmarshaller _instance = new VirtualGatewayListenerUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VirtualGatewayListenerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}