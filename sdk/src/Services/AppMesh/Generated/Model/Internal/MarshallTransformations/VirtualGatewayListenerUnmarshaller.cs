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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for VirtualGatewayListener Object
    /// </summary>  
    public class VirtualGatewayListenerUnmarshaller : IJsonUnmarshaller<VirtualGatewayListener, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public VirtualGatewayListener Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            VirtualGatewayListener unmarshalledObject = new VirtualGatewayListener();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("connectionPool", targetDepth))
                {
                    var unmarshaller = VirtualGatewayConnectionPoolUnmarshaller.Instance;
                    unmarshalledObject.ConnectionPool = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("healthCheck", targetDepth))
                {
                    var unmarshaller = VirtualGatewayHealthCheckPolicyUnmarshaller.Instance;
                    unmarshalledObject.HealthCheck = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("portMapping", targetDepth))
                {
                    var unmarshaller = VirtualGatewayPortMappingUnmarshaller.Instance;
                    unmarshalledObject.PortMapping = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tls", targetDepth))
                {
                    var unmarshaller = VirtualGatewayListenerTlsUnmarshaller.Instance;
                    unmarshalledObject.Tls = unmarshaller.Unmarshall(context, ref reader);
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